using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwiftSimServer.Controllers
{
    [Route("api/[controller]")]
    public class StoreController : Controller
    {
        // https://localhost:5001/api/store/
        [HttpGet]
        public IEnumerable<Store> Get()
        {
            return ReadStoresFromDatabase();
        }

        // https://localhost:5001/api/store/1
        [HttpGet("{id}")]
        public Store Get(int id)
        {
            var results = ReadStoresFromDatabase();

            if( id >= results.Count ){
                id = results.Count - 1; 
            }

            var store = results.Where((arg) => arg.Index == id).ToList()[0];
                               
            return  store;
        }


        private List<Store> ReadStoresFromDatabase()
        {
            var results = new List<Store>();

            results.Add(new Store {
                Name = "Cafe00",
                Location = new LocationDescription{
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 0,
                Index = 0,
                ImagePath = ""
            });

            results.Add(new Store
            {
                Name = "Cafe01",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 0,
                Index = 1,
                ImagePath = ""
            });

            results.Add(new Store
            {
                Name = "Cafe02",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 0,
                Index = 2,
                ImagePath = ""
            });

            results.Add(new Store
            {
                Name = "Dessert00",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 1,
                Index = 3,
                ImagePath = ""
            });

            results.Add(new Store
            {
                Name = "Dessert01",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 1,
                Index = 4,
                ImagePath = ""
            });

            results.Add(new Store
            {
                Name = "Dessert02",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 1,
                Index = 5,
                ImagePath = ""
            });

            results.Add(new Store
            {
                Name = "Dessert03",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 1,
                Index = 6,
                ImagePath = ""
            });

            results.Add(new Store
            {
                Name = "AfternoonTea00",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 2,
                Index = 7,
                ImagePath = ""
            });

            results.Add(new Store
            {
                Name = "AfternoonTea01",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 2,
                Index = 8,
                ImagePath = ""
            });

            results.Add(new Store
            {
                Name = "AfternoonTea02",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 2,
                Index = 9,
                ImagePath = ""
            });

            results.Add(new Store
            {
                Name = "AfternoonTea03",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 2,
                Index = 10,
                ImagePath = ""
            });


            results.Add(new Store
            {
                Name = "Italy00",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 3,
                Index = 11,
                ImagePath = ""
            });

            results.Add(new Store
            {
                Name = "Italy01",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 3,
                Index = 12,
                ImagePath = ""
            });


            results.Add(new Store
            {
                Name = "HK00",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 4,
                Index = 13,
                ImagePath = ""
            });

            results.Add(new Store
            {
                Name = "HK01",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 4,
                Index = 14,
                ImagePath = ""
            });

            results.Add(new Store
            {
                Name = "HK02",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 4,
                Index = 15,
                ImagePath = ""
            });


            results.Add(new Store
            {
                Name = "US00",
                Location = new LocationDescription
                {
                    Address = "",
                    Latitude = 0,
                    Longitude = 0
                },
                ServiceIndex = 5,
                Index = 16,
                ImagePath = ""
            });

            return results;
        }
    }

    public class Store{

        /// <summary>
        /// 服務類型
        /// </summary>
        public int ServiceIndex { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public LocationDescription Location { get; set; }

        /// 索引號
        public int Index { get; set; }

        public string ImagePath { get; set; }

    }

    public class LocationDescription{
        /// 地址
        public string Address { get; set; }
        /// 緯度
        public double Latitude { get; set; }
        /// 經度
        public double Longitude { get; set; }
    }
}
