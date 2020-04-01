using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Stores : BaseEntity
    {
        public string StoreName { get; set; }
        public string Description { get; set; }
    }
}
