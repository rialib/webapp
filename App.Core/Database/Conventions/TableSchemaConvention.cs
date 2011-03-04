//-----------------------------------------------------------------------
// <copyright file="DefaultSchemaConvention.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Database.Conventions
{
    using System;
    using System.Data.Entity.ModelConfiguration.Configuration.Types;
    using System.Data.Entity.ModelConfiguration.Conventions.Configuration;

    internal class TableSchemaConvention : IConfigurationConvention<Type, EntityTypeConfiguration>
    {
        void IConfigurationConvention<Type, EntityTypeConfiguration>.Apply(Type memberInfo, Func<EntityTypeConfiguration> configuration)
        {
            var cfg = configuration();

            var tableName = cfg.EntitySetName;

            if (String.IsNullOrEmpty(tableName))
            {
                tableName = memberInfo.Name;
            }

            var tableSchema = memberInfo.Namespace;

            var lastDotPosition = tableSchema.LastIndexOf('.');

            if (lastDotPosition > 0)
            {
                tableSchema = tableSchema.Substring(lastDotPosition + 1, tableSchema.Length - lastDotPosition - 1);
            }

            cfg.ToTable(tableName, tableSchema);
        }
    }
}
