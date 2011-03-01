using App.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using App.Data.Models;
using System.Data.Entity;
//-----------------------------------------------------------------------
// <copyright file="EntitiesTest.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Data.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EntitiesTest
    {
        [TestMethod]
        public void EntitiesConstructorTest()
        {
            var target = new Entities();
        }

        [TestMethod]
        public void UsersTest()
        {
            // Setup
            var target = new Entities();

            // Assert
            var result = target.Users.ToList();

            // Verify
            Assert.AreEqual(0, result.Count);
        }
    }
}
