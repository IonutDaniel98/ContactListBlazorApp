using PeopleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PeopleLibrary
{
    public class People : IPeople
    {
        //dbo.People is a local DataBase
        private readonly ISqlDataAccess _db;

        public People(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "SELECT * from dbo.People";

            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = "insert into dbo.People (FirstName, LastName, PhoneNumber) values (@FirstName, @LastName, @PhoneNumber)";

            return _db.SaveData(sql, person);
        }
    }
}
