using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaClinica
{
    [ToolboxBitmap(typeof(TextBox))]
    public partial class solonumeros :TextBox

    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //solo permitir numeros y teclas de control
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false; //permitir el caracter
            }
            else
            {
                e.Handled = true; //rechazar el caracter
            }
        }
      
    }
}
