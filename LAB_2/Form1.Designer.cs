
namespace LAB_2
{
    partial class Task1
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
            this.textA.Location = new System.Drawing.Point(10, 10);
            this.textA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(74, 29);
            this.textA.TabIndex = 0;
            this.textA.Text = Properties.Settings.Default.sideA;
            this.textA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Just_Key_Up);
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(10, 44);
            this.textB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(74, 29);
            this.textB.TabIndex = 1;
            this.textB.Text = Properties.Settings.Default.sideB;
            this.textB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Just_Key_Up);
            // 
            // MainButton
            // 
            this.MainButton.Location = new System.Drawing.Point(10, 77);
            this.MainButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(327, 40);
            this.MainButton.TabIndex = 2;
            this.MainButton.Text = "Режем на квадраты";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Первая сторона прямоугольника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вторая сторона прямоугольника";
            // 
            // TaskButton
            // 
            this.TaskButton.Location = new System.Drawing.Point(350, 9);
            this.TaskButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(107, 108);
            this.TaskButton.TabIndex = 5;
            this.TaskButton.Text = "Задание";
            this.TaskButton.UseVisualStyleBackColor = true;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(464, 126);
            this.Controls.Add(this.TaskButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Task1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

