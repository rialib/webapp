//-----------------------------------------------------------------------
// <copyright file="DatabaseContext.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Database
{
    using System.Data.Entity;
    using System.Data.Entity.Database;
    using System.Data.Entity.ModelConfiguration;
    using App.Database.Conventions;

    public partial class DatabaseContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // If you don't want to create and use EdmMetadata table 
            // for monitoring the correspondence 
            // between the current model and table structure 
            // created in a database, then turn off IncludeMetadataConvention: 
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            modelBuilder.Conventions.Add(new TableSchemaConvention());

            base.OnModelCreating(modelBuilder);
        }
    }
}
