namespace Halcon_Toolkit.Controls.Winform
{
    partial class SmartWindowWinform
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
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
