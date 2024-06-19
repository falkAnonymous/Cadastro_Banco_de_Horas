namespace GestaoTrabalho
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Cmb_Funcionario = new System.Windows.Forms.ComboBox();
            this.Painel_Tercerizado = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskData = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorhora = new System.Windows.Forms.TextBox();
            this.gunaAdicional = new Guna.UI.WinForms.GunaLabel();
            this.txtAdicional = new System.Windows.Forms.TextBox();
            this.Painel_Contrato = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.balaoDica = new System.Windows.Forms.ToolTip(this.components);
            this.Painel_Tercerizado.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Painel_Contrato.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cmb_Funcionario
            // 
            this.Cmb_Funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cmb_Funcionario.FormattingEnabled = true;
            this.Cmb_Funcionario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cmb_Funcionario.Location = new System.Drawing.Point(288, 20);
            this.Cmb_Funcionario.Name = "Cmb_Funcionario";
            this.Cmb_Funcionario.Size = new System.Drawing.Size(224, 21);
            this.Cmb_Funcionario.TabIndex = 3;
            this.Cmb_Funcionario.SelectedIndexChanged += new System.EventHandler(this.Cmb_Funcionario_SelectedIndexChanged);
            // 
            // Painel_Tercerizado
            // 
            this.Painel_Tercerizado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Painel_Tercerizado.Controls.Add(this.flowLayoutPanel1);
            this.Painel_Tercerizado.Location = new System.Drawing.Point(288, 122);
            this.Painel_Tercerizado.Name = "Painel_Tercerizado";
            this.Painel_Tercerizado.Size = new System.Drawing.Size(224, 301);
            this.Painel_Tercerizado.TabIndex = 4;
            this.Painel_Tercerizado.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtNome);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtCargo);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.maskData);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtValorhora);
            this.flowLayoutPanel1.Controls.Add(this.gunaAdicional);
            this.flowLayoutPanel1.Controls.Add(this.txtAdicional);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 14);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 257);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Completo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(3, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(188, 20);
            this.txtNome.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(3, 77);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(188, 20);
            this.txtCargo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data Nascimento";
            // 
            // maskData
            // 
            this.maskData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskData.Location = new System.Drawing.Point(3, 127);
            this.maskData.Mask = "00/00/0000";
            this.maskData.Name = "maskData";
            this.maskData.Size = new System.Drawing.Size(188, 22);
            this.maskData.TabIndex = 7;
            this.maskData.ValidatingType = typeof(System.DateTime);
            this.maskData.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor por horas";
            // 
            // txtValorhora
            // 
            this.txtValorhora.Location = new System.Drawing.Point(3, 179);
            this.txtValorhora.Name = "txtValorhora";
            this.txtValorhora.Size = new System.Drawing.Size(188, 20);
            this.txtValorhora.TabIndex = 11;
            // 
            // gunaAdicional
            // 
            this.gunaAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.gunaAdicional.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gunaAdicional.Location = new System.Drawing.Point(3, 202);
            this.gunaAdicional.Name = "gunaAdicional";
            this.gunaAdicional.Size = new System.Drawing.Size(189, 24);
            this.gunaAdicional.TabIndex = 16;
            this.gunaAdicional.Text = "Adicional";
            this.gunaAdicional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaAdicional.MouseHover += new System.EventHandler(this.gunaLabel1_MouseHover);
            // 
            // txtAdicional
            // 
            this.txtAdicional.Location = new System.Drawing.Point(3, 229);
            this.txtAdicional.Name = "txtAdicional";
            this.txtAdicional.Size = new System.Drawing.Size(188, 20);
            this.txtAdicional.TabIndex = 13;
            // 
            // Painel_Contrato
            // 
            this.Painel_Contrato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Painel_Contrato.Controls.Add(this.flowLayoutPanel2);
            this.Painel_Contrato.Location = new System.Drawing.Point(539, 122);
            this.Painel_Contrato.Name = "Painel_Contrato";
            this.Painel_Contrato.Size = new System.Drawing.Size(224, 301);
            this.Painel_Contrato.TabIndex = 6;
            this.Painel_Contrato.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.textBox6);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.textBox7);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.maskedTextBox2);
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.textBox9);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(18, 41);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(192, 213);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nome Completo";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(3, 27);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(188, 20);
            this.textBox6.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cargo";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(3, 77);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(188, 20);
            this.textBox7.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Data Nascimento";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(3, 127);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(188, 22);
            this.maskedTextBox2.TabIndex = 17;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox2.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Valor por horas";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(3, 179);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(188, 20);
            this.textBox9.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Painel_Tercerizado);
            this.panel1.Controls.Add(this.Painel_Contrato);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 589);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Confirmar);
            this.panel3.Controls.Add(this.btn_Limpar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 492);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 97);
            this.panel3.TabIndex = 9;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Confirmar.Font = new System.Drawing.Font("Pacifico", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.Location = new System.Drawing.Point(408, 20);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(114, 35);
            this.btn_Confirmar.TabIndex = 8;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Limpar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Limpar.Font = new System.Drawing.Font("Pacifico", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Location = new System.Drawing.Point(288, 20);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Limpar.Size = new System.Drawing.Size(114, 35);
            this.btn_Limpar.TabIndex = 7;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Cmb_Funcionario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 63);
            this.panel2.TabIndex = 0;
            // 
            // balaoDica
            // 
            this.balaoDica.AutoPopDelay = 5000;
            this.balaoDica.InitialDelay = 2000;
            this.balaoDica.IsBalloon = true;
            this.balaoDica.ReshowDelay = 500;
            this.balaoDica.ShowAlways = true;
            this.balaoDica.ToolTipTitle = "Dica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Painel_Tercerizado.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.Painel_Contrato.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Painel_Tercerizado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorhora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdicional;
        private System.Windows.Forms.TextBox txtCargo;
        protected System.Windows.Forms.ComboBox Cmb_Funcionario;
        private System.Windows.Forms.Panel Painel_Contrato;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaAdicional;
        private System.Windows.Forms.ToolTip balaoDica;
        private System.Windows.Forms.MaskedTextBox maskData;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}

