using System;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using Lab2Economic.Properties;


namespace Lab2Economic
{
    public partial class Form1 : Form
    {
        InputData inputData;
        Theory theory;
        private double ii;
        private double[] NPVmass;
        private double PBP;
        private double IRR;
        Series mySeriesOfPoint;
        Series mySeriesOfPoint1;


        private int numberRound = 3;

        public Form1()
        {
            InitializeComponent();
            inputData = new InputData();
            theory = new Theory();
            setVisibleMainMenu(false, true);
        }

        private void теорияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputData.ShowDialog();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-----------------------------------R--------------------------------
            double[] R = new double[inputData.data.horizonOfCalculationOfTheProject + 1];
            R[0] = 0;
            for (int i = 1; i < inputData.data.horizonOfCalculationOfTheProject + 1; i++)
            {
                R[i] = (inputData.data.inflowOfMeansInTheAllYears[i-1] - inputData.data.outflowOfFundsInTheAllYears[i-1]) /
                    Math.Pow((1 + (inputData.data.discountRate / 100d)), (i));
                dataGridView1.Rows.Add("R[" + (i) + "]", Math.Round(R[i], numberRound));
            }
            //---------------------------------------------------------------------

            //-----------------------------------NPV-------------------------------
            double NPV = 0;
            for (int i = 1; i < inputData.data.horizonOfCalculationOfTheProject + 1; i++)
            {
                NPV += R[i];
               
            }
            NPV -= inputData.data.startingInvestments;
            label2.Text = Math.Round(NPV, numberRound).ToString();
            //---------------------------------------------------------------------

            //----------------------------------ROI-----------------------------------
            double ROI = (NPV / inputData.data.startingInvestments) * 100d;
            label3.Text = Math.Round(ROI, numberRound).ToString();
            //----------------------------------------------------------------------

            //----------------------------------PI--------------------------------------
            double PI = 0;
            for (int i = 0; i < inputData.data.horizonOfCalculationOfTheProject; i++)
            {
                PI += (inputData.data.inflowOfMeansInTheAllYears[i] - inputData.data.outflowOfFundsInTheAllYears[i]) /
                    Math.Pow((1 + (inputData.data.discountRate / 100d)), (i + 1));

            }
            PI /= inputData.data.startingInvestments;
            label5.Text = Math.Round(PI, numberRound).ToString();
            //-------------------------------------------------------------------------

            //--------------------------------NPV-------------------------------------
            NPVmass = new double[inputData.data.horizonOfCalculationOfTheProject+1];
            NPVmass[0] = -inputData.data.startingInvestments;
            for (int i = 1; i < inputData.data.horizonOfCalculationOfTheProject+1; i++)
            {
                NPVmass[i] = NPVmass[i - 1] + R[i];
                dataGridView1.Rows.Add("NPV[" + (i-1) + "]", Math.Round(NPVmass[i-1], numberRound));
            }
            dataGridView1.Rows.Add("NPV[" + (inputData.data.horizonOfCalculationOfTheProject) + "]", Math.Round(NPVmass[inputData.data.horizonOfCalculationOfTheProject], numberRound));
            //------------------------------------------------------------------------

            //------------------------------k(ГОД ОКУПАЕМОСТИ)--------------------------
            int k = 0;
            for (int i = 0; i < inputData.data.horizonOfCalculationOfTheProject + 1; i++)
            {
                if (NPVmass[i] < 0) k = i;
                else break;
            }
            //---------------------------------------------------------------------------

            //------------------------------PBP-------------------------------------------
            try
            {
                PBP = k + Math.Abs(NPVmass[k]) / R[k + 1];
            } catch(System.IndexOutOfRangeException)
            {
                MessageBox.Show("Проблема в том, что года окупаемости (k) нету:\n Формула: PBP = k + |NPV[k]| / R[k + 1], где k = " + k + ", R["+(k+1)+"] не существует","Подсчитать не получилось");
                return;
            }
            label7.Text = Math.Round(PBP, numberRound).ToString();
            //----------------------------------------------------------------------------

            //------------------------------IRR-------------------------------------------
          

            var thread = new Thread(() =>
            {
                calculationIRR(NPV, R);
            });
            thread.IsBackground = false;
            thread.Start();

            
            
            
            //----------------------------------------------------------------------------
        }

        public void calculationIRR(double NPV, double[] R)
        {
            IRR = NPV;
            double IRRPref = 9999999999;
            double[] RR = R;
            double E = 0.1;
            ii = inputData.data.discountRate;
            while (Math.Abs(IRR) >= E)
            {
                ii += 0.00001;
                for (int i = 1; i < inputData.data.horizonOfCalculationOfTheProject + 1; i++)
                {
                    RR[i] = (inputData.data.inflowOfMeansInTheAllYears[i - 1] - inputData.data.outflowOfFundsInTheAllYears[i - 1]) /
                        Math.Pow((1 + (ii / 100d)), (i));
                }
                IRR = 0;
                for (int i = 1; i < inputData.data.horizonOfCalculationOfTheProject + 1; i++)
                {
                    IRR += RR[i];
                }
                IRR -= inputData.data.startingInvestments;
                if (Math.Abs(IRR) < 50)
                {
                    label12.Invoke(new Action(() => label12.Text = ii.ToString()));
                    label9.Invoke(new Action(() => label9.Text = IRR.ToString()));
                }

                if (Math.Abs(IRRPref) < Math.Abs(IRR)) break;
                IRRPref = IRR;
            }
            label12.Invoke(new Action(() => label12.Text = Math.Round(ii, numberRound).ToString() + "%"));
            label9.Invoke(new Action(() => label9.Text = Math.Round(IRR, numberRound).ToString()));
            this.Invoke(new Action(() => this.buildGrafic()));
           
        }

