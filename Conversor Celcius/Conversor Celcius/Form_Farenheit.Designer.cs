namespace Conversor_Celcius
{
    partial class Form_Farenheit
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
            this.btn_invert = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txb_celsius = new System.Windows.Forms.TextBox();
            this.txb_farenheit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_invert
            // 
            this.btn_invert.Font = new System.Drawing.Font("Helvetica LT Std Cond", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invert.Location = new System.Drawing.Point(149, 295);
            this.btn_invert.Name = "btn_invert";
            this.btn_invert.Size = new System.Drawing.Size(238, 31);
            this.btn_invert.TabIndex = 15;
            this.btn_invert.Text = "Invert Conversion";
            this.btn_invert.UseVisualStyleBackColor = true;
            this.btn_invert.Click += new System.EventHandler(this.btn_invert_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_clear.Font = new System.Drawing.Font("Helvetica LT Std Cond", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(279, 218);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(109, 71);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica LT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Insert Value in Celsius Box and press converter to convert at Farenheit";
            // 
            // btn_convert
            // 
            this.btn_convert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_convert.Font = new System.Drawing.Font("Helvetica LT Std Cond", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convert.ForeColor = System.Drawing.Color.Black;
            this.btn_convert.Location = new System.Drawing.Point(149, 218);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(109, 71);
            this.btn_convert.TabIndex = 12;
            this.btn_convert.Text = "Converter";
            this.btn_convert.UseVisualStyleBackColor = false;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Helvetica LT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_2.Location = new System.Drawing.Point(146, 151);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(278, 19);
            this.lbl_2.TabIndex = 11;
            this.lbl_2.Text = "This is value converted into Celsius";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Helvetica LT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_1.Location = new System.Drawing.Point(148, 82);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(173, 19);
            this.lbl_1.TabIndex = 10;
            this.lbl_1.Text = "Insert Farenheit Value";
            // 
            // txb_celsius
            // 
            this.txb_celsius.Enabled = false;
            this.txb_celsius.Font = new System.Drawing.Font("Helvetica LT Std Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_celsius.Location = new System.Drawing.Point(149, 171);
            this.txb_celsius.Name = "txb_celsius";
            this.txb_celsius.Size = new System.Drawing.Size(239, 28);
            this.txb_celsius.TabIndex = 9;
            // 
            // txb_farenheit
            // 
            this.txb_farenheit.Font = new System.Drawing.Font("Helvetica LT Std Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_farenheit.Location = new System.Drawing.Point(149, 103);
            this.txb_farenheit.Name = "txb_farenheit";
            this.txb_farenheit.Size = new System.Drawing.Size(239, 28);
            this.txb_farenheit.TabIndex = 8;
            // 
            // Form_Farenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 358);
            this.Controls.Add(this.btn_invert);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.txb_celsius);
            this.Controls.Add(this.txb_farenheit);
            this.Name = "Form_Farenheit";
            this.Text = "Converter to Celsius";
            this.Load += new System.EventHandler(this.Form_Farenheit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_invert;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txb_celsius;
        private System.Windows.Forms.TextBox txb_farenheit;

    }
}