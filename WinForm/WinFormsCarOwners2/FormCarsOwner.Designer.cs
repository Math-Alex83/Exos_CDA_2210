namespace WinFormsCarOwners2
{
    partial class FormCarsOwner
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
            this.EditTable = new System.Windows.Forms.Button();
            this.DeleteCar = new System.Windows.Forms.Button();
            this.DeleteOwner = new System.Windows.Forms.Button();
            this.AddCar = new System.Windows.Forms.Button();
            this.AddOwner = new System.Windows.Forms.Button();
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.textBoxCarName = new System.Windows.Forms.TextBox();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.textBoxEdite = new System.Windows.Forms.TextBox();
            this.textBoxCarRegistration = new System.Windows.Forms.TextBox();
            this.textBoxEditRegistration = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            this.SuspendLayout();
            // 
            // EditTable
            // 
            this.EditTable.Location = new System.Drawing.Point(397, 264);
            this.EditTable.Name = "EditTable";
            this.EditTable.Size = new System.Drawing.Size(75, 23);
            this.EditTable.TabIndex = 11;
            this.EditTable.Text = "Modifier";
            this.EditTable.UseVisualStyleBackColor = true;
            this.EditTable.Click += new System.EventHandler(this.EditTable_Click);
            // 
            // DeleteCar
            // 
            this.DeleteCar.Location = new System.Drawing.Point(397, 130);
            this.DeleteCar.Name = "DeleteCar";
            this.DeleteCar.Size = new System.Drawing.Size(188, 23);
            this.DeleteCar.TabIndex = 10;
            this.DeleteCar.Text = "Supprimer Voiture";
            this.DeleteCar.UseVisualStyleBackColor = true;
            this.DeleteCar.Click += new System.EventHandler(this.DeleteCar_Click);
            // 
            // DeleteOwner
            // 
            this.DeleteOwner.Location = new System.Drawing.Point(591, 130);
            this.DeleteOwner.Name = "DeleteOwner";
            this.DeleteOwner.Size = new System.Drawing.Size(213, 23);
            this.DeleteOwner.TabIndex = 9;
            this.DeleteOwner.Text = "Supprimer propriétaire";
            this.DeleteOwner.UseVisualStyleBackColor = true;
            this.DeleteOwner.Click += new System.EventHandler(this.DeleteOwner_Click);
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(397, 12);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(188, 23);
            this.AddCar.TabIndex = 8;
            this.AddCar.Text = "Ajout Voiture";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // AddOwner
            // 
            this.AddOwner.Location = new System.Drawing.Point(591, 12);
            this.AddOwner.Name = "AddOwner";
            this.AddOwner.Size = new System.Drawing.Size(213, 23);
            this.AddOwner.TabIndex = 7;
            this.AddOwner.Text = "Ajouter propriétaire";
            this.AddOwner.UseVisualStyleBackColor = true;
            this.AddOwner.Click += new System.EventHandler(this.AddOwner_Click);
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.RowTemplate.Height = 25;
            this.dataGridViewCar.Size = new System.Drawing.Size(379, 306);
            this.dataGridViewCar.TabIndex = 6;
            this.dataGridViewCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCar_CellContentClick);
            // 
            // textBoxCarName
            // 
            this.textBoxCarName.Location = new System.Drawing.Point(397, 71);
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.PlaceholderText = "Nom Voiture";
            this.textBoxCarName.Size = new System.Drawing.Size(188, 23);
            this.textBoxCarName.TabIndex = 12;
            this.textBoxCarName.TextChanged += new System.EventHandler(this.textBoxCarName_TextChanged);
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(591, 71);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(213, 23);
            this.textBoxOwner.TabIndex = 13;
            this.textBoxOwner.TextChanged += new System.EventHandler(this.textBoxOwner_TextChanged);
            // 
            // textBoxEdite
            // 
            this.textBoxEdite.Location = new System.Drawing.Point(485, 264);
            this.textBoxEdite.Name = "textBoxEdite";
            this.textBoxEdite.PlaceholderText = "Nom à modifier";
            this.textBoxEdite.Size = new System.Drawing.Size(100, 23);
            this.textBoxEdite.TabIndex = 14;
            this.textBoxEdite.TextChanged += new System.EventHandler(this.textBoxEdite_TextChanged);
            // 
            // textBoxCarRegistration
            // 
            this.textBoxCarRegistration.Location = new System.Drawing.Point(397, 100);
            this.textBoxCarRegistration.Name = "textBoxCarRegistration";
            this.textBoxCarRegistration.PlaceholderText = "Ex: AA-1234-BB";
            this.textBoxCarRegistration.Size = new System.Drawing.Size(188, 23);
            this.textBoxCarRegistration.TabIndex = 15;
            this.textBoxCarRegistration.TextChanged += new System.EventHandler(this.textBoxCarRegistration_TextChanged);
            // 
            // textBoxEditRegistration
            // 
            this.textBoxEditRegistration.Location = new System.Drawing.Point(591, 265);
            this.textBoxEditRegistration.Name = "textBoxEditRegistration";
            this.textBoxEditRegistration.PlaceholderText = "Immatriculation à modifier";
            this.textBoxEditRegistration.Size = new System.Drawing.Size(150, 23);
            this.textBoxEditRegistration.TabIndex = 16;
            this.textBoxEditRegistration.TextChanged += new System.EventHandler(this.textBoxEditRegistration_TextChanged);
            // 
            // FormCarsOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 330);
            this.Controls.Add(this.textBoxEditRegistration);
            this.Controls.Add(this.textBoxCarRegistration);
            this.Controls.Add(this.textBoxEdite);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.textBoxCarName);
            this.Controls.Add(this.EditTable);
            this.Controls.Add(this.DeleteCar);
            this.Controls.Add(this.DeleteOwner);
            this.Controls.Add(this.AddCar);
            this.Controls.Add(this.AddOwner);
            this.Controls.Add(this.dataGridViewCar);
            this.Name = "FormCarsOwner";
            this.Text = "FormCarsOwner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EditTable;
        private Button DeleteCar;
        private Button DeleteOwner;
        private Button AddCar;
        private Button AddOwner;
        private DataGridView dataGridViewCar;
        private TextBox textBoxCarName;
        private TextBox textBoxOwner;
        private TextBox textBoxEdite;
        private TextBox textBoxCarRegistration;
        private TextBox textBoxEditRegistration;
    }
}