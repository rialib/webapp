//-----------------------------------------------------------------------
// <copyright file="User.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Data.Models
{
    using System;

    [Flags]
    public enum UserRole
    {
        RegularUser = 0,
        Administrator = 1,
        Moderators = 2
    }

    public class User
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public UserRole Role { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime LastLoginDate { get; set; }

        public DateTime LastActivityDate { get; set; }
    }
}
