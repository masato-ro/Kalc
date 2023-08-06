namespace Kalc
{
    partial class Main
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelExpression = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonAc = new System.Windows.Forms.Button();
            this.buttonTaxMinus = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonTaxPlus = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初始化CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定稅率TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.常用各國稅率LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Jp2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelExpression
            // 
            this.labelExpression.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelExpression.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExpression.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelExpression.Location = new System.Drawing.Point(12, 38);
            this.labelExpression.Name = "labelExpression";
            this.labelExpression.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelExpression.Size = new System.Drawing.Size(268, 43);
            this.labelExpression.TabIndex = 0;
            this.labelExpression.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonPlus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMinus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonMulti, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDivide, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonEqual, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonDot, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonThree, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSix, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNine, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonZero, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonTwo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonFive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonEight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonOne, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonFour, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonAc, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonTaxMinus, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPercent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonTaxPlus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSeven, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 236);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(204, 3);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(61, 35);
            this.buttonPlus.TabIndex = 3;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(204, 50);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(61, 35);
            this.buttonMinus.TabIndex = 7;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Location = new System.Drawing.Point(204, 97);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(61, 35);
            this.buttonMulti.TabIndex = 11;
            this.buttonMulti.Text = "*";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(204, 144);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(61, 35);
            this.buttonDivide.TabIndex = 15;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(204, 191);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(61, 35);
            this.buttonEqual.TabIndex = 14;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(137, 191);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(61, 35);
            this.buttonDot.TabIndex = 16;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Location = new System.Drawing.Point(137, 144);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(61, 35);
            this.buttonThree.TabIndex = 10;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Location = new System.Drawing.Point(137, 97);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(61, 35);
            this.buttonSix.TabIndex = 6;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Location = new System.Drawing.Point(137, 50);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(61, 35);
            this.buttonNine.TabIndex = 2;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(70, 191);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(61, 35);
            this.buttonZero.TabIndex = 13;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(70, 144);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(61, 35);
            this.buttonTwo.TabIndex = 9;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Location = new System.Drawing.Point(70, 97);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(61, 35);
            this.buttonFive.TabIndex = 5;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Location = new System.Drawing.Point(70, 50);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(61, 35);
            this.buttonEight.TabIndex = 1;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(3, 144);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(61, 35);
            this.buttonOne.TabIndex = 8;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Location = new System.Drawing.Point(3, 97);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(61, 35);
            this.buttonFour.TabIndex = 4;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonAc
            // 
            this.buttonAc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAc.Location = new System.Drawing.Point(3, 191);
            this.buttonAc.Name = "buttonAc";
            this.buttonAc.Size = new System.Drawing.Size(61, 35);
            this.buttonAc.TabIndex = 12;
            this.buttonAc.Text = "AC";
            this.buttonAc.UseVisualStyleBackColor = true;
            this.buttonAc.Click += new System.EventHandler(this.buttonAc_Click);
            // 
            // buttonTaxMinus
            // 
            this.buttonTaxMinus.Location = new System.Drawing.Point(137, 3);
            this.buttonTaxMinus.Name = "buttonTaxMinus";
            this.buttonTaxMinus.Size = new System.Drawing.Size(61, 35);
            this.buttonTaxMinus.TabIndex = 18;
            this.buttonTaxMinus.Text = "未稅價";
            this.buttonTaxMinus.UseVisualStyleBackColor = true;
            this.buttonTaxMinus.Click += new System.EventHandler(this.buttonTaxMinus_Click_1);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Location = new System.Drawing.Point(3, 3);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(61, 35);
            this.buttonPercent.TabIndex = 17;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            // 
            // buttonTaxPlus
            // 
            this.buttonTaxPlus.Location = new System.Drawing.Point(70, 3);
            this.buttonTaxPlus.Name = "buttonTaxPlus";
            this.buttonTaxPlus.Size = new System.Drawing.Size(61, 35);
            this.buttonTaxPlus.TabIndex = 19;
            this.buttonTaxPlus.Text = "含稅價";
            this.buttonTaxPlus.UseVisualStyleBackColor = true;
            this.buttonTaxPlus.Click += new System.EventHandler(this.buttonTaxPlus_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Location = new System.Drawing.Point(3, 50);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(61, 35);
            this.buttonSeven.TabIndex = 20;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(292, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.說明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初始化CToolStripMenuItem,
            this.設定稅率TToolStripMenuItem,
            this.常用各國稅率LToolStripMenuItem,
            this.離開ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.檔案ToolStripMenuItem.Text = "檔案(&F)";
            // 
            // 初始化CToolStripMenuItem
            // 
            this.初始化CToolStripMenuItem.Name = "初始化CToolStripMenuItem";
            this.初始化CToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.初始化CToolStripMenuItem.Text = "初始化(&I)";
            this.初始化CToolStripMenuItem.Click += new System.EventHandler(this.初始化CToolStripMenuItem_Click);
            // 
            // 設定稅率TToolStripMenuItem
            // 
            this.設定稅率TToolStripMenuItem.Name = "設定稅率TToolStripMenuItem";
            this.設定稅率TToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.設定稅率TToolStripMenuItem.Text = "設定稅率(&T)";
            this.設定稅率TToolStripMenuItem.Click += new System.EventHandler(this.設定稅率TToolStripMenuItem_Click);
            // 
            // 常用各國稅率LToolStripMenuItem
            // 
            this.常用各國稅率LToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TwToolStripMenuItem,
            this.JpToolStripMenuItem,
            this.Jp2ToolStripMenuItem});
            this.常用各國稅率LToolStripMenuItem.Name = "常用各國稅率LToolStripMenuItem";
            this.常用各國稅率LToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.常用各國稅率LToolStripMenuItem.Text = "常用各國稅率(&L)";
            // 
            // TwToolStripMenuItem
            // 
            this.TwToolStripMenuItem.Name = "TwToolStripMenuItem";
            this.TwToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.TwToolStripMenuItem.Text = "中華民國5%";
            this.TwToolStripMenuItem.Click += new System.EventHandler(this.TwToolStripMenuItem_Click);
            // 
            // JpToolStripMenuItem
            // 
            this.JpToolStripMenuItem.Name = "JpToolStripMenuItem";
            this.JpToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.JpToolStripMenuItem.Text = "日本減輕稅率8%";
            this.JpToolStripMenuItem.Click += new System.EventHandler(this.JpToolStripMenuItem_Click);
            // 
            // Jp2ToolStripMenuItem
            // 
            this.Jp2ToolStripMenuItem.Name = "Jp2ToolStripMenuItem";
            this.Jp2ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.Jp2ToolStripMenuItem.Text = "日本一般稅率10%";
            this.Jp2ToolStripMenuItem.Click += new System.EventHandler(this.Jp2ToolStripMenuItem_Click);
            // 
            // 離開ToolStripMenuItem
            // 
            this.離開ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.離開ToolStripMenuItem.Text = "離開(&X)";
            this.離開ToolStripMenuItem.Click += new System.EventHandler(this.離開ToolStripMenuItem_Click);
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.說明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.關於ToolStripMenuItem});
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.說明ToolStripMenuItem.Text = "說明(&H)";
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.關於ToolStripMenuItem.Text = "關於(&A)";
            this.關於ToolStripMenuItem.Click += new System.EventHandler(this.關於ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.buttonEqual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAc;
            this.ClientSize = new System.Drawing.Size(292, 345);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelExpression);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalc 計算機";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExpression;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonAc;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 離開ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.ToolStripMenuItem 設定稅率TToolStripMenuItem;
        private System.Windows.Forms.Button buttonTaxMinus;
        private System.Windows.Forms.Button buttonTaxPlus;
        private System.Windows.Forms.ToolStripMenuItem 初始化CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 常用各國稅率LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Jp2ToolStripMenuItem;
        private System.Windows.Forms.Button buttonSeven;
    }
}

