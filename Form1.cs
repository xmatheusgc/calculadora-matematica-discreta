using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace projeto_md
{
    public partial class Form1 : Form
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetPlaceholders();
            if (cbFromBase.Items.Count > 0) cbFromBase.SelectedIndex = 0;
            if (cbToBase.Items.Count > 1) cbToBase.SelectedIndex = 1; // default to Binário
            if (cbBaseOps.Items.Count > 0) cbBaseOps.SelectedIndex = 0;
            if (cbOperation.Items.Count > 0) cbOperation.SelectedIndex = 0;
        }

        private void SetPlaceholders()
        {
            SetCue(txtValue, "Valor (ex: 13, 1011, A3)");
            SetCue(txtA_Ops, "Valor A");
            SetCue(txtB_Ops, "Valor B");
            SetCue(txtA_Euclid, "A (ex: 252)");
            SetCue(txtB_Euclid, "B (ex: 105)");
            SetCue(txtN, "N (>=2)");
        }

        private void SetCue(Control control, string cue)
        {
            if (control == null) return;
            SendMessage(control.Handle, EM_SETCUEBANNER, (IntPtr)0, cue);
        }

        // Conversion helpers and services
        private ConversionResult DecimalToBinary(int value)
        {
            var steps = new List<string>();
            if (value == 0)
            {
                steps.Add("0 / 2 = 0 resto 0");
                return new ConversionResult { Result = "0", Steps = steps };
            }

            var bits = new List<int>();
            int n = value;
            while (n > 0)
            {
                int q = n / 2;
                int r = n % 2;
                steps.Add($"{n} / 2 = {q} resto {r}");
                bits.Add(r);
                n = q;
            }
            bits.Reverse();
            return new ConversionResult { Result = string.Join("", bits), Steps = steps };
        }

        private ConversionResult DecimalToHex(int value)
        {
            var steps = new List<string>();
            if (value == 0)
            {
                steps.Add("0 / 16 = 0 resto 0");
                return new ConversionResult { Result = "0", Steps = steps };
            }

            var digits = new List<string>();
            int n = value;
            while (n > 0)
            {
                int q = n / 16;
                int r = n % 16;
                string digit = r < 10 ? r.ToString() : ((char)('A' + (r - 10))).ToString();
                steps.Add($"{n} / 16 = {q} resto {r} ({digit})");
                digits.Add(digit);
                n = q;
            }
            digits.Reverse();
            return new ConversionResult { Result = string.Join("", digits), Steps = steps };
        }

        private ConversionResult BinaryToDecimal(string bin)
        {
            var steps = new List<string>();
            int result = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                char c = bin[bin.Length - 1 - i];
                int bit = c == '1' ? 1 : 0;
                int term = bit * (int)Math.Pow(2, i);
                steps.Add($"{bit}×2^{i} = {term}");
                result += term;
            }
            return new ConversionResult { Result = result.ToString(), Steps = steps };
        }

        private ConversionResult HexToDecimal(string hex)
        {
            var steps = new List<string>();
            int result = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                char c = hex[hex.Length - 1 - i];
                int val;
                if (char.IsDigit(c)) val = c - '0';
                else val = char.ToUpper(c) - 'A' + 10;
                int term = val * (int)Math.Pow(16, i);
                steps.Add($"{val}×16^{i} = {term}");
                result += term;
            }
            return new ConversionResult { Result = result.ToString(), Steps = steps };
        }

        private bool ValidateBinary(string s)
        {
            return s.Length > 0 && s.All(c => c == '0' || c == '1');
        }

        private bool ValidateHex(string s)
        {
            if (s.Length == 0) return false;
            return s.All(c => char.IsDigit(c) || "ABCDEFabcdef".IndexOf(c) >= 0);
        }

        private ConversionResult ConvertAnyToAny(string value, string fromBase, string toBase)
        {
            // normalize
            value = value.Trim();
            int decimalValue;
            var allSteps = new List<string>();

            // From -> Decimal
            if (fromBase == "Decimal")
            {
                if (!int.TryParse(value, out decimalValue)) throw new ArgumentException("Valor decimal inválido");
            }
            else if (fromBase == "Binário")
            {
                if (!ValidateBinary(value)) throw new ArgumentException("Valor binário inválido");
                var dec = BinaryToDecimal(value);
                decimalValue = int.Parse(dec.Result);
                allSteps.AddRange(dec.Steps);
            }
            else // Hexadecimal
            {
                if (!ValidateHex(value)) throw new ArgumentException("Valor hexadecimal inválido");
                var dec = HexToDecimal(value);
                decimalValue = int.Parse(dec.Result);
                allSteps.AddRange(dec.Steps);
            }

            // Decimal -> To
            if (toBase == "Decimal")
            {
                return new ConversionResult { Result = decimalValue.ToString(), Steps = allSteps };
            }
            else if (toBase == "Binário")
            {
                var conv = DecimalToBinary(decimalValue);
                allSteps.AddRange(conv.Steps);
                return new ConversionResult { Result = conv.Result, Steps = allSteps };
            }
            else // Hexadecimal
            {
                var conv = DecimalToHex(decimalValue);
                allSteps.AddRange(conv.Steps);
                return new ConversionResult { Result = conv.Result, Steps = allSteps };
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                var from = cbFromBase.SelectedItem as string ?? "Decimal";
                var to = cbToBase.SelectedItem as string ?? "Binary";
                var res = ConvertAnyToAny(txtValue.Text, from, to);
                rtbStepsConv.Text = string.Join("\n", res.Steps);
                lblResultConv.Text = "Resultado: " + res.Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Operations: convert to decimal, perform op, convert back
        private void btnCalculateOps_Click(object sender, EventArgs e)
        {
            try
            {
                var baseName = cbBaseOps.SelectedItem as string ?? "Decimal";
                var op = cbOperation.SelectedItem as string ?? "Soma";
                var aStr = txtA_Ops.Text.Trim();
                var bStr = txtB_Ops.Text.Trim();
                var aDec = ConvertAnyToAny(aStr, baseName, "Decimal");
                var bDec = ConvertAnyToAny(bStr, baseName, "Decimal");
                int a = int.Parse(aDec.Result);
                int b = int.Parse(bDec.Result);
                long result;
                var steps = new List<string>();
                if (op == "Soma")
                {
                    result = (long)a + b;
                    steps.Add($"{a} + {b} = {result}");
                }
                else if (op == "Subtração")
                {
                    if (a < b) throw new InvalidOperationException("Esse tipo de operação não é suportada.");
                    result = a - b;
                    steps.Add($"{a} - {b} = {result}");
                }
                else // Multiplicação
                {
                    result = (long)a * b;
                    steps.Add($"{a} × {b} = {result}");
                }

                // convert result back to base
                var resConv = ConvertAnyToAny(result.ToString(), "Decimal", baseName);
                steps.AddRange(resConv.Steps);
                rtbStepsOps.Text = string.Join("\n", steps);
                lblResultOps.Text = "Resultado: " + resConv.Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Extended Euclid
        private void btnEuclid_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtA_Euclid.Text.Trim(), out int a)) throw new ArgumentException("A inválido");
                if (!int.TryParse(txtB_Euclid.Text.Trim(), out int b)) throw new ArgumentException("B inválido");

                var res = ExtendedEuclidService.Compute(a, b);
                rtbStepsEuclid.Text = string.Join("\n", res.Steps);
                lblResultEuclid.Text = $"Resultado: mdc({a},{b})={res.Gcd} => {res.Gcd} = {res.S}×{a} + {res.T}×{b}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sieve
        private void btnSieve_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtN.Text.Trim(), out int n) || n < 2) throw new ArgumentException("N inválido (>=2)");
                var res = EratosthenesService.Compute(n);
                rtbStepsSieve.Text = string.Join("\n", res.Steps);
                lblPrimes.Text = "Primos: " + string.Join(",", res.Primes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Models
    public class ConversionResult
    {
        public string Result { get; set; }
        public List<string> Steps { get; set; }
    }

    public class EuclidResult
    {
        public int Gcd { get; set; }
        public int S { get; set; }
        public int T { get; set; }
        public List<string> Steps { get; set; }
    }

    public class SieveResult
    {
        public List<int> Primes { get; set; }
        public List<string> Steps { get; set; }
    }

    // Services
    public static class ExtendedEuclidService
    {
        public static EuclidResult Compute(int a, int b)
        {
            var steps = new List<string>();
            int old_r = a, r = b;
            int old_s = 1, s = 0;
            int old_t = 0, t = 1;
            steps.Add($"Inicial: old_r={old_r}, r={r}, old_s={old_s}, s={s}, old_t={old_t}, t={t}");
            while (r != 0)
            {
                int q = old_r / r;
                int temp;
                temp = old_r - q * r;
                steps.Add($"{old_r} = {r}×{q} + {temp}");
                int new_r = old_r - q * r;
                old_r = r;
                r = new_r;

                int new_s = old_s - q * s;
                old_s = s;
                s = new_s;

                int new_t = old_t - q * t;
                old_t = t;
                t = new_t;

                steps.Add($"s={old_s}, t={old_t}, r={old_r}");
            }

            return new EuclidResult
            {
                Gcd = old_r,
                S = old_s,
                T = old_t,
                Steps = steps
            };
        }
    }

    public static class EratosthenesService
    {
        public static SieveResult Compute(int n)
        {
            var steps = new List<string>();
            var isPrime = new bool[n + 1];
            for (int i = 0; i <= n; i++) isPrime[i] = true;
            isPrime[0] = false; if (n >= 1) isPrime[1] = false;
            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    steps.Add($"{p} é primo");
                    var removed = new List<int>();
                    for (int multiple = p * p; multiple <= n; multiple += p)
                    {
                        if (isPrime[multiple])
                        {
                            isPrime[multiple] = false;
                            removed.Add(multiple);
                        }
                    }
                    if (removed.Count > 0)
                        steps.Add("Removendo múltiplos: " + string.Join(",", removed));
                }
            }
            var primes = new List<int>();
            for (int i = 2; i <= n; i++) if (isPrime[i]) primes.Add(i);
            steps.Add("Primos menores que " + n + ": " + string.Join(",", primes));
            return new SieveResult { Primes = primes, Steps = steps };
        }
    }
}
