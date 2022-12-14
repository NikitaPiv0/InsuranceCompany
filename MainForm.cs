using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Страховая_компания__2021_
{
    public partial class MainForm : Form
    {
        private User userActive;
        public MainForm()
        {
            InitializeComponent();
            this.userActive = new User();
        }

        class User 
        {
            public int ID { get; set; }
            public string FIO { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public int IsAdmin { get; set; }
        }

        private void dataInit()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.ListRisks". При необходимости она может быть перемещена или удалена.
            this.listRisksTableAdapter.Fill(this.insuranceCompanyDataSet.ListRisks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Branch". При необходимости она может быть перемещена или удалена.
            this.branchTableAdapter.Fill(this.insuranceCompanyDataSet.Branch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.InsuranceCase". При необходимости она может быть перемещена или удалена.
            this.insuranceCaseTableAdapter.Fill(this.insuranceCompanyDataSet.InsuranceCase);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.insuranceCompanyDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.InsuranceType". При необходимости она может быть перемещена или удалена.
            this.insuranceTypeTableAdapter.Fill(this.insuranceCompanyDataSet.InsuranceType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Programm". При необходимости она может быть перемещена или удалена.
            this.programmTableAdapter.Fill(this.insuranceCompanyDataSet.Programm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Insurer". При необходимости она может быть перемещена или удалена.
            this.insurerTableAdapter.Fill(this.insuranceCompanyDataSet.Insurer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.insuranceCompanyDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Request". При необходимости она может быть перемещена или удалена.
            this.requestTableAdapter.Fill(this.insuranceCompanyDataSet.Request);

            if (this.insuranceCompanyDataSet.InsuranceType.Rows.Count > 0)
            {
                insuranceTypeRequestCB.SelectedItem = insuranceTypeRequestCB.Items[0];
                DataRow row = this.insuranceCompanyDataSet.InsuranceType.Rows.Find(Convert.ToInt32(insuranceTypeRequestCB.SelectedValue));
                documentListRequestTB.Text = Convert.ToString(row["listDocuments"]);
            }

            for (int i = 0; i < this.requestDataGridView.Rows.Count; i++)
            {
                statusRequest(i);
            }

            if (this.insuranceCompanyDataSet.Client.Rows.Count > 0)
            {
                List<ClientCB> userCBList = new List<ClientCB>();
                for (int i = 0; i < this.insuranceCompanyDataSet.Client.Rows.Count; i++)
                    userCBList.Add(new ClientCB
                    {
                        ID = Convert.ToInt32(this.insuranceCompanyDataSet.Client.Rows[i]["ID"]),
                        Name = Convert.ToString(this.insuranceCompanyDataSet.Client.Rows[i]["firstName"]) + " " +
                            Convert.ToString(this.insuranceCompanyDataSet.Client.Rows[i]["middleName"]) + " " +
                            Convert.ToString(this.insuranceCompanyDataSet.Client.Rows[i]["lastName"])
                    });

                clientRequestCB.DataSource = userCBList;
                clientRequestCB.DisplayMember = "Name";
                clientRequestCB.ValueMember = "ID";
            }

            if (this.insuranceCompanyDataSet.Insurer.Rows.Count > 0)
            {
                List<ClientCB> userCBList = new List<ClientCB>();
                for (int i = 0; i < this.insuranceCompanyDataSet.Insurer.Rows.Count; i++)
                    userCBList.Add(new ClientCB
                    {
                        ID = Convert.ToInt32(this.insuranceCompanyDataSet.Insurer.Rows[i]["ID"]),
                        Name = Convert.ToString(this.insuranceCompanyDataSet.Insurer.Rows[i]["firstName"]) + " " +
                            Convert.ToString(this.insuranceCompanyDataSet.Insurer.Rows[i]["middleName"]) + " " +
                            Convert.ToString(this.insuranceCompanyDataSet.Insurer.Rows[i]["lastName"])
                    });

                insurerRequestCB.DataSource = userCBList;
                insurerRequestCB.DisplayMember = "Name";
                insurerRequestCB.ValueMember = "ID";
            }
        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm(userActive.IsAdmin);
            booksForm.ShowDialog();

            dataInit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Risk". При необходимости она может быть перемещена или удалена.
            this.riskTableAdapter.Fill(this.insuranceCompanyDataSet.Risk);
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (loginForm.UserID == -1)
            {
                Application.Exit();
            }
            else
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.User". При необходимости она может быть перемещена или удалена.
                this.userTableAdapter.Fill(this.insuranceCompanyDataSet.User);

                DataRow userDataRow = this.insuranceCompanyDataSet.User.Rows.Find(loginForm.UserID);

                this.userActive.ID = Convert.ToInt32(userDataRow["ID"]);
                this.userActive.FIO = userDataRow["FIO"].ToString();
                this.userActive.Login = userDataRow["login"].ToString();
                this.userActive.Password = userDataRow["password"].ToString();
                this.userActive.IsAdmin = Convert.ToInt32(userDataRow["isAdmin"]);
            }

            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.ListRisks". При необходимости она может быть перемещена или удалена.
            this.listRisksTableAdapter.Fill(this.insuranceCompanyDataSet.ListRisks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Branch". При необходимости она может быть перемещена или удалена.
            this.branchTableAdapter.Fill(this.insuranceCompanyDataSet.Branch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.InsuranceCase". При необходимости она может быть перемещена или удалена.
            this.insuranceCaseTableAdapter.Fill(this.insuranceCompanyDataSet.InsuranceCase);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.InsuranceType". При необходимости она может быть перемещена или удалена.
            this.insuranceTypeTableAdapter.Fill(this.insuranceCompanyDataSet.InsuranceType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Programm". При необходимости она может быть перемещена или удалена.
            this.programmTableAdapter.Fill(this.insuranceCompanyDataSet.Programm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Insurer". При необходимости она может быть перемещена или удалена.
            this.insurerTableAdapter.Fill(this.insuranceCompanyDataSet.Insurer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.insuranceCompanyDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Request". При необходимости она может быть перемещена или удалена.
            this.requestTableAdapter.Fill(this.insuranceCompanyDataSet.Request);
            this.insuranceCompanyDataSet.Request.userColumn.Expression = "Parent (FK_Request_User).FIO";
            this.insuranceCompanyDataSet.Request.clientColumn.Expression = "Parent (FK_Request_Client).firstName";
            this.insuranceCompanyDataSet.Request.insurerColumn.Expression = "Parent (FK_Request_Insurer).firstName";
            this.insuranceCompanyDataSet.Request.programmColumn.Expression = "Parent (FK_Request_Programm).name";
            this.insuranceCompanyDataSet.Request.insuranceTypeColumn.Expression = "Parent (FK_Request_InsuranceType).name";

            if (this.insuranceCompanyDataSet.InsuranceType.Rows.Count > 0)
            {
                insuranceTypeRequestCB.SelectedItem = insuranceTypeRequestCB.Items[0];
                DataRow row = this.insuranceCompanyDataSet.InsuranceType.Rows.Find(Convert.ToInt32(insuranceTypeRequestCB.SelectedValue));
                documentListRequestTB.Text = Convert.ToString(row["listDocuments"]);
            }

            for (int i = 0; i < this.requestDataGridView.Rows.Count; i++)
            {
                statusRequest(i);
            }

            if (this.insuranceCompanyDataSet.Client.Rows.Count > 0)
            {
                List<ClientCB> userCBList = new List<ClientCB>();
                for (int i = 0; i < this.insuranceCompanyDataSet.Client.Rows.Count; i++)
                    userCBList.Add(new ClientCB 
                    {
                        ID = Convert.ToInt32(this.insuranceCompanyDataSet.Client.Rows[i]["ID"]),
                        Name = Convert.ToString(this.insuranceCompanyDataSet.Client.Rows[i]["firstName"]) + " " +
                            Convert.ToString(this.insuranceCompanyDataSet.Client.Rows[i]["middleName"]) + " " +
                            Convert.ToString(this.insuranceCompanyDataSet.Client.Rows[i]["lastName"])
                    });

                clientRequestCB.DataSource = userCBList;
                clientRequestCB.DisplayMember = "Name";
                clientRequestCB.ValueMember = "ID";
            }

            if (this.insuranceCompanyDataSet.Insurer.Rows.Count > 0)
            {
                List<ClientCB> userCBList = new List<ClientCB>();
                for (int i = 0; i < this.insuranceCompanyDataSet.Insurer.Rows.Count; i++)
                    userCBList.Add(new ClientCB
                    {
                        ID = Convert.ToInt32(this.insuranceCompanyDataSet.Insurer.Rows[i]["ID"]),
                        Name = Convert.ToString(this.insuranceCompanyDataSet.Insurer.Rows[i]["firstName"]) + " " +
                            Convert.ToString(this.insuranceCompanyDataSet.Insurer.Rows[i]["middleName"]) + " " +
                            Convert.ToString(this.insuranceCompanyDataSet.Insurer.Rows[i]["lastName"])
                    });

                insurerRequestCB.DataSource = userCBList;
                insurerRequestCB.DisplayMember = "Name";
                insurerRequestCB.ValueMember = "ID";
            }

            dateRequestLabel.Text = DateTime.Now.ToString("d");
        }

        private class ClientCB
        { 
            public int ID { get; set; }

            public string Name { get; set; }
        }

        private class InsurerCB
        {
            public int ID { get; set; }

            public string Name { get; set; }
        }

        private void statusRequest(int index)
        {
            string statusRequestRow = requestDataGridView.Rows[index].Cells["status"].Value.ToString();
            if (statusRequestRow == "Ожидает")
                requestDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(255, 242, 179);
            else if (statusRequestRow == "Оплачено")
                requestDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(170, 255, 153);
            else if (statusRequestRow == "Задолжность")
                requestDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);

            if (!string.IsNullOrEmpty(requestDataGridView.Rows[index].Cells["policyNumber"].Value.ToString()) &&
                Convert.ToDecimal(requestDataGridView.Rows[index].Cells["policyCost"].Value) > 0)
            {
                DateTime dateEndPolicy = Convert.ToDateTime(requestDataGridView.Rows[index].Cells["datePolicyExpiration"].Value);
                if ((dateEndPolicy - DateTime.Now).Days < 30)
                {
                    requestDataGridView.Rows[index].Cells["ID"].Style.BackColor = Color.FromArgb(153, 238, 255);
                    requestDataGridView.Rows[index].Cells["datePolicyExpiration"].Style.BackColor = Color.FromArgb(153, 238, 255);
                }
                else
                {
                    requestDataGridView.Rows[index].Cells["ID"].Style = requestDataGridView.Rows[index].InheritedStyle;
                    requestDataGridView.Rows[index].Cells["datePolicyExpiration"].Style = requestDataGridView.Rows[index].InheritedStyle;
                }
            }
        }

        private void requstInsertBTN_Click(object sender, EventArgs e)
        {
            if (this.insuranceCompanyDataSet.Client.Rows.Count > 0)
            {
                if (this.insuranceCompanyDataSet.Insurer.Rows.Count > 0)
                {
                    if (this.insuranceCompanyDataSet.InsuranceType.Rows.Count > 0)
                    {
                        if (this.insuranceCompanyDataSet.Programm.Rows.Count > 0)
                        {
                            if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
                            {
                                DateTime dateRequest = DateTime.Now;
                                int clientID = Convert.ToInt32(clientRequestCB.SelectedValue);
                                int insurerID = Convert.ToInt32(insurerRequestCB.SelectedValue);
                                int programmID = Convert.ToInt32(programmRequestCB.SelectedValue);
                                int insuranceTypeID = Convert.ToInt32(insuranceTypeRequestCB.SelectedValue);
                                string listDocuments = documentListRequestTB.Text;
                                string policyNumber = policyNumberRequestCB.Text;
                                DateTime dateReceiptPolicy = dateStartRequestDTP.Value;
                                DateTime datePolicyExpiration = dateFinishRequestDTP.Value;
                                string specialConditions = specialConditionsRequestT.Text;
                                string conditionsInfluenceDegreeRisk = conditionsRiskRequestT.Text;
                                decimal policyCost = (string.IsNullOrEmpty(costRequestCB.Text)) ? 0 : Convert.ToDecimal(costRequestCB.Text);
                                decimal actualSum = (string.IsNullOrEmpty(sumRequestCB.Text)) ? 0 : Convert.ToDecimal(sumRequestCB.Text);
                                string paymentProcedure = paymentProcedureTB.Text;
                                int userID = this.userActive.ID;

                                string status = "Ожидает"; // newRequesRow["status"].ToString();
                                if (policyCost > 0 && policyCost > actualSum)
                                    status = "Задолжность";
                                else if (policyCost > 0 && policyCost <= actualSum)
                                    status = "Оплачено";

                                this.requestTableAdapter.Insert(dateRequest, clientID, insurerID, programmID, insuranceTypeID,
                                    listDocuments, policyNumber, dateReceiptPolicy, datePolicyExpiration, specialConditions,
                                    conditionsInfluenceDegreeRisk, policyCost, actualSum, paymentProcedure, userID, status);
                                this.requestTableAdapter.Fill(this.insuranceCompanyDataSet.Request);

                                for (int i = 0; i < this.requestDataGridView.Rows.Count; i++)
                                    statusRequest(i);

                                requestClear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("В таблице \"Программа\" нет записей. Добавьте программу.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("В таблице \"Вид страхования\" нет записей. Добавьте вид страхования.");
                    }
                }
                else
                {
                    MessageBox.Show("В таблице \"Страховщик\" нет записей. Добавьте страховщика.");
                }
            }
            else
            {
                MessageBox.Show("В таблице \"Страхователь\" нет записей. Добавьте страхователя.");
            }
        }

        private void updateRequestBTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
            {
                if (requestDataGridView.Rows.Count > 0)
                {
                    DataRow row = this.insuranceCompanyDataSet.Request.Rows.Find(Convert.ToInt32(requestDataGridView.CurrentRow.Cells[0].Value));
                    
                    row["dateRequest"] = DateTime.Now;
                    row["clientID"] = clientRequestCB.SelectedValue;
                    row["insurerID"] = insurerRequestCB.SelectedValue;
                    row["programmID"] = programmRequestCB.SelectedValue;
                    row["insuranceTypeID"] = insuranceTypeRequestCB.SelectedValue;
                    row["listDocuments"] = documentListRequestTB.Text;
                    row["policyNumber"] = policyNumberRequestCB.Text;
                    row["dateReceiptPolicy"] = dateStartRequestDTP.Value;
                    row["datePolicyExpiration"] = dateFinishRequestDTP.Value;
                    row["specialConditions"] = specialConditionsRequestT.Text;
                    row["conditionsInfluenceDegreeRisk"] = conditionsRiskRequestT.Text;
                    row["policyCost"] = (string.IsNullOrEmpty(costRequestCB.Text)) ? 0 : Convert.ToDecimal(costRequestCB.Text);
                    row["actualSum"] = (string.IsNullOrEmpty(sumRequestCB.Text)) ? 0 : Convert.ToDecimal(sumRequestCB.Text);
                    row["paymentProcedure"] = paymentProcedureTB.Text;

                    decimal cost = Convert.ToDecimal(row["policyCost"]);
                    decimal sum = Convert.ToDecimal(row["actualSum"]);

                    row["status"] = "Ожидает";
                    if (cost > 0 && cost > sum)
                        row["status"] = "Задолжность";
                    else if (cost > 0 && cost <= sum)
                        row["status"] = "Оплачено";
                    
                    this.requestTableAdapter.Update(row);
                    this.requestTableAdapter.Fill(this.insuranceCompanyDataSet.Request);

                    for (int i = 0; i < this.requestDataGridView.Rows.Count; i++)
                        statusRequest(i);

                    requestClear();
                }
            }
        }

        private void deleteRequestBTN_Click(object sender, EventArgs e)
        {
            if (requestDataGridView.Rows.Count > 0)
            {
                DataRow row = this.insuranceCompanyDataSet.Request.Rows.Find(Convert.ToInt32(requestDataGridView.CurrentRow.Cells[0].Value));
                DataRow[] rows = row.GetChildRows("FK_InsuranceCase_Request");
                if (rows.GetLength(0) == 0)
                {
                    
                    this.requestTableAdapter.Delete(Convert.ToInt32(row["ID"]), Convert.ToDateTime(row["dateRequest"]), Convert.ToInt32(row["clientID"]),
                        Convert.ToInt32(row["insurerID"]), Convert.ToInt32(row["programmID"]), Convert.ToInt32(row["insuranceTypeID"]), Convert.ToString(row["listDocuments"]),
                        Convert.ToString(row["policyNumber"]), Convert.ToDateTime(row["dateReceiptPolicy"]), Convert.ToDateTime(row["datePolicyExpiration"]),
                        Convert.ToString(row["specialConditions"]), Convert.ToString(row["conditionsInfluenceDegreeRisk"]), Convert.ToDecimal(row["policyCost"]),
                        Convert.ToDecimal(row["actualSum"]), Convert.ToString(row["paymentProcedure"]), Convert.ToInt32(row["userID"]), Convert.ToString(row["status"]));
                    this.requestTableAdapter.Fill(this.insuranceCompanyDataSet.Request);
                    
                    for (int i = 0; i < this.requestDataGridView.Rows.Count; i++)
                        statusRequest(i);
                }
                else
                {
                    MessageBox.Show("Есть дочерние строки. Строка не удалена.");
                }
            }
        }

        private void insuranceTypeRequestCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow row = this.insuranceCompanyDataSet.InsuranceType.Rows.Find(Convert.ToInt32(insuranceTypeRequestCB.SelectedValue));
            documentListRequestTB.Text = Convert.ToString(row["listDocuments"]);
        }

        private void insuranceCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow requstRow = this.insuranceCompanyDataSet.Request.Rows.Find(Convert.ToInt32(requestDataGridView.Rows[this.rowIndex].Cells["ID"].Value));

            if (requstRow["status"].ToString() == "Оплачено")
            {
                InsuranceCaseForm insuranceCaseForm = new InsuranceCaseForm(Convert.ToInt32(requstRow["ID"]), Convert.ToInt32(requstRow["programmID"]));
                insuranceCaseForm.ShowDialog();

                dataInit();
            }
            else
            {
                MessageBox.Show("Клиент не оплатил стоимость полиса в полном объеме.", "Полис не полачен", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int rowIndex = 0;
        private void requestDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    DataGridView tempDGV = (DataGridView)sender;

                   
                    if (rowIndex >= 0 && rowIndex < tempDGV.Rows.Count)
                        tempDGV.Rows[rowIndex].Selected = false;    // отменяем предыдущий выбор

                    tempDGV.Rows[e.RowIndex].Selected = true;     // выбираем текущую строку активной
                    rowIndex = e.RowIndex;
                }
                else
                {
                    requstContextMenuStrip.Hide();
                }
            }
        }

        private void requestDataGridView_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < requestDataGridView.Rows.Count; i++)
                statusRequest(i);
        }

        private void requestDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow row = this.insuranceCompanyDataSet.Request.Rows.Find(Convert.ToInt32(requestDataGridView.Rows[e.RowIndex].Cells["ID"].Value));

            clientRequestCB.SelectedValue = Convert.ToInt32(row["clientID"]);
            insurerRequestCB.SelectedValue = Convert.ToInt32(row["insurerID"]);
            programmRequestCB.SelectedValue = Convert.ToInt32(row["programmID"]);
            insuranceTypeRequestCB.SelectedValue = Convert.ToInt32(row["insuranceTypeID"]);
            documentListRequestTB.Text = row["listDocuments"].ToString();
            policyNumberRequestCB.Text = row["policyNumber"].ToString();
            dateStartRequestDTP.Value = Convert.ToDateTime(row["dateReceiptPolicy"]);
            dateFinishRequestDTP.Value = Convert.ToDateTime(row["datePolicyExpiration"]);
            specialConditionsRequestT.Text = row["specialConditions"].ToString();
            conditionsRiskRequestT.Text = row["conditionsInfluenceDegreeRisk"].ToString();
            costRequestCB.Text = row["policyCost"].ToString();
            sumRequestCB.Text = row["actualSum"].ToString();
            paymentProcedureTB.Text = row["paymentProcedure"].ToString();
        }

        private void requestClear()
        {
            clientRequestCB.SelectedIndex = 0;
            insurerRequestCB.SelectedIndex = 0;
            programmRequestCB.SelectedIndex = 0;
            insuranceTypeRequestCB.SelectedIndex = 0;
            policyNumberRequestCB.Clear();
            dateStartRequestDTP.Value = DateTime.Now;
            dateFinishRequestDTP.Value = DateTime.Now;
            specialConditionsRequestT.Clear();
            conditionsRiskRequestT.Clear();
            costRequestCB.Clear();
            sumRequestCB.Clear();
            paymentProcedureTB.Clear();
        }

        // выходные документы, отчеты
        private void ReplaceWordSub(string subToReplace, string text, Word.Document wordDoc)
        {
            var range = wordDoc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: subToReplace, ReplaceWith: text);
        }

        private void printRequestBTN_Click(object sender, EventArgs e)
        {
            if (this.insuranceCompanyDataSet.Request.Rows.Count > 0)
            {
                // получение значений
                DataRow requestRow = this.insuranceCompanyDataSet.Request.Rows.Find(Convert.ToInt32(requestDataGridView.CurrentRow.Cells[0].Value));
                string reqeustID = requestRow["ID"].ToString();
                string dateRequest = Convert.ToDateTime(requestRow["dateRequest"]).ToString("d");
                string programm = requestRow["programm"].ToString();
                string insuranceType = requestRow["insuranceType"].ToString();

                DataRow insurerRow = this.insuranceCompanyDataSet.Insurer.Rows.Find(Convert.ToInt32(requestRow["insurerID"]));
                string insurer = insurerRow["firstName"].ToString() + " " + insurerRow["middleName"].ToString() + " " + insurerRow["lastName"].ToString() + " ";

                DataRow branchRow = this.insuranceCompanyDataSet.Branch.Rows.Find(Convert.ToInt32(insurerRow["branckID"]));
                string branchINN = branchRow["INN"].ToString();
                string branchOGRN = branchRow["OGRN"].ToString();
                string branchLicence = branchRow["licence"].ToString();
                string branchAddress = branchRow["addresLegal"].ToString();
                string branchPhone = branchRow["phoneNumber"].ToString();
                string branchEmail = branchRow["email"].ToString();

                DataRow clientRow = this.insuranceCompanyDataSet.Client.Rows.Find(Convert.ToInt32(requestRow["clientID"]));
                string clientName = clientRow["firstName"].ToString() + " " + clientRow["middleName"].ToString() + " " + clientRow["lastName"].ToString();
                string clientPassport = "Серия " + clientRow["passportSeries"].ToString() + " № " + clientRow["passportNumber"].ToString() +
                    ", выдан " + clientRow["passportIssued"].ToString() + ", дата выдачи " + Convert.ToDateTime(clientRow["passportDate"]).ToString("d");
                string clientBirthday = Convert.ToDateTime(clientRow["birthday"]).ToString("d");
                string clientAddress = clientRow["address"].ToString();

                // работа с word
                var wordApp = new Word.Application();
                wordApp.Visible = false;

                if (requestRow["status"].ToString() == "Оплачено")
                {
                    string policy = requestRow["policyNumber"].ToString();
                    string dateStartPolicy = Convert.ToDateTime(requestRow["dateReceiptPolicy"]).ToString("d");
                    string dateEndPolicy = Convert.ToDateTime(requestRow["datePolicyExpiration"]).ToString("d");
                    string specialConditions = requestRow["specialConditions"].ToString();
                    string conditionsInfluenceDegreeRisk = requestRow["conditionsInfluenceDegreeRisk"].ToString();
                    string paymentProcedure = requestRow["paymentProcedure"].ToString();
                    
                    string fileNameRequest = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\АИС менеджера страховой компании\Reports\", "Request_1.docx");//АИС менеджера страховой компании
                    var wordDocTemplate = wordApp.Documents.Open(FileName: fileNameRequest, ReadOnly: false);

                    try
                    {
                        ReplaceWordSub("{branchINN}", branchINN, wordDocTemplate);
                        ReplaceWordSub("{branchOGRN}", branchOGRN, wordDocTemplate);
                        ReplaceWordSub("{branchLicence}", branchLicence, wordDocTemplate);
                        ReplaceWordSub("{branchAddress}", branchAddress , wordDocTemplate);
                        ReplaceWordSub("{branchPhone}", branchPhone, wordDocTemplate);
                        ReplaceWordSub("{branchEmail}", branchEmail, wordDocTemplate);
                        ReplaceWordSub("{clientName}", clientName, wordDocTemplate);
                        ReplaceWordSub("{clientPassport}", clientPassport, wordDocTemplate);
                        ReplaceWordSub("{clientBirthday}", clientBirthday, wordDocTemplate);
                        ReplaceWordSub("{clientAddress}", clientAddress, wordDocTemplate);
                        ReplaceWordSub("{reqeustID}", reqeustID, wordDocTemplate);
                        ReplaceWordSub("{policy}", policy, wordDocTemplate);
                        ReplaceWordSub("{insurer}", insurer, wordDocTemplate);
                        ReplaceWordSub("{programm}", programm, wordDocTemplate);
                        ReplaceWordSub("{insuranceType}", insuranceType, wordDocTemplate);
                        ReplaceWordSub("{specialConditions}", specialConditions, wordDocTemplate);
                        ReplaceWordSub("{conditionsInfluenceDegreeRisk}", conditionsInfluenceDegreeRisk, wordDocTemplate);
                        ReplaceWordSub("{paymentProcedure}", paymentProcedure, wordDocTemplate);
                        ReplaceWordSub("{dateStartPolicy}", dateStartPolicy, wordDocTemplate);
                        ReplaceWordSub("{dateEndPolicy}", dateEndPolicy, wordDocTemplate);
                        ReplaceWordSub("{date}", DateTime.Now.ToString("d"), wordDocTemplate);

                        DataRow[] listRiskRows = this.insuranceCompanyDataSet.ListRisks.Select("programmID = " + requestRow["programmID"].ToString());
                        string risks = "";
                        for (int i = 0; i < listRiskRows.GetLength(0); i++)
                        {
                            DataRow riskRow = this.insuranceCompanyDataSet.Risk.Rows.Find(Convert.ToInt32(listRiskRows[i]["riskID"]));
                            if (i + 1 < listRiskRows.GetLength(0))
                                risks = riskRow["name"].ToString() + ", {risks}";
                            else
                                risks = riskRow["name"].ToString() + ".";

                            ReplaceWordSub("{risks}", risks, wordDocTemplate);
                        }

                        string fileNameRequestResult = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\АИС менеджера страховой компании\Reports\", "Request_1Result.docx");
                        wordDocTemplate.SaveAs(fileNameRequestResult);
                        wordDocTemplate.Close();

                        var wordDocResult = wordApp.Documents.Open(FileName: fileNameRequestResult, ReadOnly: false);

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            wordDocResult.SaveAs(saveFileDialog.FileName);
                        }

                        wordDocResult.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка." + ex.Message, "Ошибка.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        wordApp.Quit();
                    }
                }
                else if (requestRow["status"].ToString() == "Задолжность")
                {
                    string policy = requestRow["policyNumber"].ToString();
                    string dateStartPolicy = Convert.ToDateTime(requestRow["dateReceiptPolicy"]).ToString("d");
                    string dateEndPolicy = Convert.ToDateTime(requestRow["datePolicyExpiration"]).ToString("d");
                    string specialConditions = requestRow["specialConditions"].ToString();
                    string conditionsInfluenceDegreeRisk = requestRow["conditionsInfluenceDegreeRisk"].ToString();
                    string paymentProcedure = requestRow["paymentProcedure"].ToString();
                    string policyCost = requestRow["policyCost"].ToString(); ;
                    string actualSum = requestRow["actualSum"].ToString(); ;
                    string dolgSum = (Convert.ToDecimal(policyCost) - Convert.ToDecimal(actualSum)).ToString();


                    string fileNameRequest = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\АИС менеджера страховой компании\Reports\", "Request_3.docx");
                    var wordDocTemplate = wordApp.Documents.Open(FileName: fileNameRequest, ReadOnly: false);

                    try
                    {
                        ReplaceWordSub("{branchINN}", branchINN, wordDocTemplate);
                        ReplaceWordSub("{branchOGRN}", branchOGRN, wordDocTemplate);
                        ReplaceWordSub("{branchLicence}", branchLicence, wordDocTemplate);
                        ReplaceWordSub("{branchAddress}", branchAddress, wordDocTemplate);
                        ReplaceWordSub("{branchPhone}", branchPhone, wordDocTemplate);
                        ReplaceWordSub("{branchEmail}", branchEmail, wordDocTemplate);
                        ReplaceWordSub("{clientName}", clientName, wordDocTemplate);
                        ReplaceWordSub("{clientPassport}", clientPassport, wordDocTemplate);
                        ReplaceWordSub("{clientBirthday}", clientBirthday, wordDocTemplate);
                        ReplaceWordSub("{clientAddress}", clientAddress, wordDocTemplate);
                        ReplaceWordSub("{reqeustID}", reqeustID, wordDocTemplate);
                        ReplaceWordSub("{policy}", policy, wordDocTemplate);
                        ReplaceWordSub("{insurer}", insurer, wordDocTemplate);
                        ReplaceWordSub("{programm}", programm, wordDocTemplate);
                        ReplaceWordSub("{insuranceType}", insuranceType, wordDocTemplate);
                        ReplaceWordSub("{specialConditions}", specialConditions, wordDocTemplate);
                        ReplaceWordSub("{conditionsInfluenceDegreeRisk}", conditionsInfluenceDegreeRisk, wordDocTemplate);
                        ReplaceWordSub("{paymentProcedure}", paymentProcedure, wordDocTemplate);
                        ReplaceWordSub("{dateStartPolicy}", dateStartPolicy, wordDocTemplate);
                        ReplaceWordSub("{dateEndPolicy}", dateEndPolicy, wordDocTemplate);

                        ReplaceWordSub("{policyCost}", policyCost, wordDocTemplate);
                        ReplaceWordSub("{actualSum}", actualSum, wordDocTemplate);
                        ReplaceWordSub("{dolgSum}", dolgSum, wordDocTemplate);

                        ReplaceWordSub("{date}", DateTime.Now.ToString("d"), wordDocTemplate);

                        DataRow[] listRiskRows = this.insuranceCompanyDataSet.ListRisks.Select("programmID = " + requestRow["programmID"].ToString());
                        string risks = "";
                        for (int i = 0; i < listRiskRows.GetLength(0); i++)
                        {
                            DataRow riskRow = this.insuranceCompanyDataSet.Risk.Rows.Find(Convert.ToInt32(listRiskRows[i]["riskID"]));
                            if (i + 1 < listRiskRows.GetLength(0))
                                risks = riskRow["name"].ToString() + ", {risks}";
                            else
                                risks = riskRow["name"].ToString() + ".";

                            ReplaceWordSub("{risks}", risks, wordDocTemplate);
                        }

                        string fileNameRequestResult = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\АИС менеджера страховой компании\Reports\", "Request_3Result.docx");
                        wordDocTemplate.SaveAs(fileNameRequestResult);
                        wordDocTemplate.Close();

                        var wordDocResult = wordApp.Documents.Open(FileName: fileNameRequestResult, ReadOnly: false);

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            wordDocResult.SaveAs(saveFileDialog.FileName);
                        }

                        wordDocResult.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка." + ex.Message, "Ошибка.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        wordApp.Quit();
                    }
                }
                else
                {
                    DataRow userRow = this.insuranceCompanyDataSet.User.Rows.Find(Convert.ToInt32(requestRow["userID"]));
                    string user = userRow["FIO"].ToString();
                    string listDocuments = requestRow["listDocuments"].ToString();

                    string fileNameRequest_2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\АИС менеджера страховой компании\Reports\", "Request_2.docx");
                    var wordDocTemplate = wordApp.Documents.Open(FileName: fileNameRequest_2, ReadOnly: false);
                    
                    try
                    {
                        ReplaceWordSub("{branchINN}", branchINN, wordDocTemplate);
                        ReplaceWordSub("{branchOGRN}", branchOGRN, wordDocTemplate);
                        ReplaceWordSub("{branchLicence}", branchLicence, wordDocTemplate);
                        ReplaceWordSub("{branchAddress}", branchAddress, wordDocTemplate);
                        ReplaceWordSub("{branchPhone}", branchPhone, wordDocTemplate);
                        ReplaceWordSub("{branchEmail}", branchEmail, wordDocTemplate);
                        ReplaceWordSub("{clientName}", clientName, wordDocTemplate);
                        ReplaceWordSub("{clientPassport}", clientPassport, wordDocTemplate);
                        ReplaceWordSub("{clientBirthday}", clientBirthday, wordDocTemplate);
                        ReplaceWordSub("{clientAddress}", clientAddress, wordDocTemplate);
                        ReplaceWordSub("{reqeustID}", reqeustID, wordDocTemplate);
                        ReplaceWordSub("{user}", user, wordDocTemplate);
                        ReplaceWordSub("{insurer}", insurer, wordDocTemplate);
                        ReplaceWordSub("{programm}", programm, wordDocTemplate);
                        ReplaceWordSub("{insuranceType}", insuranceType, wordDocTemplate);
                        ReplaceWordSub("{listDocuments}", listDocuments, wordDocTemplate);
                        ReplaceWordSub("{date}", DateTime.Now.ToString("d"), wordDocTemplate);

                        DataRow[] listRiskRows = this.insuranceCompanyDataSet.ListRisks.Select("programmID = " + requestRow["programmID"].ToString());
                        string risks = "";
                        for (int i = 0; i < listRiskRows.GetLength(0); i++)
                        {
                            DataRow riskRow = this.insuranceCompanyDataSet.Risk.Rows.Find(Convert.ToInt32(listRiskRows[i]["riskID"]));
                            if (i + 1 < listRiskRows.GetLength(0))
                                risks = riskRow["name"].ToString() + ", {risks}";
                            else
                                risks = riskRow["name"].ToString() + ".";

                            ReplaceWordSub("{risks}", risks, wordDocTemplate);
                        }

                        string fileNameRequest_2Result = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\АИС менеджера страховой компании\Reports\", "Reqeust_2Result.docx");
                        wordDocTemplate.SaveAs(fileNameRequest_2Result);
                        wordDocTemplate.Close();

                        var wordDocResult = wordApp.Documents.Open(FileName: fileNameRequest_2Result, ReadOnly: false);

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            wordDocResult.SaveAs(saveFileDialog.FileName);
                        }

                        wordDocResult.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка. " + ex.Message, "Ошибка.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        wordApp.Quit();
                    }
                }
            }
        }
         
        private void должникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            string fileNameDebt = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\АИС менеджера страховой компании\Reports\", "Debt.docx");
            var wordDocTemplate = wordApp.Documents.Open(fileNameDebt, ReadOnly: false);

            try
            {
                string date = DateTime.Now.ToString("d");

                ReplaceWordSub("{date}", date.ToString(), wordDocTemplate);
                
                DataRow[] depts = this.insuranceCompanyDataSet.Request.Select("policyCost > actualSum");
                Word.Table table = wordDocTemplate.Tables[1];
                if (depts.GetLength(0) > 0)
                {
                    for (int i = 0; i < depts.GetLength(0); i++)
                    {
                        Word.Row row = table.Rows.Add();

                        row.Cells[1].Range.Text = depts[i]["ID"].ToString();

                        DataRow userRow = this.insuranceCompanyDataSet.User.Rows.Find(Convert.ToInt32(depts[i]["userID"]));
                        row.Cells[2].Range.Text = userRow["FIO"].ToString();

                        DataRow insurerRow = this.insuranceCompanyDataSet.Insurer.Rows.Find(Convert.ToInt32(depts[i]["insurerID"]));
                        row.Cells[3].Range.Text = insurerRow["firstName"].ToString() + " " + insurerRow["middleName"].ToString() + " " + insurerRow["lastName"].ToString();

                        DataRow clientRow = this.insuranceCompanyDataSet.Client.Rows.Find(Convert.ToInt32(depts[i]["clientID"]));
                        row.Cells[4].Range.Text = clientRow["firstName"].ToString() + " " + clientRow["middleName"].ToString() + " " + clientRow["lastName"].ToString();
                        row.Cells[5].Range.Text = clientRow["phoneNumber"].ToString();

                        row.Cells[6].Range.Text = depts[i]["policyNumber"].ToString();
                        row.Cells[7].Range.Text = depts[i]["policyCost"].ToString();
                        row.Cells[8].Range.Text = depts[i]["actualSum"].ToString();
                        row.Cells[9].Range.Text = (Convert.ToDecimal(depts[i]["policyCost"]) - Convert.ToDecimal(depts[i]["actualSum"])).ToString();
                    }
                }

                string fileNameDebtResult = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\АИС менеджера страховой компании\Reports\", "DebtResult.docx");
                wordDocTemplate.SaveAs(fileNameDebtResult);
                wordDocTemplate.Close();

                var wordDocResult = wordApp.Documents.Open(fileNameDebtResult, ReadOnly: false);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wordDocResult.SaveAs(saveFileDialog.FileName);
                }

                wordDocResult.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка. " + ex.Message, "Ошибка.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                wordApp.Quit();
            }
        }

        private void окончаниеСрокаДействияПолисаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            string fileNamePolicyEnd = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\АИС менеджера страховой компании\Reports\", "PolicyEnd.docx");
            var wordDocTemplate = wordApp.Documents.Open(fileNamePolicyEnd, ReadOnly: false);

            try
            {
                string date = DateTime.Now.ToString("d");

                ReplaceWordSub("{date}", date.ToString(), wordDocTemplate);

                List<DataRow> policyEndRow = new List<DataRow>();
                for (int i = 0; i < this.insuranceCompanyDataSet.Request.Rows.Count; i++)
                {
                    DataRow r = this.insuranceCompanyDataSet.Request.Rows[i];
                    if (!string.IsNullOrEmpty(r["policyNumber"].ToString()) && 
                        (Convert.ToDateTime(r["datePolicyExpiration"]) - DateTime.Now).Days < 30)
                    {
                        policyEndRow.Add(r);
                    }
                }

                Word.Table table = wordDocTemplate.Tables[1];
                if (policyEndRow.Count > 0)
                {
                    for (int i = 0; i < policyEndRow.Count; i++)
                    {
                        Word.Row row = table.Rows.Add();

                        row.Cells[1].Range.Text = policyEndRow[i]["ID"].ToString();
                        
                        DataRow insurerRow = this.insuranceCompanyDataSet.Insurer.Rows.Find(Convert.ToInt32(policyEndRow[i]["insurerID"]));
                        row.Cells[2].Range.Text = insurerRow["firstName"].ToString() + " " + insurerRow["middleName"].ToString() + " " + insurerRow["lastName"].ToString();

                        DataRow clientRow = this.insuranceCompanyDataSet.Client.Rows.Find(Convert.ToInt32(policyEndRow[i]["clientID"]));
                        row.Cells[3].Range.Text = clientRow["firstName"].ToString() + " " + clientRow["middleName"].ToString() + " " + clientRow["lastName"].ToString();
                        row.Cells[4].Range.Text = clientRow["phoneNumber"].ToString();

                        row.Cells[5].Range.Text = policyEndRow[i]["policyNumber"].ToString();
                        row.Cells[6].Range.Text = Convert.ToDateTime(policyEndRow[i]["dateReceiptPolicy"]).ToString("d");
                        row.Cells[7].Range.Text = Convert.ToDateTime(policyEndRow[i]["datePolicyExpiration"]).ToString("d");
                        row.Cells[8].Range.Text = ((Convert.ToDateTime(policyEndRow[i]["datePolicyExpiration"]) - DateTime.Now).Days + 1).ToString();
                    }
                }

                string fileNamePolicyEndResult = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\АИС менеджера страховой компании\Reports\", "PolicyEndResult.docx");
                wordDocTemplate.SaveAs(fileNamePolicyEndResult);
                wordDocTemplate.Close();

                var wordDocResult = wordApp.Documents.Open(fileNamePolicyEndResult, ReadOnly: false);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wordDocResult.SaveAs(saveFileDialog.FileName);
                }

                wordDocResult.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка. " + ex.Message, "Ошибка.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                wordApp.Quit();
            }
        }

        // валидация
        private void policyNumberRequestCB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, requestErrorProvider, StringValidation.StringNumber, 16, 16, true);
        }

        private void decimalRequestCB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, requestErrorProvider, StringValidation.StringMoney, 0, int.MaxValue, true);
        }

        private void string500RequestTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, requestErrorProvider, StringValidation.StringStandard, 0, 500, true);
        }
    }
}
