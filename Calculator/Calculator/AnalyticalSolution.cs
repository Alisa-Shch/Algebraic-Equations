using Calculation;
using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private void AnalyticalSolution()
        {
            _roots.Clear(); 
            _complexRoots.Clear();
            for (int i = 0; i < _listTextBoxX.Count; i++)
            {
                _listPanel[i].Visible = false;
                _listTextBoxX[i].Text = string.Empty;
            }
            switch (degreeBox.SelectedIndex)
            {
                case 0: _roots.Add(-_a[0]/_a[1]);
                    _listPanel[0].Visible = true;
                    textBoxX1.Text = $"{Math.Round(_roots[0], trackBar.Value)}";                    
                    break;
                case 1: Discriminant();
                    break;
                case 2: CardanosMethod();
                    break;
            }
        }

        private double D;
        private void Discriminant()
        {
            D = Math.Pow(_a[1], 2) - 4*_a[2]*_a[0];
            if (D > 0)
            {
                _roots.Add((-_a[1]-Math.Sqrt(D)) / (2*_a[2]));
                _roots.Add((-_a[1]+Math.Sqrt(D)) / (2*_a[2]));

                _listPanel[0].Visible = true;
                _listPanel[1].Visible = true;

                textBoxX1.Text = $"{Math.Round(_roots[0], trackBar.Value)}";
                textBoxX2.Text = $"{Math.Round(_roots[1], trackBar.Value)}";                
            }
            else if (D == 0)
            {
                _roots.Add(-_a[1] / (2 * _a[2]));
                _listPanel[0].Visible = true;
                textBoxX1.Text = $"{Math.Round(_roots[0], trackBar.Value)}";     
            }
            else
            {
                D *= -1;
                _complexRoots.Add(new СomplexNumber(-_a[1]/(2*_a[2]),  Math.Sqrt(D)/(2*_a[2]), trackBar.Value));
                _complexRoots.Add(new СomplexNumber(-_a[1]/(2*_a[2]), -Math.Sqrt(D)/(2*_a[2]), trackBar.Value));

                _listPanel[0].Visible = true;
                _listPanel[1].Visible = true;

                textBoxX1.Text = $"{_complexRoots[0]}";
                textBoxX2.Text = $"{_complexRoots[1]}";
            }
        }

        private double q, p, w;
        private void CardanosMethod()
        {
            q = (2*Math.Pow(_a[2], 3) - 9*_a[3]*_a[2]*_a[1] + 27*Math.Pow(_a[3], 2)*_a[0]) / (27*Math.Pow(_a[3], 3));
            p = (3*_a[3]*_a[1] - Math.Pow(_a[2], 2)) / (3*Math.Pow(_a[3], 2));
            D = Math.Pow(q/2.0, 2) + Math.Pow(p/3.0, 3);

            if (D < 0)
            {
                if (q < 0) w = Math.Atan(Math.Sqrt(-D)/-(q/2.0));
                else if (q > 0) w = Math.Atan(Math.Sqrt(-D)/-(q/2.0)) + Math.PI;
                else w = Math.PI/2.0;

                _roots.Add((2*Math.Sqrt(-p/3.0) * Math.Cos(w/3.0)) - _a[2]/(3*_a[3]));
                _roots.Add((2*Math.Sqrt(-p/3.0) * Math.Cos(w/3.0 + 2*Math.PI/3.0)) - _a[2]/(3*_a[3]));
                _roots.Add((2*Math.Sqrt(-p/3.0) * Math.Cos(w/3.0 + 4*Math.PI/3.0)) - _a[2]/(3*_a[3]));

                _listPanel[0].Visible = true;
                _listPanel[1].Visible = true;
                _listPanel[2].Visible = true;

                textBoxX1.Text = $"{Math.Round(_roots[0], trackBar.Value)}";
                textBoxX2.Text = $"{Math.Round(_roots[1], trackBar.Value)}";
                textBoxX3.Text = $"{Math.Round(_roots[2], trackBar.Value)}";             
            }
            else if (D == 0)
            {
                if (p == 0 && q == 0)
                {
                    _roots.Add(-_a[2]/(3*_a[3]));

                    _listPanel[0].Visible = true;

                    textBoxX1.Text = $"{Math.Round(_roots[0], trackBar.Value)}";
                }
                else
                {
                    if (q/2.0 > 0)
                    {
                        _roots.Add(-2*Math.Pow(q/2.0, 1/3.0) - _a[2]/(3*_a[3]));
                        _roots.Add(Math.Pow(q/2.0, 1/3.0) - _a[2]/(3*_a[3]));
                    }
                    else
                    {
                        _roots.Add(2 *Math.Pow(-q/2.0, 1/3.0) - _a[2]/(3*_a[3]));
                        _roots.Add(-Math.Pow(-q/2.0, 1/3.0) - _a[2]/(3*_a[3]));
                    }
                    _listPanel[0].Visible = true;
                    _listPanel[1].Visible = true;

                    textBoxX1.Text = $"{Math.Round(_roots[0], trackBar.Value)}";
                    textBoxX2.Text = $"{Math.Round(_roots[1], trackBar.Value)}";
                }
            }
            else
            {
                double y1, y2;
                if (-q/2.0 + Math.Sqrt(D) > 0) y1 = Math.Pow(-q/2.0 + Math.Sqrt(D), 1/3.0);
                else y1 = -Math.Pow(q/2.0 - Math.Sqrt(D), 1/3.0);
                
                if (-q/2.0 - Math.Sqrt(D) > 0) y2 = Math.Pow(-q/2.0 - Math.Sqrt(D), 1/3.0);
                else y2 = -Math.Pow(q/2.0 + Math.Sqrt(D), 1/3.0);

                _roots.Add(y1 + y2 - _a[2] / (3 * _a[3]));
                _complexRoots.Add(new СomplexNumber(-1/2.0 * (y1+y2) - _a[2]/(3*_a[3]),  Math.Sqrt(3)/2.0 * (y1-y2), trackBar.Value));
                _complexRoots.Add(new СomplexNumber(-1/2.0 * (y1+y2) - _a[2]/(3*_a[3]), -Math.Sqrt(3)/2.0 * (y1-y2), trackBar.Value));

                _listPanel[0].Visible = true;
                _listPanel[1].Visible = true;
                _listPanel[2].Visible = true;

                textBoxX1.Text = $"{Math.Round(_roots[0], trackBar.Value)}";
                textBoxX2.Text = $"{_complexRoots[0]}";
                textBoxX3.Text = $"{_complexRoots[1]}";
            }
        }
    }
}