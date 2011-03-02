//-----------------------------------------------------------------------
// <copyright file="User.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Data.Models.Membership
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string UserName { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required, MaxLength(50)]
        public string DisplayName { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime LastLoginDate { get; set; }

        public DateTime LastActivityDate { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsModerator { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
