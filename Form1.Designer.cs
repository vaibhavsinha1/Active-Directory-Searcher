namespace ADSearchWinForm
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
            label1 = new Label();
            txtDomain = new TextBox();
            txtOU = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtSearchCriteria = new RichTextBox();
            label4 = new Label();
            txtPageSize = new TextBox();
            label5 = new Label();
            label6 = new Label();
            chkPropertiesToLoad = new CheckedListBox();
            btnSearch = new Button();
            label7 = new Label();
            chkSaveFile = new CheckBox();
            txtLDAPFilter = new RichTextBox();
            label8 = new Label();
            txtObjClass = new TextBox();
            label9 = new Label();
            txtObjCategory = new TextBox();
            label10 = new Label();
            rbAndSearch = new RadioButton();
            rbOrSearch = new RadioButton();
            grpBoxSearch = new GroupBox();
            txtSizeLimit = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtSortProperty = new TextBox();
            label14 = new Label();
            groupBox1 = new GroupBox();
            rbAsc = new RadioButton();
            radioButton2 = new RadioButton();
            lstSearchResult = new ListBox();
            label15 = new Label();
            txtOtherProperties = new TextBox();
            label16 = new Label();
            grpBoxSearch.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 91);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Domain";
            // 
            // txtDomain
            // 
            txtDomain.Location = new Point(178, 88);
            txtDomain.Name = "txtDomain";
            txtDomain.Size = new Size(238, 31);
            txtDomain.TabIndex = 1;
            txtDomain.Text = "redmond";
            // 
            // txtOU
            // 
            txtOU.Location = new Point(555, 91);
            txtOU.Name = "txtOU";
            txtOU.Size = new Size(637, 31);
            txtOU.TabIndex = 3;
            txtOU.Text = "OU=Users,OU=Coreidentity,DC=redmond,DC=corp,DC=microsoft,DC=com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 91);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 2;
            label2.Text = "OU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 160);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 4;
            label3.Text = "Search Criteria";
            // 
            // txtSearchCriteria
            // 
            txtSearchCriteria.Location = new Point(178, 157);
            txtSearchCriteria.Name = "txtSearchCriteria";
            txtSearchCriteria.Size = new Size(326, 144);
            txtSearchCriteria.TabIndex = 5;
            txtSearchCriteria.Text = "extensionAttribute4,6123895;samAccountName,vaibhavsinha  ";
            // 
            // label4
            // 
            label4.Location = new Point(545, 164);
            label4.Name = "label4";
            label4.Size = new Size(527, 124);
            label4.TabIndex = 6;
            label4.Text = "Enter multiple Search criteria sperated by semicolon and search property and value seperated by comma , e.g.   extensionAttribute4,6123895;samAccountName,vaibhavsinha  OR use LDAP filter";
            // 
            // txtPageSize
            // 
            txtPageSize.Location = new Point(145, 506);
            txtPageSize.Name = "txtPageSize";
            txtPageSize.Size = new Size(238, 31);
            txtPageSize.TabIndex = 8;
            txtPageSize.Text = "50";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 508);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 7;
            label5.Text = "PageSize";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 588);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 10;
            label6.Text = "Properties To Load";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // chkPropertiesToLoad
            // 
            chkPropertiesToLoad.FormattingEnabled = true;
            chkPropertiesToLoad.Location = new Point(190, 588);
            chkPropertiesToLoad.Name = "chkPropertiesToLoad";
            chkPropertiesToLoad.Size = new Size(263, 256);
            chkPropertiesToLoad.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(835, 917);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(356, 34);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 974);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 14;
            label7.Text = "Result";
            // 
            // chkSaveFile
            // 
            chkSaveFile.AutoSize = true;
            chkSaveFile.Location = new Point(844, 957);
            chkSaveFile.Name = "chkSaveFile";
            chkSaveFile.Size = new Size(493, 29);
            chkSaveFile.TabIndex = 15;
            chkSaveFile.Text = "Save Result in CSV in C:\\temp\\ADResult[CurrentDateTime]";
            chkSaveFile.UseVisualStyleBackColor = true;
            // 
            // txtLDAPFilter
            // 
            txtLDAPFilter.Location = new Point(178, 334);
            txtLDAPFilter.Name = "txtLDAPFilter";
            txtLDAPFilter.Size = new Size(326, 144);
            txtLDAPFilter.TabIndex = 17;
            txtLDAPFilter.Text = "";
            txtLDAPFilter.TextChanged += richTextBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 337);
            label8.Name = "label8";
            label8.Size = new Size(98, 25);
            label8.TabIndex = 16;
            label8.Text = "LDAP Filter";
            label8.Click += label8_Click;
            // 
            // txtObjClass
            // 
            txtObjClass.Location = new Point(178, 12);
            txtObjClass.Name = "txtObjClass";
            txtObjClass.Size = new Size(238, 31);
            txtObjClass.TabIndex = 19;
            txtObjClass.Text = "user";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 15);
            label9.Name = "label9";
            label9.Size = new Size(104, 25);
            label9.TabIndex = 18;
            label9.Text = "ObjectClass";
            // 
            // txtObjCategory
            // 
            txtObjCategory.Location = new Point(588, 9);
            txtObjCategory.Name = "txtObjCategory";
            txtObjCategory.Size = new Size(238, 31);
            txtObjCategory.TabIndex = 21;
            txtObjCategory.Text = "person";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(446, 12);
            label10.Name = "label10";
            label10.Size = new Size(136, 25);
            label10.TabIndex = 20;
            label10.Text = "ObjectCategory";
            // 
            // rbAndSearch
            // 
            rbAndSearch.AutoSize = true;
            rbAndSearch.Checked = true;
            rbAndSearch.Location = new Point(19, 59);
            rbAndSearch.Name = "rbAndSearch";
            rbAndSearch.Size = new Size(75, 29);
            rbAndSearch.TabIndex = 22;
            rbAndSearch.TabStop = true;
            rbAndSearch.Text = "AND";
            rbAndSearch.UseVisualStyleBackColor = true;
            // 
            // rbOrSearch
            // 
            rbOrSearch.AutoSize = true;
            rbOrSearch.Location = new Point(247, 59);
            rbOrSearch.Name = "rbOrSearch";
            rbOrSearch.Size = new Size(62, 29);
            rbOrSearch.TabIndex = 23;
            rbOrSearch.Text = "OR";
            rbOrSearch.UseVisualStyleBackColor = true;
            // 
            // grpBoxSearch
            // 
            grpBoxSearch.Controls.Add(rbAndSearch);
            grpBoxSearch.Controls.Add(rbOrSearch);
            grpBoxSearch.Location = new Point(555, 278);
            grpBoxSearch.Name = "grpBoxSearch";
            grpBoxSearch.Size = new Size(389, 104);
            grpBoxSearch.TabIndex = 24;
            grpBoxSearch.TabStop = false;
            grpBoxSearch.Text = "SearchCriteria";
            // 
            // txtSizeLimit
            // 
            txtSizeLimit.Location = new Point(626, 510);
            txtSizeLimit.Name = "txtSizeLimit";
            txtSizeLimit.Size = new Size(238, 31);
            txtSizeLimit.TabIndex = 26;
            txtSizeLimit.Text = "50";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(480, 512);
            label11.Name = "label11";
            label11.Size = new Size(81, 25);
            label11.TabIndex = 25;
            label11.Text = "SizeLimit";
            // 
            // label12
            // 
            label12.Location = new Point(614, 544);
            label12.Name = "label12";
            label12.Size = new Size(527, 54);
            label12.TabIndex = 27;
            label12.Text = "If there are multiple page result, each page result will be limited by this size limit, enter 0 for nolimit";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(480, 600);
            label13.Name = "label13";
            label13.Size = new Size(147, 25);
            label13.TabIndex = 28;
            label13.Text = "Sort On Property";
            label13.TextAlign = ContentAlignment.TopCenter;
            label13.Click += label13_Click;
            // 
            // txtSortProperty
            // 
            txtSortProperty.Location = new Point(626, 597);
            txtSortProperty.Name = "txtSortProperty";
            txtSortProperty.Size = new Size(238, 31);
            txtSortProperty.TabIndex = 29;
            txtSortProperty.Text = "cn";
            // 
            // label14
            // 
            label14.Location = new Point(614, 635);
            label14.Name = "label14";
            label14.Size = new Size(527, 54);
            label14.TabIndex = 30;
            label14.Text = "Enter one the selected proeprty to sort on";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbAsc);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(480, 678);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 104);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sort Direction";
            // 
            // rbAsc
            // 
            rbAsc.AutoSize = true;
            rbAsc.Checked = true;
            rbAsc.Location = new Point(19, 59);
            rbAsc.Name = "rbAsc";
            rbAsc.Size = new Size(70, 29);
            rbAsc.TabIndex = 22;
            rbAsc.TabStop = true;
            rbAsc.Text = "ASC";
            rbAsc.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(247, 59);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 29);
            radioButton2.TabIndex = 23;
            radioButton2.Text = "DESC";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // lstSearchResult
            // 
            lstSearchResult.FormattingEnabled = true;
            lstSearchResult.HorizontalScrollbar = true;
            lstSearchResult.ItemHeight = 25;
            lstSearchResult.Location = new Point(47, 1022);
            lstSearchResult.Name = "lstSearchResult";
            lstSearchResult.ScrollAlwaysVisible = true;
            lstSearchResult.Size = new Size(1290, 179);
            lstSearchResult.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(14, 884);
            label15.Name = "label15";
            label15.Size = new Size(142, 25);
            label15.TabIndex = 34;
            label15.Text = "Other Properties";
            // 
            // txtOtherProperties
            // 
            txtOtherProperties.Location = new Point(170, 881);
            txtOtherProperties.Name = "txtOtherProperties";
            txtOtherProperties.Size = new Size(637, 31);
            txtOtherProperties.TabIndex = 35;
            txtOtherProperties.Text = "extensionAttribute4";
            // 
            // label16
            // 
            label16.Location = new Point(170, 917);
            label16.Name = "label16";
            label16.Size = new Size(527, 38);
            label16.TabIndex = 36;
            label16.Text = "Enter comma seperated other properties to load";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 1221);
            Controls.Add(label16);
            Controls.Add(txtOtherProperties);
            Controls.Add(label15);
            Controls.Add(lstSearchResult);
            Controls.Add(groupBox1);
            Controls.Add(label14);
            Controls.Add(txtSortProperty);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtSizeLimit);
            Controls.Add(label11);
            Controls.Add(grpBoxSearch);
            Controls.Add(txtObjCategory);
            Controls.Add(label10);
            Controls.Add(txtObjClass);
            Controls.Add(label9);
            Controls.Add(txtLDAPFilter);
            Controls.Add(label8);
            Controls.Add(chkSaveFile);
            Controls.Add(label7);
            Controls.Add(btnSearch);
            Controls.Add(chkPropertiesToLoad);
            Controls.Add(label6);
            Controls.Add(txtPageSize);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSearchCriteria);
            Controls.Add(label3);
            Controls.Add(txtOU);
            Controls.Add(label2);
            Controls.Add(txtDomain);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpBoxSearch.ResumeLayout(false);
            grpBoxSearch.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDomain;
        private TextBox txtOU;
        private Label label2;
        private Label label3;
        private RichTextBox txtSearchCriteria;
        private Label label4;
        private TextBox txtPageSize;
        private Label label5;
        private Label label6;
        private CheckedListBox chkPropertiesToLoad;
        private Button btnSearch;
        private Label label7;
        private CheckBox chkSaveFile;
        private RichTextBox txtLDAPFilter;
        private Label label8;
        private TextBox txtObjClass;
        private Label label9;
        private TextBox txtObjCategory;
        private Label label10;
        private RadioButton rbAndSearch;
        private RadioButton rbOrSearch;
        private GroupBox grpBoxSearch;
        private TextBox txtSizeLimit;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtSortProperty;
        private Label label14;
        private GroupBox groupBox1;
        private RadioButton rbAsc;
        private RadioButton radioButton2;
        private ListBox lstSearchResult;
        private Label label15;
        private TextBox txtOtherProperties;
        private Label label16;
    }
}