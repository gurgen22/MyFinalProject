using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        
        private ICategoryService _categorytService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categorytService = categoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            
            var result = _categorytService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }

}
