using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using EL.Models;
using comments_challenge.Controllers;
using System.Web.Mvc;
using EL;
using System.Web;
using System.Web.Routing;
using System.IO;
using System.Collections.Specialized;
using System.Data.Entity;
using DAL;
using NUnit.Framework;
using System.Data.Common;

namespace comments_challenge.CandidateTests
{
    [TestFixture]
    public class CommentsTests
    {
        private CommentDAL commentDAL;
        private PostsContext postsContext;

        [SetUp]
        public void Init()
        {
            DbConnection connection = Effort.DbConnectionFactory.CreateTransient();
            postsContext = new PostsContext(connection, new PostDbInitializer<PostsContext>());
            commentDAL = new CommentDAL(postsContext);
        }
        [TearDown]
        public void Dispose()
        {
            postsContext.Dispose();
        }

        [Test]
        public void ThatPostControllerIndexActionReturnsPosts()
        {
            // Arrange
            var postsController = new PostsController(commentDAL);

            // Act
            var result = postsController.Index(String.Empty, String.Empty) as ViewResult;

            // Assert
            Assert.IsTrue(result.Model is List<PostModel>);
            Assert.IsTrue((result.Model as List<PostModel>).Count() == 3);
        }

        [Test]
        public void ThatPostControllerIndexActionReturnsPostsFilteredByTitle()
        {
            // Arrange
            var postsController = new PostsController(commentDAL);
            var searchedTitle = "title2";

            // Act
            var result = postsController.Index(searchedTitle, String.Empty) as ViewResult;

            // Assert
            Assert.IsTrue(result.Model is List<PostModel>);
            Assert.IsTrue((result.Model as List<PostModel>).Count() == 1);
            Assert.IsTrue((result.Model as List<PostModel>).ElementAt(0).Title == searchedTitle);
        }

        [Test]
        public void ThatPostControllerIndexActionReturnsPostsWithComments()
        {
            // Arrange
            var postsController = new PostsController(commentDAL);

            // Act
            var result = postsController.Index(String.Empty, String.Empty) as ViewResult;

            // Assert
            Assert.IsTrue(result.Model is List<PostModel>);
            Assert.IsTrue((result.Model as List<PostModel>).Count() == 3);
            Assert.IsTrue((result.Model as List<PostModel>).ElementAt(0).Comments != null);
            Assert.IsTrue((result.Model as List<PostModel>).ElementAt(1).Comments != null);
            Assert.IsTrue((result.Model as List<PostModel>).ElementAt(2).Comments != null);
        }
    }
}

