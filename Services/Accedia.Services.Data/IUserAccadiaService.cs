namespace Accedia.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Accedia.Data.Models;

    public interface IUserAccadiaService
    {
        void AddUserWithAddress(UserAccedia itemUserAccedia, UserAddress userAddress);
    }
}
