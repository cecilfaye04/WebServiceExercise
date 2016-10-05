namespace WebServiceExercise
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
            this.txtTemp1 = new System.Windows.Forms.TextBox();
            this.txtTemp2 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cmbTemp = new System.Windows.Forms.ComboBox();
            this.cmbTempList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTemp1
            // 
            this.txtTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp1.Location = new System.Drawing.Point(164, 101);
            this.txtTemp1.Name = "txtTemp1";
            this.txtTemp1.Size = new System.Drawing.Size(120, 24);
            this.txtTemp1.TabIndex = 0;
            // 
            // txtTemp2
            // 
            this.txtTemp2.BackColor = System.Drawing.Color.White;
            this.txtTemp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp2.Location = new System.Drawing.Point(457, 101);
            this.txtTemp2.Name = "txtTemp2";
            this.txtTemp2.ReadOnly = true;
            this.txtTemp2.Size = new System.Drawing.Size(120, 24);
            this.txtTemp2.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.FlatAppearance.BorderSize = 2;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(225, 168);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(171, 47);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnCelsiusToFahrenheit_Click);
            // 
            // cmbTemp
            // 
            this.cmbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTemp.FormattingEnabled = true;
            this.cmbTemp.Location = new System.Drawing.Point(41, 100);
            this.cmbTemp.Name = "cmbTemp";
            this.cmbTemp.Size = new System.Drawing.Size(117, 26);
            this.cmbTemp.TabIndex = 7;
            this.cmbTemp.SelectedIndexChanged += new System.EventHandler(this.cmbTemp_SelectedIndexChanged);
            // 
            // cmbTempList
            // 
            this.cmbTempList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTempList.FormattingEnabled = true;
            this.cmbTempList.Location = new System.Drawing.Point(343, 100);
            this.cmbTempList.Name = "cmbTempList";
            this.cmbTempList.Size = new System.Drawing.Size(108, 26);
            this.cmbTempList.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "TEMPERATURE CONVERTER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTempList);
            this.Controls.Add(this.cmbTemp);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtTemp2);
            this.Controls.Add(this.txtTemp1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemp1;
        private System.Windows.Forms.TextBox txtTemp2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cmbTemp;
        private System.Windows.Forms.ComboBox cmbTempList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

