using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UserPhotoContent.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserPhotoContentController : ControllerBase
    {
        private readonly ILogger<UserPhotoContentController> _logger;

        public UserPhotoContentController(ILogger<UserPhotoContentController> logger)
        {
            _logger = logger;
        }

    }
}
