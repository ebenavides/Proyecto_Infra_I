namespace WindowsFormsApplication2
{
 
    partial class ConfigWindow
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sincronizacion = new System.Windows.Forms.Label();
            this.Direccionamiento = new System.Windows.Forms.Label();
            this.comboDirecto = new System.Windows.Forms.ComboBox();
            this.comboContenido = new System.Windows.Forms.ComboBox();
            this.comboSend = new System.Windows.Forms.ComboBox();
            this.comboRecive = new System.Windows.Forms.ComboBox();
            this.comboIndirecto = new System.Windows.Forms.ComboBox();
            this.labelSend = new System.Windows.Forms.Label();
            this.labelRecive = new System.Windows.Forms.Label();
            this.labelContenido = new System.Windows.Forms.Label();
            this.labelLargo = new System.Windows.Forms.Label();
            this.labelColas = new System.Windows.Forms.Label();
            this.labelFormato = new System.Windows.Forms.Label();
            this.checkDirecto = new System.Windows.Forms.CheckBox();
            this.checkIndirecto = new System.Windows.Forms.CheckBox();
            this.checkFijo = new System.Windows.Forms.CheckBox();
            this.checkVariable = new System.Windows.Forms.CheckBox();
            this.checkFIFO = new System.Windows.Forms.CheckBox();
            this.checkPrioridad = new System.Windows.Forms.CheckBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sincronizacion
            // 
            this.Sincronizacion.AutoSize = true;
            this.Sincronizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sincronizacion.Location = new System.Drawing.Point(12, 9);
            this.Sincronizacion.Name = "Sincronizacion";
            this.Sincronizacion.Size = new System.Drawing.Size(109, 16);
            this.Sincronizacion.TabIndex = 0;
            this.Sincronizacion.Text = "Sincronización";
             // 
            // Direccionamiento
            // 
            this.Direccionamiento.AutoSize = true;
            this.Direccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccionamiento.Location = new System.Drawing.Point(6, 12);
            this.Direccionamiento.Name = "Direccionamiento";
            this.Direccionamiento.Size = new System.Drawing.Size(129, 16);
            this.Direccionamiento.TabIndex = 1;
            this.Direccionamiento.Text = "Direccionamiento";
            // 
            // comboDirecto
            // 
            this.comboDirecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDirecto.FormattingEnabled = true;
            this.comboDirecto.Items.AddRange(new object[] {
            "Explicito",
            "Implicito"});
            this.comboDirecto.Location = new System.Drawing.Point(260, 12);
            this.comboDirecto.Name = "comboDirecto";
            this.comboDirecto.Size = new System.Drawing.Size(121, 21);
            this.comboDirecto.TabIndex = 4;
            // 
            // comboContenido
            // 
            this.comboContenido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContenido.FormattingEnabled = true;
            this.comboContenido.Items.AddRange(new object[] {
            "Video",
            "Imagen",
            "Audio"});
            this.comboContenido.Location = new System.Drawing.Point(260, 19);
            this.comboContenido.Name = "comboContenido";
            this.comboContenido.Size = new System.Drawing.Size(121, 21);
            this.comboContenido.TabIndex = 5;
            
            // 
            // comboSend
            // 
            this.comboSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSend.FormattingEnabled = true;
            this.comboSend.Items.AddRange(new object[] {
            "Blocking",
            "NonBlocking"});
            this.comboSend.Location = new System.Drawing.Point(260, 9);
            this.comboSend.Name = "comboSend";
            this.comboSend.Size = new System.Drawing.Size(121, 21);
            this.comboSend.TabIndex = 6;
           
            // 
            // comboRecive
            // 
            this.comboRecive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRecive.FormattingEnabled = true;
            this.comboRecive.Items.AddRange(new object[] {
            "Blocking",
            "NonBlocking",
            "Prueba de llegada"});
            this.comboRecive.Location = new System.Drawing.Point(260, 48);
            this.comboRecive.Name = "comboRecive";
            this.comboRecive.Size = new System.Drawing.Size(121, 21);
            this.comboRecive.TabIndex = 7;
            
            // 
            // comboIndirecto
            // 
            this.comboIndirecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIndirecto.FormattingEnabled = true;
            this.comboIndirecto.Items.AddRange(new object[] {
            "Estatico",
            "Dinamico"});
            this.comboIndirecto.Location = new System.Drawing.Point(260, 55);
            this.comboIndirecto.Name = "comboIndirecto";
            this.comboIndirecto.Size = new System.Drawing.Size(121, 21);
            this.comboIndirecto.TabIndex = 8;
            
            // 
            // labelSend
            // 
            this.labelSend.AutoSize = true;
            this.labelSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSend.Location = new System.Drawing.Point(207, 11);
            this.labelSend.Name = "labelSend";
            this.labelSend.Size = new System.Drawing.Size(36, 15);
            this.labelSend.TabIndex = 9;
            this.labelSend.Text = "Send";
            
            // 
            // labelRecive
            // 
            this.labelRecive.AutoSize = true;
            this.labelRecive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecive.Location = new System.Drawing.Point(198, 51);
            this.labelRecive.Name = "labelRecive";
            this.labelRecive.Size = new System.Drawing.Size(44, 15);
            this.labelRecive.TabIndex = 10;
            this.labelRecive.Text = "Recive";
            // 
            // labelContenido
            // 
            this.labelContenido.AutoSize = true;
            this.labelContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelContenido.Location = new System.Drawing.Point(180, 25);
            this.labelContenido.Name = "labelContenido";
            this.labelContenido.Size = new System.Drawing.Size(63, 15);
            this.labelContenido.TabIndex = 13;
            this.labelContenido.Text = "Contenido";
            // 
            // labelLargo
            // 
            this.labelLargo.AutoSize = true;
            this.labelLargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelLargo.Location = new System.Drawing.Point(195, 73);
            this.labelLargo.Name = "labelLargo";
            this.labelLargo.Size = new System.Drawing.Size(39, 15);
            this.labelLargo.TabIndex = 14;
            this.labelLargo.Text = "Largo";
            // 
            // labelColas
            // 
            this.labelColas.AutoSize = true;
            this.labelColas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColas.Location = new System.Drawing.Point(6, 12);
            this.labelColas.Name = "labelColas";
            this.labelColas.Size = new System.Drawing.Size(99, 16);
            this.labelColas.TabIndex = 17;
            this.labelColas.Text = "ManejoColas";
            
            // 
            // labelFormato
            // 
            this.labelFormato.AutoSize = true;
            this.labelFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormato.Location = new System.Drawing.Point(12, 19);
            this.labelFormato.Name = "labelFormato";
            this.labelFormato.Size = new System.Drawing.Size(65, 16);
            this.labelFormato.TabIndex = 20;
            this.labelFormato.Text = "Formato";
            // 
            // checkDirecto
            // 
            this.checkDirecto.AutoSize = true;
            this.checkDirecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDirecto.Location = new System.Drawing.Point(177, 12);
            this.checkDirecto.Name = "checkDirecto";
            this.checkDirecto.Size = new System.Drawing.Size(65, 19);
            this.checkDirecto.TabIndex = 21;
            this.checkDirecto.Text = "Directo";
            this.checkDirecto.UseVisualStyleBackColor = true;
            this.checkDirecto.CheckedChanged += new System.EventHandler(this.checkDirecto_CheckedChanged);
            // 
            // checkIndirecto
            // 
            this.checkIndirecto.AutoSize = true;
            this.checkIndirecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkIndirecto.Location = new System.Drawing.Point(177, 53);
            this.checkIndirecto.Name = "checkIndirecto";
            this.checkIndirecto.Size = new System.Drawing.Size(73, 19);
            this.checkIndirecto.TabIndex = 22;
            this.checkIndirecto.Text = "Indirecto";
            this.checkIndirecto.UseVisualStyleBackColor = true;
            this.checkIndirecto.CheckedChanged += new System.EventHandler(this.checkIndirecto_CheckedChanged);
            // 
            // checkFijo
            // 
            this.checkFijo.AutoSize = true;
            this.checkFijo.BackColor = System.Drawing.Color.Transparent;
            this.checkFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkFijo.Location = new System.Drawing.Point(260, 60);
            this.checkFijo.Name = "checkFijo";
            this.checkFijo.Size = new System.Drawing.Size(46, 19);
            this.checkFijo.TabIndex = 23;
            this.checkFijo.Text = "Fijo";
            this.checkFijo.UseVisualStyleBackColor = false;
            this.checkFijo.CheckedChanged += new System.EventHandler(this.checkFijo_CheckedChanged);
            // 
            // checkVariable
            // 
            this.checkVariable.AutoSize = true;
            this.checkVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkVariable.Location = new System.Drawing.Point(260, 84);
            this.checkVariable.Name = "checkVariable";
            this.checkVariable.Size = new System.Drawing.Size(71, 19);
            this.checkVariable.TabIndex = 24;
            this.checkVariable.Text = "Variable";
            this.checkVariable.UseVisualStyleBackColor = true;
            this.checkVariable.CheckedChanged += new System.EventHandler(this.checkVariable_CheckedChanged);
            // 
            // checkFIFO
            // 
            this.checkFIFO.AutoSize = true;
            this.checkFIFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkFIFO.Location = new System.Drawing.Point(192, 29);
            this.checkFIFO.Name = "checkFIFO";
            this.checkFIFO.Size = new System.Drawing.Size(52, 19);
            this.checkFIFO.TabIndex = 25;
            this.checkFIFO.Text = "FIFO";
            this.checkFIFO.UseVisualStyleBackColor = true;
            this.checkFIFO.CheckedChanged += new System.EventHandler(this.checkFIFO_CheckedChanged);
            // 
            // checkPrioridad
            // 
            this.checkPrioridad.AutoSize = true;
            this.checkPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkPrioridad.Location = new System.Drawing.Point(192, 52);
            this.checkPrioridad.Name = "checkPrioridad";
            this.checkPrioridad.Size = new System.Drawing.Size(76, 19);
            this.checkPrioridad.TabIndex = 26;
            this.checkPrioridad.Text = "Prioridad";
            this.checkPrioridad.UseVisualStyleBackColor = true;
            this.checkPrioridad.CheckedChanged += new System.EventHandler(this.checkPrioridad_CheckedChanged);
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonIniciar.Location = new System.Drawing.Point(300, 38);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(91, 31);
            this.buttonIniciar.TabIndex = 27;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkIndirecto);
            this.groupBox1.Controls.Add(this.checkDirecto);
            this.groupBox1.Controls.Add(this.comboIndirecto);
            this.groupBox1.Controls.Add(this.comboDirecto);
            this.groupBox1.Controls.Add(this.Direccionamiento);
            this.groupBox1.Location = new System.Drawing.Point(11, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 86);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.checkVariable);
            this.groupBox2.Controls.Add(this.checkFijo);
            this.groupBox2.Controls.Add(this.labelFormato);
            this.groupBox2.Controls.Add(this.labelLargo);
            this.groupBox2.Controls.Add(this.labelContenido);
            this.groupBox2.Controls.Add(this.comboContenido);
            this.groupBox2.Location = new System.Drawing.Point(11, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 112);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.buttonIniciar);
            this.groupBox3.Controls.Add(this.checkPrioridad);
            this.groupBox3.Controls.Add(this.checkFIFO);
            this.groupBox3.Controls.Add(this.labelColas);
            this.groupBox3.Location = new System.Drawing.Point(11, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 105);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.labelRecive);
            this.groupBox4.Controls.Add(this.labelSend);
            this.groupBox4.Controls.Add(this.comboRecive);
            this.groupBox4.Controls.Add(this.comboSend);
            this.groupBox4.Controls.Add(this.Sincronizacion);
            this.groupBox4.Location = new System.Drawing.Point(11, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(426, 73);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Largo de la Cola";
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Proyecto_Infra_App.Properties.Resources.config_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 419);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigWindow";
            this.Text = "Infraestructura Tecnológica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Sincronizacion;
        private System.Windows.Forms.Label Direccionamiento;
        private System.Windows.Forms.ComboBox comboDirecto;
        private System.Windows.Forms.ComboBox comboContenido;
        private System.Windows.Forms.ComboBox comboSend;
        private System.Windows.Forms.ComboBox comboRecive;
        private System.Windows.Forms.ComboBox comboIndirecto;
        private System.Windows.Forms.Label labelSend;
        private System.Windows.Forms.Label labelRecive;
        private System.Windows.Forms.Label labelContenido;
        private System.Windows.Forms.Label labelLargo;
        private System.Windows.Forms.Label labelColas;
        private System.Windows.Forms.Label labelFormato;
        private System.Windows.Forms.CheckBox checkDirecto;
        private System.Windows.Forms.CheckBox checkIndirecto;
        private System.Windows.Forms.CheckBox checkFijo;
        private System.Windows.Forms.CheckBox checkVariable;
        private System.Windows.Forms.CheckBox checkFIFO;
        private System.Windows.Forms.CheckBox checkPrioridad;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

