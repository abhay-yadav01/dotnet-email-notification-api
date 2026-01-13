using System.ComponentModel.DataAnnotations;

namespace EmailDemo.BasicConfirmation.DTOs.Requests
{
    public class RegisterUserRequestDto
    {
        [Required] public string Name { get; set; } = string.Empty;
        [Required] public string Email { get; set; } = string.Empty;
    }
}