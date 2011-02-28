//-----------------------------------------------------------------------
// <copyright file="AccountController.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Web.Controllers
{
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;
    using System.Web.Security;
    using App.Web.Models;

    public class AccountController : Controller
    {
        public IFormsAuthenticationService FormsService { get; set; }

        public IMembershipService MembershipService { get; set; }

        //// URL: /Account/LogOn

        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (MembershipService.ValidateUser(model.UserName, model.Password))
                {
                    FormsService.SignIn(model.UserName, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError(String.Empty, "The user name or password provided is incorrect.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //// URL: /Account/LogOff

        public ActionResult LogOff()
        {
            FormsService.SignOut();

            return RedirectToAction("Index", "Home");
        }

        //// URL: /Account/Register

        public ActionResult Register()
        {
            ViewBag.PasswordLength = MembershipService.MinPasswordLength;
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                MembershipCreateStatus createStatus = MembershipService.CreateUser(model.UserName, model.Password, model.Email);

                if (createStatus == MembershipCreateStatus.Success)
                {
                    FormsService.SignIn(model.UserName, false /* createPersistentCookie */);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(String.Empty, AccountValidation.ErrorCodeToString(createStatus));
                }
            }

            // If we got this far, something failed, redisplay form
            ViewBag.PasswordLength = MembershipService.MinPasswordLength;
            return View(model);
        }

        //// URL: /Account/ChangePassword

        [Authorize]
        public ActionResult ChangePassword()
        {
            ViewBag.PasswordLength = MembershipService.MinPasswordLength;
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                if (MembershipService.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword))
                {
                    return RedirectToAction("ChangePasswordSuccess");
                }
                else
                {
                    ModelState.AddModelError(String.Empty, "The current password is incorrect or the new password is invalid.");
                }
            }

            // If we got this far, something failed, redisplay form
            ViewBag.PasswordLength = MembershipService.MinPasswordLength;
            return View(model);
        }

        //// URL: /Account/ChangePasswordSuccess

        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }

        protected override void Initialize(RequestContext requestContext)
        {
            if (FormsService == null)
            {
                FormsService = new FormsAuthenticationService();
            }

            if (MembershipService == null)
            {
                MembershipService = new AccountMembershipService();
            }

            base.Initialize(requestContext);
        }
    }
}
