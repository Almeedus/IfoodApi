using System.Collections.Generic;
using System.Threading.Tasks;
using IFoodApi.Data;
using IFoodApi.Models;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;




namespace IFoodApi.Controllers.v1
{
    public class RestauranteController
    {
        [ApiController]
        [Route("v1/IFoodApi")]
        public class CategoryController : ControllerBase
        {
            [HttpPost]
            [Route("")]
            public async Task<ActionResult<Restaurante>> Post([FromServices] DataContext context, [FromBody] Restaurante restaurante)
            {
                if (ModelState.IsValid)
                {
                    context.Restaurantes.Add(restaurante);
                    await context.SaveChangesAsync();
                    return restaurante;
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
        }

    }
}
