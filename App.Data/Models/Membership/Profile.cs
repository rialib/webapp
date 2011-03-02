//-----------------------------------------------------------------------
// <copyright file="Profile.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Data.Models.Membership
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ComponentModel.DataAnnotations;

    public class Profile
    {
        [Key, ForeignKey("ID")]
        public int UserID { get; set; }

        [MaxLength(27)]
        public string FirstName { get; set; }

        [MaxLength(25)]
        public string LastName { get; set; }

        public virtual User User { get; set; }
    }
}
