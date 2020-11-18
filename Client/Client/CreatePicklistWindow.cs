using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Client
{
    public partial class CreatePicklistWindow : UserControl
    {
        public CreatePicklistWindow()
        {
            InitializeComponent();
        }

        private void CreatePicklistWindow_Load(object sender, EventArgs e)
        {
            PicklistView.Hide();
            FileDataGridView.Hide();
            UserInputPanel.Hide();

            FillComboBox();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            ExportToPdf();
            //TestPdf(FileDataGridView, "picklist");

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PicklistView.Items.Add(new ListViewItem(new[] { ProductNumberTextbox.Text, ProductNameTextbox.Text, LocationTextbox.Text, AmountTextbox.Text }));
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            ControlUserInput();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            PicklistView.Hide();
            FileDataGridView.Show();
            
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false})
                {
                    if(ofd.ShowDialog() == DialogResult.OK)
                    {
                        FileDataGridView.DataSource = ReadCsv(ofd.FileName);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Controls for missing user input
        private void ControlUserInput()
        {
            List<ComboBox> list = new List<ComboBox>();
            list.Add(CityCombobox);
            list.Add(PlatformCombobox);
            list.Add(ExpressCombobox);

            string errorPreset = "The following is missing: \n\n";
            string errorMessage = "";

            foreach (ComboBox cb in list)
            {
                errorMessage += (CheckComboBox(cb));
            }

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorPreset + errorMessage, "Error");
            }
            else
            {
                PicklistView.Show();
                UserInputPanel.Show();
            }
        }

        // Controls combobox for user input
        private string CheckComboBox(ComboBox cb)
        {
            if (string.IsNullOrWhiteSpace(cb.Text))
            {
                return cb.Name + "\n";
            }
            else
            {
                return null;
            }
        }

        // Adds data to the user boxes
        private void FillComboBox()
        {
            foreach (string store in CreateStoreList())
            {
                CityCombobox.Items.Add(store);
            }

            PlatformCombobox.Items.Add("Store order");
            PlatformCombobox.Items.Add("Online order");

            ExpressCombobox.Items.Add("Yes");
            ExpressCombobox.Items.Add("No");
        }

        // Creates and returns a list of stores
        private List<string> CreateStoreList()
        {
            List<string> stores = new List<string>();

            #region City list
            stores.Add("Bornholm");
            stores.Add("Broendby");
            stores.Add("Esbjerg");
            stores.Add("Fredericia");
            stores.Add("Frederikshavn"); // Not available currently
            stores.Add("Gladsaxe");
            stores.Add("Herning");
            stores.Add("Hilleroed");
            stores.Add("Hjoerring");
            stores.Add("Holbaek");
            stores.Add("Holstebro");
            stores.Add("Horsens");
            stores.Add("Ishoej");
            stores.Add("Kastrup");
            stores.Add("Kolding");
            stores.Add("Koege");
            stores.Add("Egaa");
            stores.Add("Grenaa");
            stores.Add("Nakskov");
            stores.Add("Nykoebing Falster");
            stores.Add("Naestved");
            stores.Add("Odense");
            stores.Add("Randers");
            stores.Add("Roskilde");
            stores.Add("Sdr. Omme");
            stores.Add("Silkeborg");
            stores.Add("Slagelse");
            stores.Add("Svendborg");
            stores.Add("Soenderborg");
            stores.Add("Thisted");
            stores.Add("Vejle");
            stores.Add("Viborg");
            stores.Add("Aabenraa");
            stores.Add("Aalborg");
            stores.Add("Aarhus");
            #endregion

            return stores;
        }

        // Reads the .csv file
        public DataTable ReadCsv(string fileName)
        {
            DataTable data = new DataTable("Data");

            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" +
                Path.GetDirectoryName(fileName) + "\";Extended Properties='text;HDR=yes;FMT=Delimited(,)';"))
            {
                using(OleDbCommand cmd = new OleDbCommand(string.Format("select *from [{0}]", new FileInfo(fileName).Name), conn))
                {
                    conn.Open();
                    using(OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(data);
                    }
                }
            }

            return data;
        }
        
        private void ExportToPdf()
        {
            try
            {
                var pdfDocument = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
                string saveLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // desktop path

                PdfWriter.GetInstance(pdfDocument, new FileStream(saveLocation + "\\a.pdf", FileMode.OpenOrCreate));
                pdfDocument.Open();

                // Tables
                var newlineTable = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10,
                };

                var headerTable = new PdfPTable(new[] { .75f, 2f })
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 75,
                    DefaultCell = { MinimumHeight = 22f }
                };

                headerTable.AddCell("Title");
                headerTable.AddCell("Picklist");
                headerTable.AddCell("Company");
                headerTable.AddCell("My Home Trading");
                headerTable.AddCell("Picklist number");
                headerTable.AddCell("L26758");
                headerTable.AddCell("Date");
                headerTable.AddCell(DateTime.Today.ToString());

                pdfDocument.Add(headerTable);
                pdfDocument.Add(newlineTable);

                var columnCount = FileDataGridView.ColumnCount;
                var columnWidths = new[] { 1f, 1f, 1f, 1f };

                var table = new PdfPTable(columnWidths)
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 100,
                    DefaultCell = { MinimumHeight = 22f }
                };

                var cell = new PdfPCell(new Phrase("L26758"))
                {
                    Colspan = columnCount,
                    HorizontalAlignment = 1,
                    MinimumHeight = 30f
                };

                table.AddCell(cell);

                // Columns
                FileDataGridView.Columns
                    .OfType<DataGridViewColumn>()
                    .ToList()
                    .ForEach(c => table.AddCell(c.Name));

                // Rows
                FileDataGridView.Rows
                    .OfType<DataGridViewRow>()
                    .ToList()
                    .ForEach(r =>
                    {
                        var cells = r.Cells.OfType<DataGridViewCell>().ToList();
                        cells.ForEach(c => table.AddCell(c.Value.ToString()));
                    });

                pdfDocument.Add(table);

                pdfDocument.Close();
            }

            catch (Exception e)
            {

            }
            
        }

        private void TestPdf(DataGridView data, string fileName)
        {
            PdfPTable pdfTable = new PdfPTable(data.Columns.Count);

            pdfTable.DefaultCell.Padding = 3;
            pdfTable.DefaultCell.BorderWidth = 1;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            BaseFont baseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            iTextSharp.text.Font text = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);

            // Add columns
            foreach (DataGridViewColumn column in data.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            // Add rows
            foreach (DataGridViewRow row in data.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.DefaultExt = ".pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfDocument, stream);
                    pdfDocument.Open();
                    pdfDocument.Add(pdfTable);
                    pdfDocument.Close();
                    stream.Close();
                }
            }
        }
    }
}
