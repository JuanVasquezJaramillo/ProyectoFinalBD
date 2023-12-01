﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Proyecto_Final_Lab_BDI
{
    class TxtHolder:TextBox
    {
        public TxtHolder()
        {
            this.Enter += new EventHandler(txt_Enter);
            this.Leave += new EventHandler(txt_leave);
            base.ForeColor = Color.DimGray;
        }

        private string placeHolder;
        [Description("Texto placeHolder")]
        [Category("Place-Holder (custom)")]
        public string PlaceHolder
        {
            get { return placeHolder; }
            set { placeHolder = value; }
        }
        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if(txt.Text == PlaceHolder)
            {
                txt.Text = string.Empty;
                txt.ForeColor = Color.Black;
            }
        }
        private void txt_leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if(txt.Text == string.Empty)
            {
                txt.Text = placeHolder;
                txt.ForeColor = Color.DimGray;
            }
        }
    }
}
