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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblHelloWorldInt
            // 
            this.lblHelloWorldInt.AutoSize = true;
            this.lblHelloWorldInt.BackColor = System.Drawing.Color.Gray;
            this.lblHelloWorldInt.Font = new System.Drawing.Font("Stencil Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorldInt.Location = new System.Drawing.Point(126, 9);
            this.lblHelloWorldInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelloWorldInt.Name = "lblHelloWorldInt";
            this.lblHelloWorldInt.Size = new System.Drawing.Size(561, 84);
            this.lblHelloWorldInt.TabIndex = 0;
            this.lblHelloWorldInt.Text = "Hello, World!";
            this.lblHelloWorldInt.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(182, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(845, 268);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHelloWorldInt);
            this.Font = new System.Drawing.Font("Stencil Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmHelloWorldInt";
            this.Text = "\"Hello, World!\" International By Romy I. Chu III";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorldInt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

