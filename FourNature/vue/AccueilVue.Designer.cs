namespace FourNature.vue
{

    partial class Accueil
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Arbitrage = new System.Windows.Forms.Button();
            this.ListeClient = new System.Windows.Forms.Button();
            this.ListeFournisseur = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Bienvenu = new System.Windows.Forms.Label();
            this.Icon = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Version, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.Arbitrage, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ListeClient, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ListeFournisseur, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 147);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(734, 147);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // Arbitrage
            // 
            this.Arbitrage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Arbitrage.Location = new System.Drawing.Point(491, 3);
            this.Arbitrage.Name = "Arbitrage";
            this.Arbitrage.Size = new System.Drawing.Size(240, 141);
            this.Arbitrage.TabIndex = 2;
            this.Arbitrage.Text = "Arbitrage";
            this.Arbitrage.UseVisualStyleBackColor = true;
            // 
            // ListeClient
            // 
            this.ListeClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeClient.Location = new System.Drawing.Point(247, 3);
            this.ListeClient.Name = "ListeClient";
            this.ListeClient.Size = new System.Drawing.Size(238, 141);
            this.ListeClient.TabIndex = 1;
            this.ListeClient.Text = "Liste Client";
            this.ListeClient.UseVisualStyleBackColor = true;
            // 
            // ListeFournisseur
            // 
            this.ListeFournisseur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeFournisseur.Location = new System.Drawing.Point(3, 3);
            this.ListeFournisseur.Name = "ListeFournisseur";
            this.ListeFournisseur.Size = new System.Drawing.Size(238, 141);
            this.ListeFournisseur.TabIndex = 0;
            this.ListeFournisseur.Text = "Liste Fournisseur";
            this.ListeFournisseur.UseVisualStyleBackColor = true;
            this.ListeFournisseur.Click += new System.EventHandler(this.ListeFournisseur_Click);
            // 
            // Version
            // 
            this.Version.AllowDrop = true;
            this.Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(689, 428);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(42, 13);
            this.Version.TabIndex = 1;
            this.Version.Text = "Version";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.Bienvenu, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Icon, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(734, 147);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // Bienvenu
            // 
            this.Bienvenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bienvenu.AutoSize = true;
            this.Bienvenu.Location = new System.Drawing.Point(247, 0);
            this.Bienvenu.Name = "Bienvenu";
            this.Bienvenu.Size = new System.Drawing.Size(238, 147);
            this.Bienvenu.TabIndex = 0;
            this.Bienvenu.Text = "Bienvenu !";
            this.Bienvenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Icon
            // 
            this.Icon.AutoSize = true;
            this.Icon.Location = new System.Drawing.Point(3, 0);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(28, 13);
            this.Icon.TabIndex = 1;
            this.Icon.Text = "Icon";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Arbitrage;
        private System.Windows.Forms.Button ListeClient;
        private System.Windows.Forms.Button ListeFournisseur;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label Bienvenu;
        private System.Windows.Forms.Label Icon;
    }
}