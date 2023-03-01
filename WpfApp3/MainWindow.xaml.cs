using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Clock watch = new Clock("header 1", "body 1");
            timmytext.Text = watch.ToString();
            DateTime date=new DateTime();
            DateTime now=DateTime.Now;
           string shorttime=now.ToShortTimeString();
            string longtime=now.ToLongTimeString();
            string formatstring = $"" +
                $"short time :{shorttime}\n" +
                $"long time:{longtime}\n" +
                $"year:{now.Year}\n"+
                $"day of week{now.DayOfWeek}";
            // DateTime nowadd8mounth = now.AddMonths(80);
            //TimeSpan  differntcedaysfor = nowadd8mounth - now;
            //timmytext.Text = (differntcedaysfor.Days/365.6).ToString();


            const int agetodrive= 15;
            const int agetopremate= 14;
            const int agetodrink= 25;


           // TimeSpan math = nowadd8mounth - now;
           // timmytext.Text = math.ToString();
           // timmytext.Text = nowadd8mounth.ToString();
           // timmytext.Text = formatstring;
            //DateTime date = DateTime.Now;
            //timmytext.Text = date.ToString();
        }

        private void bottondis_Click(object sender, RoutedEventArgs e)
        {
           // int day = int.Parse(firstname.Text);
          //  int month = int.Parse(lastname.Text);
          //  int yearr = int.Parse(mont.Text);
           // DateTime birtday  =   new DateTime(yearr, month, day);
            
           // timmytext.Text = $"here is your birthday{birtday}";
             DateTime usemethodalikestring = dateofb();

             timmytext.Text=$"birthday is {usemethodalikestring}";

        }

        private void agge_Click(object sender, RoutedEventArgs e)
        {
            DateTime birtday = dateofb();
            DateTime now =DateTime.Now;

            TimeSpan age=now-birtday;
            int omer = (int)(age.Days / 365.25);



            timmytext.Text=$"you age{age.ToString()}";
            const int agetodrive = 15;
            const int agetopremate = 14;
            const int agetodrink = 25;
            //const int agetodrive= 15;
            if (omer > agetodrive)
            {

                timmytext.Text += "you are age is enough";
            }
            if (omer > agetopremate)
            {
                timmytext.Text += "you you can drive pracatice";
            }
            if(omer > agetodrink)
            {
                timmytext.Text += "you can drink but it is not healthy";
            }
        }
         public DateTime dateofb() {



         int day = int.Parse(firstname.Text);
        int month = int.Parse(lastname.Text);
       int yearr = int.Parse(mont.Text);

         return new DateTime(yearr,month,day); 
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {

            bool calanderdateselect=CalendarDateRange.selectdate.hasvalue
            DateTime selectdate = CalDate.selectdate.values;

               timmytext.Text= selectdate.ToString();

        }
    }
}
