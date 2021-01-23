
namespace KPGL_
{
    partial class Main_Form
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Settings_grpbox = new System.Windows.Forms.GroupBox();
            this.Import_btn = new System.Windows.Forms.Button();
            this.Export_btn = new System.Windows.Forms.Button();
            this.iterations_lbl = new System.Windows.Forms.Label();
            this.Iteration_txtbox = new System.Windows.Forms.TextBox();
            this.Paint_Of_Fractal = new System.Windows.Forms.PictureBox();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.Settings_btn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.visual_btn = new System.Windows.Forms.Button();
            this.Settings_grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paint_Of_Fractal)).BeginInit();
            this.SideBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Settings_grpbox
            // 
            this.Settings_grpbox.Controls.Add(this.Import_btn);
            this.Settings_grpbox.Controls.Add(this.Export_btn);
            this.Settings_grpbox.Controls.Add(this.iterations_lbl);
            this.Settings_grpbox.Controls.Add(this.Iteration_txtbox);
            this.Settings_grpbox.Controls.Add(this.Paint_Of_Fractal);
            this.Settings_grpbox.Controls.Add(this.Start_btn);
            this.Settings_grpbox.Location = new System.Drawing.Point(12, 292);
            this.Settings_grpbox.Name = "Settings_grpbox";
            this.Settings_grpbox.Size = new System.Drawing.Size(250, 115);
            this.Settings_grpbox.TabIndex = 0;
            this.Settings_grpbox.TabStop = false;
            this.Settings_grpbox.Text = "Settings";
            // 
            // Import_btn
            // 
            this.Import_btn.Location = new System.Drawing.Point(155, 67);
            this.Import_btn.Name = "Import_btn";
            this.Import_btn.Size = new System.Drawing.Size(71, 38);
            this.Import_btn.TabIndex = 6;
            this.Import_btn.Text = "Import";
            this.Import_btn.UseVisualStyleBackColor = true;
            // 
            // Export_btn
            // 
            this.Export_btn.Location = new System.Drawing.Point(78, 67);
            this.Export_btn.Name = "Export_btn";
            this.Export_btn.Size = new System.Drawing.Size(71, 38);
            this.Export_btn.TabIndex = 5;
            this.Export_btn.Text = "Export";
            this.Export_btn.UseVisualStyleBackColor = true;
            this.Export_btn.Click += new System.EventHandler(this.Export_btn_Click);
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
            this.Paint_Of_Fractal.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_Of_Fractal_Paint);
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(6, 67);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(66, 38);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Reset_btn.Location = new System.Drawing.Point(0, 0);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(197, 64);
            this.Reset_btn.TabIndex = 1;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SideBarPanel.Controls.Add(this.visual_btn);
            this.SideBarPanel.Controls.Add(this.Settings_btn);
            this.SideBarPanel.Controls.Add(this.Reset_btn);
            this.SideBarPanel.Controls.Add(this.Settings_grpbox);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(196, 640);
            this.SideBarPanel.TabIndex = 2;
            // 
            // Settings_btn
            // 
            this.Settings_btn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Settings_btn.Location = new System.Drawing.Point(0, 54);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(197, 64);
            this.Settings_btn.TabIndex = 2;
            this.Settings_btn.Text = "Nastavení";
            this.Settings_btn.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(196, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1074, 640);
            this.MainPanel.TabIndex = 3;
            // 
            // visual_btn
            // 
            this.visual_btn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.visual_btn.Location = new System.Drawing.Point(0, 113);
            this.visual_btn.Name = "visual_btn";
            this.visual_btn.Size = new System.Drawing.Size(197, 64);
            this.visual_btn.TabIndex = 3;
            this.visual_btn.Text = "Vizual";
            this.visual_btn.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 640);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SideBarPanel);
            this.Name = "Main_Form";
            this.Text = "Main";
            this.Settings_grpbox.ResumeLayout(false);
            this.Settings_grpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paint_Of_Fractal)).EndInit();
            this.SideBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Settings_grpbox;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.PictureBox Paint_Of_Fractal;
        private System.Windows.Forms.Button Export_btn;
        private System.Windows.Forms.Label iterations_lbl;
        private System.Windows.Forms.TextBox Iteration_txtbox;
        private System.Windows.Forms.Button Import_btn;
        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Button Settings_btn;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button visual_btn;
    }
}

