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
                dgvCompHistory.Rows.Clear();
                var matchingComponents = Graffiti.MST.ComponentsTools.GetDbData.GetComponentHistoryBatch(new List<string> { tbCompQr.Text });
                if (!matchingComponents.Any())
                {
                    MessageBox.Show("Brak danych o komponencie.");
                    return;
                }
                var sortedByDate = matchingComponents.OrderByDescending(c => c.operationDate);
                foreach (var compEntry in sortedByDate)
                {
                    dgvCompHistory.Rows.Add(
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
            dgvCompHistory.Columns.Add("opDate", "Data operacji");
            dgvCompHistory.Columns.Add("nc", "12NC");
            dgvCompHistory.Columns.Add("id", "ID");
            dgvCompHistory.Columns.Add("qr", "kod QR");
            dgvCompHistory.Columns.Add("qty", "Ilość");
            dgvCompHistory.Columns.Add("loc", "Lokalizator");
            dgvCompHistory.Columns.Add("doc", "Rodzaj dokumentu");
            dgvCompHistory.Columns.Add("exp", "Data przydatności");
            dgvCompHistory.Columns.Add("opDate", "Data operacji");
            dgvCompHistory.Columns.Add("kit", "KIT ID");
            dgvCompHistory.Columns.Add("vt", "V type code");
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            var kittingData = MST.MES.SqlDataReaderMethods.Kitting.GetOneOrderByDataReader(tbOrderNoMes.Text);
            if(kittingData == null)
            {
                MessageBox.Show("Brak danych dla podanego zlecenia");
                return;
            }

            int graffOrderNo = kittingData.GraffitiOrder.PrimaryKey00;
            List<Graffiti.MST.ComponentsTools.ComponentStruct> compsConnectedToOrder= Graffiti.MST.OrdersOperations.GetData.CoNaRW();

            dgvRw.Rows.Clear();

            dgvRw.Rows.Add("Numer zlecenia MES:", kittingData.orderNo);
            dgvRw.Rows.Add("Numery zlecenia Graffiti:");
            dgvRw.Rows.Add("Wyrób - klucz główny", kittingData.orderNo);
            dgvRw.Rows.Add("Półwyrób - klucz główny", kittingData.orderNo);
            dgvRw.Rows.Add("Wyrób - klucz w danym roku", kittingData.orderNo);
            dgvRw.Rows.Add("Półwyrób - klucz w danym roku", kittingData.orderNo);
            dgvRw.Rows.Add();
            dgvRw.Rows.Add(
                        "Data operacji",
                        "12NC",
                        "ID",
                        "Kod QR",
                        "Ilość",
                        "Lokalizator",
                        "Dok. symbol",
                        "Data przydatności",
                        "ID Kitu",
                        "VtypeCode");
            foreach (var c in compsConnectedToOrder.OrderBy(c=>c.Nc12_Formated_Rank))
            {
                dgvRw.Rows.Add(
                    c.operationDate,
                    c.Nc12_Formated_Rank,
                    c.Id,
                    c.QrCode,
                    c.Quantity,
                    c.Location,
                    c.DocumentSymbol,
                    c.expirationDate,
                    c.KitId,
                    c.VtCode);
            }

        }
    }
}
