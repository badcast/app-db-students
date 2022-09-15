#define _MSOFFICE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

#if MSOFFICE
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
#endif

namespace DataBaseStudents.Plugins
{
    public enum FormatType
    {
        Word,
        Excel,
        PDF,
        RTF
    }

    public interface IContent
    {
        byte[] GetContent(string[] keys, string[][] values);
    }

    public class Plugin
    {
        protected string _pluginName;
        protected double _version;

        public string PluginName { get => _pluginName; }
        public double Version { get => _version; }
    }

    public class ExportPlugin : Plugin, IContent
    {
        public ExportPlugin()
        {

        }

        public virtual byte[] GetContent(string[] keys, string[][] values)
        {
            return null;
        }
    }
    public class ImportPlugin : Plugin
    {
        public ImportPlugin(string pluginName, int pluginVersion)
        {
            
        }

        public virtual string[][] Import(string filename)
        {
            return null;
        }
    }

    //Export plugins
    public class WordPluginEx : ExportPlugin
    {
        public WordPluginEx()
        {
            this._pluginName = "Word plugin extension";
            this._version = 1.0;
        }
#if MSOFFICE
        public override byte[] GetContent(string[] keys, string[][] values)
        {
            //INIT COM Object
            Word.Application comWord = new Word.Application();
            comWord.Visible = false;
            var doc = comWord.Documents.Add();

            Word.Range range = doc.Content;
            var table = doc.Tables.Add(range, 1, 8);
            table.Range.ParagraphFormat.SpaceAfter = 5;
            table.Rows[1].Range.Font.Bold = 1;
            Word.Borders border = table.Range.ParagraphFormat.Borders;
            border.DistanceFromTop = 1;
            border.DistanceFromLeft = 1;
            border.DistanceFromRight = 1;
            border.DistanceFromBottom = 1;

            void SelectCell(int row, int column, string value)
            {
                int maxReady = 5;
                int completeReady = 0;
                __reload:
                try
                {
                    if (table.Rows.Count < row)
                        table.Rows.Add();
                    var cell = table.Cell(row, column);
                    cell.Range.Text = value;
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    if (completeReady < maxReady)
                    {
                        completeReady++;
                        goto __reload;
                    }
                }
            }

            //Верхние поля!
            for (int k = 0; k < keys.Length; k++)
            {
                SelectCell(1, k + 1, keys[k]);
            }

            for (int v = 0; v < values.Length; v++)
            {

                for (int c = 0; c < values[v].Length; c++)
                {
                    SelectCell(v + 2, c + 1, values[v][c]);
                }
            }

            //SAVE
            string tempFileName = Path.GetTempFileName();

            if (File.Exists(tempFileName))
                File.Delete(tempFileName);

            doc.SaveAs(tempFileName);
            doc.Close();
            string __appName = "WINWORD".ToLower();
            System.Diagnostics.Process[] prs = System.Diagnostics.Process.GetProcessesByName(__appName);
            for (int i = 0; i < prs.Length; i++)
            {
                var pr = prs[i];
                DateTime startTime = pr.StartTime;
                DateTime curTime = DateTime.Now;
                if ((curTime - startTime).TotalSeconds < 10)
                    pr.Kill();

                pr.Dispose();
            }
            byte[] b = File.ReadAllBytes(tempFileName);
            try
            {
                File.Delete(tempFileName);
            }
            catch
            {

            }
            return b;
        }
#endif
    }

    public class ExcelPluginEx : ExportPlugin
    {
        public ExcelPluginEx()
        {
            this._pluginName = "Excel plugin exporter";
            this._version = 1.0;
        }
#if MSOFFICE

