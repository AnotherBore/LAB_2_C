
namespace LAB_2
{
    partial class Task2
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.TaskButton2 = new System.Windows.Forms.Button();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(12, 12);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(365, 29);
            this.textInput.TabIndex = 0;
            this.textInput.TextChanged += new System.EventHandler(this.Just_Text_Changed);
            this.textInput.Text = Properties.Settings.Default.input;
            // 
            // TaskButton2
            // 
            this.TaskButton2.Location = new System.Drawing.Point(409, 12);
            this.TaskButton2.Margin = new System.Windows.Forms.Padding(4);
            this.TaskButton2.Name = "TaskButton2";
            this.TaskButton2.Size = new System.Drawing.Size(112, 87);
            this.TaskButton2.TabIndex = 6;
            this.TaskButton2.Text = "Задание";
            this.TaskButton2.UseVisualStyleBackColor = true;
            this.TaskButton2.Click += new System.EventHandler(this.TaskButton2_Click);
            // 
            // TaskLabel
            // 
            this.TaskLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaskLabel.Location = new System.Drawing.Point(227, 57);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(137, 28);
            this.TaskLabel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Доля букв -";
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 111);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.TaskButton2);
            this.Controls.Add(this.textInput);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 150);
            this.MinimumSize = new System.Drawing.Size(550, 150);
            this.Name = "Task2";
            this.Text = "Доля букв в строке";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button TaskButton2;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.Label label1;
    }
}