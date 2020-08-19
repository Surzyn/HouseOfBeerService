using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataLayer;

namespace HouseOfBeerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PubController : ControllerBase
    {
        [HttpGet]
        public List<FavouritePub> GetFavouritePubs()
        {
            var pubsRepo = new PubsRepository();
            var pubs = pubsRepo.GetFavouritePubs();
            return pubs;
        }
    }
}