        public override byte[] GetContent(string[] keys, string[][] values)
        {
            var missing = System.Reflection.Missing.Value;
            Excel._Application exApp = null;
            exApp = new Excel.Application();
            exApp.Visible = false;
            Excel.Workbook workbook = exApp.Workbooks.Add(missing);
            Excel.Worksheet workSheet = (Excel.Worksheet)exApp.Worksheets[1];

            void SelectCell(int row, int column, string value)
            {
                workSheet.Cells[row, column].Value2 = value;
            }

            //Верхние поля!
            for (int k = 0; k < keys.Length; k++)
            {
                SelectCell(1, k + 1, keys[k]);
            }

            for (int v = 0; v < values.Length; v++)
            {

                for (int c = 0; c < values[v].Length; c++)
                {
                    SelectCell(v + 2, c + 1, values[v][c]);
                }
            }

            string tempFile = Path.GetTempFileName();
            File.Delete(tempFile);
            workbook.SaveAs(tempFile);
            workbook.Close();
            byte[] b = File.ReadAllBytes(tempFile);
            try
            {
                File.Delete(tempFile);
            }
            catch
            {

            }
            return b;
        }
#endif
    }
    public class RTFPluginEx : ExportPlugin
    {
        public RTFPluginEx()
        {
            base._pluginName = "Rich Text Format Extension";
            base._version = 1;
        }
#if MSOFFICE

        public override byte[] GetContent(string[] keys, string[][] values)
        {
            //INIT COM Object
            Word.Application comWord = new Word.Application();
            comWord.Visible = false;
            var doc = comWord.Documents.Add();

            Word.Range range = doc.Content;
            var table = doc.Tables.Add(range, 1, 8);
            table.Range.ParagraphFormat.SpaceAfter = 5;
            table.Rows[1].Range.Font.Bold = 1;
            Word.Borders border = table.Range.ParagraphFormat.Borders;
            border.DistanceFromTop = 1;
            border.DistanceFromLeft = 1;
            border.DistanceFromRight = 1;
            border.DistanceFromBottom = 1;

            table.Borders.OutsideColor = table.Borders.InsideColor = Word.WdColor.wdColorBlack;

            void SelectCell(int row, int column, string value)
            {
                int maxReady = 5;
                int completeReady = 0;
                __reload:
                try
                {
                    if (table.Rows.Count < row)
                        table.Rows.Add();
                    var cell = table.Cell(row, column);
                    cell.Range.Text = value;
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    if (completeReady < maxReady)
                    {
                        completeReady++;
                        goto __reload;
                    }
                }
            }

            //Верхние поля!
            for (int k = 0; k < keys.Length; k++)
            {
                SelectCell(1, k + 1, keys[k]);
            }

            for (int v = 0; v < values.Length; v++)
            {

                for (int c = 0; c < values[v].Length; c++)
                {
                    SelectCell(v + 2, c + 1, values[v][c]);
                }
            }

            //SAVE
            string tempFileName = Path.GetTempFileName();

            if (File.Exists(tempFileName))
                File.Delete(tempFileName);
            doc.SaveAs(tempFileName, Word.WdSaveFormat.wdFormatRTF);
            doc.Close();
            string __appName = "WINWORD".ToLower();
            System.Diagnostics.Process[] prs = System.Diagnostics.Process.GetProcessesByName(__appName);
            for (int i = 0; i < prs.Length; i++)
            {
                var pr = prs[i];
                DateTime startTime = pr.StartTime;
                DateTime curTime = DateTime.Now;
                if ((curTime - startTime).TotalSeconds < 10)
                    pr.Kill();

                pr.Dispose();
            }
            byte[] b = File.ReadAllBytes(tempFileName);
            try
            {
                File.Delete(tempFileName);
            }
            catch
            {

            }
            return b;
        }

#endif

    }
    public class PDFPluginEx : ExportPlugin
    {
        public PDFPluginEx()
        {
            _pluginName = "PDF Extension";
            _version = 1;
        }
#if MSOFFICE

