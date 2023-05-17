namespace CriadorDeClasse
{
    partial class MenuClasseIHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuClasseIHM));
            this.group_caracteristicasClasse = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_modificadorAcesso = new System.Windows.Forms.ComboBox();
            this.tb_nomeClasse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_Asenjo = new System.Windows.Forms.RadioButton();
            this.rb_LuizAntonio = new System.Windows.Forms.RadioButton();
            this.bt_Avancar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.group_caracteristicasClasse.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_caracteristicasClasse
            // 
            this.group_caracteristicasClasse.Controls.Add(this.label5);
            this.group_caracteristicasClasse.Controls.Add(this.cb_modificadorAcesso);
            this.group_caracteristicasClasse.Controls.Add(this.tb_nomeClasse);
            this.group_caracteristicasClasse.Controls.Add(this.label3);
            this.group_caracteristicasClasse.Location = new System.Drawing.Point(30, 59);
            this.group_caracteristicasClasse.Name = "group_caracteristicasClasse";
            this.group_caracteristicasClasse.Size = new System.Drawing.Size(206, 126);
            this.group_caracteristicasClasse.TabIndex = 16;
            this.group_caracteristicasClasse.TabStop = false;
            this.group_caracteristicasClasse.Text = "Características da classe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Modificador de acesso:";
            // 
            // cb_modificadorAcesso
            // 
            this.cb_modificadorAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modificadorAcesso.FormattingEnabled = true;
            this.cb_modificadorAcesso.Items.AddRange(new object[] {
            "public",
            "internal",
            "private",
            "private protected",
            "protected",
            "protected internal"});
            this.cb_modificadorAcesso.Location = new System.Drawing.Point(26, 88);
            this.cb_modificadorAcesso.Name = "cb_modificadorAcesso";
            this.cb_modificadorAcesso.Size = new System.Drawing.Size(141, 21);
            this.cb_modificadorAcesso.TabIndex = 12;
            // 
            // tb_nomeClasse
            // 
            this.tb_nomeClasse.Location = new System.Drawing.Point(26, 43);
            this.tb_nomeClasse.Name = "tb_nomeClasse";
            this.tb_nomeClasse.Size = new System.Drawing.Size(138, 20);
            this.tb_nomeClasse.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Digite o nome da classe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Informações iniciais da classe:";
            // 
            // rb_Asenjo
            // 
            this.rb_Asenjo.AutoSize = true;
            this.rb_Asenjo.Location = new System.Drawing.Point(24, 30);
            this.rb_Asenjo.Name = "rb_Asenjo";
            this.rb_Asenjo.Size = new System.Drawing.Size(57, 17);
            this.rb_Asenjo.TabIndex = 18;
            this.rb_Asenjo.TabStop = true;
            this.rb_Asenjo.Text = "Asenjo";
            this.rb_Asenjo.UseVisualStyleBackColor = true;
            // 
            // rb_LuizAntonio
            // 
            this.rb_LuizAntonio.AutoSize = true;
            this.rb_LuizAntonio.Location = new System.Drawing.Point(97, 30);
            this.rb_LuizAntonio.Name = "rb_LuizAntonio";
            this.rb_LuizAntonio.Size = new System.Drawing.Size(83, 17);
            this.rb_LuizAntonio.TabIndex = 19;
            this.rb_LuizAntonio.TabStop = true;
            this.rb_LuizAntonio.Text = "Luiz Antonio";
            this.rb_LuizAntonio.UseVisualStyleBackColor = true;
            // 
            // bt_Avancar
            // 
            this.bt_Avancar.Location = new System.Drawing.Point(56, 270);
            this.bt_Avancar.Name = "bt_Avancar";
            this.bt_Avancar.Size = new System.Drawing.Size(148, 27);
            this.bt_Avancar.TabIndex = 21;
            this.bt_Avancar.Text = "Avançar";
            this.bt_Avancar.UseVisualStyleBackColor = true;
            this.bt_Avancar.Click += new System.EventHandler(this.bt_Avancar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Asenjo);
            this.groupBox1.Controls.Add(this.rb_LuizAntonio);
            this.groupBox1.Location = new System.Drawing.Point(30, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 62);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o padrão dos getters e setters:";
            // 
            // MenuClasseIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_Avancar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.group_caracteristicasClasse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuClasseIHM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criador de classes";
            this.group_caracteristicasClasse.ResumeLayout(false);
            this.group_caracteristicasClasse.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_caracteristicasClasse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_modificadorAcesso;
        private System.Windows.Forms.TextBox tb_nomeClasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Avancar;
        public System.Windows.Forms.RadioButton rb_Asenjo;
        public System.Windows.Forms.RadioButton rb_LuizAntonio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}