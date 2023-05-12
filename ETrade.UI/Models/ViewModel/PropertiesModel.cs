using ETrade.DTO;
using ETrade.Ent;

namespace ETrade.UI.Models.ViewModel
{
    public class PropertiesModel:BaseCrud
    {
        public Properties  Properties{ get; set; } = new Properties();  
        public List<FoodDTO> FoodDTOs { get; set; }
    }
}
