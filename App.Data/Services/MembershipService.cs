//-----------------------------------------------------------------------
// <copyright file="MembershipService.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Data.Services
{
    public interface IMembershipService
    {
        
    }

    public class MembershipService : IMembershipService
    {
        private readonly Database db;

        public MembershipService(Database dbContext)
        {
            db = dbContext;
        }
    }
}
