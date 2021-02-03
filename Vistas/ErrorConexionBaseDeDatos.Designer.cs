
namespace AppFrancisco
{
    partial class ErrorConexionBaseDeDatos
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
            this.lbMensajeError = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReintentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMensajeError
            // 
            this.lbMensajeError.AutoSize = true;
            this.lbMensajeError.Location = new System.Drawing.Point(46, 46);
            this.lbMensajeError.Name = "lbMensajeError";
            this.lbMensajeError.Size = new System.Drawing.Size(287, 13);
            this.lbMensajeError.TabIndex = 0;
            this.lbMensajeError.Text = "Ocurrio un error al intertar conectarse con la base de datos!";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(61, 117);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReintentar
            // 
            this.btnReintentar.Location = new System.Drawing.Point(224, 117);
            this.btnReintentar.Name = "btnReintentar";
            this.btnReintentar.Size = new System.Drawing.Size(75, 23);
            this.btnReintentar.TabIndex = 2;
            this.btnReintentar.Text = "Reintentar";
            this.btnReintentar.UseVisualStyleBackColor = true;
            this.btnReintentar.Click += new System.EventHandler(this.btnReintentar_Click);
            // 
            // ErrorConexionBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 176);
            this.Controls.Add(this.btnReintentar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbMensajeError);
            this.Name = "ErrorConexionBaseDeDatos";
            this.Text = "ErrorConexionBaseDeDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMensajeError;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReintentar;
    }
}