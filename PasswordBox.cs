using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Media;

namespace App
{
    public class PasswordBox : TextBox
{
    // Без этой строки контрол не получает шаблон TextBox и остаётся невидимым
    protected override Type StyleKeyOverride => typeof(TextBox);

    public PasswordBox()
    {
        PasswordChar = '•';
    }

    public string Password
    {
        get => Text ?? string.Empty;
        set => Text = value;
    }
}
}