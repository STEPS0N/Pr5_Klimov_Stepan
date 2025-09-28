using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5.Classes
{
    public class RepoStudents
    {
        public static List<Student> AllStudent()
        {
            List<Student> allStudent = new List<Student>();
            allStudent.Add(new Student("Болотов", "Евгений", "Олегович", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Григорьев", "Роман", "Владимирович", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Гудков", "Георгий", "Константинович", false, 3, "/Images/incognito.png"));
            allStudent.Add(new Student("Исипова", "Алёна", "Александровна", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Мутин", "Павел", "Алексеевич", false, 3, "/Images/incognito.png"));
            allStudent.Add(new Student("Ишимов", "Виктор", "Алексеевич", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Калижный", "Артём", "Евгеньевич", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Кусакина", "Полина", "Олеговна", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Лесникова", "Александр", "Дмитриевич", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Лесникова", "Мария", "Михайловна", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Лихачева", "Татьяна", "Яковлевна", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Мокрушина", "Надежда", "Владимировна", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Мутагаров", "Даниил", "Ринатович", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Наряжный", "Данил", "Владислович", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Никонов", "Арсений", "Дмитриевич", false, 3, "/Images/incognito.png"));
            allStudent.Add(new Student("Оборин", "Даниил", "Артёмович", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Посадских", "Дарья", "Андреевна", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Сторожев", "Денис", "Романович", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Суслов", "Егор", "Владимирович", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Токмаков", "Даниил", "Сергеевич", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Тронин", "Александр", "Владиславович", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Халилов", "Дамир", "Ринатович", true, 4, "/Images/incognito.png"));
            allStudent.Add(new Student("Шестаков", "Дмитрий", "Андреевич", true, 4, "/Images/incognito.png"));
            return allStudent;
        }
    }
}
