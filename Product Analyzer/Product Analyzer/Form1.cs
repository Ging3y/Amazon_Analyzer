using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;



namespace Product_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void importFile(string path_, ref List<Product> productList_)
        {
            int position;
            string product;
            string link;
            string brand;
            int sellers;
            int variations;
            double price;
            string category;
            int rank;
            int sales;
            double revenue;
            int reviews;
            double rating;
            string type;

            DataTable t = new DataTable();
            string[] test = {"1","2","3","4","5"};
            //productData.DataSource = test;
            //productData.Columns.Add("Me");
            string[] test_product = { "1", "Compact Survival Kit", "Upper Heights Gear", "1", "7", "29.99" };
            productData.Rows.Add(test_product);
            productData.Update();

            string testString = "24.44";
            double result;
            try
            {
                result = Convert.ToDouble(testString);
                MessageBox.Show("Convered the string " + testString + " to a double!");
            }
            catch
            {
                MessageBox.Show("There was an erro");
            }

           // foreach(string element in values)
           

            //var inputFile = new StreamReader(File.OpenRead(path_));
            //while (!reader.EndOfStream)
            //{
            //    var line = reader.ReadLine();
            //    var values = line.Split(',');

            //    try
            //    {
            //        position = Int32.Parse((values[0]));

            //        Product myProduct = new Product(position, "Hammock", "www.mylink.com", "Upper Heights", 3, 24, 34.99, "Outdoor", 3, 441, 21000.44, 74, 3.5, "FBA");
            //        MessageBox.Show(myProduct.toStringFullInfo());
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Failure to load");
            //        position = 0;
            //    }
            //    //MessageBox.Show(position.ToString(), "Header");

            //    //Product myProduct = new Product(position, "Hammock", "www.mylink.com", "Upper Heights", 3, 24, 34.99, "Outdoor", 3, 441, 21000.44, 74, 3.5, "FBA");
            //    //MessageBox.Show(myProduct.toStringFullInfo());

            //    //listA.Add(values[0]);
            //    //listB.Add(values[1]);
            //    // Product myProduct = new Product_Analyzer.Product("Test", 54.99);
            //    // productList_.Add(myProduct);
        }

        FAQ faqPage = new FAQ();
        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code to change window here
            faqPage.Show();
        }

        private void testCreateArray(string path_, ref List<Product> productList_)
        {
            MessageBox.Show("Lets practice son");
            const int COLUMN_LIMIT = 12;

            using (TextFieldParser parser = new TextFieldParser(path_))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    productData.ColumnCount = COLUMN_LIMIT;
                    var headers = new string[COLUMN_LIMIT];

                    //foreach (DataGridViewColumn column in productData.Columns)
                    //{
                    //    foreach (string field in fields)
                    //    {
                    //        headers[0] = field;
                    //    }

                    //    for (int i = 0; i < COLUMN_LIMIT; i++)
                    //    {
                    //        productData.Columns[i].HeaderText = headers[i];
                    //    }
                    //    column.HeaderText = "Bad";
                    //}
                  
                    int i = 0;
                    foreach (string field in fields)
                    {
                        MessageBox.Show(field);
                    }
                }
            }


        }

        //Imports csv file
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Product> productList = new List<Product>();
             
            openFileDialogImport.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";

            if (openFileDialogImport.ShowDialog() == DialogResult.OK)
            {
                string strfilename = openFileDialogImport.InitialDirectory + openFileDialogImport.FileName;

                testCreateArray(strfilename, ref productList);
                //UnComment once practice code is done!
                //importFile(strfilename, ref productList);

                //MessageBox.Show(productList[0].toString(), "Header");
            }
            else
            {
                MessageBox.Show("There was an error inputting the file.", "Header");
            }
        }
    }
}
