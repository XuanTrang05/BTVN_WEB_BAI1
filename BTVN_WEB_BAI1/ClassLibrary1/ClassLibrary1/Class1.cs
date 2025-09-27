using System;
using System.Text;

namespace MultiToolLib
{
    public class MultiTool
    {
        // Thuộc tính đầu vào
        public string InputText { get; set; }

        // Thuộc tính đầu ra (chỉ đọc bên ngoài)
        public string OutputText { get; private set; }

        // Dấu ấn cá nhân
        public string Signature { get; set; }

        public MultiTool()
        {
            InputText = string.Empty;
            OutputText = string.Empty;
            Signature = "-- by HoangT_XTrang";
        }

        // Hàm xử lý chính
        public bool Process()
        {
            try
            {
                if (InputText == null) InputText = string.Empty;
                string trimmed = InputText.Trim();

                if (trimmed.Length == 0)
                {
                    OutputText = BuildEmptyArt();
                    return true;
                }

                OutputText = BuildArt(trimmed);
                return true;
            }
            catch (Exception ex)
            {
                OutputText = "ERROR: " + ex.Message;
                return false;
            }
        }

        private string BuildEmptyArt()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("+----------------------+");
            sb.AppendLine("|   (no input given)   |");
            sb.AppendLine("+----------------------+");
            sb.AppendLine(Signature);
            return sb.ToString();
        }

        private string BuildArt(string txt)
        {
            string up = txt.ToUpper();
            string pattern = MakeWavePattern(up);
            int width = Math.Max(30, up.Length + 10);
            string border = new string('-', width);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("/" + border + "\\");

            string[] lines = pattern.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string centered = CenterText(line, width);
                sb.AppendLine("|" + centered + "|");
            }

            sb.AppendLine("\\" + border + "/");
            sb.AppendLine("Generated: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.AppendLine(Signature);

            return sb.ToString();
        }

        private string MakeWavePattern(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int shift = 0; shift < 3; shift++)
            {
                StringBuilder line = new StringBuilder();
                for (int i = 0; i < s.Length; i++)
                {
                    int pad = (i + shift) % 3; // 0,1,2
                    line.Append(new string(' ', pad));
                    line.Append(s[i]);
                    if (i < s.Length - 1) line.Append(' ');
                }
                sb.AppendLine(line.ToString().TrimEnd());
            }

            sb.AppendLine();
            sb.AppendLine(RepeatWithSeparator(s, " ~ ", 2));

            return sb.ToString();
        }

        private string RepeatWithSeparator(string s, string sep, int times)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                if (i > 0) sb.Append(sep);
                sb.Append(s);
            }
            return sb.ToString();
        }

        private string CenterText(string text, int width)
        {
            if (text.Length >= width) return text.Substring(0, width);
            int left = (width - text.Length) / 2;
            int right = width - text.Length - left;
            return new string(' ', left) + text + new string(' ', right);
        }

        // Hàm hỗ trợ gọi nhanh
        public string ProcessToString()
        {
            Process();
            return OutputText;
        }
    }
}
