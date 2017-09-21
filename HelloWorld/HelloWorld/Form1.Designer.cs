namespace HelloWorld
{
    partial class frmHelloWorld
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
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHelloWorld.Location = new System.Drawing.Point(315, 277);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(113, 23);
            this.btnHelloWorld.TabIndex = 0;
            this.btnHelloWorld.Text = "Show Hello World";
            this.btnHelloWorld.UseVisualStyleBackColor = true;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.ForeColor = System.Drawing.Color.Red;
            this.lblHelloWorld.Location = new System.Drawing.Point(202, 135);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(0, 80);
            this.lblHelloWorld.TabIndex = 1;
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 312);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnHelloWorld);
            this.MinimumSize = new System.Drawing.Size(351, 225);
            this.Name = "frmHelloWorld";
            this.Text = "HelloWorld";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

