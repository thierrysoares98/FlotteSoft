﻿using FlotteSoft.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlotteSoft
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Ao logar, automaticamente deixao  o campo de usuario selecionado para ser digitado
            txtUser.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MODEL.Menu menu = new MODEL.Menu();
            //menu.ShowDialog();
            this.Visible = false;
            splash sp = new splash();
            sp.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
