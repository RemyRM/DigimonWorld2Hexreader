using System.Diagnostics;
using System.Text;

namespace DigimonWorld2HexReader
{
    public partial class HexReaderForm : Form
    {
        private int StartPadding { get; set; } = 0x00;
        private int BytesPerRow { get; set; } = 0x10;
        private int LastCaretPosition { get; set; }
        private byte[] LoadedFileData { get; set; }

        public HexReaderForm()
        {
            InitializeComponent();
            StartPaddingNumericUpDown.Maximum = BytesPerRow - 1;
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Bin files (*.bin)|*.bin|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (new FileInfo(openFileDialog.FileName).Length > 2_500_000)
                        if (MessageBox.Show("The selected file exceeds 2.5MB and stability can not be guaranteerd.\n" +
                                            "Are you sure you want to open the file regardless? This may freeze your PC attmepting to open it.", 
                                            "File size exceeds 2.5MB",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                            return;


                    LoadedFilenameLabel.Text = $"Loaded file: {Path.GetFileName(openFileDialog.FileName)}";
                    LoadedFileData = File.ReadAllBytes(openFileDialog.FileName);
                    UpdateHexdataText();

                    DecodedDataTextBox.SelectionStart = 0;
                    HexDataTextBox.SelectionStart = 0;
                }
            }
        }

        private void UpdateHexdataText()
        {
            OffsetTextBox.Clear();
            HexDataTextBox.Clear();
            DecodedDataTextBox.Clear();

            StringBuilder offsetText = new StringBuilder();
            StringBuilder hexText = new StringBuilder();
            StringBuilder decodedText = new StringBuilder();

            for (int i = 0; i < LoadedFileData.Length + StartPadding; i++)
            {
                //Add # to indicate padding bytes at the start
                if (i < StartPadding)
                {
                    hexText.Append("## ");
                    decodedText.Append('#');
                    continue;
                }


                if ((i % BytesPerRow) == 0 && i != 0)
                {
                    offsetText.Append($"{(i - BytesPerRow - StartPadding < 0 ? 0 : (i - BytesPerRow - StartPadding)):X8}{Environment.NewLine}");
                    hexText.Append(Environment.NewLine);
                    decodedText.Append(Environment.NewLine);
                }


                hexText.Append($"{LoadedFileData[i - StartPadding]:X2} ");

                // Use the byte value at the offset as the Key to the digitext table and add it to the decoded text
                if (CharacterTable.CharacterLookupTable.TryGetValue(LoadedFileData[i - StartPadding], out string value))
                    decodedText.Append($"{value}");
                else
                    decodedText.Append('.');



                if (i == LoadedFileData.Length - 1 && i % BytesPerRow > 0)
                    offsetText.Append($"{i - BytesPerRow - StartPadding + (16 - (i % BytesPerRow)):X8}");
            }

            OffsetTextBox.AppendText(offsetText.ToString());
            HexDataTextBox.AppendText(hexText.ToString());
            DecodedDataTextBox.AppendText(decodedText.ToString());
        }

        private void UpdateHexHeaderText()
        {
            StringBuilder hexWidthText = new StringBuilder();
            for (int i = 0; i < BytesPerRow; i++)
            {
                int x = (i + BytesPerRow - StartPadding) % BytesPerRow;
                hexWidthText.Append($"{x:X2} ");
            }

            HexOffsetLabel.Text = hexWidthText.ToString();
        }

        private void WidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BytesPerRow = (int)((NumericUpDown)sender).Value;

            StartPaddingNumericUpDown.Maximum = BytesPerRow - 1;
            UpdateHexHeaderText();
            UpdateHexdataText();
        }

        private void StartPaddingNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            StartPadding = (int)((NumericUpDown)sender).Value;
            UpdateHexHeaderText();
            UpdateHexdataText();
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox box = (RichTextBox)sender;
            Size size = TextRenderer.MeasureText(box.Text, box.Font);
            box.Width = size.Width;
            box.Height = size.Height;
        }

        private void HexDataTextBox_SelectionChanged(object sender, EventArgs e)
        {
            RichTextBox box = (RichTextBox)sender;

            // Get the current row and column that the caret is on
            int row = box.SelectionStart / ((BytesPerRow * 3) + 1);
            int col = ((box.SelectionStart - row) / 3) % BytesPerRow;

            // Get the address the caret is currently at
            int index = row * BytesPerRow + col - StartPadding;
            OffsetAtCursorTextBox.Text = index.ToString("X");

            //Align the caret to either start of a byte or half a byte to prevent placing the cursor before a space
            if ((box.SelectionStart - row) % 3 == 2)
            {
                if (box.SelectionStart > LastCaretPosition)
                    box.SelectionStart++;
                else
                    box.SelectionStart -= 2;
            }

            LastCaretPosition = box.SelectionStart;
        }
    }
}