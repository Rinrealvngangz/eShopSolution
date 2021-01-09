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
        [HttpGet("{languageId}")]
           public async Task<IActionResult> Get(string languageId)
        {
            var product = await _publicProductService.GetAll(languageId);
            return Ok(product);
        }

             // http://localhost/product/public-paging
        [HttpGet("public-paging/{languageId}")]
        public async Task<IActionResult> Get([FromQuery]GetProductPaggingRequest request)
        {

          var product = await _publicProductService.GetAllByCategoryId(request);
          return Ok(product);
                
        }
          // http://localhost/product/1
          [HttpGet("{id}/{languageId}")]
           public async Task<IActionResult> GetByID(int id, string languageId)
        {
            var product = await _manageProductService.GetById(id,languageId);
            if(product==null)return BadRequest("Cannot find product");
            return Ok(product);
        }


       [HttpPost]
       public async Task<IActionResult> Create([FromForm]ProductCreateRequest request ){
                   
                   var productId = await _manageProductService.Create(request);
                   if(productId ==0)
                    return BadRequest();
                   var product = await _manageProductService.GetById(productId ,request.LanguageId);
                      //https://localhost:25116/Product/GetByID/2
                   return CreatedAtAction(nameof(GetByID),new {id=productId},product);
       }

        [HttpPut]
       public async Task<IActionResult> Update([FromForm]ProductUpdateRequest request ){
                   
                   var affectedResult = await _manageProductService.Update(request);
                   if(affectedResult ==0)
                    return BadRequest();
                
                   return Ok();
       }

        [HttpDelete("{id}")]
       public async Task<IActionResult> Delete( int id ){
                   
                   var affectedResult = await _manageProductService.Delete(id);
                   if(affectedResult ==0)
                    return BadRequest();         
                   return Ok();
       }

        [HttpPut("price/{id}/{newPrice}")]
       public async Task<IActionResult> UpdatePrice(int id ,decimal newPrice ){
                   
                   var isSuccessful = await _manageProductService.UpdatePrice(id,newPrice);
                   if(isSuccessful) return Ok();
                    return BadRequest();
       }



    }
}
