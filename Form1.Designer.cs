namespace Project1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_content = new System.Windows.Forms.TextBox();
            this.btn_count = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_content
            // 
            this.tb_content.Location = new System.Drawing.Point(48, 32);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.Size = new System.Drawing.Size(267, 344);
            this.tb_content.TabIndex = 0;
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(48, 408);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(267, 66);
            this.btn_count.TabIndex = 1;
            this.btn_count.Text = "빈도 알아보기";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(48, 500);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(267, 66);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "초기화하기";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.tb_content);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
    }
}

