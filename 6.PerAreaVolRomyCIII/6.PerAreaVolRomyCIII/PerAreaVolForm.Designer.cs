namespace _6.PerAreaVolRomyCIII
{
    partial class frmPerAreaVol
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
            this.lblRectangle = new System.Windows.Forms.Label();
            this.lblSphere = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRectangle
            // 
            this.lblRectangle.AutoSize = true;
            this.lblRectangle.Location = new System.Drawing.Point(22, 17);
            this.lblRectangle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRectangle.Name = "lblRectangle";
            this.lblRectangle.Size = new System.Drawing.Size(238, 96);
            this.lblRectangle.TabIndex = 0;
            this.lblRectangle.Text = "What is the area and \r\nperimeter of a \r\nrectangle with a length\r\nof 8cm and a wid" +
    "th of 5cm?";
            // 
            // lblSphere
            // 
            this.lblSphere.AutoSize = true;
            this.lblSphere.Location = new System.Drawing.Point(15, 183);
            this.lblSphere.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSphere.Name = "lblSphere";
            this.lblSphere.Size = new System.Drawing.Size(223, 48);
            this.lblSphere.TabIndex = 1;
            this.lblSphere.Text = "What is the volume of a \r\nsphere with a radius of 8?";
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Location = new System.Drawing.Point(442, 192);
            this.lblAnswer3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(100, 24);
            this.lblAnswer3.TabIndex = 4;
            this.lblAnswer3.Text = "?????????";
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(460, 27);
            this.lblAnswer1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(100, 24);
            this.lblAnswer1.TabIndex = 3;
            this.lblAnswer1.Text = "?????????";
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerimeter.Location = new System.Drawing.Point(283, 15);
            this.btnPerimeter.Margin = new System.Windows.Forms.Padding(6);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Size = new System.Drawing.Size(138, 50);
            this.btnPerimeter.TabIndex = 6;
            this.btnPerimeter.Text = "Calculate \r\n(Perimeter)";
            this.btnPerimeter.UseVisualStyleBackColor = true;
            this.btnPerimeter.Click += new System.EventHandler(this.btnPerimeter_Click);
            // 
            // btnArea
            // 
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(283, 71);
            this.btnArea.Margin = new System.Windows.Forms.Padding(6);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(138, 52);
            this.btnArea.TabIndex = 7;
            this.btnArea.Text = "Calculate\r\n(Area)";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.Location = new System.Drawing.Point(283, 183);
            this.btnVolume.Margin = new System.Windows.Forms.Padding(6);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(138, 42);
            this.btnVolume.TabIndex = 8;
            this.btnVolume.Text = "Calculate";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(460, 84);
            this.lblAnswer2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(100, 24);
            this.lblAnswer2.TabIndex = 9;
            this.lblAnswer2.Text = "?????????";
            // 
            // frmPerAreaVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(636, 264);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerimeter);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.lblSphere);
            this.Controls.Add(this.lblRectangle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPerAreaVol";
            this.Text = "Perimeter, Area, and Volume Calculations Program By Romy I. Chu III";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRectangle;
        private System.Windows.Forms.Label lblSphere;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Button btnPerimeter;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Label lblAnswer2;
    }
}

