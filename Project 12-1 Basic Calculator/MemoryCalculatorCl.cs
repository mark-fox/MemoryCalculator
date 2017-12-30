// This class provides memory calculator functionality that inherit functionality
// from the Calculator class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_14_1_Basic_Calculator
{
    class MemoryCalculatorCl : Calculator
    {
        // Declares variable
        public decimal storedValue;

        public void MemoryStore (TextBox vtextbox, Label mlabel)
        {
            // Method for storing current value
            Decimal displayValue = Convert.ToDecimal(vtextbox.Text);
            storedValue = displayValue;
            mlabel.Text = "M";
        }
        public void MemoryRecall(TextBox vtextbox)
        {
            // Method for recalling stored value
            vtextbox.Text = storedValue.ToString();
        }
        public void MemoryClear(TextBox vtextbox, Label mlabel)
        {
            // Method for clearing stored value's variable
            storedValue = default(decimal);
            mlabel.Text = "";
            vtextbox.Text = "";
        }
        public void MemoryAdd(TextBox vtextbox, Label mlabel)
        {
            // Method for adding onto stored variable
            storedValue += Convert.ToDecimal(vtextbox.Text);
            mlabel.Text = "M";
        }
    }
}
