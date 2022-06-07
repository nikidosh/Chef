using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chef_administrator
{
    /// <summary>
    /// Логика взаимодействия для AddIngredients.xaml
    /// </summary>
    public partial class AddIngredients : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        System.Data.DataTable ingredTable;
        public AddIngredients()
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
           
        }
      
        private void ButtonAdd_Click_8(object sender, RoutedEventArgs e)
        {

            SqlConnection connection = null;
            var name = textBoxName.Text;
            var count = textBoxWeight.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);

            connection.Open();


            DataTable table1 = new DataTable();
            string sql8 = $"SELECT * FROM Ingredients WHERE Name ='{name}'";
            SqlCommand command8 = new SqlCommand(sql8, connection);
            adapter.SelectCommand = command8;
            adapter.Fill(table1);

            connection = new SqlConnection(connectionString);


            /*string sql8 = $"SELECT * FROM Ingredients WHERE Result LIKE '%{type2}%'";
            string sql9 = $"SELECT * FROM Ingredients WHERE Result LIKE  %{type3}%'";*/
            //string sql7 = $"SELECT * FROM Ingredients WHERE Name = '{type1}'";

            string query = $"INSERT INTO Ingredients(Name, Count) values('{name}','{count}')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();


            if ( table1.Rows.Count != 1)
            {
                if(command.ExecuteNonQuery() == 1 )
                {
                    MessageBox.Show("Ингредиент создан успешно создан", "Успех!");
                    Ingredients good = new Ingredients();
                    good.Show();
                    this.Close();
                    //----------
                    goodsGrid.SelectAllCells();
                    goodsGrid.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
                    ApplicationCommands.Copy.Execute(null, goodsGrid);
                    goodsGrid.UnselectAllCells();
                    var result = (string)Clipboard.GetData(DataFormats.Text);
                    dynamic wordApp = null;
                    try
                    {
                        var sw = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\\отчет.doc");
                        sw.WriteLine(result);
                        sw.Close();
                        //var proc = Process.Start("export.doc");
                        Type wordType = Type.GetTypeFromProgID("Word.Application");
                        wordApp = Activator.CreateInstance(wordType);
                        wordApp.Documents.Add($"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\\отчет.doc");
                        wordApp.ActiveDocument.Range.ConvertToTable(1, goodsGrid.Items.Count, goodsGrid.Columns.Count);
                        MessageBox.Show("Отчет успешно создан! \n Находится на рабочем столе!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        if (wordApp != null)
                        {
                            wordApp.Quit();
                        }
                    }
                }
               
            }
            else if(table1.Rows.Count==1)
            {
                MessageBox.Show("Ингредиент не создан");


            }
            connection.Close();

        }

        private void ButtonAdd_Click_9(object sender, RoutedEventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Close();
        }

        private void ButtonAdd_Click_10(object sender, RoutedEventArgs e)
        {
            Ingredients obj = new Ingredients();
            obj.Show();

        }
     
     
    }
}
