﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqsql
{
    public partial class Form1 : Form
    {
        private DataDataContext data;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = new DataDataContext();
            var user = from u in data.GetTable<usuarios>()
                       select u;
            //subiendo cambios
            //s
            //Mensaje nuevo
            //nuevo bs
            dgView.DataSource = user.ToList();
        }
    }
}
