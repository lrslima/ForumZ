using System;
using System.Collections.Generic;
using System.Text;

namespace ForumZ.Domain.Models
{
    public class Answers : Entity
    {
        public Guid Key { get; set; }

        public Users User { get; set; }

        public int UpVotes { get; set; }

        public int DownVotes { get; set; }

        public Topic Topic { get; set; }

        public DateTime AnswerDate { get; set; }
    }
}
