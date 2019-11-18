namespace FlotteSoft.MODEL
{
    partial class CadVeiculos
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
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gp2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbLeves = new System.Windows.Forms.RadioButton();
            this.rbMotos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbArSim = new System.Windows.Forms.RadioButton();
            this.rbArNao = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbVeicSim = new System.Windows.Forms.RadioButton();
            this.rbVeicNao = new System.Windows.Forms.RadioButton();
            this.gp2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(423, 32);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(50, 20);
            this.txtAno.TabIndex = 2;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(126)))));
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("SF Sports Night NS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btCadastrar.Location = new System.Drawing.Point(267, 447);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(183, 56);
            this.btCadastrar.TabIndex = 14;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "MARCA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(376, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ANO:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(98, 32);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(257, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(101)))));
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "MODELO:";
            // 
            // gp2
            // 
            this.gp2.Controls.Add(this.label3);
            this.gp2.Controls.Add(this.txtValorDiaria);
            this.gp2.Controls.Add(this.txtModelo);
            this.gp2.Controls.Add(this.label2);
            this.gp2.Controls.Add(this.txtAno);
            this.gp2.Controls.Add(this.label1);
            this.gp2.Controls.Add(this.label4);
            this.gp2.Controls.Add(this.txtMarca);
            this.gp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(101)))));
            this.gp2.Location = new System.Drawing.Point(35, 142);
            this.gp2.Name = "gp2";
            this.gp2.Size = new System.Drawing.Size(655, 189);
            this.gp2.TabIndex = 15;
            this.gp2.TabStop = false;
            this.gp2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(101)))));
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "VALOR DIARIA:";
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(147, 144);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(161, 20);
            this.txtValorDiaria.TabIndex = 14;
            this.txtValorDiaria.TextChanged += new System.EventHandler(this.txtValorDiaria_TextChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(98, 69);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(428, 20);
            this.txtModelo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Sports Night NS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.label6.Location = new System.Drawing.Point(32, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "CADASTRO DE VEICULOS";
            // 
            // rbLeves
            // 
            this.rbLeves.AutoSize = true;
            this.rbLeves.ForeColor = System.Drawing.Color.Cyan;
            this.rbLeves.Location = new System.Drawing.Point(6, 37);
            this.rbLeves.Name = "rbLeves";
            this.rbLeves.Size = new System.Drawing.Size(61, 24);
            this.rbLeves.TabIndex = 18;
            this.rbLeves.TabStop = true;
            this.rbLeves.Text = "Carro";
            this.rbLeves.UseVisualStyleBackColor = true;
            this.rbLeves.CheckedChanged += new System.EventHandler(this.rbLeves_CheckedChanged);
            // 
            // rbMotos
            // 
            this.rbMotos.AutoSize = true;
            this.rbMotos.ForeColor = System.Drawing.Color.Cyan;
            this.rbMotos.Location = new System.Drawing.Point(136, 37);
            this.rbMotos.Name = "rbMotos";
            this.rbMotos.Size = new System.Drawing.Size(58, 24);
            this.rbMotos.TabIndex = 19;
            this.rbMotos.TabStop = true;
            this.rbMotos.Text = "Moto";
            this.rbMotos.UseVisualStyleBackColor = true;
            this.rbMotos.CheckedChanged += new System.EventHandler(this.rbMotos_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbLeves);
            this.groupBox2.Controls.Add(this.rbMotos);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(101)))));
            this.groupBox2.Location = new System.Drawing.Point(35, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 86);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SELECIONE O TIPO DO VEICULO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbArSim);
            this.groupBox3.Controls.Add(this.rbArNao);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(101)))));
            this.groupBox3.Location = new System.Drawing.Point(35, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 86);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AR CONDICIONADO ?";
            // 
            // rbArSim
            // 
            this.rbArSim.AutoSize = true;
            this.rbArSim.Checked = true;
            this.rbArSim.ForeColor = System.Drawing.Color.Cyan;
            this.rbArSim.Location = new System.Drawing.Point(6, 37);
            this.rbArSim.Name = "rbArSim";
            this.rbArSim.Size = new System.Drawing.Size(50, 24);
            this.rbArSim.TabIndex = 18;
            this.rbArSim.TabStop = true;
            this.rbArSim.Text = "Sim";
            this.rbArSim.UseVisualStyleBackColor = true;
            this.rbArSim.CheckedChanged += new System.EventHandler(this.rbArSim_CheckedChanged);
            // 
            // rbArNao
            // 
            this.rbArNao.AutoSize = true;
            this.rbArNao.ForeColor = System.Drawing.Color.Cyan;
            this.rbArNao.Location = new System.Drawing.Point(98, 37);
            this.rbArNao.Name = "rbArNao";
            this.rbArNao.Size = new System.Drawing.Size(51, 24);
            this.rbArNao.TabIndex = 19;
            this.rbArNao.Text = "Não";
            this.rbArNao.UseVisualStyleBackColor = true;
            this.rbArNao.CheckedChanged += new System.EventHandler(this.rbArNao_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbVeicSim);
            this.groupBox4.Controls.Add(this.rbVeicNao);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(101)))));
            this.groupBox4.Location = new System.Drawing.Point(249, 337);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 86);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "VEICULO DO CLIENTE ?";
            // 
            // rbVeicSim
            // 
            this.rbVeicSim.AutoSize = true;
            this.rbVeicSim.Checked = true;
            this.rbVeicSim.ForeColor = System.Drawing.Color.Cyan;
            this.rbVeicSim.Location = new System.Drawing.Point(6, 37);
            this.rbVeicSim.Name = "rbVeicSim";
            this.rbVeicSim.Size = new System.Drawing.Size(50, 24);
            this.rbVeicSim.TabIndex = 18;
            this.rbVeicSim.TabStop = true;
            this.rbVeicSim.Text = "Sim";
            this.rbVeicSim.UseVisualStyleBackColor = true;
            this.rbVeicSim.CheckedChanged += new System.EventHandler(this.rbVeicSim_CheckedChanged);
            // 
            // rbVeicNao
            // 
            this.rbVeicNao.AutoSize = true;
            this.rbVeicNao.ForeColor = System.Drawing.Color.Cyan;
            this.rbVeicNao.Location = new System.Drawing.Point(98, 37);
            this.rbVeicNao.Name = "rbVeicNao";
            this.rbVeicNao.Size = new System.Drawing.Size(51, 24);
            this.rbVeicNao.TabIndex = 19;
            this.rbVeicNao.Text = "Não";
            this.rbVeicNao.UseVisualStyleBackColor = true;
            this.rbVeicNao.CheckedChanged += new System.EventHandler(this.rbVeicNao_CheckedChanged);
            // 
            // CadVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(722, 515);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.gp2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CadVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Veiculos";
            this.gp2.ResumeLayout(false);
            this.gp2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gp2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.RadioButton rbLeves;
        private System.Windows.Forms.RadioButton rbMotos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbArSim;
        private System.Windows.Forms.RadioButton rbArNao;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbVeicSim;
        private System.Windows.Forms.RadioButton rbVeicNao;
    }
}