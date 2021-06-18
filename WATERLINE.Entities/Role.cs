using System;
using System.Collections.Generic;
using System.Text;
using WATERLINE.Entities.Base;

namespace WATERLINE.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
