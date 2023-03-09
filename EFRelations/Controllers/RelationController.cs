using EFRelations.DTO;
using EFRelations.DTO.OneToMany;
using Microsoft.AspNetCore.Mvc;

namespace EFRelations.Controllers
{
    public class RelationController : Controller
    {
        private readonly AddDbContext db;

        public RelationController(AddDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var model = (from p in db.Product
                         join c in db.Category
                            on p.CategoryId equals c.Id
                         select new Product
                         {
                             Id = p.Id,
                             ProductName = p.ProductName,
                             CategoryId = p.CategoryId,
                             Category=p.Category
                             


                         }).ToList();
            return Json(model);
        }
    }
}
