using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "Please select Category.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Slug =>
            FirstName?.Replace(' ', '-').ToLower() + '-' + (Category?.Name.ToString() ?? "");
    }
}
