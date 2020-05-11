using Madina.Core.Entities;
using Madina.Core.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Madina.Api.Controllers
{
    /*
     * TODO :
             * Utiliser un vl-geom-line-string qui prends un tableau de tableau de coordonnées
        et avec unvl-stylebox dedans on peut choisir la couleur 

          <vl-feature>
              <vl-geom-line-string :coordinates="[[116.544921,40.451633],[116.545264,40.451649],[116.545865,40.451698],[116.546144,40.451551],[116.546337,40.451274],[116.546788,40.451143],[116.547324,40.451078],[116.547539,40.450996],[116.547839,40.450719],[116.548440,40.450506],[116.548933,40.450604],[116.549448,40.450604],[116.550242,40.450376],[116.550865,40.450163],[116.551702,40.449935],[116.552581,40.449576]]"></vl-geom-line-string>
  		        <vl-style-box> 
                      <vl-style-stroke color="red"></vl-style-stroke> 
                  </vl-style-box>  
          </vl-feature>

        Produit une ligne rouge pour les coordonnées données.

        Il faut donc :
        Trouver la boundary box - l'envoyer au serveur
        Côté serveur récupérer d'overpass API les ways
        Chaque way est composé d'une liste de nodes => Et les noms de rues ? 
        transformer ces nodes en coordonnées
        Retourner à l'appli une liste de rue avec chacune une liste de coordonnées et la couleur =>
     */
    [Route("api/[controller]")]
    [ApiController]
    public class StreetsController : ControllerBase
    {
        private readonly ILogger<StreetsController> _logger;

        public StreetsController(ILogger<StreetsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Street> Get()
        {
            return new List<Street>()
            {
                new Street()
                {
                    Name = "Bourrassol",
                    Path = new List<Coordinate>()
                    {
                        new Coordinate()
                        {
                            Longitude = 0,
                            Latitude = 0
                        }
                    },
                    StreetNameGender = Gender.Other
                }
            };
        }
    }
}