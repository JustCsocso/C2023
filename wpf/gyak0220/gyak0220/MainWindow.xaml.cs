﻿using System;
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

namespace gyak0220
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int osszeg = Convert.ToInt32(textBox.Text) + Convert.ToInt32(textBox2.Text);

            textBlock.Text=osszeg.ToString();

            textBlock1.Text=textBox.Text+" + "+ textBox2.Text+" = "+ osszeg.ToString()+"\n";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
