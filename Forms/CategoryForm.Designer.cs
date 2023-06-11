
namespace WindowsFormsApp1.Forms
{
    partial class CategoryForm
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
            this.UIDLB = new System.Windows.Forms.Label();
            this.CatIDTB = new System.Windows.Forms.TextBox();
            this.DELETECategory = new System.Windows.Forms.Button();
            this.EDITCategory = new System.Windows.Forms.Button();
            this.ADDCategory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CatTB = new System.Windows.Forms.TextBox();
            this.CategorySLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.UIDLB);
            this.panel1.Controls.Add(this.CatIDTB);
            this.panel1.Controls.Add(this.DELETECategory);
            this.panel1.Controls.Add(this.EDITCategory);
            this.panel1.Controls.Add(this.ADDCategory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CatTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 275);
            this.panel1.TabIndex = 6;
            // 
            // UIDLB
            // 
            this.UIDLB.AutoSize = true;
            this.UIDLB.BackColor = System.Drawing.SystemColors.Highlight;
            this.UIDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIDLB.Location = new System.Drawing.Point(80, 98);
            this.UIDLB.Name = "UIDLB";
            this.UIDLB.Size = new System.Drawing.Size(105, 20);
            this.UIDLB.TabIndex = 10;
            this.UIDLB.Text = "Category ID";
            // 
            // CatIDTB
            // 
            this.CatIDTB.Location = new System.Drawing.Point(200, 98);
            this.CatIDTB.Name = "CatIDTB";
            this.CatIDTB.ReadOnly = true;
            this.CatIDTB.Size = new System.Drawing.Size(173, 20);
            this.CatIDTB.TabIndex = 9;
            this.CatIDTB.TextChanged += new System.EventHandler(this.CatIDTB_TextChanged);
            // 
            // DELETECategory
            // 
            this.DELETECategory.BackColor = System.Drawing.Color.Red;
            this.DELETECategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETECategory.Location = new System.Drawing.Point(287, 147);
            this.DELETECategory.Name = "DELETECategory";
            this.DELETECategory.Size = new System.Drawing.Size(77, 37);
            this.DELETECategory.TabIndex = 8;
            this.DELETECategory.Text = "DELETE";
            this.DELETECategory.UseVisualStyleBackColor = false;
            this.DELETECategory.Click += new System.EventHandler(this.DELETECategory_Click);
            // 
            // EDITCategory
            // 
            this.EDITCategory.BackColor = System.Drawing.Color.Red;
            this.EDITCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDITCategory.Location = new System.Drawing.Point(187, 147);
            this.EDITCategory.Name = "EDITCategory";
            this.EDITCategory.Size = new System.Drawing.Size(77, 37);
            this.EDITCategory.TabIndex = 7;
            this.EDITCategory.Text = "EDIT";
            this.EDITCategory.UseVisualStyleBackColor = false;
            this.EDITCategory.Click += new System.EventHandler(this.EDITCategory_Click);
            // 
            // ADDCategory
            // 
            this.ADDCategory.BackColor = System.Drawing.Color.Red;
            this.ADDCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDCategory.Location = new System.Drawing.Point(92, 147);
            this.ADDCategory.Name = "ADDCategory";
            this.ADDCategory.Size = new System.Drawing.Size(77, 37);
            this.ADDCategory.TabIndex = 6;
            this.ADDCategory.Text = "ADD";
            this.ADDCategory.UseVisualStyleBackColor = false;
            this.ADDCategory.Click += new System.EventHandler(this.ADDCategory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category Name";
            // 
            // CatTB
            // 
            this.CatTB.Location = new System.Drawing.Point(200, 33);
            this.CatTB.Name = "CatTB";
            this.CatTB.Size = new System.Drawing.Size(173, 20);
            this.CatTB.TabIndex = 4;
            // 
            // CategorySLB
            // 
            this.CategorySLB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CategorySLB.FormattingEnabled = true;
            this.CategorySLB.Location = new System.Drawing.Point(479, 55);
            this.CategorySLB.Name = "CategorySLB";
            this.CategorySLB.Size = new System.Drawing.Size(307, 186);
            this.CategorySLB.TabIndex = 7;
            this.CategorySLB.SelectedIndexChanged += new System.EventHandler(this.CategorySLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category Table";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategorySLB);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UIDLB;
        private System.Windows.Forms.TextBox CatIDTB;
        private System.Windows.Forms.Button DELETECategory;
        private System.Windows.Forms.Button EDITCategory;
        private System.Windows.Forms.Button ADDCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CatTB;
        private System.Windows.Forms.ListBox CategorySLB;
        private System.Windows.Forms.Label label1;
    }
}