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
using MyWpfClient.myPersonalService;

namespace MyWpfClient
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            HelloServiceOnWpf.HelloServiceClient client
                =  new HelloServiceOnWpf.HelloServiceClient("NetTcpBinding_IHelloService");
            label1.Content = client.GetMessage(textBox1.Text);

            myPersonalService.PersonalServiceClient myPersonalServiceClient = new PersonalServiceClient("BasicHttpBinding_IPersonalService");
            MessageBox.Show(myPersonalServiceClient.DoWork());
        }
    }
}
