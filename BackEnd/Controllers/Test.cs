using System;
using System.Collections.Generic;
using DAL.Models;
using DAL.Models.Book;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("controller")]
    public class Test : Controller
    {
        [HttpGet("getProducts")]
        public List<Product> GetAllProduct()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = new Random().Next(50),
                    Price= new Random().Next(1000),
                    Name = "Туалетная бумага"
                },
                new Product()
                {
                    Id = new Random().Next(50),
                    Price = new Random().Next(1000),
                    Name = "Кока-Кола"
                }
            };

        }
    }
}
