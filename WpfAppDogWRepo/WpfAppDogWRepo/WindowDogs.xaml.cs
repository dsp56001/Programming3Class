using DogLibrary;
using DogLibraryCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppDogWRepo
{
    /// <summary>
    /// Interaction logic for WindowDogs.xaml
    /// </summary>
    public partial class WindowDogs : Window
    {
        MammalRepoSimple repo;
        
        public WindowDogs()
        {
            repo = new MammalRepoSimple();
            InitalizeRepo(repo);
            InitializeComponent();
        }

        private void InitalizeRepo(MammalRepoSimple repo)
        {
            repo.Add(
                new List<IMammal>() {
                    new Dog() {  Name = "fido", Age = 1 },
                    new Dog() { Name = "Benj", Age = 2 }
                }
            );
                
                
        }
    }
}
