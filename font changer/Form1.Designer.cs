
namespace font_changer
{
    partial class Form1
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
            this.RobotoBtn = new System.Windows.Forms.Button();
            this.fnfontBtn = new System.Windows.Forms.Button();
            this.MVBoliBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fontstyleGb = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.changeLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.fontstyleGb.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RobotoBtn
            // 
            this.RobotoBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobotoBtn.Location = new System.Drawing.Point(150, 19);
            this.RobotoBtn.Name = "RobotoBtn";
            this.RobotoBtn.Size = new System.Drawing.Size(107, 44);
            this.RobotoBtn.TabIndex = 0;
            this.RobotoBtn.Text = "Roboto";
            this.RobotoBtn.UseVisualStyleBackColor = true;
            this.RobotoBtn.Click += new System.EventHandler(this.RobotoBtn_Click);
            // 
            // fnfontBtn
            // 
            this.fnfontBtn.Font = new System.Drawing.Font("Burbank Big Cd Bk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnfontBtn.Location = new System.Drawing.Point(6, 19);
            this.fnfontBtn.Name = "fnfontBtn";
            this.fnfontBtn.Size = new System.Drawing.Size(107, 44);
            this.fnfontBtn.TabIndex = 0;
            this.fnfontBtn.Text = "burbank big";
            this.fnfontBtn.UseVisualStyleBackColor = true;
            this.fnfontBtn.Click += new System.EventHandler(this.fnfontBtn_Click);
            // 
            // MVBoliBtn
            // 
            this.MVBoliBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MVBoliBtn.Location = new System.Drawing.Point(279, 19);
            this.MVBoliBtn.Name = "MVBoliBtn";
            this.MVBoliBtn.Size = new System.Drawing.Size(107, 44);
            this.MVBoliBtn.TabIndex = 0;
            this.MVBoliBtn.Text = "MV Boli";
            this.MVBoliBtn.UseVisualStyleBackColor = true;
            this.MVBoliBtn.Click += new System.EventHandler(this.MVBoliBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fnfontBtn);
            this.groupBox1.Controls.Add(this.RobotoBtn);
            this.groupBox1.Controls.Add(this.MVBoliBtn);
            this.groupBox1.Location = new System.Drawing.Point(111, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font type";
            // 
            // fontstyleGb
            // 
            this.fontstyleGb.Controls.Add(this.checkBox3);
            this.fontstyleGb.Controls.Add(this.checkBox2);
            this.fontstyleGb.Controls.Add(this.checkBox1);
            this.fontstyleGb.Location = new System.Drawing.Point(111, 122);
            this.fontstyleGb.Name = "fontstyleGb";
            this.fontstyleGb.Size = new System.Drawing.Size(393, 71);
            this.fontstyleGb.TabIndex = 3;
            this.fontstyleGb.TabStop = false;
            this.fontstyleGb.Text = "Font style";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(111, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 71);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Font size";
            // 
            // changeLbl
            // 
            this.changeLbl.AutoSize = true;
            this.changeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLbl.Location = new System.Drawing.Point(203, 314);
            this.changeLbl.Name = "changeLbl";
            this.changeLbl.Size = new System.Drawing.Size(145, 29);
            this.changeLbl.TabIndex = 4;
            this.changeLbl.Text = "font changer";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(482, 314);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(106, 37);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(6, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "underline";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(150, 32);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Bold";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(279, 32);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Italic";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "small";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(150, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "medium";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(279, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "large";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 363);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.changeLbl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.fontstyleGb);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.fontstyleGb.ResumeLayout(false);
            this.fontstyleGb.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RobotoBtn;
        private System.Windows.Forms.Button fnfontBtn;
        private System.Windows.Forms.Button MVBoliBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox fontstyleGb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label changeLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

