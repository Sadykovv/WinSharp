using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD=System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinSharp
{

    enum RowState
    {
        Existed,
        New,
        Modified,
        Deleted
    }
    public partial class Form1 : Form
    {
        

        DataBase dataBase = new DataBase();
        int selectedRow;
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "id");
            dataGridView1.Columns.Add("FIO", "ФИО");
            dataGridView1.Columns.Add("Email", "Почта");
            dataGridView1.Columns.Add("Interior", "Реквизиты");
            dataGridView1.Columns.Add("video4k", "4к");
            dataGridView1.Columns.Add("Airvideo", "Съёмка с воздуха");
            dataGridView1.Columns.Add("Ideaofvideo", "Идея съёмки");
            dataGridView1.Columns.Add("PhoneNumber", "Номер телефона");
            dataGridView1.Columns.Add("Timing", "Хронометраж");
            dataGridView1.Columns.Add("Format", "Формат");
            dataGridView1.Columns.Add("signLangInt", "Сурдоперевод");
            dataGridView1.Columns.Add("colorCorr", "Цветокор");
            dataGridView1.Columns.Add("subtitles", "Субтитры");
            dataGridView1.Columns.Add("music", "Муз.Соп");
            dataGridView1.Columns.Add("localization", "Дубляж");
            dataGridView1.Columns.Add("LocationLayout", "Макет локации");
            dataGridView1.Columns.Add("Status", "Статус заказа");
            dataGridView1.Columns.Add("IsNew","вввв");
 
        }
        private void ReadSingleRow(DataGridView dgw,SD.IDataRecord record)
        {

            dgw.Rows.Add(record.GetInt32(0),record.GetString(1),record.GetString(2),record.GetBoolean(3),record.GetBoolean(4),
            record.GetBoolean(5),record.GetString(6),record.GetString(7),record.GetString(8),record.GetString(9),
            record.GetBoolean(10),record.GetBoolean(11),record.GetBoolean(12),record.GetBoolean(13),record.GetBoolean(14),record.GetString(15), record.GetString(16),RowState.New);
          
        }


        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Table_1";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select *from Table_1 where concat (ID,FIO,Email,Interior,video4k,Airvideo,Ideaofvideo,PhoneNumber,Timing,Format,signLangInt,colorCorr,subtitles,music,localization,locationLayout,Status)like '%"+textBox3_search.Text+"%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while(read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[17].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[17].Value = RowState.Deleted;

        }


        private void Update()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[17].Value;

                if (rowState == RowState.Existed)
                    continue;

                if(rowState==RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Table_1 where id={id}";

                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
                if(rowState==RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var fio = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var email = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    bool interior = (bool)dataGridView1.Rows[index].Cells[3].Value;
                    bool video4k = (bool)dataGridView1.Rows[index].Cells[4].Value;
                    bool airvideo = (bool)dataGridView1.Rows[index].Cells[5].Value;
                    var ideaofvideo = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var phonenumber = dataGridView1.Rows[index].Cells[7].Value.ToString();
                    var timing = dataGridView1.Rows[index].Cells[8].Value.ToString();
                    var format= dataGridView1.Rows[index].Cells[9].Value.ToString();
                    var signLangInt = dataGridView1.Rows[index].Cells[10].Value.ToString();
                    var colorCorr = (bool)dataGridView1.Rows[index].Cells[11].Value;
                    var subtitles = (bool)dataGridView1.Rows[index].Cells[12].Value;
                    var music = (bool)dataGridView1.Rows[index].Cells[13].Value;
                    var localization = (bool)dataGridView1.Rows[index].Cells[14].Value;
                    var lozationLayout = dataGridView1.Rows[index].Cells[15].Value.ToString();
                    var Status = dataGridView1.Rows[index].Cells[16].Value.ToString();

                    var changeQuery = $"update Table_1 set FIO='{fio}',Email='{email}',Interior='{interior}',video4k='{video4k}',Airvideo='{airvideo}',Ideaofvideo='{ideaofvideo}',PhoneNumber='{phonenumber}'," +
                        $"Timing='{timing}',Format='{format}',signLangInt='{signLangInt}',colorCorr='{colorCorr}',subtitles='{subtitles}',music='{music}',localization='{localization}',locationLayout='{lozationLayout}',Status='{Status}' where ID ='{id}'";
                    var command = new SqlCommand(changeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }



        private void textBox3_search_TextChanged(object sender, EventArgs e)
        {
          
            Search(dataGridView1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_fio.Text = row.Cells[1].Value.ToString();
                textBox_email.Text = row.Cells[2].Value.ToString();
                checkBox_interior.Checked= (bool)row.Cells[3].Value;
                checkBox_4k.Checked = (bool)row.Cells[4].Value;
                checkBox_airvideo.Checked = (bool)row.Cells[5].Value;
                richTextBox1.Text = row.Cells[6].Value.ToString();
                textBox_phone.Text = row.Cells[7].Value.ToString();
                textBox_timing.Text = row.Cells[8].Value.ToString();
                comboBox_format.Text = row.Cells[9].Value.ToString();
                checkBox_signLangInt.Checked = (bool)row.Cells[10].Value;
                checkBox_colorCorr.Checked = (bool)row.Cells[11].Value;
                checkBox_subtitles.Checked = (bool)row.Cells[12].Value;
                checkBox_music.Checked = (bool)row.Cells[13].Value;
                checkBox_localization.Checked = (bool)row.Cells[14].Value;
                textBox_locationLayout.Text = row.Cells[15].Value.ToString();
                comboBox_Status.Text = row.Cells[16].Value.ToString();
            }
        }

        private void button1_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_newpost_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button6_search_Click(object sender, EventArgs e)
        {

        }

        private void Change()
        {
            var selectedrowindex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_id.Text;
            var fio = textBox_fio.Text;
            var email = textBox_email.Text;
            bool interior = checkBox_interior.Checked;
            bool video4k = checkBox_4k.Checked;
            bool airvideo = checkBox_airvideo.Checked;
            var ideaofvideo = richTextBox1.Text;
            var phonenumber = textBox_phone.Text;
            var timing = textBox_timing.Text;
            var format = comboBox_format.Text;
            bool signLangInt = checkBox_signLangInt.Checked;
            bool colorCorr = checkBox_colorCorr.Checked;
            bool subtitles = checkBox_subtitles.Checked;
            bool music = checkBox_music.Checked;
            bool localization = checkBox_localization.Checked;
            var locationLayout = textBox_locationLayout.Text;
            var Status = comboBox_Status.Text;




            dataGridView1.Rows[selectedrowindex].SetValues(id,fio, email, interior, video4k, airvideo, ideaofvideo, phonenumber, timing, format,signLangInt,colorCorr,subtitles,music,localization,locationLayout,Status);
            dataGridView1.Rows[selectedrowindex].Cells[17].Value = RowState.Modified;
            
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            string replacer;
            for (i = 0; i <=dataGridView1.RowCount-1;i++)
            {
                for (j=0;j<=dataGridView1.ColumnCount-1;j++)
                {
                    wsh.Cells[1, j + 1] = dataGridView1.Columns[j].HeaderText.ToString();
                    replacer = dataGridView1[j,i].Value.ToString().Replace("32","6666");
                    wsh.Cells[i + 2, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }    

                exApp.Visible = true;
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