        public void buildGrafic()
        {
            //создаем элемент Chart
            Chart myChart = new Chart();
            //кладем его на форму и растягиваем на все окно.
            myChart.Parent = panel1;
            myChart.Dock = DockStyle.Fill;
            //добавляем в Chart область для рисования графиков, их может быть
            //много, поэтому даем ей имя.
            myChart.ChartAreas.Add(new ChartArea("Math functions"));

            //Создаем и настраиваем набор точек для рисования графика, в том
            //не забыв указать имя области на которой хотим отобразить этот
            //набор точек.
            mySeriesOfPoint = new Series("Sinus");
            mySeriesOfPoint1 = new Series("point");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint1.ChartType = SeriesChartType.Point;
            mySeriesOfPoint.ChartArea = "Math functions";
            mySeriesOfPoint1.ChartArea = "Math functions";
            //for (double x = -Math.PI; x <= Math.PI; x += Math.PI / 10.0)
            //{
            //    mySeriesOfPoint.Points.AddXY(x, Math.Sin(x));
            //}
            for (int x = 0; x < NPVmass.Length; x++)
            {
                mySeriesOfPoint.Points.AddXY(x, NPVmass[x]);
                mySeriesOfPoint1.Points.AddXY(x, NPVmass[x]);
                mySeriesOfPoint1.Points[x].Color = System.Drawing.Color.Red;
                mySeriesOfPoint1.Points[x].Label = "(" + x + " год, " + Math.Round(NPVmass[x], numberRound) + ")";
            }
            mySeriesOfPoint.Points.AddXY(Math.Round(PBP, numberRound), 0);
            mySeriesOfPoint1.Points.AddXY(Math.Round(PBP, numberRound), 0);
            
            mySeriesOfPoint1.Points[NPVmass.Length].Color = System.Drawing.Color.Red;
            mySeriesOfPoint1.Points[NPVmass.Length].Label = "PBP";//"(" + Math.Round(PBP, numberRound) + " год, " + mySeriesOfPoint1.Points[NPVmass.Length].YValues[0] + ")";
            //Добавляем созданный набор точек в Chart
            myChart.Series.Add(mySeriesOfPoint);
            myChart.Series.Add(mySeriesOfPoint1);
            //points(myChart);
        }

        private void чистыйПриведенныйДоходNPVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theory.setPicture(Resources._1);
            theory.Text = "Задание №1";
            theory.ShowDialog();
        }

        private void коэффициентВозвратаИнвестицийROIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theory.setPicture(Resources._2);
            theory.Text = "Задание №2";
            theory.ShowDialog();
        }

        private void индексДоходностиPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theory.setPicture(Resources._3);
            theory.Text = "Задание №3";
            theory.ShowDialog();
        }

        private void срокОкупаемостиPBPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theory.setPicture(Resources._4);
            theory.Text = "Задание №4";
            theory.ShowDialog();
        }

        private void внутреннююНормуДоходностиIRRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theory.setPicture(Resources._5);
            theory.Text = "Задание №5";
            theory.ShowDialog();
        }

        private void чистыйПриведенныйДоходNPVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            theory.setPicture(Resources.NPV_Theory);
            theory.Text = "Чистый приведенный доход";
            theory.ShowDialog();
        }

        private void коэффициентВозвратаИнвестицииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theory.setPicture(Resources.ROI_Theory);
            theory.Text = "Коэффициент возврата инвестиции";
            theory.ShowDialog();
        }

        private void индексДоходностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            theory.setPicture(Resources.PI_Theory);
            theory.Text = "Индекс доходности";
            theory.ShowDialog();
        }

        private void срокОкупаемостиPBPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            theory.setPicture(Resources.PBP_Theory);
            theory.Text = "Срок окупаемости";
            theory.ShowDialog();
        }

        private void внутреннююНормуДоходностиIRRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            theory.setPicture(Resources.IRR_Theory);
            theory.Text = "Внутренняя норма доходности";
            theory.ShowDialog();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setVisibleMainMenu(false, true);
        }

        private void setVisibleMainMenu(bool mainSolution, bool mainForm)
        {
            label13.Visible = mainForm;
            button2.Visible = mainForm;

            label1.Visible = mainSolution;
            label2.Visible = mainSolution;
            label3.Visible = mainSolution;
            label4.Visible = mainSolution;
            label5.Visible = mainSolution;
            label6.Visible = mainSolution;
            label7.Visible = mainSolution;
            label8.Visible = mainSolution;
            label9.Visible = mainSolution;
            label10.Visible = mainSolution;
            label11.Visible = mainSolution;
            label12.Visible = mainSolution;
            panel1.Visible = mainSolution;
            dataGridView1.Visible = mainSolution;
            button1.Visible = mainSolution;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setVisibleMainMenu(true, false);
        }
    }
}
