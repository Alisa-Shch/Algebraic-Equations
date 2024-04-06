using Calculation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddComponents();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            btnConfirm.Location = new Point(groupBox1.Width/2 - btnConfirm.Width/2, 167); //(int)Math.Round(groupBox1.Height*82.67/100)
            btnClear.Location = new Point(groupBox1.Width/2 - btnClear.Width/2, 167);

            groupBoxFx.Location = new Point(groupBox1.Width/2 - groupBoxFx.Width/2, 99);

            groupBox1.Height = (int)(Height*34.83/100);

            groupBox2.Location = new Point(0, (int)(Height*93.1/100*38.3/100));
            groupBox2.Height = (int)(Height*57.24/100);

            //panel12.Width = (int)(groupBox2.Width * 45.61 / 100);
        }

        private List<TextBox> _listTextBoxA = new List<TextBox>();
        private List<TextBox> _listTextBoxX = new List<TextBox>();
        private List<TextBox> _listTextBoxfX = new List<TextBox>();
        private List<Label> _listLabel = new List<Label>();
        private List<Panel> _listPanel = new List<Panel>();
        private List<Panel> _listPanelfx = new List<Panel>();
        private Dictionary<TextBox, string> _hint = new Dictionary<TextBox, string>();
        private Dictionary<TextBox, double> _scale = new Dictionary<TextBox, double>();
        private double[] _a = new double[6];
        private List<double> _roots = new List<double>();
        //private List<double> _rootsNumSolution = new List<double>();
        private List<СomplexNumber> _complexRoots = new List<СomplexNumber>();

        private double _XMin = -20;
        private double _XMax = 20;
        private double _YMin = -20;
        private double _YMax = 20;

        private bool Verify()
        {
            try
            {
                for (int i = 0; i < degreeBox.SelectedIndex + 2; i++)
                {
                    _hint.TryGetValue(_listTextBoxA[i], out string text);
                    if (_listTextBoxA[i].Text == text || _listTextBoxA[i].Text == "-" || _listTextBoxA[i].Text.Length == 0) return false;
                }
                if (Convert.ToDouble(_listTextBoxA[degreeBox.SelectedIndex + 1].Text) == 0) return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            return false;
        }

        private bool VerifyMessage()
        {
            try
            {
                for (int i = 0; i < degreeBox.SelectedIndex + 2; i++)
                {
                    _hint.TryGetValue(_listTextBoxA[i], out string text);
                    if (_listTextBoxA[i].Text == text || _listTextBoxA[i].Text == "-" || _listTextBoxA[i].Text.Length == 0)
                    {
                        MessageBox.Show("Bведены не все коэффициенты");
                        return false;
                    }
                }
                if (Convert.ToDouble(_listTextBoxA[degreeBox.SelectedIndex + 1].Text) == 0)
                {
                    MessageBox.Show("Введите значение старшего коэффициента, отличное от нуля");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            return false;
        }

        private bool VerifyСoef(object sender)
        {
            try
            {
                if (sender is TextBox textBox)
                {
                    _hint.TryGetValue(textBox, out string text);
                    if (textBox.Text == text || textBox.Text.Length == 0) return true;
                    if (textBox == _listTextBoxA[degreeBox.SelectedIndex + 1] && (textBox.Text == "-" || Convert.ToDouble(textBox.Text) == 0))
                    {
                        MessageBox.Show("Введите значение старшего коэффициента, отличное от нуля");
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            return false;
        }

        private void AddComponents()
        {
            _listTextBoxA.Add(textBox_a0);
            _listTextBoxA.Add(textBox_a1);
            _listTextBoxA.Add(textBox_a2);
            _listTextBoxA.Add(textBox_a3);
            _listTextBoxA.Add(textBox_a4);
            _listTextBoxA.Add(textBox_a5);

            _listTextBoxX.Add(textBoxX1);
            _listTextBoxX.Add(textBoxX2);
            _listTextBoxX.Add(textBoxX3);
            _listTextBoxX.Add(textBoxX4);
            _listTextBoxX.Add(textBoxX5);

            _listTextBoxfX.Add(textBoxfX1);
            _listTextBoxfX.Add(textBoxfX2);
            _listTextBoxfX.Add(textBoxfX3);
            _listTextBoxfX.Add(textBoxfX4);
            _listTextBoxfX.Add(textBoxfX5);

            _listLabel.Add(labelCoeff0);
            _listLabel.Add(labelCoeff1);
            _listLabel.Add(labelCoeff2);
            _listLabel.Add(labelCoeff3);
            _listLabel.Add(labelCoeff4);
            _listLabel.Add(labelCoeff5);

            _listPanelfx.Add(panelFx1);
            _listPanelfx.Add(panelFx2);
            _listPanelfx.Add(panelFx3);
            _listPanelfx.Add(panelFx4);
            _listPanelfx.Add(panelFx5);

            _listPanel.Add(panelX1);
            _listPanel.Add(panelX2);
            _listPanel.Add(panelX3);
            _listPanel.Add(panelX4);
            _listPanel.Add(panelX5);

            _hint.Add(textBox_a0, "a₀");
            _hint.Add(textBox_a1, "a₁");
            _hint.Add(textBox_a2, "a₂");
            _hint.Add(textBox_a3, "a₃");
            _hint.Add(textBox_a4, "a₄");
            _hint.Add(textBox_a5, "a₅");

            _scale.Add(textBoxXMin, _XMin);
            _scale.Add(textBoxXMax, _XMax);
            _scale.Add(textBoxYMin, _YMin);
            _scale.Add(textBoxYMax, _YMax);

            textBoxXMin.Text = _XMin.ToString();
            textBoxXMax.Text = _XMax.ToString();
            textBoxYMin.Text = _YMin.ToString();
            textBoxYMax.Text = _YMax.ToString();

            chart.Series["Func"].Points.Clear();
        }
    }
}