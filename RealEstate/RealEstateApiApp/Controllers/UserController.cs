using Dtos.EstateDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateApiApp.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        //[Produces("text/plain")]
        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login()
        {
            try
            {
                return Ok("Logged in");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("get-all")]
        public ActionResult<List<EstateDto>> GetAll()
        {
            try
            {
                return Ok(_userService.GetAllEstates());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpGet("get-by-id")]
        public ActionResult<EstateDto> GetById(int id)
        {
            try
            {
                return Ok(_userService.GetEstateById(id));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
