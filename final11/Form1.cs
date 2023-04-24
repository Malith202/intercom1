using final11.Model;
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

namespace final11
{
    public partial class User_Form : Form
    {
        List<company> companyList;
        List<cFunction> cFunctionList;
        List<sub_function> subFunctionList;
        CorporationEntities db = new CorporationEntities();


       

        public User_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtSearch.Text = "EPF no";
            sNametextBox.Text = "First Name";
            txtSearch.ForeColor = Color.LightGray;
            sNametextBox.ForeColor = Color.LightGray;

            // TODO: This line of code loads data into the 'corporationDataSet.employe' table. You can move, or remove it, as needed.
            this.employeTableAdapter.Fill(this.corporationDataSet.employe);


            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);


            getCompanyFromDB();
        }

        public void getCompanyFromDB()
        {

            companyList = db.companies.ToList();
            foreach (company item in companyList)
            {
                companyBox1.Items.Add(item.company_name);
            }

        }

        public void getcFunctionFromDB(int selectedCompany)
        {

            cFunctionList = db.cFunctions.Where(F => F.company_id == selectedCompany).ToList();
            functionBox2.Items.Clear();
            foreach (cFunction item in cFunctionList)
            {
                functionBox2.Items.Add(item.function_name);
            }
        }

        public void getsubFunctionFromDB(int selectedcFunction)
        {

            subFunctionList = db.sub_function.Where(SF => SF.function_id == selectedcFunction).ToList();
            sfunctionBox3.Items.Clear();
            foreach (sub_function item in subFunctionList)
            {
                sfunctionBox3.Items.Add(item.sub_function_name);
            }
        }


        private void companyBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            company company = companyList.ElementAt(companyBox1.SelectedIndex);
            getcFunctionFromDB(company.company_id);
        }

        private void functionBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cFunction cFunction = cFunctionList.ElementAt(functionBox2.SelectedIndex);
            getsubFunctionFromDB(cFunction.function_id);
        }

        private void sfunctionBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            sub_function sub_function = subFunctionList.ElementAt(sfunctionBox3.SelectedIndex);


            List<employe> empList1 = db.employes.Where(su => su.sub_function_id == sub_function.sub_function_id).ToList();
            var list = new BindingList<employe>(empList1);
            User_dataGridView.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void sNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EPFsearch_Click(object sender, EventArgs e)
        {

      
                try
                {
                    int strKeyword = int.Parse(txtSearch.Text.Trim().ToString());

                    List<employe> empList1 = db.employes.Where(emp => emp.EPF_no == strKeyword).ToList();
                    var list = new BindingList<employe>(empList1);
                    User_dataGridView.DataSource = list;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid EPF Number");
                }

           
        }

        private SqlConnection SqlConnection(object connectionString)
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String strKeyword = (sNametextBox.Text.Trim().ToString());

                List<employe> empList1 = db.employes.Where(emp => emp.Sname.ToLower().StartsWith(strKeyword)).ToList();
                var list = new BindingList<employe>(empList1);
                User_dataGridView.DataSource = list;
            }
            catch (Exception ex)
            {

            }
        }


        private void text_leave(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "EPF no")
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = Color.Black; 
                
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text == string.Empty)
            {
                txtSearch.Text = "EPF no";
                txtSearch.ForeColor = Color.LightGray;

            }
        }

        private void sNametextBox_Enter(object sender, EventArgs e)
        {
            if(sNametextBox.Text == "First Name")
            {
                sNametextBox.Text = string.Empty;
                sNametextBox.ForeColor = Color.Black;

            }
        }

        private void sNametextBox_Leave(object sender, EventArgs e)
        {
            if (sNametextBox.Text == string.Empty)
            {
                sNametextBox.Text = "First Name";
                sNametextBox.ForeColor = Color.LightGray;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
