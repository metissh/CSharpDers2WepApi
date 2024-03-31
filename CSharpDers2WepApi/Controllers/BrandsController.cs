using Business.Abstract;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSharpDers2WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandServices _brandServices;

        public BrandsController(IBrandServices brandServices)
        {
            _brandServices = brandServices;
        }

        [HttpPost]
        
        public IActionResult  Add(CreateBrandRequest createBrandRequest)
        {
            CreatedBrandResponse createdBrandResponse = _brandServices.Add(createBrandRequest);

            return Ok(createdBrandResponse);
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_brandServices.GetAll());
        }
    }
}
