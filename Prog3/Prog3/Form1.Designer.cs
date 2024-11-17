namespace Prog3
{
    partial class Prog3
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.carTypeCB = new System.Windows.Forms.ComboBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.carLbl = new System.Windows.Forms.Label();
            this.downPaymentLbl = new System.Windows.Forms.Label();
            this.creditScoreLbl = new System.Windows.Forms.Label();
            this.carCB = new System.Windows.Forms.ComboBox();
            this.downPaymentInput = new System.Windows.Forms.TextBox();
            this.creditScoreInput = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.priceLbl = new System.Windows.Forms.Label();
            this.discountLbl = new System.Windows.Forms.Label();
            this.downPymtOutLbl = new System.Windows.Forms.Label();
            this.loanOfferLbl = new System.Windows.Forms.Label();
            this.grandTotalLbl = new System.Windows.Forms.Label();
            this.carPriceOutput = new System.Windows.Forms.Label();
            this.discountOutput = new System.Windows.Forms.Label();
            this.DownPaymentOutput = new System.Windows.Forms.Label();
            this.loanOutput = new System.Windows.Forms.Label();
            this.grandTotalOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 22);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(381, 43);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Clunker Sale Calculator";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carTypeCB
            // 
            this.carTypeCB.FormattingEnabled = true;
            this.carTypeCB.Items.AddRange(new object[] {
            "PreOwned",
            "Certified-PreOwned",
            "New"});
            this.carTypeCB.Location = new System.Drawing.Point(178, 99);
            this.carTypeCB.Name = "carTypeCB";
            this.carTypeCB.Size = new System.Drawing.Size(181, 28);
            this.carTypeCB.TabIndex = 1;
            // 
            // typeLbl
            // 
            this.typeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.typeLbl.Location = new System.Drawing.Point(-4, 107);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(165, 20);
            this.typeLbl.TabIndex = 2;
            this.typeLbl.Text = "Type";
            this.typeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // carLbl
            // 
            this.carLbl.Location = new System.Drawing.Point(-4, 157);
            this.carLbl.Name = "carLbl";
            this.carLbl.Size = new System.Drawing.Size(165, 20);
            this.carLbl.TabIndex = 3;
            this.carLbl.Text = "Car";
            this.carLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // downPaymentLbl
            // 
            this.downPaymentLbl.Location = new System.Drawing.Point(-4, 211);
            this.downPaymentLbl.Name = "downPaymentLbl";
            this.downPaymentLbl.Size = new System.Drawing.Size(165, 20);
            this.downPaymentLbl.TabIndex = 4;
            this.downPaymentLbl.Text = "Down Payment";
            this.downPaymentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // creditScoreLbl
            // 
            this.creditScoreLbl.Location = new System.Drawing.Point(-4, 266);
            this.creditScoreLbl.Name = "creditScoreLbl";
            this.creditScoreLbl.Size = new System.Drawing.Size(165, 20);
            this.creditScoreLbl.TabIndex = 5;
            this.creditScoreLbl.Text = "Credit Score";
            this.creditScoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // carCB
            // 
            this.carCB.FormattingEnabled = true;
            this.carCB.Items.AddRange(new object[] {
            "Chevy Volt",
            "Mclaren 720S",
            "Subaru Outback",
            "Toyota Camry",
            "Saturn Sky",
            "Ford Mustang GT",
            "Honda Civic"});
            this.carCB.Location = new System.Drawing.Point(178, 149);
            this.carCB.Name = "carCB";
            this.carCB.Size = new System.Drawing.Size(181, 28);
            this.carCB.TabIndex = 6;
            // 
            // downPaymentInput
            // 
            this.downPaymentInput.Location = new System.Drawing.Point(178, 205);
            this.downPaymentInput.Name = "downPaymentInput";
            this.downPaymentInput.Size = new System.Drawing.Size(181, 26);
            this.downPaymentInput.TabIndex = 7;
            // 
            // creditScoreInput
            // 
            this.creditScoreInput.Location = new System.Drawing.Point(178, 260);
            this.creditScoreInput.Name = "creditScoreInput";
            this.creditScoreInput.Size = new System.Drawing.Size(181, 26);
            this.creditScoreInput.TabIndex = 8;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(116, 310);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(135, 37);
            this.calculate.TabIndex = 9;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // priceLbl
            // 
            this.priceLbl.Location = new System.Drawing.Point(44, 374);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(117, 20);
            this.priceLbl.TabIndex = 10;
            this.priceLbl.Text = "Car Price:";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discountLbl
            // 
            this.discountLbl.Location = new System.Drawing.Point(49, 424);
            this.discountLbl.Name = "discountLbl";
            this.discountLbl.Size = new System.Drawing.Size(112, 20);
            this.discountLbl.TabIndex = 11;
            this.discountLbl.Text = "Discount:";
            this.discountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // downPymtOutLbl
            // 
            this.downPymtOutLbl.Location = new System.Drawing.Point(50, 479);
            this.downPymtOutLbl.Name = "downPymtOutLbl";
            this.downPymtOutLbl.Size = new System.Drawing.Size(111, 20);
            this.downPymtOutLbl.TabIndex = 12;
            this.downPymtOutLbl.Text = "Down Payment:";
            this.downPymtOutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loanOfferLbl
            // 
            this.loanOfferLbl.Location = new System.Drawing.Point(52, 534);
            this.loanOfferLbl.Name = "loanOfferLbl";
            this.loanOfferLbl.Size = new System.Drawing.Size(109, 20);
            this.loanOfferLbl.TabIndex = 13;
            this.loanOfferLbl.Text = "Loan Offered:";
            this.loanOfferLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grandTotalLbl
            // 
            this.grandTotalLbl.Location = new System.Drawing.Point(39, 585);
            this.grandTotalLbl.Name = "grandTotalLbl";
            this.grandTotalLbl.Size = new System.Drawing.Size(122, 20);
            this.grandTotalLbl.TabIndex = 14;
            this.grandTotalLbl.Text = "Total You Owe:";
            this.grandTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // carPriceOutput
            // 
            this.carPriceOutput.BackColor = System.Drawing.SystemColors.Control;
            this.carPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carPriceOutput.Location = new System.Drawing.Point(174, 374);
            this.carPriceOutput.Name = "carPriceOutput";
            this.carPriceOutput.Size = new System.Drawing.Size(120, 20);
            this.carPriceOutput.TabIndex = 15;
            this.carPriceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discountOutput
            // 
            this.discountOutput.BackColor = System.Drawing.SystemColors.Control;
            this.discountOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountOutput.Location = new System.Drawing.Point(174, 424);
            this.discountOutput.Name = "discountOutput";
            this.discountOutput.Size = new System.Drawing.Size(120, 20);
            this.discountOutput.TabIndex = 16;
            this.discountOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DownPaymentOutput
            // 
            this.DownPaymentOutput.BackColor = System.Drawing.SystemColors.Control;
            this.DownPaymentOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DownPaymentOutput.Location = new System.Drawing.Point(174, 479);
            this.DownPaymentOutput.Name = "DownPaymentOutput";
            this.DownPaymentOutput.Size = new System.Drawing.Size(120, 20);
            this.DownPaymentOutput.TabIndex = 17;
            this.DownPaymentOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loanOutput
            // 
            this.loanOutput.BackColor = System.Drawing.SystemColors.Control;
            this.loanOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loanOutput.Location = new System.Drawing.Point(174, 534);
            this.loanOutput.Name = "loanOutput";
            this.loanOutput.Size = new System.Drawing.Size(120, 20);
            this.loanOutput.TabIndex = 18;
            this.loanOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grandTotalOutput
            // 
            this.grandTotalOutput.BackColor = System.Drawing.SystemColors.Control;
            this.grandTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grandTotalOutput.Location = new System.Drawing.Point(174, 585);
            this.grandTotalOutput.Name = "grandTotalOutput";
            this.grandTotalOutput.Size = new System.Drawing.Size(120, 20);
            this.grandTotalOutput.TabIndex = 19;
            this.grandTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Prog3
            // 
            this.AcceptButton = this.calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 668);
            this.Controls.Add(this.grandTotalOutput);
            this.Controls.Add(this.loanOutput);
            this.Controls.Add(this.DownPaymentOutput);
            this.Controls.Add(this.discountOutput);
            this.Controls.Add(this.carPriceOutput);
            this.Controls.Add(this.grandTotalLbl);
            this.Controls.Add(this.loanOfferLbl);
            this.Controls.Add(this.downPymtOutLbl);
            this.Controls.Add(this.discountLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.creditScoreInput);
            this.Controls.Add(this.downPaymentInput);
            this.Controls.Add(this.carCB);
            this.Controls.Add(this.creditScoreLbl);
            this.Controls.Add(this.downPaymentLbl);
            this.Controls.Add(this.carLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.carTypeCB);
            this.Controls.Add(this.titleLbl);
            this.Name = "Prog3";
            this.Text = "Car Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.ComboBox carTypeCB;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label carLbl;
        private System.Windows.Forms.Label downPaymentLbl;
        private System.Windows.Forms.Label creditScoreLbl;
        private System.Windows.Forms.ComboBox carCB;
        private System.Windows.Forms.TextBox downPaymentInput;
        private System.Windows.Forms.TextBox creditScoreInput;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label discountLbl;
        private System.Windows.Forms.Label downPymtOutLbl;
        private System.Windows.Forms.Label loanOfferLbl;
        private System.Windows.Forms.Label grandTotalLbl;
        private System.Windows.Forms.Label carPriceOutput;
        private System.Windows.Forms.Label discountOutput;
        private System.Windows.Forms.Label DownPaymentOutput;
        private System.Windows.Forms.Label loanOutput;
        private System.Windows.Forms.Label grandTotalOutput;
    }
}

