namespace Accedia.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Accedia.Data.Common.Models;

    public class UserAddress : BaseModel<int>
    {
        public int TownID { get; set; }

        public string AddressText { get; set; }

        public virtual ICollection<UserLinkAddress> AddressLinkUser { get; set; }
    }
}
