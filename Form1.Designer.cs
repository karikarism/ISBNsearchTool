﻿namespace ISBNsearchTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Searchbt = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Clearbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Searchbt
            // 
            this.Searchbt.Location = new System.Drawing.Point(143, 31);
            this.Searchbt.Name = "Searchbt";
            this.Searchbt.Size = new System.Drawing.Size(75, 23);
            this.Searchbt.TabIndex = 0;
            this.Searchbt.Text = "Search";
            this.Searchbt.UseVisualStyleBackColor = true;
            this.Searchbt.Click += new System.EventHandler(this.Searchbt_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.Location = new System.Drawing.Point(-6, 93);
            this.StatusBox.Multiline = true;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(794, 207);
            this.StatusBox.TabIndex = 1;
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(27, 33);
            this.ISBN.MaxLength = 13;
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(100, 19);
            this.ISBN.TabIndex = 2;
            this.ISBN.Text = "9784785963194";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "ISBN(13桁)";
            // 
            // Clearbt
            // 
            this.Clearbt.Location = new System.Drawing.Point(143, 60);
            this.Clearbt.Name = "Clearbt";
            this.Clearbt.Size = new System.Drawing.Size(75, 23);
            this.Clearbt.TabIndex = 4;
            this.Clearbt.Text = "Clear";
            this.Clearbt.UseVisualStyleBackColor = true;
            this.Clearbt.Click += new System.EventHandler(this.Clearbt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clearbt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.Searchbt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Searchbt;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clearbt;
    }
}

