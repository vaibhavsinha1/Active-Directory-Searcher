using ADDirectorySearcher;

namespace ADSearchWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var objectCategory = txtObjCategory.Text;
            var objectClass = txtObjClass.Text;
            var domain = txtDomain.Text;
            var ou = txtOU.Text;
            var userSearchCriteria = txtSearchCriteria.Text;
            var pageSize = txtPageSize.Text;
            var includeDeleted = chkBoxIncludeDeleted.Checked;
            var userName = txtUserName.Text;
            var password = txtPassword.Text;
            if (string.IsNullOrEmpty(pageSize))
            {
                pageSize = "0";
            }

            var sizeLimit = txtSizeLimit.Text;
            var searchCriteriaAnd = rbAndSearch.Checked;
            var propertiesToLoadList = new List<string>();
            if (chkPropertiesToLoad.CheckedItems.Count > 0)
            {
                foreach (var item in chkPropertiesToLoad.CheckedItems)
                {
                    propertiesToLoadList.Add(item.ToString().ToLower());
                }
            }

            var otherProperties = txtOtherProperties.Text;
            if (!string.IsNullOrEmpty(otherProperties))
            {
                propertiesToLoadList.AddRange(otherProperties.ToLower().Split(','));
            }
            if (propertiesToLoadList.Count == 0)
            {
                propertiesToLoadList.Add("samAccountName");
            }
            var sortProperty = txtSortProperty.Text;
            var sortDirection = rbAsc.Checked ? "ASC" : "DESC";
            var searchPropeties = userSearchCriteria.GetStringAsDictionary();
            var ldapSearchFilter = new LdapSearchFilter();
            var filter = ldapSearchFilter.GetLdapSearchFilter(objectClass: objectClass, objectCategory: objectCategory, isDeleted: includeDeleted, searchProperties: searchPropeties, andSearchCriteria: searchCriteriaAnd);
            var adSearchResult = new ADSearchResult();
            var searchRsult = adSearchResult.GetSearchResults(filter: filter, domain: domain, ou: ou, propertiesToLoad: propertiesToLoadList.ToArray(), pageSize: int.Parse(pageSize), sizeLimit: int.Parse(sizeLimit),
                                sortProperty: sortProperty, sortDirection: sortDirection, userName: userName, password: password, includeDeleted: includeDeleted);

            lstSearchResult.DataSource = searchRsult;
            if (chkSaveFile.Checked)
            {
                File.AppendAllLines($"c:\\temp\\ADResult{DateTime.Today.ToFileTime().ToString()}.csv", searchRsult);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] properties = { "CN", "samAccountName", "Name", "Mail", "EmployeeId", "ExtensionAttribute4" };
            foreach (var item in properties)
            {
                chkPropertiesToLoad.Items.Add(item, true);
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}