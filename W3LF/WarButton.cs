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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Intcon.W3LF
{
    /// <summary>
    /// A custom control that displays the Warcraft III start buttons.
    /// </summary>
    [DefaultEvent("Click")]
    partial class WarButton : UserControl
    {
        private int Id = 0;

        /// <summary>
        /// Occures when the control is clicked.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new event EventHandler Click;

        /// <summary>
        /// Initializes a new instance of the <see cref="Intcon.W3LF.WarButton"/> class.
        /// </summary>
        public WarButton()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sets the Id of the <see cref="Intcon.W3LF.WarButton" />.
        /// </summary>
        /// <param name="Id">The Id of the <see cref="Intcon.W3LF.WarButton" />. Use non-0, 0 is default.</param>
        public void SetId(int Id)
        {
            this.Id = Id;
            if (Id == 0)
                pbBtn.Image = Properties.Resources.button_w3_normal;
            else
                pbBtn.Image = Properties.Resources.button_w3_gproxy_normal;
        }

        bool InBtn = false;
        private void pbBtn_MouseEnter(object sender, EventArgs e)
        {
            InBtn = true;
            if (Id == 0)
                pbBtn.Image = Properties.Resources.button_w3_hover;
            else
                pbBtn.Image = Properties.Resources.button_w3_gproxy_hover;
        }

        private void pbBtn_MouseLeave(object sender, EventArgs e)
        {
            InBtn = false;
            if (Id == 0)
                pbBtn.Image = Properties.Resources.button_w3_normal;
            else
                pbBtn.Image = Properties.Resources.button_w3_gproxy_normal;
        }

        private void pbBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                if (Id == 0)
                    pbBtn.Image = Properties.Resources.button_w3_pressed;
                else
                    pbBtn.Image = Properties.Resources.button_w3_gproxy_pressed;
        }

        private void pbBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (InBtn)
                if (Id == 0)
                    pbBtn.Image = Properties.Resources.button_w3_hover;
                else
                    pbBtn.Image = Properties.Resources.button_w3_gproxy_hover;
            else
                if (Id == 0)
                    pbBtn.Image = Properties.Resources.button_w3_normal;
                else
                    pbBtn.Image = Properties.Resources.button_w3_gproxy_normal;
        }

        private void pbBtn_Click(object sender, EventArgs e)
        {
            if (Click != null)
                Click(this, EventArgs.Empty);
        }
    }
}
