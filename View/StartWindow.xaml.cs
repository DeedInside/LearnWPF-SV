using LearnWPF_SV.ViewModel;
using System.Reflection.Emit;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

		private void Copu(object sender, RoutedEventArgs e)
		{
            string str = box.Text;

            lab.Content = str;  

		}

		private void CheckBox_Checked(object sender, RoutedEventArgs e)
		{
            chek2.IsChecked = true;
		}

		private void RadioButton_Checked(object sender, RoutedEventArgs e)
		{

		}

		private void RadioButton(object	 sender, RoutedEventArgs e)
		{
			RadioButton pressed = sender as RadioButton;
			MessageBox.Show(pressed.Content.ToString());
		}
	}
}
