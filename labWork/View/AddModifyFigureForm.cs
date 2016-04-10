using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using View;

namespace View
{
    public partial class AddModifyFigureForm : Form
    {

        private byte _figure;

        public IFigure Figure { get; set; }

        public AddModifyFigureForm()
        {
            InitializeComponent();//Инициализация элемента
        }

        private void AddModifyFigureForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Нажатие по кнопке "Отмена"
        /// </summary>
        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        /// <summary>
        /// Нажатие по кнопке "Рассчитать"
        /// </summary>
        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                Model.IFigure figureModel = null;
                switch (_figure)
                {
                    case 0:
                        var triangle = new Triangle();
                        triangle.Side1 = Convert.ToInt32(Side1.Text);
                        triangle.Side2 = Convert.ToInt32(Side2.Text);
                        triangle.Side3 = Convert.ToInt32(Side3.Text);
                        triangle.X = Convert.ToInt32(X.Text);
                        triangle.Y = Convert.ToInt32(Y.Text);
                        figureModel = triangle;
                        break;

                    case 1:
                        var rectangle = new Model.Rectangle();
                        rectangle.Length = Convert.ToInt32(Length.Text);
                        rectangle.Width = Convert.ToInt32(Breadth.Text);
                        rectangle.X = Convert.ToInt32(X.Text);
                        rectangle.Y = Convert.ToInt32(Y.Text);
                        figureModel = rectangle;
                        break;
                    case 2:
                        var circle = new Circle();
                        circle.Radius = Convert.ToInt32(Radius.Text);
                        circle.X = Convert.ToInt32(X.Text);
                        circle.Y = Convert.ToInt32(Y.Text);
                        figureModel = circle;
                        break;


                }
                Figure = figureModel;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message);
            }
            }

   



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void Side1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58))
                e.Handled = true;
        }

        private void Side2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58))
                e.Handled = true;
        }

        private void Side3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58))
                e.Handled = true;
        }

        private void Length_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58))
                e.Handled = true;
        }

        private void Breadth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58))
                e.Handled = true;
        }

        private void Radius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58))
                e.Handled = true;
        }




        private void TriangleRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Side1.Visible = true;
            Side2.Visible = true;
            Side3.Visible = true;
            Length.Visible = false;
            Breadth.Visible = false;
            Radius.Visible = false;
            X.Visible = true;
            Y.Visible = true;
            _figure = 0;
        }

        private void RectangleRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Side1.Visible = false;
            Side2.Visible = false;
            Side3.Visible = false;
            Length.Visible = true;
            Breadth.Visible = true;
            Radius.Visible = false;
            X.Visible = true;
            Y.Visible = true;
            _figure = 1;
        }

        private void CircleRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Side1.Visible = false;
            Side2.Visible = false;
            Side3.Visible = false;
            Length.Visible = false;
            Breadth.Visible = false;
            Radius.Visible = true;
            X.Visible = true;
            Y.Visible = true;
            _figure = 2;
        }

        private void Side1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Side2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Side3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Length_TextChanged(object sender, EventArgs e)
        {

        }

        private void Breadth_TextChanged(object sender, EventArgs e)
        {

        }

        private void X_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void Y_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

