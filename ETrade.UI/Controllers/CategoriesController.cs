using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly CategoriesModel model;

        
        public CategoriesController(IUow uow , CategoriesModel model ) : base(uow)
        {
            this.model = model;
        }

        public IActionResult List()
        {
            return View(uow.categoriesRepos.GetCategories());
        }
        public IActionResult Create() 
        {
            model.Text = "Kaydet";
            model.Head = "Yeni Giriş";
            model.Class = "btn btn-primary";
            return View("Crud",model);  
        }
        [HttpPost]
        public IActionResult Create(CategoriesModel m)
        {
            uow.categoriesRepos.Add(m.Categories);
            uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Update(Guid id)
        {
            model.Categories = uow.categoriesRepos.Find(id);
            model.Text = "Güncelle";
            model.Head = "Güncelleme İşlemi";
            model.Class = "btn btn-success";
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Update(CategoriesModel m)
        {
            uow.categoriesRepos.Update(m.Categories);
            uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(Guid id)
        {
            model.Categories = uow.categoriesRepos.Find(id);
            model.Text = "Sil";
            model.Head = "Silme İşlemi";
            model.Class = "btn btn-danger";
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Delete(CategoriesModel m)
        {
            uow.categoriesRepos.Delete(m.Categories);
            uow.Commit();
            return RedirectToAction("List");
        }
    }
}
