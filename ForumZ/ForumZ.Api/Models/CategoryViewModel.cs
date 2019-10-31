using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForumZ.Api.Models
{
    public class CategoryViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string Tag { get; set; }

        public DateTime CreatedAt { get; set; }

        public UsersViewModel CreatedBy { get; set; }

        public IEnumerable<CategoryTopicViewModel> Topics { get; set; }

        public IEnumerable<UsersViewModel> Members { get; set; }

        public IEnumerable<UsersViewModel> Moderators { get; set; }

        public bool Active { get; set; }

    }
}
