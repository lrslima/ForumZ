using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ForumZ.Api.Models
{
    public class UsersViewModel
    {
        public enum UsersType { Member, Moderator, Admin }


        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Photo { get; set; }


        [Required(ErrorMessage = "{0} is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(16, ErrorMessage = "Must be between 8 and 16 characters", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public UsersType UserType { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        public DateTime? BannedUntil { get; set; }

        public int BannedTimes { get; set; }

        public int Reputation { get; set; }

        public IEnumerable<TopicViewModel> Topics { get; set; }

        public IEnumerable<AnswersViewModel> Answers { get; set; }

    }
}
