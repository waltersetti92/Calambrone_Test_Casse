﻿namespace Calambrone_Test_Casse_2
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.AutoSize = true;
            this.Button1.Font = new System.Drawing.Font("Showcard Gothic", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Button1.Location = new System.Drawing.Point(482, 378);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(1083, 223);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "TEST CASSE ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 646);
            this.Controls.Add(this.Button1);
            this.Name = "Main";
            this.Text = "Test_Casse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Button1;
    }
}