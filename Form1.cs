using EquipmentCalculator.Models;
using OfficeOpenXml;
using System.Data;
using System.Globalization;

namespace EquipmentCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            LoadDataIntoDataTable("Equipments.xlsx", dgwEquipments);
            dgwCalculateResults.Columns.Add("ResultColumn", "Sonuç");
            dgwCalculateResults.Columns.Add("RemainderColumn", "Kalan");
            dgwCalculateResults.Columns.Add("CuttinSizeColumn", "Kesim Ölçüsü");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtELenght.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal eqlenght);

            saveEquipment("Equipments.xlsx", eqlenght, nudEAmouth.Value);

            txtELenght.Clear();
            nudEAmouth.Value = 0;
        }


        private void saveEquipment(string folderName, decimal eqLenght, decimal eqAmounth)
        {

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.Combine(baseDirectory, folderName);
            FileInfo fileInfo = new FileInfo(folderPath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet;

                if (!fileInfo.Exists)
                {
                    worksheet = package.Workbook.Worksheets.Add("Equipment");
                    worksheet.Cells[1, 1].Value = "Donatý Uzunluðu";
                    worksheet.Cells[1, 2].Value = "Donatý Miktarý";
                }
                else
                {
                    worksheet = package.Workbook.Worksheets[0];
                }

                int newLine = worksheet.Dimension.End.Row + 1;

                worksheet.Cells[newLine, 1].Value = eqAmounth;
                worksheet.Cells[newLine, 2].Value = eqAmounth;

                package.Save();

                LoadDataIntoDataTable("Equipments.xlsx", dgwEquipments);

            }
        }

        private DataTable ExcelToDataTable(string fileName)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.Combine(baseDirectory, "Equipments.xlsx");
            FileInfo fileInfo = new FileInfo(folderPath);

            DataTable dt = new DataTable();

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                int rowCount = worksheet.Dimension.End.Row;
                int columnCount = worksheet.Dimension.End.Column;

                for (int i = 1; i <= worksheet.Dimension.End.Column; i++)
                {
                    string columnName = worksheet.Cells[1, i].Text.Trim();

                    dt.Columns.Add(string.IsNullOrEmpty(columnName) ? $"Column{i}" : columnName);
                }

                for (int row = 2; row <= rowCount; row++)
                {
                    DataRow dataRow = dt.NewRow();
                    for (int col = 1; col <= columnCount; col++)
                    {
                        dataRow[col - 1] = worksheet.Cells[row, col].Text.Trim();
                    }
                    dt.Rows.Add(dataRow);
                }

                return dt;
            }
        }

        private void LoadDataIntoDataTable(string filePath, DataGridView dataGridView)
        {
            DataTable dt = ExcelToDataTable(filePath);
            dataGridView.DataSource = dt;
        }

        private void dgwEquipments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgwCalculateResults.Rows.Clear();

            DataGridViewRow row = dgwEquipments.Rows[e.RowIndex];
            ICollection<CalculateModel> models = GetCalculate(int.Parse(row.Cells[0].Value.ToString()), int.Parse(row.Cells[1].Value.ToString()));
            foreach (CalculateModel model in models) 
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgwCalculateResults);
                newRow.Cells[0].Value = model.Result;  
                newRow.Cells[1].Value = model.Remainder;
                newRow.Cells[2].Value = model.CuttingSize;
                dgwCalculateResults.Rows.Add(newRow);
            }
            
        }   


        private ICollection<CalculateModel> GetCalculate(int eqLenght, int amount)
        {
            ICollection<CalculateModel> models = new List<CalculateModel>();
            int[] numbers = [2,3,4,5,6,7,8,9,10];

            foreach (int number in numbers) 
            {
                CalculateModel model = new()
                {
                    Result = (eqLenght / number) * amount,
                    Remainder = (eqLenght % number) * amount,
                    CuttingSize = $"{number} M"
                };
                models.Add(model);
            }

            return models;
        }
    }
}
