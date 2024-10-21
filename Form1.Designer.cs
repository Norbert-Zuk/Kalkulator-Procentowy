namespace Kalkulator_Procentowy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxAlcohol = new System.Windows.Forms.ComboBox();
            this.labelAlcohol = new System.Windows.Forms.Label();
            this.comboBoxCapacity = new System.Windows.Forms.ComboBox();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelResultText = new System.Windows.Forms.Label();
            this.labelResultText2 = new System.Windows.Forms.Label();
            this.labelAmountResult = new System.Windows.Forms.Label();
            this.labelAlcoholResult = new System.Windows.Forms.Label();
            this.labelBeerImagine = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitle.Location = new System.Drawing.Point(3, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(473, 54);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Kalkulator ALKOHOLOWY";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxAlcohol
            // 
            this.comboBoxAlcohol.FormattingEnabled = true;
            this.comboBoxAlcohol.Location = new System.Drawing.Point(410, 143);
            this.comboBoxAlcohol.Name = "comboBoxAlcohol";
            this.comboBoxAlcohol.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlcohol.TabIndex = 1;
            this.comboBoxAlcohol.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlcohol_SelectedIndexChanged);
            // 
            // labelAlcohol
            // 
            this.labelAlcohol.AutoSize = true;
            this.labelAlcohol.BackColor = System.Drawing.Color.Silver;
            this.labelAlcohol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAlcohol.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAlcohol.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAlcohol.Location = new System.Drawing.Point(12, 108);
            this.labelAlcohol.Name = "labelAlcohol";
            this.labelAlcohol.Size = new System.Drawing.Size(334, 58);
            this.labelAlcohol.TabIndex = 2;
            this.labelAlcohol.Text = "Wybierz zawartość procentową\r\nalkoholu (Lub skorzystaj z gotowca)\r\n";
            this.labelAlcohol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAlcohol.Click += new System.EventHandler(this.labelAlcohol_Click);
            // 
            // comboBoxCapacity
            // 
            this.comboBoxCapacity.FormattingEnabled = true;
            this.comboBoxCapacity.Location = new System.Drawing.Point(410, 223);
            this.comboBoxCapacity.Name = "comboBoxCapacity";
            this.comboBoxCapacity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCapacity.TabIndex = 4;
            this.comboBoxCapacity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCapacity_SelectedIndexChanged);
            // 
            // labelCapacity
            // 
            this.labelCapacity.BackColor = System.Drawing.Color.Silver;
            this.labelCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCapacity.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCapacity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCapacity.Location = new System.Drawing.Point(12, 186);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(334, 58);
            this.labelCapacity.TabIndex = 7;
            this.labelCapacity.Text = "Wybierz pojemnośc naczynia \r\n (Lub skorzystaj z gotowca)\r\n";
            this.labelCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCapacity.Click += new System.EventHandler(this.labelCapacity_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.BackColor = System.Drawing.Color.Silver;
            this.labelAmount.Font = new System.Drawing.Font("Sitka Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAmount.Location = new System.Drawing.Point(12, 264);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(334, 58);
            this.labelAmount.TabIndex = 8;
            this.labelAmount.Text = "Wybierz ilość naczyń\r\n";
            this.labelAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAmount.Click += new System.EventHandler(this.labelAmount_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonConfirm.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConfirm.Location = new System.Drawing.Point(49, 345);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(482, 52);
            this.buttonConfirm.TabIndex = 9;
            this.buttonConfirm.Text = "ZATWIERDZ";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelResultText
            // 
            this.labelResultText.AutoSize = true;
            this.labelResultText.BackColor = System.Drawing.Color.Silver;
            this.labelResultText.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResultText.Location = new System.Drawing.Point(12, 421);
            this.labelResultText.Name = "labelResultText";
            this.labelResultText.Size = new System.Drawing.Size(387, 35);
            this.labelResultText.TabIndex = 10;
            this.labelResultText.Text = "Objętość twojego napoju wynosi:";
            this.labelResultText.Click += new System.EventHandler(this.labelResultText_Click);
            // 
            // labelResultText2
            // 
            this.labelResultText2.BackColor = System.Drawing.Color.Silver;
            this.labelResultText2.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResultText2.Location = new System.Drawing.Point(12, 477);
            this.labelResultText2.Name = "labelResultText2";
            this.labelResultText2.Size = new System.Drawing.Size(387, 35);
            this.labelResultText2.TabIndex = 11;
            this.labelResultText2.Text = "Objętość spirytusu wynosi:";
            this.labelResultText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResultText2.Click += new System.EventHandler(this.labelResultText2_Click);
            // 
            // labelAmountResult
            // 
            this.labelAmountResult.BackColor = System.Drawing.Color.White;
            this.labelAmountResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAmountResult.Location = new System.Drawing.Point(456, 477);
            this.labelAmountResult.Name = "labelAmountResult";
            this.labelAmountResult.Size = new System.Drawing.Size(75, 35);
            this.labelAmountResult.TabIndex = 13;
            this.labelAmountResult.Click += new System.EventHandler(this.labelAmountResult_Click);
            // 
            // labelAlcoholResult
            // 
            this.labelAlcoholResult.BackColor = System.Drawing.Color.White;
            this.labelAlcoholResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAlcoholResult.Location = new System.Drawing.Point(456, 421);
            this.labelAlcoholResult.Name = "labelAlcoholResult";
            this.labelAlcoholResult.Size = new System.Drawing.Size(75, 35);
            this.labelAlcoholResult.TabIndex = 15;
            this.labelAlcoholResult.Click += new System.EventHandler(this.labelAlcoholResult_Click);
            // 
            // labelBeerImagine
            // 
            this.labelBeerImagine.Image = global::Kalkulator_Procentowy.Properties.Resources.beer;
            this.labelBeerImagine.Location = new System.Drawing.Point(485, 21);
            this.labelBeerImagine.Name = "labelBeerImagine";
            this.labelBeerImagine.Size = new System.Drawing.Size(75, 106);
            this.labelBeerImagine.TabIndex = 14;
            this.labelBeerImagine.Click += new System.EventHandler(this.labelBeerImagine_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(410, 301);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(121, 20);
            this.textBoxAmount.TabIndex = 16;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAlcoholResult);
            this.Controls.Add(this.labelBeerImagine);
            this.Controls.Add(this.labelAmountResult);
            this.Controls.Add(this.labelResultText2);
            this.Controls.Add(this.labelResultText);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.comboBoxCapacity);
            this.Controls.Add(this.labelAlcohol);
            this.Controls.Add(this.comboBoxAlcohol);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator Procentowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxAlcohol;
        private System.Windows.Forms.Label labelAlcohol;
        private System.Windows.Forms.ComboBox comboBoxCapacity;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelResultText;
        private System.Windows.Forms.Label labelResultText2;
        private System.Windows.Forms.Label labelAmountResult;
        private System.Windows.Forms.Label labelBeerImagine;
        private System.Windows.Forms.Label labelAlcoholResult;
        private System.Windows.Forms.TextBox textBoxAmount;
    }
}

