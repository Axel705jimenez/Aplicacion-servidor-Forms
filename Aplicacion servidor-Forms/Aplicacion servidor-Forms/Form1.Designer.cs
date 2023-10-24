namespace Aplicacion_servidor_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciarServidor = new Button();
            lblestatus = new Label();
            lstbDatos = new ListBox();
            SuspendLayout();
            // 
            // btnIniciarServidor
            // 
            btnIniciarServidor.Location = new Point(137, 12);
            btnIniciarServidor.Name = "btnIniciarServidor";
            btnIniciarServidor.Size = new Size(122, 23);
            btnIniciarServidor.TabIndex = 1;
            btnIniciarServidor.Text = "INICIAR SERVIDOR";
            btnIniciarServidor.UseVisualStyleBackColor = true;
            btnIniciarServidor.Click += btnIniciarServidor_Click;
            // 
            // lblestatus
            // 
            lblestatus.AutoSize = true;
            lblestatus.Location = new Point(249, 306);
            lblestatus.Name = "lblestatus";
            lblestatus.Size = new Size(10, 15);
            lblestatus.TabIndex = 2;
            lblestatus.Text = " ";
            // 
            // lstbDatos
            // 
            lstbDatos.FormattingEnabled = true;
            lstbDatos.ItemHeight = 15;
            lstbDatos.Location = new Point(12, 44);
            lstbDatos.Name = "lstbDatos";
            lstbDatos.Size = new Size(378, 259);
            lstbDatos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 329);
            Controls.Add(lstbDatos);
            Controls.Add(lblestatus);
            Controls.Add(btnIniciarServidor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIniciarServidor;
        private Label lblestatus;
        private ListBox lstbDatos;
    }
}