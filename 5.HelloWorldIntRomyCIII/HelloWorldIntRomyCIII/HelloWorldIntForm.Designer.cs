namespace HelloWorldIntRomyCIII
{
    partial class frmHelloWorldInt
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
            this.lblHelloWorldInt = new System.Windows.Forms.Label();
            this.grbLanguages = new System.Windows.Forms.GroupBox();
            this.radArabic = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radTagalog = new System.Windows.Forms.RadioButton();
            this.radJapanese = new System.Windows.Forms.RadioButton();
            this.radChineseTrad = new System.Windows.Forms.RadioButton();
            this.grbLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelloWorldInt
            // 
            this.lblHelloWorldInt.AutoSize = true;
            this.lblHelloWorldInt.BackColor = System.Drawing.Color.Gray;
            this.lblHelloWorldInt.Font = new System.Drawing.Font("Stencil Std", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorldInt.Location = new System.Drawing.Point(84, 9);
            this.lblHelloWorldInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelloWorldInt.Name = "lblHelloWorldInt";
            this.lblHelloWorldInt.Size = new System.Drawing.Size(423, 63);
            this.lblHelloWorldInt.TabIndex = 0;
            this.lblHelloWorldInt.Text = "Hello, World!";
            // 
            // grbLanguages
            // 
            this.grbLanguages.Controls.Add(this.radChineseTrad);
            this.grbLanguages.Controls.Add(this.radJapanese);
            this.grbLanguages.Controls.Add(this.radTagalog);
            this.grbLanguages.Controls.Add(this.radEnglish);
            this.grbLanguages.Controls.Add(this.radArabic);
            this.grbLanguages.Location = new System.Drawing.Point(8, 106);
            this.grbLanguages.Name = "grbLanguages";
            this.grbLanguages.Size = new System.Drawing.Size(585, 146);
            this.grbLanguages.TabIndex = 1;
            this.grbLanguages.TabStop = false;
            this.grbLanguages.Text = "Languages";
            // 
            // radArabic
            // 
            this.radArabic.AutoSize = true;
            this.radArabic.Font = new System.Drawing.Font("Stencil Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radArabic.Location = new System.Drawing.Point(28, 56);
            this.radArabic.Name = "radArabic";
            this.radArabic.Size = new System.Drawing.Size(72, 32);
            this.radArabic.TabIndex = 0;
            this.radArabic.TabStop = true;
            this.radArabic.Text = "عربى";
            this.radArabic.UseVisualStyleBackColor = true;
            this.radArabic.CheckedChanged += new System.EventHandler(this.radArabic_CheckedChanged);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Font = new System.Drawing.Font("Stencil Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEnglish.Location = new System.Drawing.Point(222, 18);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(128, 32);
            this.radEnglish.TabIndex = 4;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // radTagalog
            // 
            this.radTagalog.AutoSize = true;
            this.radTagalog.Font = new System.Drawing.Font("Stencil Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTagalog.Location = new System.Drawing.Point(434, 56);
            this.radTagalog.Name = "radTagalog";
            this.radTagalog.Size = new System.Drawing.Size(132, 32);
            this.radTagalog.TabIndex = 5;
            this.radTagalog.TabStop = true;
            this.radTagalog.Text = "Tagalog";
            this.radTagalog.UseVisualStyleBackColor = true;
            this.radTagalog.CheckedChanged += new System.EventHandler(this.radTagalog_CheckedChanged);
            // 
            // radJapanese
            // 
            this.radJapanese.AutoSize = true;
            this.radJapanese.Font = new System.Drawing.Font("Stencil Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radJapanese.Location = new System.Drawing.Point(278, 56);
            this.radJapanese.Name = "radJapanese";
            this.radJapanese.Size = new System.Drawing.Size(99, 32);
            this.radJapanese.TabIndex = 6;
            this.radJapanese.TabStop = true;
            this.radJapanese.Text = "日本人";
            this.radJapanese.UseVisualStyleBackColor = true;
            this.radJapanese.CheckedChanged += new System.EventHandler(this.radJapanese_CheckedChanged);
            // 
            // radChineseTrad
            // 
            this.radChineseTrad.AutoSize = true;
            this.radChineseTrad.Font = new System.Drawing.Font("Stencil Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChineseTrad.Location = new System.Drawing.Point(152, 56);
            this.radChineseTrad.Name = "radChineseTrad";
            this.radChineseTrad.Size = new System.Drawing.Size(76, 32);
            this.radChineseTrad.TabIndex = 7;
            this.radChineseTrad.TabStop = true;
            this.radChineseTrad.Text = "中文";
            this.radChineseTrad.UseVisualStyleBackColor = true;
            this.radChineseTrad.CheckedChanged += new System.EventHandler(this.radChineseTrad_CheckedChanged);
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(610, 268);
            this.Controls.Add(this.grbLanguages);
            this.Controls.Add(this.lblHelloWorldInt);
            this.Font = new System.Drawing.Font("Stencil Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmHelloWorldInt";
            this.Text = "\"Hello, World!\" International By Romy I. Chu III";
            this.grbLanguages.ResumeLayout(false);
            this.grbLanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorldInt;
        private System.Windows.Forms.GroupBox grbLanguages;
        private System.Windows.Forms.RadioButton radChineseTrad;
        private System.Windows.Forms.RadioButton radJapanese;
        private System.Windows.Forms.RadioButton radTagalog;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radArabic;
    }
}

