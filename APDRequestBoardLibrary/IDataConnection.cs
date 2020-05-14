using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDRequestBoardLibrary
{
    public interface IDataConnection
    {
        Person InputPerson(Person person);

        void DeletePerson(Person person);

        List<Person> ReadAllPersonData();
    }
}
