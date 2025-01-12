using CSharpEgitimKapmi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKapmi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=ARSALANKHROUSH7;Initial Catalog=EgitimKampi501Db;Integrated Security=True");

        private async void btnList_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TblProduct";
            var values = await conn.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TblProduct VALUES (@name, @stock, @price, @category)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", txtProductName.Text);
            parameters.Add("@stock", txtStock.Text);
            parameters.Add("@price", txtPrice.Text);
            parameters.Add("@category", txtCategory.Text);
            await conn.ExecuteAsync(query, parameters);
            MessageBox.Show("Product added successfully!");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM TblProduct WHERE ProductId = @id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", txtProductId.Text);
            await conn.ExecuteAsync(query, parameters);
            MessageBox.Show("Product deleted successfully!");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TblProduct SET ProductName = @name, ProductStock = @stock, ProductPrice = @price, ProductCategory = @category WHERE ProductId = @id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", txtProductId.Text);
            parameters.Add("@name", txtProductName.Text);
            parameters.Add("@stock", txtStock.Text);
            parameters.Add("@price", txtPrice.Text);
            parameters.Add("@category", txtCategory.Text);
            await conn.ExecuteAsync(query, parameters);
            MessageBox.Show("Product updated successfully!");
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query = "select count(*) from TblProduct";
            var count = await conn.QueryFirstOrDefaultAsync<int>(query);
            lblTotalProductCount.Text = count.ToString();

            var query2 = "select ProductName from TblProduct Where ProductPrice = (Select MAx(ProductPrice) From TblProduct)";
            var maxPriceProduct = await conn.QueryFirstOrDefaultAsync<string>(query2);
            lblMaxPriceProductName.Text = maxPriceProduct;

            var query3 = "select Count(Distinct ProductCategory) from TblProduct";
            var distinctCategoryCount = await conn.QueryFirstOrDefaultAsync<int>(query3);
            lblDistinctCategoryCount.Text = distinctCategoryCount.ToString();
        }
    }
}
