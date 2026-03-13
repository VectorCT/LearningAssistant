using DataAccessLayer.Models;
using DataAccessLayer.Models.Enums;

namespace DataAccessLayer.Seed;

public static class ChapterSectionSeed
{
    public static List<ChapterSection> GetChapterSections()
    {
        return
        [
            new ChapterSection { Id = Guid.Parse("a1a1a1a1-a1a1-a1a1-a1a1-a1a1a1a1a1a1"), ChapterId = Guid.Parse("11111111-1111-1111-1111-111111111111"), Type = SectionType.Title, Content = "What is Technology?", Order = 1, ParentSectionId = null },
            new ChapterSection { Id = Guid.Parse("a2a2a2a2-a2a2-a2a2-a2a2-a2a2a2a2a2a2"), ChapterId = Guid.Parse("11111111-1111-1111-1111-111111111111"), Type = SectionType.Paragraph, Content = "Technology is the application of scientific knowledge for practical purposes, including tools, machines, and systems.", Order = 2, ParentSectionId = Guid.Parse("a1a1a1a1-a1a1-a1a1-a1a1-a1a1a1a1a1a1") },
            new ChapterSection { Id = Guid.Parse("a3a3a3a3-a3a3-a3a3-a3a3-a3a3a3a3a3a3"), ChapterId = Guid.Parse("22222222-2222-2222-2222-222222222222"), Type = SectionType.Title, Content = "Cell Structure Overview", Order = 1, ParentSectionId = null },
            new ChapterSection { Id = Guid.Parse("a4a4a4a4-a4a4-a4a4-a4a4-a4a4a4a4a4a4"), ChapterId = Guid.Parse("22222222-2222-2222-2222-222222222222"), Type = SectionType.Paragraph, Content = "Cells are the basic units of life.", Order = 2, ParentSectionId = Guid.Parse("a3a3a3a3-a3a3-a3a3-a3a3-a3a3a3a3a3a3") },
            new ChapterSection { Id = Guid.Parse("a5a5a5a5-a5a5-a5a5-a5a5-a5a5a5a5a5a5"), ChapterId = Guid.Parse("33333333-3333-3333-3333-333333333333"), Type = SectionType.Title, Content = "Introduction to Genetics", Order = 1, ParentSectionId = null },
            new ChapterSection { Id = Guid.Parse("a6a6a6a6-a6a6-a6a6-a6a6-a6a6a6a6a6a6"), ChapterId = Guid.Parse("33333333-3333-3333-3333-333333333333"), Type = SectionType.Paragraph, Content = "Genes are units of heredity.", Order = 2, ParentSectionId = Guid.Parse("a5a5a5a5-a5a5-a5a5-a5a5-a5a5a5a5a5a5") },
            new ChapterSection { Id = Guid.Parse("a7a7a7a7-a7a7-a7a7-a7a7-a7a7a7a7a7a7"), ChapterId = Guid.Parse("44444444-4444-4444-4444-444444444444"), Type = SectionType.Title, Content = "Theory of Evolution", Order = 1, ParentSectionId = null },
            new ChapterSection { Id = Guid.Parse("a8a8a8a8-a8a8-a8a8-a8a8-a8a8a8a8a8a8"), ChapterId = Guid.Parse("44444444-4444-4444-4444-444444444444"), Type = SectionType.Paragraph, Content = "Evolution explains diversity.", Order = 2, ParentSectionId = Guid.Parse("a7a7a7a7-a7a7-a7a7-a7a7-a7a7a7a7a7a7") },
            new ChapterSection { Id = Guid.Parse("a9a9a9a9-a9a9-a9a9-a9a9-a9a9a9a9a9a9"), ChapterId = Guid.Parse("55555555-5555-5555-5555-555555555555"), Type = SectionType.Title, Content = "Ecosystems", Order = 1, ParentSectionId = null },
            new ChapterSection { Id = Guid.Parse("b1b1b1b1-b1b1-b1b1-b1b1-b1b1b1b1b1b1"), ChapterId = Guid.Parse("55555555-5555-5555-5555-555555555555"), Type = SectionType.Paragraph, Content = "Ecosystems are communities of organisms.", Order = 2, ParentSectionId = Guid.Parse("a9a9a9a9-a9a9-a9a9-a9a9-a9a9a9a9a9a9") }
        ];
    }
}