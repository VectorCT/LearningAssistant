using System;
using System.Collections.Generic;
using DataAccessLayer.Models;

namespace LearnerAssistant.Data;

public static class MockData
{
  // Sample users: "user1", "user2", "user3"
  public static List<Comment> GetComments()
  {
    var comments = new List<Comment>
    {
      // Forum: 12592406-647b-4c68-bd06-0ad14a665077
      new Comment
      {
        Id = Guid.Parse("a1f9d2e0-1111-4b11-8a11-111111111111"),
        ForumId = Guid.Parse("12592406-647b-4c68-bd06-0ad14a665077"),
        UserId = "user1",
        CommentText = "I find factoring and quadratic equations the most common stumbling blocks.",
        ParentCommentId = null,
        Upvotes = 3,
        Likes = 1,
        CreatedAt = DateTime.Parse("2026-03-01T10:00:00")
      },

      new Comment
      {
        Id = Guid.Parse("b2f9d2e0-2222-4b22-8a22-222222222222"),
        ForumId = Guid.Parse("12592406-647b-4c68-bd06-0ad14a665077"),
        UserId = "user2",
        CommentText = "Also word problems and manipulating algebraic fractions.",
        ParentCommentId = null,
        Upvotes = 2,
        Likes = 0,
        CreatedAt = DateTime.Parse("2026-03-02T11:30:00")
      },

      // Reply to first comment
      new Comment
      {
        Id = Guid.Parse("c3f9d2e0-3333-4b33-8a33-333333333333"),
        ForumId = Guid.Parse("12592406-647b-4c68-bd06-0ad14a665077"),
        UserId = "user3",
        CommentText = "For quadratics I recommend practicing completing the square until the steps become familiar.",
        ParentCommentId = Guid.Parse("a1f9d2e0-1111-4b11-8a11-111111111111"),
        Upvotes = 1,
        Likes = 1,
        CreatedAt = DateTime.Parse("2026-03-02T12:00:00")
      },

      // Comments for forum 1a83b4fc-449b-4d73-8330-1393795a47e5
      new Comment
      {
        Id = Guid.Parse("d4f9d2e0-4444-4b44-8a44-444444444444"),
        ForumId = Guid.Parse("1a83b4fc-449b-4d73-8330-1393795a47e5"),
        UserId = "user1",
        CommentText = "Use -b/(2a) to get the x-coordinate of the vertex quickly.",
        ParentCommentId = null,
        Upvotes = 5,
        Likes = 2,
        CreatedAt = DateTime.Parse("2026-02-21T09:00:00")
      },

      new Comment
      {
        Id = Guid.Parse("e5f9d2e0-5555-4b55-8a55-555555555555"),
        ForumId = Guid.Parse("1a83b4fc-449b-4d73-8330-1393795a47e5"),
        UserId = "user2",
        CommentText = "Completing the square is useful but remembering the formula saves time.",
        ParentCommentId = Guid.Parse("d4f9d2e0-4444-4b44-8a44-444444444444"),
        Upvotes = 1,
        Likes = 0,
        CreatedAt = DateTime.Parse("2026-02-21T10:15:00")
      },

      // Comments for forum 9a666f6c-75c8-4bd1-8fa1-1efd0202a21d
      new Comment
      {
        Id = Guid.Parse("f6f9d2e0-6666-4b66-8a66-666666666666"),
        ForumId = Guid.Parse("9a666f6c-75c8-4bd1-8fa1-1efd0202a21d"),
        UserId = "user3",
        CommentText = "Start with free-body diagrams; they make Newton's laws intuitive.",
        ParentCommentId = null,
        Upvotes = 4,
        Likes = 2,
        CreatedAt = DateTime.Parse("2025-05-22T08:00:00")
      },

      // Additional seeded comments for various forums
      new Comment
      {
        Id = Guid.Parse("11111111-aaaa-4b11-8aaa-aaaaaaaaaaaa"),
        ForumId = Guid.Parse("d64b578b-90bc-4e97-bea3-23be05a902a8"),
        UserId = "user2",
        CommentText = "I like visual proofs for turning points — drawing the parabola helps.",
        ParentCommentId = null,
        Upvotes = 2,
        Likes = 1,
        CreatedAt = DateTime.Parse("2026-02-20T02:15:00")
      },

      new Comment
      {
        Id = Guid.Parse("22222222-bbbb-4b22-bbbb-bbbbbbbbbbbb"),
        ForumId = Guid.Parse("83a95744-6080-43de-aae5-35daef3dc3b1"),
        UserId = "user1",
        CommentText = "Try the 'Physics for Dummies' guide for a gentle start — lots of diagrams.",
        ParentCommentId = null,
        Upvotes = 3,
        Likes = 0,
        CreatedAt = DateTime.Parse("2025-06-01T09:30:00")
      },

      new Comment
      {
        Id = Guid.Parse("33333333-cccc-4b33-cccc-cccccccccccc"),
        ForumId = Guid.Parse("973770a4-bde8-49fa-b293-3fbc36b2aa17"),
        UserId = "user3",
        CommentText = "Product rule is for differentiating a product of functions; chain rule is for composition.",
        ParentCommentId = null,
        Upvotes = 4,
        Likes = 1,
        CreatedAt = DateTime.Parse("2026-02-18T01:00:00")
      },

      // Replies to new comments
      new Comment
      {
        Id = Guid.Parse("44444444-dddd-4b44-dddd-dddddddddddd"),
        ForumId = Guid.Parse("d64b578b-90bc-4e97-bea3-23be05a902a8"),
        UserId = "user1",
        CommentText = "Good tip — I also annotate the graph with roots and axis to visualise shifts.",
        ParentCommentId = Guid.Parse("11111111-aaaa-4b11-8aaa-aaaaaaaaaaaa"),
        Upvotes = 1,
        Likes = 0,
        CreatedAt = DateTime.Parse("2026-02-20T03:00:00")
      },

      new Comment
      {
        Id = Guid.Parse("55555555-eeee-4b55-eeee-eeeeeeeeeeee"),
        ForumId = Guid.Parse("83a95744-6080-43de-aae5-35daef3dc3b1"),
        UserId = "user2",
        CommentText = "Also check past exam papers linked in resources — they help target revision.",
        ParentCommentId = Guid.Parse("22222222-bbbb-4b22-bbbb-bbbbbbbbbbbb"),
        Upvotes = 2,
        Likes = 1,
        CreatedAt = DateTime.Parse("2025-06-01T10:00:00")
      }
    };

    return comments;
  }

