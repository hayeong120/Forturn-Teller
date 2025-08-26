namespace Forturn_Teller
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
            this.tbBirthtime = new System.Windows.Forms.GroupBox();
            this.btnShowResult = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbBirthtime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBirthtime
            // 
            this.tbBirthtime.Controls.Add(this.button1);
            this.tbBirthtime.Controls.Add(this.textBox1);
            this.tbBirthtime.Controls.Add(this.tbBirthday);
            this.tbBirthtime.Controls.Add(this.label2);
            this.tbBirthtime.Controls.Add(this.label1);
            this.tbBirthtime.Location = new System.Drawing.Point(12, 12);
            this.tbBirthtime.Name = "tbBirthtime";
            this.tbBirthtime.Size = new System.Drawing.Size(385, 426);
            this.tbBirthtime.TabIndex = 0;
            this.tbBirthtime.TabStop = false;
            this.tbBirthtime.Text = "사용자 입력";
            this.tbBirthtime.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnShowResult
            // 
            this.btnShowResult.Location = new System.Drawing.Point(403, 12);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(385, 426);
            this.btnShowResult.TabIndex = 1;
            this.btnShowResult.TabStop = false;
            this.btnShowResult.Text = "사주 결과";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "생년월일을 입력하세요(예: 20070101)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "태어난 시각을 입력해주세요(예: 08시 -> 08)";
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(64, 120);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(245, 21);
            this.tbBirthday.TabIndex = 2;
            this.tbBirthday.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 21);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "결과 보러가기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.tbBirthtime);
            this.Name = "Form1";
            this.Text = "포츈텔러";
            this.tbBirthtime.ResumeLayout(false);
            this.tbBirthtime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tbBirthtime;
        private System.Windows.Forms.GroupBox btnShowResult;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

