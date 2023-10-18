using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp3.Models;

namespace WpfApp3.ViewModels
{
    public class DogViewModel : BaseViewModel 
    {
        public IDog dog;

        public ICommand HappyBirthdayCommand { get; set; }
        public ICommand EatCommand { get; set; }
        public ICommand PoopCommand { get; set; }

        public string Name
        {   
            get
            { 
                return dog.Name; 
            }
            set {
                dog.Name = value;
                RaisePropertyChangedEvent();
            }
        }

        public int Age
        {
            get
            {
                return dog.Age;
            }
            set
            {
                dog.Age = value;
                RaisePropertyChangedEvent();
            }
        }

        public int Weight
        {
            get
            {
                return dog.Weight;
            }
            set
            {
                dog.Weight = value;
                RaisePropertyChangedEvent();
            }
        }

        

        public DogViewModel(IDog dog)
        {
            this.dog = dog;
            HappyBirthdayCommand = new BasicCommand(HappyBirthday, HappyBirthDayCanExecute);
            EatCommand = new BasicCommand(OnEatCommand, EatCommandCanExecute);
            PoopCommand = new BasicCommand(OnPoopCommand, PoopCommandCanExecute);
        }

        private bool PoopCommandCanExecute(object parameter)
        {
            return true;
        }

        private void OnPoopCommand(object parameter)
        {
            this.dog.Poop();
            RaisePropertyChangedEvent("Weight");
        }

        private bool EatCommandCanExecute(object parameter)
        {
            return true;
        }

        private void OnEatCommand(object parameter)
        {
            this.dog.Eat();
            RaisePropertyChangedEvent("Weight");
        }

        public void HappyBirthday(object sender)
        {
            this.dog.Age++;//TODO shoudl defer to dog.HappyBirthday or use Dog IAgable
            RaisePropertyChangedEvent("Age");
        }

        public bool HappyBirthDayCanExecute(object sender) 
        {
            return true;
        }

        

        internal void Eat()
        {
            this.dog.Eat();
            RaisePropertyChangedEvent("Weight");
        }

        internal void Poop()
        {
            this.dog.Poop();
            RaisePropertyChangedEvent("Weight");
        }
    }
}
