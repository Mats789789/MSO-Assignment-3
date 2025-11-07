namespace MSO3
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            loadProgramToolStripMenuItem = new ToolStripMenuItem();
            basicToolStripMenuItem = new ToolStripMenuItem();
            advancedToolStripMenuItem = new ToolStripMenuItem();
            expertToolStripMenuItem = new ToolStripMenuItem();
            fromFileToolStripMenuItemProgram = new ToolStripMenuItem();
            filePathProgramInput = new ToolStripTextBox();
            loadGridToolStripMenuItem = new ToolStripMenuItem();
            x3ToolStripMenuItem = new ToolStripMenuItem();
            x5ToolStripMenuItem = new ToolStripMenuItem();
            fromFileToolStripMenuItemGrid = new ToolStripMenuItem();
            filePathGridInput = new ToolStripTextBox();
            InputTextBox = new TextBox();
            RunButton = new Button();
            programViewPanel = new Panel();
            OutPutTextBox = new TextBox();
            WarningBox = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { loadProgramToolStripMenuItem, loadGridToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1246, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadProgramToolStripMenuItem
            // 
            loadProgramToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicToolStripMenuItem, advancedToolStripMenuItem, expertToolStripMenuItem, fromFileToolStripMenuItemProgram });
            loadProgramToolStripMenuItem.Name = "loadProgramToolStripMenuItem";
            loadProgramToolStripMenuItem.Size = new Size(91, 20);
            loadProgramToolStripMenuItem.Text = "LoadProgram";
            // 
            // basicToolStripMenuItem
            // 
            basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            basicToolStripMenuItem.Size = new Size(145, 22);
            basicToolStripMenuItem.Text = "Basic";
            basicToolStripMenuItem.Click += basicToolStripMenuItem_Click;
            // 
            // advancedToolStripMenuItem
            // 
            advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            advancedToolStripMenuItem.Size = new Size(145, 22);
            advancedToolStripMenuItem.Text = "Advanced";
            advancedToolStripMenuItem.Click += advancedToolStripMenuItem_Click;
            // 
            // expertToolStripMenuItem
            // 
            expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            expertToolStripMenuItem.Size = new Size(145, 22);
            expertToolStripMenuItem.Text = "Expert";
            expertToolStripMenuItem.Click += expertToolStripMenuItem_Click;
            // 
            // fromFileToolStripMenuItemProgram
            // 
            fromFileToolStripMenuItemProgram.DropDownItems.AddRange(new ToolStripItem[] { filePathProgramInput });
            fromFileToolStripMenuItemProgram.Name = "fromFileToolStripMenuItemProgram";
            fromFileToolStripMenuItemProgram.Size = new Size(145, 22);
            fromFileToolStripMenuItemProgram.Text = "From filepath";
            // 
            // filePathProgramInput
            // 
            filePathProgramInput.Name = "filePathProgramInput";
            filePathProgramInput.Size = new Size(200, 23);
            filePathProgramInput.KeyDown += filePathProgramInputBox_KeyDown;
            // 
            // loadGridToolStripMenuItem
            // 
            loadGridToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { x3ToolStripMenuItem, x5ToolStripMenuItem, fromFileToolStripMenuItemGrid });
            loadGridToolStripMenuItem.Name = "loadGridToolStripMenuItem";
            loadGridToolStripMenuItem.Size = new Size(67, 20);
            loadGridToolStripMenuItem.Text = "LoadGrid";
            // 
            // x3ToolStripMenuItem
            // 
            x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            x3ToolStripMenuItem.Size = new Size(145, 22);
            x3ToolStripMenuItem.Text = "3x3";
            x3ToolStripMenuItem.Click += x3ToolStripMenuItem_Click;
            // 
            // x5ToolStripMenuItem
            // 
            x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
            x5ToolStripMenuItem.Size = new Size(145, 22);
            x5ToolStripMenuItem.Text = "5x5";
            x5ToolStripMenuItem.Click += x5ToolStripMenuItem_Click;
            // 
            // fromFileToolStripMenuItemGrid
            // 
            fromFileToolStripMenuItemGrid.DropDownItems.AddRange(new ToolStripItem[] { filePathGridInput });
            fromFileToolStripMenuItemGrid.Name = "fromFileToolStripMenuItemGrid";
            fromFileToolStripMenuItemGrid.Size = new Size(145, 22);
            fromFileToolStripMenuItemGrid.Text = "From filepath";
            // 
            // filePathGridInput
            // 
            filePathGridInput.Name = "filePathGridInput";
            filePathGridInput.Size = new Size(100, 23);
            filePathGridInput.KeyDown += filePathGridInputBox_KeyDown;
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new System.Drawing.Point(12, 89);
            InputTextBox.Multiline = true;
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(419, 551);
            InputTextBox.TabIndex = 1;
            InputTextBox.TextChanged += inputTextBox_TextChanged;
            // 
            // RunButton
            // 
            RunButton.Location = new System.Drawing.Point(127, 48);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(173, 35);
            RunButton.TabIndex = 2;
            RunButton.Text = "Run Program";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += runProgramButton_Click;
            // 
            // programViewPanel
            // 
            programViewPanel.Location = new System.Drawing.Point(500, 89);
            programViewPanel.Name = "programViewPanel";
            programViewPanel.Size = new Size(672, 400);
            programViewPanel.TabIndex = 3;
            programViewPanel.Paint += programViewPanel_Paint;
            // 
            // OutPutTextBox
            // 
            OutPutTextBox.Location = new System.Drawing.Point(500, 517);
            OutPutTextBox.Multiline = true;
            OutPutTextBox.Name = "OutPutTextBox";
            OutPutTextBox.ReadOnly = true;
            OutPutTextBox.Size = new Size(672, 152);
            OutPutTextBox.TabIndex = 4;
            // 
            // WarningBox
            // 
            WarningBox.Location = new System.Drawing.Point(12, 646);
            WarningBox.Name = "WarningBox";
            WarningBox.Size = new Size(419, 23);
            WarningBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 681);
            Controls.Add(WarningBox);
            Controls.Add(OutPutTextBox);
            Controls.Add(programViewPanel);
            Controls.Add(RunButton);
            Controls.Add(InputTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "MSO3";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadProgramToolStripMenuItem;
        private ToolStripMenuItem basicToolStripMenuItem;
        private ToolStripMenuItem advancedToolStripMenuItem;
        private ToolStripMenuItem expertToolStripMenuItem;
        private Button RunButton;
        private ToolStripMenuItem loadGridToolStripMenuItem;
        private ToolStripMenuItem x3ToolStripMenuItem;
        private ToolStripMenuItem x5ToolStripMenuItem;
        private ToolStripMenuItem fromFileToolStripMenuItemGrid;
        private ToolStripMenuItem fromFileToolStripMenuItemProgram;
        private Panel programViewPanel;
        private ToolStripTextBox filePathProgramInput;
        private ToolStripTextBox filePathGridInput;

        public TextBox InputTextBox;
        public TextBox OutPutTextBox;
        public TextBox WarningBox;
    }
}
