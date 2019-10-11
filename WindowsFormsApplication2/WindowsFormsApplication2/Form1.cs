using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviaPromDataSet.Used_Enviroments". При необходимости она может быть перемещена или удалена.
            this.used_EnviromentsTableAdapter.Fill(this.aviaPromDataSet.Used_Enviroments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviaPromDataSet.Tests". При необходимости она может быть перемещена или удалена.
            this.testsTableAdapter.Fill(this.aviaPromDataSet.Tests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviaPromDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.aviaPromDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviaPromDataSet.Laboratories". При необходимости она может быть перемещена или удалена.
            this.laboratoriesTableAdapter.Fill(this.aviaPromDataSet.Laboratories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviaPromDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.aviaPromDataSet.Categories);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Создание открытого подключения
            string connectionStr = "Data Source=KB37-122-C12" + "\\" + "SQLEXPRESS;Initial Catalog=AviaProm;Integrated Security=SSPI;";
            SqlConnection dbConnection = new SqlConnection(connectionStr);
            dbConnection.Open();

            //Создание обьекта команды SQL
            string sqlQuery = "INSERT INTO Categories (Name) VALUES ('Электроника')"; //-добавляем в таблицу данные
            using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))

                //Отправляем команду
                command.ExecuteNonQuery();
            this.categoriesTableAdapter.Fill(this.aviaPromDataSet.Categories); //имя адаптера и набора данных будет зависеть от названия базы данных, указанной при подключении

            //Закрываем соединение с базой данных
            dbConnection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Создание открытого подключения
            string connectionStr = "Data Source=KB37-122-C12" + "\\" + "SQLEXPRESS;Initial Catalog=AviaProm;Integrated Security=SSPI;";
            SqlConnection dbConnection = new SqlConnection(connectionStr);
            dbConnection.Open();

            //Создание объекта команды SQL
            string sqlQuery = "DELETE FROM Categories WHERE Name='Электроника'";
            using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))

                //Отправляем команду
                command.ExecuteNonQuery();
            this.categoriesTableAdapter.Fill(this.aviaPromDataSet.Categories); //имя адаптера и набора данных будет зависеть от названия базы данных, указанной при подключении

            //Закрываем соединение с базой данных
            dbConnection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Создание открытого подключения
            string connectionStr = "Data Source=KB37-122-C12" + "\\" + "SQLEXPRESS;Initial Catalog=AviaProm;Integrated Security=SSPI;";
            SqlConnection dbConnection = new SqlConnection(connectionStr);
            dbConnection.Open();

            //Создание обьекта команды SQL
            string sqlQuery = "INSERT INTO Categories (Name) VALUES ('Лаб 1')"; //-добавляем в таблицу данные
            using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))

                //Отправляем команду
                command.ExecuteNonQuery();
            this.categoriesTableAdapter.Fill(this.aviaPromDataSet.Categories); //имя адаптера и набора данных будет зависеть от названия базы данных, указанной при подключении

            //Закрываем соединение с базой данных
            dbConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Создание открытого подключения
            string connectionStr = "Data Source=KB37-122-C12" + "\\" + "SQLEXPRESS;Initial Catalog=AviaProm;Integrated Security=SSPI;";
            SqlConnection dbConnection = new SqlConnection(connectionStr);
            dbConnection.Open();

            //Создание объекта команды SQL
            string sqlQuery = "DELETE FROM Categories WHERE Name='Лаб 1'";
            using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))

                //Отправляем команду
                command.ExecuteNonQuery();
            this.categoriesTableAdapter.Fill(this.aviaPromDataSet.Categories); //имя адаптера и набора данных будет зависеть от названия базы данных, указанной при подключении

            //Закрываем соединение с базой данных
            dbConnection.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Создание открытого подключения
            string connectionStr = "Data Source=KB37-122-C12" + "\\" + "SQLEXPRESS;Initial Catalog=AviaProm;Integrated Security=SSPI;";
            SqlConnection dbConnection = new SqlConnection(connectionStr);
            dbConnection.Open();

            //Создание обьекта команды SQL
            string sqlQuery = "INSERT INTO Categories (id_Category,Name) VALUES ('2','Шасси')"; //-добавляем в таблицу данные
            using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))

                //Отправляем команду
                command.ExecuteNonQuery();
            this.categoriesTableAdapter.Fill(this.aviaPromDataSet.Categories); //имя адаптера и набора данных будет зависеть от названия базы данных, указанной при подключении

            //Закрываем соединение с базой данных
            dbConnection.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Создание открытого подключения
            string connectionStr = "Data Source=KB37-122-C12" + "\\" + "SQLEXPRESS;Initial Catalog=AviaProm;Integrated Security=SSPI;";
            SqlConnection dbConnection = new SqlConnection(connectionStr);
            dbConnection.Open();

            //Создание объекта команды SQL
            string sqlQuery = "DELETE FROM Categories WHERE Name='Шасси'";
            using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))

                //Отправляем команду
                command.ExecuteNonQuery();
            this.categoriesTableAdapter.Fill(this.aviaPromDataSet.Categories); //имя адаптера и набора данных будет зависеть от названия базы данных, указанной при подключении

            //Закрываем соединение с базой данных
            dbConnection.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Создание открытого подключения
            string connectionStr = "Data Source=KB37-122-C12" + "\\" + "SQLEXPRESS;Initial Catalog=AviaProm;Integrated Security=SSPI;";
            SqlConnection dbConnection = new SqlConnection(connectionStr);
            dbConnection.Open();

            //Создание обьекта команды SQL
            string sqlQuery = "INSERT INTO Categories (Name) VALUES ('Тест1')"; //-добавляем в таблицу данные
            using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))

                //Отправляем команду
                command.ExecuteNonQuery();
            this.categoriesTableAdapter.Fill(this.aviaPromDataSet.Categories); //имя адаптера и набора данных будет зависеть от названия базы данных, указанной при подключении

            //Закрываем соединение с базой данных
            dbConnection.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Создание открытого подключения
            string connectionStr = "Data Source=KB37-122-C12" + "\\" + "SQLEXPRESS;Initial Catalog=AviaProm;Integrated Security=SSPI;";
            SqlConnection dbConnection = new SqlConnection(connectionStr);
            dbConnection.Open();

            //Создание объекта команды SQL
            string sqlQuery = "DELETE FROM Categories WHERE Name='Тест1'";
            using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))

                //Отправляем команду
                command.ExecuteNonQuery();
            this.categoriesTableAdapter.Fill(this.aviaPromDataSet.Categories); //имя адаптера и набора данных будет зависеть от названия базы данных, указанной при подключении

            //Закрываем соединение с базой данных
            dbConnection.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Создание открытого подключения
            string connectionStr = "Data Source=KB37-122-C12" + "\\" + "SQLEXPRESS;Initial Catalog=AviaProm;Integrated Security=SSPI;";
            SqlConnection dbConnection = new SqlConnection(connectionStr);
            dbConnection.Open();

            //Создание обьекта команды SQL
            string sqlQuery = "INSERT INTO Categories (Name) VALUES ('СтендДамкрат')"; //-добавляем в таблицу данные
            using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))

                //Отправляем команду
                command.ExecuteNonQuery();
            this.categoriesTableAdapter.Fill(this.aviaPromDataSet.Categories); //имя адаптера и набора данных будет зависеть от названия базы данных, указанной при подключении

            //Закрываем соединение с базой данных
            dbConnection.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Создание открытого подключения
            string connectionStr = "Data Source=KB37-122-C12" + "\\" + "SQLEXPRESS;Initial Catalog=AviaProm;Integrated Security=SSPI;";
            SqlConnection dbConnection = new SqlConnection(connectionStr);
            dbConnection.Open();

            //Создание объекта команды SQL
            string sqlQuery = "DELETE FROM Categories WHERE Name='СтендДамкрат'";
            using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))

                //Отправляем команду
                command.ExecuteNonQuery();
            this.categoriesTableAdapter.Fill(this.aviaPromDataSet.Categories); //имя адаптера и набора данных будет зависеть от названия базы данных, указанной при подключении

            //Закрываем соединение с базой данных
            dbConnection.Close();

        }
    }
}
