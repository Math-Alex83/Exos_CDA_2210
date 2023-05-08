namespace WFBDDCarsOwner
{
    partial class CarsOner
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
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.AddOwner = new System.Windows.Forms.Button();
            this.AddCar = new System.Windows.Forms.Button();
            this.DeleteOwner = new System.Windows.Forms.Button();
            this.DeleteCar = new System.Windows.Forms.Button();
            this.EditTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCar.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.RowTemplate.Height = 25;
            this.dataGridViewCar.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCar.TabIndex = 0;
            // 
            // AddOwner
            // 
            this.AddOwner.Location = new System.Drawing.Point(246, 0);
            this.AddOwner.Name = "AddOwner";
            this.AddOwner.Size = new System.Drawing.Size(213, 23);
            this.AddOwner.TabIndex = 1;
            this.AddOwner.Text = "Ajouter propriétaire";
            this.AddOwner.UseVisualStyleBackColor = true;
            this.AddOwner.Click += new System.EventHandler(this.AddOwner_Click);
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(465, 0);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(188, 23);
            this.AddCar.TabIndex = 2;
            this.AddCar.Text = "Ajout Voiture";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // DeleteOwner
            // 
            this.DeleteOwner.Location = new System.Drawing.Point(246, 55);
            this.DeleteOwner.Name = "DeleteOwner";
            this.DeleteOwner.Size = new System.Drawing.Size(213, 23);
            this.DeleteOwner.TabIndex = 3;
            this.DeleteOwner.Text = "Supprimer propriétaire";
            this.DeleteOwner.UseVisualStyleBackColor = true;
            this.DeleteOwner.Click += new System.EventHandler(this.DeleteOwner_Click);
            // 
            // DeleteCar
            // 
            this.DeleteCar.Location = new System.Drawing.Point(465, 55);
            this.DeleteCar.Name = "DeleteCar";
            this.DeleteCar.Size = new System.Drawing.Size(188, 23);
            this.DeleteCar.TabIndex = 4;
            this.DeleteCar.Text = "Supprimer Voiture";
            this.DeleteCar.UseVisualStyleBackColor = true;
            this.DeleteCar.Click += new System.EventHandler(this.DeleteCar_Click);
            // 
            // EditTable
            // 
            this.EditTable.Location = new System.Drawing.Point(246, 127);
            this.EditTable.Name = "EditTable";
            this.EditTable.Size = new System.Drawing.Size(75, 23);
            this.EditTable.TabIndex = 5;
            this.EditTable.Text = "Modifier";
            this.EditTable.UseVisualStyleBackColor = true;
            this.EditTable.Click += new System.EventHandler(this.EditTable_Click);
            // 
            // CarsOner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditTable);
            this.Controls.Add(this.DeleteCar);
            this.Controls.Add(this.DeleteOwner);
            this.Controls.Add(this.AddCar);
            this.Controls.Add(this.AddOwner);
            this.Controls.Add(this.dataGridViewCar);
            this.Name = "CarsOner";
            this.Text = "CarsOner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewCar;
        private Button AddOwner;
        private Button AddCar;
        private Button DeleteOwner;
        private Button DeleteCar;
        private Button EditTable;
    }
}