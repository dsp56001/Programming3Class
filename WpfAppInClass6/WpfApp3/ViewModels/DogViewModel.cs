using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.Models;

namespace WpfApp3.ViewModels
{
    public class DogViewModel : INotifyPropertyChanged
    {
        public Dog dog;

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

        public event PropertyChangedEventHandler PropertyChanged;

        public DogViewModel(Dog dog) 
        { 
            this.dog = dog;
        }

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void RaisePropertyChangedEvent([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
