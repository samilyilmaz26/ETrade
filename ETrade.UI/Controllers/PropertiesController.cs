using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class PropertiesController : BaseController
    {
        private readonly PropertiesModel model;

        public PropertiesController(IUow uow, PropertiesModel model) : base(uow)
        {
            this.model = model;
        }

        public IActionResult List()
        {
            return View(uow.propertiesRepos.GetProperties());
        }
        public IActionResult Create()
        {
            model.Text = "Ekle";
            model.Head = "Yeni Giriş";
            model.Class = "btn btn-primary";
            model.FoodDTOs = uow.foodsRepos.GetFoods(); 
            return View("Crud" , model);
        }
        [HttpPost]
        public IActionResult Create(PropertiesModel m)
        {
            uow.propertiesRepos.Add(m.Properties);
            uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Update(Guid Id)
        {
            model.Text = "Save";
            model.Head = "Özellik Güncelle";
            model.Class = "btn btn-success my-2";
            model.Properties = uow.propertiesRepos.Find(Id);
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Update(PropertiesModel m)
        {
            uow.propertiesRepos.Update(m.Properties);
            uow.Commit();
            return RedirectToAction("List");

        }
        public IActionResult Delete(Guid Id)
        {
            uow.propertiesRepos.Delete(uow.propertiesRepos.Find(Id));
            uow.Commit();
            return RedirectToAction("List");
        }
    }
}
