using System;
using System.Collections.Generic;
using System.Text;
using WATERLINE.Helpers.Region;

namespace WATERLINE.Entities.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Arabic { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; } = DateTimeHelper.CurrentDateTime();
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
