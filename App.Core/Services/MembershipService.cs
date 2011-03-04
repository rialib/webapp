//-----------------------------------------------------------------------
// <copyright file="MembershipService.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Services
{
    using System.Linq;
    using App.Database;
    using Membership = App.Models.Membership;

    public interface IMembershipService
    {
        Membership.User GetUser(int userID, bool NoTracking = true);

        Membership.User GetUser(string username, bool NoTracking = true);
    }

    public class MembershipService : IMembershipService
    {
        private readonly IMembershipContext db;

        public MembershipService(IMembershipContext membershipContext)
        {
            this.db = membershipContext;
        }

        Membership.User GetUser(int userID, bool NoTracking)
        {
            if (NoTracking)
            {
                return db.Users.AsNoTracking().FirstOrDefault(x => x.UserID == userID);
            }

            return db.Users.Find(userID);
        }

        Membership.User GetUser(string username, bool NoTracking)
        {
            if (NoTracking)
            {
                return db.Users.AsNoTracking().FirstOrDefault(x => x.UserName == username);
            }

            return db.Users.FirstOrDefault(x => x.UserName == username);
        }
    }
}
