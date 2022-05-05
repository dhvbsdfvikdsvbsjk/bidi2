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
using System.Windows.Forms.DataVisualization.Charting;

namespace eko
{
    public partial class Form1 : Form
    {
        public static string str = @"Data Source=PK306NEW-5\SQLEXPRESS;Initial Catalog=eko;Integrated Security=True";
        private SqlConnection con = new SqlConnection(str);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ekoDataSet._Субъект_". При необходимости она может быть перемещена или удалена.
            this.субъект_TableAdapter.Fill(this.ekoDataSet._Субъект_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ekoDataSet._УровеньЗагрязнение_". При необходимости она может быть перемещена или удалена.
            this.уровеньЗагрязнение_TableAdapter.Fill(this.ekoDataSet._УровеньЗагрязнение_);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            con.Open();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string uye = $"USE [eko] SELECT[id],[RivStat],[id субъекта],[ConMPC],[Class],[id даты],[id ингридиента]" +
                $"FROM[dbo].[УровеньЗагрязнение$] where[id субъекта] = '" + comboBox1.SelectedValue + "'; ";
            SqlDataAdapter dataadapter = new SqlDataAdapter(uye, str);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "eko");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "eko";
            int ueu = dataGridView1.Rows.Count;
            int sum = 0;
            ueu = ueu - 1;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

            }
            sum = sum / ueu;
            this.textBox1.Text = sum.ToString();
            /*string kol = ($"USE [eko] select avg (ConMPC) from УровеньЗагрязнение$, Субъект$" +
                $"where Субъект$.id = '" + comboBox1.SelectedValue + "' and УровеньЗагрязнение$.[id субъекта]= Субъект$.id ");
            SqlDataAdapter asg = new SqlDataAdapter(kol, str);
            DataSet dsa = new DataSet();
            asg.Fill(dsa, "eko");
            textBox1.Text = asg.ToString();*/
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*int count = dataGridView1.Rows.Cast<DataGridViewRow>()
                   .Select(row => row.Cells[4].Value.ToString())
                   .Count(s => s == "kol");*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Мурманская область")              
            {
                this.chart1.Titles.Add("Мурманская область");
                string[] aa = { "ионы молидбена", "ионы меди" };
                int[] a = { 8, 54 };
                this.chart1.Palette = ChartColorPalette.SeaGreen;
                for (int i = 0; i < aa.Length; i++)
                {
                    Series series = this.chart1.Series.Add(aa[i]);
                    series.Points.Add(a[i]);
                }
                
            }
            else if (comboBox1.Text == "Хабаровский край")
            {
                this.chart1.Titles.Clear();
                this.chart1.Titles.Add("Хабаровский край");
                string[] aa = {"ионы свинца","ионы цинка","ионы мeди","ионы железа общего"};
                int[] a = { 12 + 6, 52, 71, 80};
                this.chart1.Palette = ChartColorPalette.Berry;
                for (int i = 0; i < aa.Length; i++)
                {
                    Series series = this.chart1.Series.Add(aa[i]);
                    series.Points.Add(a[i]);
                }

            }
            else if (comboBox1.Text == "Свердловская область")
            {
                this.chart1.Titles.Clear();
                this.chart1.Titles.Add("Свердловская область");
                string[] aa = {"иoны меди", "ионы марганца", "взвешенные вещества" };
                int[] a = { 69,136+139+72+105,74+69+55+51+67+66};
                this.chart1.Palette = ChartColorPalette.Excel;
                for (int i = 0; i < aa.Length; i++)
                {
                    Series series = this.chart1.Series.Add(aa[i]);
                    series.Points.Add(a[i]);
                }
            }
            else if (comboBox1.Text == "Оренбургская область")
            {
                this.chart1.Titles.Clear();
                this.chart1.Titles.Add("Оренбургская область");
                string[] aa = {"ионы Mеди"};
                int[] a = { 63};
                this.chart1.Palette = ChartColorPalette.SemiTransparent;
                for (int i = 0; i < aa.Length; i++)
                {
                    Series series = this.chart1.Series.Add(aa[i]);
                    series.Points.Add(a[i]);
                }
            }
            else if (comboBox1.Text == "Тюменская область")
            {
                this.chart1.Titles.Clear();
                this.chart1.Titles.Add("Тюменская область");
                string[] aa = {"нефтепродукты"};
                int[] a = { 100 };
                this.chart1.Palette = ChartColorPalette.EarthTones;
                for (int i = 0; i < aa.Length; i++)
                {
                    Series series = this.chart1.Series.Add(aa[i]);
                    series.Points.Add(a[i]);
                }
            }
            else if (comboBox1.Text == "Сахалинская область")
            {
                this.chart1.Titles.Clear();
                this.chart1.Titles.Add("Сахалинская область");
                string[] aa = {"нeфтепродукты"};
                int[] a = { 100 };
                this.chart1.Palette = ChartColorPalette.Grayscale;
                for (int i = 0; i < aa.Length; i++)
                {
                    Series series = this.chart1.Series.Add(aa[i]);
                    series.Points.Add(a[i]);
                }
            }
            else if (comboBox1.Text == "Забайкальский край")
            {
                this.chart1.Titles.Clear();
                this.chart1.Titles.Add("Забайкальский край");
                string[] aa = {"взвешeные вещества"};
                int[] a = { 647 };
                this.chart1.Palette = ChartColorPalette.Pastel;
                for (int i = 0; i < aa.Length; i++)
                {
                    Series series = this.chart1.Series.Add(aa[i]);
                    series.Points.Add(a[i]);
                }
            }
            else if (comboBox1.Text == "Курганская область")
            {
                this.chart1.Titles.Clear();
                this.chart1.Titles.Add("Курганская область");
                string[] aa = { "взвешеные веществa", "aзот алюмминий", 
                    "Легкоокисляемые органические вещества по БПК5", 
                    "Синтетические поверхностно-активные вещества"
                ,"Фосфаты"};
                int[] a = { 69+75+76,201,88,70,70};
                this.chart1.Palette = ChartColorPalette.BrightPastel;
                for (int i = 0; i < aa.Length; i++)
                {
                    Series series = this.chart1.Series.Add(aa[i]);
                    series.Points.Add(a[i]);
                }
            }
            else if (comboBox1.Text == "Магаданская область")
            {
                this.chart1.Titles.Clear();
                this.chart1.Titles.Add("Магаданская область");
                string[] aa = {"ионы маргнацa"};
                int[] a = {57};
                this.chart1.Palette = ChartColorPalette.Light;
                for (int i = 0; i < aa.Length; i++)
                {
                    Series series = this.chart1.Series.Add(aa[i]);
                    series.Points.Add(a[i]);
                }
            }

        }
    }
}
