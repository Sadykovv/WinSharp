
namespace WinSharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.checkBox_airvideo = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox_interior = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_4k = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_timing = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_excel = new System.Windows.Forms.Button();
            this.textBox3_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_locationLayout = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox_music = new System.Windows.Forms.CheckBox();
            this.checkBox_localization = new System.Windows.Forms.CheckBox();
            this.checkBox_subtitles = new System.Windows.Forms.CheckBox();
            this.checkBox_colorCorr = new System.Windows.Forms.CheckBox();
            this.checkBox_signLangInt = new System.Windows.Forms.CheckBox();
            this.comboBox_format = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_newpost = new System.Windows.Forms.Button();
            this.button1_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(213, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_fio
            // 
            this.textBox_fio.Location = new System.Drawing.Point(263, 17);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(282, 23);
            this.textBox_fio.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1624, 692);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(561, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Идея для съемки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(558, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Съёмка с воздуха";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(181, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Эл. Почта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(127, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Номер телефона";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(263, 63);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(282, 23);
            this.textBox_phone.TabIndex = 12;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(263, 103);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(282, 23);
            this.textBox_email.TabIndex = 13;
            // 
            // checkBox_airvideo
            // 
            this.checkBox_airvideo.AutoSize = true;
            this.checkBox_airvideo.Location = new System.Drawing.Point(708, 19);
            this.checkBox_airvideo.Name = "checkBox_airvideo";
            this.checkBox_airvideo.Size = new System.Drawing.Size(15, 14);
            this.checkBox_airvideo.TabIndex = 14;
            this.checkBox_airvideo.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(708, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(222, 116);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // checkBox_interior
            // 
            this.checkBox_interior.AutoSize = true;
            this.checkBox_interior.Location = new System.Drawing.Point(263, 158);
            this.checkBox_interior.Name = "checkBox_interior";
            this.checkBox_interior.Size = new System.Drawing.Size(15, 14);
            this.checkBox_interior.TabIndex = 16;
            this.checkBox_interior.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(149, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Свой реквизит";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox_4k
            // 
            this.checkBox_4k.AutoSize = true;
            this.checkBox_4k.Location = new System.Drawing.Point(263, 197);
            this.checkBox_4k.Name = "checkBox_4k";
            this.checkBox_4k.Size = new System.Drawing.Size(15, 14);
            this.checkBox_4k.TabIndex = 18;
            this.checkBox_4k.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "4k";
            // 
            // textBox_timing
            // 
            this.textBox_timing.Location = new System.Drawing.Point(707, 175);
            this.textBox_timing.Name = "textBox_timing";
            this.textBox_timing.Size = new System.Drawing.Size(222, 23);
            this.textBox_timing.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(599, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Хронометраж";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(633, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Формат";
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(19, 143);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(227, 62);
            this.button_delete.TabIndex = 24;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_save.Location = new System.Drawing.Point(19, 211);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(230, 66);
            this.button_save.TabIndex = 28;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_excel
            // 
            this.button_excel.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_excel.Location = new System.Drawing.Point(19, 283);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(227, 64);
            this.button_excel.TabIndex = 29;
            this.button_excel.Text = "Excel";
            this.button_excel.UseVisualStyleBackColor = true;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // textBox3_search
            // 
            this.textBox3_search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3_search.Location = new System.Drawing.Point(1258, 13);
            this.textBox3_search.Name = "textBox3_search";
            this.textBox3_search.Size = new System.Drawing.Size(367, 33);
            this.textBox3_search.TabIndex = 30;
            this.textBox3_search.TextChanged += new System.EventHandler(this.textBox3_search_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.textBox_locationLayout);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.checkBox_music);
            this.panel1.Controls.Add(this.checkBox_localization);
            this.panel1.Controls.Add(this.checkBox_subtitles);
            this.panel1.Controls.Add(this.checkBox_colorCorr);
            this.panel1.Controls.Add(this.checkBox_signLangInt);
            this.panel1.Controls.Add(this.comboBox_format);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.textBox_fio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_email);
            this.panel1.Controls.Add(this.textBox_phone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkBox_interior);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.checkBox_4k);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.textBox_timing);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBox_airvideo);
            this.panel1.Location = new System.Drawing.Point(1, 762);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1635, 267);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(1289, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 19);
            this.label16.TabIndex = 40;
            this.label16.Text = "Макет";
            // 
            // textBox_locationLayout
            // 
            this.textBox_locationLayout.Location = new System.Drawing.Point(1359, 188);
            this.textBox_locationLayout.Name = "textBox_locationLayout";
            this.textBox_locationLayout.Size = new System.Drawing.Size(206, 23);
            this.textBox_locationLayout.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(1236, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 19);
            this.label15.TabIndex = 38;
            this.label15.Text = "Дублирование";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(1282, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 19);
            this.label14.TabIndex = 37;
            this.label14.Text = "Музыка";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(1085, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 19);
            this.label13.TabIndex = 36;
            this.label13.Text = "Субтитры";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(1085, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 19);
            this.label12.TabIndex = 35;
            this.label12.Text = "Цветокор";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(1055, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 19);
            this.label11.TabIndex = 34;
            this.label11.Text = "Сурдоперевод";
            // 
            // checkBox_music
            // 
            this.checkBox_music.AutoSize = true;
            this.checkBox_music.Location = new System.Drawing.Point(1359, 23);
            this.checkBox_music.Name = "checkBox_music";
            this.checkBox_music.Size = new System.Drawing.Size(15, 14);
            this.checkBox_music.TabIndex = 33;
            this.checkBox_music.UseVisualStyleBackColor = true;
            // 
            // checkBox_localization
            // 
            this.checkBox_localization.AutoSize = true;
            this.checkBox_localization.Location = new System.Drawing.Point(1359, 107);
            this.checkBox_localization.Name = "checkBox_localization";
            this.checkBox_localization.Size = new System.Drawing.Size(15, 14);
            this.checkBox_localization.TabIndex = 32;
            this.checkBox_localization.UseVisualStyleBackColor = true;
            // 
            // checkBox_subtitles
            // 
            this.checkBox_subtitles.AutoSize = true;
            this.checkBox_subtitles.Location = new System.Drawing.Point(1165, 189);
            this.checkBox_subtitles.Name = "checkBox_subtitles";
            this.checkBox_subtitles.Size = new System.Drawing.Size(15, 14);
            this.checkBox_subtitles.TabIndex = 30;
            this.checkBox_subtitles.UseVisualStyleBackColor = true;
            // 
            // checkBox_colorCorr
            // 
            this.checkBox_colorCorr.AutoSize = true;
            this.checkBox_colorCorr.Location = new System.Drawing.Point(1165, 112);
            this.checkBox_colorCorr.Name = "checkBox_colorCorr";
            this.checkBox_colorCorr.Size = new System.Drawing.Size(15, 14);
            this.checkBox_colorCorr.TabIndex = 29;
            this.checkBox_colorCorr.UseVisualStyleBackColor = true;
            // 
            // checkBox_signLangInt
            // 
            this.checkBox_signLangInt.AutoSize = true;
            this.checkBox_signLangInt.Location = new System.Drawing.Point(1165, 20);
            this.checkBox_signLangInt.Name = "checkBox_signLangInt";
            this.checkBox_signLangInt.Size = new System.Drawing.Size(15, 14);
            this.checkBox_signLangInt.TabIndex = 28;
            this.checkBox_signLangInt.UseVisualStyleBackColor = true;
            // 
            // comboBox_format
            // 
            this.comboBox_format.FormattingEnabled = true;
            this.comboBox_format.Items.AddRange(new object[] {
            "Праздничное",
            "Корпоративное",
            "Промо видео",
            "Другое"});
            this.comboBox_format.Location = new System.Drawing.Point(708, 215);
            this.comboBox_format.Name = "comboBox_format";
            this.comboBox_format.Size = new System.Drawing.Size(222, 23);
            this.comboBox_format.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Id";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(45, 14);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(49, 23);
            this.textBox_id.TabIndex = 25;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_edit);
            this.panel2.Controls.Add(this.button_newpost);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_save);
            this.panel2.Controls.Add(this.button_excel);
            this.panel2.Location = new System.Drawing.Point(1642, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 352);
            this.panel2.TabIndex = 33;
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_edit.Location = new System.Drawing.Point(19, 73);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(227, 64);
            this.button_edit.TabIndex = 31;
            this.button_edit.Text = "Редактировать";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_newpost
            // 
            this.button_newpost.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_newpost.Location = new System.Drawing.Point(19, 3);
            this.button_newpost.Name = "button_newpost";
            this.button_newpost.Size = new System.Drawing.Size(227, 64);
            this.button_newpost.TabIndex = 30;
            this.button_newpost.Text = "Новая запись";
            this.button_newpost.UseVisualStyleBackColor = true;
            this.button_newpost.Click += new System.EventHandler(this.button_newpost_Click);
            // 
            // button1_refresh
            // 
            this.button1_refresh.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1_refresh.Image = global::WinSharp.Properties.Resources.update_w101;
            this.button1_refresh.Location = new System.Drawing.Point(1214, 12);
            this.button1_refresh.Name = "button1_refresh";
            this.button1_refresh.Size = new System.Drawing.Size(38, 34);
            this.button1_refresh.TabIndex = 34;
            this.button1_refresh.UseVisualStyleBackColor = true;
            this.button1_refresh.Click += new System.EventHandler(this.button1_refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button1_refresh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox3_search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.CheckBox checkBox_airvideo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox_interior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_4k;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_timing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.TextBox textBox3_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1_refresh;
        private System.Windows.Forms.Button button_newpost;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.ComboBox comboBox_format;
        private System.Windows.Forms.CheckBox checkBox_music;
        private System.Windows.Forms.CheckBox checkBox_localization;
        private System.Windows.Forms.CheckBox checkBox_subtitles;
        private System.Windows.Forms.CheckBox checkBox_colorCorr;
        private System.Windows.Forms.CheckBox checkBox_signLangInt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_locationLayout;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

