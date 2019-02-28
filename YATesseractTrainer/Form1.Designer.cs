namespace YATesseractTrainer
{
    partial class Form1
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
            this.uiOutputDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.uiFontDialog = new System.Windows.Forms.FontDialog();
            this.uiFontsList = new System.Windows.Forms.ListView();
            this.uiFontNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiFontStyleCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiFontSizeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiAddFont = new System.Windows.Forms.Button();
            this.uiRemoveFont = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uiFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiLang = new System.Windows.Forms.ComboBox();
            this.uiInputDirBtn = new System.Windows.Forms.Button();
            this.uiInputFile = new System.Windows.Forms.TextBox();
            this.uiOutputDir = new System.Windows.Forms.TextBox();
            this.uiOutputDirBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiInputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font:";
            // 
            // uiFontDialog
            // 
            this.uiFontDialog.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // uiFontsList
            // 
            this.uiFontsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uiFontNameCol,
            this.uiFontStyleCol,
            this.uiFontSizeCol});
            this.uiFontsList.Location = new System.Drawing.Point(123, 9);
            this.uiFontsList.Name = "uiFontsList";
            this.uiFontsList.Size = new System.Drawing.Size(426, 218);
            this.uiFontsList.TabIndex = 3;
            this.uiFontsList.UseCompatibleStateImageBehavior = false;
            this.uiFontsList.View = System.Windows.Forms.View.Details;
            // 
            // uiFontNameCol
            // 
            this.uiFontNameCol.Text = "Name";
            this.uiFontNameCol.Width = 150;
            // 
            // uiFontStyleCol
            // 
            this.uiFontStyleCol.Text = "Style";
            this.uiFontStyleCol.Width = 70;
            // 
            // uiFontSizeCol
            // 
            this.uiFontSizeCol.Text = "Size";
            // 
            // uiAddFont
            // 
            this.uiAddFont.Location = new System.Drawing.Point(555, 78);
            this.uiAddFont.Name = "uiAddFont";
            this.uiAddFont.Size = new System.Drawing.Size(83, 30);
            this.uiAddFont.TabIndex = 4;
            this.uiAddFont.Text = "Add";
            this.uiAddFont.UseVisualStyleBackColor = true;
            this.uiAddFont.Click += new System.EventHandler(this.uiAddFont_Click);
            // 
            // uiRemoveFont
            // 
            this.uiRemoveFont.Location = new System.Drawing.Point(555, 114);
            this.uiRemoveFont.Name = "uiRemoveFont";
            this.uiRemoveFont.Size = new System.Drawing.Size(83, 30);
            this.uiRemoveFont.TabIndex = 5;
            this.uiRemoveFont.Text = "Remove";
            this.uiRemoveFont.UseVisualStyleBackColor = true;
            this.uiRemoveFont.Click += new System.EventHandler(this.uiRemoveFont_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "File Name:";
            // 
            // uiFileName
            // 
            this.uiFileName.Location = new System.Drawing.Point(123, 238);
            this.uiFileName.Name = "uiFileName";
            this.uiFileName.Size = new System.Drawing.Size(100, 26);
            this.uiFileName.TabIndex = 7;
            this.uiFileName.Text = "exp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Language:";
            // 
            // uiLang
            // 
            this.uiLang.FormattingEnabled = true;
            this.uiLang.Items.AddRange(new object[] {
            "urd",
            "ara",
            "eng"});
            this.uiLang.Location = new System.Drawing.Point(123, 276);
            this.uiLang.Name = "uiLang";
            this.uiLang.Size = new System.Drawing.Size(171, 28);
            this.uiLang.TabIndex = 9;
            // 
            // uiInputDirBtn
            // 
            this.uiInputDirBtn.Location = new System.Drawing.Point(466, 307);
            this.uiInputDirBtn.Name = "uiInputDirBtn";
            this.uiInputDirBtn.Size = new System.Drawing.Size(83, 36);
            this.uiInputDirBtn.TabIndex = 12;
            this.uiInputDirBtn.Text = "Browse";
            this.uiInputDirBtn.UseVisualStyleBackColor = true;
            this.uiInputDirBtn.Click += new System.EventHandler(this.uiInputDirBtn_Click);
            // 
            // uiInputFile
            // 
            this.uiInputFile.Location = new System.Drawing.Point(123, 312);
            this.uiInputFile.Name = "uiInputFile";
            this.uiInputFile.ReadOnly = true;
            this.uiInputFile.Size = new System.Drawing.Size(337, 26);
            this.uiInputFile.TabIndex = 13;
            this.uiInputFile.Text = "D:\\OCR\\test\\data\\test.txt";
            // 
            // uiOutputDir
            // 
            this.uiOutputDir.Location = new System.Drawing.Point(123, 354);
            this.uiOutputDir.Name = "uiOutputDir";
            this.uiOutputDir.ReadOnly = true;
            this.uiOutputDir.Size = new System.Drawing.Size(337, 26);
            this.uiOutputDir.TabIndex = 15;
            this.uiOutputDir.Text = "D:\\OCR\\test";
            // 
            // uiOutputDirBtn
            // 
            this.uiOutputDirBtn.Location = new System.Drawing.Point(466, 349);
            this.uiOutputDirBtn.Name = "uiOutputDirBtn";
            this.uiOutputDirBtn.Size = new System.Drawing.Size(83, 36);
            this.uiOutputDirBtn.TabIndex = 14;
            this.uiOutputDirBtn.Text = "Browse";
            this.uiOutputDirBtn.UseVisualStyleBackColor = true;
            this.uiOutputDirBtn.Click += new System.EventHandler(this.uiOutputDirBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Input File:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "OutputDir";
            // 
            // uiInputFileDialog
            // 
            this.uiInputFileDialog.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiOutputDir);
            this.Controls.Add(this.uiOutputDirBtn);
            this.Controls.Add(this.uiInputFile);
            this.Controls.Add(this.uiInputDirBtn);
            this.Controls.Add(this.uiLang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiRemoveFont);
            this.Controls.Add(this.uiAddFont);
            this.Controls.Add(this.uiFontsList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Yet Another Tesseract Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog uiOutputDirDialog;
        private System.Windows.Forms.FontDialog uiFontDialog;
        private System.Windows.Forms.ListView uiFontsList;
        private System.Windows.Forms.Button uiAddFont;
        private System.Windows.Forms.Button uiRemoveFont;
        private System.Windows.Forms.ColumnHeader uiFontNameCol;
        private System.Windows.Forms.ColumnHeader uiFontStyleCol;
        private System.Windows.Forms.ColumnHeader uiFontSizeCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox uiLang;
        private System.Windows.Forms.Button uiInputDirBtn;
        private System.Windows.Forms.TextBox uiInputFile;
        private System.Windows.Forms.TextBox uiOutputDir;
        private System.Windows.Forms.Button uiOutputDirBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog uiInputFileDialog;
        private System.Windows.Forms.Button button1;
    }
}

