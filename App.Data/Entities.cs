//-----------------------------------------------------------------------
// <copyright file="Entities.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Data
{
    using System.Data.Entity;
    using App.Data.Models;

    public class Entities : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
