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
            this.comboBoxShirtSize = new System.Windows.Forms.ComboBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonUnisex = new System.Windows.Forms.RadioButton();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.comboBoxFabric = new System.Windows.Forms.ComboBox();
            this.labelFabric = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxShirtType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "size";
            // 
            // comboBoxShirtSize
            // 
            this.comboBoxShirtSize.FormattingEnabled = true;
            this.comboBoxShirtSize.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.comboBoxShirtSize.Location = new System.Drawing.Point(129, 160);
            this.comboBoxShirtSize.Name = "comboBoxShirtSize";
            this.comboBoxShirtSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShirtSize.TabIndex = 42;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(129, 202);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Color";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(129, 280);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Brand";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(129, 243);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Price";
            // 
            // radioButtonUnisex
            // 
            this.radioButtonUnisex.AutoSize = true;
            this.radioButtonUnisex.Location = new System.Drawing.Point(197, 43);
            this.radioButtonUnisex.Name = "radioButtonUnisex";
            this.radioButtonUnisex.Size = new System.Drawing.Size(57, 17);
            this.radioButtonUnisex.TabIndex = 62;
            this.radioButtonUnisex.TabStop = true;
            this.radioButtonUnisex.Text = "Unisex";
            this.radioButtonUnisex.UseVisualStyleBackColor = true;
            this.radioButtonUnisex.CheckedChanged += new System.EventHandler(this.radioButtonUnisex_CheckedChanged);
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(122, 43);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(62, 17);
            this.radioButtonWoman.TabIndex = 61;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "Woman";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            this.radioButtonWoman.CheckedChanged += new System.EventHandler(this.radioButtonWoman_CheckedChanged);
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(49, 43);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(46, 17);
            this.radioButtonMan.TabIndex = 60;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Man";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            this.radioButtonMan.CheckedChanged += new System.EventHandler(this.radioButtonMan_CheckedChanged);
            // 
            // comboBoxFabric
            // 
            this.comboBoxFabric.FormattingEnabled = true;
            this.comboBoxFabric.Items.AddRange(new object[] {
            "Cotton",
            "Polyester",
            "Linen",
            "Silk",
            "Wool",
            "Denim",
            "Rayon",
            "Spandex or Elastane",
            "Nylon",
            "Viscose"});
            this.comboBoxFabric.Location = new System.Drawing.Point(127, 93);
            this.comboBoxFabric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxFabric.Name = "comboBoxFabric";
            this.comboBoxFabric.Size = new System.Drawing.Size(123, 21);
            this.comboBoxFabric.TabIndex = 66;
            // 
            // labelFabric
            // 
            this.labelFabric.AutoSize = true;
            this.labelFabric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFabric.Location = new System.Drawing.Point(52, 91);
            this.labelFabric.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFabric.Name = "labelFabric";
            this.labelFabric.Size = new System.Drawing.Size(53, 20);
            this.labelFabric.TabIndex = 65;
            this.labelFabric.Text = "Fabric";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Type";
            // 
            // comboBoxShirtType
            // 
            this.comboBoxShirtType.FormattingEnabled = true;
            this.comboBoxShirtType.Location = new System.Drawing.Point(129, 126);
            this.comboBoxShirtType.Name = "comboBoxShirtType";
            this.comboBoxShirtType.Size = new System.Drawing.Size(123, 21);
            this.comboBoxShirtType.TabIndex = 67;
            // 
            // UserControlShirt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxShirtType);
            this.Controls.Add(this.comboBoxFabric);
            this.Controls.Add(this.labelFabric);
            this.Controls.Add(this.radioButtonUnisex);
            this.Controls.Add(this.radioButtonWoman);
            this.Controls.Add(this.radioButtonMan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxShirtSize);
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
        private System.Windows.Forms.ComboBox comboBoxShirtSize;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonUnisex;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.ComboBox comboBoxFabric;
        private System.Windows.Forms.Label labelFabric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxShirtType;
    }
}
