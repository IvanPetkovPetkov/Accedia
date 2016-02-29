namespace Accedia.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Accedia.Data.Common;
    using Accedia.Data.Models;

    public class UserAccadiaService : IUserAccadiaService
    {
        private readonly IDbRepository<UserAccedia> userAccedia;
        private readonly IDbRepository<UserAddress> userAddress;

        public UserAccadiaService(IDbRepository<UserAccedia> userAccedia, IDbRepository<UserAddress> userAddress)
        {
            this.userAccedia = userAccedia;
            this.userAddress = userAddress;
        }

        public void AddUserWithAddress(UserAccedia itemUserAccedia, UserAddress userAddress)
        {
            this.userAddress.Add(userAddress);
            this.userAddress.Save();
            itemUserAccedia.AddressLinkID = userAddress.Id;
            this.userAccedia.Add(itemUserAccedia);
            this.userAccedia.Save();
        }
    }
}
