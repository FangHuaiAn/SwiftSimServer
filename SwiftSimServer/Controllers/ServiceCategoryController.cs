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
        // https://localhost:5001/api/servicecategory/version
        [HttpGet]
        [Route("version")]
        public int GetVersion(){
            return 1;
        }

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

            var keyString = "?sv=2017-11-09&ss=bfqt&srt=sco&sp=rwdlacup&se=2018-09-28T19:19:51Z&st=2018-08-20T11:19:51Z&spr=https&sig=o7C3i5x9hv1kVtwMXliiSSQCg06ETuDtI%2Bj12I4PbSg%3D";
            var results = new List<ServiceCategory>();

            results.Add(new ServiceCategory
            {
                
                Name = "咖啡",
                ImagePath = "https://scoresrv.file.core.windows.net/images/cafe.jpg" + keyString,
                Index = 0
            });

            results.Add(new ServiceCategory
            {
                Name = "甜點",
                ImagePath = "https://scoresrv.file.core.windows.net/images/cupcake.jpg" + keyString,
                Index = 1
            });

            results.Add(new ServiceCategory
            {
                Name = "下午茶",
                ImagePath = "https://scoresrv.file.core.windows.net/images/nestcake.jpg" + keyString,
                Index = 2
            });

            results.Add(new ServiceCategory
            {
                Name = "義大利麵",
                ImagePath = "https://scoresrv.file.core.windows.net/images/noodle.jpg" + keyString,
                Index = 3
            });

            results.Add(new ServiceCategory
            {
                Name = "港式叉燒",
                ImagePath = "https://scoresrv.file.core.windows.net/images/porkroast.jpg" + keyString,
                Index = 4
            });

            results.Add(new ServiceCategory
            {
                Name = "美式餐廳",
                ImagePath = "https://scoresrv.file.core.windows.net/images/porkribs.jpg" + keyString,
                Index = 5
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
