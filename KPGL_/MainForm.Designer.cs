
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
            this.Reset_btn = new System.Windows.Forms.Button();
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.visual_btn = new System.Windows.Forms.Button();
            this.Settings_btn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SideBarPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(196, 640);
            this.SideBarPanel.TabIndex = 2;
            // 
            // visual_btn
            // 
            this.visual_btn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.visual_btn.Location = new System.Drawing.Point(0, 113);
            this.visual_btn.Name = "visual_btn";
            this.visual_btn.Size = new System.Drawing.Size(197, 64);
            this.visual_btn.TabIndex = 3;
            this.visual_btn.Text = "Visual";
            this.visual_btn.UseVisualStyleBackColor = true;
            this.visual_btn.Click += new System.EventHandler(this.visual_btn_Click);
            // 
            // Settings_btn
            // 
            this.Settings_btn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Settings_btn.Location = new System.Drawing.Point(0, 54);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(197, 64);
            this.Settings_btn.TabIndex = 2;
            this.Settings_btn.Text = "Settings";
            this.Settings_btn.UseVisualStyleBackColor = true;
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(196, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1213, 640);
            this.MainPanel.TabIndex = 3;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 640);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SideBarPanel);
            this.Name = "Main_Form";
            this.Text = "Hlavní okno";
            this.SideBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Button Settings_btn;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button visual_btn;
    }
}

