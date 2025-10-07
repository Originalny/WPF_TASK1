using System;
using System.Globalization;
using System.Windows.Forms;

namespace WPF_KT1
{
    public partial class Form1 : Form
    {
        private double _first = 0;
        private string _op = null;
        private bool _newEntry = true;
        private readonly CultureInfo _ci = CultureInfo.CurrentCulture;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            txtDisplay.Text = "0";
        }

        private double ParseDisplay()
        {
            double.TryParse(txtDisplay.Text, NumberStyles.Float, _ci, out var v);

            return v;
        }

        private void SetDisplay(string s) => txtDisplay.Text = s;


        private void Digit_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;

            if (_newEntry || txtDisplay.Text == "0")
            {
                SetDisplay(b.Text);

                _newEntry = false;
            }
            else
            {
                SetDisplay(txtDisplay.Text + b.Text);
            }
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;

            if (_op != null && !_newEntry)
            {
                Result_Click(null, null);
            }

            _first = ParseDisplay();
            _op = b.Text;
            _newEntry = true;
        }

        private void ClearEverything_Click(object sender, EventArgs e)
        {
            _first = 0;
            _op = null;
            _newEntry = true;
            SetDisplay("0");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            _newEntry = true;
            SetDisplay("0");
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (_newEntry) return;

            if (txtDisplay.Text.Length > 1)
            {
                SetDisplay(txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1));
            }
            else
            {
                SetDisplay("0");
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            var sep = _ci.NumberFormat.NumberDecimalSeparator;

            if (_newEntry)
            {
                SetDisplay("0" + sep);

                _newEntry = false;
            }
            else if (!txtDisplay.Text.Contains(sep))
            {
                SetDisplay(txtDisplay.Text + sep);
            }
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0") return;

            if (txtDisplay.Text.StartsWith("-"))
            {
                SetDisplay(txtDisplay.Text.Substring(1));
            }
            else
            {
                SetDisplay("-" + txtDisplay.Text);
            }
        }

        private void Result_Click(object sender, EventArgs e)
        {
            if (_op == null)
            {
                return;
            }

            var second = ParseDisplay();

            double result = 0;

            switch (_op)
            {
                case "/":
                    if (second == 0)
                    {
                        MessageBox.Show("ERROR");
                        return;
                    }

                    result = _first / second;
                    break;

                case "X":
                    result = _first * second;
                    break;

                case "-":
                    result = _first - second;
                    break;

                case "+":
                    result = _first + second;
                    break;
            }

            SetDisplay(result.ToString());

            _op = null;
            _newEntry = true;
            _first = result;
        }
    }
}
