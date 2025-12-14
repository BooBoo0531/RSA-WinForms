using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_App
{
    public partial class Form1 : Form
    {
        private BigInteger _n, _phi, _e, _d;

        private readonly Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        #region Core Algorithms

        private bool IsProbablePrime(BigInteger source, int certainty = 10)
        {
            if (source == 2 || source == 3) return true;
            if (source < 2 || source % 2 == 0) return false;

            BigInteger d = source - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }

            for (int i = 0; i < certainty; i++)
            {
                BigInteger a = GenerateRandomBigInteger(2, source - 2);
                BigInteger x = BigInteger.ModPow(a, d, source);

                if (x == 1 || x == source - 1) continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, source);
                    if (x == 1) return false;
                    if (x == source - 1) break;
                }

                if (x != source - 1) return false;
            }
            return true;
        }

        private BigInteger GenerateRandomBigInteger(BigInteger min, BigInteger max)
        {
            byte[] bytes = max.ToByteArray();
            BigInteger r;

            do
            {
                _random.NextBytes(bytes);
                bytes[bytes.Length - 1] &= (byte)0x7F; 
                r = new BigInteger(bytes);
            } while (r < min || r > max);

            return r;
        }

        private BigInteger GCD(BigInteger a, BigInteger b)
        {
            return BigInteger.GreatestCommonDivisor(a, b);
        }

        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            if (m == 1) return 0;
            BigInteger m0 = m;
            BigInteger y = 0, x = 1;

            while (a > 1)
            {
                if (m == 0) return 0;
                BigInteger q = a / m;
                (a, m) = (m, a % m);
                (x, y) = (y, x - q * y);
            }

            if (x < 0) x += m0;
            return x;
        }

        #endregion

        #region Event Handlers (Đã chỉnh sửa Logic)

        private void btnCreateKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BigInteger.TryParse(txtP.Text, out BigInteger p) ||
                    !BigInteger.TryParse(txtQ.Text, out BigInteger q))
                {
                    MessageBox.Show("Vui lòng nhập p và q hợp lệ!");
                    return;
                }

                if (!IsProbablePrime(p) || !IsProbablePrime(q))
                {
                    var result = MessageBox.Show("Cảnh báo: p hoặc q không phải là số nguyên tố.\nTiếp tục?",
                                                 "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No) return;
                }

                _n = p * q;
                txtN.Text = _n.ToString();

                _phi = (p - 1) * (q - 1);
                txtPhi.Text = _phi.ToString();

                if (string.IsNullOrWhiteSpace(txtE.Text)) txtE.Text = "65537";

                if (!BigInteger.TryParse(txtE.Text, out BigInteger valE))
                {
                    MessageBox.Show("e không hợp lệ"); return;
                }
                _e = valE;

                if (_e <= 1 || _e >= _phi || GCD(_e, _phi) != 1)
                {
                    MessageBox.Show("e không hợp lệ! (Phải nguyên tố cùng nhau với Phi(n))");
                    return;
                }

                _d = ModInverse(_e, _phi);
                txtD.Text = _d.ToString();

                lbPublicKey.Text = $"Public Key (e, n): ({_e}, {_n})";
                lbPrivateKey.Text = $"Private Key (d, n): ({_d}, {_n})";

                MessageBox.Show("Tạo khóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo khóa: " + ex.Message);
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.Title = "Chọn file văn bản (.txt)";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo fi = new FileInfo(ofd.FileName);
                        if (fi.Length > 5 * 1024 * 1024)
                        {
                            MessageBox.Show("File quá lớn! Chỉ nên dùng file nhỏ (< 5MB).");
                            return;
                        }

                        txtInput.Text = File.ReadAllText(ofd.FileName, Encoding.UTF8);

                        txtOutput.Clear();
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi đọc file: " + ex.Message); }
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text)) return;
            if (_n == 0 || _e == 0)
            {
                MessageBox.Show("Vui lòng tạo khóa trước!");
                return;
            }

            try
            {
                byte[] plainBytes = Encoding.UTF8.GetBytes(txtInput.Text);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < plainBytes.Length; i++)
                {
                    BigInteger m = new BigInteger(new byte[] { plainBytes[i], 0 });
                    BigInteger c = BigInteger.ModPow(m, _e, _n);

                    if (i > 0) sb.Append(',');
                    sb.Append(c);
                }

                txtOutput.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mã hóa: " + ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text)) return;
            if (_n == 0 || _d == 0)
            {
                MessageBox.Show("Vui lòng tạo khóa trước!");
                return;
            }

            try
            {
                string[] cipherArray = txtInput.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                List<byte> decryptedBytes = new List<byte>();

                foreach (string item in cipherArray)
                {
                    if (BigInteger.TryParse(item.Trim(), out BigInteger c))
                    {
                        BigInteger m = BigInteger.ModPow(c, _d, _n);
                        decryptedBytes.Add((byte)m);
                    }
                }

                txtOutput.Text = Encoding.UTF8.GetString(decryptedBytes.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi giải mã (Sai khóa hoặc sai định dạng): " + ex.Message);
            }
        }

        private void btnSaveFile_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOutput.Text))
            {
                MessageBox.Show("Không có kết quả để lưu!");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt";
                sfd.Title = "Lưu kết quả ra file";
                sfd.FileName = "ket_qua.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, txtOutput.Text, Encoding.UTF8);
                        MessageBox.Show("Đã lưu file thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi lưu file: " + ex.Message);
                    }
                }
            }
        }

        private void btnAutoGenerate_Click(object sender, EventArgs e)
        {
            BigInteger p, q;
            do { p = GenerateRandomBigInteger(100, 1000); } while (!IsProbablePrime(p));
            do { q = GenerateRandomBigInteger(100, 1000); } while (q == p || !IsProbablePrime(q));

            txtP.Text = p.ToString();
            txtQ.Text = q.ToString();
            txtE.Text = "65537";
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }

        #endregion


        private void btnCLear_Click(object sender, EventArgs e)
        {
            txtP.Clear();
            txtQ.Clear();
            txtE.Clear();
            txtN.Clear();
            txtPhi.Clear();
            txtD.Clear();
            txtInput.Clear();
            txtOutput.Clear();

            lbPublicKey.Text = "Public Key";
            lbPrivateKey.Text = "Private Key";

            _n = 0;
            _phi = 0;
            _e = 0;
            _d = 0;

            txtP.Focus();

        }
    }
}