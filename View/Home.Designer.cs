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
            this.panelLastAddedTitle = new System.Windows.Forms.Panel();
            this.lblLastAdded = new System.Windows.Forms.Label();
            this.dataGridViewLast = new System.Windows.Forms.DataGridView();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artefactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLastAddedTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLast)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLastAddedTitle
            // 
            this.panelLastAddedTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLastAddedTitle.Controls.Add(this.lblLastAdded);
            this.panelLastAddedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLastAddedTitle.Location = new System.Drawing.Point(0, 0);
            this.panelLastAddedTitle.Name = "panelLastAddedTitle";
            this.panelLastAddedTitle.Size = new System.Drawing.Size(428, 50);
            this.panelLastAddedTitle.TabIndex = 0;
            // 
            // lblLastAdded
            // 
            this.lblLastAdded.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastAdded.AutoSize = true;
            this.lblLastAdded.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastAdded.Location = new System.Drawing.Point(130, 9);
            this.lblLastAdded.Name = "lblLastAdded";
            this.lblLastAdded.Size = new System.Drawing.Size(178, 21);
            this.lblLastAdded.TabIndex = 3;
            this.lblLastAdded.Text = "Last added Artefacts";
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
            this.dataGridViewLast.Size = new System.Drawing.Size(428, 376);
            this.dataGridViewLast.TabIndex = 1;
            // 
            // createdDate
            // 
            this.createdDate.HeaderText = "Date added";
            this.createdDate.MinimumWidth = 6;
            this.createdDate.Name = "createdDate";
            this.createdDate.ReadOnly = true;
            // 
            // artefactName
            // 
            this.artefactName.HeaderText = "Name";
            this.artefactName.MinimumWidth = 6;
            this.artefactName.Name = "artefactName";
            this.artefactName.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dataGridViewLast);
            this.panel1.Controls.Add(this.panelLastAddedTitle);
            this.panel1.Location = new System.Drawing.Point(169, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 426);
            this.panel1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.panelLastAddedTitle.ResumeLayout(false);
            this.panelLastAddedTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLast)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLastAddedTitle;
        private System.Windows.Forms.Label lblLastAdded;
        private System.Windows.Forms.DataGridView dataGridViewLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn artefactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.Panel panel1;
    }
}