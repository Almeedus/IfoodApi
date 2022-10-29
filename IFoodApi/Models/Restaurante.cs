using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IFoodApi.Models
{
    public class Restaurante
    {
        [Required]
        public string clientId { get; set; } = "";
        public string clientSecret { get; set; } = "";
        public string grantType { get; set; } = "";

        public string acessToken { get; set; } = "";
        public string type { get; set; } = "";
        public int expiresIn { get; set; }
    }
}
