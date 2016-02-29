namespace Accedia.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Accedia.Data.Common.Models;

    public class UserLinkAddress : BaseModel<int>
    {
        public int UserID { get; set; }

        public int AddressID { get; set; }
    }
}
