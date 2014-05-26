namespace Proyecto_Infra
{
    partial class FormCrear
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelIdProceso = new System.Windows.Forms.Label();
            this.labelTipoProceso = new System.Windows.Forms.Label();
            this.textBoxNombreProceso = new System.Windows.Forms.TextBox();
            this.textBoxIdProceso = new System.Windows.Forms.TextBox();
            this.comboTipoProceso = new System.Windows.Forms.ComboBox();
            this.buttonCrearProceso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombre.Location = new System.Drawing.Point(1, 19);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(142, 15);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre del Proceso:";
            // 
            // labelIdProceso
            // 
            this.labelIdProceso.AutoSize = true;
            this.labelIdProceso.BackColor = System.Drawing.Color.Transparent;
            this.labelIdProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelIdProceso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelIdProceso.Location = new System.Drawing.Point(40, 85);
            this.labelIdProceso.Name = "labelIdProceso";
            this.labelIdProceso.Size = new System.Drawing.Size(103, 15);
            this.labelIdProceso.TabIndex = 1;
            this.labelIdProceso.Text = "Id del Proceso:";
            // 
            // labelTipoProceso
            // 
            this.labelTipoProceso.AutoSize = true;
            this.labelTipoProceso.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelTipoProceso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTipoProceso.Location = new System.Drawing.Point(28, 155);
            this.labelTipoProceso.Name = "labelTipoProceso";
            this.labelTipoProceso.Size = new System.Drawing.Size(115, 15);
            this.labelTipoProceso.TabIndex = 2;
            this.labelTipoProceso.Text = "Tipo de Proceso:";
            // 
            // textBoxNombreProceso
            // 
            this.textBoxNombreProceso.Location = new System.Drawing.Point(149, 19);
            this.textBoxNombreProceso.Name = "textBoxNombreProceso";
            this.textBoxNombreProceso.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreProceso.TabIndex = 7;
            this.textBoxNombreProceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreProceso_KeyPress);
            // 
            // textBoxIdProceso
            // 
            this.textBoxIdProceso.Location = new System.Drawing.Point(149, 84);
            this.textBoxIdProceso.Name = "textBoxIdProceso";
            this.textBoxIdProceso.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdProceso.TabIndex = 4;
            this.textBoxIdProceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdProceso_KeyPress);
            // 
            // comboTipoProceso
            // 
            this.comboTipoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoProceso.FormattingEnabled = true;
            this.comboTipoProceso.Items.AddRange(new object[] {
            "Emisor",
            "Receptor"});
            this.comboTipoProceso.Location = new System.Drawing.Point(149, 155);
            this.comboTipoProceso.Name = "comboTipoProceso";
            this.comboTipoProceso.Size = new System.Drawing.Size(100, 21);
            this.comboTipoProceso.TabIndex = 5;
            // 
            // buttonCrearProceso
            // 
            this.buttonCrearProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearProceso.Location = new System.Drawing.Point(86, 218);
            this.buttonCrearProceso.Name = "buttonCrearProceso";
            this.buttonCrearProceso.Size = new System.Drawing.Size(105, 31);
            this.buttonCrearProceso.TabIndex = 6;
            this.buttonCrearProceso.Text = "Crear Proceso";
            this.buttonCrearProceso.UseVisualStyleBackColor = true;
            this.buttonCrearProceso.Click += new System.EventHandler(this.buttonCrearProceso_Click);
            // 
            // FormCrear
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::Proyecto_Infra.Properties.Resources.img_config;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCrearProceso);
            this.Controls.Add(this.comboTipoProceso);
            this.Controls.Add(this.textBoxIdProceso);
            this.Controls.Add(this.textBoxNombreProceso);
            this.Controls.Add(this.labelTipoProceso);
            this.Controls.Add(this.labelIdProceso);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormCrear";
            this.Text = "Crear Proceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelIdProceso;
        private System.Windows.Forms.Label labelTipoProceso;
        private System.Windows.Forms.TextBox textBoxNombreProceso;
        private System.Windows.Forms.TextBox textBoxIdProceso;
        private System.Windows.Forms.ComboBox comboTipoProceso;
        private System.Windows.Forms.Button buttonCrearProceso;
    }
}