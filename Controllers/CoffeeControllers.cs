using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingTest.repository;
using CodingTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers
{
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        private readonly CaffeineRecommendation _recommendationService;
        private readonly CoffeeRepository _coffeeRepository;
        public CoffeeController(CaffeineRecommendation recommendationService, CoffeeRepository coffeeRepository)
        {
            _recommendationService = recommendationService;
            _coffeeRepository = coffeeRepository;
        }

        [HttpGet("v1/coffees")]
        public IActionResult GetAll()
        {
            var coffees = _coffeeRepository.GetAll();
            return Ok(coffees);
        }

        [HttpPost("v1/calculate")]
        public IActionResult Create([FromBody] ConsumptionRequest request)
        {
            Console.WriteLine("APAREÇA");
            var result = _recommendationService.RecommendNextCoffee(request.Recommendations);
            return Ok(new { Recommendations = result });
        }
    }

    public class ConsumptionRequest
    {
        public List<RecentCoffeeConsumption> Recommendations { get; set; }
    }
}