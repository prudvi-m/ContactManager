using System.ComponentModel.DataAnnotations;
using System;

namespace ContactManager.Models
{
    public class Contact
    {
        // EF Core will configure the database to generate this value
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a First Name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name.")]
        public string FirstName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        
        [Range(1, 100000000, ErrorMessage = "Please select a category.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;

        public string Slug =>
            FirstName?.Replace(' ', '-').ToLower() + '-' + (Category?.Name.ToString() ?? "");
    }
}
