namespace LabaInformationTechologics
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TurnOn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.back);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 403);
            this.panel1.TabIndex = 0;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(114, 171);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TurnOn);
            this.panel2.Location = new System.Drawing.Point(687, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 465);
            this.panel2.TabIndex = 1;
            // 
            // TurnOn
            // 
            this.TurnOn.Location = new System.Drawing.Point(241, 416);
            this.TurnOn.Name = "TurnOn";
            this.TurnOn.Size = new System.Drawing.Size(196, 34);
            this.TurnOn.TabIndex = 0;
            this.TurnOn.Text = "Дернуть ручку";
            this.TurnOn.UseVisualStyleBackColor = true;
            this.TurnOn.Click += new System.EventHandler(this.TurnOn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button TurnOn;
    }
}