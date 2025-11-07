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
            inputTextBox = new TextBox();
            run_button = new Button();
            programViewPanel = new Panel();
            outPutTextBox = new TextBox();
            warningTextBox = new TextBox();
            metrics_button = new Button();
            reset_button = new Button();
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
            // inputTextBox
            // 
            inputTextBox.Location = new System.Drawing.Point(12, 89);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(419, 551);
            inputTextBox.TabIndex = 1;
            inputTextBox.TextChanged += inputTextBox_TextChanged;
            // 
            // run_button
            // 
            run_button.Location = new System.Drawing.Point(127, 48);
            run_button.Name = "run_button";
            run_button.Size = new Size(173, 35);
            run_button.TabIndex = 2;
            run_button.Text = "Run Program";
            run_button.UseVisualStyleBackColor = true;
            run_button.Click += runProgramButton_Click;
            // 
            // programViewPanel
            // 
            programViewPanel.Location = new System.Drawing.Point(500, 89);
            programViewPanel.Name = "programViewPanel";
            programViewPanel.Size = new Size(672, 400);
            programViewPanel.TabIndex = 3;
            programViewPanel.Paint += programViewPanel_Paint;
            // 
            // outPutTextBox
            // 
            outPutTextBox.Location = new System.Drawing.Point(500, 517);
            outPutTextBox.Multiline = true;
            outPutTextBox.Name = "outPutTextBox";
            outPutTextBox.ReadOnly = true;
            outPutTextBox.Size = new Size(672, 152);
            outPutTextBox.TabIndex = 4;
            // 
            // warningTextBox
            // 
            warningTextBox.Location = new System.Drawing.Point(12, 646);
            warningTextBox.Name = "warningTextBox";
            warningTextBox.ReadOnly = true;
            warningTextBox.Size = new Size(419, 23);
            warningTextBox.TabIndex = 5;
            // 
            // metrics_button
            // 
            metrics_button.Location = new System.Drawing.Point(306, 54);
            metrics_button.Name = "metrics_button";
            metrics_button.Size = new Size(75, 23);
            metrics_button.TabIndex = 6;
            metrics_button.Text = "Metrics";
            metrics_button.UseVisualStyleBackColor = true;
            metrics_button.Click += metrics_button_Click;
            // 
            // reset_button
            // 
            reset_button.Location = new System.Drawing.Point(46, 54);
            reset_button.Name = "reset_button";
            reset_button.Size = new Size(75, 23);
            reset_button.TabIndex = 7;
            reset_button.Text = "Reset";
            reset_button.UseVisualStyleBackColor = true;
            reset_button.Click += reset_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 681);
            Controls.Add(reset_button);
            Controls.Add(metrics_button);
            Controls.Add(warningTextBox);
            Controls.Add(outPutTextBox);
            Controls.Add(programViewPanel);
            Controls.Add(run_button);
            Controls.Add(inputTextBox);
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
        private Button run_button;
        private ToolStripMenuItem loadGridToolStripMenuItem;
        private ToolStripMenuItem x3ToolStripMenuItem;
        private ToolStripMenuItem x5ToolStripMenuItem;
        private ToolStripMenuItem fromFileToolStripMenuItemGrid;
        private ToolStripMenuItem fromFileToolStripMenuItemProgram;
        private ToolStripTextBox filePathProgramInput;
        private ToolStripTextBox filePathGridInput;
        private Button metrics_button;

        public Panel programViewPanel;
        public TextBox inputTextBox;
        public TextBox outPutTextBox;
        public TextBox warningTextBox;
        private Button reset_button;
    }
}
