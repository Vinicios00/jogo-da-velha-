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

namespace JogoDaVelha
{    public partial class MainWindow : Window
    {
        bool vez = true;
        int y = 0;
        int z = 0;
        int ultimaJogada = 0;
        int segundaJogada = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void click1(object sender, RoutedEventArgs e)
        {
            if (vez == true)
            {
                y++;
                z++;
                _01.Visibility = Visibility.Visible;
                a1.Visibility = Visibility.Hidden;
                Computador();
            }
        }

        private void click2(object sender, RoutedEventArgs e)
        {
            if (vez == true)
            {
                y += 2;
                z++;
                _02.Visibility = Visibility.Visible;
                a2.Visibility = Visibility.Hidden;
                Computador();
                
            }
        }

        private void click3(object sender, RoutedEventArgs e)
        {
            if (vez == true)
            {
                y += 3;
                z++;
                _03.Visibility = Visibility.Visible;
                a3.Visibility = Visibility.Hidden;
                Computador();
            }
        }

        private void click4(object sender, RoutedEventArgs e)
        {
            if (vez == true)
            {
                y += 4;
                z++;
                _04.Visibility = Visibility.Visible;
                b1.Visibility = Visibility.Hidden;
                Computador();
            }
        }


        private void click5(object sender, RoutedEventArgs e)
        {
            if (vez == true)
            {
                y += 5;
                z++;
                _05.Visibility = Visibility.Visible;
                b2.Visibility = Visibility.Hidden;
                Computador();
            }
        }

        private void click6(object sender, RoutedEventArgs e)
        {
            if (vez == true)
            {
                y += 6;
                z++;
                _06.Visibility = Visibility.Visible;
                b3.Visibility = Visibility.Hidden;
                Computador();
            }            
        }

        private void click7(object sender, RoutedEventArgs e)
        {
            if (vez == true)
            {
                y += 7;
                z++;
                _07.Visibility = Visibility.Visible;
                c1.Visibility = Visibility.Hidden;
                Computador();
            }
        }

        private void click8(object sender, RoutedEventArgs e)
        {
            if (vez == true)
            {
                y += 8;
                z++;
                _08.Visibility = Visibility.Visible;
                c2.Visibility = Visibility.Hidden;
                Computador();
            }            
        }

        private void click9(object sender, RoutedEventArgs e)
        {
            if (vez == true)
            {
                y += 9;
                z++;
                _09.Visibility = Visibility.Visible;
                c3.Visibility = Visibility.Hidden;
                Computador();
            }
        }
        private void Computador()
        {
            if (z == 1)
            {
                if (y == 1 || y == 2 || y == 3 || y == 4 || y == 6 || y == 7 || y == 8 || y == 9)
                {
                    X5.Visibility = Visibility.Visible;
                    b2.Visibility= Visibility.Hidden;
                    ultimaJogada = y;
                    y = 0;
                }
                if (y == 5)
                {
                    X1.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Hidden;
                    ultimaJogada = y;
                    y = 0;
                }
            }
            if (z == 2)
            {
                if(y == 2 && ultimaJogada ==1)
                {
                    X3.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (y == 3 || y == 6 && ultimaJogada ==1)
                {
                    X2.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if(y == 4 && ultimaJogada == 1)
                {
                    X7.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if(y == 7 || y == 8 && ultimaJogada == 1)
                {
                    X4.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (y == 9 && ultimaJogada ==1)
                {
                    X6.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (y == 3 && ultimaJogada == 2)
                {
                    X1.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (y == 1 && ultimaJogada == 2)
                {
                    X3.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (y == 4 && ultimaJogada == 2)
                {
                    X7.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (y == 6 && ultimaJogada == 2)
                {
                    X9.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (y == 7 && ultimaJogada == 2)
                {
                    X4.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (y== 8 && ultimaJogada == 2)
                {
                    X4.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (y == 9 && ultimaJogada == 2)
                {
                    X6.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 3 && y == 1)
                {
                    X2.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if(ultimaJogada == 3 && y == 2)
                {
                    X1.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 3 && y == 4)
                {
                    X2.Visibility= Visibility.Visible;
                    a2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 3 && y == 6)
                {
                    X9.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if(ultimaJogada == 3 && y == 7)
                {
                    X4.Visibility= Visibility.Visible;
                    b1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if(ultimaJogada == 3 && y == 8)
                {
                    X6.Visibility= Visibility.Visible;
                    b3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 3 && y == 9)
                {
                    X6.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 4 && y == 1)
                {
                    X7.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 4 && y == 2)
                {
                    X7.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 4 && y == 3)
                {
                    X2.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 4 && y == 6)
                {
                    X2.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 4 && y == 7)
                {
                    X1.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 4 && y == 8)
                {
                    X1.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 4 && y == 9)
                {
                    X8.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 6 && y == 1)
                {
                    X2.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 6 && y == 2)
                {
                    X9.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 6 && y == 3)
                {
                    X9.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 6 && y == 4)
                {
                    X2.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 6 && y == 7)
                {
                    X8.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 6 && y == 8)
                {
                    X3.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 6 && y == 9)
                {
                    X3.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 7 && y == 1)
                {
                    X4.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 7 && y == 2)
                {
                    X4.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 7 && y == 3)
                {
                    X4.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 7 && y == 4)
                {
                    X1.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 7 && y == 6)
                {
                    X8.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 7 && y == 8)
                {
                    X9.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 8 && y == 1)
                {
                    X4.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 8 && y == 2)
                {
                    X4.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 8 && y == 3)
                {
                    X6.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 8 && y == 4)
                {
                    X1.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 8 && y == 6)
                {
                    X3.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 8 && y == 7)
                {
                    X9.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 8 && y == 9)
                {
                    X7.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 9 && y == 1)
                {
                    X6.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 9 && y == 2)
                {
                    X6.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 9 && y == 3)
                {
                    X6.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 9 && y == 4)
                {
                    X8.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 9 && y == 7)
                {
                    X8.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 9 && y == 6)
                {
                    X3.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 5 && y == 2)
                {
                    X8.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 5 && y == 3)
                {
                    X7.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 5 && y == 4)
                {
                    X6.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 5 && y == 6)
                {
                    X4.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 5 && y == 7)
                {
                    X3.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 5 && y == 8)
                {
                    X2.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
                if (ultimaJogada == 5 && y == 9)
                {
                    X7.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Hidden;
                    segundaJogada = y;
                    y = 0;
                }
            }
            if(z == 3)
            {
                if(ultimaJogada == 1 && segundaJogada == 2 && y != 7)
                {
                    X7.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Visible;
                    c1.Background = Brushes.Green;
                    a3.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 1 && segundaJogada == 3 && y != 8)
                {
                    X8.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    c2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    a2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 1 && segundaJogada == 4 && y != 3)
                {
                    X3.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Visible;
                    a3.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c1.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 1 && segundaJogada == 6 && y != 8)
                {
                    X8.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    c2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    a2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 1 && segundaJogada == 8 && y != 6)
                {
                    X6.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b3.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b1.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 1 && segundaJogada == 9 && y != 4)
                {
                    X4.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 2 && segundaJogada == 1 && y != 7)
                {
                    X7.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    c1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    a3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 2 && segundaJogada == 3 && y != 9)
                {
                    X9.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    a1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 2 && segundaJogada == 4 && y != 3)
                {
                    X3.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    c1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    a3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 2 && segundaJogada == 6 && y != 1)
                {
                    X1.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    a1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 2 && segundaJogada == 7 && y != 6)
                {
                    X6.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 2 && segundaJogada == 8 && y != 6)
                {
                    X6.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 2 && segundaJogada == 9 && y != 4)
                {
                    X6.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 3 && segundaJogada == 1 && y != 8)
                {
                    X8.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    a2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 3 && segundaJogada == 2 && y != 9)
                {
                    X9.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Visible;
                    a1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 3 && segundaJogada == 4 && y != 8)
                {
                    X8.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    a2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 3 && segundaJogada == 6 && y != 1)
                {
                    X1.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Visible;
                    a1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 3 && segundaJogada == 7 && y != 6)
                {
                    X6.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 3 && segundaJogada == 8 && y != 4)
                {
                    X4.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 3 && segundaJogada == 9 && y != 4)
                {
                    X4.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 4 && segundaJogada == 1 && y != 3)
                {
                    X3.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Visible;
                    c1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    a3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 4 && segundaJogada == 2 && y !=3 )
                {
                    X3.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Visible;
                    c1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    a3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 4 && segundaJogada == 3 && y != 8)
                {
                    X8.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    a2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 4 && segundaJogada == 6 && y != 8)
                {
                    X8.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    a2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 4 && segundaJogada == 7 && y != 9)
                {
                    X9.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Visible;
                    a1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 4 && segundaJogada == 8 && y != 9)
                {
                    X9.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Visible;
                    a1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 4 && segundaJogada == 9 && y != 2)
                {
                    X2.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    a2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 6 && segundaJogada == 1 && y != 8)
                {
                    X8.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    a2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 6 && segundaJogada == 2 && y != 1)
                {
                    X1.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Visible;
                    a1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 6 && segundaJogada == 3 && y != 1)
                {
                    X1.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Visible;
                    a1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 6 && segundaJogada == 4 && y != 8)
                {
                    X8.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    a2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 6 && segundaJogada == 7 && y != 2)
                {
                    X2.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    a2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 6 && segundaJogada == 8 && y != 7)
                {
                    X7.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Visible;
                    a3.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c1.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 6 && segundaJogada == 9 && y != 7)
                {
                    X7.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Visible;
                    a3.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c1.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 7 && segundaJogada == 1 && y != 6)
                {
                    X6.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 7 && segundaJogada == 2 && y != 6)
                {
                    X6.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 7 && segundaJogada == 3 && y != 6)
                {
                    X6.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 7 && segundaJogada == 4 && y != 9)
                {
                    X9.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Visible;
                    a1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 7 && segundaJogada == 6 && y != 2)
                {
                    X2.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    a2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 7 && segundaJogada == 8 && y != 1)
                {
                    X1.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Visible;
                    a1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 7 && segundaJogada == 9 && y != 2)
                {
                    X2.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    a2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 8 && segundaJogada == 1 && y != 6)
                {
                    X6.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 8 && segundaJogada == 2 && y != 6)
                {
                    X6.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 8 && segundaJogada == 3 && y != 4)
                {
                    X4.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 8 && segundaJogada == 4 && y != 9)
                {
                    X9.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Visible;
                    a1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 8 && segundaJogada == 6 && y != 7)
                {
                    X7.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Visible;
                    c1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    a3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 8 && segundaJogada == 7 && y != 1)
                {
                    X1.Visibility = Visibility.Visible;
                    a1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c3.Visibility = Visibility.Visible;
                    a1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 8 && segundaJogada == 9 && y != 3)
                {
                    X3.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Visible;
                    c1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    a3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 9 && segundaJogada == 1 && y != 3)
                {
                    X3.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 9 && segundaJogada == 2 && y != 3)
                {
                    X3.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 9 && segundaJogada == 3 && y != 3)
                {
                    X3.Visibility = Visibility.Visible;
                    b1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    b3.Visibility = Visibility.Visible;
                    b1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    b3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 9 && segundaJogada == 4 && y != 2)
                {
                    X2.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    a2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 9 && segundaJogada == 6 && y != 7)
                {
                    X7.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Visible;
                    c1.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    a3.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 9 && segundaJogada == 7 && y != 2)
                {
                    X2.Visibility = Visibility.Visible;
                    a2.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c2.Visibility = Visibility.Visible;
                    a2.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c2.Background = Brushes.Green;
                    y = 0;
                }
                if (ultimaJogada == 9 && segundaJogada == 8 && y != 3)
                {
                    X3.Visibility = Visibility.Visible;
                    a3.Visibility = Visibility.Visible;
                    b2.Visibility = Visibility.Visible;
                    c1.Visibility = Visibility.Visible;
                    a3.Background = Brushes.Green;
                    b2.Background = Brushes.Green;
                    c1.Background = Brushes.Green;
                    y = 0;
                }

            }
        }
    }
}
