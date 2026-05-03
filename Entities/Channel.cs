using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Channel
    {
        public required string Name { get; set; }
        public required string Description { get; set; } 

        public string? Type { get; set; }
    }
}
