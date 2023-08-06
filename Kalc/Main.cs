using System;
using System.Reflection;
using System.Windows.Forms;
using NCalc;

namespace Kalc
{
    public partial class Main : Form
    {   
        private string expression = "";

        public Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            this.KeyPreview = true;
            this.KeyDown += Main_KeyDown;
            this.KeyPress += new KeyPressEventHandler(Main_KeyPress);

            InitializeComponent();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 取消事件的進一步傳遞
                e.SuppressKeyPress = true;
                buttonEqual.PerformClick();
            }
            else if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
                buttonEqual.PerformClick();
            }
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (Char.IsDigit(key))
            {
                // 如果是數字鍵，將對應的數字傳遞給 buttonNumber_Click 事件
                buttonNumber_Click(GetButtonFromNumber(key), null);
            }
            else if (key == '+')
            {
                buttonOperator_Click(buttonPlus, null);
            }
            else if (key == '-')
            {
                buttonOperator_Click(buttonMinus, null);
            }
            else if (key == '*')
            {
                buttonOperator_Click(buttonMulti, null);
            }
            else if (key == '/')
            {
                buttonOperator_Click(buttonDivide, null);
            }
            else if (key == '.')
            {
                buttonDot_Click(buttonDot, null);
            }
            else if (key == (char)Keys.Enter)
            {
                buttonEqual_Click(null, null);
            }
        }

        // 將數字字符對應到相應的 Button 控制元件
        private Button GetButtonFromNumber(char numberChar)
        {
            switch (numberChar)
            {
                case '0': return buttonZero;
                case '1': return buttonOne;
                case '2': return buttonTwo;
                case '3': return buttonThree;
                case '4': return buttonFour;
                case '5': return buttonFive;
                case '6': return buttonSix;
                case '7': return buttonSeven;
                case '8': return buttonEight;
                case '9': return buttonNine;
                default: return null;
            }
        }
        
        // 數字按鈕的 Click 事件處理函式
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            // 如果 expression 是 "0"，直接用輸入的數字替換掉首位的零
            if (expression == "0" || IsResultShown())
            {
                expression = button.Text;
            }
            else
            {
                expression += button.Text;
            }

            UpdateLabel();
        }

        // 判斷計算結果是否已經顯示在 expression 中
        private bool IsResultShown()
        {
            return labelExpression.Text.Contains("=");
        }

        // 運算符按鈕的 Click 事件處理函式
        private void buttonOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // 檢查 expression 是否為空
            if (string.IsNullOrEmpty(expression))
            {
                return;
            }

            // 檢查 expression 最後一個字符是否是運算符，避免重複添加運算符
            char lastChar = expression[expression.Length - 1];

            if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
            {
                // 如果已經存在運算符，則將現有的運算符替換為新的運算符
                expression = expression.Remove(expression.Length - 1) + button.Text;
            }
            else
            {
                // 如果不存在運算符，直接添加到 expression 字串的末尾
                expression += button.Text;
            }

            UpdateLabel();
        }

        // 小數點按鈕的 Click 事件處理函式
        private void buttonDot_Click(object sender, EventArgs e)
        {
            // 檢查 expression 是否已經包含小數點，避免重複添加小數點
            if (!expression.Contains("."))
            {
                // 如果 expression 是空的，則在前面補上 0，讓其成為有效的小數點
                if (string.IsNullOrEmpty(expression))
                {
                    expression = "0";
                }

                expression += ".";
            }
            else
            {
                // 如果已經存在小數點，檢查是否有運算符存在
                if (expression.Contains("+") || expression.Contains("-") || expression.Contains("*") || expression.Contains("/"))
                {
                    expression += "."; // 在運算符後方添加 "0."，形成新的小數點
                }
            }

            UpdateLabel();
        }

        // AC按鈕的 Click 事件處理函式
        private void buttonAc_Click(object sender, EventArgs e)
        {
            // 將 expression 重置為 "0"，即執行 "All Clear"
            expression = "0";
            // 重設含未稅價格為 0，以便下次計算時重新計算含未稅價格
            taxedPrice = 0;
            untaxedPrice = 0;
            UpdateLabel();
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string resourceName = null;
            string[] resourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();

            // 尋找 NCalc.dll 的資源名稱
            foreach (string name in resourceNames)
            {
                if (name.EndsWith(".NCalc.dll"))
                {
                    resourceName = name;
                    break;
                }
            }

            if (resourceName != null)
            {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    byte[] assemblyData = new byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            }

            return null;
        }

        // 加總按鈕的 Click 事件處理函式
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                // 如果 expression 字串為空，不進行計算
                if (string.IsNullOrEmpty(expression))
                {
                    return;
                }

                // 檢查 expression 字串的最後一個字元是否為運算符
                char lastChar = expression[expression.Length - 1];
                if (IsOperator(lastChar))
                {
                    expression = expression.Remove(expression.Length - 1);
                }

                Expression expr = new Expression(expression);
                object result = expr.Evaluate();

                // 將計算結果顯示在 Label 控制元件中
                if (result != null)
                {
                    // 使用 decimal 來計算浮點數，提供更高的精度
                    decimal decimalResult = Convert.ToDecimal(result);
                    labelExpression.Text = expression + " \n  = " + (double)decimalResult;

                    // 將計算結果（decimalResult）賦值給 expression，以便在計算結果的基礎上繼續計算
                    expression = decimalResult.ToString();
                }
                toolStripStatusLabel1.Text = "Result";
                // 顯示 IsResultShown() 方法的返回值（true 或 false）的對話框
                // MessageBox.Show("IsResultShown() is " + IsResultShown().ToString());
            }
            catch (EvaluationException ex)
            {
                // 若計算過程中出現錯誤，將錯誤訊息顯示在 Label 控制元件中
                labelExpression.Text = "Error! Please check the status bar.";
                toolStripStatusLabel1.Text = "Error: " + ex.Message;

                // 清空 expression 字串，準備輸入新的數字或運算
                expression = "";
            }
        }

        // 判斷是否為運算符的方法
        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        // 百分比按鈕的 Click 事件處理函式
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            try
            {
                // 如果 expression 字串為空，不進行計算
                if (string.IsNullOrEmpty(expression))
                {
                    return;
                }

                // 將表達式字串解析成數學表達式
                Expression expr = new Expression(expression);
                object result = expr.Evaluate();

                // 如果結果為數字，進行百分比計算（結果 * 0.01），並顯示在 labelExpression 控制元件中
                if (result is double || result is int)
                {
                    double numericResult = Convert.ToDouble(result);
                    double percentResult = numericResult * 0.01;
                    labelExpression.Text = expression + " \n= " + (double)percentResult;
                    expression = percentResult.ToString();
                }
                else
                {
                    labelExpression.Text = "Error! Please check the status bar.";
                    toolStripStatusLabel1.Text = "Error: Invalid expression.";
                    expression = "";
                }
            }
            catch (EvaluationException ex)
            {
                labelExpression.Text = "Error! Please check the status bar.";
                toolStripStatusLabel1.Text = "Error: " + ex.Message;
                expression = "";
            }
        }

        // 更新 Label 控制元件
        private void UpdateLabel()
        {
            labelExpression.Text = expression;
            toolStripStatusLabel1.Text = "Ready";
        }

        // 關閉程式
        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 呼叫 AboutBox
        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.Show();
        }

        // 在 Main 的類別內新增欄位，用於記錄稅率和含稅/未稅價格
        private decimal taxRate = 0;
        private decimal taxedPrice = 0;
        private decimal untaxedPrice = 0;

        // TToolStripMenuItem_Click事件處理函式，設定稅率
        private void 設定稅率TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 顯示設定稅率的對話框，讓使用者輸入稅率
            using (var dialog = new InputTaxRateDialog())
            {
                // 設定對話框的預設稅率為當前稅率
                dialog.TaxRate = taxRate;

                // 顯示對話框並檢查使用者是否按下了確定按鈕
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // 獲取使用者輸入的稅率並更新 taxRate 變數
                    taxRate = dialog.TaxRate;

                    // 將含稅價格重設為零，以便下次顯示時重新計算含稅價格
                    taxedPrice = 0;

                    // 更新稅率項目的文字顯示
                    設定稅率TToolStripMenuItem.Text = "設定稅率：" + taxRate.ToString("N") + "%";
                }
            }
        }

        // Initialize
        private void 初始化CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expression = "";
            taxRate = 0;
            taxedPrice = 0;
            設定稅率TToolStripMenuItem.Text = "設定稅率：" + taxRate.ToString("N") + "%";
            UpdateLabel();
        }

        // buttonTaxPlus_Click 事件處理函式，顯示含稅價格
        private void buttonTaxPlus_Click(object sender, EventArgs e)
        {
            // 如果表達式為空，顯示錯誤訊息並返回
            if (string.IsNullOrEmpty(expression))
            {
                labelExpression.Text = "Error! Please check the status bar.";
                toolStripStatusLabel1.Text = "含稅價不得為0，請重新輸入...";
                return;
            }

            // 如果含稅價格已經計算過，則直接顯示
            if (taxedPrice != 0)
            {
                labelExpression.Text = expression + " \n含稅價：" + taxedPrice.ToString("N");
                return;
            }

            // 否則，計算含稅價格並顯示
            try
            {
                Expression expr = new Expression(expression);
                object result = expr.Evaluate();

                // 將計算結果顯示在 Label 控制元件中
                if (result != null)
                {
                    // 使用 decimal 來計算浮點數，提供更高的精度
                    decimal decimalResult = Convert.ToDecimal(result);

                    // 計算含稅價格
                    decimal taxedPriceResult = decimalResult * (1 + taxRate / 100);

                    // 使用 "N" 格式化字串來加入千分位符號
                    labelExpression.Text = expression + " \n含稅價：" + taxedPriceResult.ToString("N");

                    // 將計算結果（decimalResult）賦值給 expression，以便在計算結果的基礎上繼續計算
                    expression = decimalResult.ToString();

                    // 將含稅價格暫存到 taxedPrice 變數中，以便下次顯示時直接使用
                    taxedPrice = taxedPriceResult;
                }
            }
            catch (EvaluationException ex)
            {
                // 若計算過程中出現錯誤，將錯誤訊息顯示在 Label 控制元件中
                labelExpression.Text = "Error! Please check the status bar.";
                toolStripStatusLabel1.Text = "Error: " + ex.Message;

                // 清空 expression 字串，準備輸入新的數字或運算
                expression = "";
            }
        }

        // buttonTaxMinus_Click 事件處理函式，顯示未稅價格
        private void buttonTaxMinus_Click_1(object sender, EventArgs e)
        {
            // 如果表達式為空，顯示錯誤訊息並返回
            if (string.IsNullOrEmpty(expression))
            {
                labelExpression.Text = "Error! Please check the status bar.";
                toolStripStatusLabel1.Text = "未稅價不得為0，請重新輸入...";
                return;
            }

            // 如果除稅價格已經計算過，則直接顯示
            if (untaxedPrice != 0)
            {
                labelExpression.Text = expression + " \n未稅價：" + untaxedPrice.ToString("N2");
                return;
            }

            // 否則，計算除稅價格並顯示
            try
            {
                Expression expr = new Expression(expression);
                object result = expr.Evaluate();

                // 將計算結果顯示在 Label 控制元件中
                if (result != null)
                {
                    // 使用 decimal 來計算浮點數，提供更高的精度
                    decimal decimalResult = Convert.ToDecimal(result);

                    // 將稅率轉換為小數形式
                    decimal taxRateDecimal = taxRate / 100m;
                    
                    // 計算除稅價格
                    decimal untaxedPriceResult = decimalResult / (1 + taxRate / 100);

                    // 使用 "N" 格式化字串來加入千分位符號
                    labelExpression.Text = expression + " \n未稅價：" + untaxedPriceResult.ToString("N2");

                    // 將計算結果（decimalResult）賦值給 expression，以便在計算結果的基礎上繼續計算
                    expression = decimalResult.ToString();

                    // 將除稅價格暫存到 untaxedPrice 變數中，以便下次顯示時直接使用
                    untaxedPrice = untaxedPriceResult;
                }
            }
            catch (EvaluationException ex)
            {
                // 若計算過程中出現錯誤，將錯誤訊息顯示在 Label 控制元件中
                labelExpression.Text = "Error! Please check the status bar.";
                toolStripStatusLabel1.Text = "Error: " + ex.Message;

                // 清空 expression 字串，準備輸入新的數字或運算
                expression = "";
            }
        }

        //將 TW "taxRate" 設定為 5
        private void TwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 將 taxRate 設定為 5
            taxRate = 5;

            // 將含稅價格重設為零，以便下次顯示時重新計算含稅價格
            taxedPrice = 0;

            // 更新稅率項目的文字顯示
            設定稅率TToolStripMenuItem.Text = "設定稅率：" + taxRate.ToString("N") + "%";
        }

        //將 JP "taxRate" 設定為 8
        private void JpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 將 taxRate 設定為 8
            taxRate = 8;

            // 將含稅價格重設為零，以便下次顯示時重新計算含稅價格
            taxedPrice = 0;

            // 更新稅率項目的文字顯示
            設定稅率TToolStripMenuItem.Text = "設定稅率：" + taxRate.ToString("N") + "%";
        }

        //將 JP "taxRate" 設定為 10
        private void Jp2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 將 taxRate 設定為 10
            taxRate = 10;

            // 將含稅價格重設為零，以便下次顯示時重新計算含稅價格
            taxedPrice = 0;

            // 更新稅率項目的文字顯示
            設定稅率TToolStripMenuItem.Text = "設定稅率：" + taxRate.ToString("N") + "%";
        }
    }

    //InputTaxRateDialog 類別屬性
    public class InputTaxRateDialog : Form
    {
        private Label labelTaxRate;
        private NumericUpDown numericUpDownTaxRate;
        private Button buttonOK;
        private Button buttonCancel;

        public decimal TaxRate
        {
            get { return numericUpDownTaxRate.Value; }
            set { numericUpDownTaxRate.Value = value; }
        }

        public InputTaxRateDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelTaxRate = new System.Windows.Forms.Label();
            this.numericUpDownTaxRate = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaxRate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTaxRate
            // 
            this.labelTaxRate.AutoSize = true;
            this.labelTaxRate.Location = new System.Drawing.Point(13, 13);
            this.labelTaxRate.Name = "labelTaxRate";
            this.labelTaxRate.Size = new System.Drawing.Size(41, 15);
            this.labelTaxRate.TabIndex = 0;
            this.labelTaxRate.Text = "稅率：";
            // 
            // numericUpDownTaxRate
            // 
            this.numericUpDownTaxRate.DecimalPlaces = 2;
            this.numericUpDownTaxRate.Increment = new decimal(new int[] {1,0,0,131072});
            this.numericUpDownTaxRate.Location = new System.Drawing.Point(60, 11);
            this.numericUpDownTaxRate.Name = "numericUpDownTaxRate";
            this.numericUpDownTaxRate.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownTaxRate.TabIndex = 1;
            this.numericUpDownTaxRate.Value = new decimal(new int[] {0,0,0,0});
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(108, 48);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 25);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "確定";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(32, 48);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(70, 25);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // InputTaxRateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 83);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.numericUpDownTaxRate);
            this.Controls.Add(this.labelTaxRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputTaxRateDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "稅率";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaxRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
