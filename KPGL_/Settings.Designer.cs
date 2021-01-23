
namespace KPGL_
{
    partial class Settings
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
            this.Settings_grpbox = new System.Windows.Forms.GroupBox();
            this.iterations_lbl = new System.Windows.Forms.Label();
            this.Iteration_txtbox = new System.Windows.Forms.TextBox();
            this.Paint_Of_Fractal = new System.Windows.Forms.PictureBox();
            this.Settings_grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paint_Of_Fractal)).BeginInit();
            this.SuspendLayout();
            // 
            // Settings_grpbox
            // 
            this.Settings_grpbox.Controls.Add(this.iterations_lbl);
            this.Settings_grpbox.Controls.Add(this.Iteration_txtbox);
            this.Settings_grpbox.Controls.Add(this.Paint_Of_Fractal);
            this.Settings_grpbox.Location = new System.Drawing.Point(12, 12);
            this.Settings_grpbox.Name = "Settings_grpbox";
            this.Settings_grpbox.Size = new System.Drawing.Size(183, 122);
            this.Settings_grpbox.TabIndex = 1;
            this.Settings_grpbox.TabStop = false;
            this.Settings_grpbox.Text = "Settings";
            // 
            // iterations_lbl
            // 
            this.iterations_lbl.AutoSize = true;
            this.iterations_lbl.Location = new System.Drawing.Point(6, 25);
            this.iterations_lbl.Name = "iterations_lbl";
            this.iterations_lbl.Size = new System.Drawing.Size(50, 13);
            this.iterations_lbl.TabIndex = 4;
            this.iterations_lbl.Text = "Iterations";
            // 
            // Iteration_txtbox
            // 
            this.Iteration_txtbox.Location = new System.Drawing.Point(6, 41);
            this.Iteration_txtbox.Name = "Iteration_txtbox";
            this.Iteration_txtbox.Size = new System.Drawing.Size(100, 20);
            this.Iteration_txtbox.TabIndex = 3;
            // 
            // Paint_Of_Fractal
            // 
            this.Paint_Of_Fractal.Location = new System.Drawing.Point(0, 121);
            this.Paint_Of_Fractal.Name = "Paint_Of_Fractal";
            this.Paint_Of_Fractal.Size = new System.Drawing.Size(1246, 495);
            this.Paint_Of_Fractal.TabIndex = 2;
            this.Paint_Of_Fractal.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 146);
            this.Controls.Add(this.Settings_grpbox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Settings_grpbox.ResumeLayout(false);
            this.Settings_grpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paint_Of_Fractal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Settings_grpbox;
        private System.Windows.Forms.Label iterations_lbl;
        private System.Windows.Forms.TextBox Iteration_txtbox;
        private System.Windows.Forms.PictureBox Paint_Of_Fractal;
    }
}