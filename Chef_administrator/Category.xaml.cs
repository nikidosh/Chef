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
    /// Логика взаимодействия для Category.xaml
    /// </summary>
    public partial class Category : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        System.Data.DataTable categorTable;
        public Category()
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
            string sql = "SELECT * FROM Category";
            categorTable = new System.Data.DataTable();
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


                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                connection.Open();
                adapter.Fill(categorTable);
                goodsGrid.ItemsSource = categorTable.DefaultView;
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
            adapter.Update(categorTable);
        }
    

        private void updateButton_Click1(object sender, RoutedEventArgs e)
        {
            MainMenu a = new MainMenu();
            a.Show();
            this.Close();
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

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void updateButton_Click2(object sender, RoutedEventArgs e)
        {
            AddCategory obj=new AddCategory();
            obj.Show();
            this.Close();
        }
    }
}
