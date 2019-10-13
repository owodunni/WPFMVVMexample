using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ViewModel : INotifyPropertyChanged
    {
        Model model = new Model();

        public ViewModel()
        {
            model.Name = "I am a model of the view model!";
        }

        public Model ModelProperty
        {
            get
            {
                return model;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
