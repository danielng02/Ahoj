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

namespace Ahoj
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nameText.Text = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name = nameText.Text;
            MessageBox.Show("Hello " + name);
        }
        
        string name;
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
