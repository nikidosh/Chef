using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для Dishes.xaml
    /// </summary>
    public partial class Dishes : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        System.Data.DataTable dishesTable;
        public Dishes()
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
            string sql = "SELECT * FROM Dishes";
            dishesTable = new System.Data.DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);

                adapter = new SqlDataAdapter(command);

                // установка команды на добавление для вызова хранимой процедуры
                adapter.InsertCommand = new SqlCommand("sp_InsertDish", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@weight", SqlDbType.Float, 0, "Weight"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.Float, 0, "Price"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@amount", SqlDbType.Float, 0, "Amount"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@category", SqlDbType.Float, 0, "Category"));

                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                connection.Open();
                adapter.Fill(dishesTable);
                goodsGrid.ItemsSource = dishesTable.DefaultView;
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
        }
        private void UpdateDB()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter);
            adapter.Update(dishesTable);
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (goodsGrid.SelectedItems != null)
            {
                for (int i = 0; i < goodsGrid.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = goodsGrid.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            UpdateDB();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = null;
            string sql = "SELECT * FROM Dishes ORDER BY Price";
            connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command);
            connection.Open();
            dishesTable.Clear();
            adapter.Fill(dishesTable);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = null;
            string sql = "SELECT * FROM Dishes ORDER BY Weight";
            connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command);
            connection.Open();
            dishesTable.Clear();
            adapter.Fill(dishesTable);
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string search = textBoxSearch.Text.Trim();
            SqlConnection connection = null;
            string sql = $"SELECT * FROM Dishes WHERE Name LIKE '%{search}%'";
            connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command);
            connection.Open();
            dishesTable.Clear();
            adapter.Fill(dishesTable);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            AddDishes obj = new AddDishes();
            obj.Show();
            this.Close();
        }
    }
}
