namespace Accedia.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using Infrastructure.Mapping;

    using Services.Data;

    using ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IMenuItemService menuItemService;
        private readonly IUserService userService;

        public HomeController(
            IMenuItemService menuItemService,
            IUserService userService)
        {
            this.menuItemService = menuItemService;
            this.userService = userService;
        }

        public ActionResult Index()
        {
            var listUserAccedia = this.userService.GetAllUsers().ToList();
            var listUserEditModel = new List<UserEditModel>();
            foreach (var userAccedia in listUserAccedia)
            {
                var userEditModel = new UserEditModel
                {
                    Company = userAccedia.Company,
                    EMail = userAccedia.EMail,
                    Phone = userAccedia.Phone,
                    Skype = userAccedia.Skype
                };
                listUserEditModel.Add(userEditModel);
            }

            return this.View(listUserEditModel);
        }

        public ActionResult Services()
        {
            var viewModel = new UserEditModel
            {
                Company = "тест"
            };
            return this.View(viewModel);
        }

        public ActionResult Orders()
        {
            var viewModel = new UserEditModel
            {
                Company = "тест"
            };
            return this.View(viewModel);
        }

        public ActionResult Offices()
        {
            var viewModel = new UserEditModel
            {
                Company = "тест"
            };
            return this.View(viewModel);
        }

        public ActionResult Calc()
        {
            var viewModel = new UserEditModel
            {
                Company = "тест"
            };
            return this.View(viewModel);
        }

        public ActionResult UserEdit()
        {
            //string giudID = this.HttpContext.User.Identity.ToString();
            //string giudID = "19ZM2pjq6U4jVb283GZkCPNukjeyb2YZ2u";
            //var currentUser = this.userService.GetCurrentUser(giudID).FirstOrDefault();

            var viewModel = new UserEditModel
            {
                Company = "тест"
            };

            return this.View(viewModel);
        }
    }
}
