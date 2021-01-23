
namespace KPGL_.Export_folder
{
    partial class Export_choices
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
            this.export_lbl = new System.Windows.Forms.Label();
            this.Export_btn = new System.Windows.Forms.Button();
            this.csv_export_checkbox = new System.Windows.Forms.CheckBox();
            this.image_export_checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // export_lbl
            // 
            this.export_lbl.AutoSize = true;
            this.export_lbl.Location = new System.Drawing.Point(12, 9);
            this.export_lbl.Name = "export_lbl";
            this.export_lbl.Size = new System.Drawing.Size(156, 13);
            this.export_lbl.TabIndex = 8;
            this.export_lbl.Text = "What would you like to export ?";
            // 
            // Export_btn
            // 
            this.Export_btn.Location = new System.Drawing.Point(15, 98);
            this.Export_btn.Name = "Export_btn";
            this.Export_btn.Size = new System.Drawing.Size(75, 23);
            this.Export_btn.TabIndex = 7;
            this.Export_btn.Text = "Export";
            this.Export_btn.UseVisualStyleBackColor = true;
            this.Export_btn.Click += new System.EventHandler(this.Export_btn_Click);
            // 
            // csv_export_checkbox
            // 
            this.csv_export_checkbox.AutoSize = true;
            this.csv_export_checkbox.Location = new System.Drawing.Point(15, 75);
            this.csv_export_checkbox.Name = "csv_export_checkbox";
            this.csv_export_checkbox.Size = new System.Drawing.Size(47, 17);
            this.csv_export_checkbox.TabIndex = 6;
            this.csv_export_checkbox.Text = "CSV";
            this.csv_export_checkbox.UseVisualStyleBackColor = true;
            // 
            // image_export_checkbox
            // 
            this.image_export_checkbox.AutoSize = true;
            this.image_export_checkbox.Location = new System.Drawing.Point(15, 52);
            this.image_export_checkbox.Name = "image_export_checkbox";
            this.image_export_checkbox.Size = new System.Drawing.Size(55, 17);
            this.image_export_checkbox.TabIndex = 5;
            this.image_export_checkbox.Text = "Image";
            this.image_export_checkbox.UseVisualStyleBackColor = true;
            // 
            // Export_choices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 141);
            this.Controls.Add(this.export_lbl);
            this.Controls.Add(this.Export_btn);
            this.Controls.Add(this.csv_export_checkbox);
            this.Controls.Add(this.image_export_checkbox);
            this.Name = "Export_choices";
            this.Text = "Export_choices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label export_lbl;
        private System.Windows.Forms.Button Export_btn;
        private System.Windows.Forms.CheckBox csv_export_checkbox;
        private System.Windows.Forms.CheckBox image_export_checkbox;
    }
}