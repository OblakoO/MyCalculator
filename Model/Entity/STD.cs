﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class STD: Operation
    {
        public override List<Double> execute(ref List<Double> numbers)
        {
            List<Double> values = numbers.Select(integer => (Double)integer).ToList();
            Double ret = 0;
            int count = values.Count();
            if (count > 1)
            {
                Double avg = values.Average();
                Double sum = values.Sum(d => (d - avg) * (d - avg));
                ret = Math.Round(Math.Sqrt(sum / count),3);
            }
            var bigIntegers = new List<Double>();
            bigIntegers.Add(ret);
            numbers = bigIntegers;
            return numbers;
        }
    }
}
