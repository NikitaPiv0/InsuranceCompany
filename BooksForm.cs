using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Страховая_компания__2021_
{
    public partial class BooksForm : Form
    {
        private int userIsAdmin;

        public BooksForm(int uia)
        {
            this.userIsAdmin = uia;

            InitializeComponent();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Request". При необходимости она может быть перемещена или удалена.
            this.requestTableAdapter.Fill(this.insuranceCompanyDataSet.Request);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.InsuranceCase". При необходимости она может быть перемещена или удалена.
            this.insuranceCaseTableAdapter.Fill(this.insuranceCompanyDataSet.InsuranceCase);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.ListRisks". При необходимости она может быть перемещена или удалена.
            this.listRisksTableAdapter.Fill(this.insuranceCompanyDataSet.ListRisks);
            this.insuranceCompanyDataSet.ListRisks.programmNameColumn.Expression = "Parent (FK_ListRisks_Programm).name";
            this.insuranceCompanyDataSet.ListRisks.riskNameColumn.Expression = "Parent (FK_ListRisks_Risk).name";
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Insurer". При необходимости она может быть перемещена или удалена.
            this.insurerTableAdapter.Fill(this.insuranceCompanyDataSet.Insurer);
            this.insuranceCompanyDataSet.Insurer.branckNameColumn.Expression = "Parent (FK_Insurer_Branch).addresLegal";
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Branch". При необходимости она может быть перемещена или удалена.
            this.branchTableAdapter.Fill(this.insuranceCompanyDataSet.Branch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.InsuranceType". При необходимости она может быть перемещена или удалена.
            this.insuranceTypeTableAdapter.Fill(this.insuranceCompanyDataSet.InsuranceType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Programm". При необходимости она может быть перемещена или удалена.
            this.programmTableAdapter.Fill(this.insuranceCompanyDataSet.Programm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Risk". При необходимости она может быть перемещена или удалена.
            this.riskTableAdapter.Fill(this.insuranceCompanyDataSet.Risk);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.insuranceCompanyDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.insuranceCompanyDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Insurer". При необходимости она может быть перемещена или удалена.

            if (this.insuranceCompanyDataSet.Programm.Rows.Count > 0)
            {
                DataView dv = new DataView(this.insuranceCompanyDataSet.ListRisks, "programmID = " + progremmListRickCB.SelectedValue.ToString(), "", DataViewRowState.CurrentRows);
                this.listRiskDataGridView.DataSource = dv;
            }

            if (this.insuranceCompanyDataSet.Branch.Rows.Count > 0)
            {
                DataView dv = new DataView(this.insuranceCompanyDataSet.Insurer, "branckID = " + branchInsurerCB.SelectedValue.ToString(), "", DataViewRowState.CurrentRows);
                this.insurerDataGridView.DataSource = dv;
            }

            if (this.userIsAdmin != 1)
                booksTabControl.TabPages.RemoveByKey("tabPage5");

            subjectClientCB.SelectedIndex = 0;

            /* DGV */
            branchDataGridView.Columns[0].Visible = false;
            clientDataGridView.Columns[0].Visible = false;
            insurerDataGridView.Columns[0].Visible = false;
            insuranceTypeDataGridView.Columns[0].Visible = false;
            programmDataGridView.Columns[0].Visible = false;
            riskDataGridView.Columns[0].Visible = false;
            listRiskDataGridView.Columns[0].Visible = false;
            userDataGridView.Columns[0].Visible = false;
        }

        private void insertUserBTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
            {
                string login = loginUserTB.Text;
                string password = passwordUserTB.Text;
                string fio = fioUserTB.Text;
                bool isAdmin = adminUserCB.Checked;

                this.userTableAdapter.Insert(login, password, fio, Convert.ToInt32(isAdmin));
                this.userTableAdapter.Fill(this.insuranceCompanyDataSet.User);

                loginUserTB.Clear();
                passwordUserTB.Clear();
                fioUserTB.Clear();
                adminUserCB.Checked = false;
            }
        }

        private void updateUserBTN_Click(object sender, EventArgs e)
        {
            if (userDataGridView.Rows.Count > 0)
            {
                if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
                {
                    DataRow row = this.insuranceCompanyDataSet.User.Rows.Find(Convert.ToInt32(userDataGridView.CurrentRow.Cells[0].Value));

                    row["login"] = loginUserTB.Text;
                    row["password"] = passwordUserTB.Text;
                    row["FIO"] = fioUserTB.Text;
                    row["isAdmin"] = adminUserCB.Checked;

                    this.userTableAdapter.Update(row);
                    this.userTableAdapter.Fill(this.insuranceCompanyDataSet.User);

                    loginUserTB.Clear();
                    passwordUserTB.Clear();
                    fioUserTB.Clear();
                    adminUserCB.Checked = false;
                }
            }
        }

        private void deleteUserBTN_Click(object sender, EventArgs e)
        {
            if (userDataGridView.Rows.Count > 0)
            {
                DataRow row = this.insuranceCompanyDataSet.User.Rows.Find(Convert.ToInt32(userDataGridView.CurrentRow.Cells[0].Value));
                DataRow[] rows = row.GetChildRows("FK_Request_User");

                if (rows.GetLength(0) == 0)
                {

                    this.userTableAdapter.Delete(Convert.ToInt32(row[0]), Convert.ToString(row[1]),
                        Convert.ToString(row[2]), Convert.ToString(row[3]), Convert.ToInt32(row[4]));
                    this.userTableAdapter.Fill(this.insuranceCompanyDataSet.User);

                }
                else
                {
                    MessageBox.Show("Есть дочерние строки. Строка не удалена.");
                }
            }
        }

        private void insertRiskBTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
            {
                string name = riskNameTB.Text;

                this.riskTableAdapter.Insert(name);
                this.riskTableAdapter.Fill(this.insuranceCompanyDataSet.Risk);

                riskNameTB.Clear();
            }
        }

        private void updateRiskBTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
            {
                if (riskDataGridView.Rows.Count > 0)
                {
                    DataRow row = this.insuranceCompanyDataSet.Risk.Rows.Find(Convert.ToInt32(riskDataGridView.CurrentRow.Cells[0].Value));

                    row["name"] = riskNameTB.Text;

                    this.riskTableAdapter.Update(row);
                    this.riskTableAdapter.Fill(this.insuranceCompanyDataSet.Risk);

                    riskNameTB.Clear();
                }
            }
        }

        private void deleteRiskBTN_Click(object sender, EventArgs e)
        {
            if (riskDataGridView.Rows.Count > 0)
            {
                DataRow row = this.insuranceCompanyDataSet.Risk.Rows.Find(Convert.ToInt32(riskDataGridView.CurrentRow.Cells[0].Value));
                DataRow[] rows1 = row.GetChildRows("FK_InsuranceCase_Risk");
                DataRow[] rows2 = row.GetChildRows("FK_ListRisks_Risk");

                if (rows1.GetLength(0) == 0 && rows2.GetLength(0) == 0)
                {
                    this.riskTableAdapter.Delete(Convert.ToInt32(row[0]), Convert.ToString(row[1]));
                    this.riskTableAdapter.Fill(this.insuranceCompanyDataSet.Risk);
                }
                else
                {
                    MessageBox.Show("Есть дочерние строки. Удаление не выполнено.");
                }
            }
        }

        private void insertProgrammBTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
            {
                string name = programmNameTB.Text;

                this.programmTableAdapter.Insert(name);
                this.programmTableAdapter.Fill(this.insuranceCompanyDataSet.Programm);

                if (this.insuranceCompanyDataSet.Programm.Rows.Count == 1)
                {
                    DataView dv = new DataView(this.insuranceCompanyDataSet.ListRisks, "programmID = " + progremmListRickCB.SelectedValue.ToString(), "", DataViewRowState.CurrentRows);
                    this.listRiskDataGridView.DataSource = dv;
                }

                programmNameTB.Clear();
            }
        }

        private void updateProgrammBTN_Click(object sender, EventArgs e)
        {
            if (programmDataGridView.Rows.Count > 0)
            {
                if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
                {
                    DataRow row = this.insuranceCompanyDataSet.Programm.Rows.Find(Convert.ToInt32(programmDataGridView.CurrentRow.Cells[0].Value));

                    row["name"] = programmNameTB.Text;

                    this.programmTableAdapter.Update(row);
                    this.programmTableAdapter.Fill(this.insuranceCompanyDataSet.Programm);

                    programmNameTB.Clear();
                }
            }
        }

        private void deleteProgrammBTN_Click(object sender, EventArgs e)
        {
            if (programmDataGridView.Rows.Count > 0)
            {
                DataRow row = this.insuranceCompanyDataSet.Programm.Rows.Find(Convert.ToInt32(programmDataGridView.CurrentRow.Cells[0].Value));
                DataRow[] rows1 = row.GetChildRows("FK_Request_Programm");
                DataRow[] rows2 = row.GetChildRows("FK_ListRisks_Programm");

                if (rows1.GetLength(0) == 0 && rows2.GetLength(0) == 0)
                {
                    this.programmTableAdapter.Delete(Convert.ToInt32(row[0]), Convert.ToString(row[1]));
                    this.programmTableAdapter.Fill(this.insuranceCompanyDataSet.Programm);
                }
                else
                {
                    MessageBox.Show("Есть дочерние строки. Удаление не выполнено.");
                }
            }
        }

        private void insertInsuranceTypeBTN(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
            {
                string name = nameInsuranceTypeTB.Text;
                string documentList = documentListInsuranceTypeTB.Text;

                this.insuranceTypeTableAdapter.Insert(name, documentList);
                this.insuranceTypeTableAdapter.Fill(this.insuranceCompanyDataSet.InsuranceType);

                nameInsuranceTypeTB.Clear();
                documentListInsuranceTypeTB.Clear();
            }
        }

        private void updateInsuranceTypeBTN(object sender, EventArgs e)
        {
            if (programmDataGridView.Rows.Count > 0)
            {
                if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
                {
                    DataRow row = this.insuranceCompanyDataSet.InsuranceType.Rows.Find(Convert.ToInt32(insuranceTypeDataGridView.CurrentRow.Cells[0].Value));

                    row["name"] = nameInsuranceTypeTB.Text;
                    row["listDocuments"] = documentListInsuranceTypeTB.Text;

                    this.insuranceTypeTableAdapter.Update(row);
                    this.insuranceTypeTableAdapter.Fill(this.insuranceCompanyDataSet.InsuranceType);

                    nameInsuranceTypeTB.Clear();
                    documentListInsuranceTypeTB.Clear();
                }
            }
        }

        private void deleteInsuranceTypeBTN(object sender, EventArgs e)
        {
            if (insuranceTypeDataGridView.Rows.Count > 0)
            {
                DataRow row = this.insuranceCompanyDataSet.InsuranceType.Rows.Find(Convert.ToInt32(insuranceTypeDataGridView.CurrentRow.Cells[0].Value));
                DataRow[] rows = row.GetChildRows("FK_Request_InsuranceType");
                if (rows.GetLength(0) == 0)
                {
                    this.insuranceTypeTableAdapter.Delete(Convert.ToInt32(row[0]), Convert.ToString(row[1]), Convert.ToString(row[2]));
                    this.insuranceTypeTableAdapter.Fill(this.insuranceCompanyDataSet.InsuranceType);
                }
                else
                {
                    MessageBox.Show("Есть дочерние строки. Удаление не выполнено.");
                }
            }
        }

        private void insertBranchBTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
            {
                string name = nameBranchTB.Text;
                string addresLegal = addressBranchTB.Text;
                string INN = innBranchTB.Text;
                string OGRN = ogrnBranchTB.Text;
                string BIK = bikBranchTB.Text;
                string KPP = kppBranchTB.Text;
                string licence = licenceBranchTB.Text;
                string checkingAccount = accountBranchTB.Text;
                string email = emailBranchTB.Text;
                string phoneCompany = phoneBranchTB.Text;

                this.branchTableAdapter.Insert(name, addresLegal, INN, OGRN, BIK, KPP,
                    licence, checkingAccount, email, phoneCompany);
                this.branchTableAdapter.Fill(this.insuranceCompanyDataSet.Branch);

                nameBranchTB.Clear();
                addressBranchTB.Clear();
                innBranchTB.Clear();
                ogrnBranchTB.Clear();
                bikBranchTB.Clear();
                kppBranchTB.Clear();
                licenceBranchTB.Clear();
                accountBranchTB.Clear();
                emailBranchTB.Clear();
                phoneBranchTB.Clear();
            }
        }

        private void updateBranchBTN_Click(object sender, EventArgs e)
        {
            if (riskDataGridView.Rows.Count > 0)
            {
                if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
                {
                    DataRow row = this.insuranceCompanyDataSet.Branch.Rows.Find(Convert.ToInt32(branchDataGridView.CurrentRow.Cells[0].Value));

                    row["name"] = nameBranchTB.Text;
                    row["addresLegal"] = addressBranchTB.Text;
                    row["INN"] = innBranchTB.Text;
                    row["OGRN"] = ogrnBranchTB.Text;
                    row["BIK"] = bikBranchTB.Text;
                    row["KPP"] = kppBranchTB.Text;
                    row["licence"] = licenceBranchTB.Text;
                    row["checkingAccount"] = accountBranchTB.Text;
                    row["email"] = emailBranchTB.Text;
                    row["phoneNumber"] = phoneBranchTB.Text;

                    this.branchTableAdapter.Update(row);
                    this.branchTableAdapter.Fill(this.insuranceCompanyDataSet.Branch);

                    nameBranchTB.Clear();
                    addressBranchTB.Clear();
                    innBranchTB.Clear();
                    ogrnBranchTB.Clear();
                    bikBranchTB.Clear();
                    kppBranchTB.Clear();
                    licenceBranchTB.Clear();
                    accountBranchTB.Clear();
                    emailBranchTB.Clear();
                    ; phoneBranchTB.Clear();
                }
            }
        }

        private void deleteBranchBTN_Click(object sender, EventArgs e)
        {
            if (branchDataGridView.Rows.Count > 0)
            {
                DataRow row = this.insuranceCompanyDataSet.Branch.Rows.Find(Convert.ToInt32(branchDataGridView.CurrentRow.Cells[0].Value));
                DataRow[] childeRows = row.GetChildRows("FK_Insurer_Branch");
                if (childeRows.GetLength(0) == 0)
                {
                    this.branchTableAdapter.Delete(Convert.ToInt32(row[0]), Convert.ToString(row[1]), Convert.ToString(row[2]),
                        Convert.ToString(row[3]), Convert.ToString(row[4]), Convert.ToString(row[5]), Convert.ToString(row[6]),
                        Convert.ToString(row[7]), Convert.ToString(row[8]), Convert.ToString(row[9]), Convert.ToString(row[10]));
                    this.branchTableAdapter.Fill(this.insuranceCompanyDataSet.Branch);
                }
                else
                {
                    MessageBox.Show("Есть дочение строки. Строка не удалена.");
                }
            }
        }

        private void insertInsurerBTN_Click(object sender, EventArgs e)
        {
            if (this.insuranceCompanyDataSet.Branch.Rows.Count > 0)
            {
                if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
                {
                    string firstName = fnameInsurerTB.Text;
                    string middleName = mnameInsurerTB.Text;
                    string lastName = lnameInsurerTB.Text;
                    int branch = Convert.ToInt32(branchInsurerCB.SelectedValue);

                    this.insurerTableAdapter.Insert(firstName, middleName, lastName, branch);
                    this.insurerTableAdapter.Fill(this.insuranceCompanyDataSet.Insurer);

                    fnameInsurerTB.Clear();
                    mnameInsurerTB.Clear();
                    lnameInsurerTB.Clear();
                }
            }
            else
            {
                MessageBox.Show("В таблице \"Филиал\" нет записей. Добавьте филиал.");
            }
        }

        private void updateInsurerBTN_Click(object sender, EventArgs e)
        {
            if (insurerDataGridView.Rows.Count > 0)
            {
                if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
                {
                    DataRow row = this.insuranceCompanyDataSet.Insurer.Rows.Find(Convert.ToInt32(insurerDataGridView.CurrentRow.Cells[0].Value));

                    row["firstName"] = fnameInsurerTB.Text;
                    row["middleName"] = mnameInsurerTB.Text;
                    row["lastName"] = lnameInsurerTB.Text;
                    row["branckID"] = branchInsurerCB.SelectedValue;

                    this.insurerTableAdapter.Update(row);
                    this.insurerTableAdapter.Fill(this.insuranceCompanyDataSet.Insurer);

                    fnameInsurerTB.Clear();
                    mnameInsurerTB.Clear();
                    lnameInsurerTB.Clear();
                }
            }
        }

        private void deleteInsurerBTN_Click(object sender, EventArgs e)
        {
            if (insurerDataGridView.Rows.Count > 0)
            {
                DataRow row = this.insuranceCompanyDataSet.Insurer.Rows.Find(Convert.ToInt32(insurerDataGridView.CurrentRow.Cells[0].Value));
                DataRow[] childeRows = row.GetChildRows("FK_Request_Insurer");
                if (childeRows.GetLength(0) == 0)
                {
                    this.insurerTableAdapter.Delete(Convert.ToInt32(row[0]), Convert.ToString(row[1]), Convert.ToString(row[2]),
                        Convert.ToString(row[3]), Convert.ToInt32(row[4]));
                    this.insurerTableAdapter.Fill(this.insuranceCompanyDataSet.Insurer);
                }
                else
                {
                    MessageBox.Show("Есть дочение строки. Строка не удалена.");
                }
            }
        }

        private void insertListRickBTN_Click(object sender, EventArgs e)
        {
            if (this.insuranceCompanyDataSet.Programm.Rows.Count > 0)
            {
                if (this.insuranceCompanyDataSet.Risk.Rows.Count > 0)
                {
                    int porgrammID = Convert.ToInt32(progremmListRickCB.SelectedValue);
                    int riskID = Convert.ToInt32(riskListRickCB.SelectedValue);

                    this.listRisksTableAdapter.Insert(porgrammID, riskID);
                    this.listRisksTableAdapter.Fill(this.insuranceCompanyDataSet.ListRisks);
                }
                else
                {
                    MessageBox.Show("В таблице \"Риск\" нет записей. Добавьте риск.");
                }
            }
            else
            {
                MessageBox.Show("В таблице \"Программа\" нет записей. Добавьте программу.");
            }
        }

        private void deleteListRickBTN_Click(object sender, EventArgs e)
        {
            if (listRiskDataGridView.Rows.Count > 0)
            {
                DataRow row = this.insuranceCompanyDataSet.ListRisks.Rows.Find(Convert.ToInt32(listRiskDataGridView.CurrentRow.Cells["ID"].Value));

                this.listRisksTableAdapter.Delete(Convert.ToInt32(row["ID"]), Convert.ToInt32(row["programmID"]), Convert.ToInt32(row["riskID"]));
                this.listRisksTableAdapter.Fill(this.insuranceCompanyDataSet.ListRisks);
            }
        }

        private void insertClientBTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
            {
                int porgrammID = Convert.ToInt32(progremmListRickCB.SelectedValue);

                string subject = subjectClientCB.Text;
                string firstName = fnameClientTB.Text;
                string middleName = mnameClientTB.Text;
                string lastName = lnameClientTB.Text;
                DateTime birthday = birthdayClientDTP.Value;
                string phoneNumber = phoneClientTB.Text;
                string address = addressClientTB.Text;
                string addresstSeries = passportSeriosClientTB.Text;
                string passportNumber = passportNumberClientTB.Text;
                string passportIssued = passportIsueClientTB.Text;
                DateTime passportDate = passportDateClientDTP.Value;
                string INN = innClientTB.Text;
                string KPP = kppClientTB.Text;
                string OGRN = ogrnClientTB.Text;
                string checkingAccount = raccClientTB.Text;
                string correspondenceAccount = kaccClientTB.Text;
                string addresLegal = uaddressClientTB.Text;
                string addresActual = faddressClientTB.Text;
                string fax = faxClientTB.Text;
                string email = emailClientTB.Text;
                string site = siteClientTB.Text;
                string fullName = companyNameClientTB.Text;
                string phoneCompany = companyPhoneClientTB.Text;

                this.clientTableAdapter.Insert(subject, firstName, middleName, lastName, birthday, phoneNumber, address,
                addresstSeries, passportNumber, passportIssued, passportDate, INN, KPP, OGRN,
                checkingAccount, correspondenceAccount, addresLegal, addresActual, fax, email,
                site, fullName, phoneCompany);
                this.clientTableAdapter.Fill(this.insuranceCompanyDataSet.Client);

                subjectClientCB.SelectedIndex = 0;
                fnameClientTB.Clear();
                mnameClientTB.Clear();
                lnameClientTB.Clear();
                passportSeriosClientTB.Clear();
                passportNumberClientTB.Clear();
                passportIsueClientTB.Clear();
                phoneClientTB.Clear();
                addressClientTB.Clear();
                companyNameClientTB.Clear();
                innClientTB.Clear();
                ogrnClientTB.Clear();
                kppClientTB.Clear();
                raccClientTB.Clear();
                kaccClientTB.Clear();
                uaddressClientTB.Clear();
                faddressClientTB.Clear();
                faxClientTB.Clear();
                emailClientTB.Clear();
                companyPhoneClientTB.Clear();
                siteClientTB.Clear();
                birthdayClientDTP.Value = DateTime.Now;
                passportDateClientDTP.Value = DateTime.Now;
            }
        }

        private void updateClientBTN_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.Rows.Count > 0)
            {
                if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
                {
                    DataRow row = this.insuranceCompanyDataSet.Client.Rows.Find(Convert.ToInt32(clientDataGridView.CurrentRow.Cells[0].Value));

                    row["subject"] = subjectClientCB.Text;
                    row["firstName"] = fnameClientTB.Text;
                    row["middleName"] = mnameClientTB.Text;
                    row["lastName"] = lnameClientTB.Text;
                    row["birthday"] = birthdayClientDTP.Value;
                    row["phoneNumber"] = phoneClientTB.Text;
                    row["address"] = addressClientTB.Text;
                    row["passportSeries"] = passportSeriosClientTB.Text;
                    row["passportNumber"] = passportNumberClientTB.Text;
                    row["passportIssued"] = passportIsueClientTB.Text;
                    row["passportDate"] = passportDateClientDTP.Value;
                    row["INN"] = innClientTB.Text;
                    row["KPP"] = kppClientTB.Text;
                    row["OGRN"] = ogrnClientTB.Text;
                    row["checkingAccount"] = raccClientTB.Text;
                    row["correspondenceAccount"] = kaccClientTB.Text;
                    row["addresLegal"] = uaddressClientTB.Text;
                    row["addresActual"] = faddressClientTB.Text;
                    row["fax"] = faxClientTB.Text;
                    row["email"] = emailClientTB.Text;
                    row["site"] = siteClientTB.Text;
                    row["fullName"] = companyNameClientTB.Text;
                    row["phoneCompany"] = companyPhoneClientTB.Text;

                    this.clientTableAdapter.Update(row);
                    this.clientTableAdapter.Fill(this.insuranceCompanyDataSet.Client);

                    subjectClientCB.SelectedIndex = 0;
                    fnameClientTB.Clear();
                    mnameClientTB.Clear();
                    lnameClientTB.Clear();
                    passportSeriosClientTB.Clear();
                    passportNumberClientTB.Clear();
                    passportIsueClientTB.Clear();
                    phoneClientTB.Clear();
                    addressClientTB.Clear();
                    companyNameClientTB.Clear();
                    innClientTB.Clear();
                    ogrnClientTB.Clear();
                    kppClientTB.Clear();
                    raccClientTB.Clear();
                    kaccClientTB.Clear();
                    uaddressClientTB.Clear();
                    faddressClientTB.Clear();
                    faxClientTB.Clear();
                    emailClientTB.Clear();
                    companyPhoneClientTB.Clear();
                    siteClientTB.Clear();
                    birthdayClientDTP.Value = DateTime.Now;
                    passportDateClientDTP.Value = DateTime.Now;
                }
            }
        }

        private void deleteClientBTN_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.Rows.Count > 0)
            {
                DataRow row = this.insuranceCompanyDataSet.Client.Rows.Find(Convert.ToInt32(clientDataGridView.CurrentRow.Cells[0].Value));
                DataRow[] childeRows = row.GetChildRows("FK_Request_Client");
                if (childeRows.GetLength(0) == 0)
                {
                    this.clientTableAdapter.Delete(Convert.ToInt32(row[0]), Convert.ToString(row[1]), Convert.ToString(row[2]),
                    Convert.ToString(row[3]), Convert.ToString(row[4]), Convert.ToDateTime(row[5]), Convert.ToString(row[6]),
                    Convert.ToString(row[7]), Convert.ToString(row[8]), Convert.ToString(row[9]), Convert.ToString(row[10]),
                    Convert.ToDateTime(row[11]), Convert.ToString(row[12]), Convert.ToString(row[13]), Convert.ToString(row[14]),
                    Convert.ToString(row[15]), Convert.ToString(row[16]), Convert.ToString(row[17]), Convert.ToString(row[18]),
                    Convert.ToString(row[19]), Convert.ToString(row[20]), Convert.ToString(row[21]), Convert.ToString(row[22]),
                    Convert.ToString(row[23]));
                    this.clientTableAdapter.Fill(this.insuranceCompanyDataSet.Client);
                }
                else
                {
                    MessageBox.Show("Есть дочение строки. Строка не удалена.");
                }
            }
        }

        private void progremmListRickCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.insuranceCompanyDataSet.ListRisks, "programmID = " + progremmListRickCB.SelectedValue.ToString(), "", DataViewRowState.CurrentRows);
            this.listRiskDataGridView.DataSource = dv;
        }

        private void tabPage_Leave(object sender, EventArgs e)
        {
            TabPage tempTabPage = (TabPage)sender;
            Control.ControlCollection elements = tempTabPage.Controls;
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] is TextBox)
                {
                    TextBox tempTB = (TextBox)elements[i];
                    tempTB.CausesValidation = false;
                    booksErrorProvider.SetError(tempTB, null);
                }
            }
        }

        private void tabPage_Enter(object sender, EventArgs e)
        {
            TabPage tempTabPage = (TabPage)sender;
            Control.ControlCollection elements = tempTabPage.Controls;
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] is TextBox)
                {
                    TextBox tempTB = (TextBox)elements[i];
                    tempTB.CausesValidation = true;
                    booksErrorProvider.SetError(tempTB, null);
                }
                else if (elements[i] is DataGridView)
                {
                    DataGridView tempDGV = (DataGridView)elements[i];
                    tempDGV.Columns[0].Visible = false;
                }
            }

            if (tempTabPage == clientTabPage)
                this.isEmptyString = true;
            else
                this.isEmptyString = false;
        }

        // валидация
        private bool isEmptyString = true;

        private void decimalRequestCB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringMoney, 0, int.MaxValue, false);
        }

        private void branchInsurerCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.insuranceCompanyDataSet.Insurer, "branckID = " + branchInsurerCB.SelectedValue.ToString(), "", DataViewRowState.CurrentRows);
            this.insurerDataGridView.DataSource = dv;

            fnameInsurerTB.Clear();
            mnameInsurerTB.Clear();
            lnameInsurerTB.Clear();
        }

        private void string500RequestTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringStandard, 0, 500, false);
        }

        private void string150RequestTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringStandard, 0, 150, false);
        }

        private void string50RequestTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringStandard, 0, 50, false);
        }

        private void innTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringNumber, 12, 12, this.isEmptyString);
        }

        private void ogrnTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringNumber, 13, 13, this.isEmptyString);
        }

        private void bikTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringNumber, 9, 9, false);
        }

        private void kppTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider,  StringValidation.StringNumber, 9, 9, this.isEmptyString);
        }

        private void licenceTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringNumber, 4, 6, false);
        }

        private void accountTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringNumber, 20, 20, this.isEmptyString);
        }

        private void emailTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringEmail, 0, 150, true);
        }

        private void phoneTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringNumber, 6, 11, false);
        }

        private void passportSeriosTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringNumber, 4, 4, false);
        }

        private void passportNumberTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringNumber, 6, 6, false);
        }

        private void companyNameClientTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringStandard, 0, 150, this.isEmptyString);
        }

        private void kaccTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringNumber, 20, 20, this.isEmptyString);
        }

        private void companyPhoneClientTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringNumber, 6, 11, false);
        }

        private void clientDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow row = this.insuranceCompanyDataSet.Client.Rows.Find(Convert.ToInt32(this.clientDataGridView.Rows[e.RowIndex].Cells[0].Value));
            subjectClientCB.Text = row["subject"].ToString();
            fnameClientTB.Text = row["firstName"].ToString();
            mnameClientTB.Text = row["middleName"].ToString();
            lnameClientTB.Text = row["lastName"].ToString();
            passportSeriosClientTB.Text = row["passportSeries"].ToString();
            passportNumberClientTB.Text = row["passportNumber"].ToString();
            passportIsueClientTB.Text = row["passportIssued"].ToString();
            phoneClientTB.Text = row["phoneNumber"].ToString();
            addressClientTB.Text = row["address"].ToString();
            companyNameClientTB.Text = row["fullName"].ToString();
            innClientTB.Text = row["INN"].ToString();
            ogrnClientTB.Text = row["OGRN"].ToString();
            kppClientTB.Text = row["KPP"].ToString();
            raccClientTB.Text = row["checkingAccount"].ToString();
            kaccClientTB.Text = row["correspondenceAccount"].ToString();
            uaddressClientTB.Text = row["addresLegal"].ToString();
            faddressClientTB.Text = row["addresActual"].ToString();
            faxClientTB.Text = row["fax"].ToString();
            emailClientTB.Text = row["email"].ToString();
            companyPhoneClientTB.Text = row["phoneCompany"].ToString();
            siteClientTB.Text = row["site"].ToString();
            birthdayClientDTP.Value = Convert.ToDateTime(row["birthday"]);
            passportDateClientDTP.Value = Convert.ToDateTime(row["passportDate"]);
        }

        private void userDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow row = this.insuranceCompanyDataSet.User.Rows.Find(Convert.ToInt32(this.userDataGridView.Rows[e.RowIndex].Cells[0].Value));
            loginUserTB.Text = row["login"].ToString();
            passwordUserTB.Text = row["password"].ToString();
            fioUserTB.Text = row["FIO"].ToString();
            adminUserCB.Checked = Convert.ToBoolean(row["isAdmin"]);
        }

        private void riskDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow row = this.insuranceCompanyDataSet.Risk.Rows.Find(Convert.ToInt32(this.riskDataGridView.Rows[e.RowIndex].Cells[0].Value));
            riskNameTB.Text = row["name"].ToString();
        }

        private void programmDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow row = this.insuranceCompanyDataSet.Programm.Rows.Find(Convert.ToInt32(this.programmDataGridView.Rows[e.RowIndex].Cells[0].Value));
            programmNameTB.Text = row["name"].ToString();
        }

        private void insuranceTypeDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow row = this.insuranceCompanyDataSet.InsuranceType.Rows.Find(Convert.ToInt32(this.insuranceTypeDataGridView.Rows[e.RowIndex].Cells[0].Value));
            nameInsuranceTypeTB.Text = row["name"].ToString();
            documentListInsuranceTypeTB.Text = row["listDocuments"].ToString();
        }

        private void insurerDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow row = this.insuranceCompanyDataSet.Insurer.Rows.Find(Convert.ToInt32(this.insurerDataGridView.Rows[e.RowIndex].Cells[0].Value));
            fnameInsurerTB.Text = row["firstName"].ToString();
            mnameInsurerTB.Text = row["middleName"].ToString();
            lnameInsurerTB.Text = row["lastName"].ToString();
            branchInsurerCB.SelectedValue = Convert.ToInt32(row["branckID"]);
        }

        private void branchDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow row = this.insuranceCompanyDataSet.Branch.Rows.Find(Convert.ToInt32(this.branchDataGridView.Rows[e.RowIndex].Cells[0].Value));
            nameBranchTB.Text = row["name"].ToString();
            addressBranchTB.Text = row["addresLegal"].ToString();
            innBranchTB.Text = row["INN"].ToString();
            ogrnBranchTB.Text = row["OGRN"].ToString();
            bikBranchTB.Text = row["BIK"].ToString();
            kppBranchTB.Text = row["KPP"].ToString();
            licenceBranchTB.Text = row["licence"].ToString();
            accountBranchTB.Text = row["checkingAccount"].ToString();
            emailBranchTB.Text = row["email"].ToString();
            phoneBranchTB.Text = row["phoneNumber"].ToString();
        }

        private void phoneClientTB_Validating_1(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringNumber, 6, 11, true);
        }

        private void string150ClientTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, booksErrorProvider, StringValidation.StringStandard, 0, 150, true);
        }
    }
}