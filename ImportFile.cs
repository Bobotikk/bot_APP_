// FilePath: ImportFile.cs
using System.IO;
using System.Windows.Forms;

namespace bot_APP_
{
    public static class ImportFile
    {
        // 用于缓存最后选择的文件路径
        private static string lastFilePath = "";

        public static void ImportFileToTextBox(RichTextBox textBox)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = string.IsNullOrEmpty(lastFilePath) ? "c:\\" : Path.GetDirectoryName(lastFilePath);
                openFileDialog.Filter = "Text files (*.txt)|*.txt|YAML files (*.yaml)|*.yaml|HTML files (*.html)|*.html|XML files (*.xml)|*.xml|JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lastFilePath = openFileDialog.FileName;
                    string fileContent = File.ReadAllText(openFileDialog.FileName);
                    textBox.Text = fileContent;
                }
            }
        }
    }
}