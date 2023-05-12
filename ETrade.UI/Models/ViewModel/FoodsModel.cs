using ETrade.DTO;
using ETrade.Ent;

namespace ETrade.UI.Models.ViewModel
{
    public class FoodsModel:BaseCrud
    {
        public Foods  Foods{ get; set; } = new Foods();
        public List<CategoriesDTO> Cats { get; set; }
    }
}
