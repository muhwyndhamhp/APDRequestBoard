using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDRequestBoardLibrary
{
    public class SqlConnector : IDataConnection
    {
        public Person InputPerson(Person person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                person.Id = cnn.Query<int>(
                    @"INSERT INTO Person (Name, Address, PhoneNumber, Email) VALUES (@Name, @Address, @PhoneNumber, @Email);" +
                    "SELECT last_insert_rowid();", 
                    person).Single();
                if(person.Request.Count != 0)
                {
                    foreach(HealthEquipment equipment in person.Request)
                    {
                        equipment.PersonId = person.Id;
                        equipment.Id = cnn.Query<int>(
                            @"INSERT INTO RequestEquipment (Category, EquipmentCount, PersonId) VALUES (@Category, @EquipmentCount, @PersonId);" +
                            "SELECT last_insert_rowid();", equipment).Single();
                    }
                }

                if(person.Providing.Count != 0)
                {
                    foreach (HealthEquipment equipment in person.Providing)
                    {
                        equipment.PersonId = person.Id;
                        equipment.Id = cnn.Query<int>(
                            @"INSERT INTO ProvidedTable (Category, EquipmentCount, PersonId) VALUES (@Category, @EquipmentCount, @PersonId);" +
                            "SELECT last_insert_rowid();", equipment).Single();
                    }
                }
                return person;
                    
            }
        }

        public void DeletePerson(Person person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

            }
        }

        public List<Person> ReadAllPersonData()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Person>("select * from Person", new DynamicParameters());

                List<Person> PersonList = output.ToList();

                foreach(Person person in PersonList)
                {
                    List<HealthEquipment> requestedList = new List<HealthEquipment>();
                    List<HealthEquipment> providedList = new List<HealthEquipment>();

                    var requested = cnn.Query<HealthEquipmentEx>("SELECT * FROM RequestEquipment WHERE PersonId = @PersonId", new  { PersonId = person.Id }).Select(x => new HealthEquipment(Convert.ToInt32(x.Id), Convert.ToInt32(x.Category), Convert.ToInt32(x.EquipmentCount), Convert.ToInt32(x.PersonId)));
                    requestedList = requested.ToList();

                    var provided = cnn.Query<HealthEquipmentEx>("SELECT * FROM ProvidedTable WHERE PersonId = @PersonId", new { PersonId = person.Id }).Select(x => new HealthEquipment(Convert.ToInt32(x.Id), Convert.ToInt32(x.Category), Convert.ToInt32(x.EquipmentCount), Convert.ToInt32(x.PersonId)));
                    providedList = provided.ToList();

                    person.Request = requestedList;
                    person.Providing = providedList;
                }

                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
