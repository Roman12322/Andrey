using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Черновик
{
    public class Calculator
    {
        private int firstNumber, secondNumber;
        public Calculator(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }
        public int GetAdd()
        {
            return firstNumber + secondNumber;
        }
        public double GetDiv()
        {
            return firstNumber / secondNumber;
        }
        public int GetSub()
        {
            return firstNumber - secondNumber;
        }
        public int GetMult()
        {
            return firstNumber * secondNumber;
        }
    }
}
