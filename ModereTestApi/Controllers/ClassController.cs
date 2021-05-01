using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ModereTest.Services;
using ModereTest.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace ModereTestApi.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class ClassController : ControllerBase
    {
        private readonly ILogger<ClassController> logger;
        private readonly IConfiguration configuration;
        private readonly IClassService classService;

        public ClassController(IConfiguration configuration, ILogger<ClassController> logger, IClassService classService)
        {
            this.configuration = configuration;
            this.logger = logger;
            this.classService = classService;
        }

        [HttpGet]
        [Route("students/{classId}")]
        public async Task<IActionResult> GetStudentsByClassIdAsync(int classId)
        {
            try
            {
                var list = await classService.GetClassRegisterByClassIdAsync(classId);
                if (list != null)
                {
                    return Ok(list);
                }
                return NotFound();
            }
            catch (Exception e)
            {
                if (e is InvalidClassException)
                { 
                    return BadRequest(e.Message); 
                }
                throw;
            }
        }
    }
}
