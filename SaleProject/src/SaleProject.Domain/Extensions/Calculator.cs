using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleProject.Domain.Extensions
{
    public class Calculator : ICalculator
    {
        public int AddTwoNumbers(int first, int second)
        {
            return first + second;
        }

        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }
    }
    public interface ICalculator
    {
        bool IsPrime(int candidate);
        int AddTwoNumbers(int first, int second);
    }
}
