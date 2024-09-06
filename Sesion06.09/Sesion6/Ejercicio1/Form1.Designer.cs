namespace Ejercicio1
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cmbNombres = new System.Windows.Forms.ComboBox();
            this.btnAgregar_Click = new System.Windows.Forms.Button();
            this.btnNombres2 = new System.Windows.Forms.Button();
            this.cmbNombres2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(206, 51);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(750, 44);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbNombres
            // 
            this.cmbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombres.FormattingEnabled = true;
            this.cmbNombres.Location = new System.Drawing.Point(206, 155);
            this.cmbNombres.Name = "cmbNombres";
            this.cmbNombres.Size = new System.Drawing.Size(750, 45);
            this.cmbNombres.TabIndex = 3;
            this.cmbNombres.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAgregar_Click
            // 
            this.btnAgregar_Click.Image = global::Ejercicio1.Properties.Resources.agregar_usuario;
            this.btnAgregar_Click.Location = new System.Drawing.Point(973, 51);
            this.btnAgregar_Click.Name = "btnAgregar_Click";
            this.btnAgregar_Click.Size = new System.Drawing.Size(66, 44);
            this.btnAgregar_Click.TabIndex = 2;
            this.btnAgregar_Click.UseVisualStyleBackColor = true;
            this.btnAgregar_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNombres2
            // 
            this.btnNombres2.Location = new System.Drawing.Point(206, 255);
            this.btnNombres2.Name = "btnNombres2";
            this.btnNombres2.Size = new System.Drawing.Size(750, 61);
            this.btnNombres2.TabIndex = 4;
            this.btnNombres2.Text = "Copiar";
            this.btnNombres2.UseVisualStyleBackColor = true;
            // 
            // cmbNombres2
            // 
            this.cmbNombres2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombres2.FormattingEnabled = true;
            this.cmbNombres2.Location = new System.Drawing.Point(206, 387);
            this.cmbNombres2.Name = "cmbNombres2";
            this.cmbNombres2.Size = new System.Drawing.Size(750, 45);
            this.cmbNombres2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 692);
            this.Controls.Add(this.cmbNombres2);
            this.Controls.Add(this.btnNombres2);
            this.Controls.Add(this.cmbNombres);
            this.Controls.Add(this.btnAgregar_Click);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnAgregar_Click;
        private System.Windows.Forms.ComboBox cmbNombres;
        private System.Windows.Forms.Button btnNombres2;
        private System.Windows.Forms.ComboBox cmbNombres2;
    }
}