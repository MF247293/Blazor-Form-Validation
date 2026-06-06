using System.ComponentModel.DataAnnotations;

public class User
{
    [Required(ErrorMessage = "First name required")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last name required")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email required")]
    [EmailAddress(ErrorMessage = "Invalid email")]
    public string Email { get; set; }
}