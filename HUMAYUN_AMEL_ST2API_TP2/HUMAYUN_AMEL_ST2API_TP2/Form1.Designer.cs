
namespace HUMAYUN_AMEL_ST2API_TP2
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
            this.Ville = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Condition = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.Label();
            this.Sunrise = new System.Windows.Forms.Label();
            this.Sunset = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Ville
            // 
            this.Ville.AutoSize = true;
            this.Ville.Location = new System.Drawing.Point(154, 118);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(34, 20);
            this.Ville.TabIndex = 0;
            this.Ville.Text = "City";
            this.Ville.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(210, 115);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(244, 27);
            this.City.TabIndex = 2;
            this.City.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "rechercher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Condition
            // 
            this.Condition.AutoSize = true;
            this.Condition.Location = new System.Drawing.Point(154, 253);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(74, 20);
            this.Condition.TabIndex = 5;
            this.Condition.Text = "Condition";
            this.Condition.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Location = new System.Drawing.Point(154, 299);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(55, 20);
            this.Details.TabIndex = 7;
            this.Details.Text = "Details";
            this.Details.Click += new System.EventHandler(this.label3_Click);
            // 
            // Sunrise
            // 
            this.Sunrise.AutoSize = true;
            this.Sunrise.Location = new System.Drawing.Point(507, 293);
            this.Sunrise.Name = "Sunrise";
            this.Sunrise.Size = new System.Drawing.Size(56, 20);
            this.Sunrise.TabIndex = 8;
            this.Sunrise.Text = "Sunrise";
            this.Sunrise.Click += new System.EventHandler(this.Sunrise_Click);
            // 
            // Sunset
            // 
            this.Sunset.AutoSize = true;
            this.Sunset.Location = new System.Drawing.Point(507, 247);
            this.Sunset.Name = "Sunset";
            this.Sunset.Size = new System.Drawing.Size(52, 20);
            this.Sunset.TabIndex = 9;
            this.Sunset.Text = "Sunset";
            this.Sunset.Click += new System.EventHandler(this.Sunset_Click);
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.Location = new System.Drawing.Point(510, 343);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(63, 20);
            this.Pressure.TabIndex = 10;
            this.Pressure.Text = "Pressure";
            this.Pressure.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.Location = new System.Drawing.Point(510, 388);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(70, 20);
            this.Humidity.TabIndex = 11;
            this.Humidity.Text = "Humidity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Condition :";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Details :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sunset :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sunrise :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pressure :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Humidity :";
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(266, 176);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(125, 62);
            this.picIcon.TabIndex = 19;
            this.picIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.Sunset);
            this.Controls.Add(this.Sunrise);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ville);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ville;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Condition;
        private System.Windows.Forms.Label Details;
        private System.Windows.Forms.Label Sunrise;
        private System.Windows.Forms.Label Sunset;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picIcon;
    }
}

