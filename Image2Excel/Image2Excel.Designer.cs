namespace Image2Excel
{
    partial class Image2Excel
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
            this.insertBtn = new System.Windows.Forms.Button();
            this.rowLbl = new System.Windows.Forms.Label();
            this.colLbl = new System.Windows.Forms.Label();
            this.rowTxt = new System.Windows.Forms.TextBox();
            this.colTxt = new System.Windows.Forms.TextBox();
            this.imgLbl = new System.Windows.Forms.Label();
            this.imageTxt = new System.Windows.Forms.TextBox();
            this.fileTxt = new System.Windows.Forms.TextBox();
            this.fileLbl = new System.Windows.Forms.Label();
            this.imgex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(99, 179);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 0;
            this.insertBtn.Text = "Create File";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // rowLbl
            // 
            this.rowLbl.AutoSize = true;
            this.rowLbl.Location = new System.Drawing.Point(17, 67);
            this.rowLbl.Name = "rowLbl";
            this.rowLbl.Size = new System.Drawing.Size(29, 13);
            this.rowLbl.TabIndex = 1;
            this.rowLbl.Text = "Row";
            // 
            // colLbl
            // 
            this.colLbl.AutoSize = true;
            this.colLbl.Location = new System.Drawing.Point(17, 93);
            this.colLbl.Name = "colLbl";
            this.colLbl.Size = new System.Drawing.Size(42, 13);
            this.colLbl.TabIndex = 2;
            this.colLbl.Text = "Column";
            // 
            // rowTxt
            // 
            this.rowTxt.Location = new System.Drawing.Point(84, 64);
            this.rowTxt.Name = "rowTxt";
            this.rowTxt.Size = new System.Drawing.Size(58, 20);
            this.rowTxt.TabIndex = 3;
            this.rowTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rowTxt_KeyPress);
            // 
            // colTxt
            // 
            this.colTxt.Location = new System.Drawing.Point(84, 90);
            this.colTxt.Name = "colTxt";
            this.colTxt.Size = new System.Drawing.Size(58, 20);
            this.colTxt.TabIndex = 4;
            this.colTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.colTxt_KeyPress);
            // 
            // imgLbl
            // 
            this.imgLbl.AutoSize = true;
            this.imgLbl.Location = new System.Drawing.Point(17, 119);
            this.imgLbl.Name = "imgLbl";
            this.imgLbl.Size = new System.Drawing.Size(61, 13);
            this.imgLbl.TabIndex = 5;
            this.imgLbl.Text = "Image Path";
            // 
            // imageTxt
            // 
            this.imageTxt.Location = new System.Drawing.Point(84, 116);
            this.imageTxt.Name = "imageTxt";
            this.imageTxt.Size = new System.Drawing.Size(168, 20);
            this.imageTxt.TabIndex = 6;
            // 
            // fileTxt
            // 
            this.fileTxt.Location = new System.Drawing.Point(84, 142);
            this.fileTxt.Name = "fileTxt";
            this.fileTxt.Size = new System.Drawing.Size(168, 20);
            this.fileTxt.TabIndex = 7;
            // 
            // fileLbl
            // 
            this.fileLbl.AutoSize = true;
            this.fileLbl.Location = new System.Drawing.Point(17, 145);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(54, 13);
            this.fileLbl.TabIndex = 8;
            this.fileLbl.Text = "File Name";
            // 
            // imgex
            // 
            this.imgex.AutoSize = true;
            this.imgex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgex.Location = new System.Drawing.Point(75, 19);
            this.imgex.Name = "imgex";
            this.imgex.Size = new System.Drawing.Size(120, 24);
            this.imgex.TabIndex = 9;
            this.imgex.Text = "Image2Excel";
            // 
            // Image2Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 214);
            this.Controls.Add(this.imgex);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.fileTxt);
            this.Controls.Add(this.imageTxt);
            this.Controls.Add(this.imgLbl);
            this.Controls.Add(this.colTxt);
            this.Controls.Add(this.rowTxt);
            this.Controls.Add(this.colLbl);
            this.Controls.Add(this.rowLbl);
            this.Controls.Add(this.insertBtn);
            this.Name = "Image2Excel";
            this.Text = "Image2Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label rowLbl;
        private System.Windows.Forms.Label colLbl;
        private System.Windows.Forms.TextBox rowTxt;
        private System.Windows.Forms.TextBox colTxt;
        private System.Windows.Forms.Label imgLbl;
        private System.Windows.Forms.TextBox imageTxt;
        private System.Windows.Forms.TextBox fileTxt;
        private System.Windows.Forms.Label fileLbl;
        private System.Windows.Forms.Label imgex;
    }
}

