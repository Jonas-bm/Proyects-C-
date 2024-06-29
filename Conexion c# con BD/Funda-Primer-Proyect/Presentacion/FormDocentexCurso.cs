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
    public partial class FormDocentexCurso : Form
    {
        private NDocentexCurso nDocenteXcurso = new NDocentexCurso();
        private NDocente nDocente=new NDocente();
        private NCurso nCurso = new NCurso();
        public FormDocentexCurso()
        {
            InitializeComponent();
            ShowTeachers(nDocente.ListAll());
            ShowCourses(nCurso.ListAll());
            ShowTeacherxCourse(nDocenteXcurso.ListAll());
        }
        private void ShowTeachers(List<Docente> docentes)
        {
            cbxDocente.DataSource = null;
            if(docentes.Count == 0)
            {
                return;
            }
            else
            {
                cbxDocente.DataSource = docentes;
                cbxDocente.ValueMember = "id_docente";
                cbxDocente.DisplayMember = "Nombre";
            }
        }
        private void ShowCourses(List<Curso> cursos)
        {
            cbxCurso.DataSource = null;
            if (cursos.Count == 0)
            {
                return;
            }
            else
            {
                cbxCurso.DataSource = cursos;
                cbxCurso.ValueMember = "id_curso";
                cbxCurso.DisplayMember = "Nombrecurso";
            }
        }
        private void ShowTeacherxCourse(List<DocentexCurso> docenteXcursos)
        {
            dgvAssign.DataSource = null;
            if(docenteXcursos.Count==0)
            {
                return;
            }
            else
            {
                dgvAssign.DataSource = docenteXcursos;
                dgvAssign.Columns["Curso"].Visible = false;
                dgvAssign.Columns["Docente"].Visible=false;
            }

        }
        private void ClearAll()
        {
            cbxCurso.Text = "";
            cbxDocente.Text = "";
            tbSemestre.Text = "";
        }
        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cbxDocente.Text == "" || cbxCurso.Text == "" || tbSemestre.Text == "")
            {
                MessageBox.Show("You must enter all fields");
                return;
            }

            int id_docente = int.Parse(cbxDocente.SelectedValue.ToString());
            int id_curso = int.Parse(cbxCurso.SelectedValue.ToString());

            DocentexCurso docentexCurso = new DocentexCurso()
            {
                id_docente=id_docente,
                id_curso=id_curso,
                Semestre=tbSemestre.Text
            };

            String mensaje=nDocenteXcurso.Assign(docentexCurso);
            MessageBox.Show(mensaje);

            ShowTeacherxCourse(nDocenteXcurso.ListAll());
            ClearAll();
        }
        private void btnUnassign_Click(object sender, EventArgs e)
        {
            if (dgvAssign.SelectedRows.Count==0)
            {
                MessageBox.Show("Select to Assign");
                return;
            }

            int id_docente = int.Parse(dgvAssign.SelectedRows[0].Cells[0].Value.ToString());
            int id_curso = int.Parse(dgvAssign.SelectedRows[0].Cells[1].Value.ToString());

            String mensaje = nDocenteXcurso.Unassign(id_docente,id_curso);
            MessageBox.Show(mensaje);

            ShowTeacherxCourse(nDocenteXcurso.ListAll());
            ClearAll();
        }

        private void btnSearchByTeacher_Click(object sender, EventArgs e)
        {
            if (cbxDocente.Text =="")
            {
                MessageBox.Show("Select Teacher");
                return;
            }
            int id_docente = int.Parse(cbxDocente.SelectedValue.ToString());

            ShowTeacherxCourse(nDocenteXcurso.SearchByIdTeacher(id_docente));
        }

        private void btnSearchByCourse_Click(object sender, EventArgs e)
        {
            if (cbxDocente.Text == "")
            {
                MessageBox.Show("Select Teacher");
                return;
            }
            int id_curso = int.Parse(cbxCurso.SelectedValue.ToString());

            ShowTeacherxCourse(nDocenteXcurso.SearchByIdCourse(id_curso));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAssign_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAssign.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAssign.SelectedRows[0];
                cbxDocente.Text = row.Cells["id_docente"].ToString();
                cbxCurso.Text = row.Cells["id_curso"].Value.ToString();
                tbSemestre.Text = row.Cells["Semestre"].Value.ToString();
            }
        }
    }
}
