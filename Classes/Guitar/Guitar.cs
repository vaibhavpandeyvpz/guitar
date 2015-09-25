using ICSharpCode.SharpZipLib.Tar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Guitar
{
    public partial class Guitar : Form
    {
        private string Destination;

        private List<string> Sources = new List<string>();

        public class Writer : TextWriter
        {
            RichTextBox Box = null;

            public Writer(RichTextBox output)
            {
                Box = output;
            }

            public override void Write(char value)
            {
                base.Write(value);
                if (value != '\r')
                {
                    Box.AppendText(value.ToString());
                }
            }

            public override Encoding Encoding
            {
                get { return Encoding.UTF8; }
            }
        }

        public Guitar()
        {
            InitializeComponent();
        }

        private void OnClearClick(object sender, EventArgs e)
        {
            Sources.Clear();
            Files.Items.Clear();
        }

        private void OnChooseClick(object sender, EventArgs e)
        {
            if (Chooser.ShowDialog() == DialogResult.OK)
            {
                foreach (var f in Chooser.FileNames)
                {
                    if (!Sources.Contains(f))
                    {
                        Files.Items.Add(new ListViewItem(new string[] { Path.GetFileName(f), f }));
                        Sources.Add(f);
                        Console.WriteLine("Selected {0}", f);
                    }
                }
            }
        }

        private void OnGuitarClosing(object sender, FormClosingEventArgs e)
        {
            if (Worker.IsBusy)
            {
                var result = MessageBox.Show("Cancel current archive?", "In Progress", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Worker.CancelAsync();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void OnGuitarLoad(object sender, EventArgs e)
        {
            Console.SetOut(new Writer(OutputBox));
            OutputBox.TextChanged += (a, b) =>
            {
                OutputBox.SelectionStart = OutputBox.Text.Length;
                OutputBox.ScrollToCaret();
            };
            Profile.MouseEnter += (a, b) =>
            {
                Profile.Cursor = Cursors.Hand;
                Profile.ForeColor = Color.MidnightBlue;
            };
            Profile.MouseLeave += (a, b) =>
            {
                Profile.Cursor = Cursors.Default;
                Profile.ForeColor = Color.RoyalBlue;
            };
            Website.MouseEnter += (a, b) =>
            {
                Website.Cursor = Cursors.Hand;
                Website.ForeColor = Color.MidnightBlue;
            };
            Website.MouseLeave += (a, b) =>
            {
                Website.Cursor = Cursors.Default;
                Website.ForeColor = Color.RoyalBlue;
            };
        }

        private void OnMakeClick(object sender, EventArgs e)
        {
            if (Sources.Count >= 1)
            {
                if (Saver.ShowDialog() == DialogResult.OK)
                {
                    if (!Worker.IsBusy)
                    {
                        Destination = Saver.FileName;
                        Make.Enabled = false;
                        Progress.Style = ProgressBarStyle.Continuous;
                        Worker.RunWorkerAsync();
                    }
                }
            }
            else
            {
                Console.WriteLine("Please choose files to add to *.tar");
            }
        }

        private void OnProfileClick(object sender, EventArgs e)
        {
            Process.Start("http://forum.xda-developers.com/member.php?u=5490832");
        }

        private void OnWebsiteClick(object sender, EventArgs e)
        {
            Process.Start("http://www.vaibhavpandey.com");
        }

        private void OnWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine(new String('-', 48));
            Make.Enabled = true;
            Progress.Style = ProgressBarStyle.Blocks;
            Progress.Value = 0;
        }

        private void OnWorkerDo(object sender, DoWorkEventArgs e)
        {
            try
            {
                var file = Destination;
                var sources = Sources;
                using (Stream output = File.Create(file))
                {
                    Worker.ReportProgress(5, string.Format("Creating {0}", file));
                    using (TarArchive archive = TarArchive.CreateOutputTarArchive(output, TarBuffer.DefaultBlockFactor))
                    {
                        archive.ProgressMessageEvent += (a, b, c) =>
                        {
                            if (!string.IsNullOrWhiteSpace(c))
                            {
                                Console.Write("{0}; {1}", b.Name, c);
                            }
                        };
                        archive.SetKeepOldFiles(false);
                        archive.SetUserInfo(1, Environment.UserName, 1, null);
                        int factor = (int)75 / sources.Count;
                        int progress = 10;
                        foreach (string s in sources)
                        {
                            progress += factor;
                            Worker.ReportProgress(progress, string.Format("Adding {0}", s));
                            TarEntry entry = TarEntry.CreateEntryFromFile(s);
                            archive.WriteEntry(entry, true);
                        }
                        archive.Close();
                        Worker.ReportProgress(85, string.Format("Finished creating {0}", file));
                        if (Checksum.Checked)
                        {
                            Worker.ReportProgress(95, "Calculating MD5 checksum of created archive");
                            string checksum;
                            using (var md5 = MD5.Create())
                            {
                                using (var stream = new BufferedStream(File.OpenRead(file), 1024 * 1024))
                                {
                                    byte[] bytes = md5.ComputeHash(stream);
                                    checksum = string.Concat(bytes.Select(b => b.ToString("X2")).ToArray());
                                }
                            }
                            Worker.ReportProgress(98, string.Format("Checksum is {0}", checksum));
                            using (var stream = new FileStream(file, FileMode.Append))
                            {
                                var bytes = Encoding.UTF8.GetBytes(string.Format("{0}  {1}\n", checksum, Path.GetFileName(file)));
                                stream.Write(bytes, 0, bytes.Length);
                            }
                            var renamed = file + ".md5";
                            if (File.Exists(renamed))
                            {
                                File.Delete(renamed);
                            }
                            File.Move(file, (file = renamed));
                            Worker.ReportProgress(99, string.Format("Renamed archive to {0}", file));
                        }
                        Worker.ReportProgress(100, "Package is ready to be flashed via ODIN");
                    }
                }
            }
            catch (Exception ex)
            {
                Worker.ReportProgress(99, "Error occurred while creating archive");
                Worker.ReportProgress(100, ex.Message);
            }
        }

        private void OnWorkerProgress(object sender, ProgressChangedEventArgs e)
        {
            Progress.Value = e.ProgressPercentage;
            Console.WriteLine(e.UserState.ToString());
        }
    }
}
