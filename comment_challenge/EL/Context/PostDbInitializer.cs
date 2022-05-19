using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EL
{
    public class PostDbInitializer<T> : CreateDatabaseIfNotExists<PostsContext>
    {
        public static IQueryable<User> UsersData = new List<User>
        {
            new User(){UserId = 1,FirstName = "Jeremy",LastName = "Clarkson", CreatedAt = DateTime.UtcNow},
            new User(){UserId = 2,FirstName = "James",LastName = "May", CreatedAt = DateTime.UtcNow},
            new User(){UserId = 3,FirstName = "Richard",LastName = "Hammound", CreatedAt = DateTime.UtcNow}
        }.AsQueryable();

        public static IQueryable<Post> PostsData = new List<Post>
        {
            new Post() { PostId = 1,UserId = 1,Title = "title",Content = "The BMW M3 remains the only car ever to have earned more titles than the venerable Porsche 911 in Motorsport, and also is the most successful touring, and grand touring car ever to have participated in racing.", CreatedAt = DateTime.UtcNow},
            new Post() { PostId = 2,UserId = 2,Title = "title2",Content = "Mercedes-AMG GmbH, commonly known as AMG, is the high performance division of Mercedes-Benz.", CreatedAt = DateTime.UtcNow},
            new Post() { PostId = 3,UserId = 3,Title = "title3",Content = "The Ford Mustang is an American automobile.", CreatedAt = DateTime.UtcNow}
        }.AsQueryable();

        public static IQueryable<Comment> CommentsData = new List<Comment>
        {
            new Comment() { CommentId = 1,UserId= 1,PostId= 1, CreatedAt = DateTime.UtcNow,Content = "Great Car"},
            new Comment() { CommentId = 2,UserId= 2,PostId= 2, CreatedAt = DateTime.UtcNow,Content = "I'd like to have it"},
            new Comment() { CommentId = 3,UserId= 3,PostId= 3, CreatedAt = DateTime.UtcNow,Content = "Nothing interesting"},
            new Comment() { CommentId = 4,UserId= 3,PostId= 1, CreatedAt = DateTime.UtcNow,Content = "I wish to test it's max speed"},
            new Comment() { CommentId = 5,UserId= 2,PostId= 3, CreatedAt = DateTime.UtcNow,Content = "Looks great"},
            new Comment() { CommentId = 6,UserId= 3,PostId= 3, CreatedAt = DateTime.UtcNow,Content = "Can't wait to do the test drive"}
        }.AsQueryable();

        protected override void Seed(PostsContext context)
        {
            context.Users.AddRange(UsersData);
            context.Posts.AddRange(PostsData);
            context.Comments.AddRange(CommentsData);
            base.Seed(context);
        }
    }
}