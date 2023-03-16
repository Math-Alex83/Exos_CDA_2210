namespace WinForms_Ph2_Validation
{
    partial class FormControleur
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.labNom = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labMontant = new System.Windows.Forms.Label();
            this.labCP = new System.Windows.Forms.Label();
            this.errorNomProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorDateProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMontantProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCPProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorNomProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDateProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMontantProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCPProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(97, 13);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(150, 23);
            this.textBoxNom.TabIndex = 2;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(97, 70);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxDate.TabIndex = 4;
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBoxDate_TextChanged);
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(97, 188);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(100, 23);
            this.textBoxCP.TabIndex = 10;
            this.textBoxCP.TextChanged += new System.EventHandler(this.textBoxCP_TextChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValider.Location = new System.Drawing.Point(261, 191);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 12;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(261, 233);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(75, 23);
            this.buttonEffacer.TabIndex = 13;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.BackColor = System.Drawing.Color.Transparent;
            this.labNom.Location = new System.Drawing.Point(12, 16);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(34, 15);
            this.labNom.TabIndex = 15;
            this.labNom.Text = "Nom";
            this.labNom.Click += new System.EventHandler(this.labNom_Click);
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.BackColor = System.Drawing.Color.Transparent;
            this.labDate.Location = new System.Drawing.Point(12, 73);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(31, 15);
            this.labDate.TabIndex = 17;
            this.labDate.Text = "Date";
            this.labDate.Click += new System.EventHandler(this.labDate_Click);
            // 
            // labMontant
            // 
            this.labMontant.AutoSize = true;
            this.labMontant.BackColor = System.Drawing.Color.Transparent;
            this.labMontant.Location = new System.Drawing.Point(12, 130);
            this.labMontant.Name = "labMontant";
            this.labMontant.Size = new System.Drawing.Size(53, 15);
            this.labMontant.TabIndex = 18;
            this.labMontant.Text = "Montant";
            this.labMontant.Click += new System.EventHandler(this.labMontant_Click);
            // 
            // labCP
            // 
            this.labCP.AutoSize = true;
            this.labCP.BackColor = System.Drawing.Color.Transparent;
            this.labCP.Location = new System.Drawing.Point(12, 191);
            this.labCP.Name = "labCP";
            this.labCP.Size = new System.Drawing.Size(70, 15);
            this.labCP.TabIndex = 19;
            this.labCP.Text = "Code Postal";
            this.labCP.Click += new System.EventHandler(this.labCP_Click);
            // 
            // errorNomProvider
            // 
            this.errorNomProvider.ContainerControl = this;
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(97, 122);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(100, 23);
            this.textBoxMontant.TabIndex = 21;
            this.textBoxMontant.TextChanged += new System.EventHandler(this.textBoxMontant_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(216, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "JJ/MM/AAAA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorDateProvider
            // 
            this.errorDateProvider.ContainerControl = this;
            // 
            // errorMontantProvider
            // 
            this.errorMontantProvider.ContainerControl = this;
            // 
            // errorCPProvider
            // 
            this.errorCPProvider.ContainerControl = this;
            // 
            // FormControleur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.labCP);
            this.Controls.Add(this.labMontant);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labNom);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxNom);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.Name = "FormControleur";
            this.Text = "FormControleur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormControleur_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorNomProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDateProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMontantProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCPProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxNom;
        private TextBox textBoxDate;
        private TextBox textBoxCP;
        private Button buttonValider;
        private Button buttonEffacer;
        private Label labNom;
        private Label labDate;
        private Label labMontant;
        private Label labCP;
        private ErrorProvider errorNomProvider;
        private TextBox textBoxMontant;
        private Label label1;
        private ErrorProvider errorDateProvider;
        private ErrorProvider errorMontantProvider;
        private ErrorProvider errorCPProvider;
    }
}