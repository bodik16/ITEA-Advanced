namespace HomeTask2GenericCollections
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
            this.button1 = new System.Windows.Forms.Button();
            this.ProductscheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.AddProductName = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.AddProductPrice = new System.Windows.Forms.NumericUpDown();
            this.AddProductEx = new System.Windows.Forms.NumericUpDown();
            this.AddProductFrom = new System.Windows.Forms.ComboBox();
            this.MeatcheckBox = new System.Windows.Forms.CheckBox();
            this.MilkcheckBox = new System.Windows.Forms.CheckBox();
            this.BakingcheckBox = new System.Windows.Forms.CheckBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.MassValue = new System.Windows.Forms.NumericUpDown();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductDateOfManufactureLabel = new System.Windows.Forms.Label();
            this.ProductExpirationLabel = new System.Windows.Forms.Label();
            this.ProductConditionalLabel = new System.Windows.Forms.Label();
            this.ProductMassLabel = new System.Windows.Forms.Label();
            this.NextDayButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateCounterLabel = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemsCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassValue)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Products from meat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ProductscheckedListBox
            // 
            this.ProductscheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductscheckedListBox.FormattingEnabled = true;
            this.ProductscheckedListBox.Location = new System.Drawing.Point(1058, 12);
            this.ProductscheckedListBox.Name = "ProductscheckedListBox";
            this.ProductscheckedListBox.Size = new System.Drawing.Size(193, 582);
            this.ProductscheckedListBox.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Products from milk\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Baking";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add product";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(223, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "Show All";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 305);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(223, 65);
            this.button6.TabIndex = 6;
            this.button6.Text = "All in one List";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // AddProductName
            // 
            this.AddProductName.Location = new System.Drawing.Point(784, 22);
            this.AddProductName.Name = "AddProductName";
            this.AddProductName.Size = new System.Drawing.Size(100, 22);
            this.AddProductName.TabIndex = 7;
            this.AddProductName.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(784, 85);
            this.monthCalendar1.MaxDate = new System.DateTime(2019, 11, 30, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2019, 10, 14, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.Visible = false;
            // 
            // AddProductPrice
            // 
            this.AddProductPrice.Location = new System.Drawing.Point(784, 51);
            this.AddProductPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AddProductPrice.Name = "AddProductPrice";
            this.AddProductPrice.Size = new System.Drawing.Size(100, 22);
            this.AddProductPrice.TabIndex = 11;
            this.AddProductPrice.Visible = false;
            // 
            // AddProductEx
            // 
            this.AddProductEx.Location = new System.Drawing.Point(784, 297);
            this.AddProductEx.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.AddProductEx.Name = "AddProductEx";
            this.AddProductEx.Size = new System.Drawing.Size(100, 22);
            this.AddProductEx.TabIndex = 12;
            this.AddProductEx.Visible = false;
            // 
            // AddProductFrom
            // 
            this.AddProductFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductFrom.Location = new System.Drawing.Point(784, 327);
            this.AddProductFrom.Name = "AddProductFrom";
            this.AddProductFrom.Size = new System.Drawing.Size(100, 24);
            this.AddProductFrom.TabIndex = 14;
            this.AddProductFrom.Visible = false;
            // 
            // MeatcheckBox
            // 
            this.MeatcheckBox.AutoSize = true;
            this.MeatcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeatcheckBox.Location = new System.Drawing.Point(566, 72);
            this.MeatcheckBox.Name = "MeatcheckBox";
            this.MeatcheckBox.Size = new System.Drawing.Size(61, 21);
            this.MeatcheckBox.TabIndex = 15;
            this.MeatcheckBox.Text = "Meat";
            this.MeatcheckBox.UseVisualStyleBackColor = true;
            this.MeatcheckBox.Visible = false;
            this.MeatcheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // MilkcheckBox
            // 
            this.MilkcheckBox.AutoSize = true;
            this.MilkcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilkcheckBox.Location = new System.Drawing.Point(566, 101);
            this.MilkcheckBox.Name = "MilkcheckBox";
            this.MilkcheckBox.Size = new System.Drawing.Size(54, 21);
            this.MilkcheckBox.TabIndex = 16;
            this.MilkcheckBox.Text = "Milk";
            this.MilkcheckBox.UseVisualStyleBackColor = true;
            this.MilkcheckBox.Visible = false;
            this.MilkcheckBox.CheckedChanged += new System.EventHandler(this.MilkcheckBox_CheckedChanged);
            // 
            // BakingcheckBox
            // 
            this.BakingcheckBox.AutoSize = true;
            this.BakingcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BakingcheckBox.Location = new System.Drawing.Point(566, 129);
            this.BakingcheckBox.Name = "BakingcheckBox";
            this.BakingcheckBox.Size = new System.Drawing.Size(73, 21);
            this.BakingcheckBox.TabIndex = 17;
            this.BakingcheckBox.Text = "Baking";
            this.BakingcheckBox.UseVisualStyleBackColor = true;
            this.BakingcheckBox.Visible = false;
            this.BakingcheckBox.CheckedChanged += new System.EventHandler(this.BakingcheckBox_CheckedChanged);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddProductButton.Location = new System.Drawing.Point(784, 385);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(262, 63);
            this.AddProductButton.TabIndex = 18;
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // MassValue
            // 
            this.MassValue.Location = new System.Drawing.Point(784, 357);
            this.MassValue.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.MassValue.Name = "MassValue";
            this.MassValue.Size = new System.Drawing.Size(100, 22);
            this.MassValue.TabIndex = 19;
            this.MassValue.Visible = false;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(666, 22);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(98, 17);
            this.ProductNameLabel.TabIndex = 20;
            this.ProductNameLabel.Text = "Product Name";
            this.ProductNameLabel.Visible = false;
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPriceLabel.Location = new System.Drawing.Point(666, 53);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(93, 17);
            this.ProductPriceLabel.TabIndex = 21;
            this.ProductPriceLabel.Text = "Product Price";
            this.ProductPriceLabel.Visible = false;
            // 
            // ProductDateOfManufactureLabel
            // 
            this.ProductDateOfManufactureLabel.AutoSize = true;
            this.ProductDateOfManufactureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDateOfManufactureLabel.Location = new System.Drawing.Point(638, 183);
            this.ProductDateOfManufactureLabel.Name = "ProductDateOfManufactureLabel";
            this.ProductDateOfManufactureLabel.Size = new System.Drawing.Size(121, 17);
            this.ProductDateOfManufactureLabel.TabIndex = 22;
            this.ProductDateOfManufactureLabel.Text = "To Consume untill";
            this.ProductDateOfManufactureLabel.Visible = false;
            // 
            // ProductExpirationLabel
            // 
            this.ProductExpirationLabel.AutoSize = true;
            this.ProductExpirationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductExpirationLabel.Location = new System.Drawing.Point(610, 299);
            this.ProductExpirationLabel.Name = "ProductExpirationLabel";
            this.ProductExpirationLabel.Size = new System.Drawing.Size(155, 17);
            this.ProductExpirationLabel.TabIndex = 23;
            this.ProductExpirationLabel.Text = "Expiration date by days";
            this.ProductExpirationLabel.Visible = false;
            // 
            // ProductConditionalLabel
            // 
            this.ProductConditionalLabel.AutoSize = true;
            this.ProductConditionalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductConditionalLabel.Location = new System.Drawing.Point(610, 334);
            this.ProductConditionalLabel.Name = "ProductConditionalLabel";
            this.ProductConditionalLabel.Size = new System.Drawing.Size(78, 17);
            this.ProductConditionalLabel.TabIndex = 24;
            this.ProductConditionalLabel.Text = "Conditional";
            this.ProductConditionalLabel.Visible = false;
            // 
            // ProductMassLabel
            // 
            this.ProductMassLabel.AutoSize = true;
            this.ProductMassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductMassLabel.Location = new System.Drawing.Point(690, 362);
            this.ProductMassLabel.Name = "ProductMassLabel";
            this.ProductMassLabel.Size = new System.Drawing.Size(69, 17);
            this.ProductMassLabel.TabIndex = 25;
            this.ProductMassLabel.Text = "Milk mass";
            this.ProductMassLabel.Visible = false;
            // 
            // NextDayButton
            // 
            this.NextDayButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NextDayButton.Font = new System.Drawing.Font("Road Rage", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextDayButton.Location = new System.Drawing.Point(12, 385);
            this.NextDayButton.Name = "NextDayButton";
            this.NextDayButton.Size = new System.Drawing.Size(224, 104);
            this.NextDayButton.TabIndex = 26;
            this.NextDayButton.Text = "Next Day";
            this.NextDayButton.UseVisualStyleBackColor = false;
            this.NextDayButton.Click += new System.EventHandler(this.NextDayButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(709, 487);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(343, 107);
            this.DateLabel.TabIndex = 27;
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DateLabel_MouseClick);
            this.DateLabel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DateLabel_MouseDoubleClick);
            // 
            // DateCounterLabel
            // 
            this.DateCounterLabel.AutoSize = true;
            this.DateCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCounterLabel.Location = new System.Drawing.Point(963, 487);
            this.DateCounterLabel.Name = "DateCounterLabel";
            this.DateCounterLabel.Size = new System.Drawing.Size(83, 32);
            this.DateCounterLabel.TabIndex = 28;
            this.DateCounterLabel.Text = "Date:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(242, 394);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(461, 208);
            this.checkedListBox1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(308, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Products which tomorrow will be delay";
            // 
            // ItemsCounter
            // 
            this.ItemsCounter.BackColor = System.Drawing.Color.Lime;
            this.ItemsCounter.Location = new System.Drawing.Point(891, 13);
            this.ItemsCounter.Name = "ItemsCounter";
            this.ItemsCounter.Size = new System.Drawing.Size(155, 63);
            this.ItemsCounter.TabIndex = 31;
            this.ItemsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 614);
            this.Controls.Add(this.ItemsCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.DateCounterLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.NextDayButton);
            this.Controls.Add(this.ProductMassLabel);
            this.Controls.Add(this.ProductConditionalLabel);
            this.Controls.Add(this.ProductExpirationLabel);
            this.Controls.Add(this.ProductDateOfManufactureLabel);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.MassValue);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.BakingcheckBox);
            this.Controls.Add(this.MilkcheckBox);
            this.Controls.Add(this.MeatcheckBox);
            this.Controls.Add(this.AddProductFrom);
            this.Controls.Add(this.AddProductEx);
            this.Controls.Add(this.AddProductPrice);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.AddProductName);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProductscheckedListBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox ProductscheckedListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox AddProductName;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NumericUpDown AddProductPrice;
        private System.Windows.Forms.NumericUpDown AddProductEx;
        private System.Windows.Forms.ComboBox AddProductFrom;
        private System.Windows.Forms.CheckBox MeatcheckBox;
        private System.Windows.Forms.CheckBox MilkcheckBox;
        private System.Windows.Forms.CheckBox BakingcheckBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.NumericUpDown MassValue;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.Label ProductDateOfManufactureLabel;
        private System.Windows.Forms.Label ProductExpirationLabel;
        private System.Windows.Forms.Label ProductConditionalLabel;
        private System.Windows.Forms.Label ProductMassLabel;
        private System.Windows.Forms.Button NextDayButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DateCounterLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ItemsCounter;
    }
}

