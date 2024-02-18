using RestWithASPNETUdemy.Controllers.Model;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i ++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        public Person FindByID(long id)
        {
            return new Person 
            {
                Id = IncrementAndGet(),
                FirstName = "Patricia",
                LastName = "Machado",
                Adress = "São Paulo - São Paulo/Brasil",
                Gender = "Female"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + 1,
                LastName = "Person LastName" + 1,
                Adress = "Some Address" + 1,
                Gender = "Female"
            };
        }

        private long IncrementAndGet()
        {
            
            return Interlocked.Increment(ref count);
        }
    }
}
