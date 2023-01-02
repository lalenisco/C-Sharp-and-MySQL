namespace Crud_Tienda
{
    partial class Form1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_Existencias = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.btn_buscar);
            this.groupBox3.Controls.Add(this.txt_Existencias);
            this.groupBox3.Controls.Add(this.txt_Precio);
            this.groupBox3.Controls.Add(this.txt_Descripcion);
            this.groupBox3.Controls.Add(this.txt_Nombre);
            this.groupBox3.Controls.Add(this.txt_Codigo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(45, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(908, 520);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de producto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 52);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(604, 372);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(258, 49);
            this.txtId.TabIndex = 11;
            this.txtId.Visible = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(648, 71);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(214, 48);
            this.btn_buscar.TabIndex = 10;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_Existencias
            // 
            this.txt_Existencias.Location = new System.Drawing.Point(271, 445);
            this.txt_Existencias.Multiline = true;
            this.txt_Existencias.Name = "txt_Existencias";
            this.txt_Existencias.Size = new System.Drawing.Size(325, 49);
            this.txt_Existencias.TabIndex = 9;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(271, 372);
            this.txt_Precio.Multiline = true;
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(325, 49);
            this.txt_Precio.TabIndex = 8;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(271, 220);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(591, 119);
            this.txt_Descripcion.TabIndex = 7;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(271, 152);
            this.txt_Nombre.Multiline = true;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(319, 42);
            this.txt_Nombre.TabIndex = 6;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(271, 77);
            this.txt_Codigo.Multiline = true;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(320, 42);
            this.txt_Codigo.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 32);
            this.label10.TabIndex = 4;
            this.label10.Text = "Existencias:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Precio Público:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(45, 584);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(204, 48);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(278, 584);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(204, 48);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(518, 584);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(202, 48);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(752, 584);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(201, 48);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(56, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 51);
            this.button6.TabIndex = 13;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(986, 660);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.TextBox txtPrecioPublico;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_Existencias;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
    }
}

