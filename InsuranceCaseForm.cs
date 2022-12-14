using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Страховая_компания__2021_
{
    public partial class InsuranceCaseForm : Form
    {
        private int requestNumber;
        private int programmID;

        public InsuranceCaseForm(int requestNumber, int pid)
        {
            this.requestNumber = requestNumber;
            this.programmID = pid;

            InitializeComponent();
        }

        private void InsuranceCaseForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.ListRisks". При необходимости она может быть перемещена или удалена.
            this.listRisksTableAdapter.Fill(this.insuranceCompanyDataSet.ListRisks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.Risk". При необходимости она может быть перемещена или удалена.
            this.riskTableAdapter.Fill(this.insuranceCompanyDataSet.Risk);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "insuranceCompanyDataSet.InsuranceCase". При необходимости она может быть перемещена или удалена.
            this.insuranceCaseTableAdapter.Fill(this.insuranceCompanyDataSet.InsuranceCase);
            this.insuranceCompanyDataSet.InsuranceCase.riskColumn.Expression = "Parent (FK_InsuranceCase_Risk).name";
            /*(this.insuranceCaseDVG.DataSource as DataTable).DefaultView.RowFilter = "requestID = " + this.requestNumber;*/
            DataView dv = new DataView(this.insuranceCompanyDataSet.InsuranceCase, "requestID = " + requestNumber, "", DataViewRowState.CurrentRows);
            this.insuranceCaseDVG.DataSource = dv;
            reqeustID_TB.Text = this.requestNumber.ToString();

            DataRow[] rowsRisk = this.insuranceCompanyDataSet.ListRisks.Select("programmID = " + this.programmID);

            List<Risk> listRisk = new List<Risk>();
            for (int i = 0; i < rowsRisk.Count(); i++)
            {
                DataRow riskRow = this.insuranceCompanyDataSet.Risk.Rows.Find(Convert.ToInt32(rowsRisk[i]["riskID"]));
                listRisk.Add(new Risk { ID = Convert.ToInt32(riskRow["ID"]), Name = riskRow["Name"].ToString() });
            }

            riskID_CB.DataSource = listRisk;
            riskID_CB.DisplayMember = "Name";
            riskID_CB.ValueMember = "ID";
        }

        class Risk 
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        private void insertInsuranceCaseBTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
            {
                decimal sum = Convert.ToDecimal(sumTB.Text);
                DateTime date = dateInsuranceCaseDTP.Value;
                int requestID = Convert.ToInt32(reqeustID_TB.Text);
                int riskID = Convert.ToInt32(riskID_CB.SelectedValue);
                DateTime datePayment = datePaymentDTP.Value;
                string remarks = remarksTB.Text;

                this.insuranceCaseTableAdapter.Insert(sum, date, requestID, riskID, datePayment, remarks);
                this.insuranceCaseTableAdapter.Fill(this.insuranceCompanyDataSet.InsuranceCase);

                dateInsuranceCaseDTP.Value = DateTime.Now;
                datePaymentDTP.Value = DateTime.Now;
                riskID_CB.SelectedIndex = 0;
                sumTB.Clear();
                remarksTB.Clear();
            }
        }

        private void deleteInsuranceCaseBTN_Click(object sender, EventArgs e)
        {
            if (insuranceCaseDVG.Rows.Count > 0)
            {
                DataRow row = this.insuranceCompanyDataSet.InsuranceCase.Rows.Find(Convert.ToInt32(insuranceCaseDVG.CurrentRow.Cells[0].Value));

                this.insuranceCaseTableAdapter.Delete(Convert.ToInt32(row["ID"]), Convert.ToDecimal(row["sum"]), 
                    Convert.ToDateTime(row["date"]), Convert.ToInt32(row["requestID"]), Convert.ToInt32(row["riskID"]), 
                    Convert.ToDateTime(row["datePayout"]), Convert.ToString(row["remarks"]));
                this.insuranceCaseTableAdapter.Fill(this.insuranceCompanyDataSet.InsuranceCase);
            }
        }

        private void updateInsuranceCaseBTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
            {
                if (insuranceCaseDVG.Rows.Count > 0)
                {
                    DataRow row = this.insuranceCompanyDataSet.InsuranceCase.Rows.Find(Convert.ToInt32(insuranceCaseDVG.CurrentRow.Cells[0].Value));

                    row["sum"] = sumTB.Text;
                    row["date"] = dateInsuranceCaseDTP.Value;
                    row["requestID"] = reqeustID_TB.Text;
                    row["riskID"] = riskID_CB.SelectedValue;
                    row["datePayout"] = datePaymentDTP.Value;
                    row["remarks"] = remarksTB.Text;

                    this.insuranceCaseTableAdapter.Update(row);
                    this.insuranceCaseTableAdapter.Fill(this.insuranceCompanyDataSet.InsuranceCase);

                    dateInsuranceCaseDTP.Value = DateTime.Now;
                    datePaymentDTP.Value = DateTime.Now;
                    riskID_CB.SelectedIndex = 0;
                    sumTB.Clear();
                    remarksTB.Clear();
                }
            }
        }

        private void decimalTB_Validating(object sender, CancelEventArgs e)
        {
            decimal sum = 0;

            if (string.IsNullOrEmpty(sumTB.Text))
            {
                e.Cancel = true;
                sumTB.Focus();
                insuranceCaseErrorProvider.SetError(sumTB, "Строка не может быть пустой");
            }
            else if (!decimal.TryParse(sumTB.Text, out sum))
            {
                e.Cancel = true;
                sumTB.Focus();
                insuranceCaseErrorProvider.SetError(sumTB, "Неверный формат числа");
            }
            else
            {
                e.Cancel = false;
                insuranceCaseErrorProvider.SetError(sumTB, null);
            }
        }

        private void string500TB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, insuranceCaseErrorProvider, StringValidation.StringStandard, 0, 500, true);
        }

        private void sumTB_Validating(object sender, CancelEventArgs e)
        {
            StringValidation.ContaierFunction(sender, e, insuranceCaseErrorProvider, StringValidation.StringMoney, 0, int.MaxValue, false);
        }

        private void insuranceCaseDVG_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow row = this.insuranceCompanyDataSet.InsuranceCase.Rows.Find(Convert.ToInt32(this.insuranceCaseDVG.Rows[e.RowIndex].Cells[0].Value));
            dateInsuranceCaseDTP.Value = Convert.ToDateTime(row["date"]);
            datePaymentDTP.Value = Convert.ToDateTime(row["datePayout"]);
            riskID_CB.SelectedValue = Convert.ToInt32(row["riskID"]);
            sumTB.Text = row["sum"].ToString();
            remarksTB.Text = row["remarks"].ToString();
        }
    }
}