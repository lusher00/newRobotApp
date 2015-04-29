namespace newRobotApp
{
    partial class ParameterUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.incrementTextBox = new System.Windows.Forms.TextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkbox
            // 
            this.checkbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkbox.AutoSize = true;
            this.checkbox.Location = new System.Drawing.Point(261, 11);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(15, 14);
            this.checkbox.TabIndex = 110;
            this.checkbox.UseVisualStyleBackColor = true;
            // 
            // incrementTextBox
            // 
            this.incrementTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.incrementTextBox.Location = new System.Drawing.Point(204, 8);
            this.incrementTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.incrementTextBox.Name = "incrementTextBox";
            this.incrementTextBox.Size = new System.Drawing.Size(50, 20);
            this.incrementTextBox.TabIndex = 109;
            this.incrementTextBox.TextChanged += new System.EventHandler(this.incrementTextBox_TextChanged);
            // 
            // setButton
            // 
            this.setButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.setButton.Location = new System.Drawing.Point(283, 5);
            this.setButton.Margin = new System.Windows.Forms.Padding(4);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(48, 24);
            this.setButton.TabIndex = 108;
            this.setButton.Text = "SET";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.minusButton.Location = new System.Drawing.Point(172, 6);
            this.minusButton.Margin = new System.Windows.Forms.Padding(4);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(24, 24);
            this.minusButton.TabIndex = 107;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.plusButton.Location = new System.Drawing.Point(140, 6);
            this.plusButton.Margin = new System.Windows.Forms.Padding(4);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(24, 24);
            this.plusButton.TabIndex = 106;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // textBox
            // 
            this.textBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox.Location = new System.Drawing.Point(83, 8);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(50, 20);
            this.textBox.TabIndex = 105;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label.Location = new System.Drawing.Point(4, 8);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(72, 20);
            this.label.TabIndex = 104;
            this.label.Text = "longlable";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkbox);
            this.Controls.Add(this.incrementTextBox);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(344, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.TextBox incrementTextBox;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label;
    }
}
