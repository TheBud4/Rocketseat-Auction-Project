using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;

namespace RocketseatAuction.API.useCases.Auctions.getCurrent;

public class GetCurrentAuctionUseCase {
    public Auction? Execute() {
        var repository = new RocketseatAuctionDBContext();

        var today = DateTime.Now;
        return repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
        }
    }
