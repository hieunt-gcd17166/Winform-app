namespace WindowsFormsApp1
{
    partial class Registration
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InFName = new System.Windows.Forms.TextBox();
            this.InLName = new System.Windows.Forms.TextBox();
            this.InPhone = new System.Windows.Forms.TextBox();
            this.InEmail = new System.Windows.Forms.TextBox();
            this.InPass = new System.Windows.Forms.TextBox();
            this.InCard = new System.Windows.Forms.TextBox();
            this.InAge = new System.Windows.Forms.ComboBox();
            this.InCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Country :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Password :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Card Number :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InFName
            // 
            this.InFName.Location = new System.Drawing.Point(149, 41);
            this.InFName.Name = "InFName";
            this.InFName.Size = new System.Drawing.Size(182, 20);
            this.InFName.TabIndex = 12;
            // 
            // InLName
            // 
            this.InLName.Location = new System.Drawing.Point(149, 67);
            this.InLName.Name = "InLName";
            this.InLName.Size = new System.Drawing.Size(182, 20);
            this.InLName.TabIndex = 13;
            // 
            // InPhone
            // 
            this.InPhone.Location = new System.Drawing.Point(149, 147);
            this.InPhone.Name = "InPhone";
            this.InPhone.Size = new System.Drawing.Size(182, 20);
            this.InPhone.TabIndex = 14;
            // 
            // InEmail
            // 
            this.InEmail.Location = new System.Drawing.Point(149, 173);
            this.InEmail.Name = "InEmail";
            this.InEmail.Size = new System.Drawing.Size(182, 20);
            this.InEmail.TabIndex = 15;
            // 
            // InPass
            // 
            this.InPass.Location = new System.Drawing.Point(149, 199);
            this.InPass.Name = "InPass";
            this.InPass.Size = new System.Drawing.Size(182, 20);
            this.InPass.TabIndex = 16;
            // 
            // InCard
            // 
            this.InCard.Location = new System.Drawing.Point(149, 225);
            this.InCard.Name = "InCard";
            this.InCard.Size = new System.Drawing.Size(182, 20);
            this.InCard.TabIndex = 17;
            // 
            // InAge
            // 
            this.InAge.FormattingEnabled = true;
            this.InAge.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80"});
            this.InAge.Location = new System.Drawing.Point(149, 93);
            this.InAge.Name = "InAge";
            this.InAge.Size = new System.Drawing.Size(182, 21);
            this.InAge.TabIndex = 18;
            // 
            // InCountry
            // 
            this.InCountry.FormattingEnabled = true;
            this.InCountry.Items.AddRange(new object[] {
            "Ả Rập Xê Út ",
            "Afghanistan ",
            "Ai Cập ",
            "Albania ",
            "Algeria ",
            "Ấn Độ ",
            "Andorra ",
            "Angola ",
            "Anh",
            "Áo ",
            "Argentina",
            "Armenia ",
            "Azerbaijan ",
            "Ba Lan",
            "Bắc Macedonia ",
            "Bahamas ",
            "Bahrain ",
            "Bangladesh ",
            "Barbados ﻿",
            "Belarus ",
            "Bénin ",
            "Bỉ ",
            "Bờ Biển Ngà ",
            "Bồ Đào Nha ",
            "Bolivia ",
            "Bosnia và Herzegovina  ",
            "Brazil ",
            "Brunei ",
            "Bulgaria  ",
            "Các tiểu vương quốc Ả Rập Thống nhất ",
            "Cameroon",
            "Campuchia",
            "Canada  ",
            "Chile Colombia ",
            "Comoros ",
            "Cộng hòa Congo ",
            "Cộng hòa dân chủ Congo ",
            "Cộng hòa Dominican ",
            "Cộng hòa Séc ",
            "Cộng hòa Trung Phi ",
            "Costa Rica ",
            "Croatia ",
            "Cuba  ",
            "Dominica ",
            "Đài Loan",
            "Đan Mạch ",
            "Đông Timor ",
            "Đức ",
            "Ecuador ",
            "El Salvador  ",
            "Ghana  ",
            "Hà Lan  ",
            "Hàn Quốc ",
            "Hoa Kỳ ",
            "Honduras ",
            "Hungary ",
            "Hy Lạp ",
            "Iceland ",
            "Indonesia ",
            "Iran ",
            "Iraq ",
            "Ireland ",
            "Israel ",
            "Jamaica ",
            "Jordan",
            "Kazakhstan ",
            "Kenya  ",
            "Lào ",
            "Latvia ",
            "Lesotho ",
            "Liban ",
            "Liberia",
            "Libya ",
            "Luxembourg ",
            "Ma-rốc ",
            "Madagascar ",
            "Malawi ",
            "Malaysia ",
            "Maldives  ",
            "Mexico ﻿",
            "Moldova ",
            "Monaco ",
            "Mông Cổ ",
            "Montenegro  ",
            "Myanmar ",
            "Na Uy",
            "Nam Phi ",
            "Nepal",
            "New Zealand ",
            "Nga ",
            "Nhật Bản  ",
            "Pakistan  ",
            "Palestine ",
            "Paraguay",
            "Peru ",
            "Phần Lan ",
            "Pháp",
            "Philippines ",
            "Qatar ",
            "Serbia ",
            "Singapore ",
            "Slovakia ",
            "Slovenia ",
            "Tanzania ",
            "Tây Ban Nha",
            "Thái Lan ",
            "Thổ Nhĩ Kỳ ",
            "Thụy Điển ",
            "Thụy Sĩ ",
            "Togo Tonga ",
            "Triều Tiên ",
            "Trung Quốc ",
            "Tunisia ",
            "Úc ",
            "Ukraine ",
            "Uruguay ",
            "Uzbekistan",
            "Venezuela",
            "Việt Nam ",
            "Ý ",
            "Yemen",
            "Zambia ",
            "Zimbabwe",
            ""});
            this.InCountry.Location = new System.Drawing.Point(149, 120);
            this.InCountry.Name = "InCountry";
            this.InCountry.Size = new System.Drawing.Size(182, 21);
            this.InCountry.TabIndex = 19;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 383);
            this.Controls.Add(this.InCountry);
            this.Controls.Add(this.InAge);
            this.Controls.Add(this.InCard);
            this.Controls.Add(this.InPass);
            this.Controls.Add(this.InEmail);
            this.Controls.Add(this.InPhone);
            this.Controls.Add(this.InLName);
            this.Controls.Add(this.InFName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox InFName;
        private System.Windows.Forms.TextBox InLName;
        private System.Windows.Forms.TextBox InPhone;
        private System.Windows.Forms.TextBox InEmail;
        private System.Windows.Forms.TextBox InPass;
        private System.Windows.Forms.TextBox InCard;
        private System.Windows.Forms.ComboBox InAge;
        private System.Windows.Forms.ComboBox InCountry;
    }
}