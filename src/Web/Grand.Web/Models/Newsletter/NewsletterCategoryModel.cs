﻿using Grand.Infrastructure.Models;

namespace Grand.Web.Models.Newsletter
{
    public class NewsletterCategoryModel : BaseModel
    {
        public string NewsletterEmailId { get; set; }
        public string[] Category { get; set; }
        public IList<NewsletterSimpleCategory> NewsletterCategories { get; set; } = new List<NewsletterSimpleCategory>();
    }
    public class NewsletterSimpleCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Selected { get; set; }
    }
}