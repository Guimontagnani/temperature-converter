namespace Conversor_Celcius
{
    partial class Form_Celsius
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
            this.txb_celsius = new System.Windows.Forms.TextBox();
            this.txb_farenheit = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_invert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_celsius
            // 
            this.txb_celsius.Font = new System.Drawing.Font("Helvetica LT Std Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_celsius.Location = new System.Drawing.Point(145, 79);
            this.txb_celsius.Name = "txb_celsius";
            this.txb_celsius.Size = new System.Drawing.Size(239, 28);
            this.txb_celsius.TabIndex = 0;
            // 
            // txb_farenheit
            // 
            this.txb_farenheit.Enabled = false;
            this.txb_farenheit.Font = new System.Drawing.Font("Helvetica LT Std Cond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_farenheit.Location = new System.Drawing.Point(145, 147);
            this.txb_farenheit.Name = "txb_farenheit";
            this.txb_farenheit.Size = new System.Drawing.Size(239, 28);
            this.txb_farenheit.TabIndex = 1;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Helvetica LT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_1.Location = new System.Drawing.Point(144, 58);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(158, 19);
            this.lbl_1.TabIndex = 2;
            this.lbl_1.Text = "Insert Celsius Value";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Helvetica LT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_2.Location = new System.Drawing.Point(142, 127);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(293, 19);
            this.lbl_2.TabIndex = 3;
            this.lbl_2.Text = "This is value converted into Farenheit";
            // 
            // btn_convert
            // 
            this.btn_convert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_convert.Font = new System.Drawing.Font("Helvetica LT Std Cond", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convert.ForeColor = System.Drawing.Color.Black;
            this.btn_convert.Location = new System.Drawing.Point(145, 194);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(109, 71);
            this.btn_convert.TabIndex = 4;
            this.btn_convert.Text = "Converter";
            this.btn_convert.UseVisualStyleBackColor = false;
            this.btn_convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica LT Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insert Value in Celsius Box and press converter to convert at Farenheit";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_clear.Font = new System.Drawing.Font("Helvetica LT Std Cond", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(275, 194);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(109, 71);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_invert
            // 
            this.btn_invert.Font = new System.Drawing.Font("Helvetica LT Std Cond", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invert.Location = new System.Drawing.Point(145, 271);
            this.btn_invert.Name = "btn_invert";
            this.btn_invert.Size = new System.Drawing.Size(238, 31);
            this.btn_invert.TabIndex = 7;
            this.btn_invert.Text = "Invert Conversion";
            this.btn_invert.UseVisualStyleBackColor = true;
            this.btn_invert.Click += new System.EventHandler(this.btn_invert_Click);
            // 
            // Form_Celsius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 358);
            this.Controls.Add(this.btn_invert);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.txb_farenheit);
            this.Controls.Add(this.txb_celsius);
            this.Name = "Form_Celsius";
            this.Text = "Converter to Farenheit";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Form_Mais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_celsius;
        private System.Windows.Forms.TextBox txb_farenheit;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_invert;
    }
}

