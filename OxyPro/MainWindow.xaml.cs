using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OxyPro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //method 1
        double amth1 = 0;
        double bmth1 = 0;
        double x1mth1 = 0;
        double x2mth1 = 0;
        double xnmth1 = 0;
        double fox1mth1 = 0;
        double fox2mth1 = 0;
        double foxnmth1 = 0;
        int iterationex1mth1 = 0;
        List<double> list1ex1mth1 = new List<double>();
        List<double> list2ex1mth1 = new List<double>();
        List<double> list3ex1mth1 = new List<double>();
        int lastpositivemth1 = 0;
        int lastnegativemth1 = 0;

        double aex2mth1 = 0;
        double bex2mth1 = 0;
        double x1ex2mth1 = 0;
        double x2ex2mth1 = 0;
        double xnex2mth1 = 0;
        double fox1ex2mth1 = 0;
        double fox2ex2mth1 = 0;
        double foxnex2mth1 = 0;
        int iterationex2mth1 = 0;
        List<double> list1ex2mth1 = new List<double>();
        List<double> list2ex2mth1 = new List<double>();
        List<double> list3ex2mth1 = new List<double>();
        int lastpositiveex2mth1 = 0;
        int lastnegativeex2mth1 = 0;

        double aex3mth1 = 0;
        double bex3mth1 = 0;
        double x1ex3mth1 = 0;
        double x2ex3mth1 = 0;
        double xnex3mth1 = 0;
        double fox1ex3mth1 = 0;
        double fox2ex3mth1 = 0;
        double foxnex3mth1 = 0;
        int iterationex3mth1 = 0;
        List<double> list1ex3mth1 = new List<double>();
        List<double> list2ex3mth1 = new List<double>();
        List<double> list3ex3mth1 = new List<double>();
        int lastpositiveex3mth1 = 0;
        int lastnegativeex3mth1 = 0;

        double aex4mth1 = 0;
        double bex4mth1 = 0;
        double x1ex4mth1 = 0;
        double x2ex4mth1 = 0;
        double xnex4mth1 = 0;
        double fox1ex4mth1 = 0;
        double fox2ex4mth1 = 0;
        double foxnex4mth1 = 0;
        int iterationex4mth1 = 0;
        List<double> list1ex4mth1 = new List<double>();
        List<double> list2ex4mth1 = new List<double>();
        List<double> list3ex4mth1 = new List<double>();
        int lastpositiveex4mth1 = 0;
        int lastnegativeex4mth1 = 0;

        //method 2
        double amth2 = 0;
        double bmth2 = 0;
        double x1mth2 = 0;
        double x2mth2 = 0;
        double xnmth2 = 0;
        double fox1mth2 = 0;
        double fox2mth2 = 0;
        double foxnmth2 = 0;
        int iterationex1mth2 = 0;
        List<double> list1ex1mth2 = new List<double>();
        List<double> list2ex1mth2 = new List<double>();
        List<double> list3ex1mth2 = new List<double>();
        int lastpositivemth2 = 0;
        int lastnegativemth2 = 0;

        double aex2mth2 = 0;
        double bex2mth2 = 0;
        double x1ex2mth2 = 0;
        double x2ex2mth2 = 0;
        double xnex2mth2 = 0;
        double fox1ex2mth2 = 0;
        double fox2ex2mth2 = 0;
        double foxnex2mth2 = 0;
        int iterationex2mth2 = 0;
        List<double> list1ex2mth2 = new List<double>();
        List<double> list2ex2mth2 = new List<double>();
        List<double> list3ex2mth2 = new List<double>();
        int lastpositiveex2mth2 = 0;
        int lastnegativeex2mth2 = 0;

        double aex3mth2 = 0;
        double bex3mth2 = 0;
        double x1ex3mth2 = 0;
        double x2ex3mth2 = 0;
        double xnex3mth2 = 0;
        double fox1ex3mth2 = 0;
        double fox2ex3mth2 = 0;
        double foxnex3mth2 = 0;
        int iterationex3mth2 = 0;
        List<double> list1ex3mth2 = new List<double>();
        List<double> list2ex3mth2 = new List<double>();
        List<double> list3ex3mth2 = new List<double>();
        int lastpositiveex3mth2 = 0;
        int lastnegativeex3mth2 = 0;

        double aex4mth2 = 0;
        double bex4mth2 = 0;
        double x1ex4mth2 = 0;
        double x2ex4mth2 = 0;
        double xnex4mth2 = 0;
        double fox1ex4mth2 = 0;
        double fox2ex4mth2 = 0;
        double foxnex4mth2 = 0;
        int iterationex4mth2 = 0;
        List<double> list1ex4mth2 = new List<double>();
        List<double> list2ex4mth2 = new List<double>();
        List<double> list3ex4mth2 = new List<double>();
        int lastpositiveex4mth2 = 0;
        int lastnegativeex4mth2 = 0;

        //method 3
        double aex1mth3 = 0;
        double bex1mth3 = 0;
        double cex1mth3 = 0;
        double x1ex1mth3 = 0;
        double x2ex1mth3 = 0;
        double xnex1mth3 = 0;
        double fox1ex1mth3 = 0;
        double fox2ex1mth3 = 0;
        double foxnex1mth3 = 0;
        double fpox1ex1mth3 = 0;
        double fpox2ex1mth3 = 0;
        double fpoxnex1mth3 = 0;
        int iterationex1mth3 = 0;
        List<double> list1ex1mth3 = new List<double>();
        List<double> list2ex1mth3 = new List<double>();
        List<double> list3ex1mth3 = new List<double>();
        List<double> lpist3ex1mth3 = new List<double>(); 
        int lastpositivemth3 = 0;
        int lastnegativemth3 = 0;

        double aex2mth3 = 0;
        double bex2mth3 = 0;
        double cex2mth3 = 0;
        double x1ex2mth3 = 0;
        double x2ex2mth3 = 0;
        double xnex2mth3 = 0;
        double fox1ex2mth3 = 0;
        double fox2ex2mth3 = 0;
        double foxnex2mth3 = 0;
        double fpox1ex2mth3 = 0;
        double fpox2ex2mth3 = 0;
        double fpoxnex2mth3 = 0;
        int iterationex2mth3 = 0;
        List<double> list1ex2mth3 = new List<double>();
        List<double> list2ex2mth3 = new List<double>();
        List<double> list3ex2mth3 = new List<double>();
        List<double> lpist3ex2mth3 = new List<double>();
        int lastpositiveex2mth3 = 0;
        int lastnegativeex2mth3 = 0;

        double aex3mth3 = 0;
        double bex3mth3 = 0;
        double cex3mth3 = 0;
        double x1ex3mth3 = 0;
        double x2ex3mth3 = 0;
        double xnex3mth3 = 0;
        double fox1ex3mth3 = 0;
        double fox2ex3mth3 = 0;
        double foxnex3mth3 = 0;
        double fpox1ex3mth3 = 0;
        double fpox2ex3mth3 = 0;
        double fpoxnex3mth3 = 0;
        int iterationex3mth3 = 0;
        List<double> list1ex3mth3 = new List<double>();
        List<double> list2ex3mth3 = new List<double>();
        List<double> list3ex3mth3 = new List<double>();
        List<double> lpist3ex3mth3 = new List<double>();
        int lastpositiveex3mth3 = 0;
        int lastnegativeex3mth3 = 0;

        double aex4mth3 = 0;
        double bex4mth3 = 0;
        double cex4mth3 = 0;
        double x1ex4mth3 = 0;
        double x2ex4mth3 = 0;
        double xnex4mth3 = 0;
        double fox1ex4mth3 = 0;
        double fox2ex4mth3 = 0;
        double foxnex4mth3 = 0;
        double fpox1ex4mth3 = 0;
        double fpox2ex4mth3 = 0;
        double fpoxnex4mth3 = 0;
        int iterationex4mth3 = 0;
        List<double> list1ex4mth3 = new List<double>();
        List<double> list2ex4mth3 = new List<double>();
        List<double> list3ex4mth3 = new List<double>();
        List<double> lpist3ex4mth3 = new List<double>();
        int lastpositiveex4mth3 = 0;
        int lastnegativeex4mth3 = 0;

       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Example1Bisection()
        {
            iterationex1mth1++;
            ex1txtmth1.Text = ex1txtmth1.Text + " Index " + iterationex1mth1 + Environment.NewLine;
            listViewex1mth1a.Items.Add(iterationex1mth1);
            x1mth1 = double.Parse(Ex1mth1atextbox.Text); 
            x2mth1 = double.Parse(Ex1mth1btextbox.Text);
            x1mth1 = Math.Round(x1mth1, 4);
            x2mth1 = Math.Round(x2mth1, 4);
            listViewex1mth1b.Items.Add(x1mth1 );
            list2ex1mth1.Add(x1mth1 );
            fox1mth1 = (Math.Pow(x1mth1,4)) + (3 * Math.Pow(x1mth1,3)) - x1mth1 -4;
            fox1mth1 = Math.Round(fox1mth1, 4);
            listViewex1mth1c.Items.Add(fox1mth1);
            list3ex1mth1.Add(fox1mth1);
            if (fox1mth1 < 0)
            {
                lastnegativemth1 = list3ex1mth1.IndexOf(fox1mth1);
            }
            else
            {
                lastpositivemth1 = list3ex1mth1.IndexOf(fox1mth1);
            }
            iterationex1mth1++;
            ex1txtmth1.Text = ex1txtmth1.Text + " Index " + iterationex1mth1 + Environment.NewLine;
            listViewex1mth1a.Items.Add(iterationex1mth1);
            listViewex1mth1b.Items.Add(x2mth1);
            list2ex1mth1.Add(x2mth1);
            fox2mth1 = (Math.Pow(x2mth1, 4)) + (3 * Math.Pow(x2mth1, 3)) - x2mth1 - 4;
            fox2mth1 = Math.Round(fox2mth1, 4);
            listViewex1mth1c.Items.Add(fox2mth1);
            list3ex1mth1.Add(fox2mth1);
            if (fox2mth1 < 0)
            {
                lastnegativemth1 = list3ex1mth1.IndexOf(fox2mth1);
            }
            else
            {
                lastpositivemth1 = list3ex1mth1.IndexOf(fox2mth1);
            }
            //in the interval [1,2] i.e x1=1, x2=2.
            if (fox1mth1 * fox2mth1 < 0)
            { 
                ex1txtmth1.Text = ex1txtmth1.Text + "Solution Exists" + Environment.NewLine;
            Resolution:              
                ex1txtmth1.Text = ex1txtmth1.Text + " Index " + iterationex1mth1 + Environment.NewLine;
                iterationex1mth1++;
                listViewex1mth1a.Items.Add(iterationex1mth1);             
                //when either is negative
                amth1 = list2ex1mth1.ElementAt(lastnegativemth1);
                bmth1 = list2ex1mth1.ElementAt(lastpositivemth1);
                xnmth1 = (amth1 + bmth1) / 2;
                xnmth1 = Math.Round(xnmth1, 4);
                ex1txtmth1.Text = ex1txtmth1.Text + "x("+iterationex1mth1+")= " + xnmth1;
                list2ex1mth1.Add(xnmth1);
                listViewex1mth1b.Items.Add(xnmth1);
                foxnmth1 = (Math.Pow(xnmth1, 4)) + (3 * Math.Pow(xnmth1, 3)) - xnmth1 - 4;
                foxnmth1 = Math.Round(foxnmth1, 4);
                listViewex1mth1c.Items.Add(foxnmth1);
                list3ex1mth1.Add(foxnmth1);
                if (foxnmth1 < 0)
                {
                    lastnegativemth1 = list3ex1mth1.IndexOf(foxnmth1);
                }
                else
                {
                    lastpositivemth1 = list3ex1mth1.IndexOf(foxnmth1);
                }
                int fi = list3ex1mth1.Count();
                int fi2 = fi - 1;
                int fi3 = fi - 2;

                if (list3ex1mth1[fi2] != list3ex1mth1[fi3])
                {
                    goto Resolution;
                }
                else
                {
                    ex1txtmth1.Text = ex1txtmth1.Text + Environment.NewLine+ "End of Iteration. Since f(x" + fi + ") is equal to f(x" + fi2 + ")" + Environment.NewLine;
                }
           
                
            }
            else
            {
                ex1txtmth1.Text = ex1txtmth1.Text + "Solution does not exist in the Interval: [" + x1mth1 + "," + x2mth1 + "]" + " Exists" + Environment.NewLine;
            }
            
        }

        private void Ex1mth1button_Click(object sender, RoutedEventArgs e)
        {
            Example1Bisection();
        }

        private void listViewex1mth1a_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex1mth1b.SelectedIndex = listViewex1mth1a.SelectedIndex;
            listViewex1mth1c.SelectedIndex = listViewex1mth1a.SelectedIndex;          
        }

        private void listViewex1mth1b_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex1mth1a.SelectedIndex = listViewex1mth1b.SelectedIndex;
            listViewex1mth1c.SelectedIndex = listViewex1mth1b.SelectedIndex;
        }

        private void listViewex1mth1c_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex1mth1b.SelectedIndex = listViewex1mth1c.SelectedIndex;
            listViewex1mth1a.SelectedIndex = listViewex1mth1c.SelectedIndex;
        }

      

        private void label2_Click(object sender, RoutedEventArgs e)
        {
            listViewex1mth1a.Items.Clear();
            listViewex1mth1b.Items.Clear();
            listViewex1mth1c.Items.Clear();
            iterationex1mth1 = 0;
            list1ex1mth1.Clear();
            list2ex1mth1.Clear();
            list3ex1mth1.Clear();
            ex1txtmth1.Text = "Comments:";
        }

        private void Ex2mth1button_Click(object sender, RoutedEventArgs e)
        {
            Example2Bisection();
        }

        private void Example2Bisection()
        {
            iterationex2mth1++;
            ex2txtmth1.Text = ex2txtmth1.Text + " Index " + iterationex2mth1 + Environment.NewLine;
            listViewex2mth1a.Items.Add(iterationex2mth1);
            x1ex2mth1 = double.Parse(Ex2mth1atextbox.Text);
            x2ex2mth1 = double.Parse(Ex2mth1btextbox.Text);
            x1ex2mth1 = Math.Round(x1ex2mth1, 4);
            x2ex2mth1 = Math.Round(x2ex2mth1, 4);
            listViewex2mth1b.Items.Add(x1ex2mth1);
            list2ex2mth1.Add(x1ex2mth1);
            fox1ex2mth1 = (Math.Pow(x1ex2mth1, 3)) - (Math.Pow(x1ex2mth1, 2)) - 1;
            fox1ex2mth1 = Math.Round(fox1ex2mth1, 4);
            listViewex2mth1c.Items.Add(fox1ex2mth1);
            list3ex2mth1.Add(fox1ex2mth1);
            if (fox1ex2mth1 < 0)
            {
                lastnegativeex2mth1 = list3ex2mth1.IndexOf(fox1ex2mth1);
            }
            else
            {
                lastpositiveex2mth1 = list3ex2mth1.IndexOf(fox1ex2mth1);
            }
            iterationex2mth1++;
            ex2txtmth1.Text = ex2txtmth1.Text + " Index " + iterationex2mth1 + Environment.NewLine;
            listViewex2mth1a.Items.Add(iterationex2mth1);
            listViewex2mth1b.Items.Add(x2ex2mth1);
            list2ex2mth1.Add(x2ex2mth1);
            fox2ex2mth1 = (Math.Pow(x2ex2mth1, 3)) - (Math.Pow(x2ex2mth1, 2)) - 1;
            fox2ex2mth1 = Math.Round(fox2ex2mth1, 4);
            listViewex2mth1c.Items.Add(fox2ex2mth1);
            list3ex2mth1.Add(fox2ex2mth1);
            if (fox2ex2mth1 < 0)
            {
                lastnegativeex2mth1 = list3ex2mth1.IndexOf(fox2ex2mth1);
            }
            else
            {
                lastpositiveex2mth1 = list3ex2mth1.IndexOf(fox2ex2mth1);
            }
            //in the interval [1,2] i.e x1=1, x2=2.
            if (fox1ex2mth1 * fox2ex2mth1 < 0)
            {
                ex2txtmth1.Text = ex2txtmth1.Text + "Solution Exists" + Environment.NewLine;
            Resolutionex2:
                ex2txtmth1.Text = ex2txtmth1.Text + " Index " + iterationex2mth1 + Environment.NewLine;
            iterationex2mth1++;
            listViewex2mth1a.Items.Add(iterationex2mth1);
                //when either is negative
            aex2mth1 = list2ex2mth1.ElementAt(lastnegativeex2mth1);
            bex2mth1 = list2ex2mth1.ElementAt(lastpositiveex2mth1);
            xnex2mth1 = (aex2mth1 + bex2mth1) / 2;
            xnex2mth1 = Math.Round(xnex2mth1, 4);
            ex2txtmth1.Text = ex2txtmth1.Text + "x(" + iterationex2mth1 + ")= " + xnex2mth1;
            list2ex2mth1.Add(xnex2mth1);
            listViewex2mth1b.Items.Add(xnex2mth1);
            foxnex2mth1 = (Math.Pow(xnex2mth1, 3)) - (Math.Pow(xnex2mth1, 2)) - 1;
            foxnex2mth1 = Math.Round(foxnex2mth1, 4);
            listViewex2mth1c.Items.Add(foxnex2mth1);
            list3ex2mth1.Add(foxnex2mth1);
            if (foxnex2mth1 < 0)
                {
                    lastnegativeex2mth1 = list3ex2mth1.IndexOf(foxnex2mth1);
                }
                else
                {
                    lastpositiveex2mth1 = list3ex2mth1.IndexOf(foxnex2mth1);
                }
            int fiex2 = list3ex2mth1.Count();
            int fi2ex2 = fiex2 - 1;
            int fi3ex2 = fiex2 - 2;

            if (list3ex2mth1[fi2ex2] != list3ex2mth1[fi3ex2])
                {
                    goto Resolutionex2;
                }
                else
                {
                    ex2txtmth1.Text = ex2txtmth1.Text + Environment.NewLine + "End of Iteration. Since f(x" + fiex2 + ") is equal to f(x" + fi2ex2 + ")" + Environment.NewLine;
                }


            }
            else
            {
                ex2txtmth1.Text = ex2txtmth1.Text + "Solution does not exist in the Interval: [" + x1ex2mth1 + "," + x2ex2mth1 + "]" + " Exists" + Environment.NewLine;
            }
        }

        private void label4_Click(object sender, RoutedEventArgs e)
        {
            listViewex2mth1a.Items.Clear();
            listViewex2mth1b.Items.Clear();
            listViewex2mth1c.Items.Clear();
            iterationex1mth1 = 0;
            list1ex2mth1.Clear();
            list2ex2mth1.Clear();
            list3ex2mth1.Clear();
            ex2txtmth1.Text = "Comments:";
        }

        private void listViewex2mth1a_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex2mth1b.SelectedIndex = listViewex2mth1a.SelectedIndex;
            listViewex2mth1c.SelectedIndex = listViewex2mth1a.SelectedIndex;
        }

        private void listViewex2mth1b_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex2mth1a.SelectedIndex = listViewex2mth1b.SelectedIndex;
            listViewex2mth1c.SelectedIndex = listViewex2mth1b.SelectedIndex;
        }

        private void listViewex2mth1c_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex2mth1b.SelectedIndex = listViewex2mth1c.SelectedIndex;
            listViewex2mth1a.SelectedIndex = listViewex2mth1c.SelectedIndex;
        }

        private void Ex3mth1button_Click(object sender, RoutedEventArgs e)
        {
            Example3Bisection();
        }

        private void Example3Bisection()
        {
            iterationex3mth1++;
            ex3txtmth1.Text = ex3txtmth1.Text + " Index " + iterationex3mth1 + Environment.NewLine;
            listViewex3mth1a.Items.Add(iterationex3mth1);
            x1ex3mth1 = double.Parse(Ex3mth1atextbox.Text);
            x2ex3mth1 = double.Parse(Ex3mth1btextbox.Text);
            x1ex3mth1 = Math.Round(x1ex3mth1, 4);
            x2ex3mth1 = Math.Round(x2ex3mth1, 4);
            listViewex3mth1b.Items.Add(x1ex3mth1);
            list2ex3mth1.Add(x1ex3mth1);
            fox1ex3mth1 = x1ex3mth1 - 2 + (Math.Log(x1ex3mth1, Math.E));
            fox1ex3mth1 = Math.Round(fox1ex3mth1, 4);
            listViewex3mth1c.Items.Add(fox1ex3mth1);
            list3ex3mth1.Add(fox1ex3mth1);
            if (fox1ex3mth1 < 0)
            {
                lastnegativeex3mth1 = list3ex3mth1.IndexOf(fox1ex3mth1);
            }
            else
            {
                lastpositiveex3mth1 = list3ex3mth1.IndexOf(fox1ex3mth1);
            }
            iterationex3mth1++;
            ex3txtmth1.Text = ex3txtmth1.Text + " Index " + iterationex3mth1 + Environment.NewLine;
            listViewex3mth1a.Items.Add(iterationex3mth1);
            listViewex3mth1b.Items.Add(x2ex3mth1);
            list2ex3mth1.Add(x2ex3mth1);
            fox2ex3mth1 = x2ex3mth1 - 2 + (Math.Log(x2ex3mth1, Math.E));
            fox2ex3mth1 = Math.Round(fox2ex3mth1, 4);
            listViewex3mth1c.Items.Add(fox2ex3mth1);
            list3ex3mth1.Add(fox2ex3mth1);
            if (fox2ex3mth1 < 0)
            {
                lastnegativeex3mth1 = list3ex3mth1.IndexOf(fox2ex3mth1);
            }
            else
            {
                lastpositiveex3mth1 = list3ex3mth1.IndexOf(fox2ex3mth1);
            }
            //in the interval [1,2] i.e x1=1, x2=2.
            if (fox1ex3mth1 * fox2ex3mth1 < 0)
            {
                ex3txtmth1.Text = ex3txtmth1.Text + "Solution Exists" + Environment.NewLine;
            Resolutionex3:
                ex3txtmth1.Text = ex3txtmth1.Text + " Index " + iterationex3mth1 + Environment.NewLine;
                iterationex3mth1++;
                listViewex3mth1a.Items.Add(iterationex3mth1);
                //when either is negative
                aex3mth1 = list2ex3mth1.ElementAt(lastnegativeex3mth1);
                bex3mth1 = list2ex3mth1.ElementAt(lastpositiveex3mth1);
                xnex3mth1 = (aex3mth1 + bex3mth1) / 2;
                xnex3mth1 = Math.Round(xnex3mth1, 4);
                ex3txtmth1.Text = ex3txtmth1.Text + "x(" + iterationex3mth1 + ")= " + xnex3mth1;
                list2ex3mth1.Add(xnex3mth1);
                listViewex3mth1b.Items.Add(xnex3mth1);
                foxnex3mth1 = xnex3mth1 - 2 + (Math.Log(xnex3mth1, Math.E)); 
                foxnex3mth1 = Math.Round(foxnex3mth1, 4);
                listViewex3mth1c.Items.Add(foxnex3mth1);
                list3ex3mth1.Add(foxnex3mth1);
                if (foxnex3mth1 < 0)
                {
                    lastnegativeex3mth1 = list3ex3mth1.IndexOf(foxnex3mth1);
                }
                else
                {
                    lastpositiveex3mth1 = list3ex3mth1.IndexOf(foxnex3mth1);
                }
                int fiex3 = list3ex3mth1.Count();
                int fi2ex3 = fiex3 - 1;
                int fi3ex3 = fiex3 - 2;

                if (list3ex3mth1[fi2ex3] != list3ex3mth1[fi3ex3])
                {
                    goto Resolutionex3;
                }
                else
                {
                    ex3txtmth1.Text = ex3txtmth1.Text + Environment.NewLine + "End of Iteration. Since f(x" + fiex3 + ") is equal to f(x" + fi2ex3 + ")" + Environment.NewLine;
                }


            }
            else
            {
                ex3txtmth1.Text = ex3txtmth1.Text + "Solution does not exist in the Interval: [" + x1ex3mth1 + "," + x2ex3mth1 + "]" + " Exists" + Environment.NewLine;
            }
        }

        private void label6_Click(object sender, RoutedEventArgs e)
        {
            listViewex3mth1a.Items.Clear();
            listViewex3mth1b.Items.Clear();
            listViewex3mth1c.Items.Clear();
            iterationex1mth1 = 0;
            list1ex3mth1.Clear();
            list2ex3mth1.Clear();
            list3ex3mth1.Clear();
            ex3txtmth1.Text = "Comments:";
        }

        private void listViewex3mth1a_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex3mth1b.SelectedIndex = listViewex3mth1a.SelectedIndex;
            listViewex3mth1c.SelectedIndex = listViewex3mth1a.SelectedIndex;
        }

        private void listViewex3mth1b_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex3mth1a.SelectedIndex = listViewex3mth1b.SelectedIndex;
            listViewex3mth1c.SelectedIndex = listViewex3mth1b.SelectedIndex;
        }

        private void listViewex3mth1c_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex3mth1b.SelectedIndex = listViewex3mth1c.SelectedIndex;
            listViewex3mth1a.SelectedIndex = listViewex3mth1c.SelectedIndex;
        }

        private void Ex4mth1button_Click(object sender, RoutedEventArgs e)
        {
            Example4Bisection();
        }

        private void Example4Bisection()
        {
            iterationex4mth1++;
            ex4txtmth1.Text = ex4txtmth1.Text + " Index " + iterationex4mth1 + Environment.NewLine;
            listViewex4mth1a.Items.Add(iterationex4mth1);
            x1ex4mth1 = double.Parse(Ex4mth1atextbox.Text);
            x2ex4mth1 = double.Parse(Ex4mth1btextbox.Text);
            x1ex4mth1 = Math.Round(x1ex4mth1, 4);
            x2ex4mth1 = Math.Round(x2ex4mth1, 4);
            listViewex4mth1b.Items.Add(x1ex4mth1);
            list2ex4mth1.Add(x1ex4mth1);
            fox1ex4mth1 = (Math.Cos(x1ex4mth1)) - x1ex4mth1;
            fox1ex4mth1 = Math.Round(fox1ex4mth1, 4);
            listViewex4mth1c.Items.Add(fox1ex4mth1);
            list3ex4mth1.Add(fox1ex4mth1);
            if (fox1ex4mth1 < 0)
            {
                lastnegativeex4mth1 = list3ex4mth1.IndexOf(fox1ex4mth1);
            }
            else
            {
                lastpositiveex4mth1 = list3ex4mth1.IndexOf(fox1ex4mth1);
            }
            iterationex4mth1++;
            ex4txtmth1.Text = ex4txtmth1.Text + " Index " + iterationex4mth1 + Environment.NewLine;
            listViewex4mth1a.Items.Add(iterationex4mth1);
            listViewex4mth1b.Items.Add(x2ex4mth1);
            list2ex4mth1.Add(x2ex4mth1);
            fox2ex4mth1 = (Math.Cos(x2ex4mth1)) - x2ex4mth1;
            fox2ex4mth1 = Math.Round(fox2ex4mth1, 4);
            listViewex4mth1c.Items.Add(fox2ex4mth1);
            list3ex4mth1.Add(fox2ex4mth1);
            if (fox2ex4mth1 < 0)
            {
                lastnegativeex4mth1 = list3ex4mth1.IndexOf(fox2ex4mth1);
            }
            else
            {
                lastpositiveex4mth1 = list3ex4mth1.IndexOf(fox2ex4mth1);
            }
            //in the interval [1,2] i.e x1=1, x2=2.
            if (fox1ex4mth1 * fox2ex4mth1 < 0)
            {
                ex4txtmth1.Text = ex4txtmth1.Text + "Solution Exists" + Environment.NewLine;
            Resolutionex4:
                ex4txtmth1.Text = ex4txtmth1.Text + " Index " + iterationex4mth1 + Environment.NewLine;
                iterationex4mth1++;
                listViewex4mth1a.Items.Add(iterationex4mth1);
                //when either is negative
                aex4mth1 = list2ex4mth1.ElementAt(lastnegativeex4mth1);
                bex4mth1 = list2ex4mth1.ElementAt(lastpositiveex4mth1);
                xnex4mth1 = (aex4mth1 + bex4mth1) / 2;
                xnex4mth1 = Math.Round(xnex4mth1, 4);
                ex4txtmth1.Text = ex4txtmth1.Text + "x(" + iterationex4mth1 + ")= " + xnex4mth1;
                list2ex4mth1.Add(xnex4mth1);
                listViewex4mth1b.Items.Add(xnex4mth1);
                foxnex4mth1 = (Math.Cos(xnex4mth1)) - xnex4mth1;
                foxnex4mth1 = Math.Round(foxnex4mth1, 4);
                listViewex4mth1c.Items.Add(foxnex4mth1);
                list3ex4mth1.Add(foxnex4mth1);
                if (foxnex4mth1 < 0)
                {
                    lastnegativeex4mth1 = list3ex4mth1.IndexOf(foxnex4mth1);
                }
                else
                {
                    lastpositiveex4mth1 = list3ex4mth1.IndexOf(foxnex4mth1);
                }
                int fiex4 = list3ex4mth1.Count();
                int fi2ex4 = fiex4 - 1;
                int fi3ex4 = fiex4 - 2;

                if (list3ex4mth1[fi2ex4] != list3ex4mth1[fi3ex4])
                {
                    goto Resolutionex4;
                }
                else
                {
                    ex4txtmth1.Text = ex4txtmth1.Text + Environment.NewLine + "End of Iteration. Since f(x" + fiex4 + ") is equal to f(x" + fi2ex4 + ")" + Environment.NewLine;
                }


            }
            else
            {
                ex4txtmth1.Text = ex4txtmth1.Text + "Solution does not exist in the Interval: [" + x1ex4mth1 + "," + x2ex4mth1 + "]" + " Exists" + Environment.NewLine;
            }
        }

        private void label8_Click(object sender, RoutedEventArgs e)
        {
            listViewex4mth1a.Items.Clear();
            listViewex4mth1b.Items.Clear();
            listViewex4mth1c.Items.Clear();
            iterationex1mth1 = 0;
            list1ex4mth1.Clear();
            list2ex4mth1.Clear();
            list3ex4mth1.Clear();
            ex4txtmth1.Text = "Comments:";
        }

        private void listViewex4mth1a_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex4mth1b.SelectedIndex = listViewex4mth1a.SelectedIndex;
            listViewex4mth1c.SelectedIndex = listViewex4mth1a.SelectedIndex;
        }

        private void listViewex4mth1b_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex4mth1a.SelectedIndex = listViewex4mth1b.SelectedIndex;
            listViewex4mth1c.SelectedIndex = listViewex4mth1b.SelectedIndex;
        }

        private void listViewex4mth1c_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex4mth1b.SelectedIndex = listViewex4mth1c.SelectedIndex;
            listViewex4mth1a.SelectedIndex = listViewex4mth1c.SelectedIndex;
        }


        //Secant Method
        private void Ex1mth2button_Click(object sender, RoutedEventArgs e)
        {
            Example1Secant();
        }

        private void Example1Secant()
        {
            iterationex1mth2++;
            ex1txtmth2.Text = ex1txtmth2.Text + " Index " + iterationex1mth2 + Environment.NewLine;
            listViewex1mth2a.Items.Add(iterationex1mth2);
            x1mth2 = double.Parse(Ex1mth2atextbox.Text); 
            x2mth2 = double.Parse(Ex1mth2btextbox.Text);
            x1mth2 = Math.Round(x1mth2, 4);
            x2mth2 = Math.Round(x2mth2, 4);
            listViewex1mth2b.Items.Add(x1mth2 );
            list2ex1mth2.Add(x1mth2);
            fox1mth2 = (Math.Pow(x1mth2,4)) + (3 * Math.Pow(x1mth2,3)) - x1mth2 -4;
            fox1mth2 = Math.Round(fox1mth2, 4);
            listViewex1mth2c.Items.Add(fox1mth2);
            list3ex1mth2.Add(fox1mth2);
            iterationex1mth2++;
            ex1txtmth2.Text = ex1txtmth2.Text + " Index " + iterationex1mth2 + Environment.NewLine;
            listViewex1mth2a.Items.Add(iterationex1mth2);
            listViewex1mth2b.Items.Add(x2mth2);
            list2ex1mth2.Add(x2mth2);
            fox2mth2 = (Math.Pow(x2mth2, 4)) + (3 * Math.Pow(x2mth2, 3)) - x2mth2 - 4;
            fox2mth2 = Math.Round(fox2mth2, 4);
            listViewex1mth2c.Items.Add(fox2mth2);
            list3ex1mth2.Add(fox2mth2);          
            //in the interval [1,2] i.e x1=1, x2=2.
            if (fox1mth2 * fox2mth2 < 0)                                                          //verify if this is still the case
            { 
                ex1txtmth2.Text = ex1txtmth2.Text + "Solution Exists" + Environment.NewLine;
            Resolution:              
                ex1txtmth2.Text = ex1txtmth2.Text + " Index " + iterationex1mth2 + Environment.NewLine;
                iterationex1mth2++;
                listViewex1mth2a.Items.Add(iterationex1mth2);
                int fii = list3ex1mth2.Count();
                int fi2i = fii - 1;
                int fi3i = fii - 2;
                amth2 = list2ex1mth2.ElementAt(fi2i);          //xprevious
                bmth2 = list3ex1mth2.ElementAt(fi2i);          //fofxprevious
                double cmth2 = list2ex1mth2.ElementAt(fi3i);   //xpreprevious
                double dmth2 = list3ex1mth2.ElementAt(fi3i);   //fofxpreprevious
                xnmth2 = amth2 - ((bmth2/(bmth2-dmth2)) * (amth2-cmth2));
                xnmth2 = Math.Round(xnmth2, 4);
                ex1txtmth2.Text = ex1txtmth2.Text + "x("+iterationex1mth2+")= " + xnmth2;
                list2ex1mth2.Add(xnmth2);
                listViewex1mth2b.Items.Add(xnmth2);
                foxnmth2 = (Math.Pow(xnmth2, 4)) + (3 * Math.Pow(xnmth2, 3)) - xnmth2 - 4;
                foxnmth2 = Math.Round(foxnmth2, 4);
                listViewex1mth2c.Items.Add(foxnmth2);
                list3ex1mth2.Add(foxnmth2);
                int fi = list3ex1mth2.Count();
                int fi2 = fi - 1;
                int fi3 = fi - 2;

                if (list3ex1mth2[fi2] != list3ex1mth2[fi3])
                {
                    goto Resolution;
                }
                else
                {
                    ex1txtmth2.Text = ex1txtmth2.Text + Environment.NewLine+ "End of Iteration. Since f(x" + fi + ") is equal to f(x" + fi2 + ")" + Environment.NewLine;
                }
           
                
            }
            else
            {
                ex1txtmth2.Text = ex1txtmth2.Text + "Solution does not exist in the Interval: [" + x1mth2 + "," + x2mth2 + "]" + " Exists" + Environment.NewLine;
            }
        }

        private void label10_Click(object sender, RoutedEventArgs e)
        {
             listViewex1mth2a.Items.Clear();
            listViewex1mth2b.Items.Clear();
            listViewex1mth2c.Items.Clear();
            iterationex1mth2 = 0;
            list1ex1mth2.Clear();
            list2ex1mth2.Clear();
            list3ex1mth2.Clear();
            ex1txtmth2.Text = "Comments:";
        }

        private void listViewex1mth2a_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex1mth2b.SelectedIndex = listViewex1mth2a.SelectedIndex;
            listViewex1mth2c.SelectedIndex = listViewex1mth2a.SelectedIndex; 
        }

        private void listViewex1mth2b_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex1mth2a.SelectedIndex = listViewex1mth2b.SelectedIndex;
            listViewex1mth2c.SelectedIndex = listViewex1mth2b.SelectedIndex;
        }

        private void listViewex1mth2c_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex1mth2b.SelectedIndex = listViewex1mth2c.SelectedIndex;
            listViewex1mth2a.SelectedIndex = listViewex1mth2c.SelectedIndex;
        }

        private void Ex2mth2button_Click(object sender, RoutedEventArgs e)
        {
            Example2Secant();
        }

        private void Example2Secant()
        {
            iterationex2mth2++;
            ex2txtmth2.Text = ex2txtmth2.Text + " Index " + iterationex2mth2 + Environment.NewLine;
            listViewex2mth2a.Items.Add(iterationex2mth2);
            x1ex2mth2 = double.Parse(Ex2mth2atextbox.Text);
            x2ex2mth2 = double.Parse(Ex2mth2btextbox.Text);
            x1ex2mth2 = Math.Round(x1ex2mth2, 4);
            x1ex2mth2 = Math.Round(x1ex2mth2, 4);
            listViewex2mth2b.Items.Add(x1ex2mth2);
            list2ex2mth2.Add(x1ex2mth2);
            fox1ex2mth2 = (Math.Pow(x1ex2mth2, 3)) - (Math.Pow(x1ex2mth2, 2)) - 1;
            fox1ex2mth2 = Math.Round(fox1ex2mth2, 4);
            listViewex2mth2c.Items.Add(fox1ex2mth2);
            list3ex2mth2.Add(fox1ex2mth2);
            iterationex2mth2++;
            ex2txtmth2.Text = ex2txtmth2.Text + " Index " + iterationex2mth2 + Environment.NewLine;
            listViewex2mth2a.Items.Add(iterationex2mth2);
            listViewex2mth2b.Items.Add(x2ex2mth2);
            list2ex2mth2.Add(x2ex2mth2);
            fox2ex2mth2 = (Math.Pow(x2ex2mth2, 3)) - (Math.Pow(x2ex2mth2, 2)) - 1;
            fox2ex2mth2 = Math.Round(fox2ex2mth2, 4);
            listViewex2mth2c.Items.Add(fox2ex2mth2);
            list3ex2mth2.Add(fox2ex2mth2);
            //in the interval [1,2] i.e x1=1, x2=2.
            if (fox1ex2mth2 * fox2ex2mth2 < 0)
            {
                ex2txtmth2.Text = ex2txtmth2.Text + "Solution Exists" + Environment.NewLine;
            Resolutionex2:
                ex2txtmth2.Text = ex2txtmth2.Text + " Index " + iterationex2mth2 + Environment.NewLine;
                iterationex2mth2++;
                listViewex2mth2a.Items.Add(iterationex2mth2);
                int fii = list3ex2mth2.Count();
                int fi2i = fii - 1;
                int fi3i = fii - 2;
                amth2 = list2ex2mth2.ElementAt(fi2i);          //xprevious
                bmth2 = list3ex2mth2.ElementAt(fi2i);          //fofxprevious
                double cmth2 = list2ex2mth2.ElementAt(fi3i);   //xpreprevious
                double dmth2 = list3ex2mth2.ElementAt(fi3i);   //fofxpreprevious
                xnmth2 = amth2 - ((bmth2 / (bmth2 - dmth2)) * (amth2 - cmth2));
                xnmth2 = Math.Round(xnmth2, 4);
                ex2txtmth2.Text = ex2txtmth2.Text + "x(" + iterationex2mth2 + ")= " + xnmth2;
                list2ex2mth2.Add(xnmth2);
                listViewex2mth2b.Items.Add(xnmth2);
                foxnex2mth2 = (Math.Pow(xnmth2, 3)) - (Math.Pow(xnmth2, 2)) - 1;
                foxnex2mth2 = Math.Round(foxnex2mth2, 4);
                listViewex2mth2c.Items.Add(foxnex2mth2);
                list3ex2mth2.Add(foxnex2mth2);
                int fiex2 = list3ex2mth2.Count();
                int fi2ex2 = fiex2 - 1;
                int fi3ex2 = fiex2 - 2;

                if (list3ex2mth2[fi2ex2] != list3ex2mth2[fi3ex2])
                {
                    goto Resolutionex2;
                }
                else
                {
                    ex2txtmth2.Text = ex2txtmth2.Text + Environment.NewLine + "End of Iteration. Since f(x" + fiex2 + ") is equal to f(x" + fi2ex2 + ")" + Environment.NewLine;
                }


            }
            else
            {
                ex2txtmth2.Text = ex2txtmth2.Text + "Solution does not exist in the Interval: [" + x1ex2mth2 + "," + x2ex2mth2 + "]" + " Exists" + Environment.NewLine;
            }
        }

        private void label12_Click(object sender, RoutedEventArgs e)
        {
            listViewex2mth2a.Items.Clear();
            listViewex2mth2b.Items.Clear();
            listViewex2mth2c.Items.Clear();
            iterationex2mth2 = 0;
            list1ex2mth2.Clear();
            list2ex2mth2.Clear();
            list3ex2mth2.Clear();
            ex2txtmth2.Text = "Comments:";
        }

        private void listViewex2mth2a_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex2mth2b.SelectedIndex = listViewex2mth2a.SelectedIndex;
            listViewex2mth2c.SelectedIndex = listViewex2mth2a.SelectedIndex;
        }

        private void listViewex2mth2b_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex2mth2a.SelectedIndex = listViewex2mth2b.SelectedIndex;
            listViewex2mth2c.SelectedIndex = listViewex2mth2b.SelectedIndex;
        }

        private void listViewex2mth2c_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex2mth2b.SelectedIndex = listViewex2mth2c.SelectedIndex;
            listViewex2mth2a.SelectedIndex = listViewex2mth2c.SelectedIndex;
        }

        private void Ex3mth2button_Click(object sender, RoutedEventArgs e)
        {
            Example3Secant();
        }

        private void Example3Secant()
        {
            iterationex3mth2++;
            ex3txtmth2.Text = ex3txtmth2.Text + " Index " + iterationex3mth2 + Environment.NewLine;
            listViewex3mth2a.Items.Add(iterationex3mth2);
            x1ex3mth2 = double.Parse(Ex3mth2atextbox.Text);
            x2ex3mth2 = double.Parse(Ex3mth2btextbox.Text);
            x1ex3mth2 = Math.Round(x1ex3mth2,4);
            x2ex3mth2 = Math.Round(x2ex3mth2, 4);
            listViewex3mth2b.Items.Add(x1ex3mth2);
            list2ex3mth2.Add(x1ex3mth2);
            fox1ex3mth2 = x1ex3mth2 - 2 + (Math.Log(x1ex3mth2, Math.E));
            fox1ex3mth2 = Math.Round(fox1ex3mth2, 4);
            listViewex3mth2c.Items.Add(fox1ex3mth2);
            list3ex3mth2.Add(fox1ex3mth2);
            iterationex3mth2++;
            ex3txtmth2.Text = ex3txtmth2.Text + " Index " + iterationex3mth2 + Environment.NewLine;
            listViewex3mth2a.Items.Add(iterationex3mth2);
            listViewex3mth2b.Items.Add(x2ex3mth2);
            list2ex3mth2.Add(x2ex3mth2);
            fox2ex3mth2 = x2ex3mth2 - 2 + (Math.Log(x2ex3mth2, Math.E));
            fox2ex3mth2 = Math.Round(fox2ex3mth2, 4);
            listViewex3mth2c.Items.Add(fox2ex3mth2);
            list3ex3mth2.Add(fox2ex3mth2);
            //in the interval [1,2] i.e x1=1, x2=2.
            if (fox1ex3mth2 * fox2ex3mth2 < 0)
            {
                ex3txtmth2.Text = ex3txtmth2.Text + "Solution Exists" + Environment.NewLine;
            Resolutionex3:
                ex3txtmth2.Text = ex3txtmth2.Text + " Index " + iterationex3mth2 + Environment.NewLine;
                iterationex3mth2++;
                listViewex3mth2a.Items.Add(iterationex3mth2);
                int fii = list3ex3mth2.Count();
                int fi2i = fii - 1;
                int fi3i = fii - 2;
                amth2 = list2ex3mth2.ElementAt(fi2i);          //xprevious
                bmth2 = list3ex3mth2.ElementAt(fi2i);          //fofxprevious
                double cmth2 = list2ex3mth2.ElementAt(fi3i);   //xpreprevious
                double dmth2 = list3ex3mth2.ElementAt(fi3i);   //fofxpreprevious
                xnmth2 = amth2 - ((bmth2 / (bmth2 - dmth2)) * (amth2 - cmth2));
                xnmth2 = Math.Round(xnmth2, 4);
                ex3txtmth2.Text = ex3txtmth2.Text + "x(" + iterationex3mth2 + ")= " + xnmth2;
                list2ex3mth2.Add(xnmth2);
                listViewex3mth2b.Items.Add(xnmth2);
                foxnex3mth2 = xnex3mth2 - 2 + (Math.Log(xnmth2, Math.E));
                foxnex3mth2 = Math.Round(foxnex3mth2, 4);
                listViewex3mth2c.Items.Add(foxnex3mth2);
                list3ex3mth2.Add(foxnex3mth2);
                int fiex3 = list3ex3mth2.Count();
                int fi2ex3 = fiex3 - 1;
                int fi3ex3 = fiex3 - 2;

                if (list3ex3mth2[fi2ex3] != list3ex3mth2[fi3ex3])
                {
                    goto Resolutionex3;
                }
                else
                {
                    ex3txtmth2.Text = ex3txtmth2.Text + Environment.NewLine + "End of Iteration. Since f(x" + fiex3 + ") is equal to f(x" + fi2ex3 + ")" + Environment.NewLine;
                }


            }
            else
            {
                ex3txtmth2.Text = ex3txtmth2.Text + "Solution does not exist in the Interval: [" + x1ex3mth2 + "," + x2ex3mth2 + "]" + " Exists" + Environment.NewLine;
            }
        }

       

        private void label14_Click(object sender, RoutedEventArgs e)
        {
            listViewex3mth2a.Items.Clear();
            listViewex3mth2b.Items.Clear();
            listViewex3mth2c.Items.Clear();
            iterationex3mth2 = 0;
            list1ex3mth2.Clear();
            list2ex3mth2.Clear();
            list3ex3mth2.Clear();
            ex3txtmth2.Text = "Comments:";
        }

        private void listViewex3mth2a_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex3mth2b.SelectedIndex = listViewex3mth2a.SelectedIndex;
            listViewex3mth2c.SelectedIndex = listViewex3mth2a.SelectedIndex;
        }

        private void listViewex3mth2b_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex3mth2a.SelectedIndex = listViewex3mth2b.SelectedIndex;
            listViewex3mth2c.SelectedIndex = listViewex3mth2b.SelectedIndex;
        }

        private void listViewex3mth2c_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex3mth2b.SelectedIndex = listViewex3mth2c.SelectedIndex;
            listViewex3mth2a.SelectedIndex = listViewex3mth2c.SelectedIndex;
        }

        private void Ex4mth2button_Click(object sender, RoutedEventArgs e)
        {
            Example4Secant();
        }

        private void Example4Secant()
        {
            iterationex4mth2++;
            ex4txtmth2.Text = ex4txtmth2.Text + " Index " + iterationex4mth2 + Environment.NewLine;
            listViewex4mth2a.Items.Add(iterationex4mth2);
            x1ex4mth2 = double.Parse(Ex4mth2atextbox.Text);
            x2ex4mth2 = double.Parse(Ex4mth2btextbox.Text);
            x1ex4mth2 = Math.Round(x1ex4mth2, 4);
            x2ex4mth2 = Math.Round(x2ex4mth2, 4);
            listViewex4mth2b.Items.Add(x1ex4mth2);
            list2ex4mth2.Add(x1ex4mth2);
            fox1ex4mth2 = (Math.Cos(x1ex4mth2)) - x1ex4mth2;
            fox1ex4mth2 = Math.Round(fox1ex4mth2, 4);
            listViewex4mth2c.Items.Add(fox1ex4mth2);
            list3ex4mth2.Add(fox1ex4mth2);
            iterationex4mth2++;
            ex4txtmth2.Text = ex4txtmth2.Text + " Index " + iterationex4mth2 + Environment.NewLine;
            listViewex4mth2a.Items.Add(iterationex4mth2);
            listViewex4mth2b.Items.Add(x2ex4mth2);
            list2ex4mth2.Add(x2ex4mth2);
            fox2ex4mth2 = (Math.Cos(x2ex4mth2)) - x2ex4mth2;
            fox2ex4mth2 = Math.Round(fox2ex4mth2, 4);
            listViewex4mth2c.Items.Add(fox2ex4mth2);
            list3ex4mth2.Add(fox2ex4mth2);
            //in the interval [1,2] i.e x1=1, x2=2.
            if (fox1ex4mth2 * fox2ex4mth2 < 0)
            {
                ex4txtmth2.Text = ex4txtmth2.Text + "Solution Exists" + Environment.NewLine;
            Resolutionex4:
                ex4txtmth2.Text = ex4txtmth2.Text + " Index " + iterationex4mth2 + Environment.NewLine;
                iterationex4mth2++;
                listViewex4mth2a.Items.Add(iterationex4mth2);
                int fii = list3ex4mth2.Count();
                int fi2i = fii - 1;
                int fi3i = fii - 2;
                amth2 = list2ex4mth2.ElementAt(fi2i);          //xprevious
                bmth2 = list3ex4mth2.ElementAt(fi2i);          //fofxprevious
                double cmth2 = list2ex4mth2.ElementAt(fi3i);   //xpreprevious
                double dmth2 = list3ex4mth2.ElementAt(fi3i);   //fofxpreprevious
                xnmth2 = amth2 - ((bmth2 / (bmth2 - dmth2)) * (amth2 - cmth2));
                xnmth2 = Math.Round(xnmth2, 4);
                ex4txtmth2.Text = ex4txtmth2.Text + "x(" + iterationex4mth2 + ")= " + xnmth2;
                list2ex4mth2.Add(xnmth2);
                listViewex4mth2b.Items.Add(xnmth2);
                foxnex4mth2 = (Math.Cos(xnmth2)) - xnmth2;
                foxnex4mth2 = Math.Round(foxnex4mth2, 4);
                listViewex4mth2c.Items.Add(foxnex4mth2);
                list3ex4mth2.Add(foxnex4mth2);
                int fiex4 = list3ex4mth2.Count();
                int fi2ex4 = fiex4 - 1;
                int fi3ex4 = fiex4 - 2;

                if (list3ex4mth2[fi2ex4] != list3ex4mth2[fi3ex4])
                {
                    goto Resolutionex4;
                }
                else
                {
                    ex4txtmth2.Text = ex4txtmth2.Text + Environment.NewLine + "End of Iteration. Since f(x" + fiex4 + ") is equal to f(x" + fi2ex4 + ")" + Environment.NewLine;
                }


            }
            else
            {
                ex4txtmth2.Text = ex4txtmth2.Text + "Solution does not exist in the Interval: [" + x1ex4mth2 + "," + x2ex4mth2 + "]" + " Exists" + Environment.NewLine;
            }
        }

        private void label16_Click(object sender, RoutedEventArgs e)
        {
            listViewex4mth2a.Items.Clear();
            listViewex4mth2b.Items.Clear();
            listViewex4mth2c.Items.Clear();
            iterationex4mth2 = 0;
            list1ex4mth2.Clear();
            list2ex4mth2.Clear();
            list3ex4mth2.Clear();
            ex4txtmth2.Text = "Comments:";
        }

        private void listViewex4mth2a_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex4mth2b.SelectedIndex = listViewex4mth2a.SelectedIndex;
            listViewex4mth2c.SelectedIndex = listViewex4mth2a.SelectedIndex;
        }

        private void listViewex4mth2b_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex4mth2a.SelectedIndex = listViewex4mth2b.SelectedIndex;
            listViewex4mth2c.SelectedIndex = listViewex4mth2b.SelectedIndex;
        }

        private void listViewex4mth2c_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex4mth2b.SelectedIndex = listViewex4mth2c.SelectedIndex;
            listViewex4mth2a.SelectedIndex = listViewex4mth2c.SelectedIndex;
        }




        // for Newton Method
        private void Ex1mth3button_Click(object sender, RoutedEventArgs e)
        {
            Example1Newton();
        }

        private void Example1Newton()
        {
            iterationex1mth3++;
            ex1txtmth3.Text = ex1txtmth3.Text + " Index " + iterationex1mth3 + Environment.NewLine;
            listViewex1mth3a.Items.Add(iterationex1mth3);
            x1ex1mth3 = double.Parse(Ex1mth3atextbox.Text); 
           // x2ex1mth3 = x1ex1mth3 -  double.Parse(Ex1mth3btextbox.Text);
            x1ex1mth3 = Math.Round(x1ex1mth3, 4);          
            listViewex1mth3b.Items.Add(x1ex1mth3 );
            list2ex1mth3.Add(x1ex1mth3 );
            fox1ex1mth3 = (Math.Pow(x1ex1mth3,4)) + (3 * Math.Pow(x1ex1mth3,3)) - x1ex1mth3 -4;
            fox1ex1mth3 = Math.Round(fox1ex1mth3, 4);
            fpox1ex1mth3 = 3* Math.Pow(x1ex1mth3,3) + (9 * Math.Pow(x1ex1mth3,2)) -1;
            fpox1ex1mth3 = Math.Round(fpox1ex1mth3, 4);
            x2ex1mth3 = x1ex1mth3 - (fox1ex1mth3 / fpox1ex1mth3);
            x2ex1mth3 = Math.Round(x2ex1mth3, 4);
            listViewex1mth3c.Items.Add(fox1ex1mth3);
            list3ex1mth3.Add(fox1ex1mth3);
            listViewex1mth3d.Items.Add(fpox1ex1mth3);
            lpist3ex1mth3.Add(fpox1ex1mth3);
            iterationex1mth3++;
            ex1txtmth3.Text = ex1txtmth3.Text + " Index " + iterationex1mth3 + Environment.NewLine;
            listViewex1mth3a.Items.Add(iterationex1mth3);
            listViewex1mth3b.Items.Add(x2ex1mth3);
            list2ex1mth3.Add(x2ex1mth3);
            fox2ex1mth3 = (Math.Pow(x2ex1mth3, 4)) + (3 * Math.Pow(x2ex1mth3, 3)) - x2ex1mth3 - 4;
            fox2ex1mth3 = Math.Round(fox2ex1mth3, 4);
            fpox2ex1mth3 = 3 * Math.Pow(x2ex1mth3, 3) + (9 * Math.Pow(x2ex1mth3, 2)) - 1;
            fpox2ex1mth3 = Math.Round(fpox2ex1mth3, 4);
            listViewex1mth3c.Items.Add(fox2ex1mth3);
            list3ex1mth3.Add(fox2ex1mth3);
            lpist3ex1mth3.Add(fpox2ex1mth3);
            listViewex1mth3d.Items.Add(fpox2ex1mth3);
            //in the interval [1,2] i.e x1=1, x2=2.
            if (fox1ex1mth3 * fox2ex1mth3 < 0)
            { 
                ex1txtmth3.Text = ex1txtmth3.Text + "Solution Exists" + Environment.NewLine;
            Resolution:              
                ex1txtmth3.Text = ex1txtmth3.Text + " Index " + iterationex1mth3 + Environment.NewLine;
                iterationex1mth3++;
                listViewex1mth3a.Items.Add(iterationex1mth3);             
                //when either is negative
                int fir = list3ex1mth3.Count();
                int fi2r = fir - 1;                                   //last
                int fi3r = fir - 2;                                   //prelast
                aex1mth3 = list2ex1mth3.ElementAt(fi2r);
                bex1mth3 = list3ex1mth3.ElementAt(fi2r);
                cex1mth3 = lpist3ex1mth3.ElementAt(fi2r);
                xnex1mth3 = aex1mth3 - (bex1mth3 / cex1mth3);
                xnex1mth3 = Math.Round(xnex1mth3, 4);
                ex1txtmth3.Text = ex1txtmth3.Text + "x("+iterationex1mth3+")= " + xnex1mth3;
                list2ex1mth3.Add(xnex1mth3);
                listViewex1mth3b.Items.Add(xnex1mth3);
                foxnex1mth3 = (Math.Pow(xnex1mth3, 4)) + (3 * Math.Pow(xnex1mth3, 3)) - xnex1mth3 - 4;
                foxnex1mth3 = Math.Round(foxnex1mth3, 4);
                fpoxnex1mth3 = 3 * Math.Pow(xnex1mth3, 3) + (9 * Math.Pow(xnex1mth3, 2)) - 1;
                fpoxnex1mth3 = Math.Round(fpoxnex1mth3, 4);
                listViewex1mth3c.Items.Add(foxnex1mth3);
                list3ex1mth3.Add(foxnex1mth3);
                listViewex1mth3d.Items.Add(fpoxnex1mth3);
                lpist3ex1mth3.Add(fpoxnex1mth3);

                int fi = list3ex1mth3.Count();
                int fi2 = fi - 1;
                int fi3 = fi - 2;

                if (list3ex1mth3[fi2] != list3ex1mth3[fi3])
                {
                    goto Resolution;
                }
                else
                {
                    ex1txtmth3.Text = ex1txtmth3.Text + Environment.NewLine+ "End of Iteration. Since f(x" + fi + ") is equal to f(x" + fi2 + ")" + Environment.NewLine;
                }
           
                
            }
            else
            {
                ex1txtmth3.Text = ex1txtmth3.Text + "Solution does not exist in the Interval: [" + x1ex1mth3 + "," + x2ex1mth3 + "]" + " Exists" + Environment.NewLine;
            }
        }

        private void label18_Click(object sender, RoutedEventArgs e)
        {
            listViewex1mth3a.Items.Clear();
            listViewex1mth3b.Items.Clear();
            listViewex1mth3c.Items.Clear();
            listViewex1mth3d.Items.Clear();
            iterationex1mth3 = 0;
            list1ex1mth3.Clear();
            list2ex1mth3.Clear();
            list3ex1mth3.Clear();
            lpist3ex1mth3.Clear();
            ex1txtmth3.Text = "Comments:";
        }

        private void listViewex1mth3a_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex1mth3b.SelectedIndex = listViewex1mth3a.SelectedIndex;
            listViewex1mth3c.SelectedIndex = listViewex1mth3a.SelectedIndex;
            listViewex1mth3d.SelectedIndex = listViewex1mth3a.SelectedIndex; 
        }

        private void listViewex1mth3b_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex1mth3a.SelectedIndex = listViewex1mth3b.SelectedIndex;
            listViewex1mth3c.SelectedIndex = listViewex1mth3b.SelectedIndex;
            listViewex1mth3d.SelectedIndex = listViewex1mth3b.SelectedIndex;
        }

        private void listViewex1mth3c_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex1mth3b.SelectedIndex = listViewex1mth3c.SelectedIndex;
            listViewex1mth3a.SelectedIndex = listViewex1mth3c.SelectedIndex;
            listViewex1mth3d.SelectedIndex = listViewex1mth3c.SelectedIndex;
        }
        private void listViewex1mth3d_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex1mth3b.SelectedIndex = listViewex1mth3d.SelectedIndex;
            listViewex1mth3a.SelectedIndex = listViewex1mth3d.SelectedIndex;
            listViewex1mth3c.SelectedIndex = listViewex1mth3d.SelectedIndex;
        }
        private void Ex2mth3button_Click(object sender, RoutedEventArgs e)
        {
            Example2Newton();
        }

        private void Example2Newton()
        {
            iterationex2mth3++;
            ex2txtmth3.Text = ex2txtmth3.Text + " Index " + iterationex2mth3 + Environment.NewLine;
            listViewex2mth3a.Items.Add(iterationex2mth3);
            x1ex2mth3 = double.Parse(Ex2mth3atextbox.Text);            
            x1ex2mth3 = Math.Round(x1ex2mth3, 4);           
            listViewex2mth3b.Items.Add(x1ex2mth3);
            list2ex2mth3.Add(x1ex2mth3);
            fox1ex2mth3 = (Math.Pow(x1ex2mth3, 3)) - (Math.Pow(x1ex2mth3, 2)) - 1;
            fox1ex2mth3 = Math.Round(fox1ex2mth3, 4);
            fpox1ex2mth3 = 3 * Math.Pow(x1ex2mth3, 2) - (2 * x1ex2mth3);
            fpox1ex2mth3 = Math.Round(fpox1ex2mth3, 4);
            x2ex2mth3 = x1ex2mth3 - (fox1ex2mth3 / fpox1ex2mth3);
            x2ex2mth3 = Math.Round(x2ex2mth3, 4);
            listViewex2mth3c.Items.Add(fox1ex2mth3);
            list3ex2mth3.Add(fox1ex2mth3);
            listViewex2mth3d.Items.Add(fpox1ex2mth3);
            lpist3ex2mth3.Add(fpox1ex2mth3);
            iterationex2mth3++;
            ex2txtmth3.Text = ex2txtmth3.Text + " Index " + iterationex2mth3 + Environment.NewLine;
            listViewex2mth3a.Items.Add(iterationex2mth3);
            listViewex2mth3b.Items.Add(x2ex2mth3);
            list2ex2mth3.Add(x2ex2mth3);
            fox2ex2mth3 = (Math.Pow(x2ex2mth3, 3)) - (Math.Pow(x2ex2mth3, 2)) - 1;
            fox2ex2mth3 = Math.Round(fox2ex2mth3, 4);
            fpox2ex2mth3 = 3 * Math.Pow(x2ex2mth3, 2) - (2 * x2ex2mth3);
            fpox2ex2mth3 = Math.Round(fpox2ex2mth3, 4);
            listViewex2mth3c.Items.Add(fox2ex2mth3);
            list3ex2mth3.Add(fox2ex2mth3);
            lpist3ex2mth3.Add(fpox2ex2mth3);
            listViewex2mth3d.Items.Add(fpox2ex2mth3);
            //in the interval [1,2] i.e x1=1, x2=2.
            //if (fox1ex2mth3 * fox2ex2mth3 < 0)
            //{
                ex2txtmth3.Text = ex2txtmth3.Text + "Solution Exists" + Environment.NewLine;
            Resolution:
                ex2txtmth3.Text = ex2txtmth3.Text + " Index " + iterationex2mth3 + Environment.NewLine;
                iterationex2mth3++;
                listViewex2mth3a.Items.Add(iterationex2mth3);
                //when either is negative
                int fir = list3ex2mth3.Count();
                int fi2r = fir - 1;                                   //last
                int fi3r = fir - 2;                                   //prelast
                aex2mth3 = list2ex2mth3.ElementAt(fi2r);
                bex2mth3 = list3ex2mth3.ElementAt(fi2r);
                cex2mth3 = lpist3ex2mth3.ElementAt(fi2r);
                xnex2mth3 = aex2mth3 - (bex2mth3 / cex2mth3);
                xnex2mth3 = Math.Round(xnex2mth3, 4);
                ex2txtmth3.Text = ex2txtmth3.Text + "x(" + iterationex2mth3 + ")= " + xnex2mth3;
                list2ex2mth3.Add(xnex2mth3);
                listViewex2mth3b.Items.Add(xnex2mth3);
                foxnex2mth3 = (Math.Pow(xnex2mth3, 3)) - (Math.Pow(xnex2mth3, 2)) - 1;
                foxnex2mth3 = Math.Round(foxnex2mth3, 4);
                fpoxnex2mth3 = 3 * Math.Pow(xnex2mth3, 2) - (2 * xnex2mth3);
                fpoxnex2mth3 = Math.Round(fpoxnex2mth3, 4);
                listViewex2mth3c.Items.Add(foxnex2mth3);
                list3ex2mth3.Add(foxnex2mth3);
                listViewex2mth3d.Items.Add(fpoxnex2mth3);
                lpist3ex2mth3.Add(fpoxnex2mth3);

                int fi = list3ex2mth3.Count();
                int fi2 = fi - 1;
                int fi3 = fi - 2;

                if (list3ex2mth3[fi2] != list3ex2mth3[fi3])
                {
                    goto Resolution;
                }
                else
                {
                    ex2txtmth3.Text = ex2txtmth3.Text + Environment.NewLine + "End of Iteration. Since f(x" + fi + ") is equal to f(x" + fi2 + ")" + Environment.NewLine;
                }


            //}
            //else
            //{
            //    ex2txtmth3.Text = ex2txtmth3.Text + "Solution does not exist in the Interval: [" + x1ex2mth3 + "," + x2ex2mth3 + "]" + " Exists" + Environment.NewLine;
            //}
        }

        private void label20_Click(object sender, RoutedEventArgs e)
        {
            listViewex2mth3a.Items.Clear();
            listViewex2mth3b.Items.Clear();
            listViewex2mth3c.Items.Clear();
            listViewex2mth3d.Items.Clear();
            iterationex2mth3 = 0;
            list1ex2mth3.Clear();
            list2ex2mth3.Clear();
            list3ex2mth3.Clear();
            lpist3ex2mth3.Clear();
            ex2txtmth3.Text = "Comments:";
        }

        private void listViewex2mth3a_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex2mth3b.SelectedIndex = listViewex2mth3a.SelectedIndex;
            listViewex2mth3c.SelectedIndex = listViewex2mth3a.SelectedIndex;
            listViewex2mth3d.SelectedIndex = listViewex2mth3a.SelectedIndex;
        }

        private void listViewex2mth3b_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex2mth3a.SelectedIndex = listViewex2mth3b.SelectedIndex;
            listViewex2mth3c.SelectedIndex = listViewex2mth3b.SelectedIndex;
            listViewex2mth3d.SelectedIndex = listViewex2mth3b.SelectedIndex;
        }

        private void listViewex2mth3c_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex2mth3b.SelectedIndex = listViewex2mth3c.SelectedIndex;
            listViewex2mth3a.SelectedIndex = listViewex2mth3c.SelectedIndex;
            listViewex2mth3d.SelectedIndex = listViewex2mth3c.SelectedIndex;
        }
        private void listViewex2mth3d_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex2mth3b.SelectedIndex = listViewex2mth3d.SelectedIndex;
            listViewex2mth3a.SelectedIndex = listViewex2mth3d.SelectedIndex;
            listViewex2mth3c.SelectedIndex = listViewex2mth3d.SelectedIndex;
        }
        private void Ex3mth3button_Click(object sender, RoutedEventArgs e)
        {
            Example3Newton();
        }

        private void Example3Newton()
        {
            iterationex3mth3++;
            ex3txtmth3.Text = ex3txtmth3.Text + " Index " + iterationex3mth3 + Environment.NewLine;
            listViewex3mth3a.Items.Add(iterationex3mth3);
            x1ex3mth3 = double.Parse(Ex3mth3atextbox.Text);            
            x1ex3mth3 = Math.Round(x1ex3mth3, 4);
            listViewex3mth3b.Items.Add(x1ex3mth3);
            list2ex3mth3.Add(x1ex3mth3);
            fox1ex3mth3 = x1ex3mth3 - 2 + (Math.Log(x1ex3mth3, Math.E));
            fox1ex3mth3 = Math.Round(fox1ex3mth3, 4);
            fpox1ex3mth3 = 1 + (1/x1ex3mth3);
            fpox1ex3mth3 = Math.Round(fpox1ex3mth3, 4);
            x2ex3mth3 = x1ex3mth3 - (fox1ex3mth3 / fpox1ex3mth3);
            x2ex3mth3 = Math.Round(x2ex3mth3, 4);
            listViewex3mth3c.Items.Add(fox1ex3mth3);
            list3ex3mth3.Add(fox1ex3mth3);
            listViewex3mth3d.Items.Add(fpox1ex3mth3);
            lpist3ex3mth3.Add(fpox1ex3mth3);
            iterationex3mth3++;
            ex3txtmth3.Text = ex3txtmth3.Text + " Index " + iterationex3mth3 + Environment.NewLine;
            listViewex3mth3a.Items.Add(iterationex3mth3);
            listViewex3mth3b.Items.Add(x2ex3mth3);
            list2ex3mth3.Add(x2ex3mth3);
            fox2ex3mth3 = x2ex3mth3 - 2 + (Math.Log(x2ex3mth3, Math.E));
            fox2ex3mth3 = Math.Round(fox2ex3mth3, 4);
            fpox2ex3mth3 = 1 + (1 / x2ex3mth3);
            fpox2ex3mth3 = Math.Round(fpox2ex3mth3, 4);
            listViewex3mth3c.Items.Add(fox2ex3mth3);
            list3ex3mth3.Add(fox2ex3mth3);
            lpist3ex3mth3.Add(fpox2ex3mth3);
            listViewex3mth3d.Items.Add(fpox2ex3mth3);
            //in the interval [1,2] i.e x1=1, x2=2.
            //if (fox1ex3mth3 * fox2ex3mth3 < 0)
            //{
                ex3txtmth3.Text = ex3txtmth3.Text + "Solution Exists" + Environment.NewLine;
            Resolution:
                ex3txtmth3.Text = ex3txtmth3.Text + " Index " + iterationex3mth3 + Environment.NewLine;
                iterationex3mth3++;
                listViewex3mth3a.Items.Add(iterationex3mth3);
                //when either is negative
                int fir = list3ex3mth3.Count();
                int fi2r = fir - 1;                                   //last
                int fi3r = fir - 2;                                   //prelast
                aex3mth3 = list2ex3mth3.ElementAt(fi2r);
                bex3mth3 = list3ex3mth3.ElementAt(fi2r);
                cex3mth3 = lpist3ex3mth3.ElementAt(fi2r);
                xnex3mth3 = aex3mth3 - (bex3mth3 / cex3mth3);
                xnex3mth3 = Math.Round(xnex3mth3, 4);
                ex3txtmth3.Text = ex3txtmth3.Text + "x(" + iterationex3mth3 + ")= " + xnex3mth3;
                list2ex3mth3.Add(xnex3mth3);
                listViewex3mth3b.Items.Add(xnex3mth3);
                foxnex3mth3 = xnex3mth3 - 2 + (Math.Log(xnex3mth3, Math.E));
                foxnex3mth3 = Math.Round(foxnex3mth3, 4);
                fpoxnex3mth3 = 1 + (1 / xnex3mth3);
                fpoxnex3mth3 = Math.Round(fpoxnex3mth3, 4);
                listViewex3mth3c.Items.Add(foxnex3mth3);
                list3ex3mth3.Add(foxnex3mth3);
                listViewex3mth3d.Items.Add(fpoxnex3mth3);
                lpist3ex3mth3.Add(fpoxnex3mth3);

                int fi = list3ex3mth3.Count();
                int fi2 = fi - 1;
                int fi3 = fi - 2;

                //if (list3ex3mth3[fi2] != list3ex3mth3[fi3])
                //{
                //    goto Resolution;
                //}
                if (iterationex3mth3 <= 7)
                {
                    goto Resolution;
                }
                else
                {
                    ex3txtmth3.Text = ex3txtmth3.Text + Environment.NewLine + "End of Iteration. Since f(x" + fi + ") is equal to f(x" + fi2 + ")" + Environment.NewLine;
                }


            //}
            //else
            //{
            //    ex3txtmth3.Text = ex3txtmth3.Text + "Solution does not exist in the Interval: [" + x1ex3mth3 + "," + x2ex3mth3 + "]" + " Exists" + Environment.NewLine;
            //}
        }

        private void label22_Click(object sender, RoutedEventArgs e)
        {
            listViewex3mth3a.Items.Clear();
            listViewex3mth3b.Items.Clear();
            listViewex3mth3c.Items.Clear();
            listViewex3mth3d.Items.Clear();
            iterationex3mth3 = 0;
            list1ex3mth3.Clear();
            list2ex3mth3.Clear();
            list3ex3mth3.Clear();
            lpist3ex3mth3.Clear();
            ex3txtmth3.Text = "Comments:";
        }

        private void listViewex3mth3a_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex3mth3b.SelectedIndex = listViewex3mth3a.SelectedIndex;
            listViewex3mth3c.SelectedIndex = listViewex3mth3a.SelectedIndex;
            listViewex3mth3d.SelectedIndex = listViewex3mth3a.SelectedIndex;
        }

        private void listViewex3mth3b_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex3mth3a.SelectedIndex = listViewex3mth3b.SelectedIndex;
            listViewex3mth3c.SelectedIndex = listViewex3mth3b.SelectedIndex;
            listViewex3mth3d.SelectedIndex = listViewex3mth3b.SelectedIndex;
        }

        private void listViewex3mth3c_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex3mth3b.SelectedIndex = listViewex3mth3c.SelectedIndex;
            listViewex3mth3a.SelectedIndex = listViewex3mth3c.SelectedIndex;
            listViewex3mth3d.SelectedIndex = listViewex3mth3c.SelectedIndex;
        }
        private void listViewex3mth3d_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex3mth3b.SelectedIndex = listViewex3mth3d.SelectedIndex;
            listViewex3mth3a.SelectedIndex = listViewex3mth3d.SelectedIndex;
            listViewex3mth3c.SelectedIndex = listViewex3mth3d.SelectedIndex;
        }
        private void Ex4mth3button_Click(object sender, RoutedEventArgs e)
        {
            Example4Newton();
        }

        private void Example4Newton()
        {
            iterationex4mth3++;
            ex4txtmth3.Text = ex4txtmth3.Text + " Index " + iterationex4mth3 + Environment.NewLine;
            listViewex4mth3a.Items.Add(iterationex4mth3);
            x1ex4mth3 = double.Parse(Ex4mth3atextbox.Text);            
            x1ex4mth3 = Math.Round(x1ex4mth3, 4);
            listViewex4mth3b.Items.Add(x1ex4mth3);
            list2ex4mth3.Add(x1ex4mth3);
            fox1ex4mth3 = (Math.Cos(x1ex4mth3)) - x1ex4mth3;
            fox1ex4mth3 = Math.Round(fox1ex4mth3, 4);
            fpox1ex4mth3 = -1 * (Math.Sin(x1ex4mth3)) - 1;
            fpox1ex4mth3 = Math.Round(fpox1ex4mth3, 4);
            x2ex4mth3 = x1ex4mth3 - (fox1ex4mth3 / fpox1ex4mth3);
            x2ex4mth3 = Math.Round(x2ex4mth3, 4);
            listViewex4mth3c.Items.Add(fox1ex4mth3);
            list3ex4mth3.Add(fox1ex4mth3);
            listViewex4mth3d.Items.Add(fpox1ex4mth3);
            lpist3ex4mth3.Add(fpox1ex4mth3);
            iterationex4mth3++;
            ex4txtmth3.Text = ex4txtmth3.Text + " Index " + iterationex4mth3 + Environment.NewLine;
            listViewex4mth3a.Items.Add(iterationex4mth3);
            listViewex4mth3b.Items.Add(x2ex4mth3);
            list2ex4mth3.Add(x2ex4mth3);
            fox2ex4mth3 = (Math.Cos(x2ex4mth3)) - x2ex4mth3;
            fox2ex4mth3 = Math.Round(fox2ex4mth3, 4);
            fpox2ex4mth3 = -1 * (Math.Sin(x2ex4mth3)) - 1;
            fpox2ex4mth3 = Math.Round(fpox2ex4mth3, 4);
            listViewex4mth3c.Items.Add(fox2ex4mth3);
            list3ex4mth3.Add(fox2ex4mth3);
            lpist3ex4mth3.Add(fpox2ex4mth3);
            listViewex4mth3d.Items.Add(fpox2ex4mth3);
            //in the interval [1,2] i.e x1=1, x2=2.
            //if (fox1ex4mth3 * fox2ex4mth3 < 0)
            //{
            //    ex4txtmth3.Text = ex4txtmth3.Text + "Solution Exists" + Environment.NewLine;
            Resolution:
                ex4txtmth3.Text = ex4txtmth3.Text + " Index " + iterationex4mth3 + Environment.NewLine;
                iterationex4mth3++;
                listViewex4mth3a.Items.Add(iterationex4mth3);
                //when either is negative
                int fir = list3ex4mth3.Count();
                int fi2r = fir - 1;                                   //last
                int fi3r = fir - 2;                                   //prelast
                aex4mth3 = list2ex4mth3.ElementAt(fi2r);
                bex4mth3 = list3ex4mth3.ElementAt(fi2r);
                cex4mth3 = lpist3ex4mth3.ElementAt(fi2r);
                xnex4mth3 = aex4mth3 - (bex4mth3 / cex4mth3);
                xnex4mth3 = Math.Round(xnex4mth3, 4);
                ex4txtmth3.Text = ex4txtmth3.Text + "x(" + iterationex4mth3 + ")= " + xnex4mth3;
                list2ex4mth3.Add(xnex4mth3);
                listViewex4mth3b.Items.Add(xnex4mth3);
                foxnex4mth3 = (Math.Cos(xnex4mth3)) - xnex4mth3;
                foxnex4mth3 = Math.Round(foxnex4mth3, 4);
                fpoxnex4mth3 = -1 * (Math.Sin(xnex4mth3)) - 1;
                fpoxnex4mth3 = Math.Round(fpoxnex4mth3, 4);
                listViewex4mth3c.Items.Add(foxnex4mth3);
                list3ex4mth3.Add(foxnex4mth3);
                listViewex4mth3d.Items.Add(fpoxnex4mth3);
                lpist3ex4mth3.Add(fpoxnex4mth3);

                int fi = list3ex4mth3.Count();
                int fi2 = fi - 1;
                int fi3 = fi - 2;

                if (list3ex4mth3[fi2] != list3ex4mth3[fi3])
                {
                    goto Resolution;
                }
                else
                {
                    ex4txtmth3.Text = ex4txtmth3.Text + Environment.NewLine + "End of Iteration. Since f(x" + fi + ") is equal to f(x" + fi2 + ")" + Environment.NewLine;
                }


            //}
            //else
            //{
            //    ex4txtmth3.Text = ex4txtmth3.Text + "Solution does not exist in the Interval: [" + x1ex4mth3 + "," + x2ex4mth3 + "]" + " Exists" + Environment.NewLine;
            //}
        }

        private void label24_Click(object sender, RoutedEventArgs e)
        {
            listViewex4mth3a.Items.Clear();
            listViewex4mth3b.Items.Clear();
            listViewex4mth3c.Items.Clear();
            listViewex4mth3d.Items.Clear();
            iterationex4mth3 = 0;
            list1ex4mth3.Clear();
            list2ex4mth3.Clear();
            list3ex4mth3.Clear();
            lpist3ex4mth3.Clear();
            ex4txtmth3.Text = "Comments:";
        }

        private void listViewex4mth3a_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex4mth3b.SelectedIndex = listViewex4mth3a.SelectedIndex;
            listViewex4mth3c.SelectedIndex = listViewex4mth3a.SelectedIndex;
            listViewex4mth3d.SelectedIndex = listViewex4mth3a.SelectedIndex;
        }

        private void listViewex4mth3b_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex4mth3a.SelectedIndex = listViewex4mth3b.SelectedIndex;
            listViewex4mth3c.SelectedIndex = listViewex4mth3b.SelectedIndex;
            listViewex4mth3d.SelectedIndex = listViewex4mth3b.SelectedIndex;
        }

        private void listViewex4mth3c_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex4mth3b.SelectedIndex = listViewex4mth3c.SelectedIndex;
            listViewex4mth3a.SelectedIndex = listViewex4mth3c.SelectedIndex;
            listViewex4mth3d.SelectedIndex = listViewex4mth3c.SelectedIndex;
        } 

        private void listViewex4mth3d_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listViewex4mth3b.SelectedIndex = listViewex4mth3d.SelectedIndex;
            listViewex4mth3a.SelectedIndex = listViewex4mth3d.SelectedIndex;
            listViewex4mth3c.SelectedIndex = listViewex4mth3d.SelectedIndex;
        }

        private void tabc1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tabc2.SelectedIndex = tabc1.SelectedIndex;
            tabc3.SelectedIndex = tabc1.SelectedIndex;
        }

        private void tabc2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tabc1.SelectedIndex = tabc2.SelectedIndex;
            tabc3.SelectedIndex = tabc2.SelectedIndex;
        }

        private void tabc3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tabc2.SelectedIndex = tabc3.SelectedIndex;
            tabc1.SelectedIndex = tabc3.SelectedIndex;
        }
    }
}