  public static List<UserReaction> GetUserReactions()
  {
    var reactions = new List<UserReaction>
    {
      // Reactions to comments in forum 12592406...
      new UserReaction
      {
        Id = Guid.Parse("71f9d2e0-7777-4777-8777-777777777777"),
        UserId = "user2",
        CommentId = Guid.Parse("a1f9d2e0-1111-4b11-8a11-111111111111"),
        Upvote = true,
        Like = false
      },

      new UserReaction
      {
        Id = Guid.Parse("72f9d2e0-8888-4888-8888-888888888888"),
        UserId = "user3",
        CommentId = Guid.Parse("a1f9d2e0-1111-4b11-8a11-111111111111"),
        Upvote = false,
        Like = true
      },

      // Reaction to reply
      new UserReaction
      {
        Id = Guid.Parse("73f9d2e0-9999-4999-9999-999999999999"),
        UserId = "user1",
        CommentId = Guid.Parse("c3f9d2e0-3333-4b33-8a33-333333333333"),
        Upvote = true,
        Like = true
      },

      // Reactions for other forums
      new UserReaction
      {
        Id = Guid.Parse("74f9d2e0-aaaa-4aaa-8aaa-aaaaaaaaaaaa"),
        UserId = "user3",
        CommentId = Guid.Parse("d4f9d2e0-4444-4b44-8a44-444444444444"),
        Upvote = true,
        Like = false
      },

      // Additional reactions for newly seeded comments
      new UserReaction
      {
        Id = Guid.Parse("75f9d2e0-ffff-4fff-8fff-ffffffffffff"),
        UserId = "user1",
        CommentId = Guid.Parse("11111111-aaaa-4b11-8aaa-aaaaaaaaaaaa"),
        Upvote = true,
        Like = true
      },

      new UserReaction
      {
        Id = Guid.Parse("76f9d2e0-1212-4121-8121-121212121212"),
        UserId = "user3",
        CommentId = Guid.Parse("33333333-cccc-4b33-cccc-cccccccccccc"),
        Upvote = false,
        Like = true
      }
    };

    return reactions;
  }

