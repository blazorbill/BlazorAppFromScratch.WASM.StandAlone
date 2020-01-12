using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorAppFromScratch.DTO;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;
using BlazorAppFromScratch.Client.BL.Services;

namespace BlazorAppFromScratch.WASM.Pages
{
    public partial class Person
    {
        private List<PersonDTO> MyPersons = new List<PersonDTO>();
        private PersonDTO MyPerson = new PersonDTO();

        [Inject]
        private IPersonClientService personService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            MyPersons = await personService.GetPersons();
            MyPerson = await personService.GetPerson(1);
        }

        async Task OnPersonSelect(ChangeEventArgs e)
        {
            int id = int.Parse(e.Value.ToString());
            MyPerson = await personService.GetPerson(id);
        }
    }
}
