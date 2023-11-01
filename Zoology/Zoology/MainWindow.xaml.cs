using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Zoology
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection conn;
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Zoology.Properties.Settings.TiyitorialsDBConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            ShowZoos();
            ShowAnimals();

        }

        private void ShowZoos()
        {
            try
            {
                string query = "SELECT * FROM Zoo";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                using (adapter)
                {
                    DataTable zooTable = new DataTable();
                    adapter.Fill(zooTable);
                    ListZoos.DisplayMemberPath = "Location";
                    ListZoos.SelectedValuePath = "Id";
                    ListZoos.ItemsSource = zooTable.DefaultView;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        

        }


        private void ShowAnimals()
        {
            try
            {
                string query = "SELECT * FROM Animal";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                using (adapter)
                {
                    DataTable animalTable = new DataTable();
                    adapter.Fill(animalTable);
                    ListAnimals.DisplayMemberPath = "Name";
                    ListAnimals.SelectedValuePath = "Id";
                    ListAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void ListZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedAnimals();
        }

        private void ShowAssociatedAnimals()
        {
            try
            {
                string query = "SELECT Animal.Name FROM Animal inner join ZooAnimal on Animal.Id = ZooAnimal.AnimalId Where ZooAnimal.ZooId = @ZooId";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                using (adapter)
                {
                    command.Parameters.AddWithValue("@ZooId",ListZoos.SelectedValue);
                    DataTable zooTable = new DataTable();
                    adapter.Fill(zooTable);
                    ListAssociatedAnimals.DisplayMemberPath = "Name";
                    ListAssociatedAnimals.SelectedValuePath = "Id";
                    ListAssociatedAnimals.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void DeleteZoo()
        {

            try
            {
                string query = "DELETE FROM Zoo where Id = @Id";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("@Id", ListZoos.SelectedValue);
                command.ExecuteScalar();
                conn.Close();
       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddAnimalToZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "INSERT INTO ZooAnimal VALUES (@ZooId,@AnimalId)";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("@ZooId", ListZoos.SelectedValue);
                command.Parameters.AddWithValue("@AnimalId", ListAnimals.SelectedValue);
                command.ExecuteScalar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                ShowAssociatedAnimals();

            }
        }

        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show(ListZoos.SelectedValue.ToString());
            DeleteZoo();
            ShowZoos();
        }

        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string query = "INSERT INTO Zoo VALUES (@Location)";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("@Location",textBox.Text);
                command.ExecuteScalar();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }finally
            { 
                conn.Close();
                ShowZoos();

            }   

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "DELETE FROM ZooAnimal WHERE AnimalId = @AnimalId AND ZooId = @ZooId";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.Parameters.AddWithValue("@AnimalId", ListAnimals.SelectedValue);
                command.Parameters.AddWithValue("@ZooId", ListZoos.SelectedValue);
                command.ExecuteScalar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                ShowAssociatedAnimals();

            }

        }
    }
}
