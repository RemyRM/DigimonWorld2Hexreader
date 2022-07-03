namespace DigimonWorld2HexReader
{
    partial class HexReaderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.HexLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HexDataTextBox = new System.Windows.Forms.RichTextBox();
            this.DecodedDataTextBox = new System.Windows.Forms.RichTextBox();
            this.OffsetTextBox = new System.Windows.Forms.RichTextBox();
            this.DataContainerPanel = new System.Windows.Forms.Panel();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartPaddingLabel = new System.Windows.Forms.Label();
            this.StartPaddingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LoadedFilenameLabel = new System.Windows.Forms.Label();
            this.HexLayoutPanelHeader = new System.Windows.Forms.TableLayoutPanel();
            this.AddressOffsetLabel = new System.Windows.Forms.Label();
            this.HexOffsetLabel = new System.Windows.Forms.Label();
            this.DecodedLabel = new System.Windows.Forms.Label();
            this.OffsetLabel = new System.Windows.Forms.Label();
            this.OffsetAtCursorTextBox = new System.Windows.Forms.TextBox();
            this.HexLayoutPanel.SuspendLayout();
            this.DataContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPaddingNumericUpDown)).BeginInit();
            this.HexLayoutPanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(19, 12);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(112, 40);
            this.LoadFileButton.TabIndex = 0;
            this.LoadFileButton.Text = "Load file";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // HexLayoutPanel
            // 
            this.HexLayoutPanel.AutoSize = true;
            this.HexLayoutPanel.ColumnCount = 3;
            this.HexLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.HexLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HexLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HexLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.HexLayoutPanel.Controls.Add(this.HexDataTextBox, 1, 0);
            this.HexLayoutPanel.Controls.Add(this.DecodedDataTextBox, 2, 0);
            this.HexLayoutPanel.Controls.Add(this.OffsetTextBox, 0, 0);
            this.HexLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HexLayoutPanel.Name = "HexLayoutPanel";
            this.HexLayoutPanel.RowCount = 1;
            this.HexLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.HexLayoutPanel.Size = new System.Drawing.Size(970, 656);
            this.HexLayoutPanel.TabIndex = 1;
            // 
            // HexDataTextBox
            // 
            this.HexDataTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.HexDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HexDataTextBox.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HexDataTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HexDataTextBox.Location = new System.Drawing.Point(103, 0);
            this.HexDataTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.HexDataTextBox.Name = "HexDataTextBox";
            this.HexDataTextBox.ReadOnly = true;
            this.HexDataTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.HexDataTextBox.Size = new System.Drawing.Size(429, 31);
            this.HexDataTextBox.TabIndex = 9;
            this.HexDataTextBox.Text = "00";
            this.HexDataTextBox.WordWrap = false;
            this.HexDataTextBox.SelectionChanged += new System.EventHandler(this.HexDataTextBox_SelectionChanged);
            this.HexDataTextBox.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // DecodedDataTextBox
            // 
            this.DecodedDataTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DecodedDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DecodedDataTextBox.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecodedDataTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DecodedDataTextBox.Location = new System.Drawing.Point(538, 0);
            this.DecodedDataTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.DecodedDataTextBox.Name = "DecodedDataTextBox";
            this.DecodedDataTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.DecodedDataTextBox.Size = new System.Drawing.Size(429, 31);
            this.DecodedDataTextBox.TabIndex = 10;
            this.DecodedDataTextBox.Text = "00";
            this.DecodedDataTextBox.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // OffsetTextBox
            // 
            this.OffsetTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.OffsetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OffsetTextBox.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OffsetTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.OffsetTextBox.Location = new System.Drawing.Point(3, 0);
            this.OffsetTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.OffsetTextBox.Name = "OffsetTextBox";
            this.OffsetTextBox.ReadOnly = true;
            this.OffsetTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.OffsetTextBox.Size = new System.Drawing.Size(94, 31);
            this.OffsetTextBox.TabIndex = 11;
            this.OffsetTextBox.Text = "00000000";
            this.OffsetTextBox.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // DataContainerPanel
            // 
            this.DataContainerPanel.AutoScroll = true;
            this.DataContainerPanel.Controls.Add(this.HexLayoutPanel);
            this.DataContainerPanel.Location = new System.Drawing.Point(20, 101);
            this.DataContainerPanel.Name = "DataContainerPanel";
            this.DataContainerPanel.Size = new System.Drawing.Size(989, 629);
            this.DataContainerPanel.TabIndex = 2;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WidthLabel.ForeColor = System.Drawing.Color.White;
            this.WidthLabel.Location = new System.Drawing.Point(1025, 32);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(88, 20);
            this.WidthLabel.TabIndex = 3;
            this.WidthLabel.Text = "Bytes width:";
            // 
            // WidthNumericUpDown
            // 
            this.WidthNumericUpDown.Location = new System.Drawing.Point(1132, 32);
            this.WidthNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.WidthNumericUpDown.Name = "WidthNumericUpDown";
            this.WidthNumericUpDown.Size = new System.Drawing.Size(52, 23);
            this.WidthNumericUpDown.TabIndex = 4;
            this.WidthNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.WidthNumericUpDown.ValueChanged += new System.EventHandler(this.WidthNumericUpDown_ValueChanged);
            // 
            // StartPaddingLabel
            // 
            this.StartPaddingLabel.AutoSize = true;
            this.StartPaddingLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartPaddingLabel.ForeColor = System.Drawing.Color.White;
            this.StartPaddingLabel.Location = new System.Drawing.Point(1025, 75);
            this.StartPaddingLabel.Name = "StartPaddingLabel";
            this.StartPaddingLabel.Size = new System.Drawing.Size(101, 20);
            this.StartPaddingLabel.TabIndex = 5;
            this.StartPaddingLabel.Text = "Start Padding:";
            // 
            // StartPaddingNumericUpDown
            // 
            this.StartPaddingNumericUpDown.Location = new System.Drawing.Point(1132, 75);
            this.StartPaddingNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.StartPaddingNumericUpDown.Name = "StartPaddingNumericUpDown";
            this.StartPaddingNumericUpDown.Size = new System.Drawing.Size(52, 23);
            this.StartPaddingNumericUpDown.TabIndex = 6;
            this.StartPaddingNumericUpDown.ValueChanged += new System.EventHandler(this.StartPaddingNumericUpDown_ValueChanged);
            // 
            // LoadedFilenameLabel
            // 
            this.LoadedFilenameLabel.AutoSize = true;
            this.LoadedFilenameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadedFilenameLabel.ForeColor = System.Drawing.Color.White;
            this.LoadedFilenameLabel.Location = new System.Drawing.Point(150, 23);
            this.LoadedFilenameLabel.Name = "LoadedFilenameLabel";
            this.LoadedFilenameLabel.Size = new System.Drawing.Size(0, 20);
            this.LoadedFilenameLabel.TabIndex = 7;
            // 
            // HexLayoutPanelHeader
            // 
            this.HexLayoutPanelHeader.AutoSize = true;
            this.HexLayoutPanelHeader.ColumnCount = 3;
            this.HexLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.HexLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HexLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HexLayoutPanelHeader.Controls.Add(this.AddressOffsetLabel, 0, 0);
            this.HexLayoutPanelHeader.Controls.Add(this.HexOffsetLabel, 1, 0);
            this.HexLayoutPanelHeader.Controls.Add(this.DecodedLabel, 2, 0);
            this.HexLayoutPanelHeader.Location = new System.Drawing.Point(17, 75);
            this.HexLayoutPanelHeader.Name = "HexLayoutPanelHeader";
            this.HexLayoutPanelHeader.RowCount = 1;
            this.HexLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.HexLayoutPanelHeader.Size = new System.Drawing.Size(970, 27);
            this.HexLayoutPanelHeader.TabIndex = 8;
            // 
            // AddressOffsetLabel
            // 
            this.AddressOffsetLabel.AutoSize = true;
            this.AddressOffsetLabel.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressOffsetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddressOffsetLabel.Location = new System.Drawing.Point(3, 0);
            this.AddressOffsetLabel.Name = "AddressOffsetLabel";
            this.AddressOffsetLabel.Size = new System.Drawing.Size(90, 20);
            this.AddressOffsetLabel.TabIndex = 0;
            this.AddressOffsetLabel.Text = "Offset 0x";
            // 
            // HexOffsetLabel
            // 
            this.HexOffsetLabel.AutoSize = true;
            this.HexOffsetLabel.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HexOffsetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HexOffsetLabel.Location = new System.Drawing.Point(103, 0);
            this.HexOffsetLabel.Name = "HexOffsetLabel";
            this.HexOffsetLabel.Size = new System.Drawing.Size(432, 20);
            this.HexOffsetLabel.TabIndex = 1;
            this.HexOffsetLabel.Text = "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F";
            // 
            // DecodedLabel
            // 
            this.DecodedLabel.AutoSize = true;
            this.DecodedLabel.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecodedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DecodedLabel.Location = new System.Drawing.Point(541, 0);
            this.DecodedLabel.Name = "DecodedLabel";
            this.DecodedLabel.Size = new System.Drawing.Size(72, 20);
            this.DecodedLabel.TabIndex = 2;
            this.DecodedLabel.Text = "Decoded";
            // 
            // OffsetLabel
            // 
            this.OffsetLabel.AutoSize = true;
            this.OffsetLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OffsetLabel.ForeColor = System.Drawing.Color.White;
            this.OffsetLabel.Location = new System.Drawing.Point(20, 733);
            this.OffsetLabel.Name = "OffsetLabel";
            this.OffsetLabel.Size = new System.Drawing.Size(71, 20);
            this.OffsetLabel.TabIndex = 9;
            this.OffsetLabel.Text = "Offset: 0x";
            // 
            // OffsetAtCursorTextBox
            // 
            this.OffsetAtCursorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.OffsetAtCursorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OffsetAtCursorTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OffsetAtCursorTextBox.ForeColor = System.Drawing.Color.White;
            this.OffsetAtCursorTextBox.Location = new System.Drawing.Point(86, 733);
            this.OffsetAtCursorTextBox.Name = "OffsetAtCursorTextBox";
            this.OffsetAtCursorTextBox.Size = new System.Drawing.Size(100, 20);
            this.OffsetAtCursorTextBox.TabIndex = 10;
            this.OffsetAtCursorTextBox.Text = "00000000";
            // 
            // HexReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1273, 758);
            this.Controls.Add(this.OffsetAtCursorTextBox);
            this.Controls.Add(this.OffsetLabel);
            this.Controls.Add(this.HexLayoutPanelHeader);
            this.Controls.Add(this.LoadedFilenameLabel);
            this.Controls.Add(this.StartPaddingNumericUpDown);
            this.Controls.Add(this.StartPaddingLabel);
            this.Controls.Add(this.WidthNumericUpDown);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.DataContainerPanel);
            this.Controls.Add(this.LoadFileButton);
            this.Name = "HexReaderForm";
            this.Text = "Form1";
            this.HexLayoutPanel.ResumeLayout(false);
            this.DataContainerPanel.ResumeLayout(false);
            this.DataContainerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPaddingNumericUpDown)).EndInit();
            this.HexLayoutPanelHeader.ResumeLayout(false);
            this.HexLayoutPanelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoadFileButton;
        private TableLayoutPanel HexLayoutPanel;
        private Panel DataContainerPanel;
        private Label WidthLabel;
        private NumericUpDown WidthNumericUpDown;
        private Label StartPaddingLabel;
        private NumericUpDown StartPaddingNumericUpDown;
        private Label LoadedFilenameLabel;
        private TableLayoutPanel HexLayoutPanelHeader;
        private Label AddressOffsetLabel;
        private Label HexOffsetLabel;
        private Label DecodedLabel;
        private RichTextBox HexDataTextBox;
        private RichTextBox DecodedDataTextBox;
        private RichTextBox OffsetTextBox;
        private Label OffsetLabel;
        private TextBox OffsetAtCursorTextBox;
    }
}