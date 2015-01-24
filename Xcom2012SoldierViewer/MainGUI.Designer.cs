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
            this.SoldierLayout.Size = new System.Drawing.Size(732, 343);
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
            this.FilterClass.Location = new System.Drawing.Point(119, 36);
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
            this.FilterRanks.Location = new System.Drawing.Point(245, 36);
            this.FilterRanks.Name = "FilterRanks";
            this.FilterRanks.Size = new System.Drawing.Size(120, 154);
            this.FilterRanks.TabIndex = 3;
            // 
            // NameSearch
            // 
            this.NameSearch.Location = new System.Drawing.Point(497, 36);
            this.NameSearch.Name = "NameSearch";
            this.NameSearch.Size = new System.Drawing.Size(100, 20);
            this.NameSearch.TabIndex = 4;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(495, 68);
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
            this.FilterStatus.Location = new System.Drawing.Point(371, 36);
            this.FilterStatus.Name = "FilterStatus";
            this.FilterStatus.Size = new System.Drawing.Size(120, 154);
            this.FilterStatus.TabIndex = 3;
            // 
            // clearFilter
            // 
            this.clearFilter.Location = new System.Drawing.Point(495, 97);
            this.clearFilter.Name = "clearFilter";
            this.clearFilter.Size = new System.Drawing.Size(102, 23);
            this.clearFilter.TabIndex = 6;
            this.clearFilter.Text = "Clear";
            this.clearFilter.UseVisualStyleBackColor = true;
            this.clearFilter.Click += new System.EventHandler(this.clearFilter_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 551);
            this.Controls.Add(this.clearFilter);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.NameSearch);
            this.Controls.Add(this.FilterStatus);
            this.Controls.Add(this.FilterRanks);
            this.Controls.Add(this.FilterClass);
            this.Controls.Add(this.SoldierLayout);
            this.Controls.Add(this.button1);
            this.Name = "MainGUI";
            this.Text = "Form1";
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
    }
}

