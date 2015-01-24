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

        private void MainGUI_Load(object sender, EventArgs e)
        {

            List<string> columns = new List<string> {"Name",
                                                    "Rank",
                                                    "XP",
                                                    "Class",
                                                    "Perks",
                                                    "Status",
                                                    "Days Out",
                                                    "Hours Out",
                                                    };
            foreach(string st in columns)
            {
                SoldierLayout.Columns.Add(st, st);
            }
            resetFilter();
            SoldierLayout.Height = this.Height - 250;
        }

        private void resetFilter()
        {
            for (int x = 0; x < FilterClass.Items.Count; x++)
            {
                FilterClass.SetItemChecked(x, true);
            }
            for (int x = 0; x < FilterRanks.Items.Count; x++)
            {
                FilterRanks.SetItemChecked(x, true);
            }
            for (int x = 0; x < FilterStatus.Items.Count; x++)
            {
                FilterStatus.SetItemChecked(x, true);
            }
            NameSearch.Text = string.Empty;
        }
        private List<XGStrategySoldier> Roster;
        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string saveFileName = Path.Combine(new string[] { Directory.GetCurrentDirectory(), Path.GetFileName(openFileDialog1.FileName) });
            SaveReader.decompress(openFileDialog1.FileName, saveFileName);
            Roster = SaveReader.parseSoldiers(saveFileName);
            loadSoldiers(Roster);
        }

        private void loadSoldiers(List<XGStrategySoldier>Roster)
        {
            SoldierLayout.Rows.Clear();
            List<string> Solclasses = new List<string>();
            List<string> Solranks = new List<string>();
            List<string> SolStatus = new List<string>();
            //for(int x = 0; x < FilterClass.Items.Count; x++)
            //{
            //    if(FilterClass.GetItemChecked(x))
            //    {
            //        Solclasses.Add(FilterClass.GetItemText(FilterClass.Items[x]));
            //    }
            //}
            foreach(object chked in FilterClass.CheckedItems)
            {
                Solclasses.Add(chked.ToString());
            }
            foreach (object chked in FilterRanks.CheckedItems)
            {
                Solranks.Add(chked.ToString());
            }
            foreach (object chked in FilterStatus.CheckedItems)
            {
                SolStatus.Add(chked.ToString());
            }
            foreach(XGStrategySoldier soldier in Roster)
            {
                bool skip = false;
                if (!Solclasses.Contains(soldier.m_kSoldier.kClass.strName))
                {
                    skip = true;
                }
                if (!Solranks.Contains(soldier.m_kSoldier.getShtRank()))
                {
                    skip = true;
                }
                if (!SolStatus.Contains(soldier.getStatus()))
                {
                    skip = true;
                }
                string name = soldier.m_kSoldier.strFirstName + " " + soldier.m_kSoldier.strLastName;
                if(NameSearch.Text != string.Empty)
                {
                    int i = name.ToUpper().IndexOf(NameSearch.Text.ToUpper());
                    if(i < 0)
                    {
                        skip = true;
                    }
                }
                if (!skip)
                {
                    SoldierLayout.Rows.Add();
                    DataGridViewRow row = SoldierLayout.Rows[SoldierLayout.Rows.Count - 1];
                    row.Cells[0].Value = soldier.m_kSoldier.strFirstName + " " + soldier.m_kSoldier.strLastName;
                    row.Cells[1].Value = soldier.m_kSoldier.getShtRank();
                    row.Cells[2].Value = soldier.m_kSoldier.iXP.ToString();
                    row.Cells[3].Value = soldier.m_kSoldier.kClass.strName;
                    //ComboBox perkBox = new ComboBox();
                    //perkBox.Items.AddRange(soldier.m_kChar.getPerks().ToArray<object>());
                    string perks = "";
                    foreach (string st in soldier.m_kChar.getPerks())
                    {
                        perks += st + "\n";
                    }
                    row.Cells[4].Value = perks;
                    row.Cells[4].Style.WrapMode = DataGridViewTriState.True;
                    row.Cells[5].Value = soldier.getStatus();
                    row.Cells[6].Value = (soldier.m_iTurnsOut / 24).ToString();
                    row.Cells[7].Value = soldier.m_iTurnsOut.ToString();
                }
            }
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            loadSoldiers(Roster);
        }

        private void clearFilter_Click(object sender, EventArgs e)
        {
            resetFilter();
        }

        private void MainGUI_Resize(object sender, EventArgs e)
        {
            SoldierLayout.Height = this.Height - 250;
        }


    }
}
