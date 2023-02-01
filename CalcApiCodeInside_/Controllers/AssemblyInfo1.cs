using AverageSmallestLargest;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CalcApiCodeInside_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssemblyInfo1 : ControllerBase
    {
        Class1 calc = new Class1();

        [HttpGet("/Average")]

        public int Average([FromQuery] int[] nums)
        {
            return calc.Average(nums);
        }

        [HttpGet("/Smallest")]


        public int Smallest([FromQuery] int[] nums)
        {

            return calc.Smallest(nums);
        }


        [HttpGet("/bigest")]
        public int bigest([FromQuery] int[] nums)
        {
            
            return calc.bigest(nums);
        }
    }
}
