using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public void NumericalSolution(double leftBorder, double rightBorder, double accuracy, bool multipleRoots)
        {
            _roots.Clear();
            for (int i = 0; i < _listTextBoxX.Count; i++)
            {
                _listPanel[i].Visible = false;
                _listTextBoxX[i].Text = string.Empty;
            }
            double middle;
            for (double step = leftBorder; step < rightBorder; step += 0.01)
            {
                if (Function(leftBorder) * Function(step) < 0)
                {
                    while (Function(leftBorder) < accuracy && Function(step) > accuracy)
                    {
                        middle = (step + leftBorder) / 2;
                        if (Function(leftBorder) * Function(middle) < 0) step = middle;
                        else leftBorder = middle;
                    }
                    _roots.Add(Math.Round(step, trackBar.Value));
                    leftBorder = step;
                    if (!multipleRoots) break;
                }
            }
            if (_roots.Count == 0)
            {
                _listPanel[0].Visible = true;
                _listTextBoxX[0].Text = "Нет корней";
            }
            else
            {
                for (int i = 0; i < _roots.Count; i++)
                {
                    _listPanel[i].Visible = true;
                    _listTextBoxX[i].Text = $"{_roots[i]}";
                }
            }
        }

        public double Function(double x)
        {
            return _a[5] * Math.Pow(x, 5) + _a[4] * Math.Pow(x, 4) + _a[3] * Math.Pow(x, 3) + _a[2] * Math.Pow(x, 2) + _a[1] * x + _a[0];
        }
    }
}