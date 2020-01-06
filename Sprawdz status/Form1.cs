using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprawdz_status
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                dataGridView1.Rows.Clear();
                var matchingComponents = Graffiti.MST.ComponentsTools.GetDbData.GetComponentHistoryBatch(new List<string> { textBox1.Text });
                if (!matchingComponents.Any())
                {
                    MessageBox.Show("Brak danych o komponencie.");
                    return;
                }
                var sortedByDate = matchingComponents.OrderByDescending(c => c.operationDate);
                foreach (var compEntry in sortedByDate)
                {
                    dataGridView1.Rows.Add(
                        compEntry.operationDate,
                        compEntry.Nc12_Formated_Rank,
                        compEntry.Id,
                        compEntry.QrCode,
                        compEntry.Quantity,
                        compEntry.Location,
                        compEntry.DocumentSymbol,
                        compEntry.expirationDate,
                        compEntry.KitId,
                        compEntry.VTypeCode
                        );
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("opDate", "Data operacji");
            dataGridView1.Columns.Add("nc", "12NC");
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("qr", "kod QR");
            dataGridView1.Columns.Add("qty", "Ilość");
            dataGridView1.Columns.Add("loc", "Lokalizator");
            dataGridView1.Columns.Add("doc", "Rodzaj dokumentu");
            dataGridView1.Columns.Add("exp", "Data przydatności");
            dataGridView1.Columns.Add("opDate", "Data operacji");
            dataGridView1.Columns.Add("kit", "KIT ID");
            dataGridView1.Columns.Add("vt", "V type code");
        }
    }
}
