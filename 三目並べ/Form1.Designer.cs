namespace 三目並べ
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ニューゲームToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.B3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.x_win_count = new System.Windows.Forms.Label();
            this.draw_count = new System.Windows.Forms.Label();
            this.o_win_count = new System.Windows.Forms.Label();
            this.カウントリセットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(422, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メニューToolStripMenuItem
            // 
            this.メニューToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ニューゲームToolStripMenuItem,
            this.カウントリセットToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem";
            this.メニューToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.メニューToolStripMenuItem.Text = "メニュー";
            // 
            // ニューゲームToolStripMenuItem
            // 
            this.ニューゲームToolStripMenuItem.Name = "ニューゲームToolStripMenuItem";
            this.ニューゲームToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ニューゲームToolStripMenuItem.Text = "ニューゲーム";
            this.ニューゲームToolStripMenuItem.Click += new System.EventHandler(this.ニューゲームToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(256, 70);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(90, 90);
            this.B3.TabIndex = 3;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(64, 70);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(90, 90);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(160, 70);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(90, 90);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B4
            // 
            this.B4.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.Location = new System.Drawing.Point(64, 166);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(90, 90);
            this.B4.TabIndex = 6;
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.button_click);
            this.B4.MouseEnter += new System.EventHandler(this.button_enter);
            this.B4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B5
            // 
            this.B5.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B5.Location = new System.Drawing.Point(160, 166);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(90, 90);
            this.B5.TabIndex = 7;
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.button_click);
            this.B5.MouseEnter += new System.EventHandler(this.button_enter);
            this.B5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B6
            // 
            this.B6.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B6.Location = new System.Drawing.Point(256, 166);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(90, 90);
            this.B6.TabIndex = 8;
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.button_click);
            this.B6.MouseEnter += new System.EventHandler(this.button_enter);
            this.B6.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B7
            // 
            this.B7.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B7.Location = new System.Drawing.Point(64, 262);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(90, 90);
            this.B7.TabIndex = 9;
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.button_click);
            this.B7.MouseEnter += new System.EventHandler(this.button_enter);
            this.B7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B8
            // 
            this.B8.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B8.Location = new System.Drawing.Point(160, 262);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(90, 90);
            this.B8.TabIndex = 10;
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.button_click);
            this.B8.MouseEnter += new System.EventHandler(this.button_enter);
            this.B8.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B9
            // 
            this.B9.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B9.Location = new System.Drawing.Point(256, 262);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(90, 90);
            this.B9.TabIndex = 11;
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.button_click);
            this.B9.MouseEnter += new System.EventHandler(this.button_enter);
            this.B9.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(70, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "X の勝利数";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(166, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "引き分け数";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(262, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "O の勝利数";
            // 
            // x_win_count
            // 
            this.x_win_count.AutoSize = true;
            this.x_win_count.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.x_win_count.Location = new System.Drawing.Point(101, 382);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(15, 13);
            this.x_win_count.TabIndex = 15;
            this.x_win_count.Text = "0";
            this.x_win_count.Click += new System.EventHandler(this.label4_Click);
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.draw_count.Location = new System.Drawing.Point(198, 382);
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(15, 13);
            this.draw_count.TabIndex = 16;
            this.draw_count.Text = "0";
            this.draw_count.Click += new System.EventHandler(this.label5_Click);
            // 
            // o_win_count
            // 
            this.o_win_count.AutoSize = true;
            this.o_win_count.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.o_win_count.Location = new System.Drawing.Point(295, 382);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(15, 13);
            this.o_win_count.TabIndex = 17;
            this.o_win_count.Text = "0";
            this.o_win_count.Click += new System.EventHandler(this.label6_Click);
            // 
            // カウントリセットToolStripMenuItem
            // 
            this.カウントリセットToolStripMenuItem.Name = "カウントリセットToolStripMenuItem";
            this.カウントリセットToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.カウントリセットToolStripMenuItem.Text = "カウントリセット";
            this.カウントリセットToolStripMenuItem.Click += new System.EventHandler(this.カウントリセットToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(422, 413);
            this.Controls.Add(this.o_win_count);
            this.Controls.Add(this.draw_count);
            this.Controls.Add(this.x_win_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "三目並べ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニューToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ニューゲームToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label x_win_count;
        private System.Windows.Forms.Label draw_count;
        private System.Windows.Forms.Label o_win_count;
        private System.Windows.Forms.ToolStripMenuItem カウントリセットToolStripMenuItem;
    }
}