        public override byte[] GetContent(string[] keys, string[][] values)
        {
            //INIT COM Object
            Word.Application comWord = new Word.Application();
            comWord.Visible = false;
            var doc = comWord.Documents.Add();

            Word.Range range = doc.Content;
            var table = doc.Tables.Add(range, 1, 8);
            table.Range.ParagraphFormat.SpaceAfter = 5;
            table.Rows[1].Range.Font.Bold = 1;
            Word.Borders border = table.Range.ParagraphFormat.Borders;
            border.DistanceFromTop = 1;
            border.DistanceFromLeft = 1;
            border.DistanceFromRight = 1;
            border.DistanceFromBottom = 1;

            table.Borders.OutsideColor = table.Borders.InsideColor = Word.WdColor.wdColorBlack;

            void SelectCell(int row, int column, string value)
            {
                int maxReady = 5;
                int completeReady = 0;
                __reload:
                try
                {
                    if (table.Rows.Count < row)
                        table.Rows.Add();
                    var cell = table.Cell(row, column);
                    cell.Range.Text = value;
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    if (completeReady < maxReady)
                    {
                        completeReady++;
                        goto __reload;
                    }
                }
            }

            //Верхние поля!
            for (int k = 0; k < keys.Length; k++)
            {
                SelectCell(1, k + 1, keys[k]);
            }

            for (int v = 0; v < values.Length; v++)
            {

                for (int c = 0; c < values[v].Length; c++)
                {
                    SelectCell(v + 2, c + 1, values[v][c]);
                }
            }

            //SAVE
            string tempFileName = Path.GetTempFileName();

            if (File.Exists(tempFileName))
                File.Delete(tempFileName);
            doc.SaveAs(tempFileName, FileFormat: Word.WdSaveFormat.wdFormatPDF);
            doc.Close();
            string __appName = "WINWORD".ToLower();
            System.Diagnostics.Process[] prs = System.Diagnostics.Process.GetProcessesByName(__appName);
            for (int i = 0; i < prs.Length; i++)
            {
                var pr = prs[i];
                DateTime startTime = pr.StartTime;
                DateTime curTime = DateTime.Now;
                if ((curTime - startTime).TotalSeconds < 10)
                    pr.Kill();

                pr.Dispose();
            }
            byte[] b = File.ReadAllBytes(tempFileName);
            try
            {
                File.Delete(tempFileName);
            }
            catch
            {

            }
            return b;
        }

#endif

    }

    //Import plugins
    public class ExcelPluginIx : ImportPlugin
    {
        public ExcelPluginIx() : base("Excel plugin importer", 1)
        {

        }
#if MSOFFICE

        public override string[][] Import(string filename)
        {
            var missing = System.Reflection.Missing.Value;
            Excel._Application exApp = new Excel.Application();
            exApp.Visible = false;
            exApp.Workbooks.Open(filename);
            Excel.Worksheet workSheet = (Excel.Worksheet)exApp.Worksheets[1];
            int rows = 0;
            int columns = 8;

            object SelectCell(int row, int column)
            {
                return workSheet.Cells[row+2, column+2].Value2;
            }

            bool hasRow(int rowIndex)
            {
                int have = columns;
                for (int y = 0; y < columns; y++)
                {
                    string g = SelectCell(rowIndex, y)?.ToString();
                    if (string.IsNullOrEmpty(g))
                        have--;
                    else
                        break;
                    if (g == null)
                    {
                        have = 0;
                        break;
                    }
                }

                return have > 0;
            }

            //get row count
            while (hasRow(rows))
                rows++;

            if (rows == 0)
            {
                exApp.DDETerminate(0);
                return null;
            }

            string[][] profiles = new string[rows][];

            for (int x = 0; x < rows; x++)
            {
                string[] __col = profiles[x] = new string[columns];
                for (int t = 0; t < columns; t++)
                {
                    __col[t] = SelectCell(x, t)?.ToString();
                }
            }

            return profiles;
        }
#endif
    }

    public class PluginFormat
    {
        private string _formatName;
        private string _ext;
        private ExportPlugin _exporter;
        private ImportPlugin _importer;

