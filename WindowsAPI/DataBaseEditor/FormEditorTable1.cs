﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseLib;

namespace WindowsFormsApp1.DataBaseEditor
{
    public partial class FormEditorTable1 : Form
    {
        public FormEditorTable1()
        {
            InitializeComponent();
        }

        string _tableName = "Основная";

        private void Table1_Load(object sender, EventArgs e)
        {
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string[] args = new string[5];
            args[0] = textBox4.Text;
            args[1] = textBox1.Text;
            args[2] = textBox2.Text;
            args[3] = textBox3.Text;
            args[4] = textBox5.Text;

            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Insert(args, _tableName);
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string[] args = new string[1];
            args[0] = textBox4.Text;

            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Delete(args, _tableName);
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string[] args = new string[7];
            args[0] = textBox4.Text;
            args[1] = textBox1.Text;
            args[2] = textBox2.Text;
            args[3] = textBox3.Text;
            args[4] = textBox5.Text;
            button1.Enabled = true;
            button2.Enabled = true;
            DataBaseCommadsManager manager = new DataBaseCommadsManager();
            manager.Update(args, _tableName);
            dataGridView1.DataSource = manager.GetDataTable(_tableName);
        }


    }
}
