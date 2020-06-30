namespace WindowsFormsApp1
{
    partial class MyAccount
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
            this.Email = new System.Windows.Forms.Label();
            this.FirName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Amount = new System.Windows.Forms.Label();
            this.Cardn = new System.Windows.Forms.Label();
            this.Phon = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Ag = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PhNumber = new System.Windows.Forms.Label();
            this.Card = new System.Windows.Forms.Label();
            this.AmountI = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Payment = new System.Windows.Forms.Button();
            this.Withdrawal = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataShow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(32, 40);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(237, 20);
            this.Email.TabIndex = 0;
            this.Email.Text = "label1";
            // 
            // FirName
            // 
            this.FirName.AutoSize = true;
            this.FirName.Location = new System.Drawing.Point(32, 97);
            this.FirName.Name = "FirName";
            this.FirName.Size = new System.Drawing.Size(35, 13);
            this.FirName.TabIndex = 1;
            this.FirName.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Amount, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Cardn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Phon, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Country, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Age, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Ag, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PhNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Card, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AmountI, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 122);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 130);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Amount
            // 
            this.Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(155, 111);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(59, 19);
            this.Amount.TabIndex = 14;
            this.Amount.Text = "label1";
            // 
            // Cardn
            // 
            this.Cardn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cardn.AutoSize = true;
            this.Cardn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cardn.Location = new System.Drawing.Point(155, 83);
            this.Cardn.Name = "Cardn";
            this.Cardn.Size = new System.Drawing.Size(59, 19);
            this.Cardn.TabIndex = 13;
            this.Cardn.Text = "label1";
            // 
            // Phon
            // 
            this.Phon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Phon.AutoSize = true;
            this.Phon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phon.Location = new System.Drawing.Point(155, 55);
            this.Phon.Name = "Phon";
            this.Phon.Size = new System.Drawing.Size(59, 19);
            this.Phon.TabIndex = 12;
            this.Phon.Text = "label1";
            // 
            // Country
            // 
            this.Country.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.Location = new System.Drawing.Point(155, 28);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(59, 19);
            this.Country.TabIndex = 11;
            this.Country.Text = "label1";
            // 
            // Age
            // 
            this.Age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(155, 2);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(59, 19);
            this.Age.TabIndex = 4;
            this.Age.Text = "label1";
            // 
            // Ag
            // 
            this.Ag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ag.AutoSize = true;
            this.Ag.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ag.Location = new System.Drawing.Point(3, 2);
            this.Ag.Name = "Ag";
            this.Ag.Size = new System.Drawing.Size(48, 19);
            this.Ag.TabIndex = 5;
            this.Ag.Text = "Age :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Country :";
            // 
            // PhNumber
            // 
            this.PhNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PhNumber.AutoSize = true;
            this.PhNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhNumber.Location = new System.Drawing.Point(3, 55);
            this.PhNumber.Name = "PhNumber";
            this.PhNumber.Size = new System.Drawing.Size(126, 19);
            this.PhNumber.TabIndex = 6;
            this.PhNumber.Text = "Phone Number :";
            // 
            // Card
            // 
            this.Card.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Card.AutoSize = true;
            this.Card.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.Location = new System.Drawing.Point(3, 83);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(115, 19);
            this.Card.TabIndex = 8;
            this.Card.Text = "Crad Number :";
            // 
            // AmountI
            // 
            this.AmountI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AmountI.AutoSize = true;
            this.AmountI.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountI.Location = new System.Drawing.Point(3, 111);
            this.AmountI.Name = "AmountI";
            this.AmountI.Size = new System.Drawing.Size(77, 19);
            this.AmountI.TabIndex = 10;
            this.AmountI.Text = "Amount :";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Payment, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Withdrawal, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Deposit, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(427, 79);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(171, 173);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Payment
            // 
            this.Payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Payment.Location = new System.Drawing.Point(20, 127);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(130, 38);
            this.Payment.TabIndex = 4;
            this.Payment.Text = "Payment Service";
            this.Payment.UseVisualStyleBackColor = true;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // Withdrawal
            // 
            this.Withdrawal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Withdrawal.Location = new System.Drawing.Point(20, 71);
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.Size = new System.Drawing.Size(130, 38);
            this.Withdrawal.TabIndex = 4;
            this.Withdrawal.Text = "Withdrawal";
            this.Withdrawal.UseVisualStyleBackColor = true;
            this.Withdrawal.Click += new System.EventHandler(this.Withdrawal_Click);
            // 
            // Deposit
            // 
            this.Deposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deposit.Location = new System.Drawing.Point(20, 11);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(130, 38);
            this.Deposit.TabIndex = 1;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(447, 26);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(130, 34);
            this.Del.TabIndex = 13;
            this.Del.Text = "Delete My Account";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataShow,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(35, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 165);
            this.dataGridView1.TabIndex = 14;
            // 
            // DataShow
            // 
            this.DataShow.HeaderText = "Log";
            this.DataShow.Name = "DataShow";
            this.DataShow.Width = 250;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Value";
            this.Column1.Name = "Column1";
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.FirName);
            this.Controls.Add(this.Email);
            this.Name = "MyAccount";
            this.Text = "MyAccount";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label FirName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label Cardn;
        private System.Windows.Forms.Label Phon;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Ag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PhNumber;
        private System.Windows.Forms.Label Card;
        private System.Windows.Forms.Label AmountI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.Button Withdrawal;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}