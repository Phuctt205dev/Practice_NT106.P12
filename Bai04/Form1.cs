using System;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Có thể khởi tạo giá trị mặc định cho labelResult nếu cần
            label3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Biến để lưu ngày tháng năm sinh
            DateTime birthDate;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthDate;

            // Kiểm tra xem ngày nhập vào có hợp lệ không
            if (DateTime.TryParseExact(textBox1.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out birthDate))
            {
                string zodiacSign = GetZodiacSign(birthDate);
                label3.Text = "" + zodiacSign;
            }
            else
            {
                label3.Text = "Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.";
            }
        }

        // Hàm để xác định cung hoàng đạo dựa trên ngày tháng sinh
        private string GetZodiacSign(DateTime birthDate)
        {
            int day = birthDate.Day;
            int month = birthDate.Month;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
                return "Bạch Dương (Aries)";
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
                return "Kim Ngưu (Taurus)";
            else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))
                return "Song Tử (Gemini)";
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
                return "Cự Giải (Cancer)";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "Sư Tử (Leo)";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return "Xử Nữ (Virgo)";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return "Thiên Bình (Libra)";
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return "Bọ Cạp (Scorpio)";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return "Nhân Mã (Sagittarius)";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                return "Ma Kết (Capricorn)";
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return "Bảo Bình (Aquarius)";
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
                return "Song Ngư (Pisces)";

            return "Không xác định";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
    }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
