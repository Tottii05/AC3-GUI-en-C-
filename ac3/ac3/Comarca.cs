using CsvHelper.Configuration.Attributes;

namespace ac3
{
    public class Consum
    {
        public int Any { get; set; }
        [Name("Codi comarca")]
        public int Codi_Comarca { get; set; }
        public string? Comarca { get; set; }
        [Name("Població")]
        public int Poblacio { get; set; }
        [Name("Domèstic xarxa")]
        public int Domestic_xarxa { get; set; }
        [Name("Activitats econòmiques i fonts pròpies")]
        public int Activitats_economiques_i_fonts_propies { get; set; }
        public int Total { get; set; }
        [Name("Consum domèstic per càpita")]
        public double Consum_domestic_per_capita { get; set; }
    }
}
