using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraPrinting.Native.Extensions;
using PrevisaoDoTempo.API;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrevisaoDoTempo
{
    public partial class Core : DevExpress.XtraEditors.XtraForm
    {

        public Core()
        {
            InitializeComponent();
        }

        public List<HGResponse> Data = new List<HGResponse>();

        public Series CriaSerie(ChartControl chart, string NomeSerie)
        {
            Series serieChart;
            serieChart = new Series();
            serieChart.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            serieChart.Name = NomeSerie;
            chart.Series.Add(serieChart);
            return serieChart;
        }


        public async Task GetTemp(string city)
        {

            var getPrevisao = RestService.For<IApiService>("https://api.hgbrasil.com");

            var Informations = await getPrevisao.GetTemp(city);

            Data.Add(Informations);
        }

        public void ConfiguraChart()
        {
            Series maxima = CriaSerie(ChartPrevisao, "Maxima (C°)");
            Series minima = CriaSerie(ChartPrevisao, "Mínima (C°)");

            int dia = 1;
            foreach (var temp in Data)
            {
                maxima.Points.Add(new SeriesPoint(temp.results.forecast[dia].max));
                minima.Points.Add(new SeriesPoint(temp.results.forecast[dia].min));

                maxima.ArgumentDataMember = temp.results.forecast[dia].date;
                minima.ArgumentDataMember = temp.results.forecast[dia].date;
                dia++;
            }
        }

        private void Core_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetTemp(txtBusca.Text).Wait(10);

            ConfiguraChart();

            Minima.Elements[1].Text = "25°";
        }
    }
}
