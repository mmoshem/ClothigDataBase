﻿namespace oopprojectfinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_select_Item = new System.Windows.Forms.Label();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.showPic = new System.Windows.Forms.Button();
            this.pictureHolder = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // label_select_Item
            // 
            this.label_select_Item.AutoSize = true;
            this.label_select_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_select_Item.Location = new System.Drawing.Point(48, 82);
            this.label_select_Item.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.comboBoxItem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(239, 33);
            this.comboBoxItem.TabIndex = 2;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // panelForm
            // 
            this.panelForm.Location = new System.Drawing.Point(56, 192);
            this.panelForm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(548, 728);
            this.panelForm.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.ForeColor = System.Drawing.Color.Coral;
            this.buttonAdd.Location = new System.Drawing.Point(717, 62);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(173, 68);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.White;
            this.update_button.ForeColor = System.Drawing.Color.YellowGreen;
            this.update_button.Location = new System.Drawing.Point(1011, 62);
            this.update_button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(173, 68);
            this.update_button.TabIndex = 16;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(693, 198);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 82;
            this.dataGrid.Size = new System.Drawing.Size(1765, 722);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_RowHeaderMouseClick);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonClear.Location = new System.Drawing.Point(1595, 62);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(173, 68);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // showPic
            // 
            this.showPic.BackColor = System.Drawing.Color.White;
            this.showPic.ForeColor = System.Drawing.Color.BlueViolet;
            this.showPic.Location = new System.Drawing.Point(1309, 62);
            this.showPic.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.showPic.Name = "showPic";
            this.showPic.Size = new System.Drawing.Size(173, 68);
            this.showPic.TabIndex = 18;
            this.showPic.Text = "Show Pic";
            this.showPic.UseVisualStyleBackColor = false;
            this.showPic.Click += new System.EventHandler(this.showPic_Click);
            // 
            // pictureHolder
            // 
            this.pictureHolder.Image = ((System.Drawing.Image)(resources.GetObject("pictureHolder.Image")));
            this.pictureHolder.Location = new System.Drawing.Point(56, 1011);
            this.pictureHolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureHolder.Name = "pictureHolder";
            this.pictureHolder.Size = new System.Drawing.Size(2404, 572);
            this.pictureHolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHolder.TabIndex = 19;
            this.pictureHolder.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(1821, 34);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(173, 68);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.LimeGreen;
            this.loadButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadButton.Location = new System.Drawing.Point(1821, 112);
            this.loadButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(173, 68);
            this.loadButton.TabIndex = 21;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureHolder);
            this.Controls.Add(this.showPic);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.label_select_Item);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Clohing Data Base";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHolder)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureHolder;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
    }
}

