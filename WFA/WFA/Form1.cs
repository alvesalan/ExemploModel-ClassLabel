using Model;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno();
                aluno.SetNome(txtNome.Text);
                aluno.SetTurma(txtTurma.Text);
                aluno.SetTurno(txtTurno.Text);
                aluno.SetIdade(Convert.ToInt32(txtIdade.Text));
                aluno.SetMatricula(Convert.ToInt32(txtMatricula));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }
    }
}
