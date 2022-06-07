using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chef_administrator
{
    /// <summary>
    /// Логика взаимодействия для AddDishes.xaml
    /// </summary>
    public partial class AddDishes : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        public string s;
        public string s1;
        public string s2;
        public string s3;


        System.Data.DataTable ingredTable;

        public AddDishes()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            goodsGrid.RowEditEnding += GoodsGrid_RowEditEnding;
        }
        private void GoodsGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            UpdateDB();
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Ingredients";
            ingredTable = new System.Data.DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);

                adapter = new SqlDataAdapter(command);

                // установка команды на добавление для вызова хранимой процедуры
                adapter.InsertCommand = new SqlCommand("sp_InsertIngred", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@count", SqlDbType.Float, 0, "Count"));


                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                connection.Open();
                adapter.Fill(ingredTable);
                goodsGrid.ItemsSource = ingredTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            SqlCommand command4 = new SqlCommand("select Name from Category", connection);
            connection.Open();
            DbDataReader reader = command4.ExecuteReader();
            while (reader.Read())
            {
                TypeList.Items.Add((string)reader["Name"]);
            }
            connection.Close();
        }
      
        private void UpdateDB()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter);
            adapter.Update(ingredTable);
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }
        private void textBoxManafacture_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonAdd_Click_8(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = null;
            var amount = Convert.ToInt32(textBoxCount.Text);
            var price = float.Parse(textBoxPrice.Text, CultureInfo.InvariantCulture);
            var name = textBoxName.Text;
            var type = s;
            var type1 = s1;
            var type2 = s2;
            var type3 = s3;
            var value = float.Parse(textBoxWeight.Text, CultureInfo.InvariantCulture);
            var name1 = TypeList3.Text;

            string query = $"INSERT INTO Dishes(Name, Weight, Price, Amount, Category) values('{name}','{value}','{price}','{amount}','{type}')";




            /*            string sql = $"DELETE FROM Ingredients WHERE Name = '{type1}';";
                        connection = new SqlConnection(connectionString);
                        SqlCommand command1 = new SqlCommand(sql, connection);
                        adapter = new SqlDataAdapter(command1);
                        connection.Open();
                        ingredTable.Clear();
                        adapter.Fill(ingredTable);
                        connection = new SqlConnection(connectionString);


                        string sql1 = $"DELETE FROM Ingredients WHERE Name = '{type2}';";
                        connection = new SqlConnection(connectionString);
                        SqlCommand command2 = new SqlCommand(sql, connection);
                        adapter = new SqlDataAdapter(command1);
                        connection.Open();
                        ingredTable.Clear();
                        adapter.Fill(ingredTable);
                        connection = new SqlConnection(connectionString);*/

            //если ингредиенты исп то минусует количество созданных блюд
            string sql = $"UPDATE Ingredients SET Count=Count-{amount} WHERE Count>0 AND Name='{type1}';";
            connection = new SqlConnection(connectionString);
            SqlCommand command1 = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command1);
            connection.Open();
            ingredTable.Clear();
            adapter.Fill(ingredTable);
            connection = new SqlConnection(connectionString);


            string sql2 = $"UPDATE Ingredients SET Count=Count-{amount} WHERE Count>0 AND Name='{type2}';";
            connection = new SqlConnection(connectionString);
            SqlCommand command2 = new SqlCommand(sql2, connection);
            adapter = new SqlDataAdapter(command2);
            connection.Open();
            ingredTable.Clear();
            adapter.Fill(ingredTable);
            connection = new SqlConnection(connectionString);

            string sql3 = $"UPDATE Ingredients SET Count=Count-{amount} WHERE Count>0 AND Name='{type3}';";
            connection = new SqlConnection(connectionString);
            SqlCommand command3 = new SqlCommand(sql3, connection);
            adapter = new SqlDataAdapter(command3);
            connection.Open();
            ingredTable.Clear();
            adapter.Fill(ingredTable);
            connection = new SqlConnection(connectionString);

            //удаляет если элемент 0 ии меньше
            string sql4 = $"DELETE FROM Ingredients WHERE Count=0 AND Count<0 AND Name='{type1}';";
            connection = new SqlConnection(connectionString);
            SqlCommand command4 = new SqlCommand(sql4, connection);
            adapter = new SqlDataAdapter(command4);
            connection.Open();
            ingredTable.Clear();
            adapter.Fill(ingredTable);
            connection = new SqlConnection(connectionString);

            string sql5 = $"DELETE FROM Ingredients WHERE Count=0 AND Count<0 AND Name='{type2}';";
            connection = new SqlConnection(connectionString);
            SqlCommand command5 = new SqlCommand(sql5, connection);
            adapter = new SqlDataAdapter(command5);
            connection.Open();
            ingredTable.Clear();
            adapter.Fill(ingredTable);
            connection = new SqlConnection(connectionString);

            string sql6 = $"DELETE FROM Ingredients WHERE Count=0 AND Count<0 AND Name='{type3}';";
            connection = new SqlConnection(connectionString);
            SqlCommand command6 = new SqlCommand(sql6, connection);
            adapter = new SqlDataAdapter(command6);
            connection.Open();
            ingredTable.Clear();
            adapter.Fill(ingredTable);
            connection = new SqlConnection(connectionString);

            //Проверка на сущ элемент
            DataTable table = new DataTable();
            string sql7 = $"SELECT * FROM Ingredients WHERE Name = '{type1}'";
            SqlCommand command7 = new SqlCommand(sql7, connection);
            adapter.SelectCommand = command7;
            adapter.Fill(table);

            DataTable table1 = new DataTable();
            string sql8 = $"SELECT * FROM Ingredients WHERE Name = '{type2}'";
            SqlCommand command8 = new SqlCommand(sql8, connection);
            adapter.SelectCommand = command8;
            adapter.Fill(table1);

            DataTable table2 = new DataTable();
            string sql9 = $"SELECT * FROM Ingredients WHERE Name = '{type3}'";
            SqlCommand command9 = new SqlCommand(sql9, connection);
            adapter.SelectCommand = command9;
            adapter.Fill(table2);

            connection = new SqlConnection(connectionString);


            /*string sql8 = $"SELECT * FROM Ingredients WHERE Result LIKE '%{type2}%'";
            string sql9 = $"SELECT * FROM Ingredients WHERE Result LIKE  %{type3}%'";*/
            //string sql7 = $"SELECT * FROM Ingredients WHERE Name = '{type1}'";


            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();




            if ( table.Rows.Count == 1 && table1.Rows.Count == 1 && table2.Rows.Count == 1)
            {
                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Товар успешно создан", "Успех!");
                    Dishes good = new Dishes();
                    good.Show();
                    this.Close();
                }
             
            }
            else
            {
                MessageBox.Show("Товар не создан тк как у вас нет ингериентов");


            }

        }



        private void TypeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // var item = (ComboBoxItem)TypeList.SelectedValue;
            string selectedState = TypeList.SelectedItem.ToString();
            s = selectedState;
        }

        private void TypeList_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            var item = (ComboBoxItem)TypeList4.SelectedValue;
            s2 = (string)item.Content;
        }

        private void TypeList_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            var item = (ComboBoxItem)TypeList3.SelectedValue;
            s1 = (string)item.Content;
        }

        private void TypeList_SelectionChanged3(object sender, SelectionChangedEventArgs e)
        {
            var item = (ComboBoxItem)TypeList5.SelectedValue;
            s3 = (string)item.Content;
        }

        private void textBoxCount_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ButtonAdd_Click_9(object sender, RoutedEventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Close();
        }
    }
}
