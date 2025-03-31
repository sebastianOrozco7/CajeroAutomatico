namespace CajeroAutomatico.VISTA
{
    partial class FrmUsuario
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
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.btnConsultarSaldo = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.grpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOpciones
            // 
            this.grpOpciones.Controls.Add(this.btnDepositar);
            this.grpOpciones.Controls.Add(this.btnRetirar);
            this.grpOpciones.Controls.Add(this.btnConsultarSaldo);
            this.grpOpciones.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpciones.Location = new System.Drawing.Point(12, 33);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(178, 174);
            this.grpOpciones.TabIndex = 0;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "OPCIONES";
            // 
            // btnConsultarSaldo
            // 
            this.btnConsultarSaldo.Location = new System.Drawing.Point(6, 38);
            this.btnConsultarSaldo.Name = "btnConsultarSaldo";
            this.btnConsultarSaldo.Size = new System.Drawing.Size(135, 33);
            this.btnConsultarSaldo.TabIndex = 0;
            this.btnConsultarSaldo.Text = "Consultar saldo";
            this.btnConsultarSaldo.UseVisualStyleBackColor = true;
            this.btnConsultarSaldo.Click += new System.EventHandler(this.btnConsultarSaldo_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(6, 77);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(88, 35);
            this.btnRetirar.TabIndex = 0;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(6, 118);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(88, 34);
            this.btnDepositar.TabIndex = 0;
            this.btnDepositar.Text = "Deposito";
            this.btnDepositar.UseVisualStyleBackColor = true;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpOpciones);
            this.Name = "FrmUsuario";
            this.Text = "UsuarioForm";
            this.grpOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnConsultarSaldo;
    }
}