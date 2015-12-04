namespace _005510040_Conventer
{
    partial class FormCon
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
            this.rTxtCSharpCode = new System.Windows.Forms.RichTextBox();
            this.btnOpenFileCpp = new System.Windows.Forms.Button();
            this.saveFileCSharp = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveFileCSharp = new System.Windows.Forms.Button();
            this.rTxtCppCode = new System.Windows.Forms.RichTextBox();
            this.btnConvertFromCpp = new System.Windows.Forms.Button();
            this.lblHeaderCSharp = new System.Windows.Forms.Label();
            this.openFileCSharp = new System.Windows.Forms.OpenFileDialog();
            this.lblHeaderCpp = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTxtCSharpCode
            // 
            this.rTxtCSharpCode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtCSharpCode.Location = new System.Drawing.Point(611, 183);
            this.rTxtCSharpCode.Name = "rTxtCSharpCode";
            this.rTxtCSharpCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rTxtCSharpCode.Size = new System.Drawing.Size(436, 350);
            this.rTxtCSharpCode.TabIndex = 32;
            this.rTxtCSharpCode.Text = "";
            // 
            // btnOpenFileCpp
            // 
            this.btnOpenFileCpp.Location = new System.Drawing.Point(11, 138);
            this.btnOpenFileCpp.Name = "btnOpenFileCpp";
            this.btnOpenFileCpp.Size = new System.Drawing.Size(437, 29);
            this.btnOpenFileCpp.TabIndex = 30;
            this.btnOpenFileCpp.Text = "Open C++ File To Convert";
            this.btnOpenFileCpp.UseVisualStyleBackColor = true;
            this.btnOpenFileCpp.Click += new System.EventHandler(this.btnOpenFileCpp_Click);
            // 
            // btnSaveFileCSharp
            // 
            this.btnSaveFileCSharp.Location = new System.Drawing.Point(611, 138);
            this.btnSaveFileCSharp.Name = "btnSaveFileCSharp";
            this.btnSaveFileCSharp.Size = new System.Drawing.Size(438, 29);
            this.btnSaveFileCSharp.TabIndex = 31;
            this.btnSaveFileCSharp.Text = "Save Converted C# File ";
            this.btnSaveFileCSharp.UseVisualStyleBackColor = true;
            this.btnSaveFileCSharp.Click += new System.EventHandler(this.btnSaveFileCSharp_Click);
            // 
            // rTxtCppCode
            // 
            this.rTxtCppCode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtCppCode.Location = new System.Drawing.Point(11, 183);
            this.rTxtCppCode.Name = "rTxtCppCode";
            this.rTxtCppCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rTxtCppCode.Size = new System.Drawing.Size(436, 350);
            this.rTxtCppCode.TabIndex = 24;
            this.rTxtCppCode.Text = "  \n\n\n\n\n\n\n\n\n   /*  \n\t\n\tPlease, copy any c++ code or open any c++ file ... \n\n   */";
            // 
            // btnConvertFromCpp
            // 
            this.btnConvertFromCpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConvertFromCpp.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnConvertFromCpp.Location = new System.Drawing.Point(453, 303);
            this.btnConvertFromCpp.Name = "btnConvertFromCpp";
            this.btnConvertFromCpp.Size = new System.Drawing.Size(151, 119);
            this.btnConvertFromCpp.TabIndex = 29;
            this.btnConvertFromCpp.Text = " > Convert >";
            this.btnConvertFromCpp.UseVisualStyleBackColor = true;
            this.btnConvertFromCpp.Click += new System.EventHandler(this.btnConvertFromCpp_Click);
            // 
            // lblHeaderCSharp
            // 
            this.lblHeaderCSharp.BackColor = System.Drawing.Color.Yellow;
            this.lblHeaderCSharp.Font = new System.Drawing.Font("Microsoft YaHei", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeaderCSharp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHeaderCSharp.Location = new System.Drawing.Point(611, 97);
            this.lblHeaderCSharp.Name = "lblHeaderCSharp";
            this.lblHeaderCSharp.Size = new System.Drawing.Size(436, 29);
            this.lblHeaderCSharp.TabIndex = 28;
            this.lblHeaderCSharp.Text = "C#";
            this.lblHeaderCSharp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileCSharp
            // 
            this.openFileCSharp.FileName = "openFileCPlusPlus";
            // 
            // lblHeaderCpp
            // 
            this.lblHeaderCpp.BackColor = System.Drawing.Color.Yellow;
            this.lblHeaderCpp.Font = new System.Drawing.Font("Microsoft YaHei", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeaderCpp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHeaderCpp.Location = new System.Drawing.Point(11, 97);
            this.lblHeaderCpp.Name = "lblHeaderCpp";
            this.lblHeaderCpp.Size = new System.Drawing.Size(436, 29);
            this.lblHeaderCpp.TabIndex = 27;
            this.lblHeaderCpp.Text = "C++";
            this.lblHeaderCpp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.Location = new System.Drawing.Point(11, 554);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(1036, 43);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft YaHei", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeader.Location = new System.Drawing.Point(11, 14);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1036, 68);
            this.lblHeader.TabIndex = 25;
            this.lblHeader.Text = "Conventer C++ To C#";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Location = new System.Drawing.Point(454, 97);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 70);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear All Text";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 609);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rTxtCSharpCode);
            this.Controls.Add(this.btnOpenFileCpp);
            this.Controls.Add(this.btnSaveFileCSharp);
            this.Controls.Add(this.rTxtCppCode);
            this.Controls.Add(this.btnConvertFromCpp);
            this.Controls.Add(this.lblHeaderCSharp);
            this.Controls.Add(this.lblHeaderCpp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHeader);
            this.Name = "FormCon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtCSharpCode;
        private System.Windows.Forms.Button btnOpenFileCpp;
        private System.Windows.Forms.SaveFileDialog saveFileCSharp;
        private System.Windows.Forms.Button btnSaveFileCSharp;
        private System.Windows.Forms.RichTextBox rTxtCppCode;
        private System.Windows.Forms.Button btnConvertFromCpp;
        private System.Windows.Forms.Label lblHeaderCSharp;
        private System.Windows.Forms.OpenFileDialog openFileCSharp;
        private System.Windows.Forms.Label lblHeaderCpp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClear;
    }
}

