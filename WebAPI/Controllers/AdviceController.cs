using Application;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdviceController : ControllerBase
    {
        private readonly GetAdviceUseCase _getAdviceUseCase;

        public AdviceController(GetAdviceUseCase getAdviceUseCase)
        {
            _getAdviceUseCase = getAdviceUseCase;
        }

        [HttpGet]
        [Route("randomAdvice")]
        public async Task<IActionResult> GetRandomAdvice()
        {
            var advice = await _getAdviceUseCase.ExecuteAsync();
            return Ok(advice);
        }
    }

}
