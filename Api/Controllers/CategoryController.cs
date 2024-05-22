using Core.Entities;
using InfraStructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly AppDb db;

        public CategoryController(AppDb _db)
        {
            db = _db;
        }
        [HttpGet("GetAll")]
        public ActionResult<List<Category>> GetAll()
        {
            return db.Categories.ToList();
        }

        [HttpGet("GetProduct/{id}")]
        public ActionResult<Category> GetProduct(int id)
        {
            return db.Categories.Find(id);
        }
        [HttpPost("AddCategory")]
        public ActionResult<List<Category>> AddCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return db.Categories.ToList();
        }
    }
}
