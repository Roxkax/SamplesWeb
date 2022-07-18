using Microsoft.AspNetCore.Mvc;
using SamplesWebApi.Data.Models;

namespace SamplesWebApi.Controllers
{
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ILogger<SampleController> _logger;

        public SampleController(ILogger<SampleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/api/Sampler/GetSampleApiItems")]
        public IEnumerable<SampleApiItem> Get(int numberOfItems)
        {
            return Enumerable.Range(1, numberOfItems).Select(i => new SampleApiItem { Id = Guid.NewGuid(), Name = DateTime.Now.AddDays(i).ToString("dddd") }).ToArray();
        }
    }
}
