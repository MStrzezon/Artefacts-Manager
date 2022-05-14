namespace ArtefactsManager.View
{
    partial class Edit
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
            this.panelElement = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveArtefact = new System.Windows.Forms.Button();
            this.panelElement.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelElement
            // 
            this.panelElement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelElement.BackColor = System.Drawing.Color.White;
            this.panelElement.Controls.Add(this.panel1);
            this.panelElement.Controls.Add(this.label4);
            this.panelElement.Controls.Add(this.nameBox);
            this.panelElement.Controls.Add(this.label3);
            this.panelElement.Controls.Add(this.categoryBox);
            this.panelElement.Controls.Add(this.label2);
            this.panelElement.Controls.Add(this.flowLayoutPanel);
            this.panelElement.Controls.Add(this.btnSaveArtefact);
            this.panelElement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelElement.Location = new System.Drawing.Point(11, 17);
            this.panelElement.Name = "panelElement";
            this.panelElement.Size = new System.Drawing.Size(309, 381);
            this.panelElement.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Location = new System.Drawing.Point(28, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 3);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Attributes:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(27, 42);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(247, 22);
            this.nameBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name:";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(27, 254);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(247, 24);
            this.categoryBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Category:";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(27, 110);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(247, 112);
            this.flowLayoutPanel.TabIndex = 6;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // btnSaveArtefact
            // 
            this.btnSaveArtefact.BackColor = System.Drawing.Color.Turquoise;
            this.btnSaveArtefact.Location = new System.Drawing.Point(100, 306);
            this.btnSaveArtefact.Name = "btnSaveArtefact";
            this.btnSaveArtefact.Size = new System.Drawing.Size(90, 43);
            this.btnSaveArtefact.TabIndex = 3;
            this.btnSaveArtefact.Text = "Save";
            this.btnSaveArtefact.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 435);
            this.Controls.Add(this.panelElement);
            this.Name = "Edit";
            this.Text = "Edit";
            this.panelElement.ResumeLayout(false);
            this.panelElement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelElement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnSaveArtefact;
    }
}