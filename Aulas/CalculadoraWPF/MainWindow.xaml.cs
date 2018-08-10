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

namespace CalculadoraWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        int tipo;
        float n1, n2;
        float? memoria;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            lblDisplay.Content += 1.ToString();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            lblDisplay.Content += 2.ToString();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            lblDisplay.Content += 3.ToString();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            lblDisplay.Content += 4.ToString();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            lblDisplay.Content += 5.ToString();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            lblDisplay.Content += 6.ToString();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            lblDisplay.Content += 7.ToString();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            lblDisplay.Content += 8.ToString();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            lblDisplay.Content += 9.ToString();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            lblDisplay.Content += 0.ToString();
        }

        private void btnMais_Click(object sender, RoutedEventArgs e)
        {
            tipo = 1;
            n1 = float.Parse(lblDisplay.Content.ToString());
            lblDisplay.Content = "";

        }

        private void btnMenos_Click(object sender, RoutedEventArgs e)
        {
            tipo = 2;
            n1 = float.Parse(lblDisplay.Content.ToString());
            lblDisplay.Content = "";
        }

        private void btnVezes_Click(object sender, RoutedEventArgs e)
        {
            tipo = 3;
            n1 = float.Parse(lblDisplay.Content.ToString());
            lblDisplay.Content = "";
        }

        private void btnPot_Click(object sender, RoutedEventArgs e)
        {
            tipo = 4;
            n1 = float.Parse(lblDisplay.Content.ToString());
            lblDisplay.Content = "";
        }

        private void btnRaiz_Click(object sender, RoutedEventArgs e)
        {
            tipo = 5;
            n1 = float.Parse(lblDisplay.Content.ToString());
            //lblDisplay.Content = "";
        }

        private void btnMemoria_Click(object sender, RoutedEventArgs e)
        {

            tipo = 6;


            if (!string.IsNullOrEmpty(lblDisplay.Content.ToString()))
            {
                memoria = float.Parse(lblDisplay.Content.ToString());
                lblDisplay.Content = "";
            }
            else {
                if (memoria.HasValue )
                {
                    lblDisplay.Content = memoria;
                }
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            tipo = 7;
            n1 = float.Parse(lblDisplay.Content.ToString());
            lblDisplay.Content = "";
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(lblDisplay.Content.ToString()))
            {
                n2 = float.Parse(lblDisplay.Content.ToString());

                switch (tipo)
                {
                    case 1:

                        lblDisplay.Content = (n1 + n2).ToString();
                        break;

                    case 2:

                        lblDisplay.Content = (n1 - n2).ToString();
                        break;

                    case 3:
                        lblDisplay.Content = (n1 * n2).ToString();
                        break;

                    case 4:
                        //lblDisplay.Content = (n1 / n2).ToString();
                        lblDisplay.Content = Math.Pow(n1, n2).ToString();
                        break;
                    case 5:

                        lblDisplay.Content = Math.Sqrt(n1);
                        break;

                    case 6:
                        if (lblDisplay.Content.Equals(""))
                        {
                            if (memoria.HasValue)
                            {
                                lblDisplay.Content = memoria;
                                lblDisplay.Content = "";
                            }
                            else
                            {
                                memoria = float.Parse(lblDisplay.Content.ToString());
                                lblDisplay.Content = "";
                            }
                        }
                        break;

                    case 7:
                        lblDisplay.Content = (n1 / n2).ToString();
                        break;






                }

                tipo = 7;
            }
        }
    }
}
