namespace TestAPIWF
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbt_FE = new System.Windows.Forms.TextBox();
            this.tbt_BE = new System.Windows.Forms.TextBox();
            this.tbt_Algo = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm FE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm BE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(75, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm Algo";
            // 
            // tbt_FE
            // 
            this.tbt_FE.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_FE.Location = new System.Drawing.Point(240, 34);
            this.tbt_FE.Name = "tbt_FE";
            this.tbt_FE.Size = new System.Drawing.Size(491, 38);
            this.tbt_FE.TabIndex = 3;
            // 
            // tbt_BE
            // 
            this.tbt_BE.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_BE.Location = new System.Drawing.Point(240, 106);
            this.tbt_BE.Name = "tbt_BE";
            this.tbt_BE.Size = new System.Drawing.Size(490, 38);
            this.tbt_BE.TabIndex = 4;
            // 
            // tbt_Algo
            // 
            this.tbt_Algo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Algo.Location = new System.Drawing.Point(240, 176);
            this.tbt_Algo.Name = "tbt_Algo";
            this.tbt_Algo.Size = new System.Drawing.Size(490, 38);
            this.tbt_Algo.TabIndex = 5;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Calculate.Location = new System.Drawing.Point(44, 255);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(176, 79);
            this.btn_Calculate.TabIndex = 6;
            this.btn_Calculate.Text = "Hiển thị";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Result
            // 
            this.btn_Result.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Result.Location = new System.Drawing.Point(243, 255);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(488, 79);
            this.btn_Result.TabIndex = 7;
            this.btn_Result.Text = "...";
            this.btn_Result.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(778, 367);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.tbt_Algo);
            this.Controls.Add(this.tbt_BE);
            this.Controls.Add(this.tbt_FE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbt_FE;
        private TextBox tbt_BE;
        private TextBox tbt_Algo;
        private Button btn_Calculate;
        private Button btn_Result;
    }
}