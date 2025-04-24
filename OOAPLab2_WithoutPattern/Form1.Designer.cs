namespace OOAPLab2_WithPattern
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNewFight = new System.Windows.Forms.Button();
            this.buttonAddHero = new System.Windows.Forms.Button();
            this.checkBoxAgile = new System.Windows.Forms.CheckBox();
            this.checkBoxIntel = new System.Windows.Forms.CheckBox();
            this.checkBoxPower = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFirstHero = new System.Windows.Forms.Label();
            this.labelSecondHero = new System.Windows.Forms.Label();
            this.labelWon = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buttonNewFight);
            this.panel1.Controls.Add(this.buttonAddHero);
            this.panel1.Controls.Add(this.checkBoxAgile);
            this.panel1.Controls.Add(this.checkBoxIntel);
            this.panel1.Controls.Add(this.checkBoxPower);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelType);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 2295);
            this.panel1.TabIndex = 0;
            // 
            // buttonNewFight
            // 
            this.buttonNewFight.BackColor = System.Drawing.SystemColors.Info;
            this.buttonNewFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewFight.Location = new System.Drawing.Point(134, 370);
            this.buttonNewFight.Name = "buttonNewFight";
            this.buttonNewFight.Size = new System.Drawing.Size(207, 32);
            this.buttonNewFight.TabIndex = 7;
            this.buttonNewFight.Text = "Начать новый бой";
            this.buttonNewFight.UseVisualStyleBackColor = false;
            this.buttonNewFight.Visible = false;
            this.buttonNewFight.Click += new System.EventHandler(this.createNewFight);
            // 
            // buttonAddHero
            // 
            this.buttonAddHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddHero.Location = new System.Drawing.Point(30, 295);
            this.buttonAddHero.Name = "buttonAddHero";
            this.buttonAddHero.Size = new System.Drawing.Size(417, 41);
            this.buttonAddHero.TabIndex = 6;
            this.buttonAddHero.Text = "Добавить героя";
            this.buttonAddHero.UseVisualStyleBackColor = true;
            this.buttonAddHero.Click += new System.EventHandler(this.AddHero);
            // 
            // checkBoxAgile
            // 
            this.checkBoxAgile.AutoSize = true;
            this.checkBoxAgile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAgile.Location = new System.Drawing.Point(30, 195);
            this.checkBoxAgile.Name = "checkBoxAgile";
            this.checkBoxAgile.Size = new System.Drawing.Size(139, 22);
            this.checkBoxAgile.TabIndex = 5;
            this.checkBoxAgile.Text = "супер ловкость";
            this.checkBoxAgile.UseVisualStyleBackColor = true;
            // 
            // checkBoxIntel
            // 
            this.checkBoxIntel.AutoSize = true;
            this.checkBoxIntel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIntel.Location = new System.Drawing.Point(30, 235);
            this.checkBoxIntel.Name = "checkBoxIntel";
            this.checkBoxIntel.Size = new System.Drawing.Size(145, 22);
            this.checkBoxIntel.TabIndex = 4;
            this.checkBoxIntel.Text = "супер интеллект";
            this.checkBoxIntel.UseVisualStyleBackColor = true;
            // 
            // checkBoxPower
            // 
            this.checkBoxPower.AutoSize = true;
            this.checkBoxPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPower.Location = new System.Drawing.Point(30, 154);
            this.checkBoxPower.Name = "checkBoxPower";
            this.checkBoxPower.Size = new System.Drawing.Size(106, 22);
            this.checkBoxPower.TabIndex = 3;
            this.checkBoxPower.Text = "супер сила";
            this.checkBoxPower.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите доп. возможности";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelType.Location = new System.Drawing.Point(26, 51);
            this.labelType.Margin = new System.Windows.Forms.Padding(0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(181, 20);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Выберите тип героя";
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Красный",
            "Зеленый"});
            this.comboBoxType.Location = new System.Drawing.Point(264, 45);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(183, 26);
            this.comboBoxType.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 61);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(331, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "СОРЕВНОВАНИЕ";
            // 
            // labelFirstHero
            // 
            this.labelFirstHero.AutoSize = true;
            this.labelFirstHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstHero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFirstHero.Location = new System.Drawing.Point(489, 74);
            this.labelFirstHero.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelFirstHero.Name = "labelFirstHero";
            this.labelFirstHero.Size = new System.Drawing.Size(0, 18);
            this.labelFirstHero.TabIndex = 7;
            // 
            // labelSecondHero
            // 
            this.labelSecondHero.AutoSize = true;
            this.labelSecondHero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSecondHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondHero.Location = new System.Drawing.Point(489, 233);
            this.labelSecondHero.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelSecondHero.Name = "labelSecondHero";
            this.labelSecondHero.Size = new System.Drawing.Size(0, 18);
            this.labelSecondHero.TabIndex = 8;
            // 
            // labelWon
            // 
            this.labelWon.AutoSize = true;
            this.labelWon.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWon.ForeColor = System.Drawing.Color.Black;
            this.labelWon.Location = new System.Drawing.Point(489, 409);
            this.labelWon.MaximumSize = new System.Drawing.Size(375, 70);
            this.labelWon.Name = "labelWon";
            this.labelWon.Size = new System.Drawing.Size(0, 23);
            this.labelWon.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(910, 473);
            this.Controls.Add(this.labelWon);
            this.Controls.Add(this.labelSecondHero);
            this.Controls.Add(this.labelFirstHero);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddHero;
        private System.Windows.Forms.CheckBox checkBoxAgile;
        private System.Windows.Forms.CheckBox checkBoxIntel;
        private System.Windows.Forms.CheckBox checkBoxPower;
        private System.Windows.Forms.Label labelFirstHero;
        private System.Windows.Forms.Label labelSecondHero;
        private System.Windows.Forms.Label labelWon;
        private System.Windows.Forms.Button buttonNewFight;
    }
}

