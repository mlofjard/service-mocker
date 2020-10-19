namespace ServiceMocker
{
    partial class MainForm
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
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.clearTokenListButton = new System.Windows.Forms.Button();
            this.autoAllowCheckBox = new System.Windows.Forms.CheckBox();
            this.allowedTokensCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // responseTextBox
            // 
            this.responseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.responseTextBox.Location = new System.Drawing.Point(3, 23);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.Size = new System.Drawing.Size(689, 489);
            this.responseTextBox.TabIndex = 0;
            this.responseTextBox.Text = "{\r\n  hello: \"world\"\r\n}";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.clearTokenListButton);
            this.splitContainer1.Panel1.Controls.Add(this.autoAllowCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.allowedTokensCheckedListBox);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.responseTextBox);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(1049, 515);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Allowed tokens:";
            // 
            // clearTokenListButton
            // 
            this.clearTokenListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearTokenListButton.Location = new System.Drawing.Point(272, 489);
            this.clearTokenListButton.Name = "clearTokenListButton";
            this.clearTokenListButton.Size = new System.Drawing.Size(75, 23);
            this.clearTokenListButton.TabIndex = 2;
            this.clearTokenListButton.Text = "Clear list";
            this.clearTokenListButton.UseVisualStyleBackColor = true;
            this.clearTokenListButton.Click += new System.EventHandler(this.clearTokenListButton_Click);
            // 
            // autoAllowCheckBox
            // 
            this.autoAllowCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoAllowCheckBox.AutoSize = true;
            this.autoAllowCheckBox.Location = new System.Drawing.Point(201, 4);
            this.autoAllowCheckBox.Name = "autoAllowCheckBox";
            this.autoAllowCheckBox.Size = new System.Drawing.Size(146, 19);
            this.autoAllowCheckBox.TabIndex = 1;
            this.autoAllowCheckBox.Text = "Auto allow new tokens";
            this.autoAllowCheckBox.UseVisualStyleBackColor = true;
            // 
            // allowedTokensCheckedListBox
            // 
            this.allowedTokensCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allowedTokensCheckedListBox.FormattingEnabled = true;
            this.allowedTokensCheckedListBox.IntegralHeight = false;
            this.allowedTokensCheckedListBox.Location = new System.Drawing.Point(3, 23);
            this.allowedTokensCheckedListBox.Name = "allowedTokensCheckedListBox";
            this.allowedTokensCheckedListBox.Size = new System.Drawing.Size(344, 460);
            this.allowedTokensCheckedListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Response JSON:";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 530);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1073, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 552);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainForm";
            this.Text = "ServiceMocker v0.0.1-alpha1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button clearTokenListButton;
        public System.Windows.Forms.CheckBox autoAllowCheckBox;
        public System.Windows.Forms.CheckedListBox allowedTokensCheckedListBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label label2;
    }
}

