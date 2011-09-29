namespace Intcon.W3LF
{
    partial class WarButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBtn
            // 
            this.pbBtn.BackColor = System.Drawing.Color.Transparent;
            this.pbBtn.BackgroundImage = global::Intcon.W3LF.Properties.Resources.button_w3_normal;
            this.pbBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBtn.Location = new System.Drawing.Point(44, 10);
            this.pbBtn.Name = "pbBtn";
            this.pbBtn.Size = new System.Drawing.Size(212, 33);
            this.pbBtn.TabIndex = 0;
            this.pbBtn.TabStop = false;
            this.pbBtn.Click += new System.EventHandler(this.pbBtn_Click);
            this.pbBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBtn_MouseDown);
            this.pbBtn.MouseEnter += new System.EventHandler(this.pbBtn_MouseEnter);
            this.pbBtn.MouseLeave += new System.EventHandler(this.pbBtn_MouseLeave);
            this.pbBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbBtn_MouseUp);
            // 
            // WarButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Intcon.W3LF.Properties.Resources.btnBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbBtn);
            this.DoubleBuffered = true;
            this.Name = "WarButton";
            this.Size = new System.Drawing.Size(302, 56);
            ((System.ComponentModel.ISupportInitialize)(this.pbBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBtn;
    }
}
