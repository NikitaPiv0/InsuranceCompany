using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Страховая_компания__2021_
{
    static public class StringValidation
    {
        public delegate bool validFunc(string str, out string errorMessege, int minValue = 0,
            int maxValue = int.MaxValue, bool isEmpty = true);


        static public bool StringStandard(string str, out string errorMessege, int minValue = 0, 
            int maxValue = int.MaxValue, bool isEmpty = true)
        {
            errorMessege = "";

            if (!isEmpty && string.IsNullOrEmpty(str))
            {
                errorMessege = "Строка не может быть пустой.";
                return false;
            }
            else if (isEmpty && string.IsNullOrEmpty(str))
            {
                return true;
            }

            if (str.Length < minValue)
            {
                errorMessege = "Строка не может быть меньше " + minValue + " символов.";
                return false;
            }
            else if (str.Length > maxValue)
            {
                errorMessege = "Строка не может превышать " + maxValue + " символов.";
                return false;
            }

            return true;
        }

        static public bool StringNumber(string str, out string errorMessege, int minValue = 0,
            int maxValue = int.MaxValue, bool isEmpty = true)
        {
            errorMessege = "";

            if (!isEmpty && string.IsNullOrEmpty(str))
            {
                errorMessege = "Строка не может быть пустой.";
                return false;
            }
            else if (isEmpty && string.IsNullOrEmpty(str))
            {
                return true;
            }

            if (str.Length < minValue)
            {
                errorMessege = "Строка не может быть меньше " + minValue + " символов.";
                return false;
            }
            else if (str.Length > maxValue)
            {
                errorMessege = "Строка не может превышать " + maxValue + " символов.";
                return false;
            }

            for (int i = 0; i < str.Length; i++)
                if (!char.IsDigit(str[i]))
                {
                    errorMessege = "Строка может содержать только цифры.";
                    return false;
                }

            return true;
        }

        static public bool StringEmail(string str, out string errorMessege, int minValue = 0,
            int maxValue = int.MaxValue, bool isEmpty = true)
        {
            errorMessege = "";

            if (!isEmpty && string.IsNullOrEmpty(str))
            {
                errorMessege = "Строка не может быть пустой.";
                return false;
            }
            else if (isEmpty && string.IsNullOrEmpty(str))
            {
                return true;
            }
            
            if (str.Length < minValue)
            {
                errorMessege = "Строка не может быть меньше " + minValue + " символов.";
                return false;
            }
            else if (str.Length > maxValue)
            {
                errorMessege = "Строка не может превышать " + maxValue + " символов.";
                return false;
            }

            if (Regex.IsMatch(str, @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)"))
            {
                return true;
            }
            else
            {
                errorMessege = "email не соответствует шаблону \'ivanov1995@mail.com\'";
                return false;
            }
        }

        static public bool StringMoney(string str, out string errorMessege, int minValue = 0,
            int maxValue = int.MaxValue, bool isEmpty = true)
        {
            errorMessege = "";

            if (!isEmpty && string.IsNullOrEmpty(str))
            {
                errorMessege = "Строка не может быть пустой.";
                return false;
            }
            else if (isEmpty && string.IsNullOrEmpty(str))
            {
                return true;
            }

            decimal temp = 0;
            if (!decimal.TryParse(str, out temp))
            {
                errorMessege = "Неверный формат денежной единицы.";
                return false;
            }

            if (temp < minValue)
            {
                errorMessege = "Величина не может быть меньше " + minValue + ".";
                return false;
            }
            else if (temp > maxValue)
            {
                errorMessege = "Величина не может превышать " + maxValue + ".";
                return false;
            }

            return true;
        }

        static public bool StringCount(string str, out string errorMessege, int minValue = 0,
            int maxValue = int.MaxValue, bool isEmpty = true)
        {
            errorMessege = "";

            if (!isEmpty && string.IsNullOrEmpty(str))
            {
                errorMessege = "Строка не может быть пустой.";
                return false;
            }
            else if (isEmpty && string.IsNullOrEmpty(str))
            {
                return true;
            }

            int temp = 0;
            if (!int.TryParse(str, out temp))
            {
                errorMessege = "Неверный формат численной единицы.";
                return false;
            }

            if (temp < minValue)
            {
                errorMessege = "Величина не может быть меньше " + minValue + ".";
                return false;
            }
            else if (temp > maxValue)
            {
                errorMessege = "Величина не может превышать " + maxValue + ".";
                return false;
            }

            return true;
        }

        static public void ContaierFunction(object sender, CancelEventArgs e, ErrorProvider errorProvider, 
            StringValidation.validFunc vf, int minValue = 0, int maxValue = int.MaxValue, bool isEmpty = true)
        {
            TextBox tempTB = (TextBox)sender;
            string errorMessege = "";
            if (!vf.Invoke(tempTB.Text, out errorMessege, minValue, maxValue, isEmpty))
            {
                e.Cancel = true;
                tempTB.Focus();
                errorProvider.SetError(tempTB, errorMessege);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tempTB, null);
            }
        }
    }
}
