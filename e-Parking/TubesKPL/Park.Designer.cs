
namespace TubesKPL
{
    partial class Park
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
            this.labelBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelParkNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.Location = new System.Drawing.Point(30, 31);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(37, 37);
            this.labelBack.TabIndex = 0;
            this.labelBack.Text = "<";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Parking lot number is";
            // 
            // labelParkNumber
            // 
            this.labelParkNumber.AutoSize = true;
            this.labelParkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParkNumber.Location = new System.Drawing.Point(82, 161);
            this.labelParkNumber.Name = "labelParkNumber";
            this.labelParkNumber.Size = new System.Drawing.Size(230, 120);
            this.labelParkNumber.TabIndex = 2;
            this.labelParkNumber.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "*Timer will automatically start\r\nwhen you reached your parking lot";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DarkRed;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Location = new System.Drawing.Point(83, 375);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(229, 56);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayment.Location = new System.Drawing.Point(83, 450);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(227, 56);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Pay";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // Park
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 594);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelParkNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBack);
            this.Name = "Park";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelParkNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnPayment;
    }
}