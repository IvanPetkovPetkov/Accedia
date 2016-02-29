namespace Accedia.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using Accedia.Common;
    using Accedia.Web.Controllers;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    public class AdministrationController : BaseController
    {
    }
}
