
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
            this.temp = new System.Windows.Forms.Label();
            this.Sunrise = new System.Windows.Forms.Label();
            this.Sunset = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Ville
            // 
            this.Ville.AutoSize = true;
            this.Ville.BackColor = System.Drawing.Color.Transparent;
            this.Ville.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ville.Location = new System.Drawing.Point(209, 140);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(56, 25);
            this.Ville.TabIndex = 0;
            this.Ville.Text = "City : ";
            this.Ville.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(272, 140);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(179, 27);
            this.City.TabIndex = 2;
            this.City.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(468, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Condition
            // 
            this.Condition.AutoSize = true;
            this.Condition.BackColor = System.Drawing.Color.Transparent;
            this.Condition.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Condition.Location = new System.Drawing.Point(361, 260);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(90, 25);
            this.Condition.TabIndex = 5;
            this.Condition.Text = "Condition";
            this.Condition.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.BackColor = System.Drawing.Color.Transparent;
            this.temp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.temp.Location = new System.Drawing.Point(457, 198);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(54, 25);
            this.temp.TabIndex = 7;
            this.temp.Text = "temp";
            this.temp.Click += new System.EventHandler(this.label3_Click);
            // 
            // Sunrise
            // 
            this.Sunrise.AutoSize = true;
            this.Sunrise.BackColor = System.Drawing.Color.Transparent;
            this.Sunrise.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sunrise.Location = new System.Drawing.Point(665, 300);
            this.Sunrise.Name = "Sunrise";
            this.Sunrise.Size = new System.Drawing.Size(69, 25);
            this.Sunrise.TabIndex = 8;
            this.Sunrise.Text = "Sunrise";
            this.Sunrise.Click += new System.EventHandler(this.Sunrise_Click);
            // 
            // Sunset
            // 
            this.Sunset.AutoSize = true;
            this.Sunset.BackColor = System.Drawing.Color.Transparent;
            this.Sunset.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sunset.Location = new System.Drawing.Point(665, 254);
            this.Sunset.Name = "Sunset";
            this.Sunset.Size = new System.Drawing.Size(65, 25);
            this.Sunset.TabIndex = 9;
            this.Sunset.Text = "Sunset";
            this.Sunset.Click += new System.EventHandler(this.Sunset_Click);
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.BackColor = System.Drawing.Color.Transparent;
            this.Pressure.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pressure.Location = new System.Drawing.Point(355, 300);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(78, 25);
            this.Pressure.TabIndex = 10;
            this.Pressure.Text = "Pressure";
            this.Pressure.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.BackColor = System.Drawing.Color.Transparent;
            this.Humidity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Humidity.Location = new System.Drawing.Point(352, 344);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(85, 25);
            this.Humidity.TabIndex = 11;
            this.Humidity.Text = "Humidity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(256, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Condition :";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(581, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sunset :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(581, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sunrise :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(256, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pressure :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(256, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Humidity :";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(348, 183);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(103, 58);
            this.picIcon.TabIndex = 19;
            this.picIcon.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(175, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 41);
            this.label4.TabIndex = 20;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(581, 344);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(114, 25);
            this.Label.TabIndex = 21;
            this.Label.Text = "Speed wind :";
            this.Label.Click += new System.EventHandler(this.label9_Click);
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.BackColor = System.Drawing.Color.Transparent;
            this.Speed.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Speed.Location = new System.Drawing.Point(690, 344);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(72, 25);
            this.Speed.TabIndex = 22;
            this.Speed.Text = "Speed  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(78, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "The weather in ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HUMAYUN_AMEL_ST2API_TP2.Properties.Resources.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.Sunset);
            this.Controls.Add(this.Sunrise);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ville);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label Sunrise;
        private System.Windows.Forms.Label Sunset;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label label9;
    }
}

