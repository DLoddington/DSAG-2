namespace TaskBassessed
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
            this.nameEnqueueTextBox = new System.Windows.Forms.TextBox();
            this.nameStackDisplay = new System.Windows.Forms.RichTextBox();
            this.nameTextLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.dequeueName = new System.Windows.Forms.Button();
            this.reverseVal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reverseStack = new System.Windows.Forms.Button();
            this.confirmationText = new System.Windows.Forms.Label();
            this.tailIndicator = new System.Windows.Forms.Label();
            this.headIndicator = new System.Windows.Forms.Label();
            this.intErrorText = new System.Windows.Forms.Label();
            this.dummyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.namesNumText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameEnqueueTextBox
            // 
            this.nameEnqueueTextBox.Location = new System.Drawing.Point(19, 54);
            this.nameEnqueueTextBox.Name = "nameEnqueueTextBox";
            this.nameEnqueueTextBox.Size = new System.Drawing.Size(176, 20);
            this.nameEnqueueTextBox.TabIndex = 0;
            // 
            // nameStackDisplay
            // 
            this.nameStackDisplay.Location = new System.Drawing.Point(317, 54);
            this.nameStackDisplay.Name = "nameStackDisplay";
            this.nameStackDisplay.Size = new System.Drawing.Size(186, 289);
            this.nameStackDisplay.TabIndex = 2;
            this.nameStackDisplay.Text = "";
            // 
            // nameTextLabel
            // 
            this.nameTextLabel.AutoSize = true;
            this.nameTextLabel.Location = new System.Drawing.Point(16, 38);
            this.nameTextLabel.Name = "nameTextLabel";
            this.nameTextLabel.Size = new System.Drawing.Size(92, 13);
            this.nameTextLabel.TabIndex = 3;
            this.nameTextLabel.Text = "Name to enqueue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current queue";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(213, 54);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 6;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // dequeueName
            // 
            this.dequeueName.Location = new System.Drawing.Point(214, 97);
            this.dequeueName.Name = "dequeueName";
            this.dequeueName.Size = new System.Drawing.Size(74, 23);
            this.dequeueName.TabIndex = 8;
            this.dequeueName.Text = "Dequeue";
            this.dequeueName.UseVisualStyleBackColor = true;
            this.dequeueName.Click += new System.EventHandler(this.dequeueName_Click);
            // 
            // reverseVal
            // 
            this.reverseVal.Location = new System.Drawing.Point(19, 146);
            this.reverseVal.Name = "reverseVal";
            this.reverseVal.Size = new System.Drawing.Size(176, 20);
            this.reverseVal.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Reverse stack from this position";
            // 
            // reverseStack
            // 
            this.reverseStack.Location = new System.Drawing.Point(214, 146);
            this.reverseStack.Name = "reverseStack";
            this.reverseStack.Size = new System.Drawing.Size(74, 23);
            this.reverseStack.TabIndex = 11;
            this.reverseStack.Text = "Execute";
            this.reverseStack.UseVisualStyleBackColor = true;
            this.reverseStack.Click += new System.EventHandler(this.reverseStack_Click);
            // 
            // confirmationText
            // 
            this.confirmationText.AutoSize = true;
            this.confirmationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.confirmationText.Location = new System.Drawing.Point(18, 224);
            this.confirmationText.Name = "confirmationText";
            this.confirmationText.Size = new System.Drawing.Size(0, 20);
            this.confirmationText.TabIndex = 12;
            // 
            // tailIndicator
            // 
            this.tailIndicator.AutoSize = true;
            this.tailIndicator.Location = new System.Drawing.Point(509, 54);
            this.tailIndicator.Name = "tailIndicator";
            this.tailIndicator.Size = new System.Drawing.Size(46, 13);
            this.tailIndicator.TabIndex = 13;
            this.tailIndicator.Text = "Tail side";
            // 
            // headIndicator
            // 
            this.headIndicator.AutoSize = true;
            this.headIndicator.Location = new System.Drawing.Point(509, 330);
            this.headIndicator.Name = "headIndicator";
            this.headIndicator.Size = new System.Drawing.Size(55, 13);
            this.headIndicator.TabIndex = 14;
            this.headIndicator.Text = "Head side";
            // 
            // intErrorText
            // 
            this.intErrorText.AutoSize = true;
            this.intErrorText.ForeColor = System.Drawing.Color.Red;
            this.intErrorText.Location = new System.Drawing.Point(16, 178);
            this.intErrorText.Name = "intErrorText";
            this.intErrorText.Size = new System.Drawing.Size(0, 13);
            this.intErrorText.TabIndex = 15;
            // 
            // dummyButton
            // 
            this.dummyButton.Location = new System.Drawing.Point(175, 318);
            this.dummyButton.Name = "dummyButton";
            this.dummyButton.Size = new System.Drawing.Size(113, 23);
            this.dummyButton.TabIndex = 16;
            this.dummyButton.Text = "Add Dummy Names";
            this.dummyButton.UseVisualStyleBackColor = true;
            this.dummyButton.Click += new System.EventHandler(this.dummyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total num of names = ";
            // 
            // namesNumText
            // 
            this.namesNumText.AutoSize = true;
            this.namesNumText.Location = new System.Drawing.Point(125, 283);
            this.namesNumText.Name = "namesNumText";
            this.namesNumText.Size = new System.Drawing.Size(0, 13);
            this.namesNumText.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 366);
            this.Controls.Add(this.namesNumText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dummyButton);
            this.Controls.Add(this.intErrorText);
            this.Controls.Add(this.headIndicator);
            this.Controls.Add(this.tailIndicator);
            this.Controls.Add(this.confirmationText);
            this.Controls.Add(this.reverseStack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reverseVal);
            this.Controls.Add(this.dequeueName);
            this.Controls.Add(this.enqueueButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextLabel);
            this.Controls.Add(this.nameStackDisplay);
            this.Controls.Add(this.nameEnqueueTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameEnqueueTextBox;
        private System.Windows.Forms.RichTextBox nameStackDisplay;
        private System.Windows.Forms.Label nameTextLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.Button dequeueName;
        private System.Windows.Forms.TextBox reverseVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reverseStack;
        private System.Windows.Forms.Label confirmationText;
        private System.Windows.Forms.Label tailIndicator;
        private System.Windows.Forms.Label headIndicator;
        private System.Windows.Forms.Label intErrorText;
        private System.Windows.Forms.Button dummyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namesNumText;
    }
}

