using System;
using System.Collections.Generic;
using System.Text;
using WATERLINE.Entities.Base;

namespace WATERLINE.Entities
{
    public class Configuration : BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }

        #region NormalsSettings
        public bool ViewableByNormals { get; set; } = false;
        public bool EditableByNormals { get; set; } = false;
        public bool DeletableByNormals { get; set; } = false;
        #endregion

        #region SupersSettings
        public bool EditableBySupers { get; set; } = true;
        public bool DeletableBySupers { get; set; } = true;
        public bool ViewableBySupers { get; set; } = true;
        #endregion
    }
}
