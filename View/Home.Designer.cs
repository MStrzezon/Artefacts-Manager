namespace ArtefactsManager.View
{
    partial class Home
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridViewTop = new System.Windows.Forms.DataGridView();
            this.panelTopTitle = new System.Windows.Forms.Panel();
            this.lblTopArtefacts = new System.Windows.Forms.Label();
            this.dataGridViewLast = new System.Windows.Forms.DataGridView();
            this.panelLastAddedTitle = new System.Windows.Forms.Panel();
            this.lblLastAdded = new System.Windows.Forms.Label();
            this.artefactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop)).BeginInit();
            this.panelTopTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLast)).BeginInit();
            this.panelLastAddedTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dataGridViewTop);
            this.splitContainer.Panel1.Controls.Add(this.panelTopTitle);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGridViewLast);
            this.splitContainer.Panel2.Controls.Add(this.panelLastAddedTitle);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 386;
            this.splitContainer.TabIndex = 0;
            // 
            // dataGridViewTop
            // 
            this.dataGridViewTop.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTop.GridColor = System.Drawing.Color.White;
            this.dataGridViewTop.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewTop.Name = "dataGridViewTop";
            this.dataGridViewTop.RowHeadersWidth = 51;
            this.dataGridViewTop.RowTemplate.Height = 24;
            this.dataGridViewTop.Size = new System.Drawing.Size(386, 400);
            this.dataGridViewTop.TabIndex = 1;
            // 
            // panelTopTitle
            // 
            this.panelTopTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTopTitle.Controls.Add(this.lblTopArtefacts);
            this.panelTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTopTitle.Name = "panelTopTitle";
            this.panelTopTitle.Size = new System.Drawing.Size(386, 50);
            this.panelTopTitle.TabIndex = 0;
            // 
            // lblTopArtefacts
            // 
            this.lblTopArtefacts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTopArtefacts.AutoSize = true;
            this.lblTopArtefacts.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopArtefacts.Location = new System.Drawing.Point(128, 9);
            this.lblTopArtefacts.Name = "lblTopArtefacts";
            this.lblTopArtefacts.Size = new System.Drawing.Size(122, 21);
            this.lblTopArtefacts.TabIndex = 2;
            this.lblTopArtefacts.Text = "Top Artefacts";
            // 
            // dataGridViewLast
            // 
            this.dataGridViewLast.AllowUserToAddRows = false;
            this.dataGridViewLast.AllowUserToDeleteRows = false;
            this.dataGridViewLast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLast.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLast.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artefactName,
            this.createdDate});
            this.dataGridViewLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLast.GridColor = System.Drawing.Color.White;
            this.dataGridViewLast.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewLast.Name = "dataGridViewLast";
            this.dataGridViewLast.RowHeadersWidth = 51;
            this.dataGridViewLast.RowTemplate.Height = 24;
            this.dataGridViewLast.Size = new System.Drawing.Size(410, 400);
            this.dataGridViewLast.TabIndex = 1;
            // 
            // panelLastAddedTitle
            // 
            this.panelLastAddedTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLastAddedTitle.Controls.Add(this.lblLastAdded);
            this.panelLastAddedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLastAddedTitle.Location = new System.Drawing.Point(0, 0);
            this.panelLastAddedTitle.Name = "panelLastAddedTitle";
            this.panelLastAddedTitle.Size = new System.Drawing.Size(410, 50);
            this.panelLastAddedTitle.TabIndex = 0;
            // 
            // lblLastAdded
            // 
            this.lblLastAdded.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastAdded.AutoSize = true;
            this.lblLastAdded.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastAdded.Location = new System.Drawing.Point(121, 9);
            this.lblLastAdded.Name = "lblLastAdded";
            this.lblLastAdded.Size = new System.Drawing.Size(178, 21);
            this.lblLastAdded.TabIndex = 3;
            this.lblLastAdded.Text = "Last added Artefacts";
            // 
            // artefactName
            // 
            this.artefactName.HeaderText = "Name";
            this.artefactName.MinimumWidth = 6;
            this.artefactName.Name = "artefactName";
            this.artefactName.ReadOnly = true;
            // 
            // createdDate
            // 
            this.createdDate.HeaderText = "Date added";
            this.createdDate.MinimumWidth = 6;
            this.createdDate.Name = "createdDate";
            this.createdDate.ReadOnly = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "Home";
            this.Text = "Home";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop)).EndInit();
            this.panelTopTitle.ResumeLayout(false);
            this.panelTopTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLast)).EndInit();
            this.panelLastAddedTitle.ResumeLayout(false);
            this.panelLastAddedTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dataGridViewTop;
        private System.Windows.Forms.Panel panelTopTitle;
        private System.Windows.Forms.Label lblTopArtefacts;
        private System.Windows.Forms.DataGridView dataGridViewLast;
        private System.Windows.Forms.Panel panelLastAddedTitle;
        private System.Windows.Forms.Label lblLastAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn artefactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
    }
}