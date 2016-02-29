namespace Accedia.Web.ViewModels.Home
{
    using Accedia.Data.Models;
    using Accedia.Services.Web;
    using Accedia.Web.Infrastructure.Mapping;

    using AutoMapper;

    public class MenuItemModel : IMapFrom<AccadiaMenuItem>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}