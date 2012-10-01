﻿namespace Pointboard
{
    partial class frm_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.box_original = new System.Windows.Forms.PictureBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.box_transformed = new System.Windows.Forms.PictureBox();
            this.btn_calibrate = new System.Windows.Forms.Button();
            this.box_filtered = new System.Windows.Forms.PictureBox();
            this.box_final = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.box_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_transformed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_filtered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_final)).BeginInit();
            this.SuspendLayout();
            // 
            // box_original
            // 
            this.box_original.Location = new System.Drawing.Point(12, 12);
            this.box_original.Name = "box_original";
            this.box_original.Size = new System.Drawing.Size(160, 120);
            this.box_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_original.TabIndex = 0;
            this.box_original.TabStop = false;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(93, 518);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(25, 13);
            this.lbl_info.TabIndex = 1;
            this.lbl_info.Text = "Info";
            // 
            // box_transformed
            // 
            this.box_transformed.Location = new System.Drawing.Point(178, 12);
            this.box_transformed.Name = "box_transformed";
            this.box_transformed.Size = new System.Drawing.Size(160, 120);
            this.box_transformed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_transformed.TabIndex = 2;
            this.box_transformed.TabStop = false;
            // 
            // btn_calibrate
            // 
            this.btn_calibrate.Enabled = false;
            this.btn_calibrate.Location = new System.Drawing.Point(12, 513);
            this.btn_calibrate.Name = "btn_calibrate";
            this.btn_calibrate.Size = new System.Drawing.Size(75, 23);
            this.btn_calibrate.TabIndex = 5;
            this.btn_calibrate.Text = "Calibrate";
            this.btn_calibrate.UseVisualStyleBackColor = true;
            this.btn_calibrate.Click += new System.EventHandler(this.button1_Click);
            // 
            // box_filtered
            // 
            this.box_filtered.Location = new System.Drawing.Point(344, 12);
            this.box_filtered.Name = "box_filtered";
            this.box_filtered.Size = new System.Drawing.Size(160, 120);
            this.box_filtered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_filtered.TabIndex = 2;
            this.box_filtered.TabStop = false;
            // 
            // box_final
            // 
            this.box_final.Location = new System.Drawing.Point(12, 138);
            this.box_final.Name = "box_final";
            this.box_final.Size = new System.Drawing.Size(492, 369);
            this.box_final.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box_final.TabIndex = 2;
            this.box_final.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 548);
            this.Controls.Add(this.btn_calibrate);
            this.Controls.Add(this.box_final);
            this.Controls.Add(this.box_filtered);
            this.Controls.Add(this.box_transformed);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.box_original);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.Text = "Laserboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Pointboard_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_transformed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_filtered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_final)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox box_original;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.PictureBox box_transformed;
        private System.Windows.Forms.Button btn_calibrate;
        private System.Windows.Forms.PictureBox box_filtered;
        private System.Windows.Forms.PictureBox box_final;
    }
}
