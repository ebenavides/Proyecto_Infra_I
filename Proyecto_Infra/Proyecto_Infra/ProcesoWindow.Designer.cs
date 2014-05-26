namespace Proyecto_Infra
{
    partial class ProcesoWindow
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
            this.lb_process = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_process
            // 
            this.lb_process.FormattingEnabled = true;
            this.lb_process.Location = new System.Drawing.Point(3, 4);
            this.lb_process.Name = "lb_process";
            this.lb_process.Size = new System.Drawing.Size(210, 82);
            this.lb_process.TabIndex = 0;
            
            // 
            // ProcesoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 88);
            this.Controls.Add(this.lb_process);
            this.Name = "ProcesoWindow";
            this.Text = "<Default>";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_process;
    }
}