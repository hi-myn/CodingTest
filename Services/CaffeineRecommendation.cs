using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingTest.Models;
using CodingTest.repository;

namespace CodingTest.Services
{
    public class CaffeineRecommendation
    {
        //Dependency Injection (DI)
        private readonly CoffeeRepository _coffeeRepository;
        private readonly CaffeineCalculationService _caffeineCalculationService;

        public CaffeineRecommendation(CoffeeRepository coffeeRepository, CaffeineCalculationService caffeineCalculationService)
        {
            _coffeeRepository = coffeeRepository;
            _caffeineCalculationService = caffeineCalculationService;
        }

        public List<CoffeeRecommendationResult> RecommendNextCoffee(List<RecentCoffeeConsumption> recentConsumptions)
        {
            return new List<CoffeeRecommendationResult>();
        }

        private double CalculateCurrentCafeine(List<RecentCoffeeConsumption> consumptions)
        {
            double totalActiveCaffeine = 0;

            foreach (var consumption in consumptions)
            {
                var coffee = _coffeeRepository.GetCoffeeByCode(consumption.Code);
                int coffeeMg = coffee.CaffeineContentInMg;
                double remainingCaffeine = _caffeineCalculationService.CalculateHalfLife(coffeeMg, consumption.Time);
                totalActiveCaffeine += remainingCaffeine;
            }

            return totalActiveCaffeine;
        }
    }

    public class CoffeeRecommendationResult
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Wait { get; set; }
    }

    public class RecentCoffeeConsumption
    {
        public string Code { get; set; }
        public int Time { get; set; }
    }
}