using Microsoft.AspNetCore.Mvc;
using EmailDemo.BasicConfirmation.DTOs.Requests;
using EmailDemo.BasicConfirmation.Services.Interfaces;

namespace EmailDemo.BasicConfirmation.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public readonly IEmailService _emailService;
        public AuthController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        // Route-01 : register user
        [HttpPost]
        public IActionResult Register([FromBody] RegisterUserRequestDto request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    Error = true,
                    Message = "Invalid request data"
                });
            }
            
            _emailService.SendWelcomeEmail(request.Name, request.Email);

            return StatusCode(StatusCodes.Status201Created, new
            {
                StatusCode = StatusCodes.Status201Created,
                Error = false,
                Message = "User registered successfully"
            });
        }
    }
}