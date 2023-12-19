using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecoprod.Helpers;

internal class StringFormatter
{
    static public bool Check(string field, string input, int max)
    {
        if (input.Length == 0)
        {
            MessageBox.Show($"Поле {field} не должно быть пустым");
            return false;
        }

        if (input.Length > max)
        {
            MessageBox.Show($"Поле {field} не должно быть больше {max} символов");
            return false;
        }

        return true;
    }
}

