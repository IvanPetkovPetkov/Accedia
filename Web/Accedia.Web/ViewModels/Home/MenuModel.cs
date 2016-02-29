namespace Accedia.Web.ViewModels.Home
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class MenuModel
    {
        public IEnumerable<MenuItemModel> MenuItems { get; set; }
    }
}