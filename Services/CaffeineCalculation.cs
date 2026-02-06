using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTest.Services
{
    public class CaffeineCalculationService
    {
        public double CalculateHalfLife(int initialMgCaffeine, int time)
        {
            double numberOfHalfLives = (double)time / 300;
            double percentageRemaining = Math.Pow(0.5, numberOfHalfLives);
            double results = initialMgCaffeine * percentageRemaining;

            return results;
        } 
    }
}