using Microsoft.Win32;
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

namespace GRegServ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog ofd = new OpenFileDialog();
        Commands File = new Commands();
        public static List<string> SelectedFiles = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Select The File(s) You Want to Register";
            ofd.Multiselect = true;
        }

        private void btnSelectFiles_Click(object sender, RoutedEventArgs e)
        {
            SelectedFiles.Clear();
            lstSelectedFiles.Items.Clear();

            ofd.ShowDialog();
            foreach (string file in ofd.FileNames)
            {
                SelectedFiles.Add(file);
                lstSelectedFiles.Items.Add(file);
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            File.RegisterDLL();
            lstSelectedFiles.Items.Clear();
            SelectedFiles.Clear();
            //lstSelectedFiles.ItemsSource = Commands.succeeded;
        }

        private void btnUnregister_Click(object sender, RoutedEventArgs e)
        {
            File.UnregisterDLL();
            lstSelectedFiles.Items.Clear();
            SelectedFiles.Clear();
        }
    }
}
