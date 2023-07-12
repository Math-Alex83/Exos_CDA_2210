namespace WindowsFormsPaint
{
    partial class FormPaint
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelDessin = new System.Windows.Forms.Panel();
            this.contextMenuStripChoix = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.addCercle = new System.Windows.Forms.ToolStripMenuItem();
            this.grouper = new System.Windows.Forms.ToolStripMenuItem();
            this.dissocier = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripChoix.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDessin
            // 
            this.panelDessin.BackColor = System.Drawing.Color.White;
            this.panelDessin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDessin.Location = new System.Drawing.Point(0, 0);
            this.panelDessin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDessin.Name = "panelDessin";
            this.panelDessin.Size = new System.Drawing.Size(1011, 752);
            this.panelDessin.TabIndex = 0;
            this.panelDessin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDessin_Paint);
            this.panelDessin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelDessin_MouseClick);
            this.panelDessin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDessin_MouseDown);
  
            // 
            // contextMenuStripChoix
            // 
            this.contextMenuStripChoix.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRectangle,
            this.addCercle,
            this.grouper,
            this.dissocier});
            this.contextMenuStripChoix.Name = "contextMenuStripChoix";
            this.contextMenuStripChoix.Size = new System.Drawing.Size(245, 124);
            this.contextMenuStripChoix.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripChoix_ItemClicked);
            // 
            // addRectangle
            // 
            this.addRectangle.Name = "addRectangle";
            this.addRectangle.Size = new System.Drawing.Size(244, 30);
            this.addRectangle.Text = "Ajouter un rectangle";
            // 
            // addCercle
            // 
            this.addCercle.Name = "addCercle";
            this.addCercle.Size = new System.Drawing.Size(244, 30);
            this.addCercle.Text = "Ajouter un Cercle";
            // 
            // grouper
            // 
            this.grouper.Name = "grouper";
            this.grouper.Size = new System.Drawing.Size(244, 30);
            this.grouper.Text = "Grouper";
            this.grouper.Click += new System.EventHandler(this.grouper_Click);
            // 
            // dissocier
            // 
            this.dissocier.Name = "dissocier";
            this.dissocier.Size = new System.Drawing.Size(244, 30);
            this.dissocier.Text = "Dissocier";
            this.dissocier.Click += new System.EventHandler(this.dissocier_Click);
            // 
            // FormPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 752);
            this.Controls.Add(this.panelDessin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.contextMenuStripChoix.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDessin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripChoix;
        private System.Windows.Forms.ToolStripMenuItem addRectangle;
        private System.Windows.Forms.ToolStripMenuItem addCercle;
        private System.Windows.Forms.ToolStripMenuItem grouper;
        private System.Windows.Forms.ToolStripMenuItem dissocier;
    }
}

