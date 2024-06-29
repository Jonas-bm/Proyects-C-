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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            lblFechaHoy.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnViewTeachers_Click(object sender, EventArgs e)
        {
            FormDocente f=new FormDocente();
            f.Show();
            
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            FormCurso f=new FormCurso();
            f.Show();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            FormDocentexCurso f=new FormDocentexCurso();
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
