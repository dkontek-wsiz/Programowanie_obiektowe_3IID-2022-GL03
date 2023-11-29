using System;
using System.Collections.Generic;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    public class MockPersonRepository : IPersonRepository
    {
        public void Create(Person input)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Person Get(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Person input)
        {
            throw new NotImplementedException();
        }
    }
}
