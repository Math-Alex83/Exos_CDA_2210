namespace FormECF
{
    partial class InscriptionStagiaireForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxDateDebut = new System.Windows.Forms.TextBox();
            this.textBoxDateFin = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.labelChoix = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.radioButtonCDA = new System.Windows.Forms.RadioButton();
            this.radioButtonDWWM = new System.Windows.Forms.RadioButton();
            this.radioButtonABC = new System.Windows.Forms.RadioButton();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDateD = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDateD)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(8, 27);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.PlaceholderText = "Ex : AKNOUCHE";
            this.textBoxNom.Size = new System.Drawing.Size(100, 23);
            this.textBoxNom.TabIndex = 0;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxDateDebut
            // 
            this.textBoxDateDebut.Location = new System.Drawing.Point(8, 158);
            this.textBoxDateDebut.Name = "textBoxDateDebut";
            this.textBoxDateDebut.PlaceholderText = "jj/mm/aaaa";
            this.textBoxDateDebut.Size = new System.Drawing.Size(100, 23);
            this.textBoxDateDebut.TabIndex = 2;
            this.textBoxDateDebut.TextChanged += new System.EventHandler(this.textBoxDateDebut_TextChanged);
            // 
            // textBoxDateFin
            // 
            this.textBoxDateFin.Location = new System.Drawing.Point(8, 224);
            this.textBoxDateFin.Name = "textBoxDateFin";
            this.textBoxDateFin.PlaceholderText = "jj/mm/aaaa";
            this.textBoxDateFin.Size = new System.Drawing.Size(100, 23);
            this.textBoxDateFin.TabIndex = 3;
            this.textBoxDateFin.TextChanged += new System.EventHandler(this.textBoxDateFin_TextChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(8, 9);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(34, 15);
            this.labelNom.TabIndex = 5;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(8, 73);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 15);
            this.labelPrenom.TabIndex = 6;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Location = new System.Drawing.Point(8, 140);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(77, 15);
            this.labelDateDebut.TabIndex = 7;
            this.labelDateDebut.Text = "Date d\'entrée";
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Location = new System.Drawing.Point(8, 206);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(64, 15);
            this.labelDateFin.TabIndex = 8;
            this.labelDateFin.Text = "Date de fin";
            // 
            // labelChoix
            // 
            this.labelChoix.AutoSize = true;
            this.labelChoix.Location = new System.Drawing.Point(232, 46);
            this.labelChoix.Name = "labelChoix";
            this.labelChoix.Size = new System.Drawing.Size(126, 15);
            this.labelChoix.TabIndex = 9;
            this.labelChoix.Text = "Formation du stagiaire";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(232, 185);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 10;
            this.buttonValider.Text = "VALIDER";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(8, 91);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.PlaceholderText = "Ex : Mathieu-Alexandre";
            this.textBoxPrenom.Size = new System.Drawing.Size(133, 23);
            this.textBoxPrenom.TabIndex = 11;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.textBoxPrenom_TextChanged);
            // 
            // radioButtonCDA
            // 
            this.radioButtonCDA.AutoSize = true;
            this.radioButtonCDA.BackColor = System.Drawing.Color.Silver;
            this.radioButtonCDA.Location = new System.Drawing.Point(232, 64);
            this.radioButtonCDA.Name = "radioButtonCDA";
            this.radioButtonCDA.Size = new System.Drawing.Size(49, 19);
            this.radioButtonCDA.TabIndex = 12;
            this.radioButtonCDA.TabStop = true;
            this.radioButtonCDA.Tag = "CDA";
            this.radioButtonCDA.Text = "CDA";
            this.radioButtonCDA.UseVisualStyleBackColor = false;
            this.radioButtonCDA.CheckedChanged += new System.EventHandler(this.radioButtonCDA_CheckedChanged);
            // 
            // radioButtonDWWM
            // 
            this.radioButtonDWWM.AutoSize = true;
            this.radioButtonDWWM.BackColor = System.Drawing.Color.Silver;
            this.radioButtonDWWM.Location = new System.Drawing.Point(232, 89);
            this.radioButtonDWWM.Name = "radioButtonDWWM";
            this.radioButtonDWWM.Size = new System.Drawing.Size(66, 19);
            this.radioButtonDWWM.TabIndex = 13;
            this.radioButtonDWWM.TabStop = true;
            this.radioButtonDWWM.Tag = "DWWM";
            this.radioButtonDWWM.Text = "DWWM";
            this.radioButtonDWWM.UseVisualStyleBackColor = false;
            this.radioButtonDWWM.CheckedChanged += new System.EventHandler(this.radioButtonDWWM_CheckedChanged);
            // 
            // radioButtonABC
            // 
            this.radioButtonABC.AutoSize = true;
            this.radioButtonABC.BackColor = System.Drawing.Color.Silver;
            this.radioButtonABC.Location = new System.Drawing.Point(232, 114);
            this.radioButtonABC.Name = "radioButtonABC";
            this.radioButtonABC.Size = new System.Drawing.Size(74, 19);
            this.radioButtonABC.TabIndex = 14;
            this.radioButtonABC.TabStop = true;
            this.radioButtonABC.Tag = "ABC-DEV";
            this.radioButtonABC.Text = "ABC-DEV";
            this.radioButtonABC.UseVisualStyleBackColor = false;
            this.radioButtonABC.CheckedChanged += new System.EventHandler(this.radioButtonABC_CheckedChanged);
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.ContainerControl = this;
            // 
            // errorProviderDateD
            // 
            this.errorProviderDateD.ContainerControl = this;
            // 
            // InscriptionStagiaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 276);
            this.Controls.Add(this.radioButtonABC);
            this.Controls.Add(this.radioButtonDWWM);
            this.Controls.Add(this.radioButtonCDA);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.labelChoix);
            this.Controls.Add(this.labelDateFin);
            this.Controls.Add(this.labelDateDebut);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxDateFin);
            this.Controls.Add(this.textBoxDateDebut);
            this.Controls.Add(this.textBoxNom);
            this.Name = "InscriptionStagiaireForm";
            this.Text = "InscriptionStagiaireForm";
            this.Load += new System.EventHandler(this.InscriptionStagiaireForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDateD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNom;
        private TextBox textBoxDateDebut;
        private TextBox textBoxDateFin;
        private Label labelNom;
        private Label labelPrenom;
        private Label labelDateDebut;
        private Label labelDateFin;
        private Label labelChoix;
        private Button buttonValider;
        private TextBox textBoxPrenom;
        private RadioButton radioButtonCDA;
        private RadioButton radioButtonDWWM;
        private RadioButton radioButtonABC;
        private ErrorProvider errorProviderNom;
        private ErrorProvider errorProviderDateD;
    }
}