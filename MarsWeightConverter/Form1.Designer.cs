namespace MarsWeightConverter
{
    partial class Exercise3
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_earthWeight = new System.Windows.Forms.TextBox();
            this.tb_marsWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Weight On Earth:";
            // 
            // tb_earthWeight
            // 
            this.tb_earthWeight.Location = new System.Drawing.Point(195, 41);
            this.tb_earthWeight.Name = "tb_earthWeight";
            this.tb_earthWeight.Size = new System.Drawing.Size(132, 20);
            this.tb_earthWeight.TabIndex = 1;
            // 
            // tb_marsWeight
            // 
            this.tb_marsWeight.Location = new System.Drawing.Point(195, 113);
            this.tb_marsWeight.Name = "tb_marsWeight";
            this.tb_marsWeight.Size = new System.Drawing.Size(132, 20);
            this.tb_marsWeight.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Weight on Mars:";
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(142, 175);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 4;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // Exercise3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 233);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_marsWeight);
            this.Controls.Add(this.tb_earthWeight);
            this.Controls.Add(this.label1);
            this.Name = "Exercise3";
            this.Text = "Exercise 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_earthWeight;
        private System.Windows.Forms.TextBox tb_marsWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Convert;
    }
}

