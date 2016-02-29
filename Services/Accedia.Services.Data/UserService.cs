namespace Accedia.Services.Data
{
    using System;
    using System.Linq;

    using Accedia.Data.Common;
    using Accedia.Data.Models;
    using Accedia.Services.Web;
    using System.Collections.Generic;
    public class UserService : IUserService
    {
        private readonly IDbRepository<UserAccedia> users;
        private readonly IDbRepository<UserAddress> userAddresses;
        private readonly IIdentifierProvider identifierProvider;

        public UserService(IDbRepository<UserAccedia> users, IDbRepository<UserAddress> userAddresses) 
        {
            this.users = users;
            this.userAddresses = userAddresses;
        }

        public IQueryable<UserAccedia> GetCurrentUser(string guidUser)
        {
            return this.users.All().Where(x => x.ApplicationUserID == guidUser);
        }

        public IQueryable<UserAccedia> GetAllUsers()
        {
            return this.users.All();
        }
    }
}
