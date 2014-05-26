namespace Proyecto_Infra
{
    partial class FormGrupo
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
            this.textBoxNombreGrupo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCrearProceso = new System.Windows.Forms.Button();
            this.textBoxIdProcesoGrupo = new System.Windows.Forms.TextBox();
            this.textBoxNombreProcesoGrupo = new System.Windows.Forms.TextBox();
            this.labelTipoProceso = new System.Windows.Forms.Label();
            this.labelIdProceso = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Grupo:";
            // 
            // textBoxNombreGrupo
            // 
            this.textBoxNombreGrupo.Location = new System.Drawing.Point(127, 32);
            this.textBoxNombreGrupo.Name = "textBoxNombreGrupo";
            this.textBoxNombreGrupo.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreGrupo.TabIndex = 1;
            this.textBoxNombreGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreGrupo_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNombreGrupo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 248);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.buttonCrearProceso);
            this.groupBox2.Controls.Add(this.textBoxIdProcesoGrupo);
            this.groupBox2.Controls.Add(this.textBoxNombreProcesoGrupo);
            this.groupBox2.Controls.Add(this.labelTipoProceso);
            this.groupBox2.Controls.Add(this.labelIdProceso);
            this.groupBox2.Controls.Add(this.labelNombre);
            this.groupBox2.Location = new System.Drawing.Point(303, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 239);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // buttonCrearProceso
            // 
            this.buttonCrearProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearProceso.Location = new System.Drawing.Point(86, 208);
            this.buttonCrearProceso.Name = "buttonCrearProceso";
            this.buttonCrearProceso.Size = new System.Drawing.Size(105, 31);
            this.buttonCrearProceso.TabIndex = 13;
            this.buttonCrearProceso.Text = "Finalizar";
            this.buttonCrearProceso.UseVisualStyleBackColor = true;
            this.buttonCrearProceso.Click += new System.EventHandler(this.buttonCrearProceso_Click);
            // 
            // textBoxIdProcesoGrupo
            // 
            this.textBoxIdProcesoGrupo.Location = new System.Drawing.Point(149, 78);
            this.textBoxIdProcesoGrupo.Name = "textBoxIdProcesoGrupo";
            this.textBoxIdProcesoGrupo.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdProcesoGrupo.TabIndex = 11;
            this.textBoxIdProcesoGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdProcesoGrupo_KeyPress);
            // 
            // textBoxNombreProcesoGrupo
            // 
            this.textBoxNombreProcesoGrupo.Location = new System.Drawing.Point(149, 14);
            this.textBoxNombreProcesoGrupo.Name = "textBoxNombreProcesoGrupo";
            this.textBoxNombreProcesoGrupo.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreProcesoGrupo.TabIndex = 14;
            this.textBoxNombreProcesoGrupo.TextChanged += new System.EventHandler(this.textBoxNombreProcesoGrupo_TextChanged);
            this.textBoxNombreProcesoGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreProcesoGrupo_KeyPress);
            // 
            // labelTipoProceso
            // 
            this.labelTipoProceso.AutoSize = true;
            this.labelTipoProceso.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelTipoProceso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTipoProceso.Location = new System.Drawing.Point(1, 157);
            this.labelTipoProceso.Name = "labelTipoProceso";
            this.labelTipoProceso.Size = new System.Drawing.Size(50, 15);
            this.labelTipoProceso.TabIndex = 10;
            this.labelTipoProceso.Text = "Grupo:";
            // 
            // labelIdProceso
            // 
            this.labelIdProceso.AutoSize = true;
            this.labelIdProceso.BackColor = System.Drawing.Color.Transparent;
            this.labelIdProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelIdProceso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelIdProceso.Location = new System.Drawing.Point(6, 79);
            this.labelIdProceso.Name = "labelIdProceso";
            this.labelIdProceso.Size = new System.Drawing.Size(103, 15);
            this.labelIdProceso.TabIndex = 9;
            this.labelIdProceso.Text = "Id del Proceso:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNombre.Location = new System.Drawing.Point(1, 14);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(142, 15);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre del Proceso:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // FormGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGrupo";
            this.Text = "Creacion de Grupo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreGrupo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCrearProceso;
        private System.Windows.Forms.TextBox textBoxIdProcesoGrupo;
        private System.Windows.Forms.TextBox textBoxNombreProcesoGrupo;
        private System.Windows.Forms.Label labelTipoProceso;
        private System.Windows.Forms.Label labelIdProceso;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}