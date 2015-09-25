namespace Guitar
{
    partial class Guitar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guitar));
            this.Chooser = new System.Windows.Forms.OpenFileDialog();
            this.Saver = new System.Windows.Forms.SaveFileDialog();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Output = new System.Windows.Forms.TabPage();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.Fieldset = new System.Windows.Forms.Panel();
            this.Maker = new System.Windows.Forms.Panel();
            this.Make = new System.Windows.Forms.Button();
            this.Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.Clear = new System.Windows.Forms.Button();
            this.Choose = new System.Windows.Forms.Button();
            this.Website = new System.Windows.Forms.Label();
            this.Checksum = new System.Windows.Forms.CheckBox();
            this.Profile = new System.Windows.Forms.Label();
            this.Files = new System.Windows.Forms.ListView();
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Paths = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.StatusBar.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.Output.SuspendLayout();
            this.Table.SuspendLayout();
            this.Fieldset.SuspendLayout();
            this.Maker.SuspendLayout();
            this.Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chooser
            // 
            this.Chooser.Multiselect = true;
            this.Chooser.Title = "Choose Files";
            // 
            // Saver
            // 
            this.Saver.CheckPathExists = false;
            this.Saver.DefaultExt = "tar";
            this.Saver.FileName = "all.tar";
            this.Saver.Filter = "Tar File|*.tar";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Progress});
            this.StatusBar.Location = new System.Drawing.Point(3, 296);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(458, 22);
            this.StatusBar.TabIndex = 6;
            this.StatusBar.Text = "statusStrip1";
            // 
            // Progress
            // 
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(100, 16);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Output);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Tabs.Location = new System.Drawing.Point(3, 168);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(458, 128);
            this.Tabs.TabIndex = 7;
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.Black;
            this.Output.Controls.Add(this.OutputBox);
            this.Output.Location = new System.Drawing.Point(4, 22);
            this.Output.Name = "Output";
            this.Output.Padding = new System.Windows.Forms.Padding(4);
            this.Output.Size = new System.Drawing.Size(450, 102);
            this.Output.TabIndex = 0;
            this.Output.Text = "Output";
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.Black;
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.ForeColor = System.Drawing.Color.GreenYellow;
            this.OutputBox.Location = new System.Drawing.Point(4, 4);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(442, 94);
            this.OutputBox.TabIndex = 0;
            this.OutputBox.Text = "";
            // 
            // Table
            // 
            this.Table.ColumnCount = 2;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Controls.Add(this.Fieldset, 1, 0);
            this.Table.Controls.Add(this.Files, 0, 0);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(3, 3);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.Size = new System.Drawing.Size(458, 165);
            this.Table.TabIndex = 8;
            // 
            // Fieldset
            // 
            this.Fieldset.Controls.Add(this.Maker);
            this.Fieldset.Controls.Add(this.Buttons);
            this.Fieldset.Controls.Add(this.Website);
            this.Fieldset.Controls.Add(this.Checksum);
            this.Fieldset.Controls.Add(this.Profile);
            this.Fieldset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fieldset.Location = new System.Drawing.Point(232, 3);
            this.Fieldset.Name = "Fieldset";
            this.Fieldset.Padding = new System.Windows.Forms.Padding(16, 16, 16, 0);
            this.Fieldset.Size = new System.Drawing.Size(223, 159);
            this.Fieldset.TabIndex = 12;
            // 
            // Maker
            // 
            this.Maker.Controls.Add(this.Make);
            this.Maker.Dock = System.Windows.Forms.DockStyle.Top;
            this.Maker.Location = new System.Drawing.Point(16, 52);
            this.Maker.Name = "Maker";
            this.Maker.Padding = new System.Windows.Forms.Padding(3);
            this.Maker.Size = new System.Drawing.Size(191, 36);
            this.Maker.TabIndex = 19;
            // 
            // Make
            // 
            this.Make.AutoSize = true;
            this.Make.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Make.Location = new System.Drawing.Point(3, 3);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(185, 30);
            this.Make.TabIndex = 21;
            this.Make.Text = "Make *.tar";
            this.Make.UseVisualStyleBackColor = true;
            this.Make.Click += new System.EventHandler(this.OnMakeClick);
            // 
            // Buttons
            // 
            this.Buttons.ColumnCount = 2;
            this.Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Buttons.Controls.Add(this.Clear, 0, 0);
            this.Buttons.Controls.Add(this.Choose, 0, 0);
            this.Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.Buttons.Location = new System.Drawing.Point(16, 16);
            this.Buttons.Name = "Buttons";
            this.Buttons.RowCount = 1;
            this.Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Buttons.Size = new System.Drawing.Size(191, 36);
            this.Buttons.TabIndex = 18;
            // 
            // Clear
            // 
            this.Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clear.Location = new System.Drawing.Point(98, 3);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(90, 30);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.OnClearClick);
            // 
            // Choose
            // 
            this.Choose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Choose.Location = new System.Drawing.Point(3, 3);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(89, 30);
            this.Choose.TabIndex = 19;
            this.Choose.Text = "Choose Files";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.OnChooseClick);
            // 
            // Website
            // 
            this.Website.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Website.AutoSize = true;
            this.Website.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Website.Location = new System.Drawing.Point(46, 136);
            this.Website.Name = "Website";
            this.Website.Size = new System.Drawing.Size(130, 13);
            this.Website.TabIndex = 17;
            this.Website.Text = "www.vaibhavpandey.com";
            this.Website.Click += new System.EventHandler(this.OnWebsiteClick);
            // 
            // Checksum
            // 
            this.Checksum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Checksum.AutoSize = true;
            this.Checksum.Location = new System.Drawing.Point(62, 97);
            this.Checksum.Name = "Checksum";
            this.Checksum.Size = new System.Drawing.Size(102, 17);
            this.Checksum.TabIndex = 12;
            this.Checksum.Text = "MD5 Checksum";
            this.Checksum.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.Profile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Profile.AutoSize = true;
            this.Profile.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Profile.Location = new System.Drawing.Point(56, 118);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(108, 13);
            this.Profile.TabIndex = 16;
            this.Profile.Text = "@vaibhavpandeyvpz";
            this.Profile.Click += new System.EventHandler(this.OnProfileClick);
            // 
            // Files
            // 
            this.Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Names,
            this.Paths});
            this.Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Files.FullRowSelect = true;
            this.Files.GridLines = true;
            this.Files.Location = new System.Drawing.Point(3, 3);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(223, 159);
            this.Files.TabIndex = 13;
            this.Files.UseCompatibleStateImageBehavior = false;
            this.Files.View = System.Windows.Forms.View.Details;
            // 
            // Names
            // 
            this.Names.Text = "Name";
            this.Names.Width = 64;
            // 
            // Paths
            // 
            this.Paths.Text = "Path";
            this.Paths.Width = 160;
            // 
            // Worker
            // 
            this.Worker.WorkerReportsProgress = true;
            this.Worker.WorkerSupportsCancellation = true;
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OnWorkerDo);
            this.Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.OnWorkerProgress);
            this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnWorkerCompleted);
            // 
            // Guitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.StatusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 360);
            this.MinimumSize = new System.Drawing.Size(480, 360);
            this.Name = "Guitar";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Guitar - http://git.io/vn5R0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnGuitarClosing);
            this.Load += new System.EventHandler(this.OnGuitarLoad);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.Output.ResumeLayout(false);
            this.Table.ResumeLayout(false);
            this.Fieldset.ResumeLayout(false);
            this.Fieldset.PerformLayout();
            this.Maker.ResumeLayout(false);
            this.Maker.PerformLayout();
            this.Buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog Chooser;
        private System.Windows.Forms.SaveFileDialog Saver;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Output;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Panel Fieldset;
        private System.Windows.Forms.ToolStripProgressBar Progress;
        private System.ComponentModel.BackgroundWorker Worker;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.CheckBox Checksum;
        private System.Windows.Forms.Label Website;
        private System.Windows.Forms.Label Profile;
        private System.Windows.Forms.ListView Files;
        private System.Windows.Forms.ColumnHeader Names;
        private System.Windows.Forms.ColumnHeader Paths;
        private System.Windows.Forms.TableLayoutPanel Buttons;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.Panel Maker;
        private System.Windows.Forms.Button Make;
    }
}

