//-----------------------------------------------------------------------
// <copyright file="DatabaseTest.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Data.Tests
{
    using System;
    using System.Data.Entity.Database;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DatabaseTest
    {
        [TestMethod]
        public void EntitiesConstructorTest()
        {
            var target = new Database();
        }

        [TestMethod]
        public void UsersTest()
        {
            DbDatabase.SetInitializer<Database>(new DropCreateDatabaseAlways<Database>());

            // Setup
            var target = new Database();

            // Assert
            var result1 = target.Users.ToList();

            // Verify
            Assert.AreEqual(0, result1.Count);
        }
    }
}
