using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserPhotoContent.Api.Models;
using UserPhotoContent.Api.Services;

namespace UserPhotoContent.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserPhotoContentController : ControllerBase
    {
        private readonly ILogger<UserPhotoContentController> _logger;
        private readonly IContentService _userPhotoContentService;

        public UserPhotoContentController(
            ILogger<UserPhotoContentController> logger,
            IContentService userPhotoContentService)
        {
            _logger = logger;
            _userPhotoContentService = userPhotoContentService;
        }

        [HttpGet]
        public IActionResult Get(int userId)
        {
            var result =  _userPhotoContentService.GetUserContent(userId);

            if (!result.Any())
            {
                return NotFound();
            }

            return new JsonResult(result);
        }
    }
}
