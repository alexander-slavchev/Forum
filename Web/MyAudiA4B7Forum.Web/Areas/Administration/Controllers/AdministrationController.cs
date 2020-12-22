namespace MyAudiA4B7Forum.Web.Areas.Administration.Controllers
{
    using MyAudiA4B7Forum.Common;
    using MyAudiA4B7Forum.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
