﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazoR.Domain.Models
{
    public class Comment
    {
        public long Id { get; set; }
        public Post Post { get; set; }
        public string Text { get; set; }
        public string Sender { get; set; }
    }
}
