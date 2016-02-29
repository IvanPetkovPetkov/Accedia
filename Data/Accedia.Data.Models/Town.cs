namespace Accedia.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Common.Models;

    public class Town : BaseModel<int>
    {
        public string Name { get; set; }
    }
}