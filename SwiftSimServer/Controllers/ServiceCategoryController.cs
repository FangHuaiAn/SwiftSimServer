using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwiftSimServer.Controllers
{
    [Route("api/[controller]")]
    public class ServiceCategoryController : Controller
    {

        // https://localhost:5001/api/servicecategory
        [HttpGet]
        public IEnumerable<ServiceCategory> Get()
        {
            return ReadFromDatabase();
        }

        // https://localhost:5001/api/servicecategory/0
        [HttpGet("{id}")]
        public ServiceCategory Get(int id)
        {
            var results = ReadFromDatabase();

            if( results.Count > id){
                return results[id];
            }

            return results[results.Count-1];
        }

        private List<ServiceCategory> ReadFromDatabase(){
            var results = new List<ServiceCategory>();

            results.Add(new ServiceCategory
            {
                Name = "",
                ImagePath = "https://swift.azurewebsites.net/Images/cafe.jpg",
                Index = 0
            });


            return results;
        }

    }

    public class ServiceCategory
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int Index { get; set; }
    }
}
