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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label_select_Item
            // 
            this.label_select_Item.AutoSize = true;
            this.label_select_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_select_Item.Location = new System.Drawing.Point(24, 43);
            this.label_select_Item.Name = "label_select_Item";
            this.label_select_Item.Size = new System.Drawing.Size(88, 20);
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
            this.comboBoxItem.Location = new System.Drawing.Point(118, 42);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxItem.TabIndex = 2;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // panelForm
            // 
            this.panelForm.Location = new System.Drawing.Point(28, 100);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(274, 378);
            this.panelForm.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(258, 29);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 44);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(371, 29);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(129, 44);
            this.update_button.TabIndex = 16;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(347, 103);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 82;
            this.dataGrid.Size = new System.Drawing.Size(815, 375);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_RowHeaderMouseClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(528, 29);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(115, 44);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 439);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.label_select_Item);
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
    }
}

