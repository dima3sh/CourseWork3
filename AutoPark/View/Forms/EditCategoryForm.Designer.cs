
using AutoPark.Entity;

namespace AutoPark.View
{
    partial class EditCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCategoryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new AutoPark.Entity.ExtComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxName = new AutoPark.Entity.ExTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Label();
            this.ComboBoxType = new AutoPark.Entity.ExtComboBox();
            this.InvalidCategoriesText = new System.Windows.Forms.Label();
            this.InvalidCategory = new System.Windows.Forms.Label();
            this.InvalidNameText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categories";
            // 
            // comboBox1
            // 
            this.comboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IsValid = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 83);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 26);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.TxtBoxName.IsValid = true;
            this.TxtBoxName.Location = new System.Drawing.Point(47, 212);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(257, 26);
            this.TxtBoxName.TabIndex = 4;
            this.TxtBoxName.TextChanged += new System.EventHandler(this.TxtBoxName_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(46, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(134, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(222, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(44, 128);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(41, 18);
            this.Type.TabIndex = 8;
            this.Type.Text = "Type";
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.IsValid = true;
            this.ComboBoxType.Location = new System.Drawing.Point(47, 149);
            this.ComboBoxType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(257, 26);
            this.ComboBoxType.TabIndex = 9;
            this.ComboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // InvalidCategoriesText
            // 
            this.InvalidCategoriesText.AutoSize = true;
            this.InvalidCategoriesText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvalidCategoriesText.ForeColor = System.Drawing.Color.IndianRed;
            this.InvalidCategoriesText.Location = new System.Drawing.Point(45, 112);
            this.InvalidCategoriesText.Name = "InvalidCategoriesText";
            this.InvalidCategoriesText.Size = new System.Drawing.Size(0, 16);
            this.InvalidCategoriesText.TabIndex = 10;
            // 
            // InvalidCategory
            // 
            this.InvalidCategory.AutoSize = true;
            this.InvalidCategory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvalidCategory.ForeColor = System.Drawing.Color.IndianRed;
            this.InvalidCategory.Location = new System.Drawing.Point(45, 175);
            this.InvalidCategory.Name = "InvalidCategory";
            this.InvalidCategory.Size = new System.Drawing.Size(0, 16);
            this.InvalidCategory.TabIndex = 11;
            // 
            // InvalidNameText
            // 
            this.InvalidNameText.AutoSize = true;
            this.InvalidNameText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvalidNameText.ForeColor = System.Drawing.Color.IndianRed;
            this.InvalidNameText.Location = new System.Drawing.Point(45, 241);
            this.InvalidNameText.Name = "InvalidNameText";
            this.InvalidNameText.Size = new System.Drawing.Size(0, 16);
            this.InvalidNameText.TabIndex = 12;
            // 
            // EditCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 330);
            this.Controls.Add(this.InvalidNameText);
            this.Controls.Add(this.InvalidCategory);
            this.Controls.Add(this.InvalidCategoriesText);
            this.Controls.Add(this.ComboBoxType);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Category";
            this.Load += new System.EventHandler(this.EditCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ExtComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private ExTextBox TxtBoxName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Type;
        private ExtComboBox ComboBoxType;
        private System.Windows.Forms.Label InvalidCategoriesText;
        private System.Windows.Forms.Label InvalidCategory;
        private System.Windows.Forms.Label InvalidNameText;
    }
}