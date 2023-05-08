namespace WinFormsCheckBoxRadio
{
    partial class FormCheckBoxRadio
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
            this.labelindication = new System.Windows.Forms.Label();
            this.labelSaisieUtil = new System.Windows.Forms.Label();
            this.textBoxSaisieUtil = new System.Windows.Forms.TextBox();
            this.groupBoxChoix = new System.Windows.Forms.GroupBox();
            this.checkBoxCouleurFond = new System.Windows.Forms.CheckBox();
            this.checkBoxCouleurCaracteres = new System.Windows.Forms.CheckBox();
            this.checkBoxCasse = new System.Windows.Forms.CheckBox();
            this.groupBoxFond = new System.Windows.Forms.GroupBox();
            this.radioButtonFondRouge = new System.Windows.Forms.RadioButton();
            this.radioButtonFondVert = new System.Windows.Forms.RadioButton();
            this.radioButtonFondBleu = new System.Windows.Forms.RadioButton();
            this.groupBoxCarac = new System.Windows.Forms.GroupBox();
            this.radioButtonCaracRouge = new System.Windows.Forms.RadioButton();
            this.radioButtonCaracBlanc = new System.Windows.Forms.RadioButton();
            this.radioButtonCaracNoir = new System.Windows.Forms.RadioButton();
            this.groupBoxCasse = new System.Windows.Forms.GroupBox();
            this.radioButtonCasseMinus = new System.Windows.Forms.RadioButton();
            this.radioButtonCasseMaj = new System.Windows.Forms.RadioButton();
            this.groupBoxChoix.SuspendLayout();
            this.groupBoxFond.SuspendLayout();
            this.groupBoxCarac.SuspendLayout();
            this.groupBoxCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelindication
            // 
            this.labelindication.AutoSize = true;
            this.labelindication.Location = new System.Drawing.Point(12, 9);
            this.labelindication.Name = "labelindication";
            this.labelindication.Size = new System.Drawing.Size(95, 15);
            this.labelindication.TabIndex = 0;
            this.labelindication.Text = "Tapez votre texte";
            // 
            // labelSaisieUtil
            // 
            this.labelSaisieUtil.AutoSize = true;
            this.labelSaisieUtil.BackColor = System.Drawing.Color.Silver;
            this.labelSaisieUtil.Location = new System.Drawing.Point(12, 97);
            this.labelSaisieUtil.Name = "labelSaisieUtil";
            this.labelSaisieUtil.Size = new System.Drawing.Size(0, 15);
            this.labelSaisieUtil.TabIndex = 1;
            // 
            // textBoxSaisieUtil
            // 
            this.textBoxSaisieUtil.Location = new System.Drawing.Point(12, 27);
            this.textBoxSaisieUtil.Name = "textBoxSaisieUtil";
            this.textBoxSaisieUtil.Size = new System.Drawing.Size(185, 23);
            this.textBoxSaisieUtil.TabIndex = 2;
            this.textBoxSaisieUtil.TextChanged += new System.EventHandler(this.textBoxSaisieUtil_TextChanged);
            // 
            // groupBoxChoix
            // 
            this.groupBoxChoix.Controls.Add(this.checkBoxCouleurFond);
            this.groupBoxChoix.Controls.Add(this.checkBoxCouleurCaracteres);
            this.groupBoxChoix.Controls.Add(this.checkBoxCasse);
            this.groupBoxChoix.Enabled = false;
            this.groupBoxChoix.Location = new System.Drawing.Point(218, 12);
            this.groupBoxChoix.Name = "groupBoxChoix";
            this.groupBoxChoix.Size = new System.Drawing.Size(200, 100);
            this.groupBoxChoix.TabIndex = 3;
            this.groupBoxChoix.TabStop = false;
            this.groupBoxChoix.Text = "Choix";
            // 
            // checkBoxCouleurFond
            // 
            this.checkBoxCouleurFond.AutoSize = true;
            this.checkBoxCouleurFond.Location = new System.Drawing.Point(17, 22);
            this.checkBoxCouleurFond.Name = "checkBoxCouleurFond";
            this.checkBoxCouleurFond.Size = new System.Drawing.Size(113, 19);
            this.checkBoxCouleurFond.TabIndex = 4;
            this.checkBoxCouleurFond.Text = "Couleur du fond";
            this.checkBoxCouleurFond.UseVisualStyleBackColor = true;
            this.checkBoxCouleurFond.CheckedChanged += new System.EventHandler(this.checkBoxCouleurFond_CheckedChanged);
            // 
            // checkBoxCouleurCaracteres
            // 
            this.checkBoxCouleurCaracteres.AutoSize = true;
            this.checkBoxCouleurCaracteres.Location = new System.Drawing.Point(17, 50);
            this.checkBoxCouleurCaracteres.Name = "checkBoxCouleurCaracteres";
            this.checkBoxCouleurCaracteres.Size = new System.Drawing.Size(145, 19);
            this.checkBoxCouleurCaracteres.TabIndex = 5;
            this.checkBoxCouleurCaracteres.Text = "Couleur des caractères";
            this.checkBoxCouleurCaracteres.UseVisualStyleBackColor = true;
            this.checkBoxCouleurCaracteres.CheckedChanged += new System.EventHandler(this.checkBoxCouleurCaracteres_CheckedChanged);
            // 
            // checkBoxCasse
            // 
            this.checkBoxCasse.AutoSize = true;
            this.checkBoxCasse.Location = new System.Drawing.Point(17, 75);
            this.checkBoxCasse.Name = "checkBoxCasse";
            this.checkBoxCasse.Size = new System.Drawing.Size(56, 19);
            this.checkBoxCasse.TabIndex = 6;
            this.checkBoxCasse.Text = "Casse";
            this.checkBoxCasse.UseVisualStyleBackColor = true;
            this.checkBoxCasse.CheckedChanged += new System.EventHandler(this.checkBoxCasse_CheckedChanged);
            // 
            // groupBoxFond
            // 
            this.groupBoxFond.BackColor = System.Drawing.Color.Silver;
            this.groupBoxFond.Controls.Add(this.radioButtonFondRouge);
            this.groupBoxFond.Controls.Add(this.radioButtonFondVert);
            this.groupBoxFond.Controls.Add(this.radioButtonFondBleu);
            this.groupBoxFond.Location = new System.Drawing.Point(12, 317);
            this.groupBoxFond.Name = "groupBoxFond";
            this.groupBoxFond.Size = new System.Drawing.Size(200, 100);
            this.groupBoxFond.TabIndex = 0;
            this.groupBoxFond.TabStop = false;
            this.groupBoxFond.Text = "Fond";
            this.groupBoxFond.Visible = false;
            // 
            // radioButtonFondRouge
            // 
            this.radioButtonFondRouge.AutoSize = true;
            this.radioButtonFondRouge.BackColor = System.Drawing.Color.Red;
            this.radioButtonFondRouge.Location = new System.Drawing.Point(20, 17);
            this.radioButtonFondRouge.Name = "radioButtonFondRouge";
            this.radioButtonFondRouge.Size = new System.Drawing.Size(59, 19);
            this.radioButtonFondRouge.TabIndex = 4;
            this.radioButtonFondRouge.TabStop = true;
            this.radioButtonFondRouge.Text = "Rouge";
            this.radioButtonFondRouge.UseVisualStyleBackColor = false;
            this.radioButtonFondRouge.CheckedChanged += new System.EventHandler(this.radioButtonFondRouge_CheckedChanged);
            // 
            // radioButtonFondVert
            // 
            this.radioButtonFondVert.AutoSize = true;
            this.radioButtonFondVert.BackColor = System.Drawing.Color.Green;
            this.radioButtonFondVert.Location = new System.Drawing.Point(20, 42);
            this.radioButtonFondVert.Name = "radioButtonFondVert";
            this.radioButtonFondVert.Size = new System.Drawing.Size(45, 19);
            this.radioButtonFondVert.TabIndex = 5;
            this.radioButtonFondVert.TabStop = true;
            this.radioButtonFondVert.Text = "Vert";
            this.radioButtonFondVert.UseVisualStyleBackColor = false;
            this.radioButtonFondVert.CheckedChanged += new System.EventHandler(this.radioButtonFondVert_CheckedChanged);
            // 
            // radioButtonFondBleu
            // 
            this.radioButtonFondBleu.AutoSize = true;
            this.radioButtonFondBleu.BackColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonFondBleu.Location = new System.Drawing.Point(20, 67);
            this.radioButtonFondBleu.Name = "radioButtonFondBleu";
            this.radioButtonFondBleu.Size = new System.Drawing.Size(80, 19);
            this.radioButtonFondBleu.TabIndex = 6;
            this.radioButtonFondBleu.TabStop = true;
            this.radioButtonFondBleu.Text = "Bleu Royal";
            this.radioButtonFondBleu.UseVisualStyleBackColor = false;
            this.radioButtonFondBleu.CheckedChanged += new System.EventHandler(this.radioButtonFondBleu_CheckedChanged);
            // 
            // groupBoxCarac
            // 
            this.groupBoxCarac.BackColor = System.Drawing.Color.Silver;
            this.groupBoxCarac.Controls.Add(this.radioButtonCaracRouge);
            this.groupBoxCarac.Controls.Add(this.radioButtonCaracBlanc);
            this.groupBoxCarac.Controls.Add(this.radioButtonCaracNoir);
            this.groupBoxCarac.Location = new System.Drawing.Point(218, 317);
            this.groupBoxCarac.Name = "groupBoxCarac";
            this.groupBoxCarac.Size = new System.Drawing.Size(200, 100);
            this.groupBoxCarac.TabIndex = 0;
            this.groupBoxCarac.TabStop = false;
            this.groupBoxCarac.Text = "Caractères";
            this.groupBoxCarac.Visible = false;
            // 
            // radioButtonCaracRouge
            // 
            this.radioButtonCaracRouge.AutoSize = true;
            this.radioButtonCaracRouge.BackColor = System.Drawing.Color.Red;
            this.radioButtonCaracRouge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonCaracRouge.Location = new System.Drawing.Point(14, 22);
            this.radioButtonCaracRouge.Name = "radioButtonCaracRouge";
            this.radioButtonCaracRouge.Size = new System.Drawing.Size(59, 19);
            this.radioButtonCaracRouge.TabIndex = 7;
            this.radioButtonCaracRouge.TabStop = true;
            this.radioButtonCaracRouge.Text = "Rouge";
            this.radioButtonCaracRouge.UseVisualStyleBackColor = false;
            this.radioButtonCaracRouge.CheckedChanged += new System.EventHandler(this.radioButtonCaracRouge_CheckedChanged);
            // 
            // radioButtonCaracBlanc
            // 
            this.radioButtonCaracBlanc.AutoSize = true;
            this.radioButtonCaracBlanc.BackColor = System.Drawing.Color.White;
            this.radioButtonCaracBlanc.Location = new System.Drawing.Point(14, 50);
            this.radioButtonCaracBlanc.Name = "radioButtonCaracBlanc";
            this.radioButtonCaracBlanc.Size = new System.Drawing.Size(54, 19);
            this.radioButtonCaracBlanc.TabIndex = 8;
            this.radioButtonCaracBlanc.TabStop = true;
            this.radioButtonCaracBlanc.Text = "Blanc";
            this.radioButtonCaracBlanc.UseVisualStyleBackColor = false;
            this.radioButtonCaracBlanc.CheckedChanged += new System.EventHandler(this.radioButtonCaracBlanc_CheckedChanged);
            // 
            // radioButtonCaracNoir
            // 
            this.radioButtonCaracNoir.AutoSize = true;
            this.radioButtonCaracNoir.BackColor = System.Drawing.Color.Black;
            this.radioButtonCaracNoir.ForeColor = System.Drawing.Color.White;
            this.radioButtonCaracNoir.Location = new System.Drawing.Point(14, 75);
            this.radioButtonCaracNoir.Name = "radioButtonCaracNoir";
            this.radioButtonCaracNoir.Size = new System.Drawing.Size(48, 19);
            this.radioButtonCaracNoir.TabIndex = 9;
            this.radioButtonCaracNoir.TabStop = true;
            this.radioButtonCaracNoir.Text = "Noir";
            this.radioButtonCaracNoir.UseVisualStyleBackColor = false;
            this.radioButtonCaracNoir.CheckedChanged += new System.EventHandler(this.radioButtonCaracNoir_CheckedChanged);
            // 
            // groupBoxCasse
            // 
            this.groupBoxCasse.BackColor = System.Drawing.Color.Silver;
            this.groupBoxCasse.Controls.Add(this.radioButtonCasseMinus);
            this.groupBoxCasse.Controls.Add(this.radioButtonCasseMaj);
            this.groupBoxCasse.Location = new System.Drawing.Point(449, 317);
            this.groupBoxCasse.Name = "groupBoxCasse";
            this.groupBoxCasse.Size = new System.Drawing.Size(200, 100);
            this.groupBoxCasse.TabIndex = 0;
            this.groupBoxCasse.TabStop = false;
            this.groupBoxCasse.Text = "Casse";
            this.groupBoxCasse.Visible = false;
            // 
            // radioButtonCasseMinus
            // 
            this.radioButtonCasseMinus.AutoSize = true;
            this.radioButtonCasseMinus.Location = new System.Drawing.Point(23, 33);
            this.radioButtonCasseMinus.Name = "radioButtonCasseMinus";
            this.radioButtonCasseMinus.Size = new System.Drawing.Size(85, 19);
            this.radioButtonCasseMinus.TabIndex = 10;
            this.radioButtonCasseMinus.TabStop = true;
            this.radioButtonCasseMinus.Text = "minuscules";
            this.radioButtonCasseMinus.UseVisualStyleBackColor = true;
            this.radioButtonCasseMinus.CheckedChanged += new System.EventHandler(this.radioButtonCasseMinus_CheckedChanged);
            // 
            // radioButtonCasseMaj
            // 
            this.radioButtonCasseMaj.AutoSize = true;
            this.radioButtonCasseMaj.Location = new System.Drawing.Point(23, 67);
            this.radioButtonCasseMaj.Name = "radioButtonCasseMaj";
            this.radioButtonCasseMaj.Size = new System.Drawing.Size(97, 19);
            this.radioButtonCasseMaj.TabIndex = 11;
            this.radioButtonCasseMaj.TabStop = true;
            this.radioButtonCasseMaj.Text = "MAJUSCULES";
            this.radioButtonCasseMaj.UseVisualStyleBackColor = true;
            this.radioButtonCasseMaj.CheckedChanged += new System.EventHandler(this.radioButtonCasseMaj_CheckedChanged);
            // 
            // FormCheckBoxRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxFond);
            this.Controls.Add(this.groupBoxCarac);
            this.Controls.Add(this.groupBoxCasse);
            this.Controls.Add(this.groupBoxChoix);
            this.Controls.Add(this.textBoxSaisieUtil);
            this.Controls.Add(this.labelSaisieUtil);
            this.Controls.Add(this.labelindication);
            this.Name = "FormCheckBoxRadio";
            this.Text = "FormCheckBoxRadio";
            this.groupBoxChoix.ResumeLayout(false);
            this.groupBoxChoix.PerformLayout();
            this.groupBoxFond.ResumeLayout(false);
            this.groupBoxFond.PerformLayout();
            this.groupBoxCarac.ResumeLayout(false);
            this.groupBoxCarac.PerformLayout();
            this.groupBoxCasse.ResumeLayout(false);
            this.groupBoxCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelindication;
        private TextBox textBoxSaisieUtil;
        private GroupBox groupBoxChoix;
        private GroupBox groupBoxFond;
        private GroupBox groupBoxCarac;
        private GroupBox groupBoxCasse;
        private CheckBox checkBoxCouleurFond;
        private CheckBox checkBoxCouleurCaracteres;
        private CheckBox checkBoxCasse;
        private RadioButton radioButtonFondRouge;
        private RadioButton radioButtonFondVert;
        private RadioButton radioButtonFondBleu;
        private RadioButton radioButtonCaracRouge;
        private RadioButton radioButtonCaracBlanc;
        private RadioButton radioButtonCaracNoir;
        private RadioButton radioButtonCasseMinus;
        private RadioButton radioButtonCasseMaj;
        internal Label labelSaisieUtil;
    }
}