﻿
namespace Pll
{
    partial class FormPickingIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPickingIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPickingInItem = new System.Windows.Forms.DataGridView();
            this.pickingInItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddLiterature = new System.Windows.Forms.Button();
            this.pickingInItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.literatureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickingInItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickingInItemBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickingInItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategorija:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(113, 29);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(121, 22);
            this.textBoxTitle.TabIndex = 3;
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(113, 71);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAuthor.TabIndex = 4;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(113, 115);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewPickingInItem);
            this.groupBox1.Location = new System.Drawing.Point(26, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 293);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavke primke:";
            // 
            // dataGridViewPickingInItem
            // 
            this.dataGridViewPickingInItem.AutoGenerateColumns = false;
            this.dataGridViewPickingInItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPickingInItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.literatureNameDataGridViewTextBoxColumn});
            this.dataGridViewPickingInItem.DataSource = this.pickingInItemBindingSource1;
            this.dataGridViewPickingInItem.Location = new System.Drawing.Point(20, 53);
            this.dataGridViewPickingInItem.Name = "dataGridViewPickingInItem";
            this.dataGridViewPickingInItem.RowHeadersWidth = 51;
            this.dataGridViewPickingInItem.RowTemplate.Height = 24;
            this.dataGridViewPickingInItem.Size = new System.Drawing.Size(243, 223);
            this.dataGridViewPickingInItem.TabIndex = 0;
            // 
            // pickingInItemBindingSource1
            // 
            this.pickingInItemBindingSource1.DataSource = typeof(Dll.Model.PickingInItem);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddLiterature);
            this.groupBox2.Controls.Add(this.comboBoxAuthor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxCategory);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxTitle);
            this.groupBox2.Location = new System.Drawing.Point(26, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 159);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nova knjižna građa";
            // 
            // buttonAddLiterature
            // 
            this.buttonAddLiterature.Location = new System.Drawing.Point(292, 21);
            this.buttonAddLiterature.Name = "buttonAddLiterature";
            this.buttonAddLiterature.Size = new System.Drawing.Size(80, 38);
            this.buttonAddLiterature.TabIndex = 6;
            this.buttonAddLiterature.Text = "Dodaj";
            this.buttonAddLiterature.UseVisualStyleBackColor = true;
            this.buttonAddLiterature.Click += new System.EventHandler(this.buttonAddLiterature_Click);
            // 
            // pickingInItemBindingSource
            // 
            this.pickingInItemBindingSource.DataSource = typeof(Dll.Model.PickingInItem);
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(449, 17);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(140, 38);
            this.buttonSpremi.TabIndex = 7;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // literatureNameDataGridViewTextBoxColumn
            // 
            this.literatureNameDataGridViewTextBoxColumn.DataPropertyName = "LiteratureName";
            this.literatureNameDataGridViewTextBoxColumn.HeaderText = "Naslov";
            this.literatureNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.literatureNameDataGridViewTextBoxColumn.Name = "literatureNameDataGridViewTextBoxColumn";
            this.literatureNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.literatureNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(449, 86);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(140, 40);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Natrag";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormPickingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 485);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPickingIn";
            this.Text = "Primka";
            this.Load += new System.EventHandler(this.FormPickingIn_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPickingInItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickingInItemBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickingInItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewPickingInItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAddLiterature;
        private System.Windows.Forms.BindingSource pickingInItemBindingSource;
        private System.Windows.Forms.BindingSource pickingInItemBindingSource1;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.DataGridViewTextBoxColumn literatureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonClose;
    }
}