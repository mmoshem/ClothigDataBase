namespace oopprojectfinal.userControls
{
    partial class UserControlShirt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPantsSize = new System.Windows.Forms.ComboBox();
            this.checkBoxHasHeel = new System.Windows.Forms.CheckBox();
            this.checkBoxHaslace = new System.Windows.Forms.CheckBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "size";
            // 
            // comboBoxPantsSize
            // 
            this.comboBoxPantsSize.FormattingEnabled = true;
            this.comboBoxPantsSize.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.comboBoxPantsSize.Location = new System.Drawing.Point(128, 43);
            this.comboBoxPantsSize.Name = "comboBoxPantsSize";
            this.comboBoxPantsSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPantsSize.TabIndex = 42;
            // 
            // checkBoxHasHeel
            // 
            this.checkBoxHasHeel.AutoSize = true;
            this.checkBoxHasHeel.Location = new System.Drawing.Point(55, 250);
            this.checkBoxHasHeel.Name = "checkBoxHasHeel";
            this.checkBoxHasHeel.Size = new System.Drawing.Size(67, 17);
            this.checkBoxHasHeel.TabIndex = 41;
            this.checkBoxHasHeel.Text = "HasHeel";
            this.checkBoxHasHeel.UseVisualStyleBackColor = true;
            // 
            // checkBoxHaslace
            // 
            this.checkBoxHaslace.AutoSize = true;
            this.checkBoxHaslace.Location = new System.Drawing.Point(55, 210);
            this.checkBoxHaslace.Name = "checkBoxHaslace";
            this.checkBoxHaslace.Size = new System.Drawing.Size(68, 17);
            this.checkBoxHaslace.TabIndex = 40;
            this.checkBoxHaslace.Text = "Has lace";
            this.checkBoxHaslace.UseVisualStyleBackColor = true;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(128, 85);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Color";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(128, 163);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Brand";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(128, 126);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Price";
            // 
            // UserControlShirt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPantsSize);
            this.Controls.Add(this.checkBoxHasHeel);
            this.Controls.Add(this.checkBoxHaslace);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.label4);
            this.Name = "UserControlShirt";
            this.Size = new System.Drawing.Size(303, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPantsSize;
        private System.Windows.Forms.CheckBox checkBoxHasHeel;
        private System.Windows.Forms.CheckBox checkBoxHaslace;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label label4;
    }
}
