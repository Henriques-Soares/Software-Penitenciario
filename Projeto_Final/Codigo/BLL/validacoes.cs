using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto_Final.Codigo.BLL
{
    public class validacoes
    {
        public void valida_mumero(KeyPressEventArgs e)
        {

            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Só pode digitar Números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        public void validar_letras(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 125)
            {
                MessageBox.Show("Só pode digitar Letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        public bool verifivar_Tl1(String TL1)
        {
            Regex r = new Regex(@"^\(?[1-9]{2}\)??(?:|9[1-9])[0-9]{3}\-?[0-9]{4}$");
            if (!r.IsMatch(TL1))
               
            {
                MessageBox.Show("Numero invalido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
               
            }
            return true;
        }

        public bool verifivar_Tl2(String TL2)
        {
            Regex r = new Regex(@"^\(?[1-9]{2}\)??(?:|9[1-9])[0-9]{3}\-?[0-9]{4}$");

            if (TL2 == "")
            {
                return true;
            }
            if (!r.IsMatch(TL2))
            {

                MessageBox.Show("Numero invalido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
               
            }
            
            
            return true;
        }
        public bool verifica_bi(String bi)
        {
            Regex r = new Regex(@"[0-9]{9}[A-Z]{2}[0-9]{3}");
            if (!r.IsMatch(bi))
            {
                MessageBox.Show("BI Invalido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
              
            }          
            return true;
        }

        public bool verifica_bi_Opcional(String bi)
        {
            Regex r = new Regex(@"[0-9]{9}[A-Z]{2}[0-9]{3}");
            if (bi.ToString() == string.Empty)
            { 
                    if (!r.IsMatch(bi))
                    return true;
            {
                MessageBox.Show("BI Invalido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            }
            return true;
        }


        public bool vaerifica_nip(String nip)
        {
            Regex r = new Regex(@"[0-9]{8}");
            if (!r.IsMatch(nip))
            {
                MessageBox.Show("Nip Invalido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return false;

            }
            return true;
          
        }
        public bool verificar_Altura(String altura)
        {
            Regex r = new Regex(@"[0-2]{1}[,]{1}[0-9]{2}");
            if (!r.IsMatch(altura))
            {
                MessageBox.Show("Altura Invalido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;

            }
            return true;
        }
        public void teclado(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Só pode digitar Números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
       
    }

}
