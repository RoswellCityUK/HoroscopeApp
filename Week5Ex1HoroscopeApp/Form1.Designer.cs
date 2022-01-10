namespace Week5Ex1HoroscopeApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblZodiacSign = new System.Windows.Forms.Label();
            this.txtHoroscope = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDOB.Location = new System.Drawing.Point(12, 27);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(174, 25);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "Select your D.O.B.:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "yyyy-MM-dd";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(12, 55);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(240, 23);
            this.dtpDOB.TabIndex = 1;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Zodiac Sign:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 114);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(240, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Get Horoscope";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your horoscope for:";
            // 
            // lblZodiacSign
            // 
            this.lblZodiacSign.AutoSize = true;
            this.lblZodiacSign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblZodiacSign.Location = new System.Drawing.Point(363, 37);
            this.lblZodiacSign.Name = "lblZodiacSign";
            this.lblZodiacSign.Size = new System.Drawing.Size(70, 15);
            this.lblZodiacSign.TabIndex = 6;
            this.lblZodiacSign.Text = "Zodiac Sign";
            // 
            // txtHoroscope
            // 
            this.txtHoroscope.Location = new System.Drawing.Point(258, 55);
            this.txtHoroscope.Name = "txtHoroscope";
            this.txtHoroscope.Size = new System.Drawing.Size(196, 154);
            this.txtHoroscope.TabIndex = 7;
            this.txtHoroscope.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxDay
            // 
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Items.AddRange(new object[] {
            "Today",
            "Tomorrow",
            "Yesterday"});
            this.cbxDay.Location = new System.Drawing.Point(129, 85);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(123, 23);
            this.cbxDay.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 249);
            this.Controls.Add(this.cbxDay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHoroscope);
            this.Controls.Add(this.lblZodiacSign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDOB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HoroscopeApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDOB;
        private DateTimePicker dtpDOB;
        private Label label1;
        private Button btnSubmit;
        private Label label2;
        private Label lblZodiacSign;
        private RichTextBox txtHoroscope;
        private Button button1;
        private ComboBox cbxDay;
    }
}