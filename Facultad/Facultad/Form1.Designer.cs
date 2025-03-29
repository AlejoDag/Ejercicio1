namespace Facultad
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtFechaNac = new System.Windows.Forms.Label();
            this.elegirFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(160, 76);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 0;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.AutoSize = true;
            this.txtFechaNac.Location = new System.Drawing.Point(36, 116);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(109, 13);
            this.txtFechaNac.TabIndex = 1;
            this.txtFechaNac.Text = "Fecha de nacimiento:";
            // 
            // elegirFechaNac
            // 
            this.elegirFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.elegirFechaNac.Location = new System.Drawing.Point(160, 110);
            this.elegirFechaNac.Name = "elegirFechaNac";
            this.elegirFechaNac.Size = new System.Drawing.Size(100, 20);
            this.elegirFechaNac.TabIndex = 4;
            this.elegirFechaNac.Value = new System.DateTime(2025, 3, 28, 0, 0, 0, 0);
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(160, 150);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(100, 25);
            this.btnSaludar.TabIndex = 2;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 281);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.elegirFechaNac);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label txtFechaNac;
        private System.Windows.Forms.DateTimePicker elegirFechaNac;
        private System.Windows.Forms.Button btnSaludar;
    }
}