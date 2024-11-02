using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab4
{
    public partial class Bai5 : Form
    {
        // Địa chỉ API đăng nhập
        private const string LoginApiUrl = "https://nt106.uitiot.vn/auth/token";
        private const string UserApiUrl = "https://nt106.uitiot.vn/api/v1/user/me";
        private string token;

        public Bai5()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút LOGIN
        private async void btnLogin_Click_1(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo nội dung yêu cầu dưới dạng Form-Data
                    var requestData = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>("username", txtUsername.Text),
                        new KeyValuePair<string, string>("password", txtPassword.Text)
                    };
                    HttpContent content = new FormUrlEncodedContent(requestData);

                    // Gửi yêu cầu POST
                    HttpResponseMessage response = await client.PostAsync(LoginApiUrl, content);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        // Đọc dữ liệu trả về
                        ApiResult apiResult = JsonConvert.DeserializeObject<ApiResult>(responseContent);

                        // Lưu token để sử dụng sau
                        token = apiResult.Token;

                        // Hiển thị kết quả đăng nhập
                        txtResult.Text = $"{apiResult.TokenType} {apiResult.Token}\nĐăng nhập thành công";
                    }
                    else
                    {
                        var errorObject = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);
                        MessageBox.Show($"Đăng nhập thất bại: {errorObject.Detail}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
    // Lớp để lưu trữ kết quả trả về từ API
    public class ApiResult
        {
            [JsonProperty("access_token")]
            public string Token { get; set; }

            [JsonProperty("token_type")]
            public string TokenType { get; set; }
        }

        // Lớp để lưu trữ thông tin lỗi
        public class ErrorResponse
        {
            [JsonProperty("detail")]
            public string Detail { get; set; }
        }

        private async  void btnGetUserInfo_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    if (string.IsNullOrEmpty(token))
                    {
                        MessageBox.Show("Bạn cần đăng nhập trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Thêm token vào tiêu đề Authorization
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    // Gửi yêu cầu GET
                    HttpResponseMessage response = await client.GetAsync(UserApiUrl);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        // Đọc dữ liệu trả về
                        UserInfo userInfo = JsonConvert.DeserializeObject<UserInfo>(responseContent);

                        // Hiển thị thông tin người dùng
                        txtName .Text = userInfo.Username;
                        txtEmail.Text = userInfo.Email;
                        txtBirthday.Text = userInfo.birthday; // Đảm bảo trường này được hiển thị đúng
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi lấy thông tin người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
        public class UserInfo
        {
            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("birthday")] // Đảm bảo rằng "dob" là trường đúng từ API
            public string birthday { get; set; } // Tên thuộc tính có thể được đổi thành "Birthday"
        }
    }


  