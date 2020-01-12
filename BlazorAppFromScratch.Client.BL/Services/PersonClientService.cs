using BlazorAppFromScratch.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppFromScratch.Client.BL.Services
{
    public class PersonClientService : IPersonClientService
    {
        public async Task<PersonDTO> GetPerson(int id)
        {
            return await HTTPHelper.HttpGet<PersonDTO>($"person/{id}");
        }

        public async Task<List<PersonDTO>> GetPersons()
        {
            return await HTTPHelper.HttpGet<List<PersonDTO>>("persons");
        }
    }
}
