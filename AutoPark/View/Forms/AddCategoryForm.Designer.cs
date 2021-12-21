
using AutoPark.Entity;

namespace AutoPark.View
{
    partial class AddCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.InvalidCategoryText = new System.Windows.Forms.Label();
            this.InvalidCarType = new System.Windows.Forms.Label();
            this.ComboboxType = new AutoPark.Entity.ExtComboBox();
            this.TxtBoxName = new AutoPark.Entity.ExTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(117, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAdd.Enabled = false;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.Location = new System.Drawing.Point(73, 206);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(97, 24);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add ";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type Car";
            // 
            // InvalidCategoryText
            // 
            this.InvalidCategoryText.AutoSize = true;
            this.InvalidCategoryText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InvalidCategoryText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvalidCategoryText.ForeColor = System.Drawing.Color.IndianRed;
            this.InvalidCategoryText.Location = new System.Drawing.Point(46, 94);
            this.InvalidCategoryText.Name = "InvalidCategoryText";
            this.InvalidCategoryText.Size = new System.Drawing.Size(0, 16);
            this.InvalidCategoryText.TabIndex = 6;
            // 
            // InvalidCarType
            // 
            this.InvalidCarType.AutoSize = true;
            this.InvalidCarType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InvalidCarType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvalidCarType.ForeColor = System.Drawing.Color.IndianRed;
            this.InvalidCarType.Location = new System.Drawing.Point(46, 157);
            this.InvalidCarType.Name = "InvalidCarType";
            this.InvalidCarType.Size = new System.Drawing.Size(0, 16);
            this.InvalidCarType.TabIndex = 7;
            // 
            // ComboboxType
            // 
            this.ComboboxType.BackColor = System.Drawing.SystemColors.Menu;
            this.ComboboxType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.ComboboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxType.FormattingEnabled = true;
            this.ComboboxType.IsValid = true;
            this.ComboboxType.Location = new System.Drawing.Point(49, 131);
            this.ComboboxType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ComboboxType.Name = "ComboboxType";
            this.ComboboxType.Size = new System.Drawing.Size(241, 26);
            this.ComboboxType.TabIndex = 5;
            this.ComboboxType.SelectedIndexChanged += new System.EventHandler(this.ComboboxType_SelectedIndexChanged);
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtBoxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.TxtBoxName.IsValid = true;
            this.TxtBoxName.Location = new System.Drawing.Point(50, 68);
            this.TxtBoxName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(241, 26);
            this.TxtBoxName.TabIndex = 3;
            this.TxtBoxName.TextChanged += new System.EventHandler(this.TxtBoxName_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(176, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(346, 242);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InvalidCarType);
            this.Controls.Add(this.InvalidCategoryText);
            this.Controls.Add(this.ComboboxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAdd;
        private ExTextBox TxtBoxName;
        private System.Windows.Forms.Label label3;
        private ExtComboBox ComboboxType;
        private System.Windows.Forms.Label InvalidCategoryText;
        private System.Windows.Forms.Label InvalidCarType;
        private System.Windows.Forms.Button button1;
    }
}