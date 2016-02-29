namespace Accedia.Web.ViewModels.Home
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Data.Models;
    using Infrastructure.Mapping;

    public class UserEditModel : IMapFrom<AccadiaMenuItem>, IMapTo<AccadiaMenuItem>
    {
        public string ApplicationUserID { get; set; }

        public bool IsCompany { get; set; }

        public string Company { get; set; }

        public string INNumber { get; set; }

        public string TaxNo { get; set; }

        public string MOL { get; set; }

        public int CityID { get; set; }

        public int AddressLinkID { get; set; }

        public string Phone { get; set; }

        public string EMail { get; set; }

        public string Skype { get; set; }

        public virtual ICollection<UserLinkAddress> AddressLinkUser { get; set; }
    }
}