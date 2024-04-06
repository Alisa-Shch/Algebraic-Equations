using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class NumForm : Form
    {
        private MainForm _mainForm;
        private double _accuracy;
        private double _leftBorder;
        private double _rightBorder;
        private bool _multipleRoots;

        public NumForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _accuracy = Math.Pow(10, -trackBar1.Value);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            _mainForm.textBox_KeyPress(sender, e);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "-" && textBox2.Text != "-" && textBox1.Text.Length != 0 && textBox2.Text.Length != 0) button1.Visible = true;
            else button1.Visible = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _accuracy = Math.Pow(10, -trackBar1.Value);
            label3.Text = $"{_accuracy}";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _multipleRoots = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _leftBorder = Convert.ToDouble(textBox1.Text);
                _rightBorder = Convert.ToDouble(textBox2.Text);
                if (_mainForm.Function(_leftBorder)*_mainForm.Function(_rightBorder) > 0 && !_multipleRoots)
                {
                    MessageBox.Show("На отрезке имеется более одного корня");
                }
                else
                {
                    if (_leftBorder != _rightBorder)
                    {
                        if (_leftBorder < _rightBorder)
                        {
                            _mainForm.NumericalSolution(_leftBorder, _rightBorder, _accuracy, _multipleRoots);

                            Close();
                        }
                        else MessageBox.Show("Левая граница должна быть меньше правой");
                    }
                    else MessageBox.Show("Левая граница не должна быть равна правой");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}