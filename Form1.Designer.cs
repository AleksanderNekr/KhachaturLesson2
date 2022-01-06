namespace Les2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button.Location = new System.Drawing.Point(105, 174);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(114, 30);
            this.Button.TabIndex = 0;
            this.Button.Text = "Кнопка";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(267, 174);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.ShortcutsEnabled = false;
            this.TextBox.Size = new System.Drawing.Size(365, 30);
            this.TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(270, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поле вывода";
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartButton.Location = new System.Drawing.Point(525, 331);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(153, 60);
            this.RestartButton.TabIndex = 3;
            this.RestartButton.Text = "Перезапустить приложение";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(690, 403);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RestartButton;
    }
}