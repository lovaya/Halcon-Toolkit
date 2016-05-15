namespace Halcon_Toolkit.Controls.Winform
{
    partial class SmartWindowWinform
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
            this.DisplayWindow = new HalconDotNet.HWindowControl();
            this.SuspendLayout();
            // 
            // hWindowControl1
            // 
            this.DisplayWindow.BackColor = System.Drawing.Color.Black;
            this.DisplayWindow.BorderColor = System.Drawing.Color.Black;
            this.DisplayWindow.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.DisplayWindow.Location = new System.Drawing.Point(0, 0);
            this.DisplayWindow.Name = "DisplayWindow";
            this.DisplayWindow.Size = new System.Drawing.Size(269, 268);
            this.DisplayWindow.TabIndex = 0;
            this.DisplayWindow.WindowSize = new System.Drawing.Size(269, 268);
            // 
            // SmartWindowWinform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisplayWindow);
            this.Name = "SmartWindowWinform";
            this.Size = this.DisplayWindow.Size;
            this.ResumeLayout(false);

        }

        #endregion

        private HalconDotNet.HWindowControl DisplayWindow;
    }
}
