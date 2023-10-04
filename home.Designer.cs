namespace project.cs
{
    partial class home
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnstd = new System.Windows.Forms.Button();
            this.btndept = new System.Windows.Forms.Button();
            this.btnteac = new System.Windows.Forms.Button();
            this.btnatten = new System.Windows.Forms.Button();
            this.btnfees = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "College Management System";
            // 
            // btnstd
            // 
            this.btnstd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnstd.BackColor = System.Drawing.Color.Transparent;
            this.btnstd.BackgroundImage = global::project.cs.Properties.Resources.img91;
            this.btnstd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstd.Location = new System.Drawing.Point(202, 196);
            this.btnstd.Name = "btnstd";
            this.btnstd.Size = new System.Drawing.Size(221, 145);
            this.btnstd.TabIndex = 6;
            this.btnstd.UseVisualStyleBackColor = false;
            this.btnstd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndept
            // 
            this.btndept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndept.BackColor = System.Drawing.Color.Black;
            this.btndept.BackgroundImage = global::project.cs.Properties.Resources.img01;
            this.btndept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndept.Location = new System.Drawing.Point(614, 361);
            this.btndept.Name = "btndept";
            this.btndept.Size = new System.Drawing.Size(232, 166);
            this.btndept.TabIndex = 7;
            this.btndept.UseVisualStyleBackColor = false;
            this.btndept.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnteac
            // 
            this.btnteac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnteac.BackColor = System.Drawing.Color.Black;
            this.btnteac.BackgroundImage = global::project.cs.Properties.Resources.img101;
            this.btnteac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnteac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnteac.Location = new System.Drawing.Point(981, 196);
            this.btnteac.Name = "btnteac";
            this.btnteac.Size = new System.Drawing.Size(201, 145);
            this.btnteac.TabIndex = 8;
            this.btnteac.UseVisualStyleBackColor = false;
            this.btnteac.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnatten
            // 
            this.btnatten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnatten.BackColor = System.Drawing.Color.Black;
            this.btnatten.BackgroundImage = global::project.cs.Properties.Resources.img82;
            this.btnatten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnatten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatten.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnatten.Location = new System.Drawing.Point(183, 533);
            this.btnatten.Name = "btnatten";
            this.btnatten.Size = new System.Drawing.Size(254, 155);
            this.btnatten.TabIndex = 9;
            this.btnatten.UseVisualStyleBackColor = false;
            this.btnatten.Click += new System.EventHandler(this.btnatten_Click);
            // 
            // btnfees
            // 
            this.btnfees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfees.BackColor = System.Drawing.Color.Black;
            this.btnfees.BackgroundImage = global::project.cs.Properties.Resources.img111;
            this.btnfees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnfees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfees.Location = new System.Drawing.Point(1005, 543);
            this.btnfees.Name = "btnfees";
            this.btnfees.Size = new System.Drawing.Size(207, 145);
            this.btnfees.TabIndex = 10;
            this.btnfees.UseVisualStyleBackColor = false;
            this.btnfees.Click += new System.EventHandler(this.btnfees_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 800);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1427, 27);
            this.panel2.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackColor = System.Drawing.Color.LightSlateGray;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1180, 707);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 46);
            this.button3.TabIndex = 16;
            this.button3.Text = "LOGOUT";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::project.cs.Properties.Resources.img7_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1427, 827);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnfees);
            this.Controls.Add(this.btnatten);
            this.Controls.Add(this.btnteac);
            this.Controls.Add(this.btndept);
            this.Controls.Add(this.btnstd);
            this.Controls.Add(this.panel1);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnstd;
        private System.Windows.Forms.Button btndept;
        private System.Windows.Forms.Button btnteac;
        private System.Windows.Forms.Button btnatten;
        private System.Windows.Forms.Button btnfees;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
    }
}