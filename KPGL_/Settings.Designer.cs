
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
            this.timer_lbl = new System.Windows.Forms.Label();
            this.timer_tick_txtbox = new System.Windows.Forms.TextBox();
            this.Import_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.iterations_lbl = new System.Windows.Forms.Label();
            this.Iteration_txtbox = new System.Windows.Forms.TextBox();
            this.Paint_Of_Fractal = new System.Windows.Forms.PictureBox();
            this.Settings_grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paint_Of_Fractal)).BeginInit();
            this.SuspendLayout();
            // 
            // Settings_grpbox
            // 
            this.Settings_grpbox.Controls.Add(this.timer_lbl);
            this.Settings_grpbox.Controls.Add(this.timer_tick_txtbox);
            this.Settings_grpbox.Controls.Add(this.Import_btn);
            this.Settings_grpbox.Controls.Add(this.save_btn);
            this.Settings_grpbox.Controls.Add(this.iterations_lbl);
            this.Settings_grpbox.Controls.Add(this.Iteration_txtbox);
            this.Settings_grpbox.Controls.Add(this.Paint_Of_Fractal);
            this.Settings_grpbox.Location = new System.Drawing.Point(12, 12);
            this.Settings_grpbox.Name = "Settings_grpbox";
            this.Settings_grpbox.Size = new System.Drawing.Size(218, 122);
            this.Settings_grpbox.TabIndex = 1;
            this.Settings_grpbox.TabStop = false;
            this.Settings_grpbox.Text = "Settings";
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.Location = new System.Drawing.Point(112, 25);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(72, 13);
            this.timer_lbl.TabIndex = 9;
            this.timer_lbl.Text = "Timer settings";
            // 
            // timer_tick_txtbox
            // 
            this.timer_tick_txtbox.Location = new System.Drawing.Point(112, 41);
            this.timer_tick_txtbox.Name = "timer_tick_txtbox";
            this.timer_tick_txtbox.Size = new System.Drawing.Size(100, 20);
            this.timer_tick_txtbox.TabIndex = 8;
            this.timer_tick_txtbox.TextChanged += new System.EventHandler(this.Iteration_txtbox_TextChanged);
            // 
            // Import_btn
            // 
            this.Import_btn.Location = new System.Drawing.Point(87, 77);
            this.Import_btn.Name = "Import_btn";
            this.Import_btn.Size = new System.Drawing.Size(71, 38);
            this.Import_btn.TabIndex = 7;
            this.Import_btn.Text = "Import";
            this.Import_btn.UseVisualStyleBackColor = true;
            this.Import_btn.Click += new System.EventHandler(this.Import_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(6, 78);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 37);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
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
            this.Iteration_txtbox.TextChanged += new System.EventHandler(this.Iteration_txtbox_TextChanged);
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
            this.ClientSize = new System.Drawing.Size(242, 146);
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
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button Import_btn;
        private System.Windows.Forms.Label timer_lbl;
        private System.Windows.Forms.TextBox timer_tick_txtbox;
    }
}