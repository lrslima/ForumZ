using System;
using System.Collections.Generic;
using System.Text;

namespace ForumZ.Domain.Models
{
    public class Topic : Entity
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public Users CreatedBy { get; set; }

        public CategoryTopic Categories { get; set; }

        public IEnumerable<Answers> Answers { get; set; }

        public int UpVotes { get; set; }

        public DateTime? EditedAt { get; set; }

        public int DownVotes { get; set; }

        public bool Closed { get; set; }

        public Users ClosedBy { get; set; }
    }
}
