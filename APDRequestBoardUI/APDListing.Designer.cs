namespace APDRequestBoardUI
{
    partial class APDListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APDListing));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PersonAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PersonEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PersonPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RAPDItem1 = new System.Windows.Forms.ComboBox();
            this.PAPDItem1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.submitAPDBillboardButton = new System.Windows.Forms.Button();
            this.RAPDItem2 = new System.Windows.Forms.ComboBox();
            this.RAPDItem4 = new System.Windows.Forms.ComboBox();
            this.RAPDItem3 = new System.Windows.Forms.ComboBox();
            this.PAPDItem4 = new System.Windows.Forms.ComboBox();
            this.PAPDItem3 = new System.Windows.Forms.ComboBox();
            this.PAPDItem2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.apdListBox = new NishBox.MultiLineListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Kebutuhan dan stok APD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(588, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Listing APD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PersonName
            // 
            this.PersonName.Location = new System.Drawing.Point(593, 89);
            this.PersonName.Name = "PersonName";
            this.PersonName.Size = new System.Drawing.Size(361, 33);
            this.PersonName.TabIndex = 2;
            this.PersonName.TextChanged += new System.EventHandler(this.PersonName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(589, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(589, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alamat";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PersonAddress
            // 
            this.PersonAddress.AcceptsTab = true;
            this.PersonAddress.Location = new System.Drawing.Point(593, 155);
            this.PersonAddress.Name = "PersonAddress";
            this.PersonAddress.Size = new System.Drawing.Size(361, 33);
            this.PersonAddress.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(589, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // PersonEmail
            // 
            this.PersonEmail.AcceptsTab = true;
            this.PersonEmail.Location = new System.Drawing.Point(593, 286);
            this.PersonEmail.Name = "PersonEmail";
            this.PersonEmail.Size = new System.Drawing.Size(361, 33);
            this.PersonEmail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(589, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nomor Telepon / HP";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // PersonPhoneNumber
            // 
            this.PersonPhoneNumber.AcceptsTab = true;
            this.PersonPhoneNumber.Location = new System.Drawing.Point(593, 220);
            this.PersonPhoneNumber.Name = "PersonPhoneNumber";
            this.PersonPhoneNumber.Size = new System.Drawing.Size(361, 33);
            this.PersonPhoneNumber.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(589, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "APD yang dibutuhkan";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // RAPDItem1
            // 
            this.RAPDItem1.FormattingEnabled = true;
            this.RAPDItem1.Location = new System.Drawing.Point(593, 376);
            this.RAPDItem1.Name = "RAPDItem1";
            this.RAPDItem1.Size = new System.Drawing.Size(258, 33);
            this.RAPDItem1.TabIndex = 5;
            this.RAPDItem1.SelectedIndexChanged += new System.EventHandler(this.RAPDItem1_SelectedIndexChanged);
            // 
            // PAPDItem1
            // 
            this.PAPDItem1.FormattingEnabled = true;
            this.PAPDItem1.Location = new System.Drawing.Point(593, 579);
            this.PAPDItem1.Name = "PAPDItem1";
            this.PAPDItem1.Size = new System.Drawing.Size(258, 33);
            this.PAPDItem1.TabIndex = 13;
            this.PAPDItem1.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(589, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "APD yang ingin dibagikan";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // submitAPDBillboardButton
            // 
            this.submitAPDBillboardButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.submitAPDBillboardButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.submitAPDBillboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.submitAPDBillboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitAPDBillboardButton.ForeColor = System.Drawing.Color.White;
            this.submitAPDBillboardButton.Location = new System.Drawing.Point(593, 766);
            this.submitAPDBillboardButton.Name = "submitAPDBillboardButton";
            this.submitAPDBillboardButton.Size = new System.Drawing.Size(361, 70);
            this.submitAPDBillboardButton.TabIndex = 22;
            this.submitAPDBillboardButton.Text = "Submit";
            this.submitAPDBillboardButton.UseVisualStyleBackColor = false;
            this.submitAPDBillboardButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RAPDItem2
            // 
            this.RAPDItem2.FormattingEnabled = true;
            this.RAPDItem2.Location = new System.Drawing.Point(593, 416);
            this.RAPDItem2.Name = "RAPDItem2";
            this.RAPDItem2.Size = new System.Drawing.Size(258, 33);
            this.RAPDItem2.TabIndex = 7;
            // 
            // RAPDItem4
            // 
            this.RAPDItem4.FormattingEnabled = true;
            this.RAPDItem4.Location = new System.Drawing.Point(593, 495);
            this.RAPDItem4.Name = "RAPDItem4";
            this.RAPDItem4.Size = new System.Drawing.Size(258, 33);
            this.RAPDItem4.TabIndex = 11;
            // 
            // RAPDItem3
            // 
            this.RAPDItem3.FormattingEnabled = true;
            this.RAPDItem3.Location = new System.Drawing.Point(593, 455);
            this.RAPDItem3.Name = "RAPDItem3";
            this.RAPDItem3.Size = new System.Drawing.Size(258, 33);
            this.RAPDItem3.TabIndex = 9;
            // 
            // PAPDItem4
            // 
            this.PAPDItem4.FormattingEnabled = true;
            this.PAPDItem4.Location = new System.Drawing.Point(593, 697);
            this.PAPDItem4.Name = "PAPDItem4";
            this.PAPDItem4.Size = new System.Drawing.Size(258, 33);
            this.PAPDItem4.TabIndex = 20;
            this.PAPDItem4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // PAPDItem3
            // 
            this.PAPDItem3.FormattingEnabled = true;
            this.PAPDItem3.Location = new System.Drawing.Point(593, 657);
            this.PAPDItem3.Name = "PAPDItem3";
            this.PAPDItem3.Size = new System.Drawing.Size(258, 33);
            this.PAPDItem3.TabIndex = 18;
            this.PAPDItem3.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // PAPDItem2
            // 
            this.PAPDItem2.FormattingEnabled = true;
            this.PAPDItem2.Location = new System.Drawing.Point(593, 618);
            this.PAPDItem2.Name = "PAPDItem2";
            this.PAPDItem2.Size = new System.Drawing.Size(258, 33);
            this.PAPDItem2.TabIndex = 15;
            this.PAPDItem2.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(857, 376);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(97, 33);
            this.numericUpDown1.TabIndex = 23;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(857, 417);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(97, 33);
            this.numericUpDown2.TabIndex = 24;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(857, 456);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(97, 33);
            this.numericUpDown3.TabIndex = 25;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(857, 495);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(97, 33);
            this.numericUpDown4.TabIndex = 26;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(857, 580);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(97, 33);
            this.numericUpDown5.TabIndex = 27;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(857, 618);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(97, 33);
            this.numericUpDown6.TabIndex = 28;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(857, 657);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(97, 33);
            this.numericUpDown7.TabIndex = 29;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(857, 698);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(97, 33);
            this.numericUpDown8.TabIndex = 30;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // apdListBox
            // 
            this.apdListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.apdListBox.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apdListBox.FormattingEnabled = true;
            this.apdListBox.Location = new System.Drawing.Point(29, 77);
            this.apdListBox.Name = "apdListBox";
            this.apdListBox.ScrollAlwaysVisible = true;
            this.apdListBox.Size = new System.Drawing.Size(536, 759);
            this.apdListBox.TabIndex = 31;
            // 
            // APDListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 858);
            this.Controls.Add(this.apdListBox);
            this.Controls.Add(this.numericUpDown8);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.PAPDItem4);
            this.Controls.Add(this.PAPDItem3);
            this.Controls.Add(this.PAPDItem2);
            this.Controls.Add(this.RAPDItem4);
            this.Controls.Add(this.RAPDItem3);
            this.Controls.Add(this.RAPDItem2);
            this.Controls.Add(this.submitAPDBillboardButton);
            this.Controls.Add(this.PAPDItem1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RAPDItem1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PersonEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PersonPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PersonAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PersonName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "APDListing";
            this.Text = "APD Request Billboard";
            this.Load += new System.EventHandler(this.APDListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PersonName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PersonAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PersonEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PersonPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox RAPDItem1;
        private System.Windows.Forms.ComboBox PAPDItem1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button submitAPDBillboardButton;
        private System.Windows.Forms.ComboBox RAPDItem2;
        private System.Windows.Forms.ComboBox RAPDItem4;
        private System.Windows.Forms.ComboBox RAPDItem3;
        private System.Windows.Forms.ComboBox PAPDItem4;
        private System.Windows.Forms.ComboBox PAPDItem3;
        private System.Windows.Forms.ComboBox PAPDItem2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private NishBox.MultiLineListBox apdListBox;
    }
}

