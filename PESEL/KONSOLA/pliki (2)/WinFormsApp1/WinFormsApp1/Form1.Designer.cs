namespace WinFormsApp1
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
            groupBoxRodzajPrzesylki = new GroupBox();
            radioButtonPaczka = new RadioButton();
            radioButtonList = new RadioButton();
            radioButtonPocztowka = new RadioButton();
            buttonSprawdzCene = new Button();
            pictureBoxRodzajPaczki = new PictureBox();
            labelCena = new Label();
            buttonZatwierdzanie = new Button();
            groupBoxDaneAdresowe = new GroupBox();
            textBoxMiasto = new TextBox();
            labelMiasto = new Label();
            textBoxKodPocztowy = new TextBox();
            labelKod = new Label();
            textBoxUlica = new TextBox();
            labelUlica = new Label();
            groupBoxRodzajPrzesylki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRodzajPaczki).BeginInit();
            groupBoxDaneAdresowe.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRodzajPrzesylki
            // 
            groupBoxRodzajPrzesylki.Controls.Add(radioButtonPaczka);
            groupBoxRodzajPrzesylki.Controls.Add(radioButtonList);
            groupBoxRodzajPrzesylki.Controls.Add(radioButtonPocztowka);
            groupBoxRodzajPrzesylki.Location = new Point(42, 48);
            groupBoxRodzajPrzesylki.Name = "groupBoxRodzajPrzesylki";
            groupBoxRodzajPrzesylki.Size = new Size(200, 117);
            groupBoxRodzajPrzesylki.TabIndex = 0;
            groupBoxRodzajPrzesylki.TabStop = false;
            groupBoxRodzajPrzesylki.Text = "Rodzaj przesyłki";
            // 
            // radioButtonPaczka
            // 
            radioButtonPaczka.AutoSize = true;
            radioButtonPaczka.Location = new Point(17, 86);
            radioButtonPaczka.Name = "radioButtonPaczka";
            radioButtonPaczka.Size = new Size(61, 19);
            radioButtonPaczka.TabIndex = 2;
            radioButtonPaczka.TabStop = true;
            radioButtonPaczka.Text = "Paczka";
            radioButtonPaczka.UseVisualStyleBackColor = true;
            // 
            // radioButtonList
            // 
            radioButtonList.AutoSize = true;
            radioButtonList.Location = new Point(17, 61);
            radioButtonList.Name = "radioButtonList";
            radioButtonList.Size = new Size(43, 19);
            radioButtonList.TabIndex = 1;
            radioButtonList.TabStop = true;
            radioButtonList.Text = "List";
            radioButtonList.UseVisualStyleBackColor = true;
            // 
            // radioButtonPocztowka
            // 
            radioButtonPocztowka.AutoSize = true;
            radioButtonPocztowka.Location = new Point(17, 36);
            radioButtonPocztowka.Name = "radioButtonPocztowka";
            radioButtonPocztowka.Size = new Size(82, 19);
            radioButtonPocztowka.TabIndex = 0;
            radioButtonPocztowka.TabStop = true;
            radioButtonPocztowka.Text = "Pocztówka";
            radioButtonPocztowka.UseVisualStyleBackColor = true;
            // 
            // buttonSprawdzCene
            // 
            buttonSprawdzCene.Location = new Point(42, 171);
            buttonSprawdzCene.Name = "buttonSprawdzCene";
            buttonSprawdzCene.Size = new Size(200, 23);
            buttonSprawdzCene.TabIndex = 1;
            buttonSprawdzCene.Text = "Sprawdz Cene";
            buttonSprawdzCene.UseVisualStyleBackColor = true;
            buttonSprawdzCene.Click += buttonSprawdzCene_Click;
            // 
            // pictureBoxRodzajPaczki
            // 
            pictureBoxRodzajPaczki.Image = Properties.Resources.list;
            pictureBoxRodzajPaczki.Location = new Point(42, 215);
            pictureBoxRodzajPaczki.Name = "pictureBoxRodzajPaczki";
            pictureBoxRodzajPaczki.Size = new Size(100, 62);
            pictureBoxRodzajPaczki.TabIndex = 2;
            pictureBoxRodzajPaczki.TabStop = false;
            pictureBoxRodzajPaczki.Click += pictureBox1_Click;
            // 
            // labelCena
            // 
            labelCena.AutoSize = true;
            labelCena.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelCena.Location = new Point(153, 214);
            labelCena.Name = "labelCena";
            labelCena.Size = new Size(52, 21);
            labelCena.TabIndex = 3;
            labelCena.Text = "Cena:";
            // 
            // buttonZatwierdzanie
            // 
            buttonZatwierdzanie.Location = new Point(42, 404);
            buttonZatwierdzanie.Name = "buttonZatwierdzanie";
            buttonZatwierdzanie.Size = new Size(746, 34);
            buttonZatwierdzanie.TabIndex = 4;
            buttonZatwierdzanie.Text = "Zatwierdź";
            buttonZatwierdzanie.UseVisualStyleBackColor = true;
            buttonZatwierdzanie.Click += buttonZatwierdzanie_Click;
            // 
            // groupBoxDaneAdresowe
            // 
            groupBoxDaneAdresowe.Controls.Add(textBoxMiasto);
            groupBoxDaneAdresowe.Controls.Add(labelMiasto);
            groupBoxDaneAdresowe.Controls.Add(textBoxKodPocztowy);
            groupBoxDaneAdresowe.Controls.Add(labelKod);
            groupBoxDaneAdresowe.Controls.Add(textBoxUlica);
            groupBoxDaneAdresowe.Controls.Add(labelUlica);
            groupBoxDaneAdresowe.Location = new Point(493, 48);
            groupBoxDaneAdresowe.Name = "groupBoxDaneAdresowe";
            groupBoxDaneAdresowe.Size = new Size(270, 254);
            groupBoxDaneAdresowe.TabIndex = 5;
            groupBoxDaneAdresowe.TabStop = false;
            groupBoxDaneAdresowe.Text = "Dane adresowe";
            // 
            // textBoxMiasto
            // 
            textBoxMiasto.Location = new Point(13, 200);
            textBoxMiasto.Name = "textBoxMiasto";
            textBoxMiasto.Size = new Size(251, 23);
            textBoxMiasto.TabIndex = 5;
            // 
            // labelMiasto
            // 
            labelMiasto.AutoSize = true;
            labelMiasto.Location = new Point(13, 167);
            labelMiasto.Name = "labelMiasto";
            labelMiasto.Size = new Size(43, 15);
            labelMiasto.TabIndex = 4;
            labelMiasto.Text = "Miasto";
            // 
            // textBoxKodPocztowy
            // 
            textBoxKodPocztowy.Location = new Point(13, 124);
            textBoxKodPocztowy.Name = "textBoxKodPocztowy";
            textBoxKodPocztowy.Size = new Size(100, 23);
            textBoxKodPocztowy.TabIndex = 3;
            // 
            // labelKod
            // 
            labelKod.AutoSize = true;
            labelKod.Location = new Point(13, 102);
            labelKod.Name = "labelKod";
            labelKod.Size = new Size(82, 15);
            labelKod.TabIndex = 2;
            labelKod.Text = "Kod pocztowy";
            // 
            // textBoxUlica
            // 
            textBoxUlica.Location = new Point(13, 61);
            textBoxUlica.Name = "textBoxUlica";
            textBoxUlica.Size = new Size(251, 23);
            textBoxUlica.TabIndex = 1;
            // 
            // labelUlica
            // 
            labelUlica.AutoSize = true;
            labelUlica.Location = new Point(13, 36);
            labelUlica.Name = "labelUlica";
            labelUlica.Size = new Size(99, 15);
            labelUlica.TabIndex = 0;
            labelUlica.Text = "Ulica z numerem:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxDaneAdresowe);
            Controls.Add(buttonZatwierdzanie);
            Controls.Add(labelCena);
            Controls.Add(pictureBoxRodzajPaczki);
            Controls.Add(buttonSprawdzCene);
            Controls.Add(groupBoxRodzajPrzesylki);
            Name = "Form1";
            Text = "Nadaj przesyłke, PESEL: 00099090";
            groupBoxRodzajPrzesylki.ResumeLayout(false);
            groupBoxRodzajPrzesylki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRodzajPaczki).EndInit();
            groupBoxDaneAdresowe.ResumeLayout(false);
            groupBoxDaneAdresowe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxRodzajPrzesylki;
        private RadioButton radioButtonPaczka;
        private RadioButton radioButtonList;
        private RadioButton radioButtonPocztowka;
        private Button buttonSprawdzCene;
        private PictureBox pictureBoxRodzajPaczki;
        private Label labelCena;
        private Button buttonZatwierdzanie;
        private GroupBox groupBoxDaneAdresowe;
        private TextBox textBoxMiasto;
        private Label labelMiasto;
        private TextBox textBoxKodPocztowy;
        private Label labelKod;
        private TextBox textBoxUlica;
        private Label labelUlica;
    }
}
