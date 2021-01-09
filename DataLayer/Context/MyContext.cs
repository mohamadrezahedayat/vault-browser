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
        public DbSet<Navis3dModel> Navis3dModels { get; set; }



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
               .HasKey(t => t.FullPath)
               .Property(t => t.FullPath)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
               .IsMaxLength()
               .HasColumnType("nvarchar");

            modelBuilder.Entity<File>()
              .Property(t => t.LastComment)
              .HasColumnType("nvarchar")
              .IsMaxLength();

            modelBuilder.Entity<File>()
              .Property(t => t.DocumentNumber)
              .HasMaxLength(50)
              .IsOptional();

            modelBuilder.Entity<File>()
             .HasRequired(f => f.Creator)
             .WithMany(p => p.CreatedFiles)
             .HasForeignKey(f => f.CreatorId)
             .WillCascadeOnDelete(true);

            modelBuilder.Entity<File>()
             .HasRequired(p => p.LastEditor)
             .WithMany(a => a.EditedFiles)
             .HasForeignKey(f => f.EditorId)
             .WillCascadeOnDelete(false);


            //Document
            modelBuilder.Entity<Document>()
             .HasKey(d => d.DocumentNumber)
             .Property(d => d.DocumentNumber)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Document>()
            .HasRequired(t => t.Transmital)
            .WithMany(d => d.Documents)
            .HasForeignKey(t => t.TransmitalNumber)
            .WillCascadeOnDelete(false);

            //Transmital
            modelBuilder.Entity<Transmital>()
             .HasKey(t => t.TransmitalNumber)
             .Property(t => t.TransmitalNumber)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            //NavisedModel
            modelBuilder.Entity<Navis3dModel>()
             .HasKey(t => t.Navis3dModelId);
            modelBuilder.Entity<Navis3dModel>()
             .Property(t => t.ItemName)
             .IsRequired()
             .HasMaxLength(50);
            modelBuilder.Entity<Navis3dModel>()
            .Property(t => t.demo)
            .IsOptional()
            .HasMaxLength(50)
            .HasColumnType("nvarchar");

            //Hyperlinks
            modelBuilder.Entity<Hyperlink>()
            .HasKey(t => t.HyperlinkId);
            modelBuilder.Entity<Hyperlink>()
            .Property(p => p.HyperlinkPath)
            .IsMaxLength()
            .IsRequired()
            .HasColumnType("nvarchar");

            modelBuilder.Entity<Hyperlink>()
           .HasRequired(a => a.Navis3DModel)
           .WithMany(h => h.Hyperlinks)
           .HasForeignKey(h => h.Navis3dModelId);
        }
    }

}
