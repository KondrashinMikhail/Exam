
namespace Exam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSecondMethod = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonFirstMethod = new System.Windows.Forms.Button();
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonAddFirstMeth = new System.Windows.Forms.Button();
            this.buttonAddSecondMeth = new System.Windows.Forms.Button();
            this.buttonDelFirstMeth = new System.Windows.Forms.Button();
            this.buttonInvokeFirstMeth = new System.Windows.Forms.Button();
            this.buttonDelSecondMeth = new System.Windows.Forms.Button();
            this.buttonInvokeSecodMeth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSecondMethod
            // 
            this.buttonSecondMethod.Location = new System.Drawing.Point(12, 135);
            this.buttonSecondMethod.Name = "buttonSecondMethod";
            this.buttonSecondMethod.Size = new System.Drawing.Size(160, 47);
            this.buttonSecondMethod.TabIndex = 0;
            this.buttonSecondMethod.Text = "Второй метод";
            this.buttonSecondMethod.UseVisualStyleBackColor = true;
            this.buttonSecondMethod.Click += new System.EventHandler(this.buttonSecondMethod_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(160, 36);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Создать объект от класса";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonFirstMethod
            // 
            this.buttonFirstMethod.Location = new System.Drawing.Point(12, 83);
            this.buttonFirstMethod.Name = "buttonFirstMethod";
            this.buttonFirstMethod.Size = new System.Drawing.Size(160, 47);
            this.buttonFirstMethod.TabIndex = 2;
            this.buttonFirstMethod.Text = "Первый метод";
            this.buttonFirstMethod.UseVisualStyleBackColor = true;
            this.buttonFirstMethod.Click += new System.EventHandler(this.buttonFirstMethod_Click);
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Location = new System.Drawing.Point(12, 54);
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(160, 23);
            this.textBoxEnter.TabIndex = 3;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 188);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(160, 23);
            this.textBoxResult.TabIndex = 4;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(178, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(123, 199);
            this.listBox.TabIndex = 5;
            // 
            // buttonAddFirstMeth
            // 
            this.buttonAddFirstMeth.Location = new System.Drawing.Point(12, 217);
            this.buttonAddFirstMeth.Name = "buttonAddFirstMeth";
            this.buttonAddFirstMeth.Size = new System.Drawing.Size(194, 23);
            this.buttonAddFirstMeth.TabIndex = 6;
            this.buttonAddFirstMeth.Text = "Подписаться на первое событие";
            this.buttonAddFirstMeth.UseVisualStyleBackColor = true;
            this.buttonAddFirstMeth.Click += new System.EventHandler(this.buttonAddFirstMeth_Click);
            // 
            // buttonAddSecondMeth
            // 
            this.buttonAddSecondMeth.Location = new System.Drawing.Point(12, 246);
            this.buttonAddSecondMeth.Name = "buttonAddSecondMeth";
            this.buttonAddSecondMeth.Size = new System.Drawing.Size(194, 23);
            this.buttonAddSecondMeth.TabIndex = 7;
            this.buttonAddSecondMeth.Text = "Подписаться на второе событие";
            this.buttonAddSecondMeth.UseVisualStyleBackColor = true;
            this.buttonAddSecondMeth.Click += new System.EventHandler(this.buttonAddSecondMeth_Click);
            // 
            // buttonDelFirstMeth
            // 
            this.buttonDelFirstMeth.Location = new System.Drawing.Point(212, 217);
            this.buttonDelFirstMeth.Name = "buttonDelFirstMeth";
            this.buttonDelFirstMeth.Size = new System.Drawing.Size(194, 23);
            this.buttonDelFirstMeth.TabIndex = 8;
            this.buttonDelFirstMeth.Text = "Отписаться от первого события";
            this.buttonDelFirstMeth.UseVisualStyleBackColor = true;
            this.buttonDelFirstMeth.Click += new System.EventHandler(this.buttonDelFirstMeth_Click);
            // 
            // buttonInvokeFirstMeth
            // 
            this.buttonInvokeFirstMeth.Location = new System.Drawing.Point(307, 12);
            this.buttonInvokeFirstMeth.Name = "buttonInvokeFirstMeth";
            this.buttonInvokeFirstMeth.Size = new System.Drawing.Size(194, 23);
            this.buttonInvokeFirstMeth.TabIndex = 9;
            this.buttonInvokeFirstMeth.Text = "Вызвтаь первое событие";
            this.buttonInvokeFirstMeth.UseVisualStyleBackColor = true;
            this.buttonInvokeFirstMeth.Click += new System.EventHandler(this.buttonInvokeFirstMeth_Click);
            // 
            // buttonDelSecondMeth
            // 
            this.buttonDelSecondMeth.Location = new System.Drawing.Point(212, 246);
            this.buttonDelSecondMeth.Name = "buttonDelSecondMeth";
            this.buttonDelSecondMeth.Size = new System.Drawing.Size(194, 23);
            this.buttonDelSecondMeth.TabIndex = 10;
            this.buttonDelSecondMeth.Text = "Отписаться от второго события";
            this.buttonDelSecondMeth.UseVisualStyleBackColor = true;
            this.buttonDelSecondMeth.Click += new System.EventHandler(this.buttonDelSecondMeth_Click);
            // 
            // buttonInvokeSecodMeth
            // 
            this.buttonInvokeSecodMeth.Location = new System.Drawing.Point(307, 41);
            this.buttonInvokeSecodMeth.Name = "buttonInvokeSecodMeth";
            this.buttonInvokeSecodMeth.Size = new System.Drawing.Size(194, 23);
            this.buttonInvokeSecodMeth.TabIndex = 11;
            this.buttonInvokeSecodMeth.Text = "Вызвать второе событие";
            this.buttonInvokeSecodMeth.UseVisualStyleBackColor = true;
            this.buttonInvokeSecodMeth.Click += new System.EventHandler(this.buttonInvokeSecodMeth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInvokeSecodMeth);
            this.Controls.Add(this.buttonDelSecondMeth);
            this.Controls.Add(this.buttonInvokeFirstMeth);
            this.Controls.Add(this.buttonDelFirstMeth);
            this.Controls.Add(this.buttonAddSecondMeth);
            this.Controls.Add(this.buttonAddFirstMeth);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxEnter);
            this.Controls.Add(this.buttonFirstMethod);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonSecondMethod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSecondMethod;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonFirstMethod;
        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonAddFirstMeth;
        private System.Windows.Forms.Button buttonAddSecondMeth;
        private System.Windows.Forms.Button buttonDelFirstMeth;
        private System.Windows.Forms.Button buttonInvokeFirstMeth;
        private System.Windows.Forms.Button buttonDelSecondMeth;
        private System.Windows.Forms.Button buttonInvokeSecodMeth;
    }
}

