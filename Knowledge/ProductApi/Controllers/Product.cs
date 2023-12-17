using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Repository _repository;

        public ProductController(Repository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult GetProducts() 
        {
            return Ok(this._repository.GetAllProducts());
        
        }

        [HttpGet("id")]
        public ActionResult GetProduct(int id)
        {
            return Ok(this._repository.GetProduct(id));

        }

        [HttpPost()]
        public ActionResult AddProduct(Product product)
        {
            try
            {
                this._repository.AddProduct(product);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPatch()]
        [HttpPut()]
        public ActionResult UpdateProduct(Product product)
        {
            try
            {
                this._repository.UpdateProduct(product);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("id")]
        public ActionResult DeleteProducts(int id)
        {
            try
            {
                this._repository.DeleteProduct(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
          
        }

    }
}
