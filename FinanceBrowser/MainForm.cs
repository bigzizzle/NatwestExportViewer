using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinanceBrowser
{
    public partial class MainForm : Form
    {
        private CSVTable m_Table = new CSVTable();

        public MainForm()
        {
            InitializeComponent();

            string directory = Properties.Settings.Default["CSVDirectory"].ToString();
            if (Directory.Exists(directory))
            {
                LoadCSVDirectory(directory);
            }
        }

        private void loadCSVDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select directory containing CSV transaction export.";
            dialog.ShowNewFolderButton = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default["CSVDirectory"] = dialog.SelectedPath;
                Properties.Settings.Default.Save();

                LoadCSVDirectory(dialog.SelectedPath);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoadCSVDirectory(string path)
        {
            m_Table.Clear();
            foreach (string file in Directory.EnumerateFiles(path, "*.csv"))
            {
                m_Table.Load(file);
            }
            m_Table.Sort();

            UpdateTabs();
        }

        private void UpdateTabs()
        {
            UpdateOverview();
            UpdateExpenditure();
            UpdateIncome();
        }

        private void UpdateOverview()
        {
            decimal totalIncome = 0;
            decimal totalExpenditure = 0;
            int totalIncomeCount = 0;
            int totalExpenditureCount = 0;

            foreach (CSVRow row in m_Table.Rows)
            {
                if (row.Value < 0)
                {
                    totalExpenditure += Math.Abs(row.Value);
                    totalExpenditureCount++;
                }
                else
                {
                    totalIncome += row.Value;
                    totalIncomeCount++;
                }
            }

            TotalIncomeBox.Text = "£ " + totalIncome.ToString("N");
            TotalIncomeCountBox.Text = totalIncomeCount.ToString("N0");

            TotalExpenditureBox.Text = "£ " + totalExpenditure.ToString("N");
            TotalExpenditureCountBox.Text = totalExpenditureCount.ToString("N0");

            TotalCashflowBox.Text = "£ " + (totalIncome - totalExpenditure).ToString("N");
        }

        private void UpdateExpenditure()
        {
            ExpenditureTransactionsPerSource.Items.Clear();
            ExpenditureIndividualTransactions.Items.Clear();

            foreach (CSVSource source in m_Table.Sources)
            {
                if (source.Total < 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        source.Name,
                        "£ " + Math.Abs(source.Total).ToString("N"),
                        source.Items.Count.ToString("N0")
                    });
                    item.Tag = source;
                    ExpenditureTransactionsPerSource.Items.Add(item);
                }
            }
        }

        private void UpdateIncome()
        {
            IncomeTransactionsPerSource.Items.Clear();
            IncomeIndividualTransactions.Items.Clear();

            foreach (CSVSource source in m_Table.Sources)
            {
                if (source.Total > 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        source.Name,
                        "£ " + Math.Abs(source.Total).ToString("N"),
                        source.Items.Count.ToString("N0")
                    });
                    item.Tag = source;
                    IncomeTransactionsPerSource.Items.Add(item);
                }
            }
        }

        private void OverviewTab_Click(object sender, EventArgs e)
        {

        }

        private void ExpenditureTransactionsPerSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExpenditureTransactionsPerSource.SelectedItems.Count == 0)
            {
                return;
            }

            CSVSource source = ExpenditureTransactionsPerSource.SelectedItems[0].Tag as CSVSource;

            ExpenditureIndividualTransactions.Items.Clear();

            foreach (CSVRow row in source.Items)
            {
                ExpenditureIndividualTransactions.Items.Add(new ListViewItem(new string[]
                {
                    row.Date.ToString(),
                    "£ " + Math.Abs(row.Value).ToString("N"),
                    row.Description
                }));
            }
        }

        private void IncomeTransactionsPerSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IncomeTransactionsPerSource.SelectedItems.Count == 0)
            {
                return;
            }

            CSVSource source = IncomeTransactionsPerSource.SelectedItems[0].Tag as CSVSource;

            IncomeIndividualTransactions.Items.Clear();

            foreach (CSVRow row in source.Items)
            {
                IncomeIndividualTransactions.Items.Add(new ListViewItem(new string[]
                {
                    row.Date.ToString(),
                    "£ " + Math.Abs(row.Value).ToString("N"),
                    row.Description
                }));
            }
        }
    }
}
