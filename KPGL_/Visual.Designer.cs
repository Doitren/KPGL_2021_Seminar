
namespace KPGL_
{
    partial class Visual
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
            this.components = new System.ComponentModel.Container();
            this.Draw_panel = new System.Windows.Forms.Panel();
            this.setting_grpbox = new System.Windows.Forms.GroupBox();
            this.Export_btn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.start_btn = new System.Windows.Forms.Button();
            this.Timer_status_lbl = new System.Windows.Forms.Label();
            this.Timer_interval_lbl = new System.Windows.Forms.Label();
            this.setting_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Draw_panel
            // 
            this.Draw_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Draw_panel.Location = new System.Drawing.Point(0, 84);
            this.Draw_panel.Name = "Draw_panel";
            this.Draw_panel.Size = new System.Drawing.Size(1215, 566);
            this.Draw_panel.TabIndex = 0;
            // 
            // setting_grpbox
            // 
            this.setting_grpbox.Controls.Add(this.Timer_interval_lbl);
            this.setting_grpbox.Controls.Add(this.Timer_status_lbl);
            this.setting_grpbox.Controls.Add(this.start_btn);
            this.setting_grpbox.Controls.Add(this.Export_btn);
            this.setting_grpbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.setting_grpbox.Location = new System.Drawing.Point(0, 0);
            this.setting_grpbox.Name = "setting_grpbox";
            this.setting_grpbox.Size = new System.Drawing.Size(1215, 78);
            this.setting_grpbox.TabIndex = 1;
            this.setting_grpbox.TabStop = false;
            this.setting_grpbox.Text = "Config Panel";
            // 
            // Export_btn
            // 
            this.Export_btn.Location = new System.Drawing.Point(84, 22);
            this.Export_btn.Name = "Export_btn";
            this.Export_btn.Size = new System.Drawing.Size(71, 38);
            this.Export_btn.TabIndex = 6;
            this.Export_btn.Text = "Export";
            this.Export_btn.UseVisualStyleBackColor = true;
            this.Export_btn.Click += new System.EventHandler(this.Export_btn_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(3, 22);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 38);
            this.start_btn.TabIndex = 7;
            this.start_btn.Text = "Start Timer";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // Timer_status_lbl
            // 
            this.Timer_status_lbl.AutoSize = true;
            this.Timer_status_lbl.Location = new System.Drawing.Point(161, 22);
            this.Timer_status_lbl.Name = "Timer_status_lbl";
            this.Timer_status_lbl.Size = new System.Drawing.Size(70, 13);
            this.Timer_status_lbl.TabIndex = 8;
            this.Timer_status_lbl.Text = "Timer status: ";
            // 
            // Timer_interval_lbl
            // 
            this.Timer_interval_lbl.AutoSize = true;
            this.Timer_interval_lbl.Location = new System.Drawing.Point(161, 35);
            this.Timer_interval_lbl.Name = "Timer_interval_lbl";
            this.Timer_interval_lbl.Size = new System.Drawing.Size(76, 13);
            this.Timer_interval_lbl.TabIndex = 9;
            this.Timer_interval_lbl.Text = "Timer interval: ";
            // 
            // Visual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 650);
            this.Controls.Add(this.setting_grpbox);
            this.Controls.Add(this.Draw_panel);
            this.Name = "Visual";
            this.Text = "Visual";
            this.setting_grpbox.ResumeLayout(false);
            this.setting_grpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Draw_panel;
        private System.Windows.Forms.GroupBox setting_grpbox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button Export_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label Timer_status_lbl;
        private System.Windows.Forms.Label Timer_interval_lbl;
    }
}