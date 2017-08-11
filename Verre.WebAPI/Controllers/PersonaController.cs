using AutoMapper;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Verre.Application;
using Verre.Application.Interface;
using Verre.Domain.Entities;
using Verre.WebAPI.ApiModels;

namespace Verre.WebAPI.Controllers
{
    public class PersonaController : ApiController
    {
        private readonly IPersonaAppService _personaApp;
        public PersonaController(IPersonaAppService personaApp)
        {
            _personaApp = personaApp;
        }
        public IEnumerable<PersonaModelApi> GetAllPersonas()
        {
            var personaApiModel = Mapper.Map<IEnumerable<Persona>, IEnumerable<PersonaModelApi>>(_personaApp.GetAll());
            return personaApiModel;
        }
        public PersonaModelApi GetPersona(int id)
        {
            var personaApiModel = Mapper.Map<Persona, PersonaModelApi>(_personaApp.GetById(id));
            if (personaApiModel == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return personaApiModel;
        }
        public HttpResponseMessage PostPersona(PersonaModelApi person)
        {
            var personaDomain = Mapper.Map<PersonaModelApi, Persona>(person);
            //_personaApp.Add(personaDomain);
            var response = Request.CreateResponse<PersonaModelApi>(HttpStatusCode.Created, person);

            string uri = Url.Link("DefaultApi", new { PersonaId = person.PersonaId });
            response.Headers.Location = new Uri(uri);
            return response;
        }
        public void PutPersona(int id, PersonaModelApi person)
        {
            var personaDomain = Mapper.Map<PersonaModelApi, Persona>(person);
            _personaApp.Update(personaDomain);
            var response = Request.CreateResponse<PersonaModelApi>(HttpStatusCode.Created, person);

            //person.PersonaId = id;
            //if (!_personaApp.Update(personaDomain))
            //{
                throw new HttpResponseException(HttpStatusCode.NotFound);
            //}
        }

        public void DeletePersona(int id)
        {

            var personaApiModel = Mapper.Map<Persona, PersonaModelApi>(_personaApp.GetById(id));
           // _personaApp.Add(personaApiModel);
            //PersonaAppService Person = _personaApp.GetById(id);
            //if (Person == null)
            //{
                throw new HttpResponseException(HttpStatusCode.NotFound);
            //}
            //_personaApp.Remove(id);
        }



    }
}
