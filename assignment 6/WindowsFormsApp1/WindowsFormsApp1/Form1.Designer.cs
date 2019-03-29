namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ssadsadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtName = new System.Windows.Forms.Label();
            this.lblenrollment = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radiomale = new System.Windows.Forms.RadioButton();
            this.rdbtnfemale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssadsadsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 28);
            // 
            // ssadsadsToolStripMenuItem
            // 
            this.ssadsadsToolStripMenuItem.Name = "ssadsadsToolStripMenuItem";
            this.ssadsadsToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.ssadsadsToolStripMenuItem.Text = "ssadsads";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(61, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(45, 17);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // lblenrollment
            // 
            this.lblenrollment.AutoSize = true;
            this.lblenrollment.Location = new System.Drawing.Point(61, 105);
            this.lblenrollment.Name = "lblenrollment";
            this.lblenrollment.Size = new System.Drawing.Size(74, 17);
            this.lblenrollment.TabIndex = 2;
            this.lblenrollment.Text = "enrollment";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(61, 151);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(41, 17);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "email";
            this.lblemail.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(61, 191);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(56, 17);
            this.lblgender.TabIndex = 4;
            this.lblgender.Text = "Gender";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(64, 239);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(87, 17);
            this.lbldob.TabIndex = 5;
            this.lbldob.Text = "Date of Birth";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 22);
            this.textBox3.TabIndex = 8;
            // 
            // radiomale
            // 
            this.radiomale.AutoSize = true;
            this.radiomale.Location = new System.Drawing.Point(178, 191);
            this.radiomale.Name = "radiomale";
            this.radiomale.Size = new System.Drawing.Size(59, 21);
            this.radiomale.TabIndex = 9;
            this.radiomale.TabStop = true;
            this.radiomale.Text = "Male";
            this.radiomale.UseVisualStyleBackColor = true;
            // 
            // rdbtnfemale
            // 
            this.rdbtnfemale.AutoSize = true;
            this.rdbtnfemale.Location = new System.Drawing.Point(295, 191);
            this.rdbtnfemale.Name = "rdbtnfemale";
            this.rdbtnfemale.Size = new System.Drawing.Size(75, 21);
            this.rdbtnfemale.TabIndex = 10;
            this.rdbtnfemale.TabStop = true;
            this.rdbtnfemale.Text = "Female";
            this.rdbtnfemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(332, 305);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 12;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 352);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rdbtnfemale);
            this.Controls.Add(this.radiomale);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblenrollment);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ssadsadsToolStripMenuItem;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label lblenrollment;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radiomale;
        private System.Windows.Forms.RadioButton rdbtnfemale;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnsubmit;
    }
}

