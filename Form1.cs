using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using OfficeOpenXml;

namespace ViewBidAskDB
{
    ///ЭТО главная форма!!!!
    public partial class Form1 : Form
    {
        //имя файла БД с которой идет работа
        string openDBName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countRec_toolStripStatusLabel.Text = "0";
            from_toolStripStatusLabel.Text = "-";
            to_toolStripStatusLabel.Text = "-";
        }

        //открыть и загрузить котировки из БД
        private void Open_toolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string errMsg;
                SQLiteWorker.SetDB(openFileDialog.FileName, out errMsg);
                if (string.IsNullOrEmpty(errMsg))
                {
                    countRec_toolStripStatusLabel.Text = "0";
                    from_toolStripStatusLabel.Text = "-";
                    to_toolStripStatusLabel.Text = "-";
                    openDBName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                    groupBox1.Text = "Данные из " + openDBName;
                    //непосредственная загрузка котировок и вывод в датагрид
                    Update_toolStripButton_Click(null, null);
                }
            }
        }

        //непосредственная загрузка котировок и вывод в датагрид
        private void Update_toolStripButton_Click(object sender, EventArgs e)
        {
            if (openDBName != string.Empty)
            {
                string errMsg;
                //получение списка котировок из файла БД
                List<BidAskData> list = SQLiteWorker.DBSelectAll("data", out errMsg);
                if (string.IsNullOrEmpty(errMsg))
                {
                    res_dataGridView.DataSource = list;
                    res_dataGridView.Columns[0].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
                    res_dataGridView.AutoResizeColumns();
                    countRec_toolStripStatusLabel.Text = list.Count.ToString("N0");
                    if (list.Count > 0)
                    {
                        from_toolStripStatusLabel.Text = list[0].Date.ToString();
                        to_toolStripStatusLabel.Text = list.Last().Date.ToString();
                    }
                }
                else
                    MessageBox.Show(errMsg, "Загрузка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //сохранение котировок в файл формата Excel
        private void Export_toolStripButton_Click(object sender, EventArgs e)
        {
            if (openDBName != string.Empty)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog()
                {
                    DefaultExt = "xlsx",
                    Filter = "Файлы Excel|*.xlsx|Все файлы|*.*",
                    InitialDirectory = Application.StartupPath,
                    FileName = openDBName + ".xlsx"
                };
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                    return;
                string fname = saveFileDialog1.FileName;
                FileInfo newFile = new FileInfo(fname);
                if (newFile.Exists)
                {
                    try
                    {
                        File.Delete(fname);
                        // ensures we create a new workbook 
                        newFile = new FileInfo(fname);
                    }
                    catch (IOException exc)
                    {
                        string errMsg = string.Format("Ошибка при создании файла \"{0}\":\n{1}", Path.GetFileName(fname), exc.Message);
                        MessageBox.Show(errMsg, "Сохранение результатов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                using (ExcelPackage package = new ExcelPackage(newFile))
                {
                    // add a new worksheet to the empty workbook ExcelWorksheet 
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(openDBName);
                    //сохранение заголовка
                    worksheet.Cells["A1"].Value = "Дата";
                    worksheet.Cells["B1"].Value = "Спрос (Bid)";
                    worksheet.Cells["C1"].Value = "Объем спр";
                    worksheet.Cells["D1"].Value = "Предл (Ask)";
                    worksheet.Cells["E1"].Value = "Объем предл";
                    worksheet.Cells["F1"].Value = "Шаг цены";

                    int row = 2;
                    foreach (BidAskData x in (List<BidAskData>)res_dataGridView.DataSource)
                    {
                        worksheet.Cells[row, 1].Value = x.Date;
                        worksheet.Cells[row, 2].Value = x.Bid;
                        worksheet.Cells[row, 3].Value = x.BidDepth;
                        worksheet.Cells[row, 4].Value = x.Ask;
                        worksheet.Cells[row, 5].Value = x.AskDepth;
                        worksheet.Cells[row, 6].Value = x.Step;
                        row++;
                    }
                    worksheet.Cells["A:A"].Style.Numberformat.Format = "dd.MM.yyyy HH:mm:ss";
                    worksheet.Cells["A:F"].AutoFitColumns(0);
                    //сохранить данные в файл
                    package.Save();
                    MessageBox.Show("Сохранение выполнено успешно", "Сохранение результатов", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
