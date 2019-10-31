using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForumZ.Api.Models
{
    public class AnswersViewModel
    {
        [Key]
        public Guid Key { get; set; }

        public UsersViewModel User { get; set; }

        public int UpVotes { get; set; }

        public int DownVotes { get; set; }

        public TopicViewModel Topic { get; set; }

        public DateTime AnswerDate { get; set; }
    }
}
