namespace WindowsFormsApplication
{
    partial class MyApp
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
            this.lblenteryourname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnsayhello = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblenteryourname
            // 
            this.lblenteryourname.AutoSize = true;
            this.lblenteryourname.Location = new System.Drawing.Point(10, 11);
            this.lblenteryourname.Name = "lblenteryourname";
            this.lblenteryourname.Size = new System.Drawing.Size(150, 19);
            this.lblenteryourname.TabIndex = 0;
            this.lblenteryourname.Text = "Enter your name:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(166, 8);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(295, 27);
            this.txtname.TabIndex = 1;
            // 
            // btnsayhello
            // 
            this.btnsayhello.BackColor = System.Drawing.Color.Transparent;
            this.btnsayhello.Location = new System.Drawing.Point(11, 55);
            this.btnsayhello.Name = "btnsayhello";
            this.btnsayhello.Size = new System.Drawing.Size(146, 37);
            this.btnsayhello.TabIndex = 2;
            this.btnsayhello.Text = "&Say Hello";
            this.btnsayhello.UseVisualStyleBackColor = false;
            this.btnsayhello.MouseLeave += new System.EventHandler(this.btnsayhello_MouseLeave);
            this.btnsayhello.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnsayhello_MouseMove);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(164, 55);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(146, 37);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(316, 55);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(146, 37);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(12, 123);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 19);
            this.lblresult.TabIndex = 5;
            // 
            // MyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 381);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsayhello);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblenteryourname);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "MyApp";
            this.Text = "MyApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblenteryourname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnsayhello;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblresult;
    }
}