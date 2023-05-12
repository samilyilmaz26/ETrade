using ETrade.DTO;
using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
	public class FoodController : BaseController
	{
        private readonly FoodsModel model;
      
        public FoodController(IUow uow, FoodsModel model) : base(uow)
        {
            this.model = model;
        }
        
        public IActionResult List()
		{
			return View(uow.foodsRepos.GetFoods());
		}
        public IActionResult Create()
        {
            model.Text = "Kaydet";
            model.Head = "Yeni Giriş";
            model.Class = "btn btn-primary";
            model.Cats = uow.categoriesRepos.GetCategories();   
            return View("Crud",model);
        }
        [HttpPost]
        public IActionResult Create(FoodsModel m)
        {
            uow.foodsRepos.Add(m.Foods);
            uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Update(Guid id )
        {
            model.Foods = uow.foodsRepos.Find(id);
            model.Text = "Güncelle";
            model.Head = "Güncelleme";
            model.Class = "btn btn-success";
            model.Cats = uow.categoriesRepos.GetCategories();
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Update(FoodsModel m)
        {
            uow.foodsRepos.Update(m.Foods);
            uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(Guid id)
        {
            model.Foods = uow.foodsRepos.Find(id);
            model.Text = "Sil";
            model.Head = "Silme";
            model.Class = "btn btn-danger";
            model.Cats = uow.categoriesRepos.GetCategories();
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Delete(FoodsModel m)
        {
            uow.foodsRepos.Delete(m.Foods);
            uow.Commit();
            return RedirectToAction("List");
        }
    }
}
