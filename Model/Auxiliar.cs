using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeVendasForm.Model
{
    class Auxiliar
    {
        public void LimparTela(Form tela)
        {
            foreach(Control controleTotal in tela.Controls) //percorre todos os controles
            {
                foreach (Control controle1 in controleTotal.Controls ) //verifica se existe um controle TabPage dentro do controle total
                {
                    if(controle1 is TabPage)
                    {
                        foreach(Control controle2 in controle1.Controls) //percorra todos os controles do TabPage
                        {
                            if(controle2 is TextBox) //verifique quais controles são TextBox
                            {
                                //limpar o nome de texto
                                (controle2 as TextBox).Text = string.Empty;
                            }
                            if (controle2 is MaskedTextBox) //verifique quais controles são TextBox
                            {
                                //limpar o nome de texto
                                (controle2 as MaskedTextBox).Text = string.Empty;
                            }
                            if (controle2 is ComboBox) //verifique quais controles são TextBox
                            {
                                //limpar o nome de texto
                                (controle2 as ComboBox).Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }
    }
}
