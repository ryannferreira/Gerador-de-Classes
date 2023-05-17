namespace CriadorDeClasse
{
    partial class MenuPropriedadeIHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPropriedadeIHM));
            this.tb_nomePropriedade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_estruturaClasse = new System.Windows.Forms.ListBox();
            this.cb_static = new System.Windows.Forms.CheckBox();
            this.bt_gerarClasse = new System.Windows.Forms.Button();
            this.cb_tipoPropriedade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.group_caracteristicasPropriedade = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_modificadorAcesso2 = new System.Windows.Forms.ComboBox();
            this.bt_janelaMetodos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.group_caracteristicasPropriedade.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_nomePropriedade
            // 
            this.tb_nomePropriedade.Location = new System.Drawing.Point(29, 48);
            this.tb_nomePropriedade.Name = "tb_nomePropriedade";
            this.tb_nomePropriedade.Size = new System.Drawing.Size(138, 20);
            this.tb_nomePropriedade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da propriedade:";
            // 
            // lb_estruturaClasse
            // 
            this.lb_estruturaClasse.FormattingEnabled = true;
            this.lb_estruturaClasse.Location = new System.Drawing.Point(322, 61);
            this.lb_estruturaClasse.Name = "lb_estruturaClasse";
            this.lb_estruturaClasse.Size = new System.Drawing.Size(238, 251);
            this.lb_estruturaClasse.TabIndex = 0;
            // 
            // cb_static
            // 
            this.cb_static.AutoSize = true;
            this.cb_static.Location = new System.Drawing.Point(29, 124);
            this.cb_static.Name = "cb_static";
            this.cb_static.Size = new System.Drawing.Size(51, 17);
            this.cb_static.TabIndex = 5;
            this.cb_static.Text = "static";
            this.cb_static.UseVisualStyleBackColor = true;
            // 
            // bt_gerarClasse
            // 
            this.bt_gerarClasse.Location = new System.Drawing.Point(382, 327);
            this.bt_gerarClasse.Name = "bt_gerarClasse";
            this.bt_gerarClasse.Size = new System.Drawing.Size(128, 39);
            this.bt_gerarClasse.TabIndex = 7;
            this.bt_gerarClasse.Text = "Gerar classe";
            this.bt_gerarClasse.UseVisualStyleBackColor = true;
            this.bt_gerarClasse.Click += new System.EventHandler(this.bt_gerarClasse_Click);
            // 
            // cb_tipoPropriedade
            // 
            this.cb_tipoPropriedade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipoPropriedade.FormattingEnabled = true;
            this.cb_tipoPropriedade.Items.AddRange(new object[] {
            "int",
            "long",
            "float",
            "double",
            "boolean",
            "string"});
            this.cb_tipoPropriedade.Location = new System.Drawing.Point(29, 170);
            this.cb_tipoPropriedade.Name = "cb_tipoPropriedade";
            this.cb_tipoPropriedade.Size = new System.Drawing.Size(136, 21);
            this.cb_tipoPropriedade.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo da propriedade:";
            // 
            // group_caracteristicasPropriedade
            // 
            this.group_caracteristicasPropriedade.Controls.Add(this.label5);
            this.group_caracteristicasPropriedade.Controls.Add(this.cb_modificadorAcesso2);
            this.group_caracteristicasPropriedade.Controls.Add(this.label1);
            this.group_caracteristicasPropriedade.Controls.Add(this.tb_nomePropriedade);
            this.group_caracteristicasPropriedade.Controls.Add(this.cb_static);
            this.group_caracteristicasPropriedade.Controls.Add(this.cb_tipoPropriedade);
            this.group_caracteristicasPropriedade.Controls.Add(this.label2);
            this.group_caracteristicasPropriedade.Location = new System.Drawing.Point(41, 61);
            this.group_caracteristicasPropriedade.Name = "group_caracteristicasPropriedade";
            this.group_caracteristicasPropriedade.Size = new System.Drawing.Size(200, 213);
            this.group_caracteristicasPropriedade.TabIndex = 13;
            this.group_caracteristicasPropriedade.TabStop = false;
            this.group_caracteristicasPropriedade.Text = "Caracteristícas da propriedade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Modificador de acesso:";
            // 
            // cb_modificadorAcesso2
            // 
            this.cb_modificadorAcesso2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modificadorAcesso2.FormattingEnabled = true;
            this.cb_modificadorAcesso2.Items.AddRange(new object[] {
            "public",
            "internal",
            "private",
            "private protected",
            "protected",
            "protected internal"});
            this.cb_modificadorAcesso2.Location = new System.Drawing.Point(29, 97);
            this.cb_modificadorAcesso2.Name = "cb_modificadorAcesso2";
            this.cb_modificadorAcesso2.Size = new System.Drawing.Size(136, 21);
            this.cb_modificadorAcesso2.TabIndex = 10;
            this.cb_modificadorAcesso2.SelectedIndexChanged += new System.EventHandler(this.cb_modificadorAcesso2_SelectedIndexChanged);
            // 
            // bt_janelaMetodos
            // 
            this.bt_janelaMetodos.Location = new System.Drawing.Point(70, 287);
            this.bt_janelaMetodos.Name = "bt_janelaMetodos";
            this.bt_janelaMetodos.Size = new System.Drawing.Size(138, 25);
            this.bt_janelaMetodos.TabIndex = 14;
            this.bt_janelaMetodos.Text = "Menu de métodos";
            this.bt_janelaMetodos.UseVisualStyleBackColor = true;
            this.bt_janelaMetodos.Click += new System.EventHandler(this.bt_janelaMetodos_Click_);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Estrutura da classe:";
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Image = global::CriadorDeClasse.Properties.Resources.lixeira1;
            this.bt_Limpar.Location = new System.Drawing.Point(282, 153);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(34, 35);
            this.bt_Limpar.TabIndex = 17;
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Image = global::CriadorDeClasse.Properties.Resources.ic_arrow_left;
            this.bt_remover.Location = new System.Drawing.Point(282, 109);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(34, 28);
            this.bt_remover.TabIndex = 6;
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Image = global::CriadorDeClasse.Properties.Resources.ic_arrow_right;
            this.bt_adicionar.Location = new System.Drawing.Point(282, 78);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(34, 28);
            this.bt_adicionar.TabIndex = 1;
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // MenuPropriedadeIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 394);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_janelaMetodos);
            this.Controls.Add(this.group_caracteristicasPropriedade);
            this.Controls.Add(this.bt_gerarClasse);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.lb_estruturaClasse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuPropriedadeIHM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criador de Classes";
            this.group_caracteristicasPropriedade.ResumeLayout(false);
            this.group_caracteristicasPropriedade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.TextBox tb_nomePropriedade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_estruturaClasse;
        private System.Windows.Forms.CheckBox cb_static;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Button bt_gerarClasse;
        private System.Windows.Forms.ComboBox cb_tipoPropriedade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox group_caracteristicasPropriedade;
        private System.Windows.Forms.Button bt_janelaMetodos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.ComboBox cb_modificadorAcesso2;
        private System.Windows.Forms.Label label5;
    }
}

