using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Backend.DTOs;

namespace Backend.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class AccountController : ControllerBase
  {

    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
      _logger = logger;
    }

    [HttpPost("login")]
    public string Login(LoginUserDto user)
    {
      return null;
    }

    [HttpPost("create")]
    public string Create(CreateUserDTO user)
    {
      return null;
    }
    
  }
}
