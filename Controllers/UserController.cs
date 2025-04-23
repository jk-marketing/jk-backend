using JK_Backend.Data;
using JK_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using static System.Net.WebRequestMethods;

namespace JK_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public UserController(AppDbContext context, HttpClient httpClient, IConfiguration configuration)
        {
            _context = context;
            _httpClient = httpClient;
            _configuration = configuration;

        }

        [HttpPost]
        public async Task<IActionResult> SaveUser([FromBody] User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            var baseUrl = _configuration["ExternalUrls:PropellerAds"];
            var url = string.Format(baseUrl, user.VisitorId);

            var response = await _httpClient.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return Ok(user);
            }
            return Ok(user);

            //return StatusCode((int)response.StatusCode, result);
           
        }
    }

}
