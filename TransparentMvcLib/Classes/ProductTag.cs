﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransparentMvcLib.Classes
{
    public class ProductTag : BaseObj
    {
        public int ProductId { get; set; }
        public int TagId { get; set; }

        public static IEnumerable<ProductTag> GetTags() {
            return GetAllTags();
        }

        private static IEnumerable<ProductTag> GetAllTags()
        {
            return new ProductTagDb().GetTags();
        }
    }
}