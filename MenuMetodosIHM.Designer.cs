namespace CriadorDeClasse
{
    partial class MenuMetodosIHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMetodosIHM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_retornoMetodo = new System.Windows.Forms.ComboBox();
            this.bt_adicionarMetodo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_codigoMetodo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_argumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_static3 = new System.Windows.Forms.CheckBox();
            this.tb_nomeMetodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_modificadorAcesso3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_modificadorAcesso3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_retornoMetodo);
            this.groupBox1.Controls.Add(this.bt_adicionarMetodo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_codigoMetodo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_argumento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_static3);
            this.groupBox1.Controls.Add(this.tb_nomeMetodo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caracteristicas do método";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de retorno do método:";
            // 
            // cb_retornoMetodo
            // 
            this.cb_retornoMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_retornoMetodo.FormattingEnabled = true;
            this.cb_retornoMetodo.Items.AddRange(new object[] {
            "void",
            "int",
            "long",
            "float",
            "double",
            "boolean",
            "string"});
            this.cb_retornoMetodo.Location = new System.Drawing.Point(32, 164);
            this.cb_retornoMetodo.Name = "cb_retornoMetodo";
            this.cb_retornoMetodo.Size = new System.Drawing.Size(136, 21);
            this.cb_retornoMetodo.TabIndex = 11;
            // 
            // bt_adicionarMetodo
            // 
            this.bt_adicionarMetodo.Location = new System.Drawing.Point(153, 439);
            this.bt_adicionarMetodo.Name = "bt_adicionarMetodo";
            this.bt_adicionarMetodo.Size = new System.Drawing.Size(75, 23);
            this.bt_adicionarMetodo.TabIndex = 10;
            this.bt_adicionarMetodo.Text = "Adicionar";
            this.bt_adicionarMetodo.UseVisualStyleBackColor = true;
            this.bt_adicionarMetodo.Click += new System.EventHandler(this.bt_adicionarMetodo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Código:";
            // 
            // tb_codigoMetodo
            // 
            this.tb_codigoMetodo.Location = new System.Drawing.Point(32, 228);
            this.tb_codigoMetodo.Multiline = true;
            this.tb_codigoMetodo.Name = "tb_codigoMetodo";
            this.tb_codigoMetodo.Size = new System.Drawing.Size(307, 193);
            this.tb_codigoMetodo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Argumento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = ")";
            // 
            // tb_argumento
            // 
            this.tb_argumento.Location = new System.Drawing.Point(190, 56);
            this.tb_argumento.Name = "tb_argumento";
            this.tb_argumento.Size = new System.Drawing.Size(119, 20);
            this.tb_argumento.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "(";
            // 
            // cb_static3
            // 
            this.cb_static3.AutoSize = true;
            this.cb_static3.Location = new System.Drawing.Point(190, 108);
            this.cb_static3.Name = "cb_static3";
            this.cb_static3.Size = new System.Drawing.Size(51, 17);
            this.cb_static3.TabIndex = 2;
            this.cb_static3.Text = "static";
            this.cb_static3.UseVisualStyleBackColor = true;
            // 
            // tb_nomeMetodo
            // 
            this.tb_nomeMetodo.Location = new System.Drawing.Point(32, 56);
            this.tb_nomeMetodo.Name = "tb_nomeMetodo";
            this.tb_nomeMetodo.Size = new System.Drawing.Size(136, 20);
            this.tb_nomeMetodo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do método:";
            // 
            // cb_modificadorAcesso3
            // 
            this.cb_modificadorAcesso3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modificadorAcesso3.FormattingEnabled = true;
            this.cb_modificadorAcesso3.Items.AddRange(new object[] {
            "public",
            "internal",
            "private",
            "private protected",
            "protected",
            "protected internal"});
            this.cb_modificadorAcesso3.Location = new System.Drawing.Point(32, 106);
            this.cb_modificadorAcesso3.Name = "cb_modificadorAcesso3";
            this.cb_modificadorAcesso3.Size = new System.Drawing.Size(136, 21);
            this.cb_modificadorAcesso3.TabIndex = 13;
            this.cb_modificadorAcesso3.SelectedIndexChanged += new System.EventHandler(this.cb_modificadorAcesso3_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Modificador de acesso:";
            // 
            // MenuMetodosIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 514);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuMetodosIHM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criador de Classes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_nomeMetodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_static3;
        private System.Windows.Forms.Button bt_adicionarMetodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_codigoMetodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_argumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_retornoMetodo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_modificadorAcesso3;
    }
}