﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public enum FileStates
    {
        a,
        b,
        c,
        d,
        e
    }
    public class File
    {
        public long ID { get; set; }
        public string FileName { get; set; }
        //public Document Document { get; set; }
        public virtual Person Creator { get; set; }
        public long CreatorId { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual Person LastEditor { get; set; }
        public long EditorId { get; set; }
        public DateTime LastRevisionDate { get; set; }
        public long LastRevisionID { get; set; }
        public string LastComment { get; set; }
        public FileStates LastState { get; set; }
    }
}
