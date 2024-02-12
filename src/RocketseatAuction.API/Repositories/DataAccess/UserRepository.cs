using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class UserRepository: IUserRepository {
    private readonly RocketseatAuctionDBContext _dBContext;
    public UserRepository(RocketseatAuctionDBContext dBContext) => _dBContext = dBContext;

    public bool ExistUserWithEmail(string email) => _dBContext.Users.Any(user => user.Email.Equals(email));
    
    public User GetUserByEmail(string email) => _dBContext.Users.First(user => user.Email.Equals(email));
    
}
