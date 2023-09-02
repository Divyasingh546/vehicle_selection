using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using V_Selection.Models;

namespace V_Selection.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateItem([FromBody] Item item)
        {
            // Here, you can process the received item data
            // You can save it to a database, perform validations, etc.

            // For simplicity, we'll return the received item as is.
            return Ok(item);
        }
    }

}
