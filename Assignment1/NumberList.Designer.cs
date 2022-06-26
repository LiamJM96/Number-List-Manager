namespace Assignment1
{
    partial class NumberList
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
            this.lbNumber = new System.Windows.Forms.ListBox();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.rbUnsorted = new System.Windows.Forms.RadioButton();
            this.rbSorted = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblFirstValue = new System.Windows.Forms.Label();
            this.lblLastValue = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelFirstValue = new System.Windows.Forms.Label();
            this.labelLastValue = new System.Windows.Forms.Label();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.labelMinValue = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.labelMaxValue = new System.Windows.Forms.Label();
            this.pbxBin = new System.Windows.Forms.PictureBox();
            this.rbBinarySearch = new System.Windows.Forms.RadioButton();
            this.rbLinearSearch = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNumber
            // 
            this.lbNumber.FormattingEnabled = true;
            this.lbNumber.HorizontalScrollbar = true;
            this.lbNumber.Location = new System.Drawing.Point(109, 11);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(120, 329);
            this.lbNumber.TabIndex = 0;
            this.lbNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbNumber_MouseDown);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(13, 12);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(75, 23);
            this.btnInitialize.TabIndex = 1;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // rbUnsorted
            // 
            this.rbUnsorted.AutoSize = true;
            this.rbUnsorted.Checked = true;
            this.rbUnsorted.Location = new System.Drawing.Point(20, 41);
            this.rbUnsorted.Name = "rbUnsorted";
            this.rbUnsorted.Size = new System.Drawing.Size(68, 17);
            this.rbUnsorted.TabIndex = 2;
            this.rbUnsorted.TabStop = true;
            this.rbUnsorted.Text = "Unsorted";
            this.rbUnsorted.UseVisualStyleBackColor = true;
            this.rbUnsorted.CheckedChanged += new System.EventHandler(this.rbUnsorted_CheckedChanged);
            // 
            // rbSorted
            // 
            this.rbSorted.AutoSize = true;
            this.rbSorted.Location = new System.Drawing.Point(20, 64);
            this.rbSorted.Name = "rbSorted";
            this.rbSorted.Size = new System.Drawing.Size(56, 17);
            this.rbSorted.TabIndex = 3;
            this.rbSorted.Text = "Sorted";
            this.rbSorted.UseVisualStyleBackColor = true;
            this.rbSorted.CheckedChanged += new System.EventHandler(this.rbSorted_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 288);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(13, 260);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 23);
            this.btnShuffle.TabIndex = 7;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(13, 113);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(13, 87);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(68, 20);
            this.txtInsert.TabIndex = 10;
            this.txtInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsert_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(261, 37);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 12;
            this.lblCount.Text = "0";
            // 
            // lblFirstValue
            // 
            this.lblFirstValue.AutoSize = true;
            this.lblFirstValue.Location = new System.Drawing.Point(261, 86);
            this.lblFirstValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstValue.Name = "lblFirstValue";
            this.lblFirstValue.Size = new System.Drawing.Size(13, 13);
            this.lblFirstValue.TabIndex = 13;
            this.lblFirstValue.Text = "0";
            // 
            // lblLastValue
            // 
            this.lblLastValue.AutoSize = true;
            this.lblLastValue.Location = new System.Drawing.Point(261, 135);
            this.lblLastValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastValue.Name = "lblLastValue";
            this.lblLastValue.Size = new System.Drawing.Size(13, 13);
            this.lblLastValue.TabIndex = 14;
            this.lblLastValue.Text = "0";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(249, 12);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(35, 13);
            this.labelCount.TabIndex = 15;
            this.labelCount.Text = "Count";
            // 
            // labelFirstValue
            // 
            this.labelFirstValue.AutoSize = true;
            this.labelFirstValue.Location = new System.Drawing.Point(241, 60);
            this.labelFirstValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstValue.Name = "labelFirstValue";
            this.labelFirstValue.Size = new System.Drawing.Size(56, 13);
            this.labelFirstValue.TabIndex = 16;
            this.labelFirstValue.Text = "First Value";
            // 
            // labelLastValue
            // 
            this.labelLastValue.AutoSize = true;
            this.labelLastValue.Location = new System.Drawing.Point(241, 110);
            this.labelLastValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastValue.Name = "labelLastValue";
            this.labelLastValue.Size = new System.Drawing.Size(57, 13);
            this.labelLastValue.TabIndex = 17;
            this.labelLastValue.Text = "Last Value";
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(261, 186);
            this.lblMinValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(13, 13);
            this.lblMinValue.TabIndex = 18;
            this.lblMinValue.Text = "0";
            // 
            // labelMinValue
            // 
            this.labelMinValue.AutoSize = true;
            this.labelMinValue.Location = new System.Drawing.Point(241, 158);
            this.labelMinValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinValue.Name = "labelMinValue";
            this.labelMinValue.Size = new System.Drawing.Size(54, 13);
            this.labelMinValue.TabIndex = 19;
            this.labelMinValue.Text = "Min Value";
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(259, 238);
            this.lblMaxValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(13, 13);
            this.lblMaxValue.TabIndex = 20;
            this.lblMaxValue.Text = "0";
            // 
            // labelMaxValue
            // 
            this.labelMaxValue.AutoSize = true;
            this.labelMaxValue.Location = new System.Drawing.Point(241, 212);
            this.labelMaxValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaxValue.Name = "labelMaxValue";
            this.labelMaxValue.Size = new System.Drawing.Size(57, 13);
            this.labelMaxValue.TabIndex = 21;
            this.labelMaxValue.Text = "Max Value";
            // 
            // pbxBin
            // 
            this.pbxBin.Image = global::Assignment1.Properties.Resources.empty__recycle_bin_icon_27617;
            this.pbxBin.Location = new System.Drawing.Point(244, 292);
            this.pbxBin.Margin = new System.Windows.Forms.Padding(2);
            this.pbxBin.Name = "pbxBin";
            this.pbxBin.Size = new System.Drawing.Size(51, 46);
            this.pbxBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBin.TabIndex = 22;
            this.pbxBin.TabStop = false;
            this.pbxBin.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxBin_DragDrop);
            this.pbxBin.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxBin_DragEnter);
            // 
            // rbBinarySearch
            // 
            this.rbBinarySearch.AutoSize = true;
            this.rbBinarySearch.Location = new System.Drawing.Point(12, 198);
            this.rbBinarySearch.Name = "rbBinarySearch";
            this.rbBinarySearch.Size = new System.Drawing.Size(91, 17);
            this.rbBinarySearch.TabIndex = 23;
            this.rbBinarySearch.Text = "Binary Search";
            this.rbBinarySearch.UseVisualStyleBackColor = true;
            // 
            // rbLinearSearch
            // 
            this.rbLinearSearch.AutoSize = true;
            this.rbLinearSearch.Location = new System.Drawing.Point(12, 176);
            this.rbLinearSearch.Name = "rbLinearSearch";
            this.rbLinearSearch.Size = new System.Drawing.Size(91, 17);
            this.rbLinearSearch.TabIndex = 24;
            this.rbLinearSearch.Text = "Linear Search";
            this.rbLinearSearch.UseVisualStyleBackColor = true;
            // 
            // NumberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 350);
            this.Controls.Add(this.rbLinearSearch);
            this.Controls.Add(this.rbBinarySearch);
            this.Controls.Add(this.pbxBin);
            this.Controls.Add(this.labelMaxValue);
            this.Controls.Add(this.lblMaxValue);
            this.Controls.Add(this.labelMinValue);
            this.Controls.Add(this.lblMinValue);
            this.Controls.Add(this.labelLastValue);
            this.Controls.Add(this.labelFirstValue);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.lblLastValue);
            this.Controls.Add(this.lblFirstValue);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rbSorted);
            this.Controls.Add(this.rbUnsorted);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.lbNumber);
            this.Name = "NumberList";
            this.Text = "Number List";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNumber;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.RadioButton rbUnsorted;
        private System.Windows.Forms.RadioButton rbSorted;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblFirstValue;
        private System.Windows.Forms.Label lblLastValue;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelFirstValue;
        private System.Windows.Forms.Label labelLastValue;
        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.Label labelMinValue;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Label labelMaxValue;
        private System.Windows.Forms.PictureBox pbxBin;
        private System.Windows.Forms.RadioButton rbBinarySearch;
        private System.Windows.Forms.RadioButton rbLinearSearch;
    }
}

