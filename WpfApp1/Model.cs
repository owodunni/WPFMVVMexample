using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Model : INotifyPropertyChanged
    {
        private string name = "I am a free model!";

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
