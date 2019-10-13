using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged
    {
        Model model = new Model();

        public Model ModelProperty
        {
            get
            {
                return model;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            model.Name = "I am a model of the main window!";
            InitializeComponent();
        }
    }
}
