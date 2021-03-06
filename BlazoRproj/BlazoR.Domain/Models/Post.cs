﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BlazoR.Domain.Models
{
    public class Post
    {
        public long Id { get; set; }
        public string Header { get; set; }
        public List<string> Images { get; set; }
        public string Text { get; set; }
        public string Sender { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
