namespace WFOpeListBox
{
    partial class OpeListeBox
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
            this.labelElement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNewElement = new System.Windows.Forms.TextBox();
            this.textBoxIndexElement = new System.Windows.Forms.TextBox();
            this.buttonAddLst = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonClearLst = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBoxItemsCount = new System.Windows.Forms.TextBox();
            this.textBoxSelectedIndex = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelElement
            // 
            this.labelElement.AutoSize = true;
            this.labelElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelElement.Location = new System.Drawing.Point(12, 9);
            this.labelElement.Name = "labelElement";
            this.labelElement.Size = new System.Drawing.Size(96, 15);
            this.labelElement.TabIndex = 0;
            this.labelElement.Text = "Nouvel Élément\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(211, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Index Élément";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(211, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Propriétés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Items.Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Selected Index";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Text";
            // 
            // textBoxNewElement
            // 
            this.textBoxNewElement.Location = new System.Drawing.Point(12, 27);
            this.textBoxNewElement.Name = "textBoxNewElement";
            this.textBoxNewElement.Size = new System.Drawing.Size(100, 23);
            this.textBoxNewElement.TabIndex = 7;
            this.textBoxNewElement.TextChanged += new System.EventHandler(this.textBoxNewElement_TextChanged);
            // 
            // textBoxIndexElement
            // 
            this.textBoxIndexElement.Location = new System.Drawing.Point(211, 27);
            this.textBoxIndexElement.Name = "textBoxIndexElement";
            this.textBoxIndexElement.Size = new System.Drawing.Size(44, 23);
            this.textBoxIndexElement.TabIndex = 8;
            this.textBoxIndexElement.TextChanged += new System.EventHandler(this.textBoxIndexElement_TextChanged);
            // 
            // buttonAddLst
            // 
            this.buttonAddLst.Location = new System.Drawing.Point(12, 56);
            this.buttonAddLst.Name = "buttonAddLst";
            this.buttonAddLst.Size = new System.Drawing.Size(100, 23);
            this.buttonAddLst.TabIndex = 9;
            this.buttonAddLst.Text = "Ajout Liste";
            this.buttonAddLst.UseVisualStyleBackColor = true;
            this.buttonAddLst.Click += new System.EventHandler(this.buttonAddLst_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(291, 27);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(114, 23);
            this.buttonSelect.TabIndex = 10;
            this.buttonSelect.Text = "Sélectionner";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonClearLst
            // 
            this.buttonClearLst.Location = new System.Drawing.Point(291, 56);
            this.buttonClearLst.Name = "buttonClearLst";
            this.buttonClearLst.Size = new System.Drawing.Size(114, 23);
            this.buttonClearLst.TabIndex = 11;
            this.buttonClearLst.Text = "Vider la liste";
            this.buttonClearLst.UseVisualStyleBackColor = true;
            this.buttonClearLst.Click += new System.EventHandler(this.buttonClearLst_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(12, 116);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(120, 94);
            this.listBox.TabIndex = 12;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.FormatStringChanged += new System.EventHandler(this.buttonAddLst_Click);
            // 
            // textBoxItemsCount
            // 
            this.textBoxItemsCount.Location = new System.Drawing.Point(305, 123);
            this.textBoxItemsCount.Name = "textBoxItemsCount";
            this.textBoxItemsCount.ReadOnly = true;
            this.textBoxItemsCount.Size = new System.Drawing.Size(40, 23);
            this.textBoxItemsCount.TabIndex = 13;
            this.textBoxItemsCount.TextChanged += new System.EventHandler(this.textBoxItemsCount_TextChanged);
            // 
            // textBoxSelectedIndex
            // 
            this.textBoxSelectedIndex.Location = new System.Drawing.Point(305, 157);
            this.textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            this.textBoxSelectedIndex.ReadOnly = true;
            this.textBoxSelectedIndex.Size = new System.Drawing.Size(40, 23);
            this.textBoxSelectedIndex.TabIndex = 14;
            this.textBoxSelectedIndex.TextChanged += new System.EventHandler(this.textBoxSelectedIndex_TextChanged);
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(305, 192);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ReadOnly = true;
            this.textBoxText.Size = new System.Drawing.Size(100, 23);
            this.textBoxText.TabIndex = 15;
            this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            // 
            // OpeListeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 238);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxSelectedIndex);
            this.Controls.Add(this.textBoxItemsCount);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonClearLst);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonAddLst);
            this.Controls.Add(this.textBoxIndexElement);
            this.Controls.Add(this.textBoxNewElement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelElement);
            this.Name = "OpeListeBox";
            this.Text = "Les listes et leurs propriétés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelElement;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxNewElement;
        private TextBox textBoxIndexElement;
        private Button buttonAddLst;
        private Button buttonSelect;
        private Button buttonClearLst;
        private ListBox listBox;
        private TextBox textBoxItemsCount;
        private TextBox textBoxSelectedIndex;
        private TextBox textBoxText;
    }
}