        public string FormatName { get => _formatName; }
        public string Extension { get => _ext; }
        public FormatType FormatType { get; }
        public bool HasExporter { get { return _exporter != null; } }
        public bool HasImporter { get { return _importer != null; } }
        public ExportPlugin Exporter { get => _exporter; }
        public ImportPlugin Importer { get => _importer; }
        public PluginFormat(string FormatName, string Extension, FormatType formatType, ExportPlugin expr, ImportPlugin impr)
        {
            this._formatName = FormatName;
            this._ext = Extension;
            this.FormatType = formatType;
            this._exporter = expr;
            this._importer = impr;
        }
    }
    public static class PluginFormats
    {
        private static Dictionary<FormatType, PluginFormat> _plugins;
        public static void InitResource()
        {
            if (_plugins == null)
            {
                _plugins = new Dictionary<FormatType, PluginFormat>()
                {
                    {
                        FormatType.Word,
                         new PluginFormat("Microsoft Word", ".doc", FormatType.Word, SavePlugin.wordPlugin, null)
                    },
                   {
                    FormatType.Excel,
                     new PluginFormat("Microsoft Excel", ".xlsx", FormatType.Excel, SavePlugin.excelPlugin, LoadPlugin.excelPluginIx)
                },
                {
                    FormatType.PDF,
                    new PluginFormat("PDF Extension", ".pdf", FormatType.PDF, SavePlugin.pdfPlugin, null)
                },
                {
                    FormatType.RTF,
                    new PluginFormat("Rich Text Format", ".rtf", FormatType.RTF, SavePlugin.rtfPlugin, null)
                }
                };
            }
        }
        public static PluginFormat GetExtension(FormatType formatType)
        {
            InitResource();

            return _plugins[formatType];
        }

        private static PluginFormat[] __temp;
        public static PluginFormat[] GetExtensions()
        {
            InitResource();
            return __temp  ?? (__temp = _plugins.Values.ToArray());
        }
    }
    public static class SavePlugin
    {
        public static readonly WordPluginEx wordPlugin = new WordPluginEx();
        public static readonly ExcelPluginEx excelPlugin = new ExcelPluginEx();
        public static readonly RTFPluginEx rtfPlugin = new RTFPluginEx();
        public static readonly PDFPluginEx pdfPlugin = new PDFPluginEx();
        public static bool SaveTo(string path, DataBase dataBase, FormatType formatType)
        {
            IContent content = null;
            switch (formatType)
            {
                case FormatType.Word:
                    content = wordPlugin;
                    break;
                case FormatType.Excel:
                    content = excelPlugin;
                    break;
                case FormatType.PDF:
                    content = pdfPlugin;
                    break;
                case FormatType.RTF:
                    content = rtfPlugin;
                    break;
                default:
                    break;
            }

            if (content == null)
            {
                return false;
            }

            string[] keys = { "№", "иин", "фио", "почта", "Номер телефона", "Дата рождения", "Национальность", "Спцеиальность", "Адрес проживания" };

            string[][] values = new string[dataBase.profiles.Count][];
            for (int i = 0; i < values.Length; i++)
            {
                var f = values[i] = new string[keys.Length];
                var prof = dataBase.profiles[i];
                f[0] = $"{i + 1}";                                          //№
                f[1] = "'" + prof.IIN;                                      //ИИН
                f[2] = $"{prof.LastName} {prof.Name} {prof.FamilyName}";    //фио
                f[3] = prof.Email;                                          //почта
                f[4] = "'" + prof.TelephoneNumber;                          //номер телефона
                f[5] = prof.Date.ToShortDateString();                                           //дата рождения
                f[6] = prof.National;                                       //национальность
                f[7] = prof.Speciality;                                     //специальность
                f[8] = prof.AddressOfHome;                                  //адрес проживания
            }

            byte[] bytes = content.GetContent(keys, values);
            using (var fs = File.OpenWrite(path))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

            return true;
        }
    }

    public static class LoadPlugin
    {
        public static readonly ExcelPluginIx excelPluginIx = new ExcelPluginIx();

        public static string[][] LoadFrom(string path, FormatType formatType)
        {
            ImportPlugin importer = null;

            switch (formatType)
            {
                case FormatType.Excel:

                    importer = excelPluginIx;
                    break;
            }

            if (importer == null)
                return null;

            return importer.Import(path);
        }
    }
}
