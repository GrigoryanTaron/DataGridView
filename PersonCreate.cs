using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
    public class PersonManager : ICreate
    {
        
        public IEnumerable<Person> Create(int count, int minAge)
        {
            
           var person = new List<Person>(count);
            for (int i = 0; i < count; i++)
            {
                person.Add(new Person()
                {
                    Id= i,
                    FirstName = $"FirstName{i}",
                    LastName = $"LastName{i}",
                    Age = new Random().Next(minAge, 90),

                });
            }
            return person;
            
        }
     
      
    }
}
