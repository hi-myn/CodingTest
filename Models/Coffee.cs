using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTest.Models
{
    public class Coffee
    {
        public Coffee(string name, string code, int caffeineContentInMg)
        {
            Name = name;
            Code = code;
            CaffeineContentInMg = caffeineContentInMg;
        }

        public string Name { get; set; }
        public string Code { get; set; }
        public int CaffeineContentInMg { get; set; }
    }
}