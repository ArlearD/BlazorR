using BlazoR.Data.Data.Repository;
using BlazoR.Domain.Models;
using Xunit;

namespace BlazoR.NUnit
{
    public class CommentRepositoryTest : IClassFixture<TestDbContext>
    {
        public TestDbContext Context { get; set; }
        public CommentRepositoryTest(TestDbContext sharedDatabase)
        {
            Context = sharedDatabase;
        }

        [Fact]
        public void ConnectionCommentRepositoryToHerokuDatabase()
        {
            using (var context = Context.CreateContext())
            {
                Assert.Equal(0, 0);
            }
        }


        [Fact]
        public void ReadCommentsTest()
        {
            using (var context = Context.CreateContext())
            {
                CommentRepository commentRepository = new CommentRepository(context);
                Assert.True(commentRepository.GetAllElements().Count != 0);
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
                CommentRepository commentRep = new CommentRepository(context);
                var testComment = new Comment
                {
                    Post = testPost,
                    Sender = "Test",
                    Text = "Test"
                };
                commentRep.Create(testComment);
                context.Posts.Remove(testPost);
                context.SaveChanges();
                Assert.Equal(0, 0);
            }
        }
    }
}
