namespace Projet_ORM
{
    partial class menu
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.familleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.créeUneFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créeProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.familleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 26);
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.familleToolStripMenuItem.Text = "Famille";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.familleToolStripMenuItem1,
            this.produitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // familleToolStripMenuItem1
            // 
            this.familleToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créeUneFamilleToolStripMenuItem,
            this.consultationFamilleToolStripMenuItem});
            this.familleToolStripMenuItem1.Name = "familleToolStripMenuItem1";
            this.familleToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.familleToolStripMenuItem1.Text = "Famille";
            // 
            // créeUneFamilleToolStripMenuItem
            // 
            this.créeUneFamilleToolStripMenuItem.Name = "créeUneFamilleToolStripMenuItem";
            this.créeUneFamilleToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.créeUneFamilleToolStripMenuItem.Text = "Crée une Famille";
            this.créeUneFamilleToolStripMenuItem.Click += new System.EventHandler(this.créeUneFamilleToolStripMenuItem_Click);
            // 
            // consultationFamilleToolStripMenuItem
            // 
            this.consultationFamilleToolStripMenuItem.Name = "consultationFamilleToolStripMenuItem";
            this.consultationFamilleToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultationFamilleToolStripMenuItem.Text = "consultation Famille";
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créeProduitToolStripMenuItem,
            this.voirProduitToolStripMenuItem});
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.produitToolStripMenuItem.Text = "Produit";
            // 
            // créeProduitToolStripMenuItem
            // 
            this.créeProduitToolStripMenuItem.Name = "créeProduitToolStripMenuItem";
            this.créeProduitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.créeProduitToolStripMenuItem.Text = "Crée produit";
            this.créeProduitToolStripMenuItem.Click += new System.EventHandler(this.créeProduitToolStripMenuItem_Click);
            // 
            // voirProduitToolStripMenuItem
            // 
            this.voirProduitToolStripMenuItem.Name = "voirProduitToolStripMenuItem";
            this.voirProduitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voirProduitToolStripMenuItem.Text = "voir produit";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem créeUneFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créeProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirProduitToolStripMenuItem;
    }
}