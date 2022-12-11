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
using Newtonsoft;
using Newtonsoft.Json;

namespace JSONSave
{
    public partial class MainWindow : Window
    {
        List<Uczen> myList = new List<Uczen>();
        public MainWindow()
        {
            InitializeComponent();
            myList.Add(new Uczen("Daria", "Pałka", "4B"));
            myList.Add(new Uczen("Maja", "Krajniewska", "4B"));
            myList.Add(new Uczen("Ala", "Maciejewska", "4B"));

            myListView.ItemsSource = myList;

        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            newObj nowy = new();
            nowy.ShowDialog();
            string imie = nowy.userName.Text;
            string nazwisko = nowy.userSurname.Text;
            string klasa = nowy.userClass.Text;

            Uczen uczen = new(imie, nazwisko, klasa);
            myList.Add(uczen);


            myListView.ItemsSource = null;
            myListView.ItemsSource = myList;

        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            string fileLocation = "C:\\Users\\verte\\Desktop\\jsonFile.json";

            var json = JsonConvert.SerializeObject(myList);

            System.IO.File.WriteAllText(fileLocation, json);
        }

        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
