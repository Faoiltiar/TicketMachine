using System;
using System.Windows.Controls;

namespace Biletomat
{
    internal class AddingAndSubtracting
    {
        public int NumericUp(TextBox textBox, int max)
        {
            int tmp;
            tmp = int.Parse(textBox.Text);
            if (tmp < max)
                tmp++;
            textBox.Text = tmp.ToString();
            return tmp;
           

        }
        public int NumericDown(TextBox textBox)
        {
            int tmp;
            tmp = int.Parse(textBox.Text);
            if (tmp > 0)
                tmp--;
            textBox.Text = tmp.ToString();
            return tmp;
        }
    }
}