using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DIContainerConfig.Models
{
    public interface IPersonRepository
    {
        IEnumerable<Person> People { get; }
        Person GetByName(string name);
        void AddPerson(Person person);
        void DeletePerson(Person person);
    }
}
