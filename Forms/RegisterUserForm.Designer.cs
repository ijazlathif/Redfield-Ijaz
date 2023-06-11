
namespace WindowsFormsApp1.Forms
{
    partial class RegisterUserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddUserTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddPasswordTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UIDLB = new System.Windows.Forms.Label();
            this.UIDTB = new System.Windows.Forms.TextBox();
            this.DELETEUSER = new System.Windows.Forms.Button();
            this.EDITUSER = new System.Windows.Forms.Button();
            this.ADDUSER = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ApproveTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UsersGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUserTB
            // 
            this.AddUserTB.Location = new System.Drawing.Point(210, 51);
            this.AddUserTB.Name = "AddUserTB";
            this.AddUserTB.Size = new System.Drawing.Size(173, 20);
            this.AddUserTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserName";
            // 
            // AddPasswordTB
            // 
            this.AddPasswordTB.Location = new System.Drawing.Point(210, 108);
            this.AddPasswordTB.Name = "AddPasswordTB";
            this.AddPasswordTB.Size = new System.Drawing.Size(173, 20);
            this.AddPasswordTB.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.labelCount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ApproveTB);
            this.panel1.Controls.Add(this.UIDLB);
            this.panel1.Controls.Add(this.UIDTB);
            this.panel1.Controls.Add(this.DELETEUSER);
            this.panel1.Controls.Add(this.EDITUSER);
            this.panel1.Controls.Add(this.ADDUSER);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AddUserTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddPasswordTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 532);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UIDLB
            // 
            this.UIDLB.AutoSize = true;
            this.UIDLB.BackColor = System.Drawing.SystemColors.Highlight;
            this.UIDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIDLB.Location = new System.Drawing.Point(137, 170);
            this.UIDLB.Name = "UIDLB";
            this.UIDLB.Size = new System.Drawing.Size(66, 20);
            this.UIDLB.TabIndex = 10;
            this.UIDLB.Text = "UserID";
            // 
            // UIDTB
            // 
            this.UIDTB.Location = new System.Drawing.Point(210, 170);
            this.UIDTB.Name = "UIDTB";
            this.UIDTB.ReadOnly = true;
            this.UIDTB.Size = new System.Drawing.Size(173, 20);
            this.UIDTB.TabIndex = 9;
            // 
            // DELETEUSER
            // 
            this.DELETEUSER.BackColor = System.Drawing.Color.Red;
            this.DELETEUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETEUSER.Location = new System.Drawing.Point(276, 310);
            this.DELETEUSER.Name = "DELETEUSER";
            this.DELETEUSER.Size = new System.Drawing.Size(92, 37);
            this.DELETEUSER.TabIndex = 8;
            this.DELETEUSER.Text = "DELETE";
            this.DELETEUSER.UseVisualStyleBackColor = false;
            this.DELETEUSER.Click += new System.EventHandler(this.DELETEUSER_Click);
            // 
            // EDITUSER
            // 
            this.EDITUSER.BackColor = System.Drawing.Color.Red;
            this.EDITUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDITUSER.Location = new System.Drawing.Point(195, 310);
            this.EDITUSER.Name = "EDITUSER";
            this.EDITUSER.Size = new System.Drawing.Size(75, 37);
            this.EDITUSER.TabIndex = 7;
            this.EDITUSER.Text = "EDIT";
            this.EDITUSER.UseVisualStyleBackColor = false;
            this.EDITUSER.Click += new System.EventHandler(this.EDITUSER_Click);
            // 
            // ADDUSER
            // 
            this.ADDUSER.BackColor = System.Drawing.Color.Red;
            this.ADDUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDUSER.Location = new System.Drawing.Point(100, 310);
            this.ADDUSER.Name = "ADDUSER";
            this.ADDUSER.Size = new System.Drawing.Size(77, 37);
            this.ADDUSER.TabIndex = 6;
            this.ADDUSER.Text = "ADD";
            this.ADDUSER.UseVisualStyleBackColor = false;
            this.ADDUSER.Click += new System.EventHandler(this.ADDUSER_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // ApproveTB
            // 
            this.ApproveTB.Location = new System.Drawing.Point(210, 240);
            this.ApproveTB.Name = "ApproveTB";
            this.ApproveTB.Size = new System.Drawing.Size(173, 20);
            this.ApproveTB.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "User Status";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UsersGV
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UsersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGV.EnableHeadersVisualStyles = false;
            this.UsersGV.GridColor = System.Drawing.Color.Red;
            this.UsersGV.Location = new System.Drawing.Point(425, 51);
            this.UsersGV.Name = "UsersGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UsersGV.Size = new System.Drawing.Size(514, 313);
            this.UsersGV.TabIndex = 7;
            this.UsersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGV_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Users Table";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(206, 453);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(105, 20);
            this.labelCount.TabIndex = 13;
            this.labelCount.Text = "User Status";
            this.labelCount.Click += new System.EventHandler(this.labelCount_Click);
            // 
            // RegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 532);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UsersGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "RegisterUserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.RegisterUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddUserTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddPasswordTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DELETEUSER;
        private System.Windows.Forms.Button EDITUSER;
        private System.Windows.Forms.Button ADDUSER;
        private System.Windows.Forms.Label UIDLB;
        private System.Windows.Forms.TextBox UIDTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ApproveTB;
        private System.Windows.Forms.DataGridView UsersGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCount;
    }
}