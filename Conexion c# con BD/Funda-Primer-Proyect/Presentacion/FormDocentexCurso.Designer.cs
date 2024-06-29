namespace Presentacion
{
    partial class FormDocentexCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchByCourse = new System.Windows.Forms.Button();
            this.btnUnassign = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearchByTeacher = new System.Windows.Forms.Button();
            this.dgvAssign = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSemestre = new System.Windows.Forms.TextBox();
            this.cbxDocente = new System.Windows.Forms.ComboBox();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssign)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(154)))), ((int)(((byte)(37)))));
            this.label5.Location = new System.Drawing.Point(19, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "LIST´S ASSIGN";
            // 
            // btnSearchByCourse
            // 
            this.btnSearchByCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(90)))), ((int)(((byte)(143)))));
            this.btnSearchByCourse.FlatAppearance.BorderSize = 0;
            this.btnSearchByCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchByCourse.Location = new System.Drawing.Point(231, 225);
            this.btnSearchByCourse.Name = "btnSearchByCourse";
            this.btnSearchByCourse.Size = new System.Drawing.Size(99, 28);
            this.btnSearchByCourse.TabIndex = 35;
            this.btnSearchByCourse.Text = "Search By Course";
            this.btnSearchByCourse.UseVisualStyleBackColor = false;
            this.btnSearchByCourse.Click += new System.EventHandler(this.btnSearchByCourse_Click);
            // 
            // btnUnassign
            // 
            this.btnUnassign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(90)))), ((int)(((byte)(143)))));
            this.btnUnassign.FlatAppearance.BorderSize = 0;
            this.btnUnassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnassign.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnassign.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUnassign.Location = new System.Drawing.Point(21, 225);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(99, 28);
            this.btnUnassign.TabIndex = 36;
            this.btnUnassign.Text = "Unassign";
            this.btnUnassign.UseVisualStyleBackColor = false;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(90)))), ((int)(((byte)(143)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(336, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 28);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearchByTeacher
            // 
            this.btnSearchByTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(90)))), ((int)(((byte)(143)))));
            this.btnSearchByTeacher.FlatAppearance.BorderSize = 0;
            this.btnSearchByTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByTeacher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchByTeacher.Location = new System.Drawing.Point(126, 225);
            this.btnSearchByTeacher.Name = "btnSearchByTeacher";
            this.btnSearchByTeacher.Size = new System.Drawing.Size(99, 28);
            this.btnSearchByTeacher.TabIndex = 39;
            this.btnSearchByTeacher.Text = "Search By Teacher";
            this.btnSearchByTeacher.UseVisualStyleBackColor = false;
            this.btnSearchByTeacher.Click += new System.EventHandler(this.btnSearchByTeacher_Click);
            // 
            // dgvAssign
            // 
            this.dgvAssign.AllowUserToOrderColumns = true;
            this.dgvAssign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssign.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(77)))));
            this.dgvAssign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssign.Location = new System.Drawing.Point(21, 25);
            this.dgvAssign.Name = "dgvAssign";
            this.dgvAssign.Size = new System.Drawing.Size(522, 193);
            this.dgvAssign.TabIndex = 34;
            this.dgvAssign.SelectionChanged += new System.EventHandler(this.dgvAssign_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.groupBox1.Controls.Add(this.cbxCurso);
            this.groupBox1.Controls.Add(this.cbxDocente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbSemestre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAssign);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(564, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(364, 272);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(154)))), ((int)(((byte)(37)))));
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "DATA TO ASSIGN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Docente:";
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnAssign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(154)))), ((int)(((byte)(37)))));
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(62, 198);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(273, 27);
            this.btnAssign.TabIndex = 18;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Curso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(14, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Semestre:";
            // 
            // tbSemestre
            // 
            this.tbSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSemestre.Location = new System.Drawing.Point(132, 148);
            this.tbSemestre.Name = "tbSemestre";
            this.tbSemestre.Size = new System.Drawing.Size(203, 21);
            this.tbSemestre.TabIndex = 11;
            // 
            // cbxDocente
            // 
            this.cbxDocente.FormattingEnabled = true;
            this.cbxDocente.Location = new System.Drawing.Point(132, 81);
            this.cbxDocente.Name = "cbxDocente";
            this.cbxDocente.Size = new System.Drawing.Size(203, 21);
            this.cbxDocente.TabIndex = 20;
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(132, 115);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(203, 21);
            this.cbxCurso.TabIndex = 20;
            // 
            // FormDocentexCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(927, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearchByCourse);
            this.Controls.Add(this.btnUnassign);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchByTeacher);
            this.Controls.Add(this.dgvAssign);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDocentexCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDocentexCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssign)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchByCourse;
        private System.Windows.Forms.Button btnUnassign;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearchByTeacher;
        private System.Windows.Forms.DataGridView dgvAssign;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.ComboBox cbxDocente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSemestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAssign;
    }
}