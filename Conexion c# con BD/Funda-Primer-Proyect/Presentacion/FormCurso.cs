using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCurso : Form
    {
        private NCurso nCurso=new NCurso();
        public FormCurso()
        {
            InitializeComponent();
            ShowCourses(nCurso.ListAll());
        }

        private void ShowCourses(List<Curso> cursos)
        {
            dgvCourse.DataSource=null;
            if (cursos.Count==0)
            {
                return;
            }
            else
            {
               dgvCourse.DataSource= cursos;
               dgvCourse.Columns["DocentexCurso"].Visible = false;
            }
        }

        private void ClearAll()
        {
            tbNombre.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(tbNombre.Text=="")
            {
               MessageBox.Show("You must enter all fields");
                return;
            }

            Curso curso = new Curso()
            {
                Nombrecurso = tbNombre.Text
            };

            String mensaje = nCurso.Register(curso);
            MessageBox.Show(mensaje);

            ShowCourses(nCurso.ListAll());
            ClearAll();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                MessageBox.Show("You must enter all fields");
                return;
            }

            int id_curso = int.Parse(dgvCourse.SelectedRows[0].Cells[0].Value.ToString());

            Curso curso = new Curso()
            {
                id_curso = id_curso,
                Nombrecurso = tbNombre.Text
            };

            String mensaje = nCurso.Modify(curso);
            MessageBox.Show(mensaje);

            ClearAll();
            ShowCourses(nCurso.ListAll());
        }

        private void btnEliminate_Click(object sender, EventArgs e)
        {
            if(dgvCourse.SelectedRows.Count==0)
            {
                MessageBox.Show("Select a Course");
                return;
            }
            int id_curso = int.Parse(dgvCourse.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nCurso.Eliminate(id_curso);
            MessageBox.Show(mensaje);

            ShowCourses(nCurso.ListAll());
            ClearAll();
        }

        private void btnSearchByNameCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCourse_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCourse.SelectedRows[0];
                tbNombre.Text = row.Cells["Nombrecurso"].Value.ToString();
            }
        }
    }
}
