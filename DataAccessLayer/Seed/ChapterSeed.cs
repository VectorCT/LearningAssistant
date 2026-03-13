using DataAccessLayer.Models;

namespace DataAccessLayer.Seed;

public static class ChapterSeed
{
    public static List<Chapter> GetChapters()
    {
    return
        [
            new Chapter { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), ChapterNumber = 1, ChapterTitle = "Introduction to Technology", Description = "An overview: this chapter is an introduction to technology and its key concepts.", SubjectId = Guid.Parse("5a5da2f4-f649-4994-95b1-228b82e9d98c"), TermId = Guid.Parse("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
            new Chapter { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), ChapterNumber = 2, ChapterTitle = "Cell Structure", Description = "Understanding the building blocks of life.", SubjectId = Guid.Parse("5a5da2f4-f649-4994-95b1-228b82e9d98c"), TermId = Guid.Parse("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
            new Chapter { Id = Guid.Parse("33333333-3333-3333-3333-333333333333"), ChapterNumber = 3, ChapterTitle = "Genetics", Description = "Introduction to genetics.", SubjectId = Guid.Parse("5a5da2f4-f649-4994-95b1-228b82e9d98c"), TermId = Guid.Parse("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
            new Chapter { Id = Guid.Parse("44444444-4444-4444-4444-444444444444"), ChapterNumber = 4, ChapterTitle = "Evolution", Description = "Theory of evolution.", SubjectId = Guid.Parse("5a5da2f4-f649-4994-95b1-228b82e9d98c"), TermId = Guid.Parse("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
            new Chapter { Id = Guid.Parse("55555555-5555-5555-5555-555555555555"), ChapterNumber = 5, ChapterTitle = "Ecology", Description = "Ecosystems and environment.", SubjectId = Guid.Parse("5a5da2f4-f649-4994-95b1-228b82e9d98c"), TermId = Guid.Parse("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
            new Chapter { Id = Guid.Parse("66666666-6666-6666-6666-666666666666"), ChapterNumber = 6, ChapterTitle = "Human Body", Description = "Human anatomy and physiology.", SubjectId = Guid.Parse("5a5da2f4-f649-4994-95b1-228b82e9d98c"), TermId = Guid.Parse("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
            new Chapter { Id = Guid.Parse("77777777-7777-7777-7777-777777777777"), ChapterNumber = 7, ChapterTitle = "Plant Biology", Description = "Plant structure and function.", SubjectId = Guid.Parse("5a5da2f4-f649-4994-95b1-228b82e9d98c"), TermId = Guid.Parse("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
            new Chapter { Id = Guid.Parse("88888888-8888-8888-8888-888888888888"), ChapterNumber = 8, ChapterTitle = "Microbiology", Description = "Microorganisms and their roles.", SubjectId = Guid.Parse("5a5da2f4-f649-4994-95b1-228b82e9d98c"), TermId = Guid.Parse("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
            new Chapter { Id = Guid.Parse("99999999-9999-9999-9999-999999999999"), ChapterNumber = 9, ChapterTitle = "Biotechnology", Description = "Applications of biology.", SubjectId = Guid.Parse("5a5da2f4-f649-4994-95b1-228b82e9d98c"), TermId = Guid.Parse("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
            new Chapter { Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), ChapterNumber = 10, ChapterTitle = "Conservation", Description = "Conservation of biodiversity.", SubjectId = Guid.Parse("5a5da2f4-f649-4994-95b1-228b82e9d98c"), TermId = Guid.Parse("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") }
        ];
    }
}