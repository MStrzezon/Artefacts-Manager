namespace ArtefactsManager.View
{
    partial class Add
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
            this.chooseBox = new System.Windows.Forms.ComboBox();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.panelElement = new System.Windows.Forms.Panel();
            this.AddType = new System.Windows.Forms.Button();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.btnSaveArtefact = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.panelCategory.SuspendLayout();
            this.panelElement.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseBox
            // 
            this.chooseBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.chooseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseBox.FormattingEnabled = true;
            this.chooseBox.Items.AddRange(new object[] {
            "Kategoria",
            "Element"});
            this.chooseBox.Location = new System.Drawing.Point(0, 0);
            this.chooseBox.Name = "chooseBox";
            this.chooseBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chooseBox.Size = new System.Drawing.Size(383, 33);
            this.chooseBox.TabIndex = 0;
            this.chooseBox.SelectedIndexChanged += new System.EventHandler(this.chooseBox_SelectedIndexChanged);
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(47, 54);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(203, 22);
            this.textBoxCategoryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category name:";
            // 
            // panelCategory
            // 
            this.panelCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCategory.BackColor = System.Drawing.Color.White;
            this.panelCategory.Controls.Add(this.label2);
            this.panelCategory.Controls.Add(this.btnSaveCategory);
            this.panelCategory.Controls.Add(this.label1);
            this.panelCategory.Controls.Add(this.textBoxCategoryName);
            this.panelCategory.Location = new System.Drawing.Point(44, 61);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(292, 360);
            this.panelCategory.TabIndex = 3;
            this.panelCategory.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Attributes:";
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.BackColor = System.Drawing.Color.Turquoise;
            this.btnSaveCategory.Location = new System.Drawing.Point(47, 301);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(90, 43);
            this.btnSaveCategory.TabIndex = 3;
            this.btnSaveCategory.Text = "Save";
            this.btnSaveCategory.UseVisualStyleBackColor = false;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // panelElement
            // 
            this.panelElement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelElement.BackColor = System.Drawing.Color.White;
            this.panelElement.Controls.Add(this.AddType);
            this.panelElement.Controls.Add(this.TypeBox);
            this.panelElement.Controls.Add(this.btnSaveArtefact);
            this.panelElement.Controls.Add(this.typeLabel);
            this.panelElement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelElement.Location = new System.Drawing.Point(47, 58);
            this.panelElement.Name = "panelElement";
            this.panelElement.Size = new System.Drawing.Size(295, 360);
            this.panelElement.TabIndex = 5;
            // 
            // AddType
            // 
            this.AddType.BackColor = System.Drawing.Color.LightSalmon;
            this.AddType.Location = new System.Drawing.Point(160, 301);
            this.AddType.Name = "AddType";
            this.AddType.Size = new System.Drawing.Size(90, 43);
            this.AddType.TabIndex = 5;
            this.AddType.Text = "New type";
            this.AddType.UseVisualStyleBackColor = false;
            this.AddType.Click += new System.EventHandler(this.AddType_Click);
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(47, 51);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(203, 24);
            this.TypeBox.TabIndex = 4;
            // 
            // btnSaveArtefact
            // 
            this.btnSaveArtefact.BackColor = System.Drawing.Color.Turquoise;
            this.btnSaveArtefact.Location = new System.Drawing.Point(47, 301);
            this.btnSaveArtefact.Name = "btnSaveArtefact";
            this.btnSaveArtefact.Size = new System.Drawing.Size(90, 43);
            this.btnSaveArtefact.TabIndex = 3;
            this.btnSaveArtefact.Text = "Save";
            this.btnSaveArtefact.UseVisualStyleBackColor = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(44, 26);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(39, 16);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Type";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 460);
            this.Controls.Add(this.panelCategory);
            this.Controls.Add(this.panelElement);
            this.Controls.Add(this.chooseBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            this.panelElement.ResumeLayout(false);
            this.panelElement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox chooseBox;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelElement;
        private System.Windows.Forms.Button btnSaveArtefact;
        private System.Windows.Forms.Button AddType;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Label typeLabel;
    }
}