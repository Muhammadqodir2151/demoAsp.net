﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAsp.ner.Data.Utils
{
    public class PaginationParams
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int SkipCount
        {
            get
            {
                return (PageNumber - 1) * PageSize;
            }
        }
    }
}
