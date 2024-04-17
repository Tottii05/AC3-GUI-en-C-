using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ac3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Helper.ConvertCsvToXml("../../../files/Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv", "../../../files/Consum_d_aigua_a_Catalunya_per_comarques_20240402.xml");
            FillYearComboBox();
            FillComarcaComboBox();
        }
        private static List<Consum> GetInfoCsv(string path, DataGridView dataGridView)
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<Consum>().ToList();
                return records;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(poblationTextBox.Text))
                {
                    poblationErrorProvider.SetError(poblationTextBox, "El campo de población no puede estar vacío.");
                }
                if (string.IsNullOrEmpty(domesticXarxaTextBox.Text))
                {
                    domesticXarxaErrorProvider.SetError(domesticXarxaTextBox, "El campo de doméstico xarxa no puede estar vacío.");
                }
                if (string.IsNullOrEmpty(activitiesTextBox.Text))
                {
                    AEErrorProvider.SetError(activitiesTextBox, "El campo de actividades económicas y fuentes propias no puede estar vacío.");
                }
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    TotalErrorProvider.SetError(textBox3, "El campo de total no puede estar vacío.");
                }
                if (string.IsNullOrEmpty(domesticCapitaTextBox.Text))
                {
                    PerCapitaErrorProvider.SetError(domesticCapitaTextBox, "El campo de consumo doméstico per cápita no puede estar vacío.");
                }
                if (string.IsNullOrEmpty(yearComboBox.Text))
                {
                    yearErrorProvider.SetError(yearComboBox, "El campo de año no puede estar vacío.");
                }
                if (string.IsNullOrEmpty(comarcaComboBox.Text))
                {
                    comarcaErrorProvider.SetError(comarcaComboBox, "El campo de comarca no puede estar vacío.");
                }
                Consum consum = new Consum
                {
                    Any = int.Parse(yearComboBox.Text),
                    Comarca = comarcaComboBox.Text,
                    Poblacio = int.Parse(poblationTextBox.Text),
                    Domestic_xarxa = int.Parse(domesticXarxaTextBox.Text),
                    Activitats_economiques_i_fonts_propies = int.Parse(activitiesTextBox.Text),
                    Total = int.Parse(textBox3.Text),
                    Consum_domestic_per_capita = double.Parse(domesticCapitaTextBox.Text)
                };

                using (var writer = new StreamWriter("../../../files/Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv", append: true))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecord(consum);
                }

                ReloadDataGrid();
            }
            catch(Exception ex)
            {
            }
        }

        private void ReloadDataGrid()
        {
            comarquesDataGrid.Rows.Clear();
            comarquesDataGrid.Columns.Clear();

            comarquesDataGrid.Columns.Add("Any", "Any");
            comarquesDataGrid.Columns.Add("Comarca", "Comarca");
            comarquesDataGrid.Columns.Add("Població", "Població");
            comarquesDataGrid.Columns.Add("Domèstic xarxa", "Domèstic xarxa");
            comarquesDataGrid.Columns.Add("A.E. i fonts pròpies", "A.E. i fonts pròpies");
            comarquesDataGrid.Columns.Add("Total", "Total");
            comarquesDataGrid.Columns.Add("Consum domèstic/càpita", "Consum domèstic/càpita");

            List<Consum> consums = GetInfoCsv("../../../files/Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv", comarquesDataGrid);

            foreach (var consumo in consums)
            {
                int rowIndex = comarquesDataGrid.Rows.Add();
                DataGridViewRow row = comarquesDataGrid.Rows[rowIndex];

                row.Cells["Any"].Value = consumo.Any;
                row.Cells["Comarca"].Value = consumo.Comarca;
                row.Cells["Població"].Value = consumo.Poblacio;
                row.Cells["Domèstic xarxa"].Value = consumo.Domestic_xarxa;
                row.Cells["A.E. i fonts pròpies"].Value = consumo.Activitats_economiques_i_fonts_propies;
                row.Cells["Total"].Value = consumo.Total;
                row.Cells["Consum domèstic/càpita"].Value = consumo.Consum_domestic_per_capita;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            yearComboBox.Text = string.Empty;
            comarcaComboBox.Text = string.Empty;
            poblationTextBox.Text = string.Empty;
            domesticXarxaTextBox.Text = string.Empty;
            activitiesTextBox.Text = string.Empty;
            totalTextBox.Text = string.Empty;
            domesticCapitaTextBox.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Consum> consums = GetInfoCsv("../../../files/Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv", comarquesDataGrid);

            comarquesDataGrid.Rows.Clear();
            comarquesDataGrid.Columns.Clear();

            comarquesDataGrid.Columns.Add("Any", "Any");
            comarquesDataGrid.Columns.Add("Comarca", "Comarca");
            comarquesDataGrid.Columns.Add("Població", "Població");
            comarquesDataGrid.Columns.Add("Domèstic xarxa", "Domèstic xarxa");
            comarquesDataGrid.Columns.Add("A.E. i fonts pròpies", "A.E. i fonts pròpies");
            comarquesDataGrid.Columns.Add("Total", "Total");
            comarquesDataGrid.Columns.Add("Consum domèstic/càpita", "Consum domèstic/càpita");

            foreach (var consumo in consums)
            {

                int rowIndex = comarquesDataGrid.Rows.Add();
                DataGridViewRow row = comarquesDataGrid.Rows[rowIndex];


                row.Cells["Any"].Value = consumo.Any;
                row.Cells["Comarca"].Value = consumo.Comarca;
                row.Cells["Població"].Value = consumo.Poblacio;
                row.Cells["Domèstic xarxa"].Value = consumo.Domestic_xarxa;
                row.Cells["A.E. i fonts pròpies"].Value = consumo.Activitats_economiques_i_fonts_propies;
                row.Cells["Total"].Value = consumo.Total;
                row.Cells["Consum domèstic/càpita"].Value = consumo.Consum_domestic_per_capita;
            }
        }

        private void FillYearComboBox()
        {
            const int MaxYear = 2050;
            List<Consum> consums = GetInfoCsv("../../../files/Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv", comarquesDataGrid);
            int oldestYear = consums.Min(x => x.Any);
            for (int i = oldestYear; i <= MaxYear; i++)
            {
                yearComboBox.Items.Add(i);
            }
        }

        private void FillComarcaComboBox()
        {
            List<string> comarquesNames = Helper.GetComarquesXml("../../../files/Consum_d_aigua_a_Catalunya_per_comarques_20240402.xml");
            foreach (var comarca in comarquesNames)
            {
                comarcaComboBox.Items.Add(comarca);
            }
        }

        private void comarquesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const int PopulationLimiter = 20000;

            List<Consum> listConsum = GetInfoCsv("../../../files/Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv", comarquesDataGrid);

            biggerPoblationShowValue.Visible = true;
            domesticAverageShowValue.Visible = true;
            biggestConsumShowValue.Visible = true;
            lowestConsumShowValue.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = comarquesDataGrid.Rows[e.RowIndex];
                int poblacion;
                biggerPoblationShowValue.Text = int.TryParse(row.Cells["Població"].Value.ToString(), out poblacion) && poblacion > PopulationLimiter ? "Sí" : "No";
                double.TryParse(row.Cells["Domèstic xarxa"].Value.ToString(), out double domesticXarxa);
                double.TryParse(row.Cells["Població"].Value.ToString(), out double poblacionDouble);
                double average = poblacionDouble != 0 ? domesticXarxa / poblacionDouble : 0;
                domesticAverageShowValue.Text = average.ToString();
                int.TryParse(row.Cells["Consum domèstic/càpita"].Value.ToString(), out int consumPerCapita);
                bool isBiggestConsumPerCapita = consumPerCapita == listConsum.Max(x => x.Consum_domestic_per_capita);
                biggestConsumShowValue.Text = isBiggestConsumPerCapita ? "Sí" : "No";
                bool isLowestConsumPerCapita = consumPerCapita == listConsum.Min(x => x.Consum_domestic_per_capita);
                lowestConsumShowValue.Text = isLowestConsumPerCapita ? "Sí" : "No";
            }
        }

        private void poblationTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(poblationTextBox.Text))
            {
                poblationErrorProvider.SetError(poblationTextBox, "El campo de población no puede estar vacío.");
            }
        }
    }
}
