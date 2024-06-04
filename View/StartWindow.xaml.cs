using LearnWPF_SV.Model;
using LearnWPF_SV.ViewModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LearnWPF_SV.View
{
    public partial class StartWindow : Window, INotifyPropertyChanged
    {
		Stack<int> stack = new Stack<int> ();
		ObservableCollection<int> listInt = new ObservableCollection<int>();

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

		private string str = null;
        public string Str { get
			{
				return str;
			}
			set
			{
				str = value;
				OnPropertyChanged(nameof(Str));
			}
		}
		
        ObservableCollection<User> users { get; set; } = new ObservableCollection<User>();
		User SelectedUser { get; set; } = null;

        object Select { get; set; }


		public StartWindow()
        {
            InitializeComponent();
			inish();
			
			
			ViewUser.ItemsSource = users;

			list.ItemsSource = stack;
			View.ItemsSource = users;
			tableGrid.ItemsSource = users;
			MyLable.Content = "qweqweqwe";
        }

		public void Copu(object sender, RoutedEventArgs e)
		{
            string str = box.Text;

            lab.Content = str;  

		}

		public void CheckBox_Checked(object sender, RoutedEventArgs e)
		{
            chek2.IsChecked = true;
		}
		public void RadioButton(object	 sender, RoutedEventArgs e)
		{
			RadioButton pressed = sender as RadioButton;
			MessageBox.Show(pressed.Content.ToString());
		}

		public void View_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			User objUser = View.SelectedItem as User;
			lab_1.Content = objUser.Id;
			lab_2.Content = objUser.Name;
			lab_3.Content = objUser.Email;
			lab_4.Content = objUser.Password;
		}
		public void inish()
		{
            listInt.Add(0);
            listInt.Add(1);
            listInt.Add(2);
            listInt.Add(3);
            listInt.Add(4);

            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            users.Add(new User() { Id = 0, Name = "qqqq", Email = "qwe@mail.ru", Password = "123" });
            users.Add(new User() { Id = 1, Name = "2222", Email = "qwe@mail.ru", Password = "123" });
            users.Add(new User() { Id = 2, Name = "www", Email = "qwe@mail.ru", Password = "123" });
            users.Add(new User() { Id = 3, Name = "eeee", Email = "qwe@mail.ru", Password = "123" });
        }

        public void AddUser(object sender, RoutedEventArgs e)
        {
			User user = new User()
			{
				Id = users.Count + 1,
				Name = inName.Text,
				Email = inEmail.Text,
				Password = inPass.Text,
			};

			users.Add(user);
        }

        private void EditUser(object sender, RoutedEventArgs e)
        {
			User user = users.FirstOrDefault(q => q.Id == SelectedUser.Id);
			if (user != null)
			{
				users.Add(new User() 
				{ 
					Id = SelectedUser.Id,
					Name = inName.Text,
					Email = inEmail.Text,
					Password = inPass.Text,
				}
				);
				users.Remove(user);
			}
        }

        private void delitUser(object sender, RoutedEventArgs e)
        {
            User user = users.FirstOrDefault(q => q.Id == SelectedUser.Id);
            users.Remove(user);
        }

        public void selectUsertoView(object sender, SelectionChangedEventArgs e)
        {
			User user = ViewUser.SelectedItem as User;
			if(user != null)
				{
				inName.Text = user.Name;
				inPass.Text = user.Password;
				inEmail.Text = user.Email;
			}
			SelectedUser = ViewUser.SelectedItem as User;
        }
    }
}
