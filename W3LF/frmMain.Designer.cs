/*
 *  Warcraft 3 Loader Form - A C# forms application modification upon the original W3L by Acid and Keres
 *	Copyright (C) 2011  MusicDemon
 *
 *	This program is free software: you can redistribute it and/or modify
 *	it under the terms of the GNU General Public License as published by
 *	the Free Software Foundation, either version 3 of the License, or
 *	(at your option) any later version.
 *
 *	This program is distributed in the hope that it will be useful,
 *	but WITHOUT ANY WARRANTY; without even the implied warranty of
 *	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *	GNU General Public License for more details.
 *
 *	You should have received a copy of the GNU General Public License
 *	along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace CPlan.W3LF
{
    partial class frmMain
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
            this.cbWindow = new System.Windows.Forms.CheckBox();
            this.cbOpenGL = new System.Windows.Forms.CheckBox();
            this.cbSWTNL = new System.Windows.Forms.CheckBox();
            this.cbClassic = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbWindow
            // 
            this.cbWindow.AutoSize = true;
            this.cbWindow.Location = new System.Drawing.Point(12, 12);
            this.cbWindow.Name = "cbWindow";
            this.cbWindow.Size = new System.Drawing.Size(106, 17);
            this.cbWindow.TabIndex = 0;
            this.cbWindow.Text = "&Windowed mode";
            this.cbWindow.UseVisualStyleBackColor = true;
            // 
            // cbOpenGL
            // 
            this.cbOpenGL.AutoSize = true;
            this.cbOpenGL.Location = new System.Drawing.Point(12, 35);
            this.cbOpenGL.Name = "cbOpenGL";
            this.cbOpenGL.Size = new System.Drawing.Size(66, 17);
            this.cbOpenGL.TabIndex = 1;
            this.cbOpenGL.Text = "&OpenGL";
            this.cbOpenGL.UseVisualStyleBackColor = true;
            // 
            // cbSWTNL
            // 
            this.cbSWTNL.AutoSize = true;
            this.cbSWTNL.Location = new System.Drawing.Point(12, 58);
            this.cbSWTNL.Name = "cbSWTNL";
            this.cbSWTNL.Size = new System.Drawing.Size(238, 17);
            this.cbSWTNL.TabIndex = 2;
            this.cbSWTNL.Text = "S&oftware Transform and Lighting Video mode";
            this.cbSWTNL.UseVisualStyleBackColor = true;
            // 
            // cbClassic
            // 
            this.cbClassic.AutoSize = true;
            this.cbClassic.Location = new System.Drawing.Point(12, 81);
            this.cbClassic.Name = "cbClassic";
            this.cbClassic.Size = new System.Drawing.Size(170, 17);
            this.cbClassic.TabIndex = 3;
            this.cbClassic.Text = "&Classic mode (Reign of Chaos)";
            this.cbClassic.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(241, 104);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "&Start Warcraft III";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 133);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbClassic);
            this.Controls.Add(this.cbSWTNL);
            this.Controls.Add(this.cbOpenGL);
            this.Controls.Add(this.cbWindow);
            this.Icon = global::CPlan.W3LF.Properties.Resources.ico;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Warcraft III Loader Form - Connection Planet";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// The <see cref="System.Windows.Forms.CheckBox"/> that determine whether or not to start Warcraft III in Windowed mode.
        /// </summary>
        private System.Windows.Forms.CheckBox cbWindow;
        /// <summary>
        /// The <see cref="System.Windows.Forms.CheckBox"/> that determine whether or not to start Warcraft III in OpenGL mode.
        /// </summary>
        private System.Windows.Forms.CheckBox cbOpenGL;
        /// <summary>
        /// The <see cref="System.Windows.Forms.CheckBox"/> that determine whether or not to start Warcraft III in Software Transform and Lighting Video mode.
        /// </summary>
        private System.Windows.Forms.CheckBox cbSWTNL;
        /// <summary>
        /// The <see cref="System.Windows.Forms.CheckBox"/> that determine whether or not to start Warcraft III in classic mode. (Reign of Chaos)
        /// </summary>
        private System.Windows.Forms.CheckBox cbClassic;
        /// <summary>
        /// The <see cref="System.Windows.Forms.Button"/> to save the settings with.
        /// </summary>
        private System.Windows.Forms.Button btnSave;
        /// <summary>
        /// The <see cref="System.Windows.Forms.Button"/> to start Warcraft III with.
        /// </summary>
        private System.Windows.Forms.Button btnStart;
    }
}

