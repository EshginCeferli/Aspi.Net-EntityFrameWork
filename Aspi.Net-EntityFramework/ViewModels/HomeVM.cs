using Aspi.Net_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspi.Net_EntityFramework.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders{ get; set; }
        public List<SliderDetail> SliderDetails { get; set; }
        public List<Work> Works { get; set; }
    }
}
