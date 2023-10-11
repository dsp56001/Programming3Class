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
using WpfApp3.Models;
using WpfApp3.ViewModels;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DogViewModel vm;
        
        public MainWindow()
        {
            vm = new DogViewModel (new Dog() { Name = "Jerico" });
            InitializeComponent();
            this.DataContext = vm;
        }

        private void btnHappyBirthday_Click(object sender, RoutedEventArgs e)
        {
            vm.Age++;
        }

        private void btnEat_Click(object sender, RoutedEventArgs e)
        {
            vm.dog.Eat();
        }

        private void btnPoop_Click(object sender, RoutedEventArgs e)
        {
            vm.dog.Poop();
        }
    }
}
