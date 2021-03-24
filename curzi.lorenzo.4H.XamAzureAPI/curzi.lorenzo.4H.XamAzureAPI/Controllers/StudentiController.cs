using curzi.lorenzo._4H.XamAzure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curzi.lorenzo._4H.XamAzureAPI.Controllers
{   //Decoratori
    [ApiController]
    [Route("[controller]")]
    public class StudentiController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Studente> Get()
        {
            List<Studente> studenti = new List<Studente>();

            studenti.Add(new Studente { Nome = "Lorenzo", Cognome = "Curzi", Immagine = "lorenzo.curzi.jpeg", Dettagli="Grande vecchio" });
            studenti.Add(new Studente { Nome = "Maurizio", Cognome = "Conti", Immagine = "maurizio.conti.png", Dettagli = "Custode dei luoghi e delle chiavi di Hogwarts " });

            return studenti;
        }
    }
}
