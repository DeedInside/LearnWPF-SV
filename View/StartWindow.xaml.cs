using LearnWPF_SV.Model;
using LearnWPF_SV.ViewModel;
using System.Reflection.Emit;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LearnWPF_SV.View
{
    public partial class StartWindow : Window
    {
		Stack<int> stack = new Stack<int> ();
		List<int> listInt = new List<int>();
		List<User> user { get; set; } = new List<User>();

		object Select { get; set; }


		public StartWindow()
        {
            InitializeComponent();
			//DataContext = new StartWindowViewModel();

			listInt.Add(0);	
			listInt.Add(1);	
			listInt.Add(2);	
			listInt.Add(3);	
			listInt.Add(4);

			stack.Push (0);
			stack.Push (1);
			stack.Push (2);
			stack.Push (3);

			user.Add(new User() { Id = 0, Name = "qqqq", Email = "qwe@mail.ru", Password="123"});
			user.Add(new User() { Id = 1, Name = "2222", Email = "qwe@mail.ru", Password="123"});
			user.Add(new User() { Id = 2, Name = "www", Email = "qwe@mail.ru", Password="123"});
			user.Add(new User() { Id = 3, Name = "eeee", Email = "qwe@mail.ru", Password= "123" });

			list.ItemsSource = stack;
			View.ItemsSource = user;
			tableGrid.ItemsSource = user;
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

		private void View_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			User objUser = View.SelectedItem as User;
			lab_1.Content = objUser.Id;
			lab_2.Content = objUser.Name;
			lab_3.Content = objUser.Email;
			lab_4.Content = objUser.Password;
		}
	}
}
