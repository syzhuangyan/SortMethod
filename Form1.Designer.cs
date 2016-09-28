namespace SortMethod
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BubbleCountList = new System.Windows.Forms.ComboBox();
            this.CreateRandomBtn = new System.Windows.Forms.Button();
            this.SortMethodList = new System.Windows.Forms.ComboBox();
            this.StartSort = new System.Windows.Forms.Button();
            this.SortStyleList = new System.Windows.Forms.ComboBox();
            this.BubbleNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BubbleCountList
            // 
            this.BubbleCountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BubbleCountList.FormattingEnabled = true;
            this.BubbleCountList.Location = new System.Drawing.Point(66, 21);
            this.BubbleCountList.Name = "BubbleCountList";
            this.BubbleCountList.Size = new System.Drawing.Size(68, 20);
            this.BubbleCountList.TabIndex = 0;
            this.BubbleCountList.SelectedIndexChanged += new System.EventHandler(this.BubbleCountList_SelectedIndexChanged);
            // 
            // CreateRandomBtn
            // 
            this.CreateRandomBtn.Location = new System.Drawing.Point(161, 20);
            this.CreateRandomBtn.Name = "CreateRandomBtn";
            this.CreateRandomBtn.Size = new System.Drawing.Size(108, 23);
            this.CreateRandomBtn.TabIndex = 1;
            this.CreateRandomBtn.Text = "生产随机数";
            this.CreateRandomBtn.UseVisualStyleBackColor = true;
            this.CreateRandomBtn.Click += new System.EventHandler(this.CreateRandomBtn_Click);
            // 
            // SortMethodList
            // 
            this.SortMethodList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortMethodList.FormattingEnabled = true;
            this.SortMethodList.Location = new System.Drawing.Point(293, 21);
            this.SortMethodList.Name = "SortMethodList";
            this.SortMethodList.Size = new System.Drawing.Size(158, 20);
            this.SortMethodList.TabIndex = 2;
            // 
            // StartSort
            // 
            this.StartSort.Location = new System.Drawing.Point(634, 21);
            this.StartSort.Name = "StartSort";
            this.StartSort.Size = new System.Drawing.Size(97, 23);
            this.StartSort.TabIndex = 3;
            this.StartSort.Text = "开始排序";
            this.StartSort.UseVisualStyleBackColor = true;
            // 
            // SortStyleList
            // 
            this.SortStyleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortStyleList.FormattingEnabled = true;
            this.SortStyleList.Location = new System.Drawing.Point(485, 22);
            this.SortStyleList.Name = "SortStyleList";
            this.SortStyleList.Size = new System.Drawing.Size(121, 20);
            this.SortStyleList.TabIndex = 4;
            // 
            // BubbleNum
            // 
            this.BubbleNum.AutoSize = true;
            this.BubbleNum.Location = new System.Drawing.Point(19, 24);
            this.BubbleNum.Name = "BubbleNum";
            this.BubbleNum.Size = new System.Drawing.Size(29, 12);
            this.BubbleNum.TabIndex = 5;
            this.BubbleNum.Text = "个数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 480);
            this.Controls.Add(this.BubbleNum);
            this.Controls.Add(this.SortStyleList);
            this.Controls.Add(this.StartSort);
            this.Controls.Add(this.SortMethodList);
            this.Controls.Add(this.CreateRandomBtn);
            this.Controls.Add(this.BubbleCountList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SortMethod";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BubbleCountList;
        private System.Windows.Forms.Button CreateRandomBtn;
        private System.Windows.Forms.ComboBox SortMethodList;
        private System.Windows.Forms.Button StartSort;
        private System.Windows.Forms.ComboBox SortStyleList;
        private System.Windows.Forms.Label BubbleNum;
    }
}

