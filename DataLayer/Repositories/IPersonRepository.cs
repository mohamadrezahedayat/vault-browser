using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IPersonRepository
    {
        List<Person> GetAllPerson();
        Person GetPersonById(int PersonId);
        void InsertPerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(Person person);
        void DeletePerson(int PersonId);
        void Save();
    }
}
