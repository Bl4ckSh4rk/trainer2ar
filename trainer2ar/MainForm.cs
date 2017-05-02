using System;
using System.Windows.Forms;
using System.IO;
using static ARGBA.Crypto;

namespace trainer2ar
{
    public partial class MainForm : Form
    {
        private byte[] byteBuffer = new byte[188];
        private Int64 fileSize = 0;
        private const Int64 MIN_FILESIZE = 188;
        private const Int64 MAX_FILESIZE = 188;

        public MainForm()
        {
            InitializeComponent();
            MaximizeBox = false;

            this.DragEnter += new DragEventHandler(MainForm_DragEnter);
            this.DragDrop += new DragEventHandler(MainForm_DragDrop);
        }

        void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            fileSize = new FileInfo(files[0]).Length;

            if (fileSize >= MIN_FILESIZE && fileSize <= MAX_FILESIZE)
            {
                byteBuffer = File.ReadAllBytes(files[0]);

                enablePanels();
                generateCode.Enabled = true;
            }
            else
            {
                codeOutput.Text = "Invalid Filesize!\ne-Reader Trainer files should have 188 Bytes!";
                enablePanels(false);
                saveCode.Enabled = false;
            }
        }

        private void openTrainer_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "e-Reader Trainer (*.ect;*.bin)|*.ect;*.bin|All files (*.*)|*.*";
                ofd.Title = "Open file";
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileSize = new FileInfo(ofd.FileName).Length;
                    if (fileSize >= MIN_FILESIZE && fileSize <= MAX_FILESIZE)
                    {
                        byteBuffer = File.ReadAllBytes(ofd.FileName);

                        enablePanels();
                    }
                    else
                    {
                        codeOutput.Text = "Invalid Filesize!\ne-Reader Trainer files should have 188 Bytes!";
                        enablePanels(false);
                        saveCode.Enabled = false;
                    }
                }
            }
        }

        private void enablePanels(bool b = true)
        {
            gamePanel.Enabled = b;
            regionPanel.Enabled = b;
            arVersionPanel.Enabled = b;
            cryptoPanel.Enabled = b;
            generateCode.Enabled = b;
        }

        private void saveCode_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt";
                sfd.Title = "Save file";
                sfd.FilterIndex = 1;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (byteBuffer != null)
                        File.WriteAllText(sfd.FileName, codeOutput.Text);
                }
            }
        }

        private UInt32[,] code = new UInt32[47,2];
        private UInt32 address, codeType;

        private void checkARVersion()
        {
            if (ar34.Checked)
            {
                codeType = 0x04200000;
                v3encryption = true;
            }
            else
            {
                codeType = 0x22000000;
                v3encryption = false;
            }
        }

        private void checkGame()
        {
            if (gameRS.Checked)
            {
                if (regionJP.Checked)
                    address = 0x2509C;
                else
                    address = 0x2533C;
            }
            else if (gameE.Checked)
            {
                if (regionJP.Checked)
                    address = 0x252E4;
                else
                    address = 0x25640;
            }
            else if (gameFRLG.Checked)
            {
                if (regionJP.Checked)
                    address = 0x24988;
                else
                    address = 0x24A28;
            }
        }

        private void fixChecksum(ref byte[] data)
        {
            UInt32 etdChecksum = trainerChecksum(data);
            data[0xBB] = (byte)(0xFF & (etdChecksum >> 24));
            data[0xBA] = (byte)(0xFF & (etdChecksum >> 16));
            data[0xB9] = (byte)(0xFF & (etdChecksum >> 8));
            data[0xB8] = (byte)(0xFF & etdChecksum);
        }

        private UInt32 trainerChecksum(byte[] data)
        {
            UInt32 checksum = 0;
            for (int i = 0; i < 0x2E; i++)
                checksum += getBytesFrom(data, i*4, 4);

            checksum &= 0xFFFFFFFF;
            return checksum;
        }

        private UInt32 getBytesFrom(byte[] data, Int32 offset, Int16 size = 1)
        {
            uint bytes = 0;
            for (int x = 0; x < size && x < 4; x++)
            {
                bytes += (UInt32)((data[offset + x] & 0xFF) << (8 * x));
            }
            return bytes;
        }
        
        private void buildCode()
        {
            checkARVersion();
            checkGame();
            fixChecksum(ref byteBuffer);

            for (int x = 0; x < 47; x++)
            {
                code[x,0] = (UInt32)(codeType + address + x * 4);
                code[x,1] = (UInt32)((byteBuffer[x * 4] & 0xFF) + ((byteBuffer[x * 4 + 1] & 0xFF) << 8) + ((byteBuffer[x * 4 + 2] & 0xFF) << 16) + ((byteBuffer[x * 4 + 3] & 0xFF) << 24));
            }
        }

        private void generateCode_Click(object sender, EventArgs e)
        {
            if (byteBuffer != null)
            {
                buildCode();
                if (encrypted.Checked == true)
                    encrypt(ref code);

                printCode();
                saveCode.Enabled = true;
            }
        }

        public void printCode()
        {
            string str_code = "";
            for (int x = 0; x < 47; x++)
                str_code += String.Format("{0:X8}", code[x, 0]) + " " + String.Format("{0:X8}", code[x, 1]) + "\n";

            codeOutput.Text = str_code;
        }
    }
}
