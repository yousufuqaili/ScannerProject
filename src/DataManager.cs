using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ScannerProject
{
    internal class DataManager
    {
        public string[] ReadAllData(string fileName)
        {
            try
            {
                return File.ReadAllLines(fileName);
            }
            catch
            {
                throw new System.ArgumentException("An error occured while reading your file!" +
                                          "\n Please make sure you type the .extention of your file!",
                                          "original");
            }
        }

        public void LoadAllData(string[] data, ListBox listBox)
        {
            var i = 0;

            foreach (var s in data)
            {
                var strb = new StringBuilder(s);

                data[i] = strb.ToString();
                listBox.Items.Add(data[i]);

                i++;
            }
        }

        public void SaveAllData(string fileName, string[] data)
        {
            var writer = new StreamWriter(fileName);

            foreach (var s in data)
            {
                writer.WriteLine(s);
            }

            writer.Close();
        }
    }
}
