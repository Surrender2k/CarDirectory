﻿
namespace CarDirectory
{
    partial class FindForm
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
            this.FindButton = new System.Windows.Forms.Button();
            this.StartTextBox = new System.Windows.Forms.MaskedTextBox();
            this.EndTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(120)))));
            this.FindButton.FlatAppearance.BorderSize = 0;
            this.FindButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.FindButton.Location = new System.Drawing.Point(25, 176);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(124, 45);
            this.FindButton.TabIndex = 38;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // StartTextBox
            // 
            this.StartTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.StartTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTextBox.Location = new System.Drawing.Point(83, 32);
            this.StartTextBox.Mask = "0000";
            this.StartTextBox.Name = "StartTextBox";
            this.StartTextBox.Size = new System.Drawing.Size(66, 38);
            this.StartTextBox.TabIndex = 39;
            this.StartTextBox.ValidatingType = typeof(int);
            this.StartTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartTextBox_KeyDown);
            // 
            // EndTextBox
            // 
            this.EndTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.EndTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndTextBox.Location = new System.Drawing.Point(83, 117);
            this.EndTextBox.Mask = "0000";
            this.EndTextBox.Name = "EndTextBox";
            this.EndTextBox.Size = new System.Drawing.Size(66, 38);
            this.EndTextBox.TabIndex = 40;
            this.EndTextBox.ValidatingType = typeof(int);
            this.EndTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EndTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 33);
            this.label3.TabIndex = 41;
            this.label3.Text = "От";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.label4.Location = new System.Drawing.Point(19, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 33);
            this.label4.TabIndex = 42;
            this.label4.Text = "До";
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(172, 233);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndTextBox);
            this.Controls.Add(this.StartTextBox);
            this.Controls.Add(this.FindButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Найти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.MaskedTextBox StartTextBox;
        private System.Windows.Forms.MaskedTextBox EndTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}