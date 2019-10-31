using System;
using System.Collections.Generic;
using System.Text;

namespace ForumZ.Domain.Models
{
    public class Category : Entity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string Tag { get; set; }

        public DateTime CreatedAt { get; set; }

        public Users CreatedBy { get; set; }

        public CategoryTopic Topics { get; set; }

        public IEnumerable<Users> Members { get; set; }

        public IEnumerable<Users> Moderators { get; set; }

        public bool Active { get; set; }
    }
}
