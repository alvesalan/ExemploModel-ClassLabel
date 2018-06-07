﻿using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class CadastroAlunoNota : Form
    {

        private Aluno aluno;

        public CadastroAlunoNota(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarNota();

        }

        private void CadastrarNota()
        {
            try
            {
                double nota = Convert.ToDouble(txtNota.Text);
                aluno.AdicionarNota(nota);
                this.DialogResult = DialogResult.OK;
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtNota_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void txtNota_KeyDown(object sender, KeyEventArgs e)
        {
            CadastrarNota();
        }


    }
}
