namespace Accedia.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Accedia.Data.Common;
    using Accedia.Data.Models;

    public class MenuItemService : IMenuItemService
    {
        private readonly IDbRepository<AccadiaMenuItem> accadiaMenuItems;

        public MenuItemService(IDbRepository<AccadiaMenuItem> accadiaMenuItems)
        {
            this.accadiaMenuItems = accadiaMenuItems;
        }

        public IQueryable<AccadiaMenuItem> GetVisibleMenuItems()
        {
            return this.accadiaMenuItems.All().Where(x => x.IsVisible).OrderBy(x => x.OrderNumber);
        }
    }
}
