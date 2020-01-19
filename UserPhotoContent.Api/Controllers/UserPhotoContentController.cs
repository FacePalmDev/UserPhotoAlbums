using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserPhotoContent.Interfaces.Services;

namespace UserPhotoContent.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserPhotoContentController : ControllerBase
    {
        private readonly ILogger<UserPhotoContentController> _logger;
        private readonly IUserContentService _photoAlbumsContentService;


        public UserPhotoContentController(
            ILogger<UserPhotoContentController> logger,
                IUserContentService photoAlbumsContentService
            )
        {
            _logger = logger;
            _photoAlbumsContentService = photoAlbumsContentService;
        }

        [HttpGet]
        public IActionResult Get(int userId)
        {
            var result = _photoAlbumsContentService.Get(userId);

            if (result.Any() == false)
            {
                return NotFound();
            }

            return new JsonResult(result);
        }
    }
}
