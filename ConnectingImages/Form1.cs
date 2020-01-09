using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConnectingImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string fileName;
        private string[] imgsFiles;

        bool SetOutFileName()
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Выберите файл для сохранения результата";
            sf.Filter = "*.png|*.png|*.jpg|*.jpg|*.bmp|*.bmp";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                fileName = sf.FileName;
                return true;
            }
            return false;
        }
        bool OpenImgsFiles()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Выберите файлы для объединения";
            of.Multiselect = true;
            string extension = Path.GetExtension(fileName);
            of.Filter = $"*{extension}|*{extension}";
            if (of.ShowDialog() == DialogResult.OK)
            {
                imgsFiles = of.FileNames;
                return true;
            }
            return false;
        }
        
        Image[] OpenImgs(string[] isf)
        {
            return isf.Select(i => Bitmap.FromFile(i)).ToArray();
        }

        Bitmap CreateSeqImg(Image[] isf)
        {
            Bitmap res = new Bitmap(isf.Sum(i => i.Width), isf.Max(i => i.Height));
            int offset = 0;
            Graphics g = Graphics.FromImage(res);
            progressBar.BeginInvoke(new Action(() => 
            {
                progressBar.Maximum = isf.Count();
                progressBar.Value = 0;
            }));
            foreach (var img in isf)
            {
                g.DrawImage(img, new Rectangle(offset, 0, img.Width, img.Height));
                offset += img.Width;
                progressBar.BeginInvoke(new Action(() =>
                {
                    progressBar.Value += 1;
                }));
            }
            return res;
        }


        private void selectOutFile_Click(object sender, EventArgs e)
        {
            SetOutFileName();
        }

        private async void openImgSeq_Click(object sender, EventArgs e)
        {
            if (fileName == null || fileName == "")
            {
                MessageBox.Show("Выбирите файл для сохранения результата.");
                if (!SetOutFileName())
                {
                    return;
                }
            }
            if (OpenImgsFiles())
            {
                selectOutFile.Enabled = false;
                openImgSeq.Enabled = false;
                await Task.Factory.StartNew(new Action(() =>
                {
                   CreateSeqImg(OpenImgs(imgsFiles)).Save(fileName);
                }));
                selectOutFile.Enabled = true;
                openImgSeq.Enabled = true;
                MessageBox.Show("Готово.");
            }
        }
    }
}
