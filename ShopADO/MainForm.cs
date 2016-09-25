using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using ShopADO.EF;

namespace ShopADO
{
    public partial class MainForm : Form
    {
        private ShopADOContext context;

        public MainForm()
        {
            InitializeComponent();

            context = new ShopADOContext();

            context.Good.Load();
            context.Category.Load();
            context.Manufacturer.Load();

            dgvCategories.DataSource = context.Category.Local.ToBindingList();
            dgvCategories.Columns[0].Visible = false;
            dgvManufacturers.DataSource = context.Manufacturer.Local.ToBindingList();
            dgvGoods.DataSource = context.Good.Local.ToBindingList();
        }

        private void bSave_Click(object sender, System.EventArgs e)
        {
            context.SaveChanges();
        }
    }
}
