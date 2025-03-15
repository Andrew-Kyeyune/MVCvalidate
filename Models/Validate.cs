using System.ComponentModel.DataAnnotations;
namespace MVCvalidate.Models
{
    public class Validate
    {
        [Required(ErrorMessage = "Name is Required.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and Confirmation do not match")]
        [DataType(DataType.Password)]
        public required string Confirm_Password { get; set; }

        [Required(ErrorMessage = "Age is requires")]
        [Range(21, 30, ErrorMessage = "Age must be between 21 and 30")]

        public int Age { get; set; }

        [Required(ErrorMessage = "Email is requires")]
        [EmailAddress( ErrorMessage = "Invalid Email Address")]

        public required string Email { get; set; }


        [Required(ErrorMessage = "User_Id is required")]
        [RegularExpression(@"~`", ErrorMessage = "User Id Must Contain  atleast one upper Character, one digit, and must be between 7 and 20 characters.")]

        public required string User_Id { get; set; }

    }
}
