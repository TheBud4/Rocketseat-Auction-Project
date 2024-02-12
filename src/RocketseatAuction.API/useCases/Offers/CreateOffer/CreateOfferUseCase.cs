﻿using RocketseatAuction.API.Communication.Requests;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Services;

namespace RocketseatAuction.API.useCases.Offers.CreateOffer;

public class CreateOfferUseCase {

    private readonly ILoggedUser _loggedUser;
    private readonly IOfferRepository _repository;
    public CreateOfferUseCase(ILoggedUser loggedUser, IOfferRepository repository) {
        _loggedUser = loggedUser;
        _repository = repository;
    }
    public int Execute(int ItemId,RequestCreateOfferJson request) {

        var user =  _loggedUser.User();

        var offer = new Offer {
            CreatedOn = DateTime.Now,
            ItemId = ItemId,
            Price = request.Price,
            UserId = user.Id,
        };
        _repository.Add(offer);

        return offer.Id;
    }
}