  public static List<Forum> GetForums()
  {
    return new List<Forum>
    {
      new Forum
      {
        Id = Guid.Parse("12592406-647b-4c68-bd06-0ad14a665077"),
        Topic = "Difficult problems in Algebra",
        DiscussionQuestion = "What are common algebra problems students face?",
        Screenshot = null,
        CreatedAt = DateTime.Parse("2025-06-12T20:32:42.1633333"),
        SubjectId = Guid.Parse("3fe2283b-6751-4633-8903-2043997bbf20")
      },
      new Forum
      {
        Id = Guid.Parse("1a83b4fc-449b-4d73-8330-1393795a47e5"),
        Topic = "Turning Points and Axis of Symmetry",
        DiscussionQuestion = "Is there a quick way to find the turning point of a parabola without completing the square every time?",
        Screenshot = null,
        CreatedAt = DateTime.Parse("2026-02-20T01:07:07.51"),
        SubjectId = Guid.Parse("b2df6db3-2b38-4c3a-9517-5e3e2b98b741")
      },
      new Forum
      {
        Id = Guid.Parse("9a666f6c-75c8-4bd1-8fa1-1efd0202a21d"),
        Topic = "Physics Chapter 1",
        DiscussionQuestion = "How do we understand Newton’s Laws?",
        Screenshot = null,
        CreatedAt = DateTime.Parse("2025-05-21T09:21:04.8566667"),
        SubjectId = Guid.Parse("b2df6db3-2b38-4c3a-9517-5e3e2b98b741")
      },
      new Forum
      {
        Id = Guid.Parse("d64b578b-90bc-4e97-bea3-23be05a902a8"),
        Topic = "Turning Points and Axis of Symmetry",
        DiscussionQuestion = "Is there a quick way to find the turning point of a parabola without completing the square every time?",
        Screenshot = null,
        CreatedAt = DateTime.Parse("2026-02-20T00:51:14.0466667"),
        SubjectId = Guid.Parse("b2df6db3-2b38-4c3a-9517-5e3e2b98b741")
      },
      new Forum
      {
        Id = Guid.Parse("83a95744-6080-43de-aae5-35daef3dc3b1"),
        Topic = "Best study guides?",
        DiscussionQuestion = "What are the best study guides for exam preparation?",
        Screenshot = null,
        CreatedAt = DateTime.Parse("2025-05-21T09:21:04.8566667"),
        SubjectId = Guid.Parse("b2df6db3-2b38-4c3a-9517-5e3e2b98b741")
      },
      new Forum
      {
        Id = Guid.Parse("973770a4-bde8-49fa-b293-3fbc36b2aa17"),
        Topic = "Struggling with Product Rule",
        DiscussionQuestion = "Can someone explain when to use the product rule vs chain rule? I always get confused between them when solving derivatives.",
        Screenshot = null,
        CreatedAt = DateTime.Parse("2026-02-18T00:51:14.0433333"),
        SubjectId = Guid.Parse("b2df6db3-2b38-4c3a-9517-5e3e2b98b741")
      },
      new Forum
      {
        Id = Guid.Parse("4e789033-2c18-488f-b1ba-4093b2c77053"),
        Topic = "Physics Chapter 1",
        DiscussionQuestion = "How do we understand Newton’s Laws?",
        Screenshot = null,
        CreatedAt = DateTime.Parse("2025-06-12T20:32:42.1633333"),
        SubjectId = Guid.Parse("b2df6db3-2b38-4c3a-9517-5e3e2b98b741")
      },
      new Forum
      {
        Id = Guid.Parse("91dc665a-eed7-4098-a41b-459a2ffdcb6a"),
        Topic = "Difficult problems in Algebra",
        DiscussionQuestion = "What are common algebra problems students face?",
        Screenshot = null,
        CreatedAt = DateTime.Parse("2025-05-21T09:21:04.8566667"),
        SubjectId = Guid.Parse("3fe2283b-6751-4633-8903-2043997bbf20")
      },
      new Forum
      {
        Id = Guid.Parse("518cae9e-6e93-4cff-be00-479c78302c88"),
        Topic = "Difficult problems in Algebra",
        DiscussionQuestion = "What are common algebra problems students face?",
        Screenshot = null,
        CreatedAt = DateTime.Parse("2025-05-21T09:21:04.8566667"),
        SubjectId = Guid.Parse("b2df6db3-2b38-4c3a-9517-5e3e2b98b741")
      }
    };
  }

  public static List<ApplicationUser> GetUsers()
  {
    return new List<ApplicationUser>
    {
      new ApplicationUser { Id = "user1", UserName = "Tshepo Tshola", NormalizedUserName = "Tshepo Tshola", Email = "user1@example.com", NormalizedEmail = "USER1@EXAMPLE.COM", Name = "User", Surname = "One" },
      new ApplicationUser { Id = "user2", UserName = "John Klane", NormalizedUserName = "John Klane", Email = "user2@example.com", NormalizedEmail = "USER2@EXAMPLE.COM", Name = "User", Surname = "Two" },
      new ApplicationUser { Id = "user3", UserName = "Marry Jane", NormalizedUserName = "Marry Jane", Email = "user3@example.com", NormalizedEmail = "USER3@EXAMPLE.COM", Name = "User", Surname = "Three" }
    };
  }
}
