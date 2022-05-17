namespace ArtefactsManager.View
{
    partial class AddEditRole
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.categoriesList = new System.Windows.Forms.ListBox();
            this.CategoriesBox = new System.Windows.Forms.GroupBox();
            this.typesBox = new System.Windows.Forms.GroupBox();
            this.typesList = new System.Windows.Forms.ListBox();
            this.optionsBox = new System.Windows.Forms.GroupBox();
            this.addCheck = new System.Windows.Forms.CheckBox();
            this.editableCheck = new System.Windows.Forms.CheckBox();
            this.visibleCheck = new System.Windows.Forms.CheckBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.permissionsBox = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dataGridViewPermissions = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CanAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CategoriesBox.SuspendLayout();
            this.typesBox.SuspendLayout();
            this.optionsBox.SuspendLayout();
            this.permissionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role name";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox.Location = new System.Drawing.Point(33, 51);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(311, 22);
            this.nameBox.TabIndex = 1;
            // 
            // categoriesList
            // 
            this.categoriesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.ItemHeight = 16;
            this.categoriesList.Location = new System.Drawing.Point(3, 18);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(220, 181);
            this.categoriesList.TabIndex = 2;
            // 
            // CategoriesBox
            // 
            this.CategoriesBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoriesBox.Controls.Add(this.categoriesList);
            this.CategoriesBox.Location = new System.Drawing.Point(386, 31);
            this.CategoriesBox.Name = "CategoriesBox";
            this.CategoriesBox.Size = new System.Drawing.Size(226, 202);
            this.CategoriesBox.TabIndex = 3;
            this.CategoriesBox.TabStop = false;
            this.CategoriesBox.Text = "Categories";
            // 
            // typesBox
            // 
            this.typesBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typesBox.Controls.Add(this.typesList);
            this.typesBox.Location = new System.Drawing.Point(389, 239);
            this.typesBox.Name = "typesBox";
            this.typesBox.Size = new System.Drawing.Size(223, 202);
            this.typesBox.TabIndex = 4;
            this.typesBox.TabStop = false;
            this.typesBox.Text = "Types";
            // 
            // typesList
            // 
            this.typesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typesList.FormattingEnabled = true;
            this.typesList.ItemHeight = 16;
            this.typesList.Location = new System.Drawing.Point(3, 18);
            this.typesList.Name = "typesList";
            this.typesList.Size = new System.Drawing.Size(217, 181);
            this.typesList.TabIndex = 2;
            // 
            // optionsBox
            // 
            this.optionsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionsBox.Controls.Add(this.addCheck);
            this.optionsBox.Controls.Add(this.editableCheck);
            this.optionsBox.Controls.Add(this.visibleCheck);
            this.optionsBox.Location = new System.Drawing.Point(631, 119);
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.Size = new System.Drawing.Size(135, 183);
            this.optionsBox.TabIndex = 5;
            this.optionsBox.TabStop = false;
            this.optionsBox.Text = "Options";
            // 
            // addCheck
            // 
            this.addCheck.AutoSize = true;
            this.addCheck.Location = new System.Drawing.Point(6, 73);
            this.addCheck.Name = "addCheck";
            this.addCheck.Size = new System.Drawing.Size(80, 20);
            this.addCheck.TabIndex = 2;
            this.addCheck.Text = "Can add";
            this.addCheck.UseVisualStyleBackColor = true;
            // 
            // editableCheck
            // 
            this.editableCheck.AutoSize = true;
            this.editableCheck.Location = new System.Drawing.Point(6, 47);
            this.editableCheck.Name = "editableCheck";
            this.editableCheck.Size = new System.Drawing.Size(79, 20);
            this.editableCheck.TabIndex = 1;
            this.editableCheck.Text = "Editable";
            this.editableCheck.UseVisualStyleBackColor = true;
            // 
            // visibleCheck
            // 
            this.visibleCheck.AutoSize = true;
            this.visibleCheck.Location = new System.Drawing.Point(6, 21);
            this.visibleCheck.Name = "visibleCheck";
            this.visibleCheck.Size = new System.Drawing.Size(70, 20);
            this.visibleCheck.TabIndex = 0;
            this.visibleCheck.Text = "Visible";
            this.visibleCheck.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.Location = new System.Drawing.Point(637, 338);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(129, 46);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // permissionsBox
            // 
            this.permissionsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.permissionsBox.Controls.Add(this.dataGridViewPermissions);
            this.permissionsBox.Location = new System.Drawing.Point(13, 119);
            this.permissionsBox.Name = "permissionsBox";
            this.permissionsBox.Size = new System.Drawing.Size(348, 322);
            this.permissionsBox.TabIndex = 7;
            this.permissionsBox.TabStop = false;
            this.permissionsBox.Text = "Permissions";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.Location = new System.Drawing.Point(249, 462);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(334, 46);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dataGridViewPermissions
            // 
            this.dataGridViewPermissions.AllowUserToAddRows = false;
            this.dataGridViewPermissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Type,
            this.Visible,
            this.Editable,
            this.CanAdd,
            this.Delete});
            this.dataGridViewPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPermissions.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewPermissions.Name = "dataGridViewPermissions";
            this.dataGridViewPermissions.RowHeadersWidth = 51;
            this.dataGridViewPermissions.RowTemplate.Height = 24;
            this.dataGridViewPermissions.Size = new System.Drawing.Size(342, 301);
            this.dataGridViewPermissions.TabIndex = 0;
            this.dataGridViewPermissions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPermissions_CellContentClick);
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 91;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 68;
            // 
            // Visible
            // 
            this.Visible.HeaderText = "Visible";
            this.Visible.MinimumWidth = 6;
            this.Visible.Name = "Visible";
            this.Visible.ReadOnly = true;
            this.Visible.Width = 54;
            // 
            // Editable
            // 
            this.Editable.HeaderText = "Editable";
            this.Editable.MinimumWidth = 6;
            this.Editable.Name = "Editable";
            this.Editable.ReadOnly = true;
            this.Editable.Width = 63;
            // 
            // CanAdd
            // 
            this.CanAdd.HeaderText = "Can add";
            this.CanAdd.MinimumWidth = 6;
            this.CanAdd.Name = "CanAdd";
            this.CanAdd.ReadOnly = true;
            this.CanAdd.Width = 64;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // AddEditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.permissionsBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.optionsBox);
            this.Controls.Add(this.typesBox);
            this.Controls.Add(this.CategoriesBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddEditRole";
            this.Text = "AddEditRole";
            this.CategoriesBox.ResumeLayout(false);
            this.typesBox.ResumeLayout(false);
            this.optionsBox.ResumeLayout(false);
            this.optionsBox.PerformLayout();
            this.permissionsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ListBox categoriesList;
        private System.Windows.Forms.GroupBox CategoriesBox;
        private System.Windows.Forms.GroupBox typesBox;
        private System.Windows.Forms.ListBox typesList;
        private System.Windows.Forms.GroupBox optionsBox;
        private System.Windows.Forms.CheckBox addCheck;
        private System.Windows.Forms.CheckBox editableCheck;
        private System.Windows.Forms.CheckBox visibleCheck;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox permissionsBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView dataGridViewPermissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Visible;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Editable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CanAdd;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}