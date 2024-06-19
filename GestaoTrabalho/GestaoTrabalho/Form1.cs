using System.Windows.Forms;
using System;
using System.Drawing;
using GestaoTrabalho.Classes;
using GestaoTrabalho.Forms;

namespace GestaoTrabalho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Painel_Contrato.Location = new Point(288, 116);
            AddLista(Cmb_Funcionario, Contrato.Tercerizado, Contrato.Contrato, Contrato.Nenhum);
            Cmb_Funcionario.DropDownStyle = ComboBoxStyle.DropDownList;
            maskData.Click += new EventHandler(maskedTextBox1_Click);


            // Armazena o último item em uma variável
            var ultimoItem = Cmb_Funcionario.Items[Cmb_Funcionario.Items.Count - 1];

            // Remove o último item do ComboBox
            Cmb_Funcionario.Items.RemoveAt(Cmb_Funcionario.Items.Count - 1);

            // Adiciona o último item ao início do ComboBox
            Cmb_Funcionario.Items.Insert(0, ultimoItem);

            Cmb_Funcionario.Sorted = false;

            // Define "Nenhum" como selecionado por padrão
            Cmb_Funcionario.SelectedIndex = Cmb_Funcionario.FindStringExact(Contrato.Nenhum.ToString());
        }


        private void AddLista(ComboBox values, params Contrato[] enumerado)
        {
            for (int i = 0; i < enumerado.Length; i++)
            {

                values.Items.Add(enumerado[i].ToString());
            }

        }

        private void Cmb_Funcionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region If Off
            //if (Cmb_Funcionario.SelectedIndex == 0)
            //{
            //    Painel_Contrato.Visible = false;
            //    Painel_Tercerizado.Visible = false;
            //    btn_Confirmar.Visible = false;
            //    btn_Limpar.Visible = false;
            //}
            //else if (Cmb_Funcionario.SelectedIndex == 1)
            //{

            //    Painel_Contrato.Visible = true;
            //    Painel_Tercerizado.Visible = false;
            //    btn_Confirmar.Visible = true;
            //    btn_Limpar.Visible = true;

            //}
            //else
            //{
            //    Painel_Contrato.Visible = false;
            //    Painel_Tercerizado.Visible = true;
            //    btn_Confirmar.Visible = true;
            //    btn_Limpar.Visible = true;
            //}
            #endregion


            switch (Cmb_Funcionario.SelectedIndex)
            {
                case 0:

                    Painel_Contrato.Visible = false;
                    Painel_Tercerizado.Visible = false;
                    btn_Confirmar.Visible = false;
                    btn_Limpar.Visible = false;
                    break;
                case 1:
                    Painel_Contrato.Visible = false;
                    Painel_Tercerizado.Visible = true;
                    btn_Confirmar.Visible = true;
                    btn_Limpar.Visible = true;
                    break;
                default:
                    Painel_Contrato.Visible = true;
                    Painel_Tercerizado.Visible = false;
                    btn_Confirmar.Visible = true;
                    btn_Limpar.Visible = true;
                    break;
            }

        }

        private void gunaLabel1_MouseHover(object sender, EventArgs e)
        {
            balaoDica.Active = true;
            balaoDica.SetToolTip(gunaAdicional, "Coloque quanto você gastou durante o mes trabalhado");
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            // Define a posição do cursor para 0 

            maskData.SelectionStart = 0;
            maskedTextBox2.SelectionStart = 0;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            Empregado empregado = new Empregado(txtNome, txtCargo, maskData, txtValorhora);
            Resultado resultado = new Resultado();

            resultado.Show();
            resultado.TopLevel = true;



        }
    }


}



enum Contrato : int
{
    Nenhum = 0,
    Contrato = 1,
    Tercerizado = 2

};





