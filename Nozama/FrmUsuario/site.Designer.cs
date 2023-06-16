
namespace Nozama
{
    partial class site
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
            this.btnoutrosprodutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnoutrosprodutos
            // 
            this.btnoutrosprodutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnoutrosprodutos.BackColor = System.Drawing.Color.Transparent;
            this.btnoutrosprodutos.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnoutrosprodutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoutrosprodutos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoutrosprodutos.ForeColor = System.Drawing.Color.Peru;
            this.btnoutrosprodutos.Location = new System.Drawing.Point(336, 378);
            this.btnoutrosprodutos.Name = "btnoutrosprodutos";
            this.btnoutrosprodutos.Size = new System.Drawing.Size(136, 26);
            this.btnoutrosprodutos.TabIndex = 10;
            this.btnoutrosprodutos.Text = "COMPRAR";
            this.btnoutrosprodutos.UseVisualStyleBackColor = false;
            this.btnoutrosprodutos.Click += new System.EventHandler(this.btnoutrosprodutos_Click);
            // 
            // site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nozama.Properties.Resources.nozamação;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnoutrosprodutos);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Peru;
            this.Name = "site";
            this.Text = "site";
            this.Load += new System.EventHandler(this.site_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnoutrosprodutos;
    }
}