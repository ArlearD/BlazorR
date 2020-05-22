using BlazoR.Domain.Models;
using BlazoR.Shared;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BlazoR.NUnit
{
    public class PostServiceTest : IClassFixture<TestDbContext>
    {
        public TestDbContext Context { get; set; }
        public PostServiceTest(TestDbContext sharedDatabase)
        {
            Context = sharedDatabase;
        }

        [Fact]
        public void ConnectionToHerokuDatabase()
        {
            using (var context = Context.CreateContext())
            {
                Assert.Equal(0,0);
            }
        }


        [Fact]
        public void GetPosts()
        {
            using (var context = Context.CreateContext())
            {
                PostService postService = new PostService(context);
                var posts = postService.GetPosts();
                Assert.True(posts.Count != 0);
            }
        }

        [Fact]
        public void InsertAndGetPost()
        {
            using (var context = Context.CreateContext())
            {
                PostService postService = new PostService(context);
                var post = new Post
                {
                    Header = "Test",
                };
                postService.CreatePost(post);
                Assert.Equal(post.Header, postService.GetPosts().Where(x => x.Header == post.Header).FirstOrDefault().Header);

                context.Posts.Remove(post);
                context.SaveChanges();
            }
        }
    }
}
