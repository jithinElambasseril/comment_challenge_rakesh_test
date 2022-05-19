using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EL;
using EL.Models;

namespace DAL
{
    public class CommentDAL
    {
        private readonly PostsContext _dbContext;

        public CommentDAL(PostsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<PostModel> GetPosts(string title = null, string sortOrder = null)
        {
            /* Fill posts */
            var postModel = new List<PostModel>();
            var posts = _dbContext.Posts.ToList();
            if (posts.Any())
            {
                posts.ForEach(post =>
                {
                    postModel.Add(new PostModel
                    {

                        Id = post.PostId,
                        Comments = post.Comments.Select(comment => new CommentModel
                        {
                            Id = comment.CommentId,
                            Content = comment.Content,
                            CreatedAt = comment.CreatedAt,
                            PostId = comment.PostId,
                            UpdatedAt = comment.UpdatedAt,
                            User = new UserModel
                            {
                                Id = comment.User.UserId,
                                FirstName = comment.User.FirstName,
                                LastName = comment.User.LastName,
                                CreatedAt = comment.User.CreatedAt,
                                UpdatedAt = comment.User.UpdatedAt
                            },
                            UserId = comment.UserId
                        }),
                        Content = post.Content,
                        Title = post.Title,
                        CreatedAt = post.CreatedAt,
                        UpdatedAt = post.UpdatedAt,
                        UserId = post.UserId
                    });
                });
                return postModel;
            }
            return null;
        }
    }
}
