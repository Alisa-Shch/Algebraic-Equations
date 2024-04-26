using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Calculator
{
    public partial class MainForm : Form
    {
        /*
        private void textBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox == _listTextBoxA[degreeBox.SelectedIndex + 1] && e.KeyValue == 9)
                {
                    e.IsInputKey = true;
                }
            }
        }
        */
       
        public void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                degreeBox.Enabled = false;
                if (e.KeyChar == 45 && textBox.SelectionStart == 0) {; }
                else
                {
                    if (e.KeyChar == '.') e.KeyChar = ',';
                    if (/*e.KeyChar != 9 &&*/ e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                    {
                        e.Handled = true;
                        MessageBox.Show("Только цифpы!");
                    }
                    //if (e.KeyChar == 9 && VerifyСoef(sender)) _listTextBoxA[_listTextBoxA.IndexOf(textBox)-1].Focus();
                    if (e.KeyChar == 13 && VerifyСoef(sender))
                    {
                        if (textBox.Text.Length > 0 && textBox.Text != "-") SendKeys.Send("{TAB}");
                        else MessageBox.Show("Bведите число");
                    }
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (Verify()) btnConfirm.Visible = true;
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                _hint.TryGetValue(textBox, out string text);
                if (textBox.Text == text)
                {
                    textBox.Text = string.Empty;
                    textBox.ForeColor = Color.Black;
                }
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                _hint.TryGetValue(textBox, out string text);
                if (textBox.Text.Length == 0)
                {
                    textBox.Text = text;
                    textBox.ForeColor = Color.Gray;
                }
            }
        }

        private void textBox_VisibleChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox) { if (textBox.Visible) textBox_Leave(sender, e); }
        }

        private void textBoxScale_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                try
                {
                    if (textBox.Text.Length != 0 && textBox.Text != "-")
                    {
                        _scale[textBox] = Convert.ToDouble(textBox.Text);

                        if (_scale[textBoxXMin] < _scale[textBoxXMax] && _scale[textBoxYMin] < _scale[textBoxYMax])
                        {
                            btnBuildGraph_Click(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        private void textBoxScale_Click(object sender, EventArgs e)
        {
            if (sender is TextBox textBox) textBox.SelectAll(); 
        }

        private void degreeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupBoxFx.Visible == false) groupBoxFx.Visible = true;
            for (int i = 0; i < _listTextBoxA.Count; i++)
            {
                _listTextBoxA[i].Visible = false;
                _listLabel[i].Visible = false;
                if (i < _listPanel.Count) _listPanel[i].Visible = false;
            }
            for (int i = 0; i < degreeBox.SelectedIndex + 2; i++)
            {
                _listTextBoxA[i].Visible = true;
                _listLabel[i].Visible = true;
            }
            for (int i = 0; i < degreeBox.SelectedIndex + 1; i++) _listPanel[i].Visible = true;
            if (degreeBox.SelectedIndex < 3)
            {
                btnFindRoots.Visible = true;
                btnCheckResult.Visible = true;
            }
            else 
            { 
                btnFindRoots.Visible = false;
                btnCheckResult.Visible = false;
            }
            if (degreeBox.SelectedIndex >= 2) btnSolveNum.Visible = true;
            else btnSolveNum.Visible = false;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            labelTrackBar.Text = $"{trackBar.Value}";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (VerifyMessage())
            {
                try
                {
                    for (int i = 0; i < degreeBox.SelectedIndex + 2; i++) _a[i] = Convert.ToDouble(_listTextBoxA[i].Text);
                    for (int i = 0; i < _listTextBoxA.Count; i++) _listTextBoxA[i].Enabled = false;
                    btnConfirm.Visible = false;
                    groupBox2.Enabled = true;
                    btnClear.Visible = true;
                    panel7.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chart.Series["Func"].Points.Clear();
            _roots.Clear();
            _complexRoots.Clear();
            for (int i = 0; i < _listTextBoxA.Count; i++)
            {
                _a[i] = 0;
                _listTextBoxA[i].Text = string.Empty;
                _listTextBoxA[i].Enabled = true;
                _listTextBoxA[i].Visible = false;
                _listLabel[i].Visible = false;
                if (i < _listPanel.Count)
                {
                    _listPanel[i].Visible = false;
                    _listTextBoxX[i].Text = string.Empty;
                    _listTextBoxfX[i].Text = string.Empty;
                    //_listPanelfx[i].Visible = true;
                }
            }
            degreeBox.SelectedIndex = -1;
            degreeBox.Enabled = true;
            groupBoxFx.Visible = false;
            groupBox2.Enabled = false;
            btnClear.Visible = false;
            panel7.Visible = false;
            //btnCheckResult.Enabled = false;
        }

        private void btnFindRoots_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _listTextBoxfX.Count; i++) { _listTextBoxfX[i].Text = string.Empty; }                
            AnalyticalSolution();
            //btnCheckResult.Enabled = true;
        }

        private void btnSolveNum_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _listTextBoxfX.Count; i++) { _listTextBoxfX[i].Text = string.Empty; }
            new NumForm(this).ShowDialog();
        }

        private void btnBuildGraph_Click(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisX.Minimum = _scale[textBoxXMin];
            chart.ChartAreas[0].AxisX.Maximum = _scale[textBoxXMax];
            chart.ChartAreas[0].AxisY.Minimum = _scale[textBoxYMin];
            chart.ChartAreas[0].AxisY.Maximum = _scale[textBoxYMax];

            chart.Series["Func"].Points.Clear();
            double y;
            for (double x = _scale[textBoxXMin]; x <= _scale[textBoxXMax]; x += 0.01)
            {
                y = _a[5] * Math.Pow(x, 5) + _a[4] * Math.Pow(x, 4) + _a[3] * Math.Pow(x, 3) + _a[2] * Math.Pow(x, 2) + _a[1] * x + _a[0];
                chart.Series["Func"].Points.AddXY(x, y);
            }
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            _scale[textBoxXMin] = _XMin;
            _scale[textBoxXMax] = _XMax;
            _scale[textBoxYMin] = _YMin;
            _scale[textBoxYMax] = _YMax;

            textBoxXMin.Text = _scale[textBoxXMin].ToString();
            textBoxXMax.Text = _scale[textBoxXMax].ToString();
            textBoxYMin.Text = _scale[textBoxYMin].ToString();
            textBoxYMax.Text = _scale[textBoxYMax].ToString();

            btnBuildGraph_Click(sender, e);

            chart.Visible = false;
            chart.ChartAreas[0].AxisY.ScaleView.ZoomReset(10);
            chart.ChartAreas[0].AxisX.ScaleView.ZoomReset(10);
            chart.Visible = true;
        }

        private void btnCheckResult_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _roots.Count; i++)
            {
                _listTextBoxfX[i].Text = $"{Math.Round(_a[3] * Math.Pow(_roots[i], 3) + _a[2] * Math.Pow(_roots[i], 2) + _a[1] * _roots[i] + _a[0], 10)}";
            }
        }

        private void chart_MouseEnter(object sender, EventArgs e)
        {
            ChartArea ca = chart.ChartAreas[0];
            ca.AxisX.ScaleView.Zoomable = true;
            ca.AxisY.ScaleView.Zoomable = true;
            ca.CursorX.AutoScroll = true;
            ca.CursorY.AutoScroll = true;
            ca.CursorX.IsUserSelectionEnabled = true;
            ca.CursorY.IsUserSelectionEnabled = true;
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label12, "Введите значения всех коэффициентов. \nИ обязательно укажите значение старшего коэффициента, \nотличное от нуля.");
        }
    }
}