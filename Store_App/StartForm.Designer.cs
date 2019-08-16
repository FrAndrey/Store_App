﻿namespace Store_App
{
    partial class StartForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SelectFormButton = new System.Windows.Forms.Button();
            this.ExitAppButton = new System.Windows.Forms.Button();
            this.OpenFormButton = new System.Windows.Forms.Button();
            this.ProductOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 167);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SelectFormButton
            // 
            this.SelectFormButton.Location = new System.Drawing.Point(470, 220);
            this.SelectFormButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectFormButton.Name = "SelectFormButton";
            this.SelectFormButton.Size = new System.Drawing.Size(264, 121);
            this.SelectFormButton.TabIndex = 2;
            this.SelectFormButton.Text = "Start a New Order";
            this.SelectFormButton.UseVisualStyleBackColor = true;
            this.SelectFormButton.Click += new System.EventHandler(this.SelectFormButton_Click);
            // 
            // ExitAppButton
            // 
            this.ExitAppButton.Location = new System.Drawing.Point(470, 566);
            this.ExitAppButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ExitAppButton.Name = "ExitAppButton";
            this.ExitAppButton.Size = new System.Drawing.Size(264, 121);
            this.ExitAppButton.TabIndex = 2;
            this.ExitAppButton.Text = "Exit The Application";
            this.ExitAppButton.UseVisualStyleBackColor = true;
            this.ExitAppButton.Click += new System.EventHandler(this.ExitAppButton_Click);
            // 
            // OpenFormButton
            // 
            this.OpenFormButton.Location = new System.Drawing.Point(470, 375);
            this.OpenFormButton.Margin = new System.Windows.Forms.Padding(6);
            this.OpenFormButton.Name = "OpenFormButton";
            this.OpenFormButton.Size = new System.Drawing.Size(264, 121);
            this.OpenFormButton.TabIndex = 2;
            this.OpenFormButton.Text = "Open a Saved Order";
            this.OpenFormButton.UseVisualStyleBackColor = true;
            this.OpenFormButton.Click += new System.EventHandler(this.OpenFormButton_Click);
            // 
            // ProductOpenFileDialog
            // 
            this.ProductOpenFileDialog.FileName = "openFileDialog1";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 790);
            this.ControlBox = false;
            this.Controls.Add(this.ExitAppButton);
            this.Controls.Add(this.OpenFormButton);
            this.Controls.Add(this.SelectFormButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SelectFormButton;
        private System.Windows.Forms.Button ExitAppButton;
        private System.Windows.Forms.Button OpenFormButton;
        private System.Windows.Forms.OpenFileDialog ProductOpenFileDialog;
    }
}