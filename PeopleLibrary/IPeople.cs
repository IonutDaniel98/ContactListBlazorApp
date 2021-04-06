using PeopleLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeopleLibrary
{
    public interface IPeople
    {
        Task<List<PersonModel>> GetPeople();
        Task InsertPerson(PersonModel person);
    }
}