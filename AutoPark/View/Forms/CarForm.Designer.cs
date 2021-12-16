
using AutoPark.Entity;

namespace AutoPark
{
    partial class CarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new AutoPark.Entity.ExtComboBox();
            this.ComboBoxTypeCar = new ExtComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelImageName = new System.Windows.Forms.Label();
            this.InvalidModelText = new System.Windows.Forms.Label();
            this.InvalidCarNumberText = new System.Windows.Forms.Label();
            this.InvalidTypeBox = new System.Windows.Forms.Label();
            this.InvalidCategoryText = new System.Windows.Forms.Label();
            this.CarNumber = new AutoPark.Entity.ExTextBox();
            this.CarModel = new AutoPark.Entity.ExTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(113, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(151, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Car";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.CategoryComboBox.BorderColor = System.Drawing.Color.Transparent;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.IsValid = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(45, 255);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(267, 26);
            this.CategoryComboBox.TabIndex = 8;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // ComboBoxTypeCar
            // 
            this.ComboBoxTypeCar.BackColor = System.Drawing.SystemColors.Menu;
            this.ComboBoxTypeCar.FormattingEnabled = true;
            this.ComboBoxTypeCar.Location = new System.Drawing.Point(45, 192);
            this.ComboBoxTypeCar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ComboBoxTypeCar.Name = "ComboBoxTypeCar";
            this.ComboBoxTypeCar.Size = new System.Drawing.Size(267, 26);
            this.ComboBoxTypeCar.TabIndex = 9;
            this.ComboBoxTypeCar.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTypeCar_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Image";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Import...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelImageName
            // 
            this.labelImageName.AutoSize = true;
            this.labelImageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelImageName.Location = new System.Drawing.Point(131, 331);
            this.labelImageName.Name = "labelImageName";
            this.labelImageName.Size = new System.Drawing.Size(51, 18);
            this.labelImageName.TabIndex = 13;
            this.labelImageName.Text = "Image";
            // 
            // InvalidModelText
            // 
            this.InvalidModelText.AutoSize = true;
            this.InvalidModelText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvalidModelText.ForeColor = System.Drawing.Color.IndianRed;
            this.InvalidModelText.Location = new System.Drawing.Point(42, 89);
            this.InvalidModelText.Name = "InvalidModelText";
            this.InvalidModelText.Size = new System.Drawing.Size(0, 16);
            this.InvalidModelText.TabIndex = 15;
            // 
            // InvalidCarNumberText
            // 
            this.InvalidCarNumberText.AutoSize = true;
            this.InvalidCarNumberText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvalidCarNumberText.ForeColor = System.Drawing.Color.IndianRed;
            this.InvalidCarNumberText.Location = new System.Drawing.Point(42, 155);
            this.InvalidCarNumberText.Name = "InvalidCarNumberText";
            this.InvalidCarNumberText.Size = new System.Drawing.Size(0, 16);
            this.InvalidCarNumberText.TabIndex = 16;
            // 
            // InvalidTypeBox
            // 
            this.InvalidTypeBox.AutoSize = true;
            this.InvalidTypeBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvalidTypeBox.ForeColor = System.Drawing.Color.IndianRed;
            this.InvalidTypeBox.Location = new System.Drawing.Point(42, 218);
            this.InvalidTypeBox.Name = "InvalidTypeBox";
            this.InvalidTypeBox.Size = new System.Drawing.Size(0, 16);
            this.InvalidTypeBox.TabIndex = 17;
            // 
            // InvalidCategoryText
            // 
            this.InvalidCategoryText.AutoSize = true;
            this.InvalidCategoryText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvalidCategoryText.ForeColor = System.Drawing.Color.IndianRed;
            this.InvalidCategoryText.Location = new System.Drawing.Point(42, 284);
            this.InvalidCategoryText.Name = "InvalidCategoryText";
            this.InvalidCategoryText.Size = new System.Drawing.Size(0, 16);
            this.InvalidCategoryText.TabIndex = 18;
            // 
            // CarNumber
            // 
            this.CarNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.CarNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.CarNumber.IsValid = true;
            this.CarNumber.Location = new System.Drawing.Point(45, 129);
            this.CarNumber.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.CarNumber.Name = "CarNumber";
            this.CarNumber.Size = new System.Drawing.Size(267, 26);
            this.CarNumber.TabIndex = 3;
            this.CarNumber.TextChanged += new System.EventHandler(this.CarNumber_TextChanged);
            // 
            // CarModel
            // 
            this.CarModel.BackColor = System.Drawing.SystemColors.Menu;
            this.CarModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.CarModel.IsValid = true;
            this.CarModel.Location = new System.Drawing.Point(45, 63);
            this.CarModel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.CarModel.Name = "CarModel";
            this.CarModel.Size = new System.Drawing.Size(267, 26);
            this.CarModel.TabIndex = 1;
            this.CarModel.TextChanged += new System.EventHandler(this.CarModel_TextChanged_1);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(368, 441);
            this.Controls.Add(this.InvalidCategoryText);
            this.Controls.Add(this.InvalidTypeBox);
            this.Controls.Add(this.InvalidCarNumberText);
            this.Controls.Add(this.InvalidModelText);
            this.Controls.Add(this.labelImageName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboBoxTypeCar);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CarNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CarModel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private ExtComboBox CategoryComboBox;
        private ExtComboBox ComboBoxTypeCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelImageName;
        private System.Windows.Forms.Label InvalidModelText;
        private ExTextBox CarModel;
        private ExTextBox CarNumber;
        private System.Windows.Forms.Label InvalidCarNumberText;
        private System.Windows.Forms.Label InvalidTypeBox;
        private System.Windows.Forms.Label InvalidCategoryText;
    }
}