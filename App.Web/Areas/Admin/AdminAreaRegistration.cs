//-----------------------------------------------------------------------
// <copyright file="AdminAreaRegistration.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Web.Areas.Admin
{
    using System.Web.Mvc;

    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
