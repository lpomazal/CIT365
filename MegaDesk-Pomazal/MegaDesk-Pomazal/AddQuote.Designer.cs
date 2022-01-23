namespace MegaDesk_Pomazal
{
    partial class AddQuote
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.TextBox();
            this.deskWidth = new System.Windows.Forms.NumericUpDown();
            this.deskDepth = new System.Windows.Forms.NumericUpDown();
            this.selectedSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.numDrawers = new System.Windows.Forms.Label();
            this.numDrawer = new System.Windows.Forms.NumericUpDown();
            this.rushOptions = new System.Windows.Forms.ComboBox();
            this.submitQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First and Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desk Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desk Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surface Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rush Option";
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(237, 79);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(146, 20);
            this.custName.TabIndex = 5;
            // 
            // deskWidth
            // 
            this.deskWidth.Location = new System.Drawing.Point(237, 116);
            this.deskWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.deskWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(120, 20);
            this.deskWidth.TabIndex = 6;
            this.deskWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // deskDepth
            // 
            this.deskDepth.Location = new System.Drawing.Point(237, 149);
            this.deskDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.deskDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(120, 20);
            this.deskDepth.TabIndex = 7;
            this.deskDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // selectedSurfaceMaterial
            // 
            this.selectedSurfaceMaterial.FormattingEnabled = true;
            this.selectedSurfaceMaterial.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.selectedSurfaceMaterial.Location = new System.Drawing.Point(237, 180);
            this.selectedSurfaceMaterial.Name = "selectedSurfaceMaterial";
            this.selectedSurfaceMaterial.Size = new System.Drawing.Size(121, 21);
            this.selectedSurfaceMaterial.TabIndex = 8;
            // 
            // numDrawers
            // 
            this.numDrawers.AutoSize = true;
            this.numDrawers.Location = new System.Drawing.Point(105, 223);
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(46, 13);
            this.numDrawers.TabIndex = 9;
            this.numDrawers.Text = "Drawers";
            // 
            // numDrawer
            // 
            this.numDrawer.Location = new System.Drawing.Point(237, 223);
            this.numDrawer.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDrawer.Name = "numDrawer";
            this.numDrawer.Size = new System.Drawing.Size(120, 20);
            this.numDrawer.TabIndex = 10;
            // 
            // rushOptions
            // 
            this.rushOptions.FormattingEnabled = true;
            this.rushOptions.Items.AddRange(new object[] {
            "None (14 days)",
            "3 Days",
            "5 Days",
            "4 Days"});
            this.rushOptions.Location = new System.Drawing.Point(237, 257);
            this.rushOptions.Name = "rushOptions";
            this.rushOptions.Size = new System.Drawing.Size(121, 21);
            this.rushOptions.TabIndex = 11;
            // 
            // submitQuote
            // 
            this.submitQuote.Location = new System.Drawing.Point(346, 353);
            this.submitQuote.Name = "submitQuote";
            this.submitQuote.Size = new System.Drawing.Size(75, 23);
            this.submitQuote.TabIndex = 12;
            this.submitQuote.Text = "Submit";
            this.submitQuote.UseVisualStyleBackColor = true;
            this.submitQuote.Click += new System.EventHandler(this.submitQuote_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitQuote);
            this.Controls.Add(this.rushOptions);
            this.Controls.Add(this.numDrawer);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.selectedSurfaceMaterial);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.NumericUpDown deskWidth;
        private System.Windows.Forms.NumericUpDown deskDepth;
        private System.Windows.Forms.ComboBox selectedSurfaceMaterial;
        private System.Windows.Forms.Label numDrawers;
        private System.Windows.Forms.NumericUpDown numDrawer;
        private System.Windows.Forms.ComboBox rushOptions;
        private System.Windows.Forms.Button submitQuote;
    }
}