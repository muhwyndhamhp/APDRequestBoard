using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDRequestBoardLibrary
{
    public class TextConnector : IDataConnection
    {
        public void DeletePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Person InputPerson(Person person)
        {
            //TODO  - later do the correct way to export to text
            person.Id = 1;

            return person;
        }

        public List<Person> ReadAllPersonData()
        {
            throw new NotImplementedException();
        }
    }
}
