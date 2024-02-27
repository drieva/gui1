namespace MoveEstimatorGUIApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.hoursLabel = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.milesLabel = new System.Windows.Forms.Label();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.calculateEstimateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(12, 21);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(78, 20);
            this.hoursLabel.TabIndex = 0;
            this.hoursLabel.Text = "Number of hours:";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(180, 18);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 26);
            this.hoursTextBox.TabIndex = 1;
            // 
            // milesLabel
            // 
            this.milesLabel.AutoSize = true;
            this.milesLabel.Location = new System.Drawing.Point(12, 57);
            this.milesLabel.Name = "milesLabel";
            this.milesLabel.Size = new System.Drawing.Size(71, 20);
            this.milesLabel.TabIndex = 2;
            this.milesLabel.Text = "Number of miles:";
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(180, 54);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(100, 26);
            this.milesTextBox.TabIndex = 3;
            // 
            // calculateEstimateButton
            // 
            this.calculateEstimateButton.Location = new System.Drawing.Point(16, 94);
            this.calculateEstimateButton.Name = "calculateEstimateButton";
            this.calculateEstimateButton.Size = new System.Drawing.Size(180, 35);
            this.calculateEstimateButton.TabIndex = 4;
            this.calculateEstimateButton.Text = "Calculate Estimate";
            this.calculateEstimateButton.UseVisualStyleBackColor = true;
            this.calculateEstimateButton.Click += new System.EventHandler(this.CalculateEstimateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 146);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 20);
            this.resultLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateEstimateButton);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.milesLabel);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.hoursLabel);
            this.Name = "Form1";
            this.Text = "MoveEstimator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Label milesLabel;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.Button calculateEstimateButton;
        private System.Windows.Forms.Label resultLabel;
    }
}
