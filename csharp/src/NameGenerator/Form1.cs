using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameGenerator
{
    public partial class Form1 : Form
    {
        private string[] alphabet = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                             "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                             "1","2","3","4","5","6","7","8","9","0"
                            };
        Random rand = new Random();
        public static readonly string DataFileDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NameGeneratorLog");
        string LogFileName { get { return Path.Combine(DataFileDirectory, "NameGeneratorLog.txt"); } }
        readonly object LogFileLock = new object();
        StreamWriter LogFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            string name = textName.Text = nameGenerate();
            string[] line = { new DateTime().ToString(), name, name.Length.ToString() };
            LogNames(string.Join(",", new DateTime().ToString(), name, name.Length.ToString()));
            btnGenerate.Enabled = true;
        }

        int randText()
        {
            return rand.Next(0, (alphabet.Length - 1));
        }

        string nameGenerate()
        {
            String name = "";
            int nameLength = (int)numericUpDown1.Value;
            if (nameLength >= 10)
            {
                for (int i = 1; i < nameLength; i++)
                {
                    name += alphabet[randText()];
                }
            }
            else
            {
                MessageBox.Show("Length of name must be greater 10");
                numericUpDown1.Value = 10;
            }
            Console.WriteLine("Name was created: " + name);
            return name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(LogFileName))
            {
                Directory.CreateDirectory(DataFileDirectory);
            }
        }


        void LogNames(string text)
        {
            lock (LogFileLock)
            {
                if (LogFile == null)
                {
                    bool existed = File.Exists(LogFileName);

                    LogFile = File.AppendText(LogFileName);
                    if (!existed)
                        LogFile.WriteLine("Time,Name,Length");
                    BeginInvoke((Action)(() => { btnGenerate.Visible = true; }));
                }
                LogFile.WriteLine(text);

            }
        }



    }
}
