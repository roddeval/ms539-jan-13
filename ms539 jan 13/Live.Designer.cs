namespace ms539_jan_13
{
    partial class Live
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
            this.components = new System.ComponentModel.Container();
            this.btnGo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblJobSkills = new System.Windows.Forms.Label();
            this.cb_Web = new System.Windows.Forms.CheckBox();
            this.cb_UI = new System.Windows.Forms.CheckBox();
            this.cb_DB = new System.Windows.Forms.CheckBox();
            this.lab_Edu = new System.Windows.Forms.Label();
            this.gb_edu = new System.Windows.Forms.GroupBox();
            this.rb_hs = new System.Windows.Forms.RadioButton();
            this.rb_bs = new System.Windows.Forms.RadioButton();
            this.rb_ms = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gb_edu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(61, 34);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.toolTip1.SetToolTip(this.btnGo, "This is the Go button");
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblJobSkills
            // 
            this.lblJobSkills.AutoSize = true;
            this.lblJobSkills.Location = new System.Drawing.Point(213, 39);
            this.lblJobSkills.Name = "lblJobSkills";
            this.lblJobSkills.Size = new System.Drawing.Size(46, 13);
            this.lblJobSkills.TabIndex = 1;
            this.lblJobSkills.Text = "job skills";
            // 
            // cb_Web
            // 
            this.cb_Web.AutoSize = true;
            this.cb_Web.Location = new System.Drawing.Point(216, 66);
            this.cb_Web.Name = "cb_Web";
            this.cb_Web.Size = new System.Drawing.Size(115, 17);
            this.cb_Web.TabIndex = 2;
            this.cb_Web.Text = "Web Development";
            this.cb_Web.UseVisualStyleBackColor = true;
            // 
            // cb_UI
            // 
            this.cb_UI.AutoSize = true;
            this.cb_UI.Location = new System.Drawing.Point(216, 90);
            this.cb_UI.Name = "cb_UI";
            this.cb_UI.Size = new System.Drawing.Size(79, 17);
            this.cb_UI.TabIndex = 3;
            this.cb_UI.Text = "UI Desogm";
            this.cb_UI.UseVisualStyleBackColor = true;
            // 
            // cb_DB
            // 
            this.cb_DB.AutoSize = true;
            this.cb_DB.Location = new System.Drawing.Point(216, 114);
            this.cb_DB.Name = "cb_DB";
            this.cb_DB.Size = new System.Drawing.Size(72, 17);
            this.cb_DB.TabIndex = 4;
            this.cb_DB.Text = "Database";
            this.cb_DB.UseVisualStyleBackColor = true;
            // 
            // lab_Edu
            // 
            this.lab_Edu.AutoSize = true;
            this.lab_Edu.Location = new System.Drawing.Point(346, 39);
            this.lab_Edu.Name = "lab_Edu";
            this.lab_Edu.Size = new System.Drawing.Size(94, 13);
            this.lab_Edu.TabIndex = 5;
            this.lab_Edu.Text = "Highest Education";
            // 
            // gb_edu
            // 
            this.gb_edu.BackColor = System.Drawing.SystemColors.Window;
            this.gb_edu.Controls.Add(this.radioButton1);
            this.gb_edu.Controls.Add(this.rb_ms);
            this.gb_edu.Controls.Add(this.rb_bs);
            this.gb_edu.Controls.Add(this.rb_hs);
            this.gb_edu.Location = new System.Drawing.Point(349, 66);
            this.gb_edu.Name = "gb_edu";
            this.gb_edu.Size = new System.Drawing.Size(200, 132);
            this.gb_edu.TabIndex = 6;
            this.gb_edu.TabStop = false;
            // 
            // rb_hs
            // 
            this.rb_hs.AutoSize = true;
            this.rb_hs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rb_hs.Location = new System.Drawing.Point(24, 19);
            this.rb_hs.Name = "rb_hs";
            this.rb_hs.Size = new System.Drawing.Size(83, 17);
            this.rb_hs.TabIndex = 0;
            this.rb_hs.TabStop = true;
            this.rb_hs.Text = "High School";
            this.rb_hs.UseVisualStyleBackColor = true;
            // 
            // rb_bs
            // 
            this.rb_bs.AutoSize = true;
            this.rb_bs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb_bs.Location = new System.Drawing.Point(24, 48);
            this.rb_bs.Name = "rb_bs";
            this.rb_bs.Size = new System.Drawing.Size(72, 17);
            this.rb_bs.TabIndex = 1;
            this.rb_bs.TabStop = true;
            this.rb_bs.Text = "Bachelors";
            this.rb_bs.UseVisualStyleBackColor = true;
            // 
            // rb_ms
            // 
            this.rb_ms.AutoSize = true;
            this.rb_ms.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rb_ms.Location = new System.Drawing.Point(24, 77);
            this.rb_ms.Name = "rb_ms";
            this.rb_ms.Size = new System.Drawing.Size(62, 17);
            this.rb_ms.TabIndex = 2;
            this.rb_ms.TabStop = true;
            this.rb_ms.Text = "Masters";
            this.rb_ms.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 100);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Live
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_edu);
            this.Controls.Add(this.lab_Edu);
            this.Controls.Add(this.cb_DB);
            this.Controls.Add(this.cb_UI);
            this.Controls.Add(this.cb_Web);
            this.Controls.Add(this.lblJobSkills);
            this.Controls.Add(this.btnGo);
            this.Name = "Live";
            this.Text = "Live";
            this.gb_edu.ResumeLayout(false);
            this.gb_edu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblJobSkills;
        private System.Windows.Forms.CheckBox cb_Web;
        private System.Windows.Forms.CheckBox cb_UI;
        private System.Windows.Forms.CheckBox cb_DB;
        private System.Windows.Forms.Label lab_Edu;
        private System.Windows.Forms.GroupBox gb_edu;
        private System.Windows.Forms.RadioButton rb_ms;
        private System.Windows.Forms.RadioButton rb_bs;
        private System.Windows.Forms.RadioButton rb_hs;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

