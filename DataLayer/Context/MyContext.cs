using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Transmital> Transmitals { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Person  
            modelBuilder.Entity<Person>()
                .Property(t => t.PersonID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Person>()
               .Property(t => t.Name)
               .IsRequired()
               .HasMaxLength(50);

            //File
            modelBuilder.Entity<File>()
                .Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<File>()
               .Property(t => t.FileName)
               .HasMaxLength(50)
               .IsRequired()
               .HasColumnType("nvarchar");

            modelBuilder.Entity<File>()
              .Property(t => t.LastComment)
              .IsMaxLength();

            modelBuilder.Entity<File>()
             .HasRequired(f => f.Creator)
             .WithMany(p => p.CreatedFiles)
             .HasForeignKey(f => f.CreatorId)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<File>()
             .HasRequired(p => p.LastEditor)
             .WithMany(a => a.EditedFiles)
             .HasForeignKey(f => f.EditorId)
             .WillCascadeOnDelete(false);

            //modelBuilder.Entity<File>()
            //.HasRequired(d => d.Document)
            //.WithOptional(f => f.File);

            //Document
            modelBuilder.Entity<Document>()
             .HasKey(d => d.DocumentNumber)
             .Property(d => d.DocumentNumber)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Document>()
            .HasRequired(t => t.Transmital)
            .WithMany(d=>d.Documents)
            .HasForeignKey(t => t.TransmitalNumber)
            .WillCascadeOnDelete(false);

           // modelBuilder.Entity<Document>()
           //.HasOptional(f => f.File)
           //.WithRequired(d => d.Document)
           //.WillCascadeOnDelete(false);

            //Transmital
            modelBuilder.Entity<Transmital>()
             .HasKey(t => t.TransmitalNumber)
             .Property(t => t.TransmitalNumber)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

        }
    }

}
