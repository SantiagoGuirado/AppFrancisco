
namespace AppFrancisco
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuVer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVerClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVerMarcasTelefonos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVerModelosTelefonos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVerServiciosOfrecidos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVerTrabajosRealizados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregarNuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregarNuevaMarcaTelefono = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregarNuevoModeloTelefono = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregarNuevoServicioOfrecido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregarNuevoTrabajoRealizado = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVer,
            this.menuAgregar});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // menuVer
            // 
            this.menuVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVerClientes,
            this.menuVerMarcasTelefonos,
            this.menuVerModelosTelefonos,
            this.menuVerServiciosOfrecidos,
            this.menuVerTrabajosRealizados});
            this.menuVer.Name = "menuVer";
            this.menuVer.Size = new System.Drawing.Size(35, 20);
            this.menuVer.Text = "Ver";
            // 
            // menuVerClientes
            // 
            this.menuVerClientes.Name = "menuVerClientes";
            this.menuVerClientes.Size = new System.Drawing.Size(189, 22);
            this.menuVerClientes.Text = "Clientes";
            this.menuVerClientes.Click += new System.EventHandler(this.menuVerClientes_Click);
            // 
            // menuVerMarcasTelefonos
            // 
            this.menuVerMarcasTelefonos.Name = "menuVerMarcasTelefonos";
            this.menuVerMarcasTelefonos.Size = new System.Drawing.Size(189, 22);
            this.menuVerMarcasTelefonos.Text = "Marcas de Telefonos";
            this.menuVerMarcasTelefonos.Click += new System.EventHandler(this.menuVerMarcasTelefonos_Click);
            // 
            // menuVerModelosTelefonos
            // 
            this.menuVerModelosTelefonos.Name = "menuVerModelosTelefonos";
            this.menuVerModelosTelefonos.Size = new System.Drawing.Size(189, 22);
            this.menuVerModelosTelefonos.Text = "Modelos de Telefonos";
            this.menuVerModelosTelefonos.Click += new System.EventHandler(this.menuVerModelosTelefonos_Click);
            // 
            // menuVerServiciosOfrecidos
            // 
            this.menuVerServiciosOfrecidos.Name = "menuVerServiciosOfrecidos";
            this.menuVerServiciosOfrecidos.Size = new System.Drawing.Size(189, 22);
            this.menuVerServiciosOfrecidos.Text = "Servicios Ofrecidos";
            this.menuVerServiciosOfrecidos.Click += new System.EventHandler(this.menuVerServiciosOfrecidos_Click);
            // 
            // menuVerTrabajosRealizados
            // 
            this.menuVerTrabajosRealizados.Name = "menuVerTrabajosRealizados";
            this.menuVerTrabajosRealizados.Size = new System.Drawing.Size(189, 22);
            this.menuVerTrabajosRealizados.Text = "Trabajos Realizados";
            this.menuVerTrabajosRealizados.Click += new System.EventHandler(this.menuVerTrabajosRealizados_Click);
            // 
            // menuAgregar
            // 
            this.menuAgregar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgregarNuevoCliente,
            this.menuAgregarNuevaMarcaTelefono,
            this.menuAgregarNuevoModeloTelefono,
            this.menuAgregarNuevoServicioOfrecido,
            this.menuAgregarNuevoTrabajoRealizado});
            this.menuAgregar.Name = "menuAgregar";
            this.menuAgregar.Size = new System.Drawing.Size(61, 20);
            this.menuAgregar.Text = "Agregar";
            // 
            // menuAgregarNuevoCliente
            // 
            this.menuAgregarNuevoCliente.Name = "menuAgregarNuevoCliente";
            this.menuAgregarNuevoCliente.Size = new System.Drawing.Size(217, 22);
            this.menuAgregarNuevoCliente.Text = "Nuevo Cliente";
            // 
            // menuAgregarNuevaMarcaTelefono
            // 
            this.menuAgregarNuevaMarcaTelefono.Name = "menuAgregarNuevaMarcaTelefono";
            this.menuAgregarNuevaMarcaTelefono.Size = new System.Drawing.Size(217, 22);
            this.menuAgregarNuevaMarcaTelefono.Text = "Nueva Marca de Telefono";
            // 
            // menuAgregarNuevoModeloTelefono
            // 
            this.menuAgregarNuevoModeloTelefono.Name = "menuAgregarNuevoModeloTelefono";
            this.menuAgregarNuevoModeloTelefono.Size = new System.Drawing.Size(217, 22);
            this.menuAgregarNuevoModeloTelefono.Text = "Nuevo Modelo de Telefono";
            // 
            // menuAgregarNuevoServicioOfrecido
            // 
            this.menuAgregarNuevoServicioOfrecido.Name = "menuAgregarNuevoServicioOfrecido";
            this.menuAgregarNuevoServicioOfrecido.Size = new System.Drawing.Size(217, 22);
            this.menuAgregarNuevoServicioOfrecido.Text = "Nuevo Servicio Ofrecido";
            // 
            // menuAgregarNuevoTrabajoRealizado
            // 
            this.menuAgregarNuevoTrabajoRealizado.Name = "menuAgregarNuevoTrabajoRealizado";
            this.menuAgregarNuevoTrabajoRealizado.Size = new System.Drawing.Size(217, 22);
            this.menuAgregarNuevoTrabajoRealizado.Text = "Nuevo Trabajo Realizado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 360);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(446, 400);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(546, 399);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(656, 398);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Vista Principal";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuVer;
        private System.Windows.Forms.ToolStripMenuItem menuVerClientes;
        private System.Windows.Forms.ToolStripMenuItem menuVerMarcasTelefonos;
        private System.Windows.Forms.ToolStripMenuItem menuVerServiciosOfrecidos;
        private System.Windows.Forms.ToolStripMenuItem menuVerModelosTelefonos;
        private System.Windows.Forms.ToolStripMenuItem menuVerTrabajosRealizados;
        private System.Windows.Forms.ToolStripMenuItem menuAgregar;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarNuevoCliente;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarNuevaMarcaTelefono;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarNuevoModeloTelefono;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarNuevoServicioOfrecido;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarNuevoTrabajoRealizado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnImprimir;
    }
}

