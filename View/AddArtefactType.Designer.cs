namespace ArtefactsManager.View
{
    partial class AddArtefactType
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
            this.panelCategory = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.attributesList = new System.Windows.Forms.ListBox();
            this.AttributeBox = new System.Windows.Forms.TextBox();
            this.btnAddAttribute = new System.Windows.Forms.Button();
            this.panelCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCategory
            // 
            this.panelCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCategory.BackColor = System.Drawing.Color.White;
            this.panelCategory.Controls.Add(this.btnAddAttribute);
            this.panelCategory.Controls.Add(this.AttributeBox);
            this.panelCategory.Controls.Add(this.attributesList);
            this.panelCategory.Controls.Add(this.label2);
            this.panelCategory.Controls.Add(this.btnSave);
            this.panelCategory.Controls.Add(this.label1);
            this.panelCategory.Controls.Add(this.textBoxCategoryName);
            this.panelCategory.Location = new System.Drawing.Point(44, 50);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(295, 360);
            this.panelCategory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Attributes:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.Location = new System.Drawing.Point(102, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 43);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type name";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(47, 54);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(203, 22);
            this.textBoxCategoryName.TabIndex = 1;
            // 
            // attributesList
            // 
            this.attributesList.FormattingEnabled = true;
            this.attributesList.ItemHeight = 16;
            this.attributesList.Location = new System.Drawing.Point(47, 128);
            this.attributesList.Name = "attributesList";
            this.attributesList.Size = new System.Drawing.Size(203, 84);
            this.attributesList.TabIndex = 5;
            this.attributesList.DoubleClick += new System.EventHandler(this.attributesList_DoubleClick);
            // 
            // AttributeBox
            // 
            this.AttributeBox.Location = new System.Drawing.Point(47, 235);
            this.AttributeBox.Name = "AttributeBox";
            this.AttributeBox.Size = new System.Drawing.Size(120, 22);
            this.AttributeBox.TabIndex = 6;
            // 
            // btnAddAttribute
            // 
            this.btnAddAttribute.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddAttribute.Location = new System.Drawing.Point(182, 235);
            this.btnAddAttribute.Name = "btnAddAttribute";
            this.btnAddAttribute.Size = new System.Drawing.Size(68, 22);
            this.btnAddAttribute.TabIndex = 7;
            this.btnAddAttribute.Text = "Add";
            this.btnAddAttribute.UseVisualStyleBackColor = false;
            this.btnAddAttribute.Click += new System.EventHandler(this.btnAddAttribute_Click);
            // 
            // AddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 460);
            this.Controls.Add(this.panelCategory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddType";
            this.Text = "AddType";
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Button btnAddAttribute;
        private System.Windows.Forms.TextBox AttributeBox;
        private System.Windows.Forms.ListBox attributesList;
    }
}