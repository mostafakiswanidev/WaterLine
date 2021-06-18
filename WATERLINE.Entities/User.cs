using System;
using System.Collections.Generic;
using System.Text;
using WATERLINE.Entities.Base;

namespace WATERLINE.Entities
{
    public class User : BaseEntity
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public bool IsEmailConfirmed { get; set; } = false;
        public bool IsPhonenumberConfirmed { get; set; } = false;
        public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
