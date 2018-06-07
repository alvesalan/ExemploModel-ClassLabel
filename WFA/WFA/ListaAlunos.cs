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
    public partial class ListaAlunos : Form
    {
        public ListaAlunos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CadastroAluno().ShowDialog();
        }

        private void ListaAlunos_Activated(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.alunos.Count(); i++)
            {
                Aluno aluno = Program.alunos[i];
                dataGridView1.Rows.Add(new Object[]
                    {
                       aluno.GetCodigo(),
                       aluno.GetNome(),
                       aluno.GetTurma(),
                       aluno.GetTurno(),
                       aluno.GetIdade()

            });
            }
        }

        internal static object GetNotas()
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            new CadastroAluno(Codigo).ShowDialog();
        }
    }
}
