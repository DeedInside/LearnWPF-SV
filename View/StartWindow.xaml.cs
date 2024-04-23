using LearnWPF_SV.ViewModel;
using System.Reflection.Emit;
using System.Windows;
using System.Windows.Controls;

namespace LearnWPF_SV.View
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
            //DataContext = new StartWindowViewModel();
         
            MyLable.Content = "qweqweqwe";
        }
    }
}
