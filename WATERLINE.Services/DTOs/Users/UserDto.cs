using System;
using System.Collections.Generic;
using System.Text;

namespace WATERLINE.Services.DTOs.Users
{
    public class UserDto
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Password { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public bool IsPhonenumberConfirmed { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
    }
}
