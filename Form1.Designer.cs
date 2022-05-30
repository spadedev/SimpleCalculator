
namespace SimpleCalculator
{
    partial class SimpleCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.subtract_btn = new System.Windows.Forms.Button();
            this.multiply_btn = new System.Windows.Forms.Button();
            this.divide_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.num1_txtbox = new System.Windows.Forms.TextBox();
            this.num2_txtbox = new System.Windows.Forms.TextBox();
            this.result_txtbox = new System.Windows.Forms.TextBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "The result is:";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(39, 192);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // subtract_btn
            // 
            this.subtract_btn.Location = new System.Drawing.Point(120, 192);
            this.subtract_btn.Name = "subtract_btn";
            this.subtract_btn.Size = new System.Drawing.Size(75, 23);
            this.subtract_btn.TabIndex = 4;
            this.subtract_btn.Text = "Subtract";
            this.subtract_btn.UseVisualStyleBackColor = true;
            this.subtract_btn.Click += new System.EventHandler(this.subtract_btn_Click);
            // 
            // multiply_btn
            // 
            this.multiply_btn.Location = new System.Drawing.Point(201, 192);
            this.multiply_btn.Name = "multiply_btn";
            this.multiply_btn.Size = new System.Drawing.Size(75, 23);
            this.multiply_btn.TabIndex = 5;
            this.multiply_btn.Text = "Multiply";
            this.multiply_btn.UseVisualStyleBackColor = true;
            this.multiply_btn.Click += new System.EventHandler(this.multiply_btn_Click);
            // 
            // divide_btn
            // 
            this.divide_btn.Location = new System.Drawing.Point(282, 192);
            this.divide_btn.Name = "divide_btn";
            this.divide_btn.Size = new System.Drawing.Size(75, 23);
            this.divide_btn.TabIndex = 6;
            this.divide_btn.Text = "Divide";
            this.divide_btn.UseVisualStyleBackColor = true;
            this.divide_btn.Click += new System.EventHandler(this.divide_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(58, 221);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(110, 23);
            this.clear_btn.TabIndex = 7;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // num1_txtbox
            // 
            this.num1_txtbox.Location = new System.Drawing.Point(168, 31);
            this.num1_txtbox.Name = "num1_txtbox";
            this.num1_txtbox.Size = new System.Drawing.Size(189, 20);
            this.num1_txtbox.TabIndex = 9;
            // 
            // num2_txtbox
            // 
            this.num2_txtbox.Location = new System.Drawing.Point(168, 68);
            this.num2_txtbox.Name = "num2_txtbox";
            this.num2_txtbox.Size = new System.Drawing.Size(189, 20);
            this.num2_txtbox.TabIndex = 10;
            // 
            // result_txtbox
            // 
            this.result_txtbox.Location = new System.Drawing.Point(168, 135);
            this.result_txtbox.Name = "result_txtbox";
            this.result_txtbox.Size = new System.Drawing.Size(189, 20);
            this.result_txtbox.TabIndex = 11;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(219, 221);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(110, 23);
            this.exit_btn.TabIndex = 12;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(413, 291);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.result_txtbox);
            this.Controls.Add(this.num2_txtbox);
            this.Controls.Add(this.num1_txtbox);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.divide_btn);
            this.Controls.Add(this.multiply_btn);
            this.Controls.Add(this.subtract_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SimpleCalculator";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.SimpleCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button subtract_btn;
        private System.Windows.Forms.Button multiply_btn;
        private System.Windows.Forms.Button divide_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TextBox num1_txtbox;
        private System.Windows.Forms.TextBox num2_txtbox;
        private System.Windows.Forms.TextBox result_txtbox;
        private System.Windows.Forms.Button exit_btn;
    }
}

