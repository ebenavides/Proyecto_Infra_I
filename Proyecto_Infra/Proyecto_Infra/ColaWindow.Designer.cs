namespace Proyecto_Infra
{
    partial class ColaWindow
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
            this.ColaBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ColaBox
            // 
            this.ColaBox.FormattingEnabled = true;
            this.ColaBox.Location = new System.Drawing.Point(4, 8);
            this.ColaBox.Name = "ColaBox";
            this.ColaBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ColaBox.Size = new System.Drawing.Size(117, 134);
            this.ColaBox.TabIndex = 0;
            // 
            // ColaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 145);
            this.Controls.Add(this.ColaBox);
            this.Name = "ColaWindow";
            this.Text = "ColaWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ColaBox;
    }
}