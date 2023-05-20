namespace oopprojectfinal.userControls
{
    partial class UserControlPants
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
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonUnisex = new System.Windows.Forms.RadioButton();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPantsType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 53;
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
            this.comboBoxPantsSize.Location = new System.Drawing.Point(130, 162);
            this.comboBoxPantsSize.Name = "comboBoxPantsSize";
            this.comboBoxPantsSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPantsSize.TabIndex = 52;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(130, 204);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Color";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(130, 282);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Brand";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(130, 245);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Price";
            // 
            // radioButtonUnisex
            // 
            this.radioButtonUnisex.AutoSize = true;
            this.radioButtonUnisex.Location = new System.Drawing.Point(203, 37);
            this.radioButtonUnisex.Name = "radioButtonUnisex";
            this.radioButtonUnisex.Size = new System.Drawing.Size(57, 17);
            this.radioButtonUnisex.TabIndex = 59;
            this.radioButtonUnisex.TabStop = true;
            this.radioButtonUnisex.Text = "Unisex";
            this.radioButtonUnisex.UseVisualStyleBackColor = true;
            this.radioButtonUnisex.CheckedChanged += new System.EventHandler(this.radioButtonUnisex_CheckedChanged);
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(128, 37);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(62, 17);
            this.radioButtonWoman.TabIndex = 58;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "Woman";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            this.radioButtonWoman.CheckedChanged += new System.EventHandler(this.radioButtonWoman_CheckedChanged);
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(55, 37);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(46, 17);
            this.radioButtonMan.TabIndex = 57;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Man";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            this.radioButtonMan.CheckedChanged += new System.EventHandler(this.radioButtonMan_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Type";
            // 
            // comboBoxPantsType
            // 
            this.comboBoxPantsType.FormattingEnabled = true;
            this.comboBoxPantsType.Items.AddRange(new object[] {
            "Jeans ",
            "Chinos ",
            "Cargo pants",
            "Sweatpants",
            "Trousers",
            "Harem pants",
            "Track pants",
            "Dress pants",
            "Khaki pants",
            "Corduroy pants",
            "Pleated pants",
            "Jogger pants",
            "Skinny pants"});
            this.comboBoxPantsType.Location = new System.Drawing.Point(130, 90);
            this.comboBoxPantsType.Name = "comboBoxPantsType";
            this.comboBoxPantsType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPantsType.TabIndex = 61;
            // 
            // UserControlPants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPantsType);
            this.Controls.Add(this.radioButtonUnisex);
            this.Controls.Add(this.radioButtonWoman);
            this.Controls.Add(this.radioButtonMan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPantsSize);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.label4);
            this.Name = "UserControlPants";
            this.Size = new System.Drawing.Size(303, 324);
            this.Load += new System.EventHandler(this.UserControlPants_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPantsSize;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonUnisex;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPantsType;
    }
}
