﻿using System;
using System.Collections.Generic;
using System.Text;
using NewsSite.Domain.Entities;

namespace NewsSite.Domain.Abstract
{
    public interface IPostRepository
    {
        IEnumerable<Post> Posts { get; }
        IEnumerable<Tag> Tags { get; }
        IEnumerable<Category> Categories { get; }

        IEnumerable<Comment> Comments { get; }

        // void SavePost(Post post);
        Post DeletePost(int postId);
        void SavePost(Post post, List<Tag> tags);
        void AddComment(int? parentId, int postId, string Text);
    }
}
