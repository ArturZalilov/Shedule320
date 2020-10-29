using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shedule320
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        string[,] monday = { {"10:20 - 11:15 \n 11:10 - 11:55", "Правовое обеспечение профессиональной деятельности", "Носач А.И."},
            { "12:15 - 13:00 \n 13:05 - 13:50", "Правовое обеспечение профессиональной деятельности", "Носач А.И."},
            { "14:05 - 14:50 \n 14:55 - 15:40", "МДК 01.02 Прикладное программирование", "Исакова В.В." } };
        string[,] tuesday = { {"8:30 - 08:15 \n 09:20 - 10:05", "МДК 01.02 Прикладное программирование", "Исакова В.В." },
            { "10:20 - 11:15 \n 11:10 - 11:55", "МДК 03.03 Документирование и сертификация", "Назарова Н.А." },
            { "12:15 - 13:00 \n 13:05 - 13:50", "МДК 01.02 Прикладное программирование", "Иванов Е.О." },
            { "14:05 - 14:50 \n 14:55 - 15:40", "МДК 01.02 Прикладное программирование", "Иванов Е.О." } };
        string[,] wednesday = { {"8:30 - 08:15 \n 09:20 - 10:05", "Физ-ра", "Кашигина Е.А."},
            { "10:20 - 11:15 \n 11:10 - 11:55", "МДК 01.01 Системное программирование", "Маслов Р.А." },
            { "12:15 - 13:00 \n 13:05 - 13:50", "МДК 01.02 Прикладное программирование", "Иванов Е.О." },
            { "14:05 - 14:50 \n 14:55 - 15:40", "МДК 01.02 Прикладное программирование", "Иванов Е.О." } };
        string[,] thursday_one = { {"8:30 - 08:15 \n 09:20 - 10:05", "МДК 03.01 Технология разработки программного обеспечения", "Исакова В.В."},
            { "10:20 - 11:15 \n 11:10 - 11:55", "МДК 01.02 Прикладное программирование", "Исакова В.В." },
            { "12:15 - 13:00 \n 13:05 - 13:50", "МДК 03.01 Технология разработки программного обеспечения", "Исакова В.В."} };
        string[,] thursday_two = { {"10:20 - 11:15 \n 11:10 - 11:55", "МДК 01.02 Прикладное программирование", "Исакова В.В." },
            { "12:15 - 13:00 \n 13:05 - 13:50", "МДК 03.01 Технология разработки программного обеспечения", "Исакова В.В."},
            { "14:05 - 14:50 \n 14:55 - 15:40", "МДК 01.01 Системное программирование", "Маслов Р.А." } };
        string[,] friday = { {"8:30 - 08:15 \n 09:20 - 10:05", "Англ.яз. \n Нем.яз.", "Захваткина И.А. \n Полканова О.В."},
            { "10:20 - 11:15 \n 11:10 - 11:55", "БЖД", "Каримов Д.Э."} };
        string[,] saturday = { {"14:05 - 14:50 \n 14:55 - 15:40", "МДК 01.02 Прикладное программирование", "Исакова В.В." },
            { "16:00 - 16:45 \n 16:50 - 17:35", "МДК 03.02 Инструментальные средства разработки программного обеспечения", "" } };

        public Page1(string weekday)
        {
            InitializeComponent();

            if (weekday == "monday")
            {
                lbTitle.Text = "Понедельник";
                time1.Text = monday[0, 0];
                time2.Text = monday[1, 0];
                time3.Text = monday[2, 0];
                lesson1.Text = monday[0, 1];
                lesson2.Text = monday[1, 1];
                lesson3.Text = monday[2, 1];
                teacher1.Text = monday[0, 2];
                teacher2.Text = monday[1, 2];
                teacher3.Text = monday[2, 2];
            }
            else if (weekday == "tuesday")
            {
                lbTitle.Text = "Вторник";
                time1.Text = tuesday[0, 0];
                time2.Text = tuesday[1, 0];
                time3.Text = tuesday[2, 0];
                time4.Text = tuesday[3, 0];
                lesson1.Text = tuesday[0, 1];
                lesson2.Text = tuesday[1, 1];
                lesson3.Text = tuesday[2, 1];
                lesson4.Text = tuesday[3, 1];
                teacher1.Text = tuesday[0, 2];
                teacher2.Text = tuesday[1, 2];
                teacher3.Text = tuesday[2, 2];
                teacher4.Text = tuesday[3, 2];
            }
            else if (weekday == "wednesday")
            {
                lbTitle.Text = "Среда";
                time1.Text = wednesday[0, 0];
                time2.Text = wednesday[1, 0];
                time3.Text = wednesday[2, 0];
                time4.Text = wednesday[3, 0];
                lesson1.Text = wednesday[0, 1];
                lesson2.Text = wednesday[1, 1];
                lesson3.Text = wednesday[2, 1];
                lesson4.Text = wednesday[3, 1];
                teacher1.Text = wednesday[0, 2];
                teacher2.Text = wednesday[1, 2];
                teacher3.Text = wednesday[2, 2];
                teacher4.Text = wednesday[3, 2];
            }
            else if (weekday == "thursday_one")
            {
                lbTitle.Text = "Четверг";
                time1.Text = thursday_one[0, 0];
                time2.Text = thursday_one[1, 0];
                time3.Text = thursday_one[2, 0];
                lesson1.Text = thursday_one[0, 1];
                lesson2.Text = thursday_one[1, 1];
                lesson3.Text = thursday_one[2, 1];
                teacher1.Text = thursday_one[0, 2];
                teacher2.Text = thursday_one[1, 2];
                teacher3.Text = thursday_one[2, 2];

            }
            else if (weekday == "thursday_two")
            {
                lbTitle.Text = "Четверг";
                time1.Text = thursday_two[0, 0];
                time2.Text = thursday_two[1, 0];
                time3.Text = thursday_two[2, 0];
                lesson1.Text = thursday_two[0, 1];
                lesson2.Text = thursday_two[1, 1];
                lesson3.Text = thursday_two[2, 1];
                teacher1.Text = thursday_two[0, 2];
                teacher2.Text = thursday_two[1, 2];
                teacher3.Text = thursday_two[2, 2];
            }
            else if (weekday == "friday")
            {
                lbTitle.Text = "Пятница";
                time1.Text = friday[0, 0];
                time2.Text = friday[1, 0];
                lesson1.Text = friday[0, 1];
                lesson2.Text = friday[1, 1];
                teacher1.Text = friday[0, 2];
                teacher2.Text = friday[1, 2];
            }
            else if (weekday == "saturday")
            {
                lbTitle.Text = "Суббота";
                time1.Text = saturday[0, 0];
                time2.Text = saturday[1, 0];
                lesson1.Text = saturday[0, 1];
                lesson2.Text = saturday[1, 1];
                teacher1.Text = saturday[0, 2];
                teacher2.Text = saturday[1, 2];
            }

            
        }
    }
}