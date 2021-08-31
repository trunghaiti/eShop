﻿using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class Language
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public Status IsDefault { set; get; }

        public List<CategoryTranslation> CategoryTranslations { set; get; }
        public List<ProductTranslation> ProductTranslations { set; get; }
    }
}
