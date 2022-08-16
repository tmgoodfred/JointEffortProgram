namespace JointEffortProgram
{
    partial class Form1
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
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.refreshFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputTxt
            // 
            this.outputTxt.Location = new System.Drawing.Point(290, 83);
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.Size = new System.Drawing.Size(185, 23);
            this.outputTxt.TabIndex = 0;
            // 
            // refreshFileBtn
            // 
            this.refreshFileBtn.Location = new System.Drawing.Point(366, 252);
            this.refreshFileBtn.Name = "refreshFileBtn";
            this.refreshFileBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshFileBtn.TabIndex = 1;
            this.refreshFileBtn.Text = "Refresh";
            this.refreshFileBtn.UseVisualStyleBackColor = true;
            this.refreshFileBtn.Click += new System.EventHandler(this.refreshFileBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshFileBtn);
            this.Controls.Add(this.outputTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox outputTxt;
        private Button refreshFileBtn;
    }
}