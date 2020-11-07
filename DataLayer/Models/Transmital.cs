using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public enum POI
    {
        IFA, IFC, IFI, AFC, AB
    }
    public class Transmital
    {
        public Transmital()
        {
            Documents = new HashSet<Document>();
        }
        public string TransmitalNumber { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public string POI { get; set; }

    }
}
