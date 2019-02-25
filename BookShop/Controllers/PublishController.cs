using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Dtos;
using BookShop.Managers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    [Route("publisher")]
    [ApiController]
    public class PublishController : Controller
    {


        //GET: /HelloWorld/Welcome/ 

       
        IBase<PublisherDto> manager;

        public PublishController(IBase<PublisherDto> lm)
        {
            manager = lm;
        }

        [HttpGet]
        public IEnumerable<PublisherDto> GetActors()
        {
            var res = manager.GetAll();
            return res;
        }

        [HttpPost]
        public PublisherDto CreateActor(PublisherDto publisher)
        {
            return manager.Save(publisher);
        }

        [HttpPut]
        public PublisherDto UpdateActor(PublisherDto publisher)
        {
            return manager.Update(publisher);
        }

    }
}