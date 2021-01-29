using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Application.Catalog.Products;
using Microsoft.AspNetCore.Mvc;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Catalog.ProductImages;
using Microsoft.AspNetCore.Authorization;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eShopSolution.Backend_API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class ProductsController : Controller
    {
        
       private readonly IProductService _poductService;
        public ProductsController(IProductService publicProductService)
        {
            _poductService = publicProductService;
        
        }
        // GET: api/values
     

             // http://localhost/products?pageIndex=1&pagesSize=10&CategoryId=2
     /*   [HttpGet("{languageId}")]
        public async Task<IActionResult> GetAllPaging(string languageId ,[FromQuery]GetProductPaggingRequest request)
        {

          var product = await _poductService.GetAllByCategoryId( languageId, request);
          return Ok(product);
                
        }*/


        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetManageProductPaggingRequest request)
        {
            var products = await _poductService.GetAllPading(request);
            return Ok(products);
        }



        // http://localhost/product/1
        [HttpGet("{productId}/{languageId}")]
           public async Task<IActionResult> GetByID(int productId, string languageId)
        {
            var product = await _poductService.GetById(productId,languageId);
            if(product==null)return BadRequest("Cannot find product");
            return Ok(product);
        }

        [HttpGet("featured/{languageId}/{take}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetFeaturedProducts(int take, string languageId)
        {
            var products = await _poductService.GetFeaturedProducts(languageId, take);
            return Ok(products);
        }


        [HttpGet("latest/{languageId}/{take}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetLatestProducts(int take, string languageId)
        {
            var products = await _poductService.GetLatestProducts(languageId, take);
            return Ok(products);
        }


        [HttpPost]
       [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm]ProductCreateRequest request ){
                   if(!ModelState.IsValid){
                       return BadRequest(ModelState);
                   }
                   var productId = await _poductService.Create(request);
                   if(productId ==0)
                    return BadRequest();
                   var product = await _poductService.GetById(productId ,request.LanguageId);
                      //https://localhost:25116/Product/GetByID/2
                   return CreatedAtAction(nameof(GetByID),new {id=productId},product);
       }

        [HttpPut("{productId}")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Update([FromRoute] int productId, [FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.Id = productId;
            var affectedResult = await _poductService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }


        [HttpPut]
       public async Task<IActionResult> Update([FromForm]ProductUpdateRequest request ){
                        if(!ModelState.IsValid){
                       return BadRequest(ModelState);
                   }
                   var affectedResult = await _poductService.Update(request);
                   if(affectedResult ==0)
                    return BadRequest();
                
                   return Ok();
       }

        [HttpDelete("{productId}")]
       public async Task<IActionResult> Delete( int productId ){
                   
                   var affectedResult = await _poductService.Delete(productId);
                   if(affectedResult ==0)
                    return BadRequest();         
                   return Ok();
       }

        [HttpPatch("{productId}/{newPrice}")]
       public async Task<IActionResult> UpdatePrice(int productId ,decimal newPrice ){
                   
                   var isSuccessful = await _poductService.UpdatePrice(productId,newPrice);
                   if(isSuccessful) return Ok();
                    return BadRequest();
       }
       
       [HttpPost("{productId}/images")]
       public async Task<IActionResult> CreateImage(int productId,[FromForm]ProductImageCreateRequest request ){
                   if(!ModelState.IsValid){
                       return BadRequest(ModelState);
                   }
                   var imageId = await _poductService.AddImage(productId,request);
                   if(imageId ==0)
                    return BadRequest();
                   var image = await _poductService.GetImageById(imageId);
                    
                   return CreatedAtAction(nameof(GetImageById),new {id=imageId},image);
       }

      [HttpGet("{productId}/images/{imageId}")]
           public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _poductService.GetImageById(imageId);
            if(image==null)return BadRequest("Cannot find product");
            return Ok(image);
        }

          [HttpPut("{productId}/images/{imageId}")]
       public async Task<IActionResult> UpdateImage(int imageId , [FromForm]ProductImageUpdateRequest request)
       {
                        if(!ModelState.IsValid){
                       return BadRequest(ModelState);
                   }
                   var Result = await _poductService.UpdateImage(imageId,request);
                   if(Result ==0)
                    return BadRequest();     
                   return Ok();
       }
       
        [HttpDelete("{productId}/images/{imageId}")]
       public async Task<IActionResult> RemoveImage( int imageId ){
                     if(!ModelState.IsValid){
                       return BadRequest(ModelState);
                   }
                   var result = await _poductService.RemoveImage(imageId);
                   if(result ==0)
                    return BadRequest();         
                   return Ok(); 
       }

        [HttpPut("{id}/categories")]
        public async Task<IActionResult> CategoryAssign(int id, [FromBody] CategoryAssignRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _poductService.CategoryAssign(id, request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }


    }
}
