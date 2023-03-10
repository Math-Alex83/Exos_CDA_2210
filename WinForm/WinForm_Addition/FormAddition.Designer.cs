namespace WinForm_Addition
{
    partial class Ladditionnator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toucheVider = new System.Windows.Forms.Button();
            this.toucheCalculer = new System.Windows.Forms.Button();
            this.touche0 = new System.Windows.Forms.Button();
            this.touche1 = new System.Windows.Forms.Button();
            this.touche2 = new System.Windows.Forms.Button();
            this.touche3 = new System.Windows.Forms.Button();
            this.touche4 = new System.Windows.Forms.Button();
            this.touche5 = new System.Windows.Forms.Button();
            this.touche6 = new System.Windows.Forms.Button();
            this.touche7 = new System.Windows.Forms.Button();
            this.touche8 = new System.Windows.Forms.Button();
            this.touche9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(43, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(200, 50);
            this.textBox1.TabIndex = 2;
            // 
            // toucheVider
            // 
            this.toucheVider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toucheVider.BackColor = System.Drawing.Color.DarkRed;
            this.toucheVider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toucheVider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toucheVider.ForeColor = System.Drawing.Color.White;
            this.toucheVider.Location = new System.Drawing.Point(43, 193);
            this.toucheVider.MinimumSize = new System.Drawing.Size(60, 40);
            this.toucheVider.Name = "toucheVider";
            this.toucheVider.Size = new System.Drawing.Size(60, 40);
            this.toucheVider.TabIndex = 3;
            this.toucheVider.Text = "Vider";
            this.toucheVider.UseVisualStyleBackColor = false;
            this.toucheVider.Click += new System.EventHandler(this.toucheVider_Click);
            // 
            // toucheCalculer
            // 
            this.toucheCalculer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toucheCalculer.BackColor = System.Drawing.Color.ForestGreen;
            this.toucheCalculer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toucheCalculer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toucheCalculer.ForeColor = System.Drawing.Color.White;
            this.toucheCalculer.Location = new System.Drawing.Point(183, 193);
            this.toucheCalculer.MaximumSize = new System.Drawing.Size(60, 40);
            this.toucheCalculer.MinimumSize = new System.Drawing.Size(60, 40);
            this.toucheCalculer.Name = "toucheCalculer";
            this.toucheCalculer.Size = new System.Drawing.Size(60, 40);
            this.toucheCalculer.TabIndex = 4;
            this.toucheCalculer.Text = "Calculer";
            this.toucheCalculer.UseVisualStyleBackColor = false;
            this.toucheCalculer.Click += new System.EventHandler(this.toucheCalculer_Click);
            // 
            // touche0
            // 
            this.touche0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.touche0.BackColor = System.Drawing.Color.Ivory;
            this.touche0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.touche0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche0.Location = new System.Drawing.Point(43, 91);
            this.touche0.MinimumSize = new System.Drawing.Size(25, 25);
            this.touche0.Name = "touche0";
            this.touche0.Size = new System.Drawing.Size(25, 25);
            this.touche0.TabIndex = 5;
            this.touche0.Text = "0";
            this.touche0.UseVisualStyleBackColor = false;
            this.touche0.Click += new System.EventHandler(this.boutons_ensemble);
            // 
            // touche1
            // 
            this.touche1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.touche1.BackColor = System.Drawing.Color.Ivory;
            this.touche1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.touche1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche1.Location = new System.Drawing.Point(84, 91);
            this.touche1.MinimumSize = new System.Drawing.Size(25, 25);
            this.touche1.Name = "touche1";
            this.touche1.Size = new System.Drawing.Size(25, 25);
            this.touche1.TabIndex = 6;
            this.touche1.Text = "1";
            this.touche1.UseVisualStyleBackColor = false;
            this.touche1.Click += new System.EventHandler(this.boutons_ensemble);
            // 
            // touche2
            // 
            this.touche2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.touche2.BackColor = System.Drawing.Color.Ivory;
            this.touche2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.touche2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche2.Location = new System.Drawing.Point(128, 91);
            this.touche2.MinimumSize = new System.Drawing.Size(25, 25);
            this.touche2.Name = "touche2";
            this.touche2.Size = new System.Drawing.Size(25, 25);
            this.touche2.TabIndex = 7;
            this.touche2.Text = "2";
            this.touche2.UseVisualStyleBackColor = false;
            this.touche2.Click += new System.EventHandler(this.boutons_ensemble);
            // 
            // touche3
            // 
            this.touche3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.touche3.BackColor = System.Drawing.Color.Ivory;
            this.touche3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.touche3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche3.Location = new System.Drawing.Point(170, 91);
            this.touche3.MinimumSize = new System.Drawing.Size(25, 25);
            this.touche3.Name = "touche3";
            this.touche3.Size = new System.Drawing.Size(25, 25);
            this.touche3.TabIndex = 8;
            this.touche3.Text = "3";
            this.touche3.UseVisualStyleBackColor = false;
            this.touche3.Click += new System.EventHandler(this.boutons_ensemble);
            // 
            // touche4
            // 
            this.touche4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.touche4.BackColor = System.Drawing.Color.Ivory;
            this.touche4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.touche4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche4.Location = new System.Drawing.Point(218, 91);
            this.touche4.MinimumSize = new System.Drawing.Size(25, 25);
            this.touche4.Name = "touche4";
            this.touche4.Size = new System.Drawing.Size(25, 25);
            this.touche4.TabIndex = 9;
            this.touche4.Text = "4";
            this.touche4.UseVisualStyleBackColor = false;
            this.touche4.Click += new System.EventHandler(this.boutons_ensemble);
            // 
            // touche5
            // 
            this.touche5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.touche5.BackColor = System.Drawing.Color.Ivory;
            this.touche5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.touche5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche5.Location = new System.Drawing.Point(43, 149);
            this.touche5.MinimumSize = new System.Drawing.Size(25, 25);
            this.touche5.Name = "touche5";
            this.touche5.Size = new System.Drawing.Size(25, 25);
            this.touche5.TabIndex = 10;
            this.touche5.Text = "5";
            this.touche5.UseVisualStyleBackColor = false;
            this.touche5.Click += new System.EventHandler(this.boutons_ensemble);
            // 
            // touche6
            // 
            this.touche6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.touche6.BackColor = System.Drawing.Color.Ivory;
            this.touche6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.touche6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche6.Location = new System.Drawing.Point(84, 149);
            this.touche6.MinimumSize = new System.Drawing.Size(25, 25);
            this.touche6.Name = "touche6";
            this.touche6.Size = new System.Drawing.Size(25, 25);
            this.touche6.TabIndex = 11;
            this.touche6.Text = "6";
            this.touche6.UseVisualStyleBackColor = false;
            this.touche6.Click += new System.EventHandler(this.boutons_ensemble);
            // 
            // touche7
            // 
            this.touche7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.touche7.BackColor = System.Drawing.Color.Ivory;
            this.touche7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.touche7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche7.Location = new System.Drawing.Point(128, 149);
            this.touche7.MinimumSize = new System.Drawing.Size(25, 25);
            this.touche7.Name = "touche7";
            this.touche7.Size = new System.Drawing.Size(25, 25);
            this.touche7.TabIndex = 12;
            this.touche7.Text = "7";
            this.touche7.UseVisualStyleBackColor = false;
            this.touche7.Click += new System.EventHandler(this.boutons_ensemble);
            // 
            // touche8
            // 
            this.touche8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.touche8.BackColor = System.Drawing.Color.Ivory;
            this.touche8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.touche8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche8.Location = new System.Drawing.Point(170, 149);
            this.touche8.MinimumSize = new System.Drawing.Size(25, 25);
            this.touche8.Name = "touche8";
            this.touche8.Size = new System.Drawing.Size(25, 25);
            this.touche8.TabIndex = 13;
            this.touche8.Text = "8";
            this.touche8.UseVisualStyleBackColor = false;
            this.touche8.Click += new System.EventHandler(this.boutons_ensemble);
            // 
            // touche9
            // 
            this.touche9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.touche9.BackColor = System.Drawing.Color.Ivory;
            this.touche9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.touche9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche9.Location = new System.Drawing.Point(218, 149);
            this.touche9.MinimumSize = new System.Drawing.Size(25, 25);
            this.touche9.Name = "touche9";
            this.touche9.Size = new System.Drawing.Size(25, 25);
            this.touche9.TabIndex = 14;
            this.touche9.Text = "9";
            this.touche9.UseVisualStyleBackColor = false;
            this.touche9.Click += new System.EventHandler(this.boutons_ensemble);
            // 
            // Ladditionnator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.touche9);
            this.Controls.Add(this.touche8);
            this.Controls.Add(this.touche7);
            this.Controls.Add(this.touche6);
            this.Controls.Add(this.touche5);
            this.Controls.Add(this.touche4);
            this.Controls.Add(this.touche3);
            this.Controls.Add(this.touche2);
            this.Controls.Add(this.touche1);
            this.Controls.Add(this.touche0);
            this.Controls.Add(this.toucheCalculer);
            this.Controls.Add(this.toucheVider);
            this.Controls.Add(this.textBox1);
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Ladditionnator";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddition";
            this.Load += new System.EventHandler(this.Ladditionnator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private Button toucheVider;
        private Button toucheCalculer;
        private Button touche0;
        private Button touche1;
        private Button touche2;
        private Button touche3;
        private Button touche4;
        private Button touche5;
        private Button touche6;
        private Button touche7;
        private Button touche8;
        private Button touche9;
    }
}