namespace oopprojectfinal
{
    partial class UserControlShoe
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
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxShoeSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.radioButtonUnisex = new System.Windows.Forms.RadioButton();
            this.labelShoeType = new System.Windows.Forms.Label();
            this.comboBoxShoeType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(122, 189);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Color";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(122, 267);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Brand";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(122, 231);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Price";
            // 
            // comboBoxShoeSize
            // 
            this.comboBoxShoeSize.FormattingEnabled = true;
            this.comboBoxShoeSize.Items.AddRange(new object[] {
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30",
            "30.5",
            "31",
            "31.5",
            "32",
            "32.5",
            "33",
            "33.5",
            "34",
            "34.5",
            "35",
            "35.5",
            "36",
            "36.5",
            "37",
            "37.5",
            "38",
            "38.5",
            "39",
            "39.5",
            "40",
            "40.5",
            "41",
            "41.5",
            "42",
            "42.5",
            "43",
            "43.5",
            "44",
            "44.5",
            "45",
            "45.5",
            "46",
            "46.5",
            "47",
            "47.5",
            "48",
            "48.5",
            "49",
            "49.5"});
            this.comboBoxShoeSize.Location = new System.Drawing.Point(122, 148);
            this.comboBoxShoeSize.Name = "comboBoxShoeSize";
            this.comboBoxShoeSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShoeSize.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "size";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(49, 46);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(46, 17);
            this.radioButtonMan.TabIndex = 32;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Man";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            this.radioButtonMan.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(122, 46);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(62, 17);
            this.radioButtonWoman.TabIndex = 33;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "Woman";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            this.radioButtonWoman.CheckedChanged += new System.EventHandler(this.radioButtonWoman_CheckedChanged);
            // 
            // radioButtonUnisex
            // 
            this.radioButtonUnisex.AutoSize = true;
            this.radioButtonUnisex.Location = new System.Drawing.Point(197, 46);
            this.radioButtonUnisex.Name = "radioButtonUnisex";
            this.radioButtonUnisex.Size = new System.Drawing.Size(57, 17);
            this.radioButtonUnisex.TabIndex = 34;
            this.radioButtonUnisex.TabStop = true;
            this.radioButtonUnisex.Text = "Unisex";
            this.radioButtonUnisex.UseVisualStyleBackColor = true;
            this.radioButtonUnisex.CheckedChanged += new System.EventHandler(this.radioButtonUnisex_CheckedChanged);
            // 
            // labelShoeType
            // 
            this.labelShoeType.AutoSize = true;
            this.labelShoeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShoeType.Location = new System.Drawing.Point(45, 85);
            this.labelShoeType.Name = "labelShoeType";
            this.labelShoeType.Size = new System.Drawing.Size(43, 20);
            this.labelShoeType.TabIndex = 36;
            this.labelShoeType.Text = "Type";
            // 
            // comboBoxShoeType
            // 
            this.comboBoxShoeType.FormattingEnabled = true;
            //this.comboBoxShoeType.Items.AddRange(new object[] { ////////////IM DELETEING THIS 
            //"Jeans ",
            //"Chinos ",
            //"Cargo pants",
            //"Sweatpants",
            //"Trousers",
            //"Harem pants",
            //"Track pants",
            //"Dress pants",
            //"Khaki pants",
            //"Corduroy pants",
            //"Pleated pants",
            //"Jogger pants",
            //"Skinny pants"});
            this.comboBoxShoeType.Location = new System.Drawing.Point(122, 84);
            this.comboBoxShoeType.Name = "comboBoxShoeType";
            this.comboBoxShoeType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShoeType.TabIndex = 35;
            // 
            // UserControlShoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelShoeType);
            this.Controls.Add(this.comboBoxShoeType);
            this.Controls.Add(this.radioButtonUnisex);
            this.Controls.Add(this.radioButtonWoman);
            this.Controls.Add(this.radioButtonMan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxShoeSize);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.label4);
            this.Name = "UserControlShoe";
            this.Size = new System.Drawing.Size(303, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxColor;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxPrice;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxBrand;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.RadioButton radioButtonMan;
        public System.Windows.Forms.RadioButton radioButtonWoman;
        public System.Windows.Forms.RadioButton radioButtonUnisex;
        public System.Windows.Forms.Label labelShoeType;
        public System.Windows.Forms.ComboBox comboBoxShoeType;
        public System.Windows.Forms.ComboBox comboBoxShoeSize;
    }
}
