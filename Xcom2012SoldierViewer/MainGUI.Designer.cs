namespace Xcom2012SoldierViewer
{
    partial class MainGUI
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SoldierLayout = new System.Windows.Forms.DataGridView();
            this.FilterClass = new System.Windows.Forms.CheckedListBox();
            this.FilterRanks = new System.Windows.Forms.CheckedListBox();
            this.NameSearch = new System.Windows.Forms.TextBox();
            this.Filter = new System.Windows.Forms.Button();
            this.FilterStatus = new System.Windows.Forms.CheckedListBox();
            this.clearFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterPerkText = new System.Windows.Forms.TextBox();
            this.FilterPerks = new System.Windows.Forms.ListBox();
            this.FilteredPerks = new System.Windows.Forms.ListBox();
            this.AddPerk = new System.Windows.Forms.Button();
            this.RemovePerk = new System.Windows.Forms.Button();
            this.ClearPerks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterKIA = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SoldierLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SoldierLayout
            // 
            this.SoldierLayout.AllowUserToAddRows = false;
            this.SoldierLayout.AllowUserToDeleteRows = false;
            this.SoldierLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoldierLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SoldierLayout.Location = new System.Drawing.Point(0, 208);
            this.SoldierLayout.Name = "SoldierLayout";
            this.SoldierLayout.ReadOnly = true;
            this.SoldierLayout.ShowCellErrors = false;
            this.SoldierLayout.ShowCellToolTips = false;
            this.SoldierLayout.ShowEditingIcon = false;
            this.SoldierLayout.ShowRowErrors = false;
            this.SoldierLayout.Size = new System.Drawing.Size(854, 343);
            this.SoldierLayout.TabIndex = 1;
            // 
            // FilterClass
            // 
            this.FilterClass.CheckOnClick = true;
            this.FilterClass.FormattingEnabled = true;
            this.FilterClass.Items.AddRange(new object[] {
            "PFC",
            "SPEC - Unassigned",
            "Assault",
            "Engineer",
            "Gunner",
            "Infantry",
            "Medic",
            "Rocketeer",
            "Scout",
            "Sniper"});
            this.FilterClass.Location = new System.Drawing.Point(12, 36);
            this.FilterClass.Name = "FilterClass";
            this.FilterClass.Size = new System.Drawing.Size(120, 154);
            this.FilterClass.TabIndex = 2;
            // 
            // FilterRanks
            // 
            this.FilterRanks.CheckOnClick = true;
            this.FilterRanks.FormattingEnabled = true;
            this.FilterRanks.Items.AddRange(new object[] {
            "PFC",
            "SPEC",
            "LCPL",
            "CPL",
            "SGT",
            "TSGT",
            "GSGT",
            "MSGT"});
            this.FilterRanks.Location = new System.Drawing.Point(138, 36);
            this.FilterRanks.Name = "FilterRanks";
            this.FilterRanks.Size = new System.Drawing.Size(120, 154);
            this.FilterRanks.TabIndex = 3;
            // 
            // NameSearch
            // 
            this.NameSearch.Location = new System.Drawing.Point(749, 53);
            this.NameSearch.Name = "NameSearch";
            this.NameSearch.Size = new System.Drawing.Size(100, 20);
            this.NameSearch.TabIndex = 4;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(747, 85);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(102, 23);
            this.Filter.TabIndex = 5;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // FilterStatus
            // 
            this.FilterStatus.CheckOnClick = true;
            this.FilterStatus.FormattingEnabled = true;
            this.FilterStatus.Items.AddRange(new object[] {
            "eStatus_Active",
            "eStatus_OnMission",
            "eStatus_PsiTesting",
            "eStatus_CovertOps",
            "eStatus_GeneMod",
            "eStatus_Augmenting",
            "eStatus_Healing",
            "eStatus_Dead",
            "eStatus_Fatigued"});
            this.FilterStatus.Location = new System.Drawing.Point(264, 36);
            this.FilterStatus.Name = "FilterStatus";
            this.FilterStatus.Size = new System.Drawing.Size(120, 154);
            this.FilterStatus.TabIndex = 3;
            // 
            // clearFilter
            // 
            this.clearFilter.Location = new System.Drawing.Point(747, 114);
            this.clearFilter.Name = "clearFilter";
            this.clearFilter.Size = new System.Drawing.Size(102, 23);
            this.clearFilter.TabIndex = 6;
            this.clearFilter.Text = "Clear";
            this.clearFilter.UseVisualStyleBackColor = true;
            this.clearFilter.Click += new System.EventHandler(this.clearFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Soldier Name";
            // 
            // FilterPerkText
            // 
            this.FilterPerkText.Location = new System.Drawing.Point(390, 36);
            this.FilterPerkText.Name = "FilterPerkText";
            this.FilterPerkText.Size = new System.Drawing.Size(152, 20);
            this.FilterPerkText.TabIndex = 9;
            this.FilterPerkText.TextChanged += new System.EventHandler(this.FilterPerkText_TextChanged);
            // 
            // FilterPerks
            // 
            this.FilterPerks.FormattingEnabled = true;
            this.FilterPerks.Location = new System.Drawing.Point(390, 56);
            this.FilterPerks.Name = "FilterPerks";
            this.FilterPerks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.FilterPerks.Size = new System.Drawing.Size(152, 134);
            this.FilterPerks.TabIndex = 10;
            // 
            // FilteredPerks
            // 
            this.FilteredPerks.FormattingEnabled = true;
            this.FilteredPerks.Location = new System.Drawing.Point(596, 56);
            this.FilteredPerks.Name = "FilteredPerks";
            this.FilteredPerks.Size = new System.Drawing.Size(140, 134);
            this.FilteredPerks.TabIndex = 11;
            // 
            // AddPerk
            // 
            this.AddPerk.Location = new System.Drawing.Point(548, 85);
            this.AddPerk.Name = "AddPerk";
            this.AddPerk.Size = new System.Drawing.Size(42, 23);
            this.AddPerk.TabIndex = 12;
            this.AddPerk.Text = ">>";
            this.AddPerk.UseVisualStyleBackColor = true;
            this.AddPerk.Click += new System.EventHandler(this.AddPerk_Click);
            // 
            // RemovePerk
            // 
            this.RemovePerk.Location = new System.Drawing.Point(548, 114);
            this.RemovePerk.Name = "RemovePerk";
            this.RemovePerk.Size = new System.Drawing.Size(42, 23);
            this.RemovePerk.TabIndex = 12;
            this.RemovePerk.Text = "<<";
            this.RemovePerk.UseVisualStyleBackColor = true;
            this.RemovePerk.Click += new System.EventHandler(this.RemovePerk_Click);
            // 
            // ClearPerks
            // 
            this.ClearPerks.Location = new System.Drawing.Point(596, 36);
            this.ClearPerks.Name = "ClearPerks";
            this.ClearPerks.Size = new System.Drawing.Size(140, 21);
            this.ClearPerks.TabIndex = 12;
            this.ClearPerks.Text = "Clear";
            this.ClearPerks.UseVisualStyleBackColor = true;
            this.ClearPerks.Click += new System.EventHandler(this.ClearPerks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Perks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filtered Perks";
            // 
            // FilterKIA
            // 
            this.FilterKIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterKIA.FormattingEnabled = true;
            this.FilterKIA.Items.AddRange(new object[] {
            "Not Dead",
            "Dead",
            "Everyone"});
            this.FilterKIA.Location = new System.Drawing.Point(238, 7);
            this.FilterKIA.Name = "FilterKIA";
            this.FilterKIA.Size = new System.Drawing.Size(121, 21);
            this.FilterKIA.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "KIA Filter";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 551);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FilterKIA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemovePerk);
            this.Controls.Add(this.ClearPerks);
            this.Controls.Add(this.AddPerk);
            this.Controls.Add(this.FilteredPerks);
            this.Controls.Add(this.FilterPerks);
            this.Controls.Add(this.FilterPerkText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearFilter);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.NameSearch);
            this.Controls.Add(this.FilterStatus);
            this.Controls.Add(this.FilterRanks);
            this.Controls.Add(this.FilterClass);
            this.Controls.Add(this.SoldierLayout);
            this.Controls.Add(this.button1);
            this.Name = "MainGUI";
            this.Text = "XCOMSoldierViewer";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.Resize += new System.EventHandler(this.MainGUI_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.SoldierLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView SoldierLayout;
        private System.Windows.Forms.CheckedListBox FilterClass;
        private System.Windows.Forms.CheckedListBox FilterRanks;
        private System.Windows.Forms.TextBox NameSearch;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.CheckedListBox FilterStatus;
        private System.Windows.Forms.Button clearFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilterPerkText;
        private System.Windows.Forms.ListBox FilterPerks;
        private System.Windows.Forms.ListBox FilteredPerks;
        private System.Windows.Forms.Button AddPerk;
        private System.Windows.Forms.Button RemovePerk;
        private System.Windows.Forms.Button ClearPerks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FilterKIA;
        private System.Windows.Forms.Label label4;
    }
}

