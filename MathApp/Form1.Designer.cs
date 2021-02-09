
namespace MathApp
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
            this.components = new System.ComponentModel.Container();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.FirstNum = new System.Windows.Forms.Label();
            this.SecondNum = new System.Windows.Forms.Label();
            this.toolTipTop = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBottom = new System.Windows.Forms.ToolTip(this.components);
            this.OutputTitle = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.maskedTextBoxTop = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxBottom = new System.Windows.Forms.MaskedTextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 36);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.Location = new System.Drawing.Point(12, 65);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(75, 23);
            this.BtnSubtract.TabIndex = 2;
            this.BtnSubtract.Text = "Subtract";
            this.BtnSubtract.UseVisualStyleBackColor = true;
            this.BtnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Location = new System.Drawing.Point(12, 94);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(75, 23);
            this.BtnMultiply.TabIndex = 3;
            this.BtnMultiply.Text = "Multiply";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Location = new System.Drawing.Point(12, 123);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(75, 23);
            this.BtnDivide.TabIndex = 4;
            this.BtnDivide.Text = "Divide";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(82, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(113, 13);
            this.Title.TabIndex = 7;
            this.Title.Text = "Let\'s Do Some MATH!";
            // 
            // FirstNum
            // 
            this.FirstNum.AutoSize = true;
            this.FirstNum.Location = new System.Drawing.Point(101, 68);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(92, 13);
            this.FirstNum.TabIndex = 8;
            this.FirstNum.Text = "Enter 1st Number:";
            // 
            // SecondNum
            // 
            this.SecondNum.AutoSize = true;
            this.SecondNum.Location = new System.Drawing.Point(97, 126);
            this.SecondNum.Name = "SecondNum";
            this.SecondNum.Size = new System.Drawing.Size(96, 13);
            this.SecondNum.TabIndex = 9;
            this.SecondNum.Text = "Enter 2nd Number:";
            // 
            // OutputTitle
            // 
            this.OutputTitle.AutoSize = true;
            this.OutputTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTitle.Location = new System.Drawing.Point(34, 187);
            this.OutputTitle.Name = "OutputTitle";
            this.OutputTitle.Size = new System.Drawing.Size(53, 13);
            this.OutputTitle.TabIndex = 12;
            this.OutputTitle.Text = "Output: ";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(85, 186);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 13);
            this.Output.TabIndex = 13;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(104, 215);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // maskedTextBoxTop
            // 
            this.maskedTextBoxTop.BeepOnError = true;
            this.maskedTextBoxTop.Location = new System.Drawing.Point(212, 65);
            this.maskedTextBoxTop.Name = "maskedTextBoxTop";
            this.maskedTextBoxTop.PromptChar = ' ';
            this.maskedTextBoxTop.ResetOnSpace = false;
            this.maskedTextBoxTop.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxTop.TabIndex = 15;
            // 
            // maskedTextBoxBottom
            // 
            this.maskedTextBoxBottom.Location = new System.Drawing.Point(212, 125);
            this.maskedTextBoxBottom.Name = "maskedTextBoxBottom";
            this.maskedTextBoxBottom.PromptChar = ' ';
            this.maskedTextBoxBottom.ResetOnSpace = false;
            this.maskedTextBoxBottom.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBoxBottom.TabIndex = 16;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 250);
            this.Controls.Add(this.maskedTextBoxBottom);
            this.Controls.Add(this.maskedTextBoxTop);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.OutputTitle);
            this.Controls.Add(this.SecondNum);
            this.Controls.Add(this.FirstNum);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnSubtract);
            this.Controls.Add(this.BtnAdd);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSubtract;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label FirstNum;
        private System.Windows.Forms.Label SecondNum;
        private System.Windows.Forms.ToolTip toolTipTop;
        private System.Windows.Forms.ToolTip toolTipBottom;
        private System.Windows.Forms.Label OutputTitle;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTop;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBottom;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

