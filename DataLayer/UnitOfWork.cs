using DataLayer.Context;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IDisposable
    {
        MyContext db = new MyContext();

        private GenericRepository<Person> personRipository;
        private GenericRepository<File> fileRipository;
        private GenericRepository<Document> documentRipository;
        private GenericRepository<Transmital> transmitalRipository;
        public GenericRepository<Person> PersonRipository
        {
            get
            {
                if (personRipository == null)
                {
                    personRipository = new GenericRepository<Person>(db);
                }
                return personRipository;
            }
        }
        public GenericRepository<File> FileRipository
        {
            get
            {
                if (fileRipository == null)
                {
                    fileRipository = new GenericRepository<File>(db);
                }
                return fileRipository;
            }
        }
        public GenericRepository<Document> DocumentRipository
        {
            get
            {
                if (documentRipository == null)
                {
                    documentRipository = new GenericRepository<Document>(db);
                }
                return documentRipository;
            }
        }
        public GenericRepository<Transmital> TransmitalRipository
        {
            get
            {
                if (transmitalRipository == null)
                {
                    transmitalRipository = new GenericRepository<Transmital>(db);
                }
                return transmitalRipository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
