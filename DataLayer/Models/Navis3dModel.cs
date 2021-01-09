using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Navis3dModel
    {
        public Navis3dModel()
        {
            Hyperlinks = new HashSet<Hyperlink>();
        }
        public int Navis3dModelId { get; set; }
        public string ItemName { get; set; }
        public virtual ICollection<Hyperlink> Hyperlinks {get;set;}
        public string demo{ get; set; }
    }
}
