﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using jsoner;

namespace BiblPrakt
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

        private void Serializer_Click(object sender, RoutedEventArgs e)
        {
            SerialDes.Ser(NameBar.Text,AnimBar.Text);
            NameBar.Text = "";
            AnimBar.Text = "";
        }

        private void Deserialiser_Click(object sender, RoutedEventArgs e)
        {
            List<human> kek = SerialDes.Des<List<jsoner.human>>("chel.json");
            NameBar.Text = kek[0].name;
            AnimBar.Text = kek[0].favanim;
            
        }
    }
}