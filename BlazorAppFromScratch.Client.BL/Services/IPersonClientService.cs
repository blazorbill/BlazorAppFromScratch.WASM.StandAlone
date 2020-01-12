using BlazorAppFromScratch.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppFromScratch.Client.BL.Services
{
    public interface IPersonClientService
    {
        Task<List<PersonDTO>> GetPersons();
        Task<PersonDTO> GetPerson(int id);
    }
}
