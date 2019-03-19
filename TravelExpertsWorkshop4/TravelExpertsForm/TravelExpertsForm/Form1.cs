using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsClassLib;

namespace TravelExpertsForm
{
    public partial class MainForm : Form
    {
        protected List<Packages> AllPackages = PackagesDB.GetPackages();
        protected List<Products> AllProducts = ProductsDB.GetProducts();
        protected List<Suppliers> AllSuppliers = SuppliersDB.GetSuppliers();
        protected List<ProSup> ProSupLinkages = ProSupDB.GetProSups();
        protected List<PacProSup> PacProSupLinkages = PacProSupDB.GetPacProSup() ;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductsBindingSource.DataSource = AllProducts;
            ProductsCB.DataSource = ProductsBindingSource;
            ProductsCB.DisplayMember = "ProdName";
            ProductsCB.ValueMember = "ProductId";
        }
    }
}
