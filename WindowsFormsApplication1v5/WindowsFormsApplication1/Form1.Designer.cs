namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkAssassin = new System.Windows.Forms.CheckBox();
            this.chkTank = new System.Windows.Forms.CheckBox();
            this.chkMaster = new System.Windows.Forms.CheckBox();
            this.chkAid = new System.Windows.Forms.CheckBox();
            this.chkFighters = new System.Windows.Forms.CheckBox();
            this.chkArcher = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(419, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "搜尋";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(687, 330);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // chkAssassin
            // 
            this.chkAssassin.AutoSize = true;
            this.chkAssassin.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkAssassin.Location = new System.Drawing.Point(18, 22);
            this.chkAssassin.Name = "chkAssassin";
            this.chkAssassin.Size = new System.Drawing.Size(66, 23);
            this.chkAssassin.TabIndex = 3;
            this.chkAssassin.Text = "刺客";
            this.chkAssassin.UseVisualStyleBackColor = true;
            this.chkAssassin.CheckedChanged += new System.EventHandler(this.Check_Clicked);
            // 
            // chkTank
            // 
            this.chkTank.AutoSize = true;
            this.chkTank.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkTank.Location = new System.Drawing.Point(84, 22);
            this.chkTank.Name = "chkTank";
            this.chkTank.Size = new System.Drawing.Size(66, 23);
            this.chkTank.TabIndex = 3;
            this.chkTank.Text = "坦克";
            this.chkTank.UseVisualStyleBackColor = true;
            this.chkTank.CheckedChanged += new System.EventHandler(this.Check_Clicked);
            // 
            // chkMaster
            // 
            this.chkMaster.AutoSize = true;
            this.chkMaster.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkMaster.Location = new System.Drawing.Point(150, 22);
            this.chkMaster.Name = "chkMaster";
            this.chkMaster.Size = new System.Drawing.Size(66, 23);
            this.chkMaster.TabIndex = 3;
            this.chkMaster.Text = "法師";
            this.chkMaster.UseVisualStyleBackColor = true;
            this.chkMaster.CheckedChanged += new System.EventHandler(this.Check_Clicked);
            // 
            // chkAid
            // 
            this.chkAid.AutoSize = true;
            this.chkAid.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkAid.Location = new System.Drawing.Point(216, 22);
            this.chkAid.Name = "chkAid";
            this.chkAid.Size = new System.Drawing.Size(66, 23);
            this.chkAid.TabIndex = 3;
            this.chkAid.Text = "輔助";
            this.chkAid.UseVisualStyleBackColor = true;
            this.chkAid.CheckedChanged += new System.EventHandler(this.Check_Clicked);
            // 
            // chkFighters
            // 
            this.chkFighters.AutoSize = true;
            this.chkFighters.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkFighters.Location = new System.Drawing.Point(282, 22);
            this.chkFighters.Name = "chkFighters";
            this.chkFighters.Size = new System.Drawing.Size(66, 23);
            this.chkFighters.TabIndex = 3;
            this.chkFighters.Text = "鬥士";
            this.chkFighters.UseVisualStyleBackColor = true;
            this.chkFighters.CheckedChanged += new System.EventHandler(this.Check_Clicked);
            // 
            // chkArcher
            // 
            this.chkArcher.AutoSize = true;
            this.chkArcher.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkArcher.Location = new System.Drawing.Point(348, 22);
            this.chkArcher.Name = "chkArcher";
            this.chkArcher.Size = new System.Drawing.Size(66, 23);
            this.chkArcher.TabIndex = 3;
            this.chkArcher.Text = "射手";
            this.chkArcher.UseVisualStyleBackColor = true;
            this.chkArcher.CheckedChanged += new System.EventHandler(this.Check_Clicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(606, 22);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "後台管理";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 395);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkArcher);
            this.Controls.Add(this.chkFighters);
            this.Controls.Add(this.chkAid);
            this.Controls.Add(this.chkMaster);
            this.Controls.Add(this.chkTank);
            this.Controls.Add(this.chkAssassin);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkAssassin;
        private System.Windows.Forms.CheckBox chkTank;
        private System.Windows.Forms.CheckBox chkMaster;
        private System.Windows.Forms.CheckBox chkAid;
        private System.Windows.Forms.CheckBox chkFighters;
        private System.Windows.Forms.CheckBox chkArcher;
        private System.Windows.Forms.Button btnLogin;
    }
}

