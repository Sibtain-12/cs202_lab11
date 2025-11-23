namespace EventPlayground
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
        private void InitializeComponent()
        {
            this.lblDisplay = new System.Windows.Forms.Label();
            this.cmbColors = new System.Windows.Forms.ComboBox();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnChangeText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(318, 55);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(219, 25);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "Welcome to Events Lab";
            // 
            // cmbColors
            // 
            this.cmbColors.FormattingEnabled = true;
            this.cmbColors.Location = new System.Drawing.Point(323, 111);
            this.cmbColors.Name = "cmbColors";
            this.cmbColors.Size = new System.Drawing.Size(214, 24);
            this.cmbColors.TabIndex = 1;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(323, 180);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(100, 42);
            this.btnChangeColor.TabIndex = 2;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            // 
            // btnChangeText
            // 
            this.btnChangeText.Location = new System.Drawing.Point(446, 180);
            this.btnChangeText.Name = "btnChangeText";
            this.btnChangeText.Size = new System.Drawing.Size(91, 42);
            this.btnChangeText.TabIndex = 3;
            this.btnChangeText.Text = "Change Text";
            this.btnChangeText.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(867, 397);
            this.Controls.Add(this.btnChangeText);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.cmbColors);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.Text = "EventPlayground";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.ComboBox cmbColors;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnChangeText;
    }
}

