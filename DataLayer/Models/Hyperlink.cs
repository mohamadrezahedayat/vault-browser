using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
  public class Hyperlink
    {
        public int HyperlinkId { get; set; }
        public string HyperlinkPath { get; set; }
        public virtual Navis3dModel Navis3DModel { get; set; }
        public int Navis3dModelId { get; set; }
    }
}
