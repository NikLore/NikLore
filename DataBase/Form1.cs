using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic;
using LiveCharts;
using LiveCharts.Wpf;

namespace DataBase
{
    public partial class Form1 : Form
    {
        string connectionString = @"Provider=Microsoft.Jet.OleDb.4.0;Data Source = auto1.mdb";

        OleDbConnection connection;

        public Form1()
        {
            InitializeComponent();
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connectionString);            connection.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            string commandString = "SELECT * FROM [Клиенты]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandString, connection);            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView2.DataSource = table;
        }

        private void btn_input_t1_Click(object sender, EventArgs e)
        {
            string inpName = Microsoft.VisualBasic.Interaction.InputBox("Введите ФИО клиента");
            string inpPhone = Microsoft.VisualBasic.Interaction.InputBox("Введите номер телефона");

            string commandString = $"INSERT INTO [Клиенты] ([ФИО], [Телефон]) VALUES ('{inpName}', '{inpPhone}')";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_upp_t1_Click(object sender, EventArgs e)
        {
            string inpName = Microsoft.VisualBasic.Interaction.InputBox("Введите ФИО клиента");
            string inpPhone = Microsoft.VisualBasic.Interaction.InputBox("Введите номер телефона");

            string commandString = $"UPDATE [Клиенты] SET [Телефон] = '{inpPhone}' WHERE [ФИО] = '{inpName}'";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_del_t1_Click(object sender, EventArgs e)
        {
            string inpName = Microsoft.VisualBasic.Interaction.InputBox("Введите ФИО клиента");

            string commandString = $"DELETE FROM [Клиенты] WHERE [ФИО] = '{inpName}' ";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_sel_t2_Click(object sender, EventArgs e)
        {
            string commandString = "SELECT * FROM [Расчеты с клиентами]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandString, connection);            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btn_inp_t2_Click(object sender, EventArgs e)
        {
            string inpDate = Microsoft.VisualBasic.Interaction.InputBox("Введите дату оказания услуг");
            string inpName = Microsoft.VisualBasic.Interaction.InputBox("Введите ФИО клиента");
            string inpTypeWork = Microsoft.VisualBasic.Interaction.InputBox("Введите тип услуги");
            string inpPrice = Microsoft.VisualBasic.Interaction.InputBox("Введите стоимость");
            string inpName2 = Microsoft.VisualBasic.Interaction.InputBox("Введите ФИО сотрудника");
            
            string commandString = $"INSERT INTO [Расчеты с клиентами] ([Дата оказания], [Клиент], [Тип услуги], [Стоимость работ], [Сотрудник]) VALUES ('{inpDate}', '{inpName}', '{inpTypeWork}', '{inpPrice}', '{inpName2}')";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_upp_t2_Click(object sender, EventArgs e)
        {
            string inpName2 = Microsoft.VisualBasic.Interaction.InputBox("Введите ФИО сотрудника");
            string inpDate = Microsoft.VisualBasic.Interaction.InputBox("Введите дату оказания услуг");

            string commandString = $"UPDATE [Расчеты с клиентами] SET [Дата оказания] = '{inpDate}' WHERE [Сотрудник] = '{inpName2}'";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_del_t2_Click(object sender, EventArgs e)
        {
            string inpName = Microsoft.VisualBasic.Interaction.InputBox("Введите ФИО клиента");

            string commandString = $"DELETE FROM [Расчеты с клиентами] WHERE [Клиент] = '{inpName}' ";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_sel_t3_Click(object sender, EventArgs e)
        {
            string commandString = "SELECT * FROM [Сотрудники]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandString, connection);            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView3.DataSource = table;
        }

        private void btn__inp_t3_Click(object sender, EventArgs e)
        {

            string inpName = Microsoft.VisualBasic.Interaction.InputBox("Введите ФИО");
            string inpPhone = Microsoft.VisualBasic.Interaction.InputBox("Введите номер телефона");
            string inpPosition = Microsoft.VisualBasic.Interaction.InputBox("Введите должность");

            string commandString = $"INSERT INTO [Сотрудники] ([ФИО], [Телефон], [Должность]) VALUES ('{inpName}', '{inpPhone}', '{inpPosition}')";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_upp_t3_Click(object sender, EventArgs e)
        {
            string inpName = Microsoft.VisualBasic.Interaction.InputBox("Введите ФИО");
            string inpPhone = Microsoft.VisualBasic.Interaction.InputBox("Введите номер телефона");

            string commandString = $"UPDATE [Сотрудники] SET [Телефон] = '{inpPhone}' WHERE [ФИО] = '{inpName}'";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void btn_del_t3_Click(object sender, EventArgs e)
        {
            string inpName = Microsoft.VisualBasic.Interaction.InputBox("Введите ФИО");

            string commandString = $"DELETE FROM [Сотрудники] WHERE [ФИО] = '{inpName}' ";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string commandString = "SELECT * FROM [Услуги]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandString, connection);            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView4.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string inpTypeWork = Microsoft.VisualBasic.Interaction.InputBox("Введите тип работ");
            string inpPrice = Microsoft.VisualBasic.Interaction.InputBox("Введите цену");

            string commandString = $"INSERT INTO [Услуги] ([Тип работ], [Цена]) VALUES ('{inpTypeWork}', '{inpPrice}')";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inpTypeWork = Microsoft.VisualBasic.Interaction.InputBox("Введите тип работ");
            string inpPrice = Microsoft.VisualBasic.Interaction.InputBox("Введите цену");

            string commandString = $"UPDATE [Услуги] SET [Цена] = '{inpPrice}' WHERE [Тип работ] = '{inpTypeWork}'";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string inpTypeWork = Microsoft.VisualBasic.Interaction.InputBox("Введите тип работ");

            string commandString = $"DELETE FROM [Услуги] WHERE [Тип работ] = '{inpTypeWork}' ";
            OleDbCommand command = new OleDbCommand(commandString, connection);
            command.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChartValues<int> parabola = new ChartValues<int>();

            List<string> x_values = new List<string>();
            List<string> y_values = new List<string>();

            int[] x = new int[] { -74, -88, -62, -98, -15, -58, -10, 0, 18, 37, 65, 57, 15, 85, 11 };

            for (int i = 0; i < x.Length; i++)
            {
                parabola.Add(x[i] * x[i]);
                x_values.Add(x[i].ToString());
                y_values.Add((x[i] * x[i]).ToString());
            }

            cartesianChart2.AxisX.Clear();
            cartesianChart2.AxisX.Add(new Axis()
            {
                Title = "Ось Х",
                Labels = x_values
            });

            cartesianChart2.AxisY.Clear();
            cartesianChart2.AxisY.Add(new Axis()
            {
                Title = "Ось Y",
                Labels = y_values
            });

            LineSeries line = new LineSeries();
            line.Title = "Кривая";
            line.Values = parabola;

            SeriesCollection series = new SeriesCollection();
            series.Add(line);

            cartesianChart2.Series = series;
            cartesianChart2.LegendLocation = LegendLocation.Top;
        }

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}