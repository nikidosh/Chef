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
    /// Логика взаимодействия для AddCategory.xaml
    /// </summary>
    public partial class AddCategory : Window
    {

        string connectionString;
        SqlDataAdapter adapter;
        System.Data.DataTable ingredTable;
        public AddCategory()
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
        private void UpdateDB()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter);
            adapter.Update(ingredTable);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Category";
            ingredTable = new System.Data.DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);

                adapter = new SqlDataAdapter(command);

                // установка команды на добавление для вызова хранимой процедуры
                adapter.InsertCommand = new SqlCommand("sp_InsertCategor", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));


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

        }

        private void ButtonAdd_Click_8(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = null;
            var name = textBoxName.Text;
           

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);

            connection.Open();


            DataTable table1 = new DataTable();
            string sql8 = $"SELECT * FROM Category WHERE Name ='{name}'";
            SqlCommand command8 = new SqlCommand(sql8, connection);
            adapter.SelectCommand = command8;
            adapter.Fill(table1);

            connection = new SqlConnection(connectionString);


            /*string sql8 = $"SELECT * FROM Ingredients WHERE Result LIKE '%{type2}%'";
            string sql9 = $"SELECT * FROM Ingredients WHERE Result LIKE  %{type3}%'";*/
            //string sql7 = $"SELECT * FROM Ingredients WHERE Name = '{type1}'";

            string query = $"INSERT INTO Category(Name) values('{name}')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();


            if (command.ExecuteNonQuery() == 1)
            {
                
                    MessageBox.Show("Ингредиент создан успешно создан", "Успех!");
                    Category good = new Category();
                    good.Show();
                    this.Close();
                

            }
            else 
            {
                MessageBox.Show("Ингредиент не создан");


            }
            connection.Close();

        
    }

        private void ButtonAdd_Click_9(object sender, RoutedEventArgs e)
        {
            MainMenu a = new MainMenu();
            a.Show();
            this.Close();
        }

        private void ButtonAdd_Click_10(object sender, RoutedEventArgs e)
        {
            Category a = new Category();
            a.Show();
            this.Close();
        }
    }
}
