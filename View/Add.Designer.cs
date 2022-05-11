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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelElement = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 1;
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
            this.panelCategory.Controls.Add(this.btnSave);
            this.panelCategory.Controls.Add(this.label1);
            this.panelCategory.Controls.Add(this.textBox1);
            this.panelCategory.Location = new System.Drawing.Point(48, 63);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(295, 360);
            this.panelCategory.TabIndex = 3;
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.Location = new System.Drawing.Point(47, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 43);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panelElement
            // 
            this.panelElement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelElement.BackColor = System.Drawing.Color.White;
            this.panelElement.Controls.Add(this.comboBox1);
            this.panelElement.Controls.Add(this.button1);
            this.panelElement.Controls.Add(this.label4);
            this.panelElement.Location = new System.Drawing.Point(48, 63);
            this.panelElement.Name = "panelElement";
            this.panelElement.Size = new System.Drawing.Size(295, 360);
            this.panelElement.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(47, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(47, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 460);
            this.Controls.Add(this.panelElement);
            this.Controls.Add(this.panelCategory);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelElement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}