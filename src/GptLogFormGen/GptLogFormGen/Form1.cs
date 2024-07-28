using System;
using System.Windows.Forms;

namespace GptLogFormGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            // Input validation
            if (!int.TryParse(txtNumRecords.Text, out int numRecords) || numRecords <= 0)
            {
                MessageBox.Show("Please enter a valid number of interaction records.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string title = txtTitle.Text;
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a conversation title.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string link = txtLink.Text;
            bool includeUtils = chkIncludeUtils.Checked;

            // Replace illegal characters in title for file name
            string sanitizedTitle = title.Replace(" ", "_").Replace("/", "").Replace("\\", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");

            // Generate output file name
            string outputFileName = $"GPT_Record_{DateTime.Now:yyMMdd_HHmmss}__{sanitizedTitle}.md";

            // Get the directory of the executable
            string executableDirectory = Environment.CurrentDirectory;
            string outputFilePath = System.IO.Path.Combine(executableDirectory, outputFileName);

            // Create the markdown content
            var content = GenerateMarkdownContent(numRecords, title, link, includeUtils);

            // Save the file
            try
            {
                System.IO.File.WriteAllText(outputFilePath, content);
                MessageBox.Show($"Generated file: {outputFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to generate file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }




        private string GenerateMarkdownContent(int numRecords, string title, string link, bool includeUtils)
        {
            var mdContent = new System.Text.StringBuilder();

            mdContent.AppendLine("# **===ChatLog===**");
            mdContent.AppendLine("---");
            mdContent.AppendLine("### Conversation_title:");
            mdContent.AppendLine($":label: {title}");
            mdContent.AppendLine();
            mdContent.AppendLine("### Personal_link:");
            mdContent.AppendLine(string.IsNullOrEmpty(link) ? ":sparkles: [Unavailable](## \"No link has been provided.\")" : $":sparkles: [Personal_link]({link})");
            mdContent.AppendLine();
            mdContent.AppendLine("### Interaction_Log_File_Creation_Date:");
            mdContent.AppendLine($":calendar: {DateTime.Now:yyyy-MM-dd, HH:mm:ss}.");
            mdContent.AppendLine();
            mdContent.AppendLine("---");
            mdContent.AppendLine();

            for (int i = 1; i <= numRecords; i++)
            {
                mdContent.AppendLine("# **User_question:**");
                mdContent.AppendLine();
                mdContent.AppendLine();
                mdContent.AppendLine("# **ChatGPT_answer:**");
                mdContent.AppendLine();
                mdContent.AppendLine();
            }

            if (includeUtils)
            {
                mdContent.AppendLine("<div style=\"page-break-after: always;\"></div>");
                mdContent.AppendLine();
                mdContent.AppendLine("# Utils");
                mdContent.AppendLine();
                mdContent.AppendLine("### Page-break");
                mdContent.AppendLine();
                mdContent.AppendLine("<div style=\"page-break-after: always;\"></div>");
                mdContent.AppendLine();
            }

            return mdContent.ToString();
        }
    }
}
