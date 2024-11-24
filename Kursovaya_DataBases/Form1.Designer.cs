namespace Kursovaya_DataBases
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label18 = new Label();
            button1 = new Button();
            label13 = new Label();
            label19 = new Label();
            CoefEa = new TextBox();
            textFt = new TextBox();
            CoefVm = new TextBox();
            CountOfU = new TextBox();
            BoxWeight = new TextBox();
            textRe = new TextBox();
            textDm1 = new TextBox();
            textKhl = new TextBox();
            BoxZubie = new ComboBox();
            BoxDeltaH = new ComboBox();
            BoxZh = new ComboBox();
            BoxZm = new ComboBox();
            BoxSigma = new ComboBox();
            Boxg0 = new ComboBox();
            BoxKhb = new ComboBox();
            label9 = new Label();
            label17 = new Label();
            ResultQH = new TextBox();
            ResultQHP = new TextBox();
            textBoxResult = new TextBox();
            label20 = new Label();
            labelKha = new Label();
            BoxKha = new ComboBox();
            labelKhv = new Label();
            BoxKhv = new ComboBox();
            SaveBut = new Button();
            text_isSaved = new Label();
            LabelSE = new Label();
            UnitCodeBox = new ComboBox();
            ResultCodeUnitText = new Label();
            textBoxUnitCode = new TextBox();
            ResultCodeDetail = new Label();
            textDetailCode = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(178, 9);
            label1.Name = "label1";
            label1.Size = new Size(723, 77);
            label1.TabIndex = 0;
            label1.Text = "Проверочный расчет конической передачи на контактную выносливость рабочих поверхностей зубьев";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(482, 77);
            label2.Name = "label2";
            label2.Size = new Size(108, 26);
            label2.TabIndex = 1;
            label2.Text = "Параметры";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 238);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 2;
            label3.Text = "Передаточное число u";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Location = new Point(63, 272);
            label4.Name = "label4";
            label4.Size = new Size(259, 62);
            label4.TabIndex = 3;
            label4.Text = "Коэффициент, учитывающий форму сопряженных поверхностей зубьев Z{H}";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Location = new Point(63, 344);
            label5.Name = "label5";
            label5.Size = new Size(268, 62);
            label5.TabIndex = 4;
            label5.Text = "Коэффициент, учитывающий механические свойства материалов сопряженных колес Z{M}";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(619, 432);
            label6.Name = "label6";
            label6.Size = new Size(247, 20);
            label6.TabIndex = 5;
            label6.Text = "Коэффициент долговечности K{hl}";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 521);
            label7.Name = "label7";
            label7.Size = new Size(300, 20);
            label7.TabIndex = 6;
            label7.Text = "Коэффициент торцового перекрытия E{a}";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 563);
            label8.Name = "label8";
            label8.Size = new Size(138, 20);
            label8.TabIndex = 7;
            label8.Text = "Исходная сила F{t}";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(619, 142);
            label10.Name = "label10";
            label10.Size = new Size(129, 20);
            label10.TabIndex = 9;
            label10.Text = "Ширина ремня b";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.Location = new Point(619, 182);
            label11.Name = "label11";
            label11.Size = new Size(300, 48);
            label11.TabIndex = 10;
            label11.Text = "Коэффициент, учитывающий влияние вида зубчатой передачи delta{h}";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.Location = new Point(619, 238);
            label12.Name = "label12";
            label12.Size = new Size(268, 70);
            label12.TabIndex = 11;
            label12.Text = "Коэффициент, учитывающий влияние разности шагов зацепления шестерни и колеса g{0}";
            label12.UseWaitCursor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(63, 486);
            label14.Name = "label14";
            label14.Size = new Size(185, 20);
            label14.TabIndex = 13;
            label14.Text = "Окружная скорость V{m} ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(619, 327);
            label15.Name = "label15";
            label15.Size = new Size(246, 20);
            label15.TabIndex = 14;
            label15.Text = "Внешнее конусное расстояние Re";
            // 
            // label16
            // 
            label16.Location = new Point(619, 370);
            label16.Name = "label16";
            label16.Size = new Size(246, 45);
            label16.TabIndex = 15;
            label16.Text = "Средний делительный диаметр шестерни d{m1}";
            // 
            // label18
            // 
            label18.Location = new Point(619, 486);
            label18.Name = "label18";
            label18.Size = new Size(312, 68);
            label18.TabIndex = 17;
            label18.Text = "Коэффициент, учитывающий распределение нагрузки по ширине венца конического колеса K{hb}";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(213, 663);
            button1.Name = "button1";
            button1.Size = new Size(131, 50);
            button1.TabIndex = 18;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.Location = new Point(62, 417);
            label13.Name = "label13";
            label13.Size = new Size(282, 52);
            label13.TabIndex = 21;
            label13.Text = "Допускаемое контактное напряжение σ{HP}";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(63, 210);
            label19.Name = "label19";
            label19.Size = new Size(86, 20);
            label19.TabIndex = 22;
            label19.Text = "Тип зубьев";
            label19.Click += label19_Click;
            // 
            // CoefEa
            // 
            CoefEa.Location = new Point(377, 514);
            CoefEa.Name = "CoefEa";
            CoefEa.Size = new Size(116, 27);
            CoefEa.TabIndex = 23;
            CoefEa.TextChanged += CoefEa_TextChanged;
            // 
            // textFt
            // 
            textFt.Location = new Point(377, 556);
            textFt.Name = "textFt";
            textFt.Size = new Size(116, 27);
            textFt.TabIndex = 24;
            textFt.TextChanged += CoefFt_TextChanged;
            // 
            // CoefVm
            // 
            CoefVm.Location = new Point(377, 479);
            CoefVm.Name = "CoefVm";
            CoefVm.Size = new Size(116, 27);
            CoefVm.TabIndex = 25;
            // 
            // CountOfU
            // 
            CountOfU.Location = new Point(377, 238);
            CountOfU.Name = "CountOfU";
            CountOfU.Size = new Size(116, 27);
            CountOfU.TabIndex = 26;
            // 
            // BoxWeight
            // 
            BoxWeight.Location = new Point(937, 135);
            BoxWeight.Name = "BoxWeight";
            BoxWeight.Size = new Size(116, 27);
            BoxWeight.TabIndex = 27;
            // 
            // textRe
            // 
            textRe.Location = new Point(937, 320);
            textRe.Name = "textRe";
            textRe.Size = new Size(116, 27);
            textRe.TabIndex = 28;
            // 
            // textDm1
            // 
            textDm1.Location = new Point(937, 379);
            textDm1.Name = "textDm1";
            textDm1.Size = new Size(116, 27);
            textDm1.TabIndex = 29;
            // 
            // textKhl
            // 
            textKhl.Location = new Point(937, 432);
            textKhl.Name = "textKhl";
            textKhl.Size = new Size(116, 27);
            textKhl.TabIndex = 30;
            // 
            // BoxZubie
            // 
            BoxZubie.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxZubie.FormattingEnabled = true;
            BoxZubie.Items.AddRange(new object[] { "Прямозубые", "Конические", "Круговые", "Тангенциальные" });
            BoxZubie.Location = new Point(377, 202);
            BoxZubie.Margin = new Padding(3, 4, 3, 4);
            BoxZubie.Name = "BoxZubie";
            BoxZubie.Size = new Size(153, 28);
            BoxZubie.TabIndex = 31;
            BoxZubie.SelectedIndexChanged += typeBox_SelectedIndexChanged;
            // 
            // BoxDeltaH
            // 
            BoxDeltaH.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxDeltaH.FormattingEnabled = true;
            BoxDeltaH.Items.AddRange(new object[] { "0,006", "0,004", "0,002", "0,014", "0,01" });
            BoxDeltaH.Location = new Point(937, 190);
            BoxDeltaH.Margin = new Padding(3, 4, 3, 4);
            BoxDeltaH.Name = "BoxDeltaH";
            BoxDeltaH.Size = new Size(116, 28);
            BoxDeltaH.TabIndex = 32;
            // 
            // BoxZh
            // 
            BoxZh.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxZh.FormattingEnabled = true;
            BoxZh.Items.AddRange(new object[] { "1,48", "1,52", "1,58", "1,62", "1,68", "1,71", "1,76", "1,83", "1,93", "2,14", "0", "1,47", "1,51", "1,56", "1,6", "1,66", "1,69", "1,74", "1,8", "1,9", "2,07", "1,46", "1,5", "1,55", "1,58", "1,63", "1,67", "1,71", "1,77", "1,86", "2", "2,35", "1,43", "1,47", "1,52", "1,55", "1,6", "1,63", "1,67", "1,72" });
            BoxZh.Location = new Point(377, 290);
            BoxZh.Margin = new Padding(3, 4, 3, 4);
            BoxZh.Name = "BoxZh";
            BoxZh.Size = new Size(116, 28);
            BoxZh.TabIndex = 33;
            // 
            // BoxZm
            // 
            BoxZm.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxZm.FormattingEnabled = true;
            BoxZm.Items.AddRange(new object[] { "274", "234", "225", "209", "69,5", "35", "47,5" });
            BoxZm.Location = new Point(377, 358);
            BoxZm.Margin = new Padding(3, 4, 3, 4);
            BoxZm.Name = "BoxZm";
            BoxZm.Size = new Size(116, 28);
            BoxZm.TabIndex = 34;
            // 
            // BoxSigma
            // 
            BoxSigma.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxSigma.FormattingEnabled = true;
            BoxSigma.Items.AddRange(new object[] { "550", "600", "650", "800", "900", "1000", "1100", "1150", "1150" });
            BoxSigma.Location = new Point(377, 429);
            BoxSigma.Margin = new Padding(3, 4, 3, 4);
            BoxSigma.Name = "BoxSigma";
            BoxSigma.Size = new Size(116, 28);
            BoxSigma.TabIndex = 35;
            // 
            // Boxg0
            // 
            Boxg0.DropDownStyle = ComboBoxStyle.DropDownList;
            Boxg0.FormattingEnabled = true;
            Boxg0.Items.AddRange(new object[] { "17", "28", "38", "47", "56", "22", "31", "42", "53", "61", "82", "37", "48", "64", "73", "100" });
            Boxg0.Location = new Point(937, 260);
            Boxg0.Margin = new Padding(3, 4, 3, 4);
            Boxg0.Name = "Boxg0";
            Boxg0.Size = new Size(116, 28);
            Boxg0.TabIndex = 36;
            // 
            // BoxKhb
            // 
            BoxKhb.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxKhb.FormattingEnabled = true;
            BoxKhb.Items.AddRange(new object[] { "1,16", "1,37", "1,58", "1,8", "1,08", "1,18", "1,29", "1,4", "1,07", "1,14", "1,23", "1,34", "1", "1,2", "1,32", "1,44", "1,55", "1,04", "1,1", "1,15", "1,22", "1,28", "1,13" });
            BoxKhb.Location = new Point(937, 497);
            BoxKhb.Margin = new Padding(3, 4, 3, 4);
            BoxKhb.Name = "BoxKhb";
            BoxKhb.Size = new Size(116, 28);
            BoxKhb.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(202, 741);
            label9.Name = "label9";
            label9.Size = new Size(291, 20);
            label9.TabIndex = 38;
            label9.Text = "Значение контактного напряжения σ{H}";
            // 
            // label17
            // 
            label17.Location = new Point(202, 772);
            label17.Name = "label17";
            label17.Size = new Size(282, 52);
            label17.TabIndex = 39;
            label17.Text = "Допускаемое контактное напряжение σ{HP}";
            // 
            // ResultQH
            // 
            ResultQH.Location = new Point(520, 741);
            ResultQH.Margin = new Padding(3, 4, 3, 4);
            ResultQH.Name = "ResultQH";
            ResultQH.ReadOnly = true;
            ResultQH.Size = new Size(114, 27);
            ResultQH.TabIndex = 46;
            // 
            // ResultQHP
            // 
            ResultQHP.Location = new Point(520, 783);
            ResultQHP.Margin = new Padding(3, 4, 3, 4);
            ResultQHP.Name = "ResultQHP";
            ResultQHP.ReadOnly = true;
            ResultQHP.Size = new Size(114, 27);
            ResultQHP.TabIndex = 47;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(672, 741);
            textBoxResult.Margin = new Padding(3, 4, 3, 4);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(321, 27);
            textBoxResult.TabIndex = 51;
            textBoxResult.TextAlign = HorizontalAlignment.Center;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(791, 717);
            label20.Name = "label20";
            label20.Size = new Size(75, 20);
            label20.TabIndex = 52;
            label20.Text = "Результат";
            // 
            // labelKha
            // 
            labelKha.Location = new Point(619, 563);
            labelKha.Name = "labelKha";
            labelKha.Size = new Size(312, 65);
            labelKha.TabIndex = 53;
            labelKha.Text = "Коэффициент, учитывающий распределение нагрузки между зубьями K{ha}";
            // 
            // BoxKha
            // 
            BoxKha.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxKha.FormattingEnabled = true;
            BoxKha.Items.AddRange(new object[] { "1", "1,01", "1,03", "1,05", "1,13", "1,09", "1,16", "1,01", "1,07", "1,04", "1,02", "1,12", "1,06" });
            BoxKha.Location = new Point(937, 575);
            BoxKha.Margin = new Padding(3, 4, 3, 4);
            BoxKha.Name = "BoxKha";
            BoxKha.Size = new Size(116, 28);
            BoxKha.TabIndex = 54;
            // 
            // labelKhv
            // 
            labelKhv.Location = new Point(619, 635);
            labelKhv.Name = "labelKhv";
            labelKhv.Size = new Size(312, 65);
            labelKhv.TabIndex = 55;
            labelKhv.Text = "Коэффициент, учитывающий динамическую нагрузку, возникающую в зацеплении K{hv}";
            // 
            // BoxKhv
            // 
            BoxKhv.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxKhv.FormattingEnabled = true;
            BoxKhv.Items.AddRange(new object[] { "1,04", "1,045", "1,05", "1,06", "1,065", "1,07", "1,075", "1,08", "1,085", "1,09", "1,095", "1,08", "1,1", "1,11", "1,12", "1,13", "1,14", "1,15", "1,16" });
            BoxKhv.Location = new Point(937, 651);
            BoxKhv.Margin = new Padding(3, 4, 3, 4);
            BoxKhv.Name = "BoxKhv";
            BoxKhv.Size = new Size(116, 28);
            BoxKhv.TabIndex = 56;
            // 
            // SaveBut
            // 
            SaveBut.BackColor = Color.FromArgb(128, 255, 128);
            SaveBut.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBut.Location = new Point(362, 663);
            SaveBut.Name = "SaveBut";
            SaveBut.Size = new Size(131, 50);
            SaveBut.TabIndex = 57;
            SaveBut.Text = "Сохранить резульат";
            SaveBut.UseVisualStyleBackColor = false;
            SaveBut.Click += button2_Click;
            // 
            // text_isSaved
            // 
            text_isSaved.AutoSize = true;
            text_isSaved.Location = new Point(510, 676);
            text_isSaved.Name = "text_isSaved";
            text_isSaved.Size = new Size(0, 20);
            text_isSaved.TabIndex = 58;
            // 
            // LabelSE
            // 
            LabelSE.AutoSize = true;
            LabelSE.Location = new Point(63, 168);
            LabelSE.Name = "LabelSE";
            LabelSE.Size = new Size(150, 20);
            LabelSE.TabIndex = 59;
            LabelSE.Text = "Сборочная еденица";
            LabelSE.Click += label21_Click;
            // 
            // UnitCodeBox
            // 
            UnitCodeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            UnitCodeBox.FormattingEnabled = true;
            UnitCodeBox.Location = new Point(377, 160);
            UnitCodeBox.Margin = new Padding(3, 4, 3, 4);
            UnitCodeBox.Name = "UnitCodeBox";
            UnitCodeBox.Size = new Size(153, 28);
            UnitCodeBox.TabIndex = 60;
            UnitCodeBox.SelectedIndexChanged += UnitCodeBox_SelectedIndexChanged;
            // 
            // ResultCodeUnitText
            // 
            ResultCodeUnitText.AutoSize = true;
            ResultCodeUnitText.Location = new Point(748, 772);
            ResultCodeUnitText.Name = "ResultCodeUnitText";
            ResultCodeUnitText.Size = new Size(183, 20);
            ResultCodeUnitText.TabIndex = 61;
            ResultCodeUnitText.Text = "Код сборочной еденицы";
            // 
            // textBoxUnitCode
            // 
            textBoxUnitCode.Location = new Point(672, 797);
            textBoxUnitCode.Margin = new Padding(3, 4, 3, 4);
            textBoxUnitCode.Name = "textBoxUnitCode";
            textBoxUnitCode.ReadOnly = true;
            textBoxUnitCode.Size = new Size(321, 27);
            textBoxUnitCode.TabIndex = 62;
            textBoxUnitCode.TextAlign = HorizontalAlignment.Center;
            // 
            // ResultCodeDetail
            // 
            ResultCodeDetail.AutoSize = true;
            ResultCodeDetail.Location = new Point(791, 828);
            ResultCodeDetail.Name = "ResultCodeDetail";
            ResultCodeDetail.Size = new Size(86, 20);
            ResultCodeDetail.TabIndex = 63;
            ResultCodeDetail.Text = "Код детали";
            // 
            // textDetailCode
            // 
            textDetailCode.Location = new Point(672, 852);
            textDetailCode.Margin = new Padding(3, 4, 3, 4);
            textDetailCode.Name = "textDetailCode";
            textDetailCode.ReadOnly = true;
            textDetailCode.Size = new Size(321, 27);
            textDetailCode.TabIndex = 64;
            textDetailCode.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1109, 930);
            Controls.Add(textDetailCode);
            Controls.Add(ResultCodeDetail);
            Controls.Add(textBoxUnitCode);
            Controls.Add(ResultCodeUnitText);
            Controls.Add(UnitCodeBox);
            Controls.Add(LabelSE);
            Controls.Add(text_isSaved);
            Controls.Add(SaveBut);
            Controls.Add(BoxKhv);
            Controls.Add(labelKhv);
            Controls.Add(BoxKha);
            Controls.Add(labelKha);
            Controls.Add(label20);
            Controls.Add(textBoxResult);
            Controls.Add(ResultQHP);
            Controls.Add(ResultQH);
            Controls.Add(label17);
            Controls.Add(label9);
            Controls.Add(BoxKhb);
            Controls.Add(Boxg0);
            Controls.Add(BoxSigma);
            Controls.Add(BoxZm);
            Controls.Add(BoxZh);
            Controls.Add(BoxDeltaH);
            Controls.Add(BoxZubie);
            Controls.Add(textKhl);
            Controls.Add(textDm1);
            Controls.Add(textRe);
            Controls.Add(BoxWeight);
            Controls.Add(CountOfU);
            Controls.Add(CoefVm);
            Controls.Add(textFt);
            Controls.Add(CoefEa);
            Controls.Add(label19);
            Controls.Add(label13);
            Controls.Add(button1);
            Controls.Add(label18);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label18;
        private Button button1;
        private Label label13;
        private Label label19;
        private TextBox CoefEa;
        private TextBox textFt;
        private TextBox CoefVm;
        private TextBox CountOfU;
        private TextBox BoxWeight;
        private TextBox textRe;
        private TextBox textDm1;
        private TextBox textKhl;
        private ComboBox BoxZubie;
        private ComboBox BoxDeltaH;
        private ComboBox BoxZh;
        private ComboBox BoxZm;
        private ComboBox BoxSigma;
        private ComboBox Boxg0;
        private ComboBox BoxKhb;
        private Label label9;
        private Label label17;
        private TextBox ResultQH;
        private TextBox ResultQHP;
        private TextBox textBoxResult;
        private Label label20;
        private Label labelKha;
        private ComboBox UnitCodeBox;
        private ComboBox BoxKha;
        private Label labelKhv;
        private ComboBox BoxKhv;
        private Button SaveBut;
        private Label text_isSaved;
        private Label LabelSE;
        private Label ResultCodeUnitText;
        private TextBox textBoxUnitCode;
        private Label ResultCodeDetail;
        private TextBox textDetailCode;
    }
}
