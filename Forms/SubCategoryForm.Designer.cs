
namespace WindowsFormsApp1.Forms
{
    partial class SubCategoryForm
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
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DELETEBT = new System.Windows.Forms.Button();
            this.UpdateBT = new System.Windows.Forms.Button();
            this.ADDBT = new System.Windows.Forms.Button();
            this.SubCatTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubCatIDTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SUbCatLB = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryCB
            // 
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(270, 37);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(196, 21);
            this.CategoryCB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SubCatIDTB);
            this.groupBox1.Controls.Add(this.DELETEBT);
            this.groupBox1.Controls.Add(this.UpdateBT);
            this.groupBox1.Controls.Add(this.ADDBT);
            this.groupBox1.Controls.Add(this.SubCatTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CategoryCB);
            this.groupBox1.Location = new System.Drawing.Point(-25, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // DELETEBT
            // 
            this.DELETEBT.BackColor = System.Drawing.Color.Red;
            this.DELETEBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETEBT.Location = new System.Drawing.Point(341, 252);
            this.DELETEBT.Name = "DELETEBT";
            this.DELETEBT.Size = new System.Drawing.Size(100, 39);
            this.DELETEBT.TabIndex = 6;
            this.DELETEBT.Text = "DELETE";
            this.DELETEBT.UseVisualStyleBackColor = false;
            this.DELETEBT.Click += new System.EventHandler(this.DELETEBT_Click);
            // 
            // UpdateBT
            // 
            this.UpdateBT.BackColor = System.Drawing.Color.Red;
            this.UpdateBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBT.Location = new System.Drawing.Point(209, 252);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(100, 39);
            this.UpdateBT.TabIndex = 5;
            this.UpdateBT.Text = "UPDATE";
            this.UpdateBT.UseVisualStyleBackColor = false;
            this.UpdateBT.Click += new System.EventHandler(this.UpdateBT_Click);
            // 
            // ADDBT
            // 
            this.ADDBT.BackColor = System.Drawing.Color.Red;
            this.ADDBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDBT.Location = new System.Drawing.Point(77, 252);
            this.ADDBT.Name = "ADDBT";
            this.ADDBT.Size = new System.Drawing.Size(100, 39);
            this.ADDBT.TabIndex = 4;
            this.ADDBT.Text = "ADD";
            this.ADDBT.UseVisualStyleBackColor = false;
            this.ADDBT.Click += new System.EventHandler(this.ADDBT_Click);
            // 
            // SubCatTB
            // 
            this.SubCatTB.Location = new System.Drawing.Point(270, 107);
            this.SubCatTB.Name = "SubCatTB";
            this.SubCatTB.Size = new System.Drawing.Size(196, 20);
            this.SubCatTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "SubCategory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // SubCatIDTB
            // 
            this.SubCatIDTB.Location = new System.Drawing.Point(270, 169);
            this.SubCatIDTB.Name = "SubCatIDTB";
            this.SubCatIDTB.ReadOnly = true;
            this.SubCatIDTB.Size = new System.Drawing.Size(196, 20);
            this.SubCatIDTB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "SubCategory ID";
            // 
            // SUbCatLB
            // 
            this.SUbCatLB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SUbCatLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SUbCatLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUbCatLB.FormattingEnabled = true;
            this.SUbCatLB.ItemHeight = 25;
            this.SUbCatLB.Location = new System.Drawing.Point(495, 12);
            this.SUbCatLB.Name = "SUbCatLB";
            this.SUbCatLB.Size = new System.Drawing.Size(215, 350);
            this.SUbCatLB.TabIndex = 2;
            this.SUbCatLB.SelectedIndexChanged += new System.EventHandler(this.SUbCatLB_SelectedIndexChanged);
            // 
            // SubCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SUbCatLB);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubCategoryForm";
            this.Text = "SubCategoryForm";
            this.Load += new System.EventHandler(this.SubCategoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DELETEBT;
        private System.Windows.Forms.Button UpdateBT;
        private System.Windows.Forms.Button ADDBT;
        private System.Windows.Forms.TextBox SubCatTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubCatIDTB;
        private System.Windows.Forms.ListBox SUbCatLB;
    }
}