namespace Titanic
{
    partial class AddEditForm
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
            comboBoxSurvived = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxClass = new ComboBox();
            textBoxName = new TextBox();
            labelSex = new Label();
            comboBoxSex = new ComboBox();
            labelAge = new Label();
            numericUpDownAge = new NumericUpDown();
            numericUpDownSibsp = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            numericUpDownParch = new NumericUpDown();
            textBoxTicket = new TextBox();
            textBoxFare = new TextBox();
            textBoxCabin = new TextBox();
            comboBoxEmbarce = new ComboBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSibsp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownParch).BeginInit();
            SuspendLayout();
            // 
            // comboBoxSurvived
            // 
            comboBoxSurvived.FormattingEnabled = true;
            comboBoxSurvived.Items.AddRange(new object[] { "Не выжил", "Выжил" });
            comboBoxSurvived.Location = new Point(12, 45);
            comboBoxSurvived.Name = "comboBoxSurvived";
            comboBoxSurvived.Size = new Size(254, 28);
            comboBoxSurvived.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "Состояние";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 88);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Класс";
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "1", "2", "3", "" });
            comboBoxClass.Location = new Point(12, 123);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(254, 28);
            comboBoxClass.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 186);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Сведения о пассажире";
            textBoxName.Size = new Size(254, 98);
            textBoxName.TabIndex = 4;
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Location = new Point(13, 311);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(37, 20);
            labelSex.TabIndex = 5;
            labelSex.Text = "Пол";
            // 
            // comboBoxSex
            // 
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Items.AddRange(new object[] { "Мужской", "Женский" });
            comboBoxSex.Location = new Point(13, 355);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(253, 28);
            comboBoxSex.TabIndex = 6;
            comboBoxSex.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(12, 413);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(64, 20);
            labelAge.TabIndex = 8;
            labelAge.Text = "Возраст";
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(12, 465);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(245, 27);
            numericUpDownAge.TabIndex = 9;
            // 
            // numericUpDownSibsp
            // 
            numericUpDownSibsp.Location = new Point(373, 45);
            numericUpDownSibsp.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownSibsp.Name = "numericUpDownSibsp";
            numericUpDownSibsp.Size = new Size(190, 27);
            numericUpDownSibsp.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 12);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 11;
            label3.Text = "Sibsp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 88);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 12;
            label4.Text = "Parch";
            // 
            // numericUpDownParch
            // 
            numericUpDownParch.Location = new Point(373, 124);
            numericUpDownParch.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownParch.Name = "numericUpDownParch";
            numericUpDownParch.Size = new Size(183, 27);
            numericUpDownParch.TabIndex = 13;
            // 
            // textBoxTicket
            // 
            textBoxTicket.Location = new Point(371, 186);
            textBoxTicket.Name = "textBoxTicket";
            textBoxTicket.PlaceholderText = "Номер билета";
            textBoxTicket.Size = new Size(185, 27);
            textBoxTicket.TabIndex = 14;
            // 
            // textBoxFare
            // 
            textBoxFare.Location = new Point(372, 257);
            textBoxFare.Name = "textBoxFare";
            textBoxFare.PlaceholderText = "Цена";
            textBoxFare.Size = new Size(183, 27);
            textBoxFare.TabIndex = 15;
            // 
            // textBoxCabin
            // 
            textBoxCabin.Location = new Point(371, 354);
            textBoxCabin.Name = "textBoxCabin";
            textBoxCabin.PlaceholderText = "Каюта";
            textBoxCabin.Size = new Size(184, 27);
            textBoxCabin.TabIndex = 16;
            // 
            // comboBoxEmbarce
            // 
            comboBoxEmbarce.FormattingEnabled = true;
            comboBoxEmbarce.Items.AddRange(new object[] { "C", "S", "Q" });
            comboBoxEmbarce.Location = new Point(371, 465);
            comboBoxEmbarce.Name = "comboBoxEmbarce";
            comboBoxEmbarce.Size = new Size(185, 28);
            comboBoxEmbarce.TabIndex = 17;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOk.Location = new Point(52, 551);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(126, 60);
            buttonOk.TabIndex = 18;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(403, 551);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(114, 51);
            buttonCancel.TabIndex = 19;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 642);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(comboBoxEmbarce);
            Controls.Add(textBoxCabin);
            Controls.Add(textBoxFare);
            Controls.Add(textBoxTicket);
            Controls.Add(numericUpDownParch);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDownSibsp);
            Controls.Add(numericUpDownAge);
            Controls.Add(labelAge);
            Controls.Add(comboBoxSex);
            Controls.Add(labelSex);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxClass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxSurvived);
            Name = "AddEditForm";
            Text = "Информация о пассажире";
            Load += AddEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSibsp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownParch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox comboBoxSurvived;
        public Label label1;
        public Label label2;
        public ComboBox comboBoxClass;
        public TextBox textBoxName;
        public Label labelSex;
        public ComboBox comboBoxSex;
        public Label labelAge;
        public NumericUpDown numericUpDownAge;
        public NumericUpDown numericUpDownSibsp;
        public Label label3;
        public Label label4;
        public NumericUpDown numericUpDownParch;
        public TextBox textBoxTicket;
        public TextBox textBoxFare;
        public TextBox textBoxCabin;
        public ComboBox comboBoxEmbarce;
        public Button buttonOk;
        public Button buttonCancel;
        private NumericUpDown numericUpDown1;
    }
}