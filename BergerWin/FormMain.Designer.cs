namespace BergerWin
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCode = new System.Windows.Forms.Button();
            this.tbBinaryIn = new System.Windows.Forms.TextBox();
            this.tbBinaryOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbK = new System.Windows.Forms.Label();
            this.lbR = new System.Windows.Forms.Label();
            this.lbMu = new System.Windows.Forms.Label();
            this.tbWeights = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(106, 71);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(75, 23);
            this.btnCode.TabIndex = 0;
            this.btnCode.Text = "Code";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // tbBinaryIn
            // 
            this.tbBinaryIn.Location = new System.Drawing.Point(12, 36);
            this.tbBinaryIn.Name = "tbBinaryIn";
            this.tbBinaryIn.Size = new System.Drawing.Size(260, 20);
            this.tbBinaryIn.TabIndex = 1;
            // 
            // tbBinaryOut
            // 
            this.tbBinaryOut.Location = new System.Drawing.Point(12, 117);
            this.tbBinaryOut.Name = "tbBinaryOut";
            this.tbBinaryOut.ReadOnly = true;
            this.tbBinaryOut.Size = new System.Drawing.Size(260, 20);
            this.tbBinaryOut.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input combination:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result:";
            // 
            // lbK
            // 
            this.lbK.AutoSize = true;
            this.lbK.Location = new System.Drawing.Point(12, 158);
            this.lbK.Name = "lbK";
            this.lbK.Size = new System.Drawing.Size(16, 13);
            this.lbK.TabIndex = 5;
            this.lbK.Text = "...";
            // 
            // lbR
            // 
            this.lbR.AutoSize = true;
            this.lbR.Location = new System.Drawing.Point(117, 158);
            this.lbR.Name = "lbR";
            this.lbR.Size = new System.Drawing.Size(16, 13);
            this.lbR.TabIndex = 6;
            this.lbR.Text = "...";
            // 
            // lbMu
            // 
            this.lbMu.AutoSize = true;
            this.lbMu.Location = new System.Drawing.Point(219, 158);
            this.lbMu.Name = "lbMu";
            this.lbMu.Size = new System.Drawing.Size(16, 13);
            this.lbMu.TabIndex = 7;
            this.lbMu.Text = "...";
            // 
            // tbWeights
            // 
            this.tbWeights.Location = new System.Drawing.Point(12, 203);
            this.tbWeights.Multiline = true;
            this.tbWeights.Name = "tbWeights";
            this.tbWeights.ReadOnly = true;
            this.tbWeights.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbWeights.Size = new System.Drawing.Size(260, 105);
            this.tbWeights.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Weights:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 320);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbWeights);
            this.Controls.Add(this.lbMu);
            this.Controls.Add(this.lbR);
            this.Controls.Add(this.lbK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBinaryOut);
            this.Controls.Add(this.tbBinaryIn);
            this.Controls.Add(this.btnCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.Text = "Berger Plus Coder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.TextBox tbBinaryIn;
        private System.Windows.Forms.TextBox tbBinaryOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbK;
        private System.Windows.Forms.Label lbR;
        private System.Windows.Forms.Label lbMu;
        private System.Windows.Forms.TextBox tbWeights;
        private System.Windows.Forms.Label label4;
    }
}

