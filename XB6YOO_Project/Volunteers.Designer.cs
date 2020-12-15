namespace XB6YOO_Project
{
    partial class Volunteers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblp1 = new System.Windows.Forms.Label();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.nUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblp1
            // 
            this.lblp1.AutoSize = true;
            this.lblp1.Location = new System.Drawing.Point(21, 268);
            this.lblp1.Name = "lblp1";
            this.lblp1.Size = new System.Drawing.Size(35, 13);
            this.lblp1.TabIndex = 1;
            this.lblp1.Text = "label1";
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(119, 263);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(57, 23);
            this.btnAdd1.TabIndex = 4;
            this.btnAdd1.Text = "button1";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.BtnAdd1_Click);
            // 
            // nUpDown1
            // 
            this.nUpDown1.Location = new System.Drawing.Point(78, 263);
            this.nUpDown1.Name = "nUpDown1";
            this.nUpDown1.Size = new System.Drawing.Size(35, 20);
            this.nUpDown1.TabIndex = 7;
            // 
            // Volunteers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nUpDown1);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.lblp1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Volunteers";
            this.Size = new System.Drawing.Size(491, 391);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblp1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.NumericUpDown nUpDown1;
    }
}
