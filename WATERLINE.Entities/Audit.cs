﻿using System;
using System.Collections.Generic;
using System.Text;
using WATERLINE.Entities.Base;

namespace WATERLINE.Entities
{
    public class Audit : BaseEntity
    {
        public string UserId { get; set; }
        public string Type { get; set; }
        public string TableName { get; set; }
        public DateTime DateTime { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }
        public string AffectedColumns { get; set; }
        public string PrimaryKey { get; set; }
    }
}
