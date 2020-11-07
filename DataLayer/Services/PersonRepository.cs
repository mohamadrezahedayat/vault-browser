using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace DataLayer.Services
{
    public class PersonRepository : IPersonRepository
    {
        private MyContext db;
        public PersonRepository(MyContext myContext)
        {
            db = myContext;
        }
        public List<Person> GetAllPerson()
        {
            return db.Persons.ToList();
        }
        public Person GetPersonById(int PersonId)
        {
            return db.Persons.Find(PersonId);
        }
        public void InsertPerson(Person person)
        {
            db.Persons.Add(person);
        }
        public void UpdatePerson(Person person)
        {
            db.Entry(person).State = EntityState.Modified;
        }
        public void DeletePerson(Person person)
        {
            db.Entry(person).State = EntityState.Deleted;
        }

        public void DeletePerson(int PersonId)
        {
            var person = GetPersonById(PersonId);
            DeletePerson(person);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}







