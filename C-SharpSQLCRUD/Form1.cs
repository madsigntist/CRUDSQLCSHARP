using System.Linq;

namespace C_SharpSQLCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        ProgrammingClassDataContext db = new ProgrammingClassDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            int prodid = int.Parse(textBox1.Text);
            string itemname = textBox2.Text, design = textBox3.Text, color = comboBox1.Text;
            DateTime modifydate = DateTime.Parse(dateTimePicker1.Text);
            var st = new ProductInfo
            {
                ProductID = prodid,
                ItemName = itemname,
                Design = design,
                Color = color,
                ModifyDate = modifydate,
            };
            db.ProductInfos.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Successfully Inserted");
            loadData();
        }
        //adding method to load data in datagridview
        void loadData()
        {
            var st = from s in db.ProductInfos select s;
            dataGridView1.DataSource = st;
        }
    }
}