﻿using System;
using System.Collections.Generic;
using System.Text;
using NewsSite.Domain.Entities;

namespace NewsSite.Domain.Abstract
{
    public interface IPostRepository
    {
        IEnumerable<Post> Posts { get; }
    }
}
