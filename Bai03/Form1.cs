namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txt1.SelectionStart;
            string originalText = txt1.Text;
            string filteredText = string.Concat(originalText.Where(char.IsDigit));
            if (originalText != filteredText)
            {
                MessageBox.Show("Vui lòng nhập số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (filteredText.Length > 12)
            {
                filteredText = filteredText.Substring(0, 12);
            }
            txt1.Text = filteredText;
            txt1.SelectionStart = cursorPosition > filteredText.Length ? filteredText.Length : cursorPosition;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();

        }
        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txt1.Text;

            if (long.TryParse(input, out long numberToRead) && input.Length <= 12)
            {
                
                txt2.Text = ConvertNumberToWords(numberToRead);
            }
            else
            {
                
                txt2.Text = "Vui lòng nhập một số nguyên tối đa 12 chữ số.";
            }
        }
        private string ConvertNumberToWords(long number)
        {
            if (number == 0) return "Không";

            string[] units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] teens = { "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
            string[] tens = { "", "", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            string[] thousands = { "", "nghìn", "triệu", "tỷ" };

            string words = "";
            int thousandIndex = 0;

            while (number > 0)
            {
                int part = (int)(number % 1000);
                if (part > 0)
                {
                    words = ConvertThreeDigitNumberToWords(part) + " " + thousands[thousandIndex] + " " + words;
                }
                number /= 1000;
                thousandIndex++;
            }

            return words.Trim();
        }
        private string ConvertThreeDigitNumberToWords(int number)
        {
            string[] ones = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] teens = { "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
            string[] tens = { "", "", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

            string words = "";
            if (number / 100 > 0)
            {
                words += ones[number / 100] + " tram ";
                number %= 100;
            }
            if (number / 10 > 1)
            {
                words += tens[number / 10] + " ";
                number %= 10;
            }
            else if (number / 10 == 1)
            {
                words += teens[number - 10] + " ";
                return words.Trim();
            }

            if (number > 0)
            {
                words += ones[number] + " ";
            }

            return words.Trim();
        }

        
    }
}