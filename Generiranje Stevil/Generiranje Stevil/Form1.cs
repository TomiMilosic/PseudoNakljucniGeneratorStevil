using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Generiranje_Stevil
{
    public partial class Form1 : Form
    {
        int seme = 0;
        List<double> stevila = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

       

        private void GenerirajBtn_Click(object sender, EventArgs e)
        {

            double X = 0;
            double.TryParse(SteviloX.Text, out X);

            if (Sinrb.Checked)
            {
                if (s10rb.Checked) GenerirajSin(10, X);
                if (s100rb.Checked) GenerirajSin(100, X);
                if (s1000rb.Checked) GenerirajSin(1000, X);
                if (s10000rb.Checked) GenerirajSin(10000, X);
                if (PoljubnoGeneriranjetxb.Text != "" || PoljubnoGeneriranjetxb.Text != null)
                {
                    int stevilo = 0;
                    if (int.TryParse(PoljubnoGeneriranjetxb.Text, out stevilo))
                    {
                        GenerirajSin(stevilo, X);
                    }
                    else
                    {
                        MessageBox.Show("Napaka!");
                    }
                }

            }

            if (Cosrb.Checked)
            {
                if (s10rb.Checked) GenerirajCos(10, X);
                if (s100rb.Checked) GenerirajCos(100, X);
                if (s1000rb.Checked) GenerirajCos(1000, X);
                if (s10000rb.Checked) GenerirajCos(10000, X);
                if (PoljubnoGeneriranjetxb.Text != "" || PoljubnoGeneriranjetxb.Text != null)
                {
                    int stevilo = 0;
                    if (int.TryParse(PoljubnoGeneriranjetxb.Text, out stevilo))
                    {
                        GenerirajCos(stevilo, X);
                    }
                    else
                    {
                        MessageBox.Show("Napaka!");
                    }
                }

            }



        }



        public void GenerirajSin(int steviloPonovitev, double x)
        {
            for (int i = 0; i < steviloPonovitev; i++)
            {
                seme = (int)(DateTime.Now.Ticks % 1000);
                double y = Math.Round(seme * Math.Sin(x - (Math.PI / 3)), 2);
                stevila.Add(y);
                x = y;
            }

           

            using (var pisi = new StreamWriter(@"seznamStevil.txt"))
            {
                foreach (var item in stevila)
                {
                    pisi.Write(item + ",");
                }

            }

            StPojavitev(stevila);

        }


        public void GenerirajCos(int steviloPonovitev, double x)
        {
            for (int i = 0; i < steviloPonovitev; i++)
            {
                seme =(int)(DateTime.Now.Ticks % 1000);
                double y = Math.Round(seme * Math.Cos(x + (Math.PI / 6)), 2);
                stevila.Add(y);
                x = y;
            }


            using (var pisi = new StreamWriter(@"seznamStevil.txt"))
            {
                foreach (var item in stevila)
                {
                    pisi.Write(item + ",");
                }

            }
            StPojavitev(stevila);

        }


        public void StPojavitev(List<double> stevila)
        {

            chart1.Series.Clear();

            var edinstvena = stevila.GroupBy(x => x);
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            
            foreach (var item in edinstvena)
            {
                series.Points.AddXY(item.Key,item.Count());
            }

            chart1.Series.Add(series);

        }
    }
}
