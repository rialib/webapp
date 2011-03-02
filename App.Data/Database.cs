//-----------------------------------------------------------------------
// <copyright file="Database.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Data
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using App.Data.Configuration;
    using Membership = App.Data.Models.Membership;

    public class Database : DbContext
    {
        public DbSet<Membership.User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Add(new TableSchemaConvention());
        }
    }
}
