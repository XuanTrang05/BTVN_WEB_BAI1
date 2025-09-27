using System;
using System.Windows.Forms;

namespace WindowsFormsApphehe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Khi bấm nút Xử lý
        private void btnProcess_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ txtInput
            string input = txtInput.Text;

            // Xử lý 1: chuyển thành chữ hoa
            string upper = input.ToUpper();

            // Xử lý 2: đếm số ký tự
            int charCount = input.Length;

            // Xử lý 3: đếm số từ
            string[] words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            // Hiển thị kết quả
            txtOutput.Text =
                "Chữ hoa: " + upper + "\n" +
                "Số ký tự: " + charCount + "\n" +
                "Số từ: " + wordCount;
        }

        // Khi nhập text, đồng bộ ra output (demo sự kiện TextChanged)
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            txtOutput.Text = txtInput.Text;
        }
    }
}
