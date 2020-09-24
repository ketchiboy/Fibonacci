using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Forms;
namespace PageNavigation
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            MySlider.ValueChanged += MySlider_ValueChanged;
        }

     

        private void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value1 = MySlider.Value;
            int value2 = (int)value1;
            MyLabel.Text = "N= [" + value2.ToString() + "]";

            int fib = Fibonacci(value2);

            MyLabel2.Text = "fib= [" + fib.ToString() + "]";
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }


    }
}