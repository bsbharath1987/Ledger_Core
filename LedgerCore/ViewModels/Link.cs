﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LedgerCore.ViewModels
{
    public class Link
    {
        public string Url { get; set; }
        public string Rel { get; set; }
        public string Method { get; set; }
    }

    public class LinkHelper<T> where T:class
    {
        public List<Link> Links { get; set; }
        public T Value { get; set; }
    }
}
