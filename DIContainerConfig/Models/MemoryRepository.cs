using System.Collections.Generic;
using System.Linq;

namespace DIContainerConfig.Models
{
    public class MemoryRepository : IPersonRepository
    {
        public MemoryRepository(ISingletonRepository singletonRepository, IScopeRepository scopeRepository, ITransiantRepository transiantRepository)
        {
            this.singletonRepository = singletonRepository;
            this.scopeRepository = scopeRepository;
            this.transiantRepository = transiantRepository;
            people = new Dictionary<string, Person>();
            new List<Person>
            {
                new Person{id=1,FullName="Ali Alizade"},
                new Person{id=2,FullName="Rebi poori"}
            }.ForEach(p => AddPerson(p));

        }
                private Dictionary<string, Person> people;

        private readonly ISingletonRepository singletonRepository;
        private readonly IScopeRepository scopeRepository;
        private readonly ITransiantRepository transiantRepository;

        public IEnumerable<Person> People => people.Values;

        public void AddPerson(Person person)
        {
            people[person.FullName] = person;
        }

        public void DeletePerson(Person person)
        {
            people.Remove(person.FullName);
        }

        public Person GetByName(string name)
        {
            return people[name];
        }
    }
}
