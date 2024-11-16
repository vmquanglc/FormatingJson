namespace Serialize___Deserialize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Format_click(object sender, EventArgs e)
        {
            var resultFormat = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    return;
                }

                resultFormat = textBox1.Text.Replace(@"\", "")
                 .Replace(@"""{", "{")
                 .Replace(@"}""", "}")
                 .Replace(@"""[", "[")
                 .Replace(@"]""", "]");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                textBox2.Text = resultFormat;
            }
        }
    }
}
