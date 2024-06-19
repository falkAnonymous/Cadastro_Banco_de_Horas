using System;
using System.Globalization;
using System.Windows.Forms;

namespace GestaoTrabalho.Classes
{
    internal class Empregado
    {
        public string Nome { get; private set; }
        public string Cargo { get; private set; }
        public string Data_Nascimento { get; private set; }
        public int Valor_Hora { get; private set; }


        public Empregado() { }

        public Empregado(TextBox nome, TextBox cargo, MaskedTextBox datanascimento, TextBox valorhora)
        {
            this.Nome = nome.Text;
            this.Cargo = cargo.Text;

            this.Data_Nascimento = datanascimento.Mask = "00/00/0000";
            this.Valor_Hora = int.Parse(valorhora.Text);
        }

        private protected virtual void pagamentos()
        {

        }
    }

}

