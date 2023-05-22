namespace oopprojectfinal
{
    partial class Form1
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
            this.label_select_Item = new System.Windows.Forms.Label();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.showPic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label_select_Item
            // 
            this.label_select_Item.AutoSize = true;
            this.label_select_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_select_Item.Location = new System.Drawing.Point(48, 83);
            this.label_select_Item.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_select_Item.Name = "label_select_Item";
            this.label_select_Item.Size = new System.Drawing.Size(173, 37);
            this.label_select_Item.TabIndex = 0;
            this.label_select_Item.Text = "Select item";
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Items.AddRange(new object[] {
            "Shoe",
            "Shirt",
            "Pants"});
            this.comboBoxItem.Location = new System.Drawing.Point(236, 81);
            this.comboBoxItem.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(238, 33);
            this.comboBoxItem.TabIndex = 2;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // panelForm
            // 
            this.panelForm.Location = new System.Drawing.Point(56, 192);
            this.panelForm.Margin = new System.Windows.Forms.Padding(6);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(548, 727);
            this.panelForm.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(516, 56);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 85);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(742, 56);
            this.update_button.Margin = new System.Windows.Forms.Padding(6);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(258, 85);
            this.update_button.TabIndex = 16;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(694, 198);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(6);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 82;
            this.dataGrid.Size = new System.Drawing.Size(1630, 721);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_RowHeaderMouseClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1056, 56);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(230, 85);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // showPic
            // 
            this.showPic.Location = new System.Drawing.Point(1352, 56);
            this.showPic.Margin = new System.Windows.Forms.Padding(6);
            this.showPic.Name = "showPic";
            this.showPic.Size = new System.Drawing.Size(150, 85);
            this.showPic.TabIndex = 18;
            this.showPic.Text = "Show Pic";
            this.showPic.UseVisualStyleBackColor = true;
            this.showPic.Click += new System.EventHandler(this.showPic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2056, 1246);
            this.Controls.Add(this.showPic);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.label_select_Item);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_select_Item;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button showPic;
    }
}

