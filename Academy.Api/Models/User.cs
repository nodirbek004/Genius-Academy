using System.ComponentModel.DataAnnotations;

namespace Academy.Api.Models;
public class User
{
    public long Id { get; set; }

    [Required]
    [MinLength(2),MaxLength(15)]
    [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Name must contain only alphabetic characters.")]
    public string FirstName { get; set; }

    [Required]
    [MinLength(2),MaxLength(15)]
    [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Name must contain only alphabetic characters.")]

    public string LastName { get; set; }
    [Required]
    [StringLength(9, MinimumLength = 9, ErrorMessage = "Phone number must be exactly 9 digits.")]
    [RegularExpression("^[0-9]{9}$", ErrorMessage = "Phone number must be numeric and 9 digits long.")]
    public string Phone { get; set; }
}
