//-----------------------------------------------------------------------
// <copyright file="Profile.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Models.Membership
{
    using System.ComponentModel.DataAnnotations;

    public class Profile
    {
        [Key]
        public int UserID { get; set; }

        [MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(20)]
        public string LastName { get; set; }

        public virtual User User { get; set; }
    }
}
