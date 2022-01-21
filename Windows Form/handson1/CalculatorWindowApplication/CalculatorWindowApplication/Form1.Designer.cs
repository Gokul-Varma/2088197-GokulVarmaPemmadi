namespace CalculatorWindowApplication
{
    partial class Form1
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
            this.lblinput1 = new System.Windows.Forms.Label();
            this.lblinput2 = new System.Windows.Forms.Label();
            this.txtinput1 = new System.Windows.Forms.TextBox();
            this.txtinput2 = new System.Windows.Forms.TextBox();
            this.lblOperation = new System.Windows.Forms.Label();
            this.radioButton_add = new System.Windows.Forms.RadioButton();
            this.radioButton_subtract = new System.Windows.Forms.RadioButton();
            this.radioButton_multiply = new System.Windows.Forms.RadioButton();
            this.radioButton_division = new System.Windows.Forms.RadioButton();
            this.button_calculate = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblinput1
            // 
            this.lblinput1.AutoSize = true;
            this.lblinput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinput1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblinput1.Location = new System.Drawing.Point(81, 77);
            this.lblinput1.Name = "lblinput1";
            this.lblinput1.Size = new System.Drawing.Size(84, 29);
            this.lblinput1.TabIndex = 0;
            this.lblinput1.Text = "input1";
            this.lblinput1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblinput2
            // 
            this.lblinput2.AutoSize = true;
            this.lblinput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinput2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblinput2.Location = new System.Drawing.Point(81, 142);
            this.lblinput2.Name = "lblinput2";
            this.lblinput2.Size = new System.Drawing.Size(84, 29);
            this.lblinput2.TabIndex = 0;
            this.lblinput2.Text = "input2";
            this.lblinput2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtinput1
            // 
            this.txtinput1.Location = new System.Drawing.Point(181, 74);
            this.txtinput1.Name = "txtinput1";
            this.txtinput1.Size = new System.Drawing.Size(100, 26);
            this.txtinput1.TabIndex = 1;
            // 
            // txtinput2
            // 
            this.txtinput2.Location = new System.Drawing.Point(181, 142);
            this.txtinput2.Name = "txtinput2";
            this.txtinput2.Size = new System.Drawing.Size(100, 26);
            this.txtinput2.TabIndex = 2;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(64, 209);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(129, 29);
            this.lblOperation.TabIndex = 3;
            this.lblOperation.Text = "Operation";
            // 
            // radioButton_add
            // 
            this.radioButton_add.AutoSize = true;
            this.radioButton_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_add.Location = new System.Drawing.Point(214, 209);
            this.radioButton_add.Name = "radioButton_add";
            this.radioButton_add.Size = new System.Drawing.Size(73, 29);
            this.radioButton_add.TabIndex = 4;
            this.radioButton_add.TabStop = true;
            this.radioButton_add.Text = "Add";
            this.radioButton_add.UseVisualStyleBackColor = true;
            this.radioButton_add.CheckedChanged += new System.EventHandler(this.radioButton_add_CheckedChanged);
            // 
            // radioButton_subtract
            // 
            this.radioButton_subtract.AutoSize = true;
            this.radioButton_subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_subtract.Location = new System.Drawing.Point(315, 209);
            this.radioButton_subtract.Name = "radioButton_subtract";
            this.radioButton_subtract.Size = new System.Drawing.Size(110, 29);
            this.radioButton_subtract.TabIndex = 4;
            this.radioButton_subtract.TabStop = true;
            this.radioButton_subtract.Text = "Subtract";
            this.radioButton_subtract.UseVisualStyleBackColor = true;
            this.radioButton_subtract.CheckedChanged += new System.EventHandler(this.radioButton_subtract_CheckedChanged);
            // 
            // radioButton_multiply
            // 
            this.radioButton_multiply.AutoSize = true;
            this.radioButton_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_multiply.Location = new System.Drawing.Point(468, 209);
            this.radioButton_multiply.Name = "radioButton_multiply";
            this.radioButton_multiply.Size = new System.Drawing.Size(103, 29);
            this.radioButton_multiply.TabIndex = 4;
            this.radioButton_multiply.TabStop = true;
            this.radioButton_multiply.Text = "Multiply";
            this.radioButton_multiply.UseVisualStyleBackColor = true;
            this.radioButton_multiply.CheckedChanged += new System.EventHandler(this.radioButton_multiply_CheckedChanged);
            // 
            // radioButton_division
            // 
            this.radioButton_division.AutoSize = true;
            this.radioButton_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_division.Location = new System.Drawing.Point(608, 210);
            this.radioButton_division.Name = "radioButton_division";
            this.radioButton_division.Size = new System.Drawing.Size(105, 29);
            this.radioButton_division.TabIndex = 4;
            this.radioButton_division.TabStop = true;
            this.radioButton_division.Text = "Division";
            this.radioButton_division.UseVisualStyleBackColor = true;
            this.radioButton_division.CheckedChanged += new System.EventHandler(this.radioButton_division_CheckedChanged);
            // 
            // button_calculate
            // 
            this.button_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calculate.Location = new System.Drawing.Point(128, 269);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(130, 52);
            this.button_calculate.TabIndex = 5;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_result_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(315, 269);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(130, 52);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(53, 375);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(140, 36);
            this.lblresult.TabIndex = 6;
            this.lblresult.Text = "RESULT";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(229, 375);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(180, 36);
            this.txtresult.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(308, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "CALCULATOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.radioButton_division);
            this.Controls.Add(this.radioButton_multiply);
            this.Controls.Add(this.radioButton_subtract);
            this.Controls.Add(this.radioButton_add);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.txtinput2);
            this.Controls.Add(this.txtinput1);
            this.Controls.Add(this.lblinput2);
            this.Controls.Add(this.lblinput1);
            this.Name = "Form1";
            this.Text = "Calculatorapp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinput1;
        private System.Windows.Forms.Label lblinput2;
        private System.Windows.Forms.TextBox txtinput1;
        private System.Windows.Forms.TextBox txtinput2;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.RadioButton radioButton_add;
        private System.Windows.Forms.RadioButton radioButton_subtract;
        private System.Windows.Forms.RadioButton radioButton_multiply;
        private System.Windows.Forms.RadioButton radioButton_division;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label1;
    }
}

