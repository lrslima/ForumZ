using System;
using System.Collections.Generic;
using System.Text;

namespace ForumZ.Domain.Models
{
    public class CategoryTopic : Entity
    {
        public Guid Id { get; set; }

        public IEnumerable<Topic> Topic { get; set; }
        public IEnumerable<Category> Category { get; set; }
    }
}
