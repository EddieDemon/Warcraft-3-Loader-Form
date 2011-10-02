/*
 *    Warcraft 3 Loader Form - A C# forms application modification upon the original W3L by Acid and Keres
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

﻿using System;
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
    /// A custom CheckBox-like control.
    /// </summary>
    partial class CheckBoxC : UserControl
    {
        bool _Checked = false;
        /// <summary>
        /// Creates a new instance of the <see cref="Intcon.W3LF.CheckBoxC"/> class.
        /// </summary>
        public CheckBoxC()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The text associated with this control.
        /// </summary>
        [BrowsableAttribute(true)]
        [CategoryAttribute("Apperance")]
        [DefaultValue("CCheckBox1")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return lblCaption.Text; }
            set { lblCaption.Text = value; }
        }
        /// <summary>
        /// Gets or set a value indicating whether the System.Windows.Forms.CheckBox is in the checked state.
        /// </summary>
        public bool Checked
        {
            get { return _Checked; }
            set
            {
                _Checked = value;
                Image Chck = Properties.Resources.cbChck;
                if (!Enabled) Chck = Properties.Resources.cbChckDis;
                if (_Checked)
                    pbCheck.Image = Chck;
                else
                    pbCheck.Image = null;
            }
        }
        /// <summary>
        /// Handles the click event and changes the <see cref="Intcon.W3LF.CheckBoxC.Checked"/> property.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains no event data.</param>
        private void CheckBoxC_Click(object sender, EventArgs e)
        {
            if (Enabled)
            {
                if (_Checked) Checked = false;
                else Checked = true;
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether the control can respond to user interaction.
        /// </summary>
        public new bool Enabled
        {
            get { return base.Enabled; }
            set
            {
                base.Enabled = value;
                if (value)
                {
                    pbCheck.BackgroundImage = Properties.Resources.cb;
                    if (_Checked)
                        pbCheck.Image = Properties.Resources.cbChck;
                }
                else
                {
                    pbCheck.BackgroundImage = Properties.Resources.cbDis;
                    if (_Checked)
                        pbCheck.Image = Properties.Resources.cbChckDis;
                }
            }
        }
        /// <summary>
        /// Handles the mousedown event and changes the check sign.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A System.Windows.Forms.MouseEventArgs that contains the event data.</param>
        private void CheckBoxC_MouseDown(object sender, MouseEventArgs e)
        {
            if (Enabled) pbCheck.BackgroundImage = Properties.Resources.cbPress;
        }
        /// <summary>
        /// Handles the mousedown event and changes the check sign.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A System.Windows.Forms.MouseEventArgs that contains the event data.</param>
        private void CheckBoxC_MouseUp(object sender, MouseEventArgs e)
        {
            if (Enabled) pbCheck.BackgroundImage = Properties.Resources.cb;
        }
    }
}
