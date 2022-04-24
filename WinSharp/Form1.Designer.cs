
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
            this.textBox_format = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(361, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_fio
            // 
            this.textBox_fio.Location = new System.Drawing.Point(411, 12);
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1413, 692);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(769, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Идея для съемки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(766, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Съёмка с воздуха";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(329, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Эл. Почта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(275, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Номер телефона";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(411, 58);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(282, 23);
            this.textBox_phone.TabIndex = 12;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(411, 98);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(282, 23);
            this.textBox_email.TabIndex = 13;
            // 
            // checkBox_airvideo
            // 
            this.checkBox_airvideo.AutoSize = true;
            this.checkBox_airvideo.Location = new System.Drawing.Point(916, 12);
            this.checkBox_airvideo.Name = "checkBox_airvideo";
            this.checkBox_airvideo.Size = new System.Drawing.Size(15, 14);
            this.checkBox_airvideo.TabIndex = 14;
            this.checkBox_airvideo.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(916, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(222, 116);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // checkBox_interior
            // 
            this.checkBox_interior.AutoSize = true;
            this.checkBox_interior.Location = new System.Drawing.Point(411, 153);
            this.checkBox_interior.Name = "checkBox_interior";
            this.checkBox_interior.Size = new System.Drawing.Size(15, 14);
            this.checkBox_interior.TabIndex = 16;
            this.checkBox_interior.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(297, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Свой реквизит";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox_4k
            // 
            this.checkBox_4k.AutoSize = true;
            this.checkBox_4k.Location = new System.Drawing.Point(411, 192);
            this.checkBox_4k.Name = "checkBox_4k";
            this.checkBox_4k.Size = new System.Drawing.Size(15, 14);
            this.checkBox_4k.TabIndex = 18;
            this.checkBox_4k.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "4k";
            // 
            // textBox_timing
            // 
            this.textBox_timing.Location = new System.Drawing.Point(915, 168);
            this.textBox_timing.Name = "textBox_timing";
            this.textBox_timing.Size = new System.Drawing.Size(222, 23);
            this.textBox_timing.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(807, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Хронометраж";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(841, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Формат";
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(33, 143);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(436, 62);
            this.button_delete.TabIndex = 24;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_save.Location = new System.Drawing.Point(36, 211);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(436, 66);
            this.button_save.TabIndex = 28;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_excel
            // 
            this.button_excel.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_excel.Location = new System.Drawing.Point(33, 283);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(436, 64);
            this.button_excel.TabIndex = 29;
            this.button_excel.Text = "Excel";
            this.button_excel.UseVisualStyleBackColor = true;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // textBox3_search
            // 
            this.textBox3_search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3_search.Location = new System.Drawing.Point(1039, 12);
            this.textBox3_search.Name = "textBox3_search";
            this.textBox3_search.Size = new System.Drawing.Size(367, 33);
            this.textBox3_search.TabIndex = 30;
            this.textBox3_search.TextChanged += new System.EventHandler(this.textBox3_search_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.textBox_format);
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
            this.panel1.Size = new System.Drawing.Size(1413, 267);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox_format
            // 
            this.textBox_format.Location = new System.Drawing.Point(915, 208);
            this.textBox_format.Name = "textBox_format";
            this.textBox_format.Size = new System.Drawing.Size(222, 23);
            this.textBox_format.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_edit);
            this.panel2.Controls.Add(this.button_newpost);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_save);
            this.panel2.Controls.Add(this.button_excel);
            this.panel2.Location = new System.Drawing.Point(1420, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 352);
            this.panel2.TabIndex = 33;
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_edit.Location = new System.Drawing.Point(33, 73);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(436, 64);
            this.button_edit.TabIndex = 31;
            this.button_edit.Text = "Редактировать";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_newpost
            // 
            this.button_newpost.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_newpost.Location = new System.Drawing.Point(33, 3);
            this.button_newpost.Name = "button_newpost";
            this.button_newpost.Size = new System.Drawing.Size(436, 64);
            this.button_newpost.TabIndex = 30;
            this.button_newpost.Text = "Новая запись";
            this.button_newpost.UseVisualStyleBackColor = true;
            this.button_newpost.Click += new System.EventHandler(this.button_newpost_Click);
            // 
            // button1_refresh
            // 
            this.button1_refresh.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1_refresh.Image = global::WinSharp.Properties.Resources.update_w101;
            this.button1_refresh.Location = new System.Drawing.Point(994, 12);
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
        private System.Windows.Forms.TextBox textBox_format;
        private System.Windows.Forms.Button button_edit;
    }
}

