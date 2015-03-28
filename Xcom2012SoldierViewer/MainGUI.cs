using System;
using System.Collections;
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

        private List<string> Ranks = new List<string> { "PFC",
                                                        "SPEC",
                                                        "LCPL",
                                                        "CPL",
                                                        "SGT",
                                                        "TSGT",
                                                        "GSGT",
                                                        "MSGT"};
        private readonly List<string> columns = new List<string> {"ID","First Name","NickName","Last Name",
                                                        "Rank",
                                                        "XP",
                                                        "PsiRank",
                                                        "PsiXP",
                                                        "Class",
                                                        "Perks",
                                                        "Status",
                                                        "Days Out",
                                                        "Hours Out",
                                                        "Kills"
                                                        };

        readonly List<string> PerkList = new List<string>();
        readonly List<string> PerkFilteredList = new List<string>();
        readonly List<string> PerkFilterList = new List<string>();
        private void MainGUI_Load(object sender, EventArgs e)
        {
            FilterKIA.SelectedIndex = 0;
            foreach (string st in columns)
            {
                if (st.Equals("Perks"))
                    SoldierLayout.Columns.Add(new DataGridViewComboBoxColumn
                    {
                        HeaderText = st,
                        Name = st,
                        ReadOnly = false,//If the DGV, the combocolumn or the comobocell are readonly, dropdown doesn't work.
                        FlatStyle = FlatStyle.Flat,
                        DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
                    });
                else
            {
                SoldierLayout.Columns.Add(st, st);
                SoldierLayout.Columns[SoldierLayout.Columns.Count - 1].ReadOnly = true; //Non-combobox are fine to readonly
            }
            }
            resetFilter();
            SoldierLayout.Height = this.Height - 300;
            List<string> perks = Enum.GetNames(typeof(EPerkType)).ToList<string>();
            foreach(EPerkType perk in Enum.GetValues(typeof(EPerkType)))
            {
                string name = getPerk(perk).name;
                PerkList.Add(name);
                PerkFilterList.Add(name);
            }
            refreshPerkLBs();
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string saveFileName = Path.Combine(new string[] { Directory.GetCurrentDirectory(), Path.GetFileName(openFileDialog1.FileName) });
                SaveReader.decompress(openFileDialog1.FileName, saveFileName);
                Roster = SaveReader.parseSoldiers(saveFileName);
                loadSoldiers(Roster);
            }
        }

        private void loadSoldiers(List<XGStrategySoldier>Roster)
        {
            SoldierLayout.Rows.Clear();
            List<string> Solclasses = new List<string>();
            List<string> Solranks = new List<string>();
            List<string> SolStatus = new List<string>();
            List<string> SolPerks = new List<string>();
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
            foreach (object chked in FilteredPerks.Items)
            {
                SolPerks.Add(chked.ToString());
            }
            foreach(XGStrategySoldier soldier in Roster)
            {
                if (!Solclasses.Contains(soldier.m_kSoldier.kClass.strName))
                {
                    continue;
                }
                if (!Solranks.Contains(soldier.m_kSoldier.getShtRank()))
                {
                    continue;
                }
                if (!SolStatus.Contains(soldier.getStatus()))
                {
                    continue;
                }
                bool skip = (SolPerks.Count > 0);
                List<String> perks = new List<string>();
                foreach (KeyValuePair<EPerkType, bool> perk in soldier.m_kChar.getPerks())
                {
                    Perk p = getPerk(perk.Key);
                    string st = p.name;
                    if (SolPerks.Contains(st) && !perk.Value)
                    {
                        skip = false;
                    }
                    if (!perk.Value)
                    {
                        perks.Add(st);
                    }
                }
                if (skip)
                {
                    continue;
                }
                switch(FilterKIA.SelectedIndex)
                {
                    case 0:
                        if(soldier.m_eStatus == ESoldierStatus.eStatus_Dead)
                        {
                            continue;
                        }
                        break;
                    case 1:
                        if(soldier.m_eStatus != ESoldierStatus.eStatus_Dead)
                        {
                            continue;
                        }
                        break;
                }
                string name = soldier.m_kSoldier.strFirstName + " " + soldier.m_kSoldier.strLastName;
                if(NameSearch.Text != string.Empty)
                {
                    int i = name.ToUpper().IndexOf(NameSearch.Text.ToUpper());
                    if(i < 0)
                    {
                        continue;
                    }
                }
                SoldierLayout.Rows.Add();
                DataGridViewRow row = SoldierLayout.Rows[SoldierLayout.Rows.Count - 1];
                int c =0;
                row.Cells[c++].Value = soldier.m_kSoldier.iID;
                row.Cells[c++].Value = soldier.m_kSoldier.strFirstName;
                row.Cells[c++].Value = (soldier.m_kSoldier.strNickName.Length == 0
                    ? " "
                    : " \"" + soldier.m_kSoldier.strNickName + "\" ");
                row.Cells[c++].Value = soldier.m_kSoldier.strLastName;
                row.Cells[c++].Value = soldier.m_kSoldier.getShtRank();
                row.Cells[c++].Value = soldier.m_kSoldier.iXP.ToString();
                row.Cells[c++].Value = soldier.m_kSoldier.iPsiRank.ToString();
                row.Cells[c++].Value = soldier.m_kSoldier.iPsiXP.ToString();
                row.Cells[c++].Value = soldier.m_kSoldier.kClass.strName;
                ((DataGridViewComboBoxCell) row.Cells[c]).Items.AddRange(perks.ToArray());
                if (((DataGridViewComboBoxCell)row.Cells[c]).Items.Count >0)
                row.Cells[c].Value = ((DataGridViewComboBoxCell)row.Cells[c++]).Items[0]; //This is basically the 'selecteditem' equivalent for DGVComboboxsCells, makes them show up.
                row.Cells[c].Style.WrapMode = DataGridViewTriState.True;
                row.Cells[c++].Value = soldier.getStatus().Replace("eStatus_", "");
                row.Cells[c++].Value = (soldier.m_iTurnsOut / 24);
                row.Cells[c++].Value = soldier.m_iTurnsOut;
                row.Cells[c++].Value = soldier.m_kSoldier.iNumKills;
            }
        }

        private static Perk getPerk(EPerkType ePerk)
        {
            Perk p;
            Perk.LearnablePerks.TryGetValue(ePerk, out p);
            return p ?? (p = new Perk(ePerk));
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
            SoldierLayout.Height = this.Height - 300;
        }

        private void AddPerk_Click(object sender, EventArgs e)
        {
            List<string> items = FilterPerks.SelectedItems.Cast<string>().ToList<string>();
            foreach(var item in items)
            {

                PerkFilteredList.Add(item);
                PerkFilterList.Remove(item);
            }
            refreshPerkLBs();
        }

        private void RemovePerk_Click(object sender, EventArgs e)
        {
            List<string> items = FilterPerks.SelectedItems.Cast<string>().ToList<string>();
            foreach (var item in items)
            {
                PerkFilteredList.Remove(item);
                PerkFilterList.Add(item);
            }
            refreshPerkLBs();
        }

        private void ClearPerks_Click(object sender, EventArgs e)
        {
            FilteredPerks.Items.Clear();
            FilterPerks.Items.Clear();
            PerkFilteredList.Clear();
            PerkFilterList.Clear();
            PerkFilterList.AddRange(PerkList);
            refreshPerkLBs();
        }

        private void refreshPerkLBs()
        {
            FilterPerks.Items.Clear();
            FilteredPerks.Items.Clear();
            if (FilterPerkText.Text != string.Empty)
            {
                string searchText = FilterPerkText.Text.ToUpper();
                FilterPerks.Items.Clear();
                foreach (string item in PerkFilterList)
                {
                    if (item.ToUpper().Contains(searchText))
                    {
                        FilterPerks.Items.Add(item);
                    }
                }
            }
            else
            {
                FilterPerks.Items.AddRange(PerkFilterList.ToArray<object>());
            }
            FilteredPerks.Items.AddRange(PerkFilteredList.ToArray<object>());
        }

        private void FilterPerkText_TextChanged(object sender, EventArgs e)
        {
            refreshPerkLBs();
        }
    }
}
