using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Economic
{
    public partial class InputData : Form
    {
        public DataForInput data;

        public InputData()
        {
            InitializeComponent();
            data = new DataForInput();
            dataGridView1.Visible = false;
            button1.Visible = false;
            this.Width = 383;
            this.Height = 139;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.startingInvestments = Convert.ToInt64(dataGridView1[1, 0].Value.ToString());
            data.discountRate = Convert.ToInt64(dataGridView1[1, 1].Value.ToString());
            data.horizonOfCalculationOfTheProject = Convert.ToInt64(numericUpDown1.Value.ToString());
            for (int i = 0; i < Convert.ToInt64(numericUpDown1.Value.ToString()); i++)
            {
                data.inflowOfMeansInTheAllYears[i] = Convert.ToInt64(dataGridView1[1, 2+i].Value.ToString());
            }
            for (int i = 0; i < Convert.ToInt64(numericUpDown1.Value.ToString()); i++)
            {
                data.outflowOfFundsInTheAllYears[i] = Convert.ToInt64(dataGridView1[1, 2 + Convert.ToInt32(numericUpDown1.Value.ToString()) + i].Value.ToString());
            }       
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 383;
            this.Height = 479;
            dataGridView1.Rows.Clear();
            data.horizonOfCalculationOfTheProject = Convert.ToInt64(numericUpDown1.Value);
            dataGridView1.Visible = true;
            button1.Visible = true;
            foreach (Map entry in data.getData())
            {
                dataGridView1.Rows.Add(entry.name, entry.value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Width = 383;
            this.Height = 479;
            dataGridView1.Rows.Clear();
            numericUpDown1.Value = 3;
            data.horizonOfCalculationOfTheProject = 3;
            dataGridView1.Visible = true;
            button1.Visible = true;
            foreach (Map entry in data.getExample())
            {
                dataGridView1.Rows.Add(entry.name, entry.value);
            }
        }
    }
}
