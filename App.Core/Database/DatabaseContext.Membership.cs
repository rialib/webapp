//-----------------------------------------------------------------------
// <copyright file="DatabaseContext.Membership.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Database
{
    using System.Data.Entity;
    using App.Models.Membership;

    public interface IMembershipContext
    {
        DbSet<User> Users { get; set; }

        DbSet<Login> Logins { get; set; }

        DbSet<Profile> Profiles { get; set; }
    }

    public partial class DatabaseContext : DbContext, IMembershipContext
    {
        DbSet<User> IMembershipContext.Users { get; set; }

        DbSet<Login> IMembershipContext.Logins { get; set; }

        DbSet<Profile> IMembershipContext.Profiles { get; set; }
    }
}
