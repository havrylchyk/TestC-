using System.Windows.Forms;

namespace Formationofgroups.UI
{
    public partial class Form1 : Form
    {
        public void FillGroupDataGridView()
        {
            GroupDataGridView.ColumnCount = 2;//Створюємо 4 колонки в таблиці
            GroupDataGridView.Columns[0].HeaderText = "Назва";//Даємо їм назви
            GroupDataGridView.Columns[1].HeaderText = "Рік навчання";

            foreach (var group in groupService.GroupList)//Цмкл для виводу даних з списку
            {
                string[] data = {
                    group.Name.ToString(),
                    group.YearOfStudy.ToString(),//Оскільки метод ToString ми переписали то використовуємо його
                };
                GroupDataGridView.Rows.Add(data);//Додаємо до рядку дані отримані зі списку
            }
        }

        public void FillStudentDataGridView()
        {
            StudentDataGridView.ColumnCount = 4;//Створюємо 4 колонки в таблиці
            StudentDataGridView.Columns[0].HeaderText = "Ім'я";//Даємо їм назви
            StudentDataGridView.Columns[1].HeaderText = "Прізвище";
            StudentDataGridView.Columns[2].HeaderText = "Рік народження";
            StudentDataGridView.Columns[3].HeaderText = "Група";

            foreach (var student in studentService.StudentList)//Цмкл для виводу даних з списку
            {
                string[] data = {
                    student.FirstName.ToString(),
                    student.SecondName.ToString(),//Оскільки метод ToString ми переписали то використовуємо його
                    student.YearsOfBirth.ToString(),//Оскільки метод ToString ми переписали то використовуємо його
                    student.Group.Name.ToString()//Оскільки метод ToString ми переписали то використовуємо його
                };
                StudentDataGridView.Rows.Add(data);//Додаємо до рядку дані отримані зі списку
            }
        }

        public void FillElectiveCourseDataGridView()
        {
            ElectiveCourseDataGridView.ColumnCount = 4;
            ElectiveCourseDataGridView.Columns[0].HeaderText = "Назва";//Даємо їм назви
            ElectiveCourseDataGridView.Columns[1].HeaderText = "Кількість лекцій";
            ElectiveCourseDataGridView.Columns[2].HeaderText = "Кількість практичних";
            ElectiveCourseDataGridView.Columns[3].HeaderText = "Рік навчання";

            foreach (var electiveCourse in electiveCourseService.CourseList)//Цмкл для виводу даних з списку
            {
                string[] data = {
                    electiveCourse.NameOfCourse.ToString(),
                    electiveCourse.AmountOfLectures.ToString(),//Оскільки метод ToString ми переписали то використовуємо його
                    electiveCourse.AmountOfLessons.ToString(),//Оскільки метод ToString ми переписали то використовуємо його
                    electiveCourse.YearOfStudy.ToString()//Оскільки метод ToString ми переписали то використовуємо його
                };
                ElectiveCourseDataGridView.Rows.Add(data);//Додаємо до рядку дані отримані зі списку
            }
        }
    }
}
