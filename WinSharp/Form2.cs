using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Linq;

namespace WinSharp
{
    public partial class Form2 : Form
    {
        DataBase database = new DataBase();
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    

        private void button_save_form2_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var fio = textBox_fio2.Text;
            var email = textBox_email2.Text;
            bool interior = checkBox_interior2.Checked;
            bool video4k = checkBox_4k2.Checked;
            bool airvideo = checkBox_airvideo2.Checked;
            var ideaofvideo = richTextBox12.Text;
            var phonenumber = textBox_phone2.Text;
            var timing = textBox_timing2.Text;
            var format = comboBox_format2.Text;

            var addQuery = $"insert into Table_1(FIO,Email,Interior,video4k,Airvideo,Ideaofvideo,PhoneNumber,Timing) values ('{fio}','{email}','{interior}'" +
                $"'{video4k}','{airvideo}','{ideaofvideo}','{phonenumber}','{timing}')";

            var command = new SqlCommand(addQuery, database.GetConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана","", MessageBoxButtons.OK,MessageBoxIcon.Information);
            database.closeConnection();
        }
    }
}
