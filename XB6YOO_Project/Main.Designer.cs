﻿namespace XB6YOO_Project
{
    partial class Main
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
            this.btnPetition = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnVolunter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnPetition
            // 
            this.btnPetition.Location = new System.Drawing.Point(27, 98);
            this.btnPetition.Name = "btnPetition";
            this.btnPetition.Size = new System.Drawing.Size(89, 40);
            this.btnPetition.TabIndex = 0;
            this.btnPetition.Text = "button1";
            this.btnPetition.UseVisualStyleBackColor = true;
            this.btnPetition.Click += new System.EventHandler(this.BtnPetition_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.Location = new System.Drawing.Point(27, 159);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(89, 40);
            this.btnCompany.TabIndex = 1;
            this.btnCompany.Text = "button2";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.BtnCompany_Click);
            // 
            // btnVolunter
            // 
            this.btnVolunter.Location = new System.Drawing.Point(27, 218);
            this.btnVolunter.Name = "btnVolunter";
            this.btnVolunter.Size = new System.Drawing.Size(89, 40);
            this.btnVolunter.TabIndex = 2;
            this.btnVolunter.Text = "button3";
            this.btnVolunter.UseVisualStyleBackColor = true;
            this.btnVolunter.Click += new System.EventHandler(this.BtnVolunter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Greenpeace Information System";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(691, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(122, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 401);
            this.panel1.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolunter);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.btnPetition);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPetition;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnVolunter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel1;
    }
}