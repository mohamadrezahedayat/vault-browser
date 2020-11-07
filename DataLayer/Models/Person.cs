using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Person
    {
        public Person()
        {
            CreatedFiles = new HashSet<File>();
            EditedFiles = new HashSet<File>();
        }
        public long PersonID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<File> CreatedFiles { get; set; }
        public virtual ICollection<File> EditedFiles { get; set; }
    }
}
