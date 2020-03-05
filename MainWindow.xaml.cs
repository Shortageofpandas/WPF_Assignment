using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using Microsoft.Win32;

namespace wpfAssignment
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();
        public MainWindow()
        {
            InitializeComponent();
            gridOuter.DataContext = users;
        }

        private void ReadFromFile(object sender, RoutedEventArgs e)
        {
            users.Clear();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.InitialDirectory = "C:\\";
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == true)
            {
                string filePath = ofd.FileName;

                using (StreamReader file = new StreamReader(filePath))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        users.Add(new User(line));
                    }
                    file.Dispose();
                    file.Close();
                }
            }
            watch.Stop();
            statusBar.Content = $"Last Load happended at: {DateTime.Now.ToString("HH:mm:ss")} - {users.Count.ToString("#,##")} users loaded.";
        }
    }
}
