using Pr5.Classes;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pr5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Classes.Student> AllStudent = Classes.RepoStudents.AllStudent();
        public List<Classes.Student> FilteredStudent = new List<Classes.Student>();
        public int Count = 10;
        public int Step = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            FilteredStudent = AllStudent;
            CreateStudent(Step, Count);
        }

        public void CreateStudent(int Step, int Count)
        {
            for (int iStudent = Step; iStudent < Step + Count; iStudent++)
            {
                if (FilteredStudent.Count > iStudent)
                {
                    parent.Children.Add(new Elements.Student(FilteredStudent[iStudent]));
                }
            }
            this.Step += Count;
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scroll = sender as ScrollViewer;
            double ParentHeight = parent.ActualHeight;
            double WindowHeight = scroll.ActualHeight - 20;
            double DeltaHeight = ParentHeight - WindowHeight;
            if (DeltaHeight - scroll.VerticalOffset < 140)
            {
                CreateStudent(Step, Count);
            }
        }

        private void PutList(object sender, RoutedEventArgs e)
        {
            string fio = Input_FIO.Text.Trim();
            string scholarshipText = (Input_scholarship.SelectedItem as ComboBoxItem).Content.ToString();
            string courseText = (Input_course.SelectedItem as ComboBoxItem).Content.ToString();
            string imagePath = Input_ImagePath.Text.Trim();

            if (string.IsNullOrWhiteSpace(fio) || string.IsNullOrWhiteSpace(scholarshipText) || string.IsNullOrWhiteSpace(courseText))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
                return;
            }

            string[] fioParts = fio.Split(' ');
            if (fioParts.Length < 3)

            {
                MessageBox.Show("Введите ФИО в формате: Фамилия Имя Отчество", "Ошибка");
                return;
            }

            string lastname = fioParts[0];
            string firstname = fioParts[1];
            string surname = fioParts[2];

            bool scholarship = scholarshipText == "получает";
            int course = int.Parse(courseText);

            Student newStudent = new Student(firstname, lastname, surname, scholarship, course, imagePath);

            AllStudent.Insert(0, newStudent);
            FilteredStudent = AllStudent;

            parent.Children.Clear();
            Step = 0;
            CreateStudent(Step, Math.Min(Count, FilteredStudent.Count));

            Input_FIO.Text = "";
            Input_scholarship.SelectedIndex = -1;
            Input_course.SelectedIndex = -1;
            Input_ImagePath.Text = "/Images/incognito.png";

            MessageBox.Show("Студент успешно добавлен!", "Успех");
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = SearchBox.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                FilteredStudent = AllStudent;
            }
            else
            {
                FilteredStudent = AllStudent.Where(s => s.GetFIO().ToLower().Contains(searchText)).ToList();
            }

            parent.Children.Clear();
            Step = 0;
            CreateStudent(Step, Math.Min(Count, FilteredStudent.Count));
        }
    }
}