using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class OfferRepository: IOfferRepository {

    private readonly RocketseatAuctionDBContext _dBContext;
    public OfferRepository(RocketseatAuctionDBContext dBContext) => _dBContext = dBContext;
    public void Add(Offer offer) {
        _dBContext.Offers.Add(offer);
        _dBContext.SaveChanges();
    }
}
