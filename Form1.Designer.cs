namespace MyTarot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myTarot정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.tbWorry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCard4 = new System.Windows.Forms.Button();
            this.btnCard3 = new System.Windows.Forms.Button();
            this.btnCard2 = new System.Windows.Forms.Button();
            this.btnCard1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.결과불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.결과불러오기ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            this.파일ToolStripMenuItem.Click += new System.EventHandler(this.파일ToolStripMenuItem_Click);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myTarot정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // myTarot정보ToolStripMenuItem
            // 
            this.myTarot정보ToolStripMenuItem.Name = "myTarot정보ToolStripMenuItem";
            this.myTarot정보ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.myTarot정보ToolStripMenuItem.Text = "My Tarot 정보";
            this.myTarot정보ToolStripMenuItem.Click += new System.EventHandler(this.myTarot정보ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDone);
            this.groupBox1.Controls.Add(this.tbWorry);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 입력";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(371, 152);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(170, 31);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "입력 완료";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbWorry
            // 
            this.tbWorry.Location = new System.Drawing.Point(26, 77);
            this.tbWorry.Multiline = true;
            this.tbWorry.Name = "tbWorry";
            this.tbWorry.Size = new System.Drawing.Size(288, 106);
            this.tbWorry.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "궁금한 주제를 입력하세요";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCard4);
            this.groupBox2.Controls.Add(this.btnCard3);
            this.groupBox2.Controls.Add(this.btnCard2);
            this.groupBox2.Controls.Add(this.btnCard1);
            this.groupBox2.Location = new System.Drawing.Point(14, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 280);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "카드 선택";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(592, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 199);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnCard4
            // 
            this.btnCard4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCard4.BackgroundImage")));
            this.btnCard4.Enabled = false;
            this.btnCard4.Location = new System.Drawing.Point(589, 45);
            this.btnCard4.Name = "btnCard4";
            this.btnCard4.Size = new System.Drawing.Size(130, 204);
            this.btnCard4.TabIndex = 3;
            this.btnCard4.Text = "☀️";
            this.btnCard4.UseVisualStyleBackColor = true;
            this.btnCard4.Click += new System.EventHandler(this.btnCard4_Click);
            // 
            // btnCard3
            // 
            this.btnCard3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCard3.BackgroundImage")));
            this.btnCard3.Enabled = false;
            this.btnCard3.Location = new System.Drawing.Point(409, 45);
            this.btnCard3.Name = "btnCard3";
            this.btnCard3.Size = new System.Drawing.Size(130, 204);
            this.btnCard3.TabIndex = 2;
            this.btnCard3.Text = "🌑";
            this.btnCard3.UseVisualStyleBackColor = true;
            this.btnCard3.Click += new System.EventHandler(this.btnCard3_Click);
            // 
            // btnCard2
            // 
            this.btnCard2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCard2.BackgroundImage")));
            this.btnCard2.Enabled = false;
            this.btnCard2.Location = new System.Drawing.Point(233, 45);
            this.btnCard2.Name = "btnCard2";
            this.btnCard2.Size = new System.Drawing.Size(130, 204);
            this.btnCard2.TabIndex = 1;
            this.btnCard2.Text = "🫧";
            this.btnCard2.UseVisualStyleBackColor = true;
            this.btnCard2.Click += new System.EventHandler(this.btnCard2_Click);
            // 
            // btnCard1
            // 
            this.btnCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCard1.BackgroundImage")));
            this.btnCard1.Enabled = false;
            this.btnCard1.Location = new System.Drawing.Point(52, 45);
            this.btnCard1.Name = "btnCard1";
            this.btnCard1.Size = new System.Drawing.Size(130, 204);
            this.btnCard1.TabIndex = 0;
            this.btnCard1.Text = "✨";
            this.btnCard1.UseVisualStyleBackColor = true;
            this.btnCard1.Click += new System.EventHandler(this.btnCard1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbResult);
            this.groupBox3.Location = new System.Drawing.Point(12, 533);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 139);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "카드 풀이";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(13, 21);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(750, 105);
            this.tbResult.TabIndex = 0;
            // 
            // 결과불러오기ToolStripMenuItem
            // 
            this.결과불러오기ToolStripMenuItem.Name = "결과불러오기ToolStripMenuItem";
            this.결과불러오기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.결과불러오기ToolStripMenuItem.Text = "결과 불러오기";
            this.결과불러오기ToolStripMenuItem.Click += new System.EventHandler(this.결과불러오기ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "My Tarot";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myTarot정보ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox tbWorry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCard1;
        private System.Windows.Forms.Button btnCard4;
        private System.Windows.Forms.Button btnCard3;
        private System.Windows.Forms.Button btnCard2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.ToolStripMenuItem 결과불러오기ToolStripMenuItem;
    }
}

