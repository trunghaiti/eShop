using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class CategoryTranslation
    {
        public int Id { set; get; }
        public int CategoryId { set; get; }
        public string Name { set; get; }
        public string SeoDescription { set; get; }
        public int SeoTitle { set; get; }
        public int LangguageId { set; get; }
        public int SeoAlias { set; get; }
    }
}
