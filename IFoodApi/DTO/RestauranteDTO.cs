using System.ComponentModel.DataAnnotations;

namespace IFoodApi.DTO
{
    public class RestauranteDTO
    {
        public string acessToken { get; set; }
        public string type { get; set; }
        public int expiresIn { get; set; }
    }
}
