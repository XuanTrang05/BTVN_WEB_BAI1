using System;

namespace WebAppDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnProcess_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string upper = input.ToUpper();
            int charCount = input.Length;
            int wordCount = string.IsNullOrEmpty(input)
                ? 0
                : input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

            litOutput.Text =
                $"<div class='result'>" +
                $"<p><b>Chuỗi in hoa:</b> {upper}</p>" +
                $"<p><b>Số ký tự:</b> {charCount}</p>" +
                $"<p><b>Số từ:</b> {wordCount}</p>" +
                $"</div>";
        }
    }
}
