using System;
using System.Drawing;
using System.Windows.Forms;

namespace task_3_geom_v2
{
    public partial class Form1 : Form
    {
        //Размеры бумажных и экранных сиситем координат
        double X1 = -970;
        double X2 = 970;
        double Y1 = -550;
        double Y2 = 550;
        double I1 = 0;
        double I2 = 1940;
        double J1 = 1100;
        double J2 = 0;

        
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        //Заливки
        SolidBrush brWhite = new SolidBrush(Color.White);

        //Линии
        Pen penBlack = new Pen(Color.Black, 3);
        Pen penPink = new Pen(Color.Pink, 3);

        //Массив с координатами точек для линий 
        Point[] lines = new Point[4] { new Point(1000, 200), new Point(1200, 350), new Point(1000, 300), new Point(1200, 450) };
        

        public void Draw()
        {
            g.FillRectangle(brWhite,0, 0, 1940, 1100);

            //Координаты
            g.DrawLine(penBlack, 0, Height / 2, Width, Height/2);
            g.DrawLine(penBlack, Width/2, 0, Width/2, Height);

            //линии
            g.DrawLine(penPink, lines[0], lines[1]);
            g.DrawLine(penPink, lines[2], lines[3]);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }

        public void TransformMatrix(ref Point[] lines, double turn, double transferX, double transferY, double stretchingX, double stretchingY, ref Point[]currentLines)
        {


            //массивы для перевода в начало координат 
            double[,] matrixForFirstLine = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            double[,] matrixForSecondLine = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            
           

            if (checkBoxTransfer.Checked) // Сдвиг
            {
                double[,] matrix = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { transferX, transferY, 1 } };
              
                MultiplyMatrix(matrix, 0, 4, 2);               

            }
            if (checkBoxStretching.Checked) // Растяжение
            {
                //матрица для аффиного преобразования
                double[,] matrix = new double[3, 3] { { stretchingX, 0, 0 }, { 0, stretchingY, 0 }, { 0, 0, 1 } };

                //перевод в бумажные координаты
                FromSystemCoordinateDescartes();
                //заполнения массива для перехода в начало координат
                matrixForFirstLine[2, 0] = -currentLines[0].X;
                matrixForFirstLine[2, 1] = -currentLines[0].Y;
                matrixForSecondLine[2, 0] = -currentLines[1].X;
                matrixForSecondLine[2, 1] = -currentLines[1].Y;
                //переход в начало координат второй линии
                MultiplyMatrix(matrixForSecondLine, 2, 4, 2);
                //переход в начало координат первой линии
                MultiplyMatrix(matrixForFirstLine, 0, 2, 2);
                //аффинное преобразование
                MultiplyMatrix(matrix, 0, 4, 2);
                //перевод первой координаты в начально положение
                MultiplyMatrix(matrixForFirstLine, 0, 2, 1);
                //перевод второй координаты в начально положение
                MultiplyMatrix(matrixForSecondLine, 2, 4, 1);
                //перевод в экранные координаты
                FromSystemCoordinateScreen();
            }
            if (checkBoxReflectionY.Checked) //Отражение по X
            {              
                double[,] matrix = new double[3, 3] { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

                FromSystemCoordinateDescartes();
                matrixForFirstLine[2, 0] = -currentLines[0].X;
                matrixForFirstLine[2, 1] = -currentLines[0].Y;
                matrixForSecondLine[2, 0] = -currentLines[1].X;
                matrixForSecondLine[2, 1] = -currentLines[1].Y;
                MultiplyMatrix(matrixForSecondLine, 2, 4, 2);
                MultiplyMatrix(matrixForFirstLine, 0, 2, 2);
                MultiplyMatrix(matrix, 0, 4, 2);
                MultiplyMatrix(matrixForFirstLine, 0, 2, 1);
                MultiplyMatrix(matrixForSecondLine, 2, 4, 1);
                FromSystemCoordinateScreen();

            }
            if (checkBoxReflectionX.Checked) //Отражение по Y
            {
                double[,] matrix = new double[3, 3] { { 1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };

                FromSystemCoordinateDescartes();
                matrixForFirstLine[2, 0] = -currentLines[0].X;
                matrixForFirstLine[2, 1] = -currentLines[0].Y;
                matrixForSecondLine[2, 0] = -currentLines[1].X;
                matrixForSecondLine[2, 1] = -currentLines[1].Y;
                MultiplyMatrix(matrixForSecondLine, 2, 4, 2);
                MultiplyMatrix(matrixForFirstLine, 0, 2, 2);
                MultiplyMatrix(matrix, 0, 4, 2);
                MultiplyMatrix(matrixForFirstLine, 0, 2, 1);
                MultiplyMatrix(matrixForSecondLine, 2, 4, 1);
                FromSystemCoordinateScreen();
            }
            if (checkBoxTurn.Checked) //Поворот
            {
               
                turn = (turn * Math.PI) / 180;

                double[,] matrix = new double[3, 3] { { Math.Cos(turn), Math.Sin(turn), 0 }, { Math.Sin(turn)*(-1), Math.Cos(turn), 0 }, { 0, 0, 1 } };
                
                FromSystemCoordinateDescartes();
                matrixForFirstLine[2, 0] = -currentLines[0].X;
                matrixForFirstLine[2, 1] = -currentLines[0].Y;
                matrixForSecondLine[2, 0] = -currentLines[1].X;
                matrixForSecondLine[2, 1] = -currentLines[1].Y;
                MultiplyMatrix(matrixForSecondLine, 2, 4, 2);
                MultiplyMatrix(matrixForFirstLine, 0, 2, 2);
                MultiplyMatrix(matrix, 0, 4, 2);
                MultiplyMatrix(matrixForFirstLine, 0, 2, 1);
                MultiplyMatrix(matrixForSecondLine, 2, 4, 1);
                FromSystemCoordinateScreen();
            }
        }

        //a - значение счетчика
        //matrix - используемая матрица преобразований
        //current - исходный массив точек
        //deg - степень для -1
        public void MultiplyMatrix(double[,]matrix, int a, int N, int deg)
        {
            double c1,c2;
            
            for (int i = a; i < N; i++)
            {
                c1 = lines[i].X;
                c2 = lines[i].Y;

                lines[i].X = (int)(c1 * matrix[0, 0] + c2 * matrix[1, 0] + 1 * matrix[2, 0] * Math.Pow((-1), deg));
                lines[i].Y = (int)(c1 * matrix[0, 1] + c2 * matrix[1, 1] + 1 * matrix[2, 1] * Math.Pow((-1), deg));
               
            }

        }
        
        //массив для хранения координат для переноса в начало координат
        Point[] currentLines = new Point[2];
        //перевод в декартовые координаты
        public void FromSystemCoordinateDescartes()
        {
            
            lines[0].X = (int)(X2 - ((I2 - lines[0].X) / (I2 - I1)) * (X2 - X1));
            lines[0].Y = (int)(Y2 - ((lines[0].Y - J2) / (J1 - J2)) * (Y2 - Y1));

            lines[1].X = (int)(X2 - ((I2 - lines[1].X) / (I2 - I1)) * (X2 - X1));
            lines[1].Y = (int)(Y2 - ((lines[1].Y - J2) / (J1 - J2)) * (Y2 - Y1));

            lines[2].X = (int)(X2 - ((I2 - lines[2].X) / (I2 - I1)) * (X2 - X1));
            lines[2].Y = (int)(Y2 - ((lines[2].Y - J2) / (J1 - J2)) * (Y2 - Y1));

            lines[3].X = (int)(X2 - ((I2 - lines[3].X) / (I2 - I1)) * (X2 - X1));
            lines[3].Y = (int)(Y2 - ((lines[3].Y - J2) / (J1 - J2)) * (Y2 - Y1));

            //Массив чтоб не изменялся lines
            currentLines = new Point[2] { new Point(lines[0].X, lines[0].Y), new Point(lines[2].X, lines[2].Y) };
        }
        //перевод в экранные координаты
        public void FromSystemCoordinateScreen()
        {

            lines[0].X = (int)(I2 - ((X2 - lines[0].X) / (X2 - X1)) * (I2 - I1));
            lines[0].Y = (int)(J2 - ((Y2 - lines[0].Y) / (Y2 - Y1)) * (J2 - J1));

            lines[1].X = (int)(I2 - ((X2 - lines[1].X) / (X2 - X1)) * (I2 - I1));
            lines[1].Y = (int)(J2 - ((Y2 - lines[1].Y) / (Y2 - Y1)) * (J2 - J1));

            lines[2].X = (int)(I2 - ((X2 - lines[2].X) / (X2 - X1)) * (I2 - I1));
            lines[2].Y = (int)(J2 - ((Y2 - lines[2].Y) / (Y2 - Y1)) * (J2 - J1));

            lines[3].X = (int)(I2 - ((X2 - lines[3].X) / (X2 - X1)) * (I2 - I1));
            lines[3].Y = (int)(J2 - ((Y2 - lines[3].Y) / (Y2 - Y1)) * (J2 - J1));
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            double turn = Convert.ToDouble(numericUpDownTurn.Value);
            double TransferX = Convert.ToDouble(numericUpDownTransferX.Value);
            double TransferY = Convert.ToDouble(numericUpDownTransferY.Value);
            double StretchingX = Convert.ToDouble(numericUpDownStretchingX.Value);
            double StretchingY = Convert.ToDouble(numericUpDownStretchingY.Value);

            TransformMatrix(ref lines, turn, TransferX, TransferY, StretchingX, StretchingY, ref currentLines);
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            lines[0].X = 1000;
            lines[0].Y = 200;

            lines[1].X = 1200;
            lines[1].Y = 350;

            lines[2].X = 1000;
            lines[2].Y = 300;

            lines[3].X = 1200;
            lines[3].Y = 450;
            Draw();
            
        }
        
    }
}
