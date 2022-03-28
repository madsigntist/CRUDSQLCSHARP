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
                InsertDate = DateTime.Now,
                ModifyDate = modifydate,
            };
            db.ProductInfos.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Successfully Inserted");
            loadData();
        }
        void loadData()
        {
            var st = from s in db.ProductInfos select s;
            dataGridView1.DataSource = st;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string itemname = textBox2.Text, design = textBox3.Text, color = comboBox1.Text;
            DateTime modifydate = DateTime.Parse(dateTimePicker1.Text);
            var st = (from s in db.ProductInfos where 
                      s.ProductID == int.Parse(textBox1.Text) select s).First();
            st.ItemName = itemname;
            st.Design = design;
            st.Color = color;
            st.ModifyDate = modifydate;
            st.UpdateDate = DateTime.Now;
            db.SubmitChanges();
            MessageBox.Show("Update Successful");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var st = from s in db.ProductInfos where 
                     s.ProductID == int.Parse(textBox1.Text) select s;
            dataGridView1.DataSource = st;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This cannot be undone, are you sure?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var st = (from s in db.ProductInfos where 
                      s.ProductID == int.Parse(textBox1.Text) select s).First();
                db.ProductInfos.DeleteOnSubmit(st);
                db.SubmitChanges();
                MessageBox.Show("Record Deleted");
                loadData();
            }
        }
    }
}