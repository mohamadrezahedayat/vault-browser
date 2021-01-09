using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public enum Version
    {
        a, b, c, d, e, f
    }
    
    public class Document
    {
        public string DocumentNumber { get; set; }
        public string Title { get; set; }
        //public File File { get; set; }
        public Version DocumentVersion { get; set; }

        public virtual Transmital Transmital { get; set; }
        public string TransmitalNumber { get; set; }

    }
}
