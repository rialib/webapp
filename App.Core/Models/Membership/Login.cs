//-----------------------------------------------------------------------
// <copyright file="Login.cs" company="RIA Library Foundation">
//     Copyright © 2011 RIA Library Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace App.Models.Membership
{
    using System.ComponentModel.DataAnnotations;

    public enum LoginType : byte
    {
        Password,
        Facebook,
        Twitter
    }

    public class Login
    {
        [Key]
        public int UserID { get; set; }

        [Key]
        public int LoginID { get; set; }

        public byte LoginType { get; set; }

        [Required, MaxLength(50)]
        public string Key { get; set; }
    }
}
