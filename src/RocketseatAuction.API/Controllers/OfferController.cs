using Microsoft.AspNetCore.Mvc;

namespace RocketseatAuction.API.Controllers;

public class OfferController : RocketseatAuctionBaseController {
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute]int itemId) {
        return Created();
        }
    }
