using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DLL_APP_TEST
{
    public class Class1
    {


        public static int n = 0;
        public static int[,] Results = new int[18, 1];


        public int Vopros2(CheckBox CB1, CheckBox CB2, CheckBox CB3)
        {
            if ((!CB1.Checked) && (!CB2.Checked) && (!CB3.Checked))
            {
                MessageBox.Show("Вы не выбрали ни один вариант ответа", "Нет ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if ((CB1.Checked) && (CB2.Checked) && (!CB3.Checked))
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[1, 0] = 1;

                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[1, 0] = 0;
                return 0;
            }
        }
        public static int Vopros1(RadioButton CB1, RadioButton CB2, RadioButton CB3)
        {
            if ((!CB1.Checked) && (!CB2.Checked) && (!CB3.Checked))
            {
                MessageBox.Show("Вы не выбрали ни один вариант ответа", "Нет ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if ((!CB1.Checked) && (CB2.Checked) && (!CB3.Checked))
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[0, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[0, 0] = 0;
                return 0;
            }
        }
        public static int Vopros3(RadioButton CB1, RadioButton CB2, RadioButton CB3)
        {
            if ((!CB1.Checked) && (!CB2.Checked) && (!CB3.Checked))
            {
                MessageBox.Show("Вы не выбрали ни один вариант ответа", "Нет ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if ((CB1.Checked) && (!CB2.Checked) && (!CB3.Checked))
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[2, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[2, 0] = 0;
                return 0;
            }
        }

        public static int Vopros4(CheckBox CB1, CheckBox CB2, CheckBox CB3)
        {
            if ((!CB1.Checked) && (!CB2.Checked) && (!CB3.Checked))
            {
                MessageBox.Show("Вы не выбрали ни один вариант ответа", "Нет ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if ((CB1.Checked) && (CB2.Checked) && (!CB3.Checked))
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[3, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[3, 0] = 0;
                return 0;
            }
        }


        public static int Vopros5(string right_ans, string ans)
        {
            if (ans == "")
            {
                MessageBox.Show("Вы не ввели ответ", "Отсутствие ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
                if (ans == right_ans)
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[4, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[4, 0] = 0;
                return 0;
            }
        }


        public static int Vopros6(string right_ans, string ans)
        {
            if (ans == "")
            {
                MessageBox.Show("Вы не ввели ответ", "Отсутствие ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
                if (ans == right_ans)
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[5, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[5, 0] = 0;
                return 0;
            }
        }

        public static int Vopros7(ComboBox CB1, ComboBox CB2)
        {
            if (CB1.SelectedIndex == -1 && CB2.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не ввели ответ", "Отсутствие ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
                    if ((CB1.SelectedIndex == 0 && CB2.SelectedIndex == 3) | (CB2.SelectedIndex == 0 && CB1.SelectedIndex == 3))
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[6, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[6, 0] = 0;
                return 0;
            }
        }

        public static int Vopros8(ComboBox CB1, ComboBox CB2)
        {
            if (CB1.SelectedIndex == -1 && CB2.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не ввели ответ", "Отсутствие ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
                    if ((CB1.SelectedIndex == 0 && CB2.SelectedIndex == 1) | (CB2.SelectedIndex == 0 && CB1.SelectedIndex == 1))
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[7, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[7, 0] = 0;
                return 0;
            }
        }


        public static void Vopros9_b1(ListBox L1, TextBox T1)
        {
            if (L1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали ни один вариант ответа", "Нет ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (L1.SelectedIndex != -1)
            {
                string selected = L1.SelectedItem.ToString();
                T1.Text = selected;
            }
        }
        public static int Vopros9(string right_ans, string right_ans1, string right_ans2, string ans, string ans1, string ans2)
        {
            if (ans == "")
            {
                MessageBox.Show("Вы не ввели ответ", "Отсутствие ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
                if (ans == right_ans && ans1 == right_ans1 && ans2 == right_ans2)
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[8, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[8, 0] = 0;
                return 0;
            }
        }


        public static void Vopros10_b1(ListBox L1, TextBox T1)
        {
            if (L1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали ни один вариант ответа", "Нет ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (L1.SelectedIndex != -1)
            {
                string selected = L1.SelectedItem.ToString();
                T1.Text = selected;
            }
        }
        public static int Vopros10(string right_ans, string right_ans1, string right_ans2, string ans, string ans1, string ans2)
        {
            if (ans == "")
            {
                MessageBox.Show("Вы не ввели ответ", "Отсутствие ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
                if (ans == right_ans && ans1 == right_ans1 && ans2 == right_ans2)
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[9, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[9, 0] = 0;
                return 0;
            }
        }

        public static int Vopros11(HScrollBar HSB)
        {
            if (HSB.Value == 200)
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[10, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[10, 0] = 0;
                return 0;
            }
        }


        public static int Vopros12(CheckedListBox CLB)
        {
            if (CLB.SelectedIndex == null)
            {
                MessageBox.Show("Вы не выбрали ни один вариант ответа", "Нет ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (CLB.SelectedIndex == 1)
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[11, 0] = 1; ;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[11, 0] = 0;
                return 0;
            }
        }

        public static int Vopros13(TrackBar t)
        {
            if (t.Value == 2)
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[12, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[12, 0] = 0;
                return 0;
            }
        }
        public static int Vopros14(TrackBar t)
        {
            if (t.Value == 3)
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[13, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[13, 0] = 0;
                return 0;
            }
        }


        public static int Vopros15(RadioButton CB1, RadioButton CB2, RadioButton CB3)
        {
            if ((!CB1.Checked) && (!CB2.Checked) && (!CB3.Checked))
            {
                MessageBox.Show("Вы не выбрали ни один вариант ответа", "Нет ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if ((!CB1.Checked) && (!CB2.Checked) && (CB3.Checked))
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[14, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[14, 0] = 0;
                return 0;
            }
        }


        public static int Vopros16(RadioButton CB1, RadioButton CB2, RadioButton CB3)
        {
            if ((!CB1.Checked) && (!CB2.Checked) && (!CB3.Checked))
            {
                MessageBox.Show("Вы не выбрали ни один вариант ответа", "Нет ответа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if ((!CB1.Checked) && (!CB2.Checked) && (CB3.Checked))
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[15, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[15, 0] = 0;
                return 0;
            }
        }



        public static int Vopros17(NumericUpDown NUD)
        {
            int rans = 30;
            if (NUD.Value == 0)
            {
                MessageBox.Show("Вы не выбрали ни один вариант ответа", "Нет ответа",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (NUD.Value == rans)
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[16, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[16, 0] = 0;
                return 0;
            }
        }

        public static int Vopros18(DomainUpDown DOM)
        {
            string rans = "Сортировка выбором";
            if (DOM.Text == "")
            {
                MessageBox.Show("Вы не выбрали ни один вариант ответа", "Нет ответа",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (DOM.Text == rans)
            {
                MessageBox.Show("Вы ответили верно", "Верный ответ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                n += 1;
                Results[17, 0] = 1;
                return 1;
            }
            else
            {
                MessageBox.Show("Ваш ответ неверный", "Неправильный ответ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Results[17, 0] = 0;
                return 0;
            }
        }






    }
}


