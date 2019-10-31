using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ForumZ.Api.Models
{
    public class TopicViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20, ErrorMessage = "Must be at last 4 characteres and max 20 characteres", MinimumLength = 4)]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(1000, ErrorMessage = "Must be at last 4 characteres and max 20 characteres", MinimumLength = 10)]
        public string Content { get; set; }

        public UsersViewModel CreatedBy { get; set; }

        public IEnumerable<CategoryTopicViewModel> Categories { get; set; }

        public IEnumerable<AnswersViewModel> Answers { get; set; }

        public int UpVotes { get; set; }

        public DateTime? EditedAt { get; set; }

        public int DownVotes { get; set; }

        public bool Closed { get; set; }

        public UsersViewModel ClosedBy { get; set; }
    }
}
