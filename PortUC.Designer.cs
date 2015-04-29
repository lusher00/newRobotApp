namespace newRobotApp
{
    partial class PortUC
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
            this.cmbBaudSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbComSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBaudSelect
            // 
            this.cmbBaudSelect.FormattingEnabled = true;
            this.cmbBaudSelect.Location = new System.Drawing.Point(83, 42);
            this.cmbBaudSelect.Name = "cmbBaudSelect";
            this.cmbBaudSelect.Size = new System.Drawing.Size(73, 21);
            this.cmbBaudSelect.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Baud Rate:";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(283, 41);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(48, 24);
            this.closeBtn.TabIndex = 45;
            this.closeBtn.Text = "close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closePort_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(283, 6);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(48, 24);
            this.openBtn.TabIndex = 44;
            this.openBtn.Text = "open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openPort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Select COM:";
            // 
            // cmbComSelect
            // 
            this.cmbComSelect.FormattingEnabled = true;
            this.cmbComSelect.Location = new System.Drawing.Point(83, 8);
            this.cmbComSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cmbComSelect.Name = "cmbComSelect";
            this.cmbComSelect.Size = new System.Drawing.Size(73, 21);
            this.cmbComSelect.Sorted = true;
            this.cmbComSelect.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Input";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(83, 78);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(194, 20);
            this.outputTextBox.TabIndex = 50;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(83, 112);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(248, 20);
            this.inputTextbox.TabIndex = 51;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(283, 76);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(48, 24);
            this.sendBtn.TabIndex = 52;
            this.sendBtn.Text = "send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // PortUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBaudSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbComSelect);
            this.Name = "PortUC";
            this.Size = new System.Drawing.Size(344, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBaudSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbComSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Button sendBtn;
    }
}
