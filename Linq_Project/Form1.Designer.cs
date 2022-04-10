
namespace Linq_Project
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
            this.btnAllNumbers = new System.Windows.Forms.Button();
            this.lstView = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNegatif = new System.Windows.Forms.Button();
            this.btnPositiveNumbers = new System.Windows.Forms.Button();
            this.btnEvenNumber = new System.Windows.Forms.Button();
            this.btnOddNumber = new System.Windows.Forms.Button();
            this.btnMaxNumber = new System.Windows.Forms.Button();
            this.btnMinNumber = new System.Windows.Forms.Button();
            this.btnHmn = new System.Windows.Forms.Button();
            this.btnAlfbatik = new System.Windows.Forms.Button();
            this.btnLenght = new System.Windows.Forms.Button();
            this.btnContain = new System.Windows.Forms.Button();
            this.btnStartWith = new System.Windows.Forms.Button();
            this.btnAllOrders = new System.Windows.Forms.Button();
            this.btnOrderDates = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFinPerson = new System.Windows.Forms.Button();
            this.btnOrderNumber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllNumbers
            // 
            this.btnAllNumbers.Location = new System.Drawing.Point(12, 12);
            this.btnAllNumbers.Name = "btnAllNumbers";
            this.btnAllNumbers.Size = new System.Drawing.Size(101, 47);
            this.btnAllNumbers.TabIndex = 0;
            this.btnAllNumbers.Text = "AllNumbers";
            this.btnAllNumbers.UseVisualStyleBackColor = true;
            this.btnAllNumbers.Click += new System.EventHandler(this.btnAllNumbers_Click);
            // 
            // lstView
            // 
            this.lstView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstView.FormattingEnabled = true;
            this.lstView.ItemHeight = 18;
            this.lstView.Location = new System.Drawing.Point(12, 179);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(166, 328);
            this.lstView.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(184, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 329);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnNegatif
            // 
            this.btnNegatif.Location = new System.Drawing.Point(187, 12);
            this.btnNegatif.Name = "btnNegatif";
            this.btnNegatif.Size = new System.Drawing.Size(73, 47);
            this.btnNegatif.TabIndex = 3;
            this.btnNegatif.Text = "Negatif Numbers";
            this.btnNegatif.UseVisualStyleBackColor = true;
            this.btnNegatif.Click += new System.EventHandler(this.btnNegatif_Click);
            // 
            // btnPositiveNumbers
            // 
            this.btnPositiveNumbers.Location = new System.Drawing.Point(266, 12);
            this.btnPositiveNumbers.Name = "btnPositiveNumbers";
            this.btnPositiveNumbers.Size = new System.Drawing.Size(73, 47);
            this.btnPositiveNumbers.TabIndex = 4;
            this.btnPositiveNumbers.Text = "Postivie Numbers";
            this.btnPositiveNumbers.UseVisualStyleBackColor = true;
            this.btnPositiveNumbers.Click += new System.EventHandler(this.btnPositiveNumbers_Click);
            // 
            // btnEvenNumber
            // 
            this.btnEvenNumber.Location = new System.Drawing.Point(345, 12);
            this.btnEvenNumber.Name = "btnEvenNumber";
            this.btnEvenNumber.Size = new System.Drawing.Size(73, 47);
            this.btnEvenNumber.TabIndex = 5;
            this.btnEvenNumber.Text = "Even Numbers";
            this.btnEvenNumber.UseVisualStyleBackColor = true;
            this.btnEvenNumber.Click += new System.EventHandler(this.btnEvenNumber_Click);
            // 
            // btnOddNumber
            // 
            this.btnOddNumber.Location = new System.Drawing.Point(424, 12);
            this.btnOddNumber.Name = "btnOddNumber";
            this.btnOddNumber.Size = new System.Drawing.Size(73, 47);
            this.btnOddNumber.TabIndex = 6;
            this.btnOddNumber.Text = "Odd Numbers";
            this.btnOddNumber.UseVisualStyleBackColor = true;
            this.btnOddNumber.Click += new System.EventHandler(this.btnOddNumber_Click);
            // 
            // btnMaxNumber
            // 
            this.btnMaxNumber.Location = new System.Drawing.Point(503, 12);
            this.btnMaxNumber.Name = "btnMaxNumber";
            this.btnMaxNumber.Size = new System.Drawing.Size(73, 47);
            this.btnMaxNumber.TabIndex = 7;
            this.btnMaxNumber.Text = "Max Number";
            this.btnMaxNumber.UseVisualStyleBackColor = true;
            this.btnMaxNumber.Click += new System.EventHandler(this.btnMaxNumber_Click);
            // 
            // btnMinNumber
            // 
            this.btnMinNumber.Location = new System.Drawing.Point(582, 12);
            this.btnMinNumber.Name = "btnMinNumber";
            this.btnMinNumber.Size = new System.Drawing.Size(73, 47);
            this.btnMinNumber.TabIndex = 8;
            this.btnMinNumber.Text = "Min Number";
            this.btnMinNumber.UseVisualStyleBackColor = true;
            this.btnMinNumber.Click += new System.EventHandler(this.btnMinNumber_Click);
            // 
            // btnHmn
            // 
            this.btnHmn.Location = new System.Drawing.Point(661, 12);
            this.btnHmn.Name = "btnHmn";
            this.btnHmn.Size = new System.Drawing.Size(73, 47);
            this.btnHmn.TabIndex = 9;
            this.btnHmn.Text = "How mnay number ?";
            this.btnHmn.UseVisualStyleBackColor = true;
            this.btnHmn.Click += new System.EventHandler(this.btnHmn_Click);
            // 
            // btnAlfbatik
            // 
            this.btnAlfbatik.Location = new System.Drawing.Point(187, 74);
            this.btnAlfbatik.Name = "btnAlfbatik";
            this.btnAlfbatik.Size = new System.Drawing.Size(73, 47);
            this.btnAlfbatik.TabIndex = 10;
            this.btnAlfbatik.Text = "Alfbatik";
            this.btnAlfbatik.UseVisualStyleBackColor = true;
            this.btnAlfbatik.Click += new System.EventHandler(this.btnAlfbatik_Click);
            // 
            // btnLenght
            // 
            this.btnLenght.Location = new System.Drawing.Point(266, 74);
            this.btnLenght.Name = "btnLenght";
            this.btnLenght.Size = new System.Drawing.Size(73, 47);
            this.btnLenght.TabIndex = 11;
            this.btnLenght.Text = "Lenght";
            this.btnLenght.UseVisualStyleBackColor = true;
            this.btnLenght.Click += new System.EventHandler(this.btnLenght_Click);
            // 
            // btnContain
            // 
            this.btnContain.Location = new System.Drawing.Point(345, 74);
            this.btnContain.Name = "btnContain";
            this.btnContain.Size = new System.Drawing.Size(73, 47);
            this.btnContain.TabIndex = 12;
            this.btnContain.Text = "Contain";
            this.btnContain.UseVisualStyleBackColor = true;
            this.btnContain.Click += new System.EventHandler(this.btnContain_Click);
            // 
            // btnStartWith
            // 
            this.btnStartWith.Location = new System.Drawing.Point(424, 74);
            this.btnStartWith.Name = "btnStartWith";
            this.btnStartWith.Size = new System.Drawing.Size(73, 47);
            this.btnStartWith.TabIndex = 13;
            this.btnStartWith.Text = "Start With A";
            this.btnStartWith.UseVisualStyleBackColor = true;
            this.btnStartWith.Click += new System.EventHandler(this.btnStartWith_Click);
            // 
            // btnAllOrders
            // 
            this.btnAllOrders.Location = new System.Drawing.Point(187, 127);
            this.btnAllOrders.Name = "btnAllOrders";
            this.btnAllOrders.Size = new System.Drawing.Size(73, 47);
            this.btnAllOrders.TabIndex = 14;
            this.btnAllOrders.Text = "All Orders";
            this.btnAllOrders.UseVisualStyleBackColor = true;
            this.btnAllOrders.Click += new System.EventHandler(this.btnAllOrders_Click);
            // 
            // btnOrderDates
            // 
            this.btnOrderDates.Location = new System.Drawing.Point(266, 127);
            this.btnOrderDates.Name = "btnOrderDates";
            this.btnOrderDates.Size = new System.Drawing.Size(73, 47);
            this.btnOrderDates.TabIndex = 15;
            this.btnOrderDates.Text = "Order Dates";
            this.btnOrderDates.UseVisualStyleBackColor = true;
            this.btnOrderDates.Click += new System.EventHandler(this.btnOrderDates_Click);
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(345, 127);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(73, 47);
            this.btnTop.TabIndex = 16;
            this.btnTop.Text = "Top 5 ";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(424, 127);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(73, 47);
            this.btnLast.TabIndex = 17;
            this.btnLast.Text = "Last 5";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFinPerson
            // 
            this.btnFinPerson.Location = new System.Drawing.Point(503, 127);
            this.btnFinPerson.Name = "btnFinPerson";
            this.btnFinPerson.Size = new System.Drawing.Size(73, 47);
            this.btnFinPerson.TabIndex = 18;
            this.btnFinPerson.Text = "FindPerson";
            this.btnFinPerson.UseVisualStyleBackColor = true;
            this.btnFinPerson.Click += new System.EventHandler(this.btnFinPerson_Click);
            // 
            // btnOrderNumber
            // 
            this.btnOrderNumber.Location = new System.Drawing.Point(583, 127);
            this.btnOrderNumber.Name = "btnOrderNumber";
            this.btnOrderNumber.Size = new System.Drawing.Size(81, 47);
            this.btnOrderNumber.TabIndex = 19;
            this.btnOrderNumber.Text = "OrderNumber";
            this.btnOrderNumber.UseVisualStyleBackColor = true;
            this.btnOrderNumber.Click += new System.EventHandler(this.btnOrderNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 542);
            this.Controls.Add(this.btnOrderNumber);
            this.Controls.Add(this.btnFinPerson);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnOrderDates);
            this.Controls.Add(this.btnAllOrders);
            this.Controls.Add(this.btnStartWith);
            this.Controls.Add(this.btnContain);
            this.Controls.Add(this.btnLenght);
            this.Controls.Add(this.btnAlfbatik);
            this.Controls.Add(this.btnHmn);
            this.Controls.Add(this.btnMinNumber);
            this.Controls.Add(this.btnMaxNumber);
            this.Controls.Add(this.btnOddNumber);
            this.Controls.Add(this.btnEvenNumber);
            this.Controls.Add(this.btnPositiveNumbers);
            this.Controls.Add(this.btnNegatif);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.btnAllNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAllNumbers;
        private System.Windows.Forms.ListBox lstView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNegatif;
        private System.Windows.Forms.Button btnPositiveNumbers;
        private System.Windows.Forms.Button btnEvenNumber;
        private System.Windows.Forms.Button btnOddNumber;
        private System.Windows.Forms.Button btnMaxNumber;
        private System.Windows.Forms.Button btnMinNumber;
        private System.Windows.Forms.Button btnHmn;
        private System.Windows.Forms.Button btnAlfbatik;
        private System.Windows.Forms.Button btnLenght;
        private System.Windows.Forms.Button btnContain;
        private System.Windows.Forms.Button btnStartWith;
        private System.Windows.Forms.Button btnAllOrders;
        private System.Windows.Forms.Button btnOrderDates;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFinPerson;
        private System.Windows.Forms.Button btnOrderNumber;
    }
}

