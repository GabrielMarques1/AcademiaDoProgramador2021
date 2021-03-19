
namespace WindowsFormsApp1
{
    partial class Chamado
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
            this.txtID1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxEquipamentos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskDataAbertura = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar1 = new System.Windows.Forms.Button();
            this.btnDeletar1 = new System.Windows.Forms.Button();
            this.btnAtualizar1 = new System.Windows.Forms.Button();
            this.btnInserir1 = new System.Windows.Forms.Button();
            this.dgvChamado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID1
            // 
            this.txtID1.Location = new System.Drawing.Point(109, 27);
            this.txtID1.Name = "txtID1";
            this.txtID1.Size = new System.Drawing.Size(281, 20);
            this.txtID1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(109, 53);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(281, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Título:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(109, 79);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(281, 44);
            this.txtDescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Equipamentos:";
            // 
            // cBoxEquipamentos
            // 
            this.cBoxEquipamentos.FormattingEnabled = true;
            this.cBoxEquipamentos.Location = new System.Drawing.Point(109, 129);
            this.cBoxEquipamentos.Name = "cBoxEquipamentos";
            this.cBoxEquipamentos.Size = new System.Drawing.Size(281, 21);
            this.cBoxEquipamentos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 39;
            this.label4.Text = "Data de\r\nAbertura:\r\n";
            // 
            // mskDataAbertura
            // 
            this.mskDataAbertura.Location = new System.Drawing.Point(109, 168);
            this.mskDataAbertura.Mask = "00/00/0000";
            this.mskDataAbertura.Name = "mskDataAbertura";
            this.mskDataAbertura.Size = new System.Drawing.Size(281, 20);
            this.mskDataAbertura.TabIndex = 4;
            this.mskDataAbertura.ValidatingType = typeof(System.DateTime);
            // 
            // btnPesquisar1
            // 
            this.btnPesquisar1.BackColor = System.Drawing.Color.SlateBlue;
            this.btnPesquisar1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar1.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar1.Location = new System.Drawing.Point(288, 199);
            this.btnPesquisar1.Name = "btnPesquisar1";
            this.btnPesquisar1.Size = new System.Drawing.Size(192, 29);
            this.btnPesquisar1.TabIndex = 8;
            this.btnPesquisar1.Text = "Pesquisar por ID/Refresh";
            this.btnPesquisar1.UseVisualStyleBackColor = false;
            this.btnPesquisar1.Click += new System.EventHandler(this.btnPesquisar1_Click);
            // 
            // btnDeletar1
            // 
            this.btnDeletar1.BackColor = System.Drawing.Color.Orange;
            this.btnDeletar1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar1.ForeColor = System.Drawing.Color.White;
            this.btnDeletar1.Location = new System.Drawing.Point(173, 199);
            this.btnDeletar1.Name = "btnDeletar1";
            this.btnDeletar1.Size = new System.Drawing.Size(109, 29);
            this.btnDeletar1.TabIndex = 7;
            this.btnDeletar1.Text = "Deletar por ID";
            this.btnDeletar1.UseVisualStyleBackColor = false;
            this.btnDeletar1.Click += new System.EventHandler(this.btnDeletar1_Click);
            // 
            // btnAtualizar1
            // 
            this.btnAtualizar1.BackColor = System.Drawing.Color.Tomato;
            this.btnAtualizar1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar1.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar1.Location = new System.Drawing.Point(92, 199);
            this.btnAtualizar1.Name = "btnAtualizar1";
            this.btnAtualizar1.Size = new System.Drawing.Size(76, 29);
            this.btnAtualizar1.TabIndex = 6;
            this.btnAtualizar1.Text = "Atualizar";
            this.btnAtualizar1.UseVisualStyleBackColor = false;
            this.btnAtualizar1.Click += new System.EventHandler(this.btnAtualizar1_Click);
            // 
            // btnInserir1
            // 
            this.btnInserir1.BackColor = System.Drawing.Color.YellowGreen;
            this.btnInserir1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir1.ForeColor = System.Drawing.Color.White;
            this.btnInserir1.Location = new System.Drawing.Point(12, 199);
            this.btnInserir1.Name = "btnInserir1";
            this.btnInserir1.Size = new System.Drawing.Size(74, 29);
            this.btnInserir1.TabIndex = 5;
            this.btnInserir1.Text = "Inserir";
            this.btnInserir1.UseVisualStyleBackColor = false;
            this.btnInserir1.Click += new System.EventHandler(this.btnInserir1_Click);
            // 
            // dgvChamado
            // 
            this.dgvChamado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChamado.Location = new System.Drawing.Point(17, 234);
            this.dgvChamado.MultiSelect = false;
            this.dgvChamado.Name = "dgvChamado";
            this.dgvChamado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamado.Size = new System.Drawing.Size(442, 150);
            this.dgvChamado.TabIndex = 9;
            // 
            // Chamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 393);
            this.Controls.Add(this.dgvChamado);
            this.Controls.Add(this.btnPesquisar1);
            this.Controls.Add(this.btnDeletar1);
            this.Controls.Add(this.btnAtualizar1);
            this.Controls.Add(this.btnInserir1);
            this.Controls.Add(this.mskDataAbertura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxEquipamentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID1);
            this.Controls.Add(this.label6);
            this.Name = "Chamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chamadas";
            this.Load += new System.EventHandler(this.Chamado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Chamado_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxEquipamentos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskDataAbertura;
        private System.Windows.Forms.Button btnPesquisar1;
        private System.Windows.Forms.Button btnDeletar1;
        private System.Windows.Forms.Button btnAtualizar1;
        private System.Windows.Forms.Button btnInserir1;
        private System.Windows.Forms.DataGridView dgvChamado;
    }
}