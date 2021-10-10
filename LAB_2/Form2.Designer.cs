
namespace LAB_2
{
    partial class MainMenu
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
            this.Task1Button = new System.Windows.Forms.Button();
            this.Task2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task1Button
            // 
            this.Task1Button.Location = new System.Drawing.Point(7, 7);
            this.Task1Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Task1Button.Name = "Task1Button";
            this.Task1Button.Size = new System.Drawing.Size(127, 69);
            this.Task1Button.TabIndex = 0;
            this.Task1Button.Text = "Задача на for";
            this.Task1Button.UseVisualStyleBackColor = true;
            this.Task1Button.Click += new System.EventHandler(this.Task1Button_Click);
            // 
            // Task2Button
            // 
            this.Task2Button.Location = new System.Drawing.Point(150, 7);
            this.Task2Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Task2Button.Name = "Task2Button";
            this.Task2Button.Size = new System.Drawing.Size(127, 69);
            this.Task2Button.TabIndex = 1;
            this.Task2Button.Text = "Задача на строки";
            this.Task2Button.UseVisualStyleBackColor = true;
            this.Task2Button.Click += new System.EventHandler(this.Task2Button_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(288, 87);
            this.Controls.Add(this.Task2Button);
            this.Controls.Add(this.Task1Button);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(304, 126);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Task1Button;
        private System.Windows.Forms.Button Task2Button;
    }
}