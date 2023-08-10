
namespace PadariaCarmel
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.lblCarregando = new System.Windows.Forms.Label();
            this.lblPorc = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pgbCarregando = new System.Windows.Forms.ProgressBar();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.Location = new System.Drawing.Point(347, 295);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(13, 13);
            this.lblCarregando.TabIndex = 0;
            this.lblCarregando.Text = "0";
            // 
            // lblPorc
            // 
            this.lblPorc.AutoSize = true;
            this.lblPorc.Location = new System.Drawing.Point(366, 295);
            this.lblPorc.Name = "lblPorc";
            this.lblPorc.Size = new System.Drawing.Size(15, 13);
            this.lblPorc.TabIndex = 1;
            this.lblPorc.Text = "%";
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(190, 67);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(310, 215);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 2;
            this.pctLogo.TabStop = false;
            // 
            // pgbCarregando
            // 
            this.pgbCarregando.Location = new System.Drawing.Point(177, 324);
            this.pgbCarregando.Name = "pgbCarregando";
            this.pgbCarregando.Size = new System.Drawing.Size(349, 35);
            this.pgbCarregando.TabIndex = 3;
        
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pgbCarregando);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.lblPorc);
            this.Controls.Add(this.lblCarregando);
            this.Name = "frmSplash";
            this.Text = "frmSplash";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.Label lblPorc;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.ProgressBar pgbCarregando;
        private System.Windows.Forms.Timer tmrSplash;
    }
}