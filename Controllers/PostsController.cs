using CONSUMIR_API_DTOs.DTOs;
using CONSUMIR_API_DTOs.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CONSUMIR_API_DTOs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        IPostsService _titlesService;

        public PostsController(IPostsService titlesService)
        {
            _titlesService = titlesService;
        }

        [HttpGet]
        public async Task<IEnumerable<PostDto>> Get() => await _titlesService.Get();
    }
}
