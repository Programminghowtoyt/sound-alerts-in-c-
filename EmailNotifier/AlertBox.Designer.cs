﻿namespace EmailNotifier
{
    partial class AlertBox
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
            this.lblAlertNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAlertMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAlertNumber
            // 
            this.lblAlertNumber.AutoSize = true;
            this.lblAlertNumber.Location = new System.Drawing.Point(0, 0);
            this.lblAlertNumber.Name = "lblAlertNumber";
            this.lblAlertNumber.Size = new System.Drawing.Size(35, 13);
            this.lblAlertNumber.TabIndex = 0;
            this.lblAlertNumber.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAlertMessage
            // 
            this.lblAlertMessage.AutoSize = true;
            this.lblAlertMessage.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertMessage.Location = new System.Drawing.Point(12, 29);
            this.lblAlertMessage.Name = "lblAlertMessage";
            this.lblAlertMessage.Size = new System.Drawing.Size(68, 23);
            this.lblAlertMessage.TabIndex = 2;
            this.lblAlertMessage.Text = "label2";
            // 
            // AlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 133);
            this.Controls.Add(this.lblAlertMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAlertNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertBox";
            this.Text = "AlertBox";
            this.Load += new System.EventHandler(this.AlertBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlertNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAlertMessage;
    }
}