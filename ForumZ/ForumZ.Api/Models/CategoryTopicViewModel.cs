using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForumZ.Api.Models
{
    public class CategoryTopicViewModel 
    {
        [Key]
        public Guid Id { get; set; }

        public Guid TopicId { get; set; }
        public Guid CategoryId { get; set; }
    }
}
