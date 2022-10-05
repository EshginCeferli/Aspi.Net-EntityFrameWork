using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspi.Net_EntityFramework.Models
{
    public class Work: BaseEntitity
    {
        public string Image { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
    }
}
