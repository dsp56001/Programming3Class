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
using WpfApp3.Models;
using WpfApp3.ViewModels;

namespace WpfApp3.Views
{
    /// <summary>
    /// Interaction logic for UserControlDog.xaml
    /// </summary>
    public partial class UserControlDog : UserControl
    {
        DogViewModel vm;

        public UserControlDog()
        {
            InitializeComponent();
            vm = new DogViewModel(new Dog() { Name = "Jerico" });
            this.DataContext = vm;
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
        }
    }
}
