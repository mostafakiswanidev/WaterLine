using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WATERLINE.Portal.ViewModels.User
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            Fullname = string.Format("{0} {1} {2}", Firstname, Middlename, Lastname);
        }

        public int Id { get; set; }
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
        public string Role { get; set; }
        public int RoleId { get; set; }
        public DateTime DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
