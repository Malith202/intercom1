namespace final11
{
    partial class User_Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Form));
            this.sfunctionBox3 = new System.Windows.Forms.ComboBox();
            this.functionBox2 = new System.Windows.Forms.ComboBox();
            this.companyBox1 = new System.Windows.Forms.ComboBox();
            this.User_dataGridView = new System.Windows.Forms.DataGridView();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corporationDataSet = new final11.CorporationDataSet();
            this.employeTableAdapter = new final11.CorporationDataSetTableAdapters.employeTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.sNametextBox = new System.Windows.Forms.TextBox();
            this.EPFsearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.corporationDataSet1 = new final11.CorporationDataSet();
            this.ePFnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeIntercomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeLandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officefaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.User_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corporationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corporationDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfunctionBox3
            // 
            this.sfunctionBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfunctionBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sfunctionBox3.FormattingEnabled = true;
            this.sfunctionBox3.Location = new System.Drawing.Point(1140, 25);
            this.sfunctionBox3.Name = "sfunctionBox3";
            this.sfunctionBox3.Size = new System.Drawing.Size(125, 21);
            this.sfunctionBox3.TabIndex = 13;
            this.sfunctionBox3.SelectedIndexChanged += new System.EventHandler(this.sfunctionBox3_SelectedIndexChanged);
            // 
            // functionBox2
            // 
            this.functionBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.functionBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.functionBox2.FormattingEnabled = true;
            this.functionBox2.Location = new System.Drawing.Point(857, 25);
            this.functionBox2.Name = "functionBox2";
            this.functionBox2.Size = new System.Drawing.Size(139, 21);
            this.functionBox2.TabIndex = 12;
            this.functionBox2.SelectedIndexChanged += new System.EventHandler(this.functionBox2_SelectedIndexChanged);
            // 
            // companyBox1
            // 
            this.companyBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.companyBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyBox1.FormattingEnabled = true;
            this.companyBox1.Location = new System.Drawing.Point(608, 25);
            this.companyBox1.Name = "companyBox1";
            this.companyBox1.Size = new System.Drawing.Size(132, 21);
            this.companyBox1.TabIndex = 11;
            this.companyBox1.Tag = "";
            this.companyBox1.SelectedIndexChanged += new System.EventHandler(this.companyBox1_SelectedIndexChanged);
            // 
            // User_dataGridView
            // 
            this.User_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.User_dataGridView.AutoGenerateColumns = false;
            this.User_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.User_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.User_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.User_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ePFnoDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.officeIntercomDataGridViewTextBoxColumn,
            this.officeMobileDataGridViewTextBoxColumn,
            this.officeLandDataGridViewTextBoxColumn,
            this.officefaxDataGridViewTextBoxColumn,
            this.officeLocationDataGridViewTextBoxColumn});
            this.User_dataGridView.DataSource = this.employeBindingSource;
            this.User_dataGridView.GridColor = System.Drawing.Color.Silver;
            this.User_dataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.User_dataGridView.Location = new System.Drawing.Point(12, 95);
            this.User_dataGridView.Name = "User_dataGridView";
            this.User_dataGridView.Size = new System.Drawing.Size(1266, 166);
            this.User_dataGridView.TabIndex = 17;
            // 
            // employeBindingSource
            // 
            this.employeBindingSource.DataMember = "employe";
            this.employeBindingSource.DataSource = this.corporationDataSet;
            // 
            // corporationDataSet
            // 
            this.corporationDataSet.DataSetName = "CorporationDataSet";
            this.corporationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeTableAdapter
            // 
            this.employeTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(528, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Company";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(776, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Function";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(1026, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sub Function";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(477, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 25);
            this.button4.TabIndex = 34;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sNametextBox
            // 
            this.sNametextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sNametextBox.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.sNametextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sNametextBox.Location = new System.Drawing.Point(219, 21);
            this.sNametextBox.MaxLength = 20;
            this.sNametextBox.Name = "sNametextBox";
            this.sNametextBox.Size = new System.Drawing.Size(252, 25);
            this.sNametextBox.TabIndex = 33;
            this.sNametextBox.Text = "Short Name";
            this.sNametextBox.WordWrap = false;
            this.sNametextBox.TextChanged += new System.EventHandler(this.sNametextBox_TextChanged);
            this.sNametextBox.Enter += new System.EventHandler(this.sNametextBox_Enter);
            this.sNametextBox.Leave += new System.EventHandler(this.sNametextBox_Leave);
            // 
            // EPFsearch
            // 
            this.EPFsearch.BackColor = System.Drawing.Color.Gold;
            this.EPFsearch.ForeColor = System.Drawing.Color.Transparent;
            this.EPFsearch.Image = ((System.Drawing.Image)(resources.GetObject("EPFsearch.Image")));
            this.EPFsearch.Location = new System.Drawing.Point(152, 21);
            this.EPFsearch.Name = "EPFsearch";
            this.EPFsearch.Size = new System.Drawing.Size(31, 25);
            this.EPFsearch.TabIndex = 32;
            this.EPFsearch.UseVisualStyleBackColor = false;
            this.EPFsearch.Click += new System.EventHandler(this.EPFsearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearch.Location = new System.Drawing.Point(18, 21);
            this.txtSearch.MaxLength = 5;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(128, 25);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.Text = "EPF No.";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // corporationDataSet1
            // 
            this.corporationDataSet1.DataSetName = "CorporationDataSet";
            this.corporationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ePFnoDataGridViewTextBoxColumn
            // 
            this.ePFnoDataGridViewTextBoxColumn.DataPropertyName = "EPF_no";
            this.ePFnoDataGridViewTextBoxColumn.HeaderText = "EPF Number";
            this.ePFnoDataGridViewTextBoxColumn.MaxInputLength = 2000;
            this.ePFnoDataGridViewTextBoxColumn.Name = "ePFnoDataGridViewTextBoxColumn";
            this.ePFnoDataGridViewTextBoxColumn.Width = 80;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "Sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Short Name";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // officeIntercomDataGridViewTextBoxColumn
            // 
            this.officeIntercomDataGridViewTextBoxColumn.DataPropertyName = "Office_Intercom";
            this.officeIntercomDataGridViewTextBoxColumn.HeaderText = "Office Intercom";
            this.officeIntercomDataGridViewTextBoxColumn.Name = "officeIntercomDataGridViewTextBoxColumn";
            this.officeIntercomDataGridViewTextBoxColumn.Width = 80;
            // 
            // officeMobileDataGridViewTextBoxColumn
            // 
            this.officeMobileDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.officeMobileDataGridViewTextBoxColumn.DataPropertyName = "Office_Mobile";
            this.officeMobileDataGridViewTextBoxColumn.HeaderText = "Office Mobile";
            this.officeMobileDataGridViewTextBoxColumn.Name = "officeMobileDataGridViewTextBoxColumn";
            // 
            // officeLandDataGridViewTextBoxColumn
            // 
            this.officeLandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.officeLandDataGridViewTextBoxColumn.DataPropertyName = "Office_Land";
            this.officeLandDataGridViewTextBoxColumn.HeaderText = "Office Land";
            this.officeLandDataGridViewTextBoxColumn.Name = "officeLandDataGridViewTextBoxColumn";
            // 
            // officefaxDataGridViewTextBoxColumn
            // 
            this.officefaxDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.officefaxDataGridViewTextBoxColumn.DataPropertyName = "Office_fax";
            this.officefaxDataGridViewTextBoxColumn.HeaderText = "Office fax";
            this.officefaxDataGridViewTextBoxColumn.Name = "officefaxDataGridViewTextBoxColumn";
            // 
            // officeLocationDataGridViewTextBoxColumn
            // 
            this.officeLocationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.officeLocationDataGridViewTextBoxColumn.DataPropertyName = "Office_Location";
            this.officeLocationDataGridViewTextBoxColumn.HeaderText = "Office Location";
            this.officeLocationDataGridViewTextBoxColumn.Name = "officeLocationDataGridViewTextBoxColumn";
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 268);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.sNametextBox);
            this.Controls.Add(this.EPFsearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User_dataGridView);
            this.Controls.Add(this.sfunctionBox3);
            this.Controls.Add(this.functionBox2);
            this.Controls.Add(this.companyBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 307);
            this.Name = "User_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Ceylon Petroleum Corporation (Ceypetco)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corporationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corporationDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox sfunctionBox3;
        private System.Windows.Forms.ComboBox functionBox2;
        private System.Windows.Forms.ComboBox companyBox1;
        private System.Windows.Forms.DataGridView User_dataGridView;
        private CorporationDataSet corporationDataSet;
        private System.Windows.Forms.BindingSource employeBindingSource;
        private CorporationDataSetTableAdapters.employeTableAdapter employeTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox sNametextBox;
        private System.Windows.Forms.Button EPFsearch;
        private System.Windows.Forms.TextBox txtSearch;
        private CorporationDataSet corporationDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePFnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeIntercomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeLandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officefaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeLocationDataGridViewTextBoxColumn;
    }
}

