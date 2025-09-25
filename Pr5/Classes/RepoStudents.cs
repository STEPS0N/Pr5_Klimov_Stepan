using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5.Classes
{
    public class RepoStudents
    {
        public static List<Student> AllStudent(){
            List<Student> allStudent = new List<Student>();
            allStudent.Add(new Student("Болотов", "Евгений", "Олегович"));
            allStudent.Add(new Student("Григорьев", "Роман", "Владимирович"));
            allStudent.Add(new Student("Гудков", "Георгий", "Константинович", false, 3));
            allStudent.Add(new Student("Исипова", "Алёна", "Александровна", true));
            allStudent.Add(new Student("Мутин", "Павел", "Алексеевич", false, 3));
            allStudent.Add(new Student("Ишимов", "Виктор", "Алексеевич"));
            allStudent.Add(new Student("Калижный", "Артём", "Евгеньевич"));
            allStudent.Add(new Student("Кусакина", "Полина", "Олеговна", true));
            allStudent.Add(new Student("Лесникова", "Александр", "Дмитриевич"));
            allStudent.Add(new Student("Лесникова", "Мария", "Михайловна", true));
            allStudent.Add(new Student("Лихачева", "Татьяна", "Яковлевна"));
            allStudent.Add(new Student("Мокрушина", "Надежда", "Владимировна", true));
            allStudent.Add(new Student("Мутагаров", "Даниил", "Ринатович"));
            allStudent.Add(new Student("Наряжный", "Данил", "Владислович"));
            allStudent.Add(new Student("Никонов", "Арсений", "Дмитриевич", false, 3));
            allStudent.Add(new Student("Оборин", "Даниил", "Артёмович"));
            allStudent.Add(new Student("Посадских", "Дарья", "Андреевна"));
            allStudent.Add(new Student("Сторожев", "Денис", "Романович", true));
            allStudent.Add(new Student("Суслов", "Егор", "Владимирович"));
            allStudent.Add(new Student("Токмаков", "Даниил", "Сергеевич", true));
            allStudent.Add(new Student("Тронин", "Александр", "Владиславович"));
            allStudent.Add(new Student("Халилов", "Дамир", "Ринатович"));
            allStudent.Add(new Student("Шестаков", "Дмитрий", "Андреевич"));
            return allStudent;
        }
    }
}
