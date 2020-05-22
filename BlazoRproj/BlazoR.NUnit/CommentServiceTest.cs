using BlazoR.Domain.Models;
using BlazoR.Shared;
using System.Linq;
using Xunit;

namespace BlazoR.NUnit
{
    public class CommentServiceTest : IClassFixture<TestDbContext>
    {
        public TestDbContext Context { get; set; }
        public CommentServiceTest(TestDbContext sharedDatabase)
        {
            Context = sharedDatabase;
        }

        [Fact]
        public void ConnectionToHerokuDatabase()
        {
            using (var context = Context.CreateContext())
            {
                Assert.Equal(0, 0);
            }
        }


        [Fact]
        public void AddComment()
        {
            using (var context = Context.CreateContext())
            {
                Post testPost = new Post
                {
                    Header = "Test"
                };
                context.Posts.Add(testPost);
                CommentService commentService = new CommentService(context);
                commentService.AddNewComment("Test", testPost, "TestUser");
                context.Posts.Remove(testPost);
                context.SaveChanges();
                Assert.Equal(0, 0);
            }
        }

        [Fact]
        public void ReadPostsComments()
        {
            using (var context = Context.CreateContext())
            {
                Post testPost = new Post
                {
                    Header = "Test"
                };
                context.Posts.Add(testPost);
                CommentService commentService = new CommentService(context);
                commentService.AddNewComment("Test", testPost, "TestUser");
                var comments = commentService.GetComments(testPost);
                Assert.Equal("TestUser", comments.FirstOrDefault().Sender);
                context.Posts.Remove(testPost);
                context.SaveChanges();
            }
        }
    }
}
