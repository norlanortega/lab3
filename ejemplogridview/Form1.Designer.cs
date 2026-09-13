namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Variable requerida por el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos utilizados.
        /// </summary>
        /// <param name="disposing">true si se deben liberar recursos administrados.</param>
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
        /// Método requerido para admitir el Diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();

            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtSalario = new System.Windows.Forms.TextBox();

            this.dgvDatos = new System.Windows.Forms.DataGridView();

            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();

            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();

            this.SuspendLayout();

            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(50, 70);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID empleado:";

            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";

            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(50, 170);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";

            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(50, 220);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(65, 20);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo:";

            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(50, 270);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(145, 20);
            this.lblFechaNac.TabIndex = 4;
            this.lblFechaNac.Text = "Fecha nacimiento:";

            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(50, 320);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(65, 20);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salario:";

            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(210, 67);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 26);
            this.txtId.TabIndex = 6;

            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(210, 117);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 26);
            this.txtNombre.TabIndex = 7;

            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(210, 167);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 26);
            this.txtApellido.TabIndex = 8;

            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(210, 217);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 26);
            this.txtCorreo.TabIndex = 9;

            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(210, 267);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaNac.TabIndex = 10;

            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(210, 317);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(200, 26);
            this.txtSalario.TabIndex = 11;

            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(450, 67);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(700, 350);
            this.dgvDatos.TabIndex = 12;

            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.toolStripButton1
            });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 33);
            this.toolStrip1.TabIndex = 13;

            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 28);
            this.toolStripButton1.Text = "Guardar";
            this.toolStripButton1.Click +=
                new System.EventHandler(this.toolStripButton1_Click);

            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;

            // 
            // Form1
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1200, 500);

            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDatos);

            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);

            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);

            this.Name = "Form1";
            this.Text = "Registro de Personas";

            this.Load +=
                new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblSalario;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtSalario;

        private System.Windows.Forms.DataGridView dgvDatos;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}