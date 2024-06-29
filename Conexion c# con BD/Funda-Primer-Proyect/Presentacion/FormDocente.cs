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
    public partial class FormDocente : Form
    {
        private NDocente nDocente = new NDocente();
        public FormDocente()
        {
            InitializeComponent();
            ShowTeachers(nDocente.ListAll());

        }
        private void ShowTeachers(List<Docente> docentes)
        {
            dgvTeacher.DataSource = null;
            if (docentes.Count == 0)
            {
                return;
            }
            else
            {
                dgvTeacher.DataSource = docentes;
                dgvTeacher.Columns["DocentexCurso"].Visible = false;
            }
        }
        private void ClearAll()
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbEscuela.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbApellido.Text == "" || tbEscuela.Text == "")
            {
                MessageBox.Show("You must enter all fields");
                return;
            }
            Docente docente = new Docente()
            {
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Escuela = tbEscuela.Text,
            };
            String mensaje = nDocente.Register(docente);
            MessageBox.Show(mensaje);

            ShowTeachers(nDocente.ListAll());
            ClearAll();
        }

        private void btnEliminate_Click(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a teacher");
                return;
            }

            int id_docente = int.Parse(dgvTeacher.SelectedRows[0].Cells[0].Value.ToString());
            String message = nDocente.Eliminate(id_docente);
            ShowTeachers(nDocente.ListAll());
            ClearAll();

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbApellido.Text == "" || tbEscuela.Text == "")
            {
                MessageBox.Show("You must enter all fields");
                return;
            }
            int id_docente = int.Parse(dgvTeacher.SelectedRows[0].Cells[0].Value.ToString());

            Docente docente = new Docente()
            {
                id_docente = id_docente,
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Escuela = tbEscuela.Text,
            };
            String mensaje = nDocente.Modify(docente);
            MessageBox.Show(mensaje);

            ClearAll();
            ShowTeachers(nDocente.ListAll());
        }
        private void btnSearchBySchool_Click(object sender, EventArgs e)
        {
            if (tbEscuela.Text == "")
            {
                MessageBox.Show("Enter School");
                return;
            }
            String school = tbEscuela.Text;
            ShowTeachers(nDocente.SearchBySchool(school));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTeacher_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvTeacher.SelectedRows[0];
                tbNombre.Text = row.Cells["Nombre"].Value.ToString();
                tbApellido.Text = row.Cells["Apellido"].Value.ToString();
                tbEscuela.Text = row.Cells["Escuela"].Value.ToString();
                    
            }
        }
    }
}