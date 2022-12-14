namespace JointEffortProgram
{
    partial class Notepad
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
            this.noteEntryTxt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.blankSlateBtn = new System.Windows.Forms.Button();
            this.previousEntryBtn = new System.Windows.Forms.Button();
            this.nextEntryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputTxt
            // 
            this.outputTxt.Location = new System.Drawing.Point(298, 12);
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.Size = new System.Drawing.Size(185, 23);
            this.outputTxt.TabIndex = 0;
            this.outputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // refreshFileBtn
            // 
            this.refreshFileBtn.Location = new System.Drawing.Point(681, 12);
            this.refreshFileBtn.Name = "refreshFileBtn";
            this.refreshFileBtn.Size = new System.Drawing.Size(107, 23);
            this.refreshFileBtn.TabIndex = 1;
            this.refreshFileBtn.Text = "Clear File Data";
            this.refreshFileBtn.UseVisualStyleBackColor = true;
            this.refreshFileBtn.Click += new System.EventHandler(this.refreshFileBtn_Click);
            // 
            // noteEntryTxt
            // 
            this.noteEntryTxt.Location = new System.Drawing.Point(157, 63);
            this.noteEntryTxt.Multiline = true;
            this.noteEntryTxt.Name = "noteEntryTxt";
            this.noteEntryTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteEntryTxt.Size = new System.Drawing.Size(490, 307);
            this.noteEntryTxt.TabIndex = 2;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(314, 393);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // blankSlateBtn
            // 
            this.blankSlateBtn.Location = new System.Drawing.Point(408, 393);
            this.blankSlateBtn.Name = "blankSlateBtn";
            this.blankSlateBtn.Size = new System.Drawing.Size(75, 23);
            this.blankSlateBtn.TabIndex = 4;
            this.blankSlateBtn.Text = "Blank Slate";
            this.blankSlateBtn.UseVisualStyleBackColor = true;
            this.blankSlateBtn.Click += new System.EventHandler(this.blankSlateBtn_Click);
            // 
            // previousEntryBtn
            // 
            this.previousEntryBtn.Location = new System.Drawing.Point(186, 393);
            this.previousEntryBtn.Name = "previousEntryBtn";
            this.previousEntryBtn.Size = new System.Drawing.Size(94, 23);
            this.previousEntryBtn.TabIndex = 6;
            this.previousEntryBtn.Text = "Previous Entry";
            this.previousEntryBtn.UseVisualStyleBackColor = true;
            this.previousEntryBtn.Click += new System.EventHandler(this.previousEntryBtn_Click);
            // 
            // nextEntryBtn
            // 
            this.nextEntryBtn.Location = new System.Drawing.Point(518, 393);
            this.nextEntryBtn.Name = "nextEntryBtn";
            this.nextEntryBtn.Size = new System.Drawing.Size(94, 23);
            this.nextEntryBtn.TabIndex = 7;
            this.nextEntryBtn.Text = "Next Entry";
            this.nextEntryBtn.UseVisualStyleBackColor = true;
            this.nextEntryBtn.Click += new System.EventHandler(this.nextEntryBtn_Click);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextEntryBtn);
            this.Controls.Add(this.previousEntryBtn);
            this.Controls.Add(this.blankSlateBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.noteEntryTxt);
            this.Controls.Add(this.refreshFileBtn);
            this.Controls.Add(this.outputTxt);
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox outputTxt;
        private Button refreshFileBtn;
        private TextBox noteEntryTxt;
        private Button submitBtn;
        private Button blankSlateBtn;
        private Button previousEntryBtn;
        private Button nextEntryBtn;
    }
}