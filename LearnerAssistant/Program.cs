using DataAccessLayer.Context;
using LearnerAssistant.Services;
using LearnerAssistant.Services.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

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
builder.Services.AddDbContext<ApplicationDbContext>(
    options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("ApplicationDb"),
            b => b.EnableRetryOnFailure(10, TimeSpan.FromSeconds(1), null)));

builder.Services.AddControllers();
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

using var scope = app.Services.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
await dbContext.Database.MigrateAsync();

app.Run();
