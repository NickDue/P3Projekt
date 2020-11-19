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
            PicklistView.Hide(); // skal slettes
            //FileDataGridView.Hide();

            FillComboBox();

            GetEmployeeInformation("Dunke Dolmer"); 
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (FileDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Missing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                ConvertToPdf(FileDataGridView, "picklist");
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            if (ControlUserInput())
            {
                PicklistView.Hide();
                FileDataGridView.Show();

                try
                {
                    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                    {
                        if (ofd.ShowDialog() == DialogResult.OK)
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
            
            else
            {
                
            }
        }

        // Controls for missing user input
        private bool ControlUserInput()
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
                MessageBox.Show(errorPreset + errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        // Displays the user information in the menu
        private void GetEmployeeInformation(string employee)
        {
            Random ID = new Random();
            
            EmployeeNameBox.Text = employee;
            IDBox.Text = (ID.Next(1000, 1100)).ToString();
            RoleBox.Text = "FLOOR";
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

        private void ConvertToPdf(DataGridView data, string fileName)
        {
            PdfPTable picklistTable = new PdfPTable(data.Columns.Count);

            // Design
            picklistTable.DefaultCell.Padding = 3;
            picklistTable.DefaultCell.BorderWidth = 1;
            picklistTable.WidthPercentage = 100;
            picklistTable.HorizontalAlignment = Element.ALIGN_LEFT;

            BaseFont baseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            iTextSharp.text.Font text = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);

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

            // Header table
            headerTable.AddCell(new Phrase(CityLabel.Text, text));
            headerTable.AddCell(new Phrase(CityCombobox.Text, text));
            headerTable.AddCell(new Phrase(PlatformLabel.Text, text));
            headerTable.AddCell(new Phrase(PlatformCombobox.Text, text));
            headerTable.AddCell(new Phrase(ExpressLabel.Text, text));
            headerTable.AddCell(new Phrase(ExpressCombobox.Text, text));
            headerTable.AddCell(new Phrase("Date", text));
            headerTable.AddCell(new Phrase(DateTime.Now.ToString(), text));

            // Picklist table
            foreach (DataGridViewColumn column in data.Columns) // Adding columns
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                picklistTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in data.Rows) // Adding rows
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    picklistTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            // Save file
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF | *.pdf";
            saveFileDialog.FileName = fileName;
            saveFileDialog.DefaultExt = ".pdf";

            // Generate .pdf file
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDocument = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfDocument, stream);
                    pdfDocument.Open();
                    pdfDocument.Add(headerTable);
                    pdfDocument.Add(newlineTable);
                    pdfDocument.Add(picklistTable);
                    pdfDocument.Close();
                    stream.Close();
                }
            }
        }
    }
}
