using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Application.Catalog.Products;
using Microsoft.AspNetCore.Mvc;
using eShopSolution.ViewModels.Catalog.Products;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eShopSolution.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        
       private readonly IPublicProductService _publicProductService;
       private readonly IManageProductService _manageProductService;
        public ProductController(IPublicProductService publicProductService, IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }
        // GET: api/values
        // http://localhost/product
        [HttpGet]
           public async Task<IActionResult> Get()
        {
            var product = await _publicProductService.GetAll();
            return Ok(product);
        }

             // http://localhost/product/public-paging
        [HttpGet("public-paging")]
        public async Task<IActionResult> Get([FromQuery]GetProductPaggingRequest request){

          var product = await _publicProductService.GetAllByCategoryId(request);
          return Ok(product);
                
        }
          // http://localhost/product/1
          [HttpGet("{id}")]
           public async Task<IActionResult> GetByID(int productId)
        {
            var product = await _manageProductService.GetById(productId);
            if(product==null)return BadRequest("Cannot find product");
            return Ok(product);
        }


       [HttpPost]
       public async Task<IActionResult> Create([FromBody]ProductCreateRequest request ){
                   
                   var productId = await _manageProductService.Create(request);
                   if(productId ==0)
                    return BadRequest();
                   var product = await _manageProductService.GetById(productId);

                   return CreatedAtAction(nameof(GetByID),new {id=productId},product);
       }





    }
}
