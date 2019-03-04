/* March 4,2019
 * Andrea Bonafini
 * stringConcat
*/
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

namespace _319481strignConcat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConcat_Click(object sender, RoutedEventArgs e)
        {
            //local variable
            string fName, lName;
            string fullName;
            int yearBorn;

            //assign values
            fName = txtFirstName.Text;
            fName =fName.Trim();
            lName = txtLastName.Text;
            lName =lName.Trim();
            yearBorn = calBDay.SelectedDate.Value.Year;
                

            //Concatenation 
            fullName = fName + " " + lName;
            if (fullName == "Andrea Bonafini" ) 
            {
                if (yearBorn >= 2000)
                {
                    lblOutput.Content = "you must be the student";
                        }
                else

                {//do this if true
                    lblOutput.Content = "Hey " 
                        + fullName;
                }


            }
            else
            {
                //Output
                lblOutput.Content = fullName;

            }
                

            //Output
            lblOutput.Content = fullName;
      }
    }
}
