using DataAccessLayer.Context;
using LearnerAssistant.Services;
using LearnerAssistant.Services.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Services.Interfaces;
using System.Reflection;
using System.Text.Json.Serialization;
using LearnerAssistant.Data;

const string CorsPolicy = "ALLOWOPTIONS";

var builder = WebApplication.CreateBuilder(args);

builder
    .Services
    .AddCors(c => c.AddPolicy(
        CorsPolicy,
        builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            .WithExposedHeaders("Content-Disposition")));

// Add services to the container.
builder.Services.AddScoped<ISubjectsService, SubjectsService>();
builder.Services.AddScoped<IGradesService, GradesService>();
builder.Services.AddScoped<IGradeSubjectsService, GradeSubjectsService>();
builder.Services.AddScoped<IPastPapersService, PastPapersService>();
builder.Services.AddScoped<IPastMemorandumService, PastMemorandumService>();
builder.Services.AddScoped<IChapterService, ChapterService>();
builder.Services.AddScoped<IChapterSectionService, ChapterSectionService>();
builder.Services.AddScoped<IForumService, ForumService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IUserReactionService, UserReactionService>();
builder.Services.AddScoped<IQuestionService, QuestionService>();
builder.Services.AddScoped<IAnswerService, AnswerService>();
builder.Services.AddScoped<IQuizService, QuizService>();
builder.Services.AddScoped<IVideoTutorialService, VideoTutorialService>();

builder.Services.AddDbContext<ApplicationDbContext>(
    options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("ApplicationDb"),
            b => b.EnableRetryOnFailure(10, TimeSpan.FromSeconds(1), null)));

builder.Services.AddControllers()
  .AddJsonOptions(o =>
  {
    // Prevent JSON serializer from throwing on cycles between navigation properties
    o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    o.JsonSerializerOptions.MaxDepth = 64;
  });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
  var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
  var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
  c.IncludeXmlComments(xmlPath);

  c.SwaggerDoc("v1", new OpenApiInfo { Title = "Learner Assistant API", Version = "v1" });

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
app.Use(async (context, next) =>
{
  if (context.Request.Headers.TryGetValue(
      "X-Forwarded-Prefix",
      out Microsoft.Extensions.Primitives.StringValues value))
  {
    context.Request.PathBase = value[0];
    context.Request.IsHttps = true;
  }

  if (context.Request.Path == "/")
  {
    context.Response.Redirect("/swagger");
  }
  else
  {
    await next();
  }
});

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("v1/swagger.json", "Learner Assistant Api"));
app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(CorsPolicy);
app.MapControllers();

// Apply EF Core migrations automatically on startup with retry
using var scope = app.Services.CreateScope();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
var maxAttempts = 3;
for (var attempt = 1; attempt <= maxAttempts; attempt++)
{
    try
    {
        logger.LogInformation("Applying database migrations (attempt {Attempt})...", attempt);
        await dbContext.Database.MigrateAsync();
        logger.LogInformation("Database migrations applied successfully.");
        break;
    }
    catch (Exception ex)
    {
        logger.LogWarning(ex, "Database migration attempt {Attempt} failed.", attempt);
        if (attempt == maxAttempts)
        {
            logger.LogError(ex, "All migration attempts failed. Application will continue, but DB schema may be inconsistent.");
            throw; // rethrow to make failure explicit
        }
        await Task.Delay(TimeSpan.FromSeconds(2 * attempt));
    }
}

//// Seed mock users, forums, comments and reactions only in Development
//if (app.Environment.IsDevelopment())
//{
//  // users
//  var mockUsers = MockData.GetUsers();
//  foreach (var u in mockUsers)
//  {
//    if (!await dbContext.Users.AnyAsync(x => x.Id == u.Id))
//    {
//      dbContext.Users.Add(u);
//    }
//  }

//  // forums
//  var mockForums = MockData.GetForums();
//  foreach (var f in mockForums)
//  {
//    if (!await dbContext.Forums.AnyAsync(x => x.Id == f.Id))
//    {
//      dbContext.Forums.Add(f);
//    }
//  }

//  // comments
//  var mockComments = MockData.GetComments();
//  foreach (var c in mockComments)
//  {
//    if (!await dbContext.Comments.AnyAsync(x => x.Id == c.Id))
//    {
//      dbContext.Comments.Add(c);
//    }
//  }

//  // reactions
//  var mockReactions = MockData.GetUserReactions();
//  foreach (var r in mockReactions)
//  {
//    if (!await dbContext.UserReactions.AnyAsync(x => x.Id == r.Id))
//    {
//      dbContext.UserReactions.Add(r);
//    }
//  }

//  await dbContext.SaveChangesAsync();
//}

app.Run();
