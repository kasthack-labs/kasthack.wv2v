namespace kasthack.wv2test2
{
    partial class FrmVisualizer
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
            this.brsContent = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.brsContent)).BeginInit();
            this.SuspendLayout();
            // 
            // brsContent
            // 
            this.brsContent.CreationProperties = null;
            this.brsContent.DefaultBackgroundColor = System.Drawing.Color.White;
            this.brsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brsContent.Location = new System.Drawing.Point(0, 0);
            this.brsContent.Name = "brsContent";
            this.brsContent.Size = new System.Drawing.Size(800, 450);
            this.brsContent.TabIndex = 0;
            this.brsContent.ZoomFactor = 1D;
            // 
            // frmVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brsContent);
            this.Name = "frmVisualizer";
            this.Text = "kasthack\'s WebView2 HTML Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brsContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 brsContent;
    }
}

