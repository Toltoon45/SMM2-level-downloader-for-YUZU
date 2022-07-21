using System.Diagnostics;
using System.Net;
namespace DownloadMarioLevels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_levelReplace_ID.Text = "000";
            try
            {
                textBox_levelPath.Text = System.IO.File.ReadAllText(@"TextBox.dat");
            }
            catch
            {

            }
        }
        WebClient marioID = new WebClient();
         async private void button_downloadLevel_Click(object sender, EventArgs e)
        {
            downloadLevel();
        }

        async private void downloadLevel()
        {
            label4.Text = "";
            try
            {
                string levelID = textBox_forLevel_ID.Text;
                levelID = levelID.Replace(" ", "-");
                marioID.DownloadFile($"https://tgrcode.com/mm2/level_data/{levelID}",
                    $@"{textBox_levelPath.Text}\course_data_{textBox_levelReplace_ID.Text}.bcd");

                nextLevelIDforReplace();
                label4.ForeColor = Color.Green;
                label4.Text = "Level load successful";
            }
            catch (Exception)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "file not downloaded";
            }
        }

        private void nextLevelIDforReplace()
        {
            if (Convert.ToInt16(textBox_levelReplace_ID.Text) < 9)
            {
                textBox_levelReplace_ID.Text = $"00{Convert.ToInt16(textBox_levelReplace_ID.Text) + 1}";
            }
            else if (Convert.ToInt16(textBox_levelReplace_ID.Text) >= 10 &&
                Convert.ToInt16(textBox_levelReplace_ID.Text) < 99)
            {
                textBox_levelReplace_ID.Text = $"0{Convert.ToInt16(textBox_levelReplace_ID.Text) + 1}";
            }
            else
                textBox_levelReplace_ID.Text = $"{Convert.ToInt16(textBox_levelReplace_ID.Text) + 1}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            try
            {
                Process.Start("explorer", $@"{textBox_levelPath.Text}");
            }
            catch
            {
                label4.ForeColor = Color.Red;
                label4.Text = "incorrect file path";
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.File.WriteAllText(@"TextBox.dat", textBox_levelPath.Text);
        }
    }
}