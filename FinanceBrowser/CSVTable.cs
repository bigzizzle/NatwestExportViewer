using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace FinanceBrowser
{
    public class CSVRow
    {
        public Dictionary<string, string> Values = new Dictionary<string, string>();

        public DateTime Date;
        public string Type;
        public string Description;
        public decimal Value;
        public decimal Balance;
        public string AccountName;
        public string AccountNumber;

        public CSVSource Source;
    }

    public class CSVSource
    {
        public List<CSVRow> Items = new List<CSVRow>();
        public string Name;
        public decimal Total;
    }

    public class CSVTable
    {
        public List<CSVRow> Rows = new List<CSVRow>();
        public List<CSVSource> Sources = new List<CSVSource>();

        public void Clear()
        {
            Rows.Clear();
            Sources.Clear();
        }

        public void Sort()
        {
            Rows.Sort((x, y) => x.Date.CompareTo(y.Date));
            Sources.Sort((x, y) => (-Math.Abs(x.Total)).CompareTo(-Math.Abs(y.Total)));
        }

        public void Load(string path)
        {
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                string[] columns = parser.ReadFields();

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields.Length >= columns.Length)
                    {
                        CSVRow row = new CSVRow();

                        for (int i = 0; i < columns.Length; i++)
                        {
                            row.Values.Add(columns[i], fields[i]);
                        }

                        row.Date = DateTime.Parse(row.Values["Date"]);
                        row.Type = row.Values["Type"];
                        row.Description = row.Values["Description"];
                        row.Value = decimal.Parse(row.Values["Value"]);
                        row.Balance = decimal.Parse(row.Values["Balance"]);
                        row.AccountName = row.Values["Account Name"];
                        row.AccountNumber = row.Values["Account Number"];

                        // Cut off the first part of the POS description as its a generic account id/date that
                        // is the same for everything.
                        if (row.Type == "POS")
                        {
                            row.Description = row.Description.Split(new char[] { ',' }, 2)[1].Trim();
                        }

                        Rows.Add(row);
                    }
                }
            }

            // Try and figure out unique sources, by filtering out the dates etc that are embedded in the description,
            // there is no easy way to parse them out, as they are different for each transaction, so we're just going
            // to try grouping them together based on their levenshtein distance.
            foreach (CSVRow row in Rows)
            {
                CSVSource match = null;
                int bestCount = int.MaxValue;

                foreach (CSVSource source in Sources)
                {
                    Int32 distance = Strings.Levenshtein(row.Description, source.Name);
                    if (distance < row.Description.Length / 3 && distance < bestCount)
                    {
                        match = source;
                        bestCount = distance;
                    }
                }

                if (match == null)
                {
                    match = new CSVSource();
                    match.Name = row.Description;
                    Sources.Add(match);
                }
                else
                {
                    row.Source = match;
                }

                match.Items.Add(row);
                match.Total += row.Value;
            }
        }
    }
}
