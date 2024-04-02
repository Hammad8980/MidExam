using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MidExam.Shared.Models;

namespace MidExam.Server.Controllers
{
    public class ClientsControllers : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public ClientsControllers(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        [Route("api/Clients/Get")]
        public IEnumerable<Persons> Get()
        {
            return _dataAccessProvider.GetClientRecord();
        }
        [HttpPost]
        [Route("api/clients/Create")]
        public void Create([FromBody] Persons person)
        {
            if(ModelState.IsValid)
            {
                _dataAccessProvider.AddClientRecord(person);
            }
        }


        [HttpGet]
        [Route("api/Clients/Details/{id}")]
        public Persons Details(int id) 
        { 
            return _dataAccessProvider.GetClientRecord(id);
        }

        [HttpPut]
        [Route("api/Clients/Edit")]
        public void Edit([FromBody] Persons person)
        {
            if(ModelState.IsValid)
            {
                _dataAccessProvider.UpdateClientRecord(person);
            }
        }
        [HttpDelete]
        [Route("api/Clients/Delete/{id}")]
        public void DeleteConfirmed(int id)
        {
            _dataAccessProvider.DeleteClientRecord(id);
        }
    }
}
