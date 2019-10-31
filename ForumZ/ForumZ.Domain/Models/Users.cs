using System;
using System.Collections.Generic;
using System.Text;

namespace ForumZ.Domain.Models
{
    public class Users : Entity
    {
        public enum UsersType { Member, Moderator, Admin }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Photo { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public UsersType UserType { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? BannedUntil { get; set; }

        public int BannedTimes { get; set; }

        public int Reputation { get; set; }

        public IEnumerable<Topic> Topics { get; set; }

        public IEnumerable<Answers> Answers { get; set; }
    }
}
