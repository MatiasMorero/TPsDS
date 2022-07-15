using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PobreTITO
{
    internal class Validaciones
    {
        public void validarLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) // Si la tecla que presiono es letra
            {
                e.Handled = false; // Se la permito
            }
            else if (char.IsSeparator(e.KeyChar)) // Si la tecla que presiono es un espacio
            {
                e.Handled = false; // Se la permito
            }
            else if (char.IsControl(e.KeyChar)) // Si la tecla que presiono es un caracter de control
            {
                e.Handled = false; // Se la permito
            }
            else // Cualquier otra
            {
                e.Handled = true; // No se la permito
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void validarNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else 
            {
                e.Handled = true; 
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void validarNumerosFecha(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == "/")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void validarLetrasNumeros(KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar)) 
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
