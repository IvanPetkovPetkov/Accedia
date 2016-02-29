namespace Accedia.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Common.Models;

    public class UserAccedia : BaseModel<int>
    {
        public string ApplicationUserID { get; set; }

        public bool IsCompany { get; set; }

        public string Company { get; set; }

        public string INNumber { get; set; }

        public string TaxNo { get; set; }

        public string MOL { get; set; }

        public int AddressLinkID { get; set; }

        public string Phone { get; set; }

        public string EMail { get; set; }

        public string Skype { get; set; }

        public string FilePath { get; set; }

        public virtual ICollection<UserLinkAddress> AddressLinkUser { get; set; }
    }
}
