using CsvHelper;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace ac3
{
    public static class Helper
    {
        public static bool IsValidXmlName(string name)
        {
            return Regex.IsMatch(name, @"^[\p{L}\p{Nl}_][\p{L}\p{Nl}\p{Mn}\p{Mc}\p{Nd}\p{Pc}\p{Cf}]*$");
        }

        public static void ConvertCsvToXml(string csvPath, string xmlPath)
        {
            const string ConvertSuccess = "Csv convertido a Xml correctamente";

            var records = new List<Dictionary<string, string>>();

            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    var record = new Dictionary<string, string>();

                    foreach (var header in csv.HeaderRecord)
                    {
                        var cleanedHeader = header.Replace(" ", "_");
                        record[cleanedHeader] = csv.GetField(header);
                    }

                    records.Add(record);
                }
            }

            var root = new XElement("data");

            foreach (var record in records)
            {
                var recordElement = new XElement("record");

                foreach (var kvp in record)
                {
                    var elementName = kvp.Key;
                    if (!IsValidXmlName(elementName))
                    {
                        elementName = Regex.Replace(elementName, @"[^\w\.-]", "_");
                    }

                    recordElement.Add(new XElement(elementName, kvp.Value));
                }

                root.Add(recordElement);
            }

            var xmlDocument = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), root);
            xmlDocument.Save(xmlPath);
            Console.WriteLine(ConvertSuccess);
        }
        public static List<string> GetComarquesXml(string path)
        {
            var comarques = new List<string>();

            var xml = XDocument.Load(path);

            foreach (var element in xml.Root.Elements())
            {
                var comarca = element.Element("Comarca")?.Value;
                if (comarca != null)
                {
                    comarques.Add(comarca);
                }
            }

            return comarques;
        }
        public static void AppendConsum(Consum consum, string path)
        {
            using (var writer = new StreamWriter(path, true))
            using (var csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
            {
                writer.WriteLine();
                csv.WriteRecord(consum);
            }
        }
        public static int GetCodiComarca(string comarca)
        {
            var xml = XDocument.Load("../../../files/Consum_d_aigua_a_Catalunya_per_comarques_20240402.xml");

            foreach (var element in xml.Root.Elements())
            {
                if (element.Element("Comarca")?.Value == comarca)
                {
                    return int.Parse(element.Element("Codi_comarca")?.Value);
                }
            }

            return -1;
        }
    }
}
