using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labWork1;
using Newtonsoft;
using System.IO;
using Newtonsoft.Json;

namespace View
{
    public partial class View : Form
    {
        private DataTable _table;
        public View()
        {
            InitializeComponent();
            CreateDatatable();
            foreach (DataGridViewColumn column in FigureGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public class ListFigures
        {
            public static List<IFigure> list = new List<IFigure>();
        }

        private void CreateDatatable()
        {

            _table = new DataTable();
            var column0 = new DataColumn("Название фигуры")
            {
                Caption = "Figure",
                DataType = typeof(string),
                ReadOnly = true
            };
            var column2 = new DataColumn("Координата X")
            {
                Caption = "Сoordinate",
                DataType = typeof(double),
                ReadOnly = true
            };
            var column4 = new DataColumn("Координата Y")
            {
                Caption = "Сoordinate",
                DataType = typeof(double),
                ReadOnly = true
            };
            var column6 = new DataColumn("Площадь")
            {
                Caption = "Area",
                DataType = typeof(double),
                ReadOnly = true
            };

            _table.Columns.Add(column0);
            _table.Columns.Add(column2);
            _table.Columns.Add(column4);
            _table.Columns.Add(column6);
            FigureGridView.DataSource = _table;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CloseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Закрыть программу?", "Завершение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) Application.Exit();
        }


        private void TableFigure_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Все не сохраннёные данные могут быть потеряны. Создать новый файл?", "New", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    _table.Rows.Clear();
                    ListFigures.list.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NewFile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Все не сохраннёные данные могут быть потеряны. Создать новый файл?", "New", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    _table.Rows.Clear();
                    ListFigures.list.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddShape(object sender, EventArgs e)
        {
            AddModifyFigureForm f = new AddModifyFigureForm();
            IFigure figure = null;
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                figure = f.Figure;
                ListFigures.list.Add(figure);
                var row = _table.NewRow();
                row[0] = figure.Name;
                row[1] = figure.X;
                row[2] = figure.Y;
                row[3] = figure.CalculationArea();
                _table.Rows.Add(row);
                FigureGridView.Update();
            }
        }
        private void RemoveData_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Удалить обьект?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewCell cell in FigureGridView.SelectedCells)
                {
                    FigureGridView.Rows.RemoveAt(cell.RowIndex);
                }
            }

        }

        public IFigure Figure { get; set; }
        public int _figure;
        private void FillTable_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int style;
            for (int i = 0; i < 10; i++)
            {
                style = rnd.Next(0, 3);
                labWork1.IFigure figureModel = null;
                switch (_figure)
                {
                    case 0:
                        var circle = new Circle();
                        circle.Radius = Convert.ToInt32(rnd.Next(0, 10));
                        circle.X = Convert.ToInt32(rnd.Next(0, 100));
                        circle.Y = Convert.ToInt32(rnd.Next(0, 100));
                        figureModel = circle;
                        break;
                    case 1:
                        var rectangle = new labWork1.Rectangle();
                        rectangle.Length = Convert.ToInt32(rnd.Next(0, 10));
                        rectangle.Width = Convert.ToInt32(rnd.Next(0, 10));
                        rectangle.X = Convert.ToInt32(rnd.Next(0, 100));
                        rectangle.Y = Convert.ToInt32(rnd.Next(0, 100));
                        figureModel = rectangle;
                        break;
                    case 2:
                        var triangle = new Triangle();
                        triangle.Side1 = Convert.ToInt32(rnd.Next(0, 10));
                        triangle.Side2 = Convert.ToInt32(rnd.Next(0, 10));
                        triangle.Side3 = Convert.ToInt32(rnd.Next(0, 10));
                        triangle.X = Convert.ToInt32(rnd.Next(0, 100));
                        triangle.Y = Convert.ToInt32(rnd.Next(0, 100));
                        figureModel = triangle;
                        break;
                }
                Figure = figureModel;
                DialogResult = DialogResult.OK;
                _figure = (rnd.Next(0, 3));
                IFigure figure = null;
                figure = Figure;
                ListFigures.list.Add(figure);
                var row = _table.NewRow();
                row[0] = figure.Name;
                row[1] = figure.X;
                row[2] = figure.Y;
                row[3] = figure.CalculationArea();
                _table.Rows.Add(row);
            }
        }



        private void RemoveTheLine(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить обьект?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewCell cell in FigureGridView.SelectedCells)
                {
                    FigureGridView.Rows.RemoveAt(cell.RowIndex);
                }
            }
        }

        private void OptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Все не сохраннёные данные могут быть потеряны. Создать новый файл?", "New", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    _table.Rows.Clear();
                    ListFigures.list.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            serializer.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto;
            serializer.Formatting = Newtonsoft.Json.Formatting.Indented;

            var OpenFileDialog = new OpenFileDialog();
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var fileName = OpenFileDialog.FileName;

            using (StreamReader streamreader = new StreamReader(fileName))
            {
                using (Newtonsoft.Json.JsonReader jReader = new Newtonsoft.Json.JsonTextReader(streamreader))
                {
                    ListFigures.list = serializer.Deserialize<List<IFigure>>(jReader);

                    for (int i = 0; i < ListFigures.list.Count; i++)
                    {
                        var figure = ListFigures.list[i];
                        var row = _table.NewRow();
                        row[0] = figure.Name;
                        row[1] = figure.X;
                        row[2] = figure.Y;
                        row[3] = figure.CalculationArea();
                        _table.Rows.Add(row);
                    }
                }
            }
        }




        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.TypeNameHandling = TypeNameHandling.Auto;
            serializer.Formatting = Formatting.Indented;

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Figure | *.figure";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var fileName = saveFileDialog.FileName;

            using (StreamWriter streamwriter = new StreamWriter(fileName))
            {
                using (Newtonsoft.Json.JsonWriter jWriter = new Newtonsoft.Json.JsonTextWriter(streamwriter))
                {
                    serializer.Serialize(jWriter, ListFigures.list);
                }
            }
        }




        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Закрыть программу?", "Завершение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) Application.Exit();
        }


        private void Result_Enter(object sender, EventArgs e)
        {

        }

        private void Result_Enter_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
