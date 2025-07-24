using Microsoft.AspNetCore.Mvc;
using TelephoneDirectory.Business.Services.Directory.Abstract;
using TelephoneDirectory.Business.Services.Directory.Models.RequestModels;
using TelephoneDirectory.Business.Services.Directory.Models.ResponseModels;

namespace TelephoneDirectory.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DirectoryController : ControllerBase
    {
        private readonly IDirectoryService _directoryService;
        public DirectoryController(IDirectoryService directoryService)
        {
            _directoryService = directoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            
            return Ok(new List<GetAllResponseModel>());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            
            return Ok(new GetAllResponseModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddUserRequestModel model)
        {
           
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateUserRequestModel model)
        {
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            return Ok();
        }
    }
} 