using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace YATesseractTrainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uiLang.SelectedIndex = 0;
        }

        private void uiAddFont_Click(object sender, EventArgs e)
        {
            if (uiFontDialog.ShowDialog() == DialogResult.OK)
            {
                var font = uiFontDialog.Font;

                foreach (ListViewItem addedItem in uiFontsList.Items)
                {
                    if (addedItem.Text.Equals(font.Name) && addedItem.SubItems[1].Text.Equals(font.Style.ToString()) &&
                        addedItem.SubItems[2].Text.Equals(Math.Round(font.Size).ToString()))
                    {
                        return;
                    }
                }

                ListViewItem item = new ListViewItem();

                item.Text = font.Name;
                item.SubItems.Add(font.Style.ToString());
                item.SubItems.Add(Math.Round(font.Size).ToString());

                uiFontsList.Items.Add(item);
            }
        }

        private void uiRemoveFont_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in uiFontsList.SelectedItems)
            {
                uiFontsList.Items.Remove(item);
            }
        }

        private void uiOutputDirBtn_Click(object sender, EventArgs e)
        {
            if (uiOutputDirDialog.ShowDialog() == DialogResult.OK)
            {
                uiOutputDir.Text = uiOutputDirDialog.SelectedPath;
            }
        }

        private void uiInputDirBtn_Click(object sender, EventArgs e)
        {
            if (uiInputFileDialog.ShowDialog() == DialogResult.OK)
            {
                uiInputFile.Text = uiInputFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateData();
        }

        protected void generateData()
        {
            string[] lines = File.ReadAllLines(uiInputFile.Text);

            foreach (ListViewItem item in uiFontsList.Items)
            {
                int i = 0;
                foreach (var line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        var filename = uiFileName.Text + (i++);
                        DrawText(line, new Font(item.SubItems[0].Text, float.Parse(item.SubItems[2].Text)), Color.Black, Color.White).Save(uiOutputDir.Text + "\\" + filename + ".tiff", ImageFormat.Tiff);
                        File.WriteAllText(uiOutputDir.Text + "\\" + filename + ".gt.txt", line);
                    }
                }
            }

            MessageBox.Show("File(s) created successfully");
        }

        private Image DrawText(String text, Font font, Color textColor, Color backColor)
        {
            //first, create a dummy bitmap just to get a graphics object
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);

            //measure the string to see how big the image needs to be
            SizeF textSize = drawing.MeasureString(text, font);

            //free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            //create a new image of the right size
            img = new Bitmap((int)textSize.Width, (int)textSize.Height);

            drawing = Graphics.FromImage(img);

            //paint the background
            drawing.Clear(backColor);

            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);

            drawing.DrawString(text, font, textBrush, 0, 0);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            return img;

        }

        protected void generateData_old()
        {
            foreach (ListViewItem item in uiFontsList.Items)
            {
                _generate(uiInputFile.Text.Replace(@"\","/"), uiLang.SelectedItem.ToString(), item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, uiFileName.Text+ item.SubItems[2].Text+"_", uiOutputDir.Text);
            }

            MessageBox.Show("File(s) created successfully");
        }

        protected void _generate(string inputFile, string lang, string fontName, string fontStyle, string fontSize, string fName, string outDir)
        {
            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            //startInfo.StandardOutputEncoding = Encoding.UTF8;
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardError = false;
            startInfo.RedirectStandardOutput = false;
            startInfo.FileName = "java.exe";
            startInfo.WorkingDirectory = Environment.CurrentDirectory;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = " -jar GenerateTiffBox.jar \"" + inputFile + "\" \"" + lang + "\" \"" + fontName + "\" " + Constants.getStyle(fontStyle) + " " + fontSize + " \"" + fName + "\" \"" + outDir + "\" false";

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch(Exception ex)
            {
                // Log error.
            }
        }
    }
}
