
namespace 롤토체스_조합_시뮬레이션
{
    partial class MF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MF));
            this.WB1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.select1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // WB1
            // 
            this.WB1.Location = new System.Drawing.Point(12, 92);
            this.WB1.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB1.Name = "WB1";
            this.WB1.Size = new System.Drawing.Size(250, 250);
            this.WB1.TabIndex = 1;
            this.WB1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(12, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // select1
            // 
            this.select1.FormattingEnabled = true;
            this.select1.Location = new System.Drawing.Point(381, 92);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(208, 20);
            this.select1.TabIndex = 3;
            // 
            // MF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.select1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MF";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "롤토체스 조합 시뮬레이션";
            this.Load += new System.EventHandler(this.MF_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser WB1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox select1;
    }
}

