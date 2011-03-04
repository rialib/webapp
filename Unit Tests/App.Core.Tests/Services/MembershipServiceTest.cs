//-----------------------------------------------------------------------
// <copyright file="MembershipServiceTest.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Core.Tests.Services
{
    using App.Services;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using App.Database;
    using App.Models.Membership;

    [TestClass]
    public class MembershipServiceTest
    {
        [TestMethod, DeploymentItem("App.Core.dll")]
        public void GetUserTest()
        {
            IMembershipContext membershipContext = null; // TODO: Initialize to an appropriate value
            IMembershipService target = new MembershipService(membershipContext); // TODO: Initialize to an appropriate value
            int userID = 0; // TODO: Initialize to an appropriate value
            bool NoTracking = false; // TODO: Initialize to an appropriate value
            User expected = null; // TODO: Initialize to an appropriate value
            User actual;
            actual = target.GetUser(userID, NoTracking);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
