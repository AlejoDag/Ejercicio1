namespace Facultad
{
    partial class FormEmpleado
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
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.elegirFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Roles = new System.Windows.Forms.ListBox();
            this.SelectRol = new System.Windows.Forms.Button();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legajo:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(160, 44);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 1;
            this.txtLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajo_KeyPress);
            // 
            // elegirFechaIngreso
            // 
            this.elegirFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.elegirFechaIngreso.Location = new System.Drawing.Point(160, 76);
            this.elegirFechaIngreso.Name = "elegirFechaIngreso";
            this.elegirFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.elegirFechaIngreso.TabIndex = 1;
            this.elegirFechaIngreso.Value = new System.DateTime(2025, 3, 28, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de ingreso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol:";
            // 
            // Roles
            // 
            this.Roles.FormattingEnabled = true;
            this.Roles.Items.AddRange(new object[] {
            "Directivo",
            "Docente",
            "Bedel"});
            this.Roles.Location = new System.Drawing.Point(270, 133);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(100, 43);
            this.Roles.TabIndex = 3;
            // 
            // SelectRol
            // 
            this.SelectRol.Location = new System.Drawing.Point(270, 108);
            this.SelectRol.Name = "SelectRol";
            this.SelectRol.Size = new System.Drawing.Size(100, 20);
            this.SelectRol.TabIndex = 4;
            this.SelectRol.Text = "Seleccionar";
            this.SelectRol.UseVisualStyleBackColor = true;
            this.SelectRol.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // txtRol
            // 
            this.txtRol.Enabled = false;
            this.txtRol.Location = new System.Drawing.Point(160, 108);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(100, 20);
            this.txtRol.TabIndex = 5;
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 278);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.SelectRol);
            this.Controls.Add(this.Roles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.elegirFechaIngreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.label1);
            this.Name = "FormEmpleado";
            this.Text = "FormEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.DateTimePicker elegirFechaIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Roles;
        private System.Windows.Forms.Button SelectRol;
        private System.Windows.Forms.TextBox txtRol;
    }
}