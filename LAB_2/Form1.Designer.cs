
namespace LAB_2
{
    partial class MainForm
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
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.MainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(17, 18);
            this.textA.Margin = new System.Windows.Forms.Padding(4);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(127, 29);
            this.textA.TabIndex = 0;
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(17, 58);
            this.textB.Margin = new System.Windows.Forms.Padding(4);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(127, 29);
            this.textB.TabIndex = 1;
            // 
            // MainButton
            // 
            this.MainButton.Location = new System.Drawing.Point(17, 105);
            this.MainButton.Margin = new System.Windows.Forms.Padding(4);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(384, 43);
            this.MainButton.TabIndex = 2;
            this.MainButton.Text = "Режем на квадраты";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Первая сторона прямоугольника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вторая сторона прямоугольника";
            // 
            // TaskButton
            // 
            this.TaskButton.Location = new System.Drawing.Point(409, 18);
            this.TaskButton.Margin = new System.Windows.Forms.Padding(4);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(112, 130);
            this.TaskButton.TabIndex = 5;
            this.TaskButton.Text = "Задание";
            this.TaskButton.UseVisualStyleBackColor = true;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 161);
            this.Controls.Add(this.TaskButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 200);
            this.MinimumSize = new System.Drawing.Size(550, 200);
            this.Name = "MainForm";
            this.Text = "Квадраторезка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TaskButton;
    }
}

