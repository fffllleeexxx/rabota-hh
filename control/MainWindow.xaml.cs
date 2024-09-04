using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace control
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<Person> list = new List<Person>();

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"^[А-ЯЁ][а-яё]+ [А-ЯЁ][а-яё]+$");
            Match match = regex.Match(firstName.Text);
            DateTime temp;
            double com = 0;
            double c = 0;
            DateTime oneYearBefore = DateTime.Now.AddYears(-3);
            DateTime dateNow = DateTime.Now;

            var parsedDate = DateTime.Parse(data.Text);

            if (match.Success)
            {            
                if (DateTime.TryParse(data.Text, out temp))
                {
                    if(Convert.ToInt32(revenue.Text) < 50000 )
                    {
                        com = Convert.ToInt32(revenue.Text) * 0.03;
                    }
                    else if(Convert.ToInt32(revenue.Text) >= 50000)
                    {
                        com = Convert.ToInt32(revenue.Text) * 0.06;
                    }

                    if(oneYearBefore > parsedDate)
                    {
                        c += com + com * 0.05;
                        commissions.Text = Convert.ToString(c);
                    }
                }
                else
                {
                    data.Text = "Неверный формат";
                }
            }
            else
            {
                firstName.Text = "Неверный формат";
            }

            Person person = new Person(firstName.Text, c, Convert.ToInt32(revenue.Text), Convert.ToString(dateNow - parsedDate));
            list.Add(person);    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1(list);
            window1.Show();
        }
    }
}
