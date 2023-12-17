
using Microsoft.AspNetCore.Mvc;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly Repository _repository;

        public CategoryController(Repository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult GetCategories()
        {
            return Ok(this._repository.GetAllCategories());

        }

        [HttpGet("id")]
        public ActionResult GetCategory(int id)
        {
            return Ok(this._repository.GetCategory(id));

        }

        [HttpPost()]
        public ActionResult AddCategory(Category category)
        {
            try
            {
                this._repository.AddCategory(category);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPatch()]
        [HttpPut()]
        public ActionResult UpdateCategory(Category category)
        {
            try
            {
                this._repository.UpdateCategory(category);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("id")]
        public ActionResult DeleteCategories(int id)
        {
            try
            {
                this._repository.DeleteCategory(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
