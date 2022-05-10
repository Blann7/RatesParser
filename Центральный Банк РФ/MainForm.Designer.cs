namespace RatesParser
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.LabelForComboBox = new System.Windows.Forms.Label();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.textCurName = new System.Windows.Forms.TextBox();
            this.PictureCentralBank = new System.Windows.Forms.PictureBox();
            this.textCurNumCode = new System.Windows.Forms.TextBox();
            this.textCurCharCode = new System.Windows.Forms.TextBox();
            this.textCurNominal = new System.Windows.Forms.TextBox();
            this.textCurValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCentralBank)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(197, 20);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(230, 23);
            this.comboBoxCurrency.TabIndex = 0;
            // 
            // LabelForComboBox
            // 
            this.LabelForComboBox.AutoSize = true;
            this.LabelForComboBox.BackColor = System.Drawing.Color.Transparent;
            this.LabelForComboBox.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelForComboBox.Location = new System.Drawing.Point(27, 18);
            this.LabelForComboBox.Name = "LabelForComboBox";
            this.LabelForComboBox.Size = new System.Drawing.Size(160, 25);
            this.LabelForComboBox.TabIndex = 1;
            this.LabelForComboBox.Text = "Выбор валюты:";
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLoad.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLoad.Location = new System.Drawing.Point(27, 57);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(400, 39);
            this.ButtonLoad.TabIndex = 2;
            this.ButtonLoad.Text = "Загрузить информацию";
            this.ButtonLoad.UseVisualStyleBackColor = false;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // textCurName
            // 
            this.textCurName.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCurName.Location = new System.Drawing.Point(27, 112);
            this.textCurName.Name = "textCurName";
            this.textCurName.ReadOnly = true;
            this.textCurName.Size = new System.Drawing.Size(400, 27);
            this.textCurName.TabIndex = 3;
            this.textCurName.Visible = false;
            // 
            // PictureCentralBank
            // 
            this.PictureCentralBank.BackColor = System.Drawing.Color.Transparent;
            this.PictureCentralBank.BackgroundImage = global::Центральный_Банк_РФ.Resources.ЦБ_РФ_картинка;
            this.PictureCentralBank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureCentralBank.Location = new System.Drawing.Point(27, 145);
            this.PictureCentralBank.Name = "PictureCentralBank";
            this.PictureCentralBank.Size = new System.Drawing.Size(125, 126);
            this.PictureCentralBank.TabIndex = 4;
            this.PictureCentralBank.TabStop = false;
            this.PictureCentralBank.Visible = false;
            // 
            // textCurNumCode
            // 
            this.textCurNumCode.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCurNumCode.Location = new System.Drawing.Point(158, 145);
            this.textCurNumCode.Name = "textCurNumCode";
            this.textCurNumCode.ReadOnly = true;
            this.textCurNumCode.Size = new System.Drawing.Size(269, 27);
            this.textCurNumCode.TabIndex = 5;
            this.textCurNumCode.Visible = false;
            // 
            // textCurCharCode
            // 
            this.textCurCharCode.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCurCharCode.Location = new System.Drawing.Point(158, 178);
            this.textCurCharCode.Name = "textCurCharCode";
            this.textCurCharCode.ReadOnly = true;
            this.textCurCharCode.Size = new System.Drawing.Size(269, 27);
            this.textCurCharCode.TabIndex = 6;
            this.textCurCharCode.Visible = false;
            // 
            // textCurNominal
            // 
            this.textCurNominal.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCurNominal.Location = new System.Drawing.Point(158, 211);
            this.textCurNominal.Name = "textCurNominal";
            this.textCurNominal.ReadOnly = true;
            this.textCurNominal.Size = new System.Drawing.Size(269, 27);
            this.textCurNominal.TabIndex = 7;
            this.textCurNominal.Visible = false;
            // 
            // textCurValue
            // 
            this.textCurValue.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCurValue.Location = new System.Drawing.Point(158, 244);
            this.textCurValue.Name = "textCurValue";
            this.textCurValue.ReadOnly = true;
            this.textCurValue.Size = new System.Drawing.Size(269, 27);
            this.textCurValue.TabIndex = 8;
            this.textCurValue.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 288);
            this.Controls.Add(this.textCurValue);
            this.Controls.Add(this.textCurNominal);
            this.Controls.Add(this.textCurCharCode);
            this.Controls.Add(this.textCurNumCode);
            this.Controls.Add(this.PictureCentralBank);
            this.Controls.Add(this.textCurName);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.LabelForComboBox);
            this.Controls.Add(this.comboBoxCurrency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Центральный Банк РФ";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureCentralBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ComboBox comboBoxCurrency;
        public Label LabelForComboBox;
        private Button ButtonLoad;
        private TextBox textCurName;
        private PictureBox PictureCentralBank;
        private TextBox textCurNumCode;
        private TextBox textCurCharCode;
        private TextBox textCurNominal;
        private TextBox textCurValue;
    }
}