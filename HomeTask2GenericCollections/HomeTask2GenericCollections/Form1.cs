using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask2GenericCollections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ProductscheckedListBox.Items.Clear();

            for (int i = 0; i < Warehouse.ProductsFromMeat.Count; i++)
            {
                ProductscheckedListBox.Items.Add(Warehouse.ProductsFromMeat[i]);
            }

            //ProductType type = new Baking("", 120, new DateTime(2019,10,10), 25, FromWhat.Buckwheat);
            //Baking baking = new Baking();
            //Warehouse.productTypes.Add(baking);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ProductscheckedListBox.Items.Clear();

            for (int i = 0; i < Warehouse.ProductsFromMilk.Count; i++)
            {
                ProductscheckedListBox.Items.Add(Warehouse.ProductsFromMilk[i]);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ProductscheckedListBox.Items.Clear();
            for (int i = 0; i < Warehouse.BakingProducts.Count; i++)
            {
                ProductscheckedListBox.Items.Add(Warehouse.BakingProducts[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MeatcheckBox.Visible = true;
            MilkcheckBox.Visible = true;
            BakingcheckBox.Visible = true;
            //ProductType produtType = new Baking("Cookies", 48, new DateTime(2019, 10, 10), 30, FromWhat.Wheat);
            //Warehouse.SomeName.ListOfProducts.Add(productType);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ProductscheckedListBox.Items.Clear();
            for (int i = 0; i < Warehouse.SomeName.ListOfProducts.Count; i++)
            {
                ProductscheckedListBox.Items.Add(Warehouse.SomeName.ListOfProducts[i].ToString());
            }
            ItemsCounter.Text = Convert.ToString(Warehouse.SomeName.ListOfProducts.Count);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Warehouse.BakingProducts.Count; i++)
            {
                Warehouse.SomeName.ListOfProducts.Add(Warehouse.BakingProducts[i]);
            }
            for (int i = 0; i < Warehouse.ProductsFromMilk.Count; i++)
            {
                Warehouse.SomeName.ListOfProducts.Add(Warehouse.ProductsFromMilk[i]);
            }
            for (int i = 0; i < Warehouse.ProductsFromMeat.Count; i++)
            {
                Warehouse.SomeName.ListOfProducts.Add(Warehouse.ProductsFromMeat[i]);
            }
            button6.Enabled = false;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            MeatChoise();

        }

        private void MilkcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MilkChoise();

        }

        private void BakingcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BakingChoise();
        }
        private void MeatChoise()
        {
            if (MeatcheckBox.Checked == true)
            {
                MilkcheckBox.Enabled = false;
                BakingcheckBox.Enabled = false;
                AddProductName.Visible = true;
                AddProductPrice.Visible = true;
                AddProductEx.Visible = true;
                monthCalendar1.Visible = true;
                AddProductFrom.Visible = true;
                ProductNameLabel.Visible = true;
                ProductPriceLabel.Visible = true;
                ProductDateOfManufactureLabel.Visible = true;
                ProductConditionalLabel.Visible = true;
                ProductExpirationLabel.Visible = true;
                ProductConditionalLabel.Text = "Conditional of Meat";
                AddProductFrom.Items.Add(Meat.Chicken);
                AddProductFrom.Items.Add(Meat.Fish);
                AddProductFrom.Items.Add(Meat.Pork);
                AddProductFrom.Items.Add(Meat.Veal);
                AddProductButton.Text = $"Add Meat {AddProductFrom.Text}";

            }
            else if(MeatcheckBox.Checked == false)
            {
                AddProductFrom.Items.Clear();
                MilkcheckBox.Enabled = true;
                BakingcheckBox.Enabled = true;
                AddProductName.Visible = false;
                AddProductPrice.Visible = false;
                AddProductEx.Visible = false;
                monthCalendar1.Visible = false;
                AddProductFrom.Visible = false;
                ProductNameLabel.Visible = false;
                ProductPriceLabel.Visible = false;
                ProductDateOfManufactureLabel.Visible = false;
                ProductConditionalLabel.Visible = false;
                ProductExpirationLabel.Visible = false;
                ProductConditionalLabel.Text = "Conditional";
                AddProductButton.Text = $" ";

            }

        }
        private void MilkChoise()
        {
            if (MilkcheckBox.Checked == true)
            {
                MeatcheckBox.Enabled = false;
                BakingcheckBox.Enabled = false;
                AddProductName.Visible = true;
                AddProductPrice.Visible = true;
                AddProductEx.Visible = true;
                monthCalendar1.Visible = true;
                MassValue.Visible = true;
                ProductNameLabel.Visible = true;
                ProductPriceLabel.Visible = true;
                ProductDateOfManufactureLabel.Visible = true;
                ProductMassLabel.Visible = true;
                ProductExpirationLabel.Visible = true;
                AddProductButton.Text = $"Add Dairy Product";

            }
            else if(MilkcheckBox.Checked == false)
            {
                AddProductFrom.Items.Clear();
                MeatcheckBox.Enabled = true;
                BakingcheckBox.Enabled = true;
                AddProductName.Visible = false;
                AddProductPrice.Visible = false;
                AddProductEx.Visible = false;
                monthCalendar1.Visible = false;
                AddProductFrom.Visible = false;
                MassValue.Visible = false;
                ProductNameLabel.Visible = false;
                ProductPriceLabel.Visible = false;
                ProductDateOfManufactureLabel.Visible = false;
                ProductMassLabel.Visible = false;
                ProductExpirationLabel.Visible = false;
                AddProductButton.Text = $" ";

            }

        }
        private void BakingChoise()
        {
            if (BakingcheckBox.Checked == true)
            {
                MilkcheckBox.Enabled = false;
                MeatcheckBox.Enabled = false;
                AddProductName.Visible = true;
                AddProductPrice.Visible = true;
                AddProductEx.Visible = true;
                monthCalendar1.Visible = true;
                AddProductFrom.Visible = true;
                ProductNameLabel.Visible = true;
                ProductPriceLabel.Visible = true;
                ProductDateOfManufactureLabel.Visible = true;
                ProductConditionalLabel.Visible = true;
                ProductConditionalLabel.Text = "Baking variety";
                ProductExpirationLabel.Visible = true;
                AddProductFrom.Items.Add(FromWhat.Buckwheat);
                AddProductFrom.Items.Add(FromWhat.Wheat);
                AddProductButton.Text = $"Add Baking from {AddProductFrom.Text}";

            }
            else if(BakingcheckBox.Checked == false)
            {
                AddProductFrom.Items.Clear();
                MilkcheckBox.Enabled = true;
                MeatcheckBox.Enabled = true;
                AddProductName.Visible = false;
                AddProductPrice.Visible = false;
                AddProductEx.Visible = false;
                monthCalendar1.Visible = false;
                AddProductFrom.Visible = false;
                ProductNameLabel.Visible = false;
                ProductPriceLabel.Visible = false;
                ProductConditionalLabel.Text = "Conditional";
                ProductDateOfManufactureLabel.Visible = false;
                ProductConditionalLabel.Visible = false;
                ProductExpirationLabel.Visible = false;
                AddProductButton.Text = $" ";

            }

        }
       
        private void AddProductButton_Click(object sender, EventArgs e)
        {
           
                if (AddProductName.Text != string.Empty &&  
                    Convert.ToString(AddProductPrice.Value) != string.Empty && 
                    Convert.ToString(AddProductEx.Value) != string.Empty)
                { 
                    if (MeatcheckBox.Checked == true)
                    {
                        ProductType MeatProduct = new MeatProducts(AddProductName.Text, (int)AddProductPrice.Value, 
                            monthCalendar1.SelectionStart, (int)AddProductEx.Value, Find(AddProductFrom));
                        Warehouse.SomeName.ListOfProducts.Add(MeatProduct);
                        Warehouse.ProductsFromMeat.Add((MeatProducts)MeatProduct);
                    }
                    if (BakingcheckBox.Checked == true)
                    {
                        ProductType BakingProdukt = new Baking(AddProductName.Text, (int)AddProductPrice.Value, 
                            monthCalendar1.SelectionStart, (int)AddProductEx.Value, FindFromWhat(AddProductFrom));
                        Warehouse.SomeName.ListOfProducts.Add(BakingProdukt);
                        Warehouse.BakingProducts.Add((Baking)BakingProdukt);
                    }
                    if (MilkcheckBox.Checked == true)
                    {
                        ProductType dairy_Products = new Dairy_Products(AddProductName.Text, (int)AddProductPrice.Value, 
                            monthCalendar1.SelectionStart, (int)AddProductEx.Value, (int)MassValue.Value);
                        Warehouse.SomeName.ListOfProducts.Add(dairy_Products);
                        Warehouse.ProductsFromMilk.Add((Dairy_Products)dairy_Products);
                    }
                    AddProductName.Text = null;
                    AddProductName.Visible = false;
                    AddProductPrice.Visible = false;
                    AddProductPrice.Value =0;
                    AddProductEx.Visible = false;
                    AddProductEx.Value = 0;
                    monthCalendar1.Visible = false;
                    AddProductFrom.Visible = false;
                    AddProductFrom.Text = " ";
                    MeatcheckBox.Visible = false;
                    MilkcheckBox.Visible = false;
                    BakingcheckBox.Visible = false;
                    MassValue.Visible = false;
                    MassValue.Value = 0;
                }
                else
                {
                    MessageBox.Show("Somethig went wrongg");
                }
          
        }
        private Meat Find(ComboBox comboBox)
        {
            Meat meat = Meat.Pork; 
           if(comboBox.Text == $"{Meat.Chicken}")
            {
                meat = Meat.Chicken;
            }
           else if(comboBox.Text == $"{Meat.Fish}")
            {
                meat = Meat.Fish;
            }
            else if (comboBox.Text == $"{Meat.Pork}")
            {
                meat = Meat.Pork;
            }
            else if (comboBox.Text == $"{Meat.Veal}")
            {
                meat = Meat.Veal;
            }
            return meat;
        }
        private FromWhat FindFromWhat(ComboBox comboBox)
        {
            FromWhat fromWhat = FromWhat.Wheat;
           if(comboBox.Text == $"{FromWhat.Buckwheat}")
            {
                fromWhat = FromWhat.Buckwheat;
            }
           else if(comboBox.Text == $"{FromWhat.Wheat}")
            {
                fromWhat = FromWhat.Wheat;
            }
            return fromWhat;


        }
        DateTime date = new DateTime(2019, 10, 14);
        private void NextDayButton_Click(object sender, EventArgs e)
        {
            
            checkedListBox1.Items.Clear();
            DateLabel.Text = Convert.ToString(date = date.AddDays(1));
            checkedListBox1.Items.Clear();
            for (int i = 0; i < Warehouse.SomeName.ListOfProducts.Count; i++)
            {
                if (Warehouse.SomeName.ListOfProducts[i].To_Consume_Untill.Day - date.Day == 1)
                {
                    //DateLabel.Text = $"{Warehouse.SomeName.ListOfProducts[i].ToString()}";
                    checkedListBox1.Items.Add(Warehouse.SomeName.ListOfProducts[i]);
                }
                else if (Warehouse.SomeName.ListOfProducts[i].To_Consume_Untill.Day < date.Day)
                {
                    Warehouse.SomeName.ListOfProducts.Remove(Warehouse.SomeName.ListOfProducts[i]);

                }
            }



        }

        private void DateLabel_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void DateLabel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DateLabel.Text = Convert.ToString(date);
        }
    }




    }
