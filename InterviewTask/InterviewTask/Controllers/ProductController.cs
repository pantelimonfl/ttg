using InterviewTask.BLL.Contract;
using InterviewTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ITourService _tourService;

        public ProductController(ITourService tourService)
        {
            _tourService = tourService;
        }

        [HttpPost("products")]
        public async Task<IActionResult> GetProducts([FromBody] SearchModel searchModel) 
        {
            if (ModelState.IsValid && searchModel.NumberOfGuests != 0)
            {
                var result = await _tourService.GetProducts(searchModel);

                return (result != null && result.Any()) ? Ok(result) : NotFound("No products could be found based on the search criteria.");
            }
            else return BadRequest("Model is not valid.");
        }
    }
}
