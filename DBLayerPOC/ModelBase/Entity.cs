using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayerPOC.ModelBase
{
    /// <summary>
    /// Comment this line of code..
    /// TODO - Define table relations
    /// Review Access file
    /// </summary>
    public class Entity
    {
        public int Id { get; set; }

        public DateTime? LastChangeDateTime { get; set; }

        public int? LastChangeUserId { get; set; }
    }
}
