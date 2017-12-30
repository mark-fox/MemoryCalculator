// This class provides calculator functionality.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_14_1_Basic_Calculator
{
    class Calculator
    {
        // Declares variables
        private byte oper;
        private decimal total;
        private decimal[] values;
        public bool newInputs;

        public Calculator()
        {
            // Creates array to hold inputs
            values = new decimal[2];
        }

        public void Add(decimal value)
        {
            // Saves passed value as first input and sets operator variable
            values[0] = value;
            oper = 1;
        }
        public void Subtract(decimal value)
        {
            // Saves passed value as first input and sets operator variable
            values[0] = value;
            oper = 2;
        }
        public void Multiply(decimal value)
        {
            // Saves passed value as first input and sets operator variable
            values[0] = value;
            oper = 3;
        }
        public void Divide(decimal value)
        {
            // Saves passed value as first input and sets operator variable
            values[0] = value;
            oper = 4;
        }
        public decimal Equals(decimal value)
        {
            // Saves passed value as second input and determines what action to take
            values[1] = value;
            switch (oper)
            {
                // 1 = ADD; 2 = SUBTRACT; 3 = MULTIPLY; 4 = DIVIDE
                case 1:
                    total = values[0] + values[1];
                    break;
                case 2:
                    total = values[0] - values[1];
                    break;
                case 3:
                    total = values[0] * values[1];
                    break;
                case 4:
                    total = values[0] / values[1];
                    break;
                default:
                    break;
            }
            return total;
        }
        public decimal Reciprocal(decimal value)
        {
            // Returns reciprocal calculation
            return 1 / value;
        }
        public decimal SquareRoot(decimal value)
        {
            // Returns square root calculation
            return (decimal)Math.Sqrt((double)value);
        }
        public void Clear()
        {
            // Clears stored array
            Array.Clear(values, 0, values.Length);
        }
        public bool isNumeric(string input)
        {
            // Validates inputs
            decimal number = 0m;
            if (Decimal.TryParse(input, out number))
                return true;
            else
                return false;
        }
    }
}