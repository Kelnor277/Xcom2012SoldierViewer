using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Xcom2012SoldierViewer
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string saveFileName = Path.Combine(new string[] {Directory.GetCurrentDirectory(), Path.GetFileName(openFileDialog1.FileName)});
            SaveReader.decompress(openFileDialog1.FileName, saveFileName);
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string saveFileName = Path.Combine(new string[] { Directory.GetCurrentDirectory(), Path.GetFileName(openFileDialog1.FileName) });
            SaveReader.decompress(openFileDialog1.FileName, saveFileName);
            List<XGStrategySoldier> Roster = SaveReader.parseSoldiers(saveFileName);
        }

        private void loadSoldiers()
        {
            
        }
    }
}
