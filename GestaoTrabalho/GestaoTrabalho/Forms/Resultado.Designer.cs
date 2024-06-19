namespace GestaoTrabalho.Forms
{
    partial class Resultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bdCadastroTrabalhador = new System.Windows.Forms.DataGridView();
            this.Tnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tcargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tdatanascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tvalorhora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tadicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroTrabalhador)).BeginInit();
            this.SuspendLayout();
            // 
            // bdCadastroTrabalhador
            // 
            this.bdCadastroTrabalhador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdCadastroTrabalhador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bdCadastroTrabalhador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdCadastroTrabalhador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tnome,
            this.Tcargo,
            this.Tdatanascimento,
            this.Tvalorhora,
            this.Tadicional,
            this.ValorTotal});
            this.bdCadastroTrabalhador.Location = new System.Drawing.Point(12, 12);
            this.bdCadastroTrabalhador.Name = "bdCadastroTrabalhador";
            this.bdCadastroTrabalhador.Size = new System.Drawing.Size(485, 373);
            this.bdCadastroTrabalhador.TabIndex = 0;
            // 
            // Tnome
            // 
            this.Tnome.HeaderText = "Nome";
            this.Tnome.Name = "Tnome";
            this.Tnome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tcargo
            // 
            this.Tcargo.HeaderText = "Cargo";
            this.Tcargo.Name = "Tcargo";
            this.Tcargo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tdatanascimento
            // 
            this.Tdatanascimento.HeaderText = "Data Nascimento";
            this.Tdatanascimento.Name = "Tdatanascimento";
            this.Tdatanascimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tvalorhora
            // 
            this.Tvalorhora.HeaderText = "Valor por Horas";
            this.Tvalorhora.Name = "Tvalorhora";
            this.Tvalorhora.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tadicional
            // 
            this.Tadicional.HeaderText = "Adicinal";
            this.Tadicional.Name = "Tadicional";
            this.Tadicional.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(509, 397);
            this.Controls.Add(this.bdCadastroTrabalhador);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Resultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroTrabalhador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bdCadastroTrabalhador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tcargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tdatanascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tvalorhora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tadicional;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
    }
}