
namespace Страховая_компания__2021_
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окончаниеСрокаДействияПолисаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listRequestGB = new System.Windows.Forms.GroupBox();
            this.requestDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuranceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuranceTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listDocumentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReceiptPolicyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePolicyExpiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialConditionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionsInfluenceDegreeRiskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentProcedureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requstContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insuranceCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insuranceCompanyDataSet = new Страховая_компания__2021_.InsuranceCompanyDataSet();
            this.updateRequestBTN = new System.Windows.Forms.Button();
            this.deleteRequestBTN = new System.Windows.Forms.Button();
            this.registrationRequestGB = new System.Windows.Forms.GroupBox();
            this.printRequestBTN = new System.Windows.Forms.Button();
            this.insuranceTypeRequestCB = new System.Windows.Forms.ComboBox();
            this.insuranceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sumRequestCB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.costRequestCB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateFinishRequestDTP = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.requstInsertBTN = new System.Windows.Forms.Button();
            this.paymentProcedureTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateStartRequestDTP = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.policyNumberRequestCB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.conditionsRiskRequestT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.specialConditionsRequestT = new System.Windows.Forms.TextBox();
            this.documentListRequestTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.programmRequestCB = new System.Windows.Forms.ComboBox();
            this.programmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.Ghj = new System.Windows.Forms.Label();
            this.insurerRequestCB = new System.Windows.Forms.ComboBox();
            this.insurerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientRequestCB = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateRequestLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.requestTableAdapter = new Страховая_компания__2021_.InsuranceCompanyDataSetTableAdapters.RequestTableAdapter();
            this.clientTableAdapter = new Страховая_компания__2021_.InsuranceCompanyDataSetTableAdapters.ClientTableAdapter();
            this.insurerTableAdapter = new Страховая_компания__2021_.InsuranceCompanyDataSetTableAdapters.InsurerTableAdapter();
            this.programmTableAdapter = new Страховая_компания__2021_.InsuranceCompanyDataSetTableAdapters.ProgrammTableAdapter();
            this.insuranceTypeTableAdapter = new Страховая_компания__2021_.InsuranceCompanyDataSetTableAdapters.InsuranceTypeTableAdapter();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Страховая_компания__2021_.InsuranceCompanyDataSetTableAdapters.UserTableAdapter();
            this.requestErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.insuranceCaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insuranceCaseTableAdapter = new Страховая_компания__2021_.InsuranceCompanyDataSetTableAdapters.InsuranceCaseTableAdapter();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchTableAdapter = new Страховая_компания__2021_.InsuranceCompanyDataSetTableAdapters.BranchTableAdapter();
            this.listRisksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listRisksTableAdapter = new Страховая_компания__2021_.InsuranceCompanyDataSetTableAdapters.ListRisksTableAdapter();
            this.riskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.riskTableAdapter = new Страховая_компания__2021_.InsuranceCompanyDataSetTableAdapters.RiskTableAdapter();
            this.mainFormMenuStrip.SuspendLayout();
            this.listRequestGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGridView)).BeginInit();
            this.requstContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCompanyDataSet)).BeginInit();
            this.registrationRequestGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRisksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(1210, 24);
            this.mainFormMenuStrip.TabIndex = 0;
            this.mainFormMenuStrip.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            this.справочникиToolStripMenuItem.Click += new System.EventHandler(this.справочникиToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.должникиToolStripMenuItem,
            this.окончаниеСрокаДействияПолисаToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // должникиToolStripMenuItem
            // 
            this.должникиToolStripMenuItem.Name = "должникиToolStripMenuItem";
            this.должникиToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.должникиToolStripMenuItem.Text = "Должники";
            this.должникиToolStripMenuItem.Click += new System.EventHandler(this.должникиToolStripMenuItem_Click);
            // 
            // окончаниеСрокаДействияПолисаToolStripMenuItem
            // 
            this.окончаниеСрокаДействияПолисаToolStripMenuItem.Name = "окончаниеСрокаДействияПолисаToolStripMenuItem";
            this.окончаниеСрокаДействияПолисаToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.окончаниеСрокаДействияПолисаToolStripMenuItem.Text = "Окончание срока действия полиса";
            this.окончаниеСрокаДействияПолисаToolStripMenuItem.Click += new System.EventHandler(this.окончаниеСрокаДействияПолисаToolStripMenuItem_Click);
            // 
            // listRequestGB
            // 
            this.listRequestGB.Controls.Add(this.requestDataGridView);
            this.listRequestGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.listRequestGB.Location = new System.Drawing.Point(0, 24);
            this.listRequestGB.Name = "listRequestGB";
            this.listRequestGB.Size = new System.Drawing.Size(1210, 317);
            this.listRequestGB.TabIndex = 1;
            this.listRequestGB.TabStop = false;
            this.listRequestGB.Text = "Список заявок";
            // 
            // requestDataGridView
            // 
            this.requestDataGridView.AllowUserToAddRows = false;
            this.requestDataGridView.AllowUserToDeleteRows = false;
            this.requestDataGridView.AutoGenerateColumns = false;
            this.requestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.user,
            this.client,
            this.insurer,
            this.programm,
            this.insuranceType,
            this.dateRequestDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.insurerIDDataGridViewTextBoxColumn,
            this.programmID,
            this.insuranceTypeIDDataGridViewTextBoxColumn,
            this.listDocumentsDataGridViewTextBoxColumn,
            this.policyNumber,
            this.dateReceiptPolicyDataGridViewTextBoxColumn,
            this.datePolicyExpiration,
            this.specialConditionsDataGridViewTextBoxColumn,
            this.conditionsInfluenceDegreeRiskDataGridViewTextBoxColumn,
            this.policyCost,
            this.actualSumDataGridViewTextBoxColumn,
            this.paymentProcedureDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.status});
            this.requestDataGridView.ContextMenuStrip = this.requstContextMenuStrip;
            this.requestDataGridView.DataSource = this.requestBindingSource;
            this.requestDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestDataGridView.Location = new System.Drawing.Point(3, 16);
            this.requestDataGridView.Name = "requestDataGridView";
            this.requestDataGridView.ReadOnly = true;
            this.requestDataGridView.Size = new System.Drawing.Size(1204, 295);
            this.requestDataGridView.TabIndex = 0;
            this.requestDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.requestDataGridView_CellMouseDoubleClick);
            this.requestDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.requestDataGridView_CellMouseUp);
            this.requestDataGridView.Sorted += new System.EventHandler(this.requestDataGridView_Sorted);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "№ заявки";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 76;
            // 
            // user
            // 
            this.user.DataPropertyName = "user";
            this.user.HeaderText = "Менеджер";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // client
            // 
            this.client.DataPropertyName = "client";
            this.client.HeaderText = "Клиент";
            this.client.Name = "client";
            this.client.ReadOnly = true;
            // 
            // insurer
            // 
            this.insurer.DataPropertyName = "insurer";
            this.insurer.HeaderText = "Страховщик";
            this.insurer.Name = "insurer";
            this.insurer.ReadOnly = true;
            // 
            // programm
            // 
            this.programm.DataPropertyName = "programm";
            this.programm.HeaderText = "Программа";
            this.programm.Name = "programm";
            this.programm.ReadOnly = true;
            // 
            // insuranceType
            // 
            this.insuranceType.DataPropertyName = "insuranceType";
            this.insuranceType.HeaderText = "Вид страхования";
            this.insuranceType.Name = "insuranceType";
            this.insuranceType.ReadOnly = true;
            // 
            // dateRequestDataGridViewTextBoxColumn
            // 
            this.dateRequestDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateRequestDataGridViewTextBoxColumn.DataPropertyName = "dateRequest";
            this.dateRequestDataGridViewTextBoxColumn.HeaderText = "Дата подачи";
            this.dateRequestDataGridViewTextBoxColumn.Name = "dateRequestDataGridViewTextBoxColumn";
            this.dateRequestDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateRequestDataGridViewTextBoxColumn.Width = 88;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "clientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "clientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // insurerIDDataGridViewTextBoxColumn
            // 
            this.insurerIDDataGridViewTextBoxColumn.DataPropertyName = "insurerID";
            this.insurerIDDataGridViewTextBoxColumn.HeaderText = "insurerID";
            this.insurerIDDataGridViewTextBoxColumn.Name = "insurerIDDataGridViewTextBoxColumn";
            this.insurerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.insurerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // programmID
            // 
            this.programmID.DataPropertyName = "programmID";
            this.programmID.HeaderText = "programmID";
            this.programmID.Name = "programmID";
            this.programmID.ReadOnly = true;
            this.programmID.Visible = false;
            // 
            // insuranceTypeIDDataGridViewTextBoxColumn
            // 
            this.insuranceTypeIDDataGridViewTextBoxColumn.DataPropertyName = "insuranceTypeID";
            this.insuranceTypeIDDataGridViewTextBoxColumn.HeaderText = "insuranceTypeID";
            this.insuranceTypeIDDataGridViewTextBoxColumn.Name = "insuranceTypeIDDataGridViewTextBoxColumn";
            this.insuranceTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.insuranceTypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // listDocumentsDataGridViewTextBoxColumn
            // 
            this.listDocumentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.listDocumentsDataGridViewTextBoxColumn.DataPropertyName = "listDocuments";
            this.listDocumentsDataGridViewTextBoxColumn.HeaderText = "Список документов";
            this.listDocumentsDataGridViewTextBoxColumn.Name = "listDocumentsDataGridViewTextBoxColumn";
            this.listDocumentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.listDocumentsDataGridViewTextBoxColumn.Width = 121;
            // 
            // policyNumber
            // 
            this.policyNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.policyNumber.DataPropertyName = "policyNumber";
            this.policyNumber.HeaderText = "Полис";
            this.policyNumber.Name = "policyNumber";
            this.policyNumber.ReadOnly = true;
            this.policyNumber.Width = 64;
            // 
            // dateReceiptPolicyDataGridViewTextBoxColumn
            // 
            this.dateReceiptPolicyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateReceiptPolicyDataGridViewTextBoxColumn.DataPropertyName = "dateReceiptPolicy";
            this.dateReceiptPolicyDataGridViewTextBoxColumn.HeaderText = "Дата начала полиса";
            this.dateReceiptPolicyDataGridViewTextBoxColumn.Name = "dateReceiptPolicyDataGridViewTextBoxColumn";
            this.dateReceiptPolicyDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateReceiptPolicyDataGridViewTextBoxColumn.Width = 123;
            // 
            // datePolicyExpiration
            // 
            this.datePolicyExpiration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datePolicyExpiration.DataPropertyName = "datePolicyExpiration";
            this.datePolicyExpiration.HeaderText = "Дата окончания полиса";
            this.datePolicyExpiration.Name = "datePolicyExpiration";
            this.datePolicyExpiration.ReadOnly = true;
            this.datePolicyExpiration.Width = 140;
            // 
            // specialConditionsDataGridViewTextBoxColumn
            // 
            this.specialConditionsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.specialConditionsDataGridViewTextBoxColumn.DataPropertyName = "specialConditions";
            this.specialConditionsDataGridViewTextBoxColumn.HeaderText = "Особые условия";
            this.specialConditionsDataGridViewTextBoxColumn.Name = "specialConditionsDataGridViewTextBoxColumn";
            this.specialConditionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.specialConditionsDataGridViewTextBoxColumn.Width = 106;
            // 
            // conditionsInfluenceDegreeRiskDataGridViewTextBoxColumn
            // 
            this.conditionsInfluenceDegreeRiskDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.conditionsInfluenceDegreeRiskDataGridViewTextBoxColumn.DataPropertyName = "conditionsInfluenceDegreeRisk";
            this.conditionsInfluenceDegreeRiskDataGridViewTextBoxColumn.HeaderText = "Усл влияющ на степень риска";
            this.conditionsInfluenceDegreeRiskDataGridViewTextBoxColumn.Name = "conditionsInfluenceDegreeRiskDataGridViewTextBoxColumn";
            this.conditionsInfluenceDegreeRiskDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionsInfluenceDegreeRiskDataGridViewTextBoxColumn.Width = 144;
            // 
            // policyCost
            // 
            this.policyCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.policyCost.DataPropertyName = "policyCost";
            this.policyCost.HeaderText = "Стоимоть полиса";
            this.policyCost.Name = "policyCost";
            this.policyCost.ReadOnly = true;
            this.policyCost.Width = 110;
            // 
            // actualSumDataGridViewTextBoxColumn
            // 
            this.actualSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.actualSumDataGridViewTextBoxColumn.DataPropertyName = "actualSum";
            this.actualSumDataGridViewTextBoxColumn.HeaderText = "Фактическая сумма оплаты";
            this.actualSumDataGridViewTextBoxColumn.Name = "actualSumDataGridViewTextBoxColumn";
            this.actualSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.actualSumDataGridViewTextBoxColumn.Width = 128;
            // 
            // paymentProcedureDataGridViewTextBoxColumn
            // 
            this.paymentProcedureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paymentProcedureDataGridViewTextBoxColumn.DataPropertyName = "paymentProcedure";
            this.paymentProcedureDataGridViewTextBoxColumn.HeaderText = "Порядок выплаты";
            this.paymentProcedureDataGridViewTextBoxColumn.Name = "paymentProcedureDataGridViewTextBoxColumn";
            this.paymentProcedureDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentProcedureDataGridViewTextBoxColumn.Width = 114;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // requstContextMenuStrip
            // 
            this.requstContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insuranceCaseToolStripMenuItem});
            this.requstContextMenuStrip.Name = "requstContextMenuStrip";
            this.requstContextMenuStrip.Size = new System.Drawing.Size(177, 26);
            // 
            // insuranceCaseToolStripMenuItem
            // 
            this.insuranceCaseToolStripMenuItem.Name = "insuranceCaseToolStripMenuItem";
            this.insuranceCaseToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.insuranceCaseToolStripMenuItem.Text = "Страховые случаи";
            this.insuranceCaseToolStripMenuItem.Click += new System.EventHandler(this.insuranceCaseToolStripMenuItem_Click);
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataMember = "Request";
            this.requestBindingSource.DataSource = this.insuranceCompanyDataSet;
            // 
            // insuranceCompanyDataSet
            // 
            this.insuranceCompanyDataSet.DataSetName = "InsuranceCompanyDataSet";
            this.insuranceCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updateRequestBTN
            // 
            this.updateRequestBTN.Location = new System.Drawing.Point(304, 283);
            this.updateRequestBTN.Name = "updateRequestBTN";
            this.updateRequestBTN.Size = new System.Drawing.Size(267, 49);
            this.updateRequestBTN.TabIndex = 3;
            this.updateRequestBTN.Text = "Редактировать";
            this.updateRequestBTN.UseVisualStyleBackColor = true;
            this.updateRequestBTN.Click += new System.EventHandler(this.updateRequestBTN_Click);
            // 
            // deleteRequestBTN
            // 
            this.deleteRequestBTN.Location = new System.Drawing.Point(610, 283);
            this.deleteRequestBTN.Name = "deleteRequestBTN";
            this.deleteRequestBTN.Size = new System.Drawing.Size(267, 49);
            this.deleteRequestBTN.TabIndex = 2;
            this.deleteRequestBTN.Text = "Удалить";
            this.deleteRequestBTN.UseVisualStyleBackColor = true;
            this.deleteRequestBTN.Click += new System.EventHandler(this.deleteRequestBTN_Click);
            // 
            // registrationRequestGB
            // 
            this.registrationRequestGB.Controls.Add(this.printRequestBTN);
            this.registrationRequestGB.Controls.Add(this.updateRequestBTN);
            this.registrationRequestGB.Controls.Add(this.insuranceTypeRequestCB);
            this.registrationRequestGB.Controls.Add(this.deleteRequestBTN);
            this.registrationRequestGB.Controls.Add(this.sumRequestCB);
            this.registrationRequestGB.Controls.Add(this.label14);
            this.registrationRequestGB.Controls.Add(this.costRequestCB);
            this.registrationRequestGB.Controls.Add(this.label13);
            this.registrationRequestGB.Controls.Add(this.dateFinishRequestDTP);
            this.registrationRequestGB.Controls.Add(this.label12);
            this.registrationRequestGB.Controls.Add(this.requstInsertBTN);
            this.registrationRequestGB.Controls.Add(this.paymentProcedureTB);
            this.registrationRequestGB.Controls.Add(this.label11);
            this.registrationRequestGB.Controls.Add(this.dateStartRequestDTP);
            this.registrationRequestGB.Controls.Add(this.label10);
            this.registrationRequestGB.Controls.Add(this.policyNumberRequestCB);
            this.registrationRequestGB.Controls.Add(this.label7);
            this.registrationRequestGB.Controls.Add(this.conditionsRiskRequestT);
            this.registrationRequestGB.Controls.Add(this.label9);
            this.registrationRequestGB.Controls.Add(this.specialConditionsRequestT);
            this.registrationRequestGB.Controls.Add(this.documentListRequestTB);
            this.registrationRequestGB.Controls.Add(this.label6);
            this.registrationRequestGB.Controls.Add(this.label8);
            this.registrationRequestGB.Controls.Add(this.programmRequestCB);
            this.registrationRequestGB.Controls.Add(this.label5);
            this.registrationRequestGB.Controls.Add(this.Ghj);
            this.registrationRequestGB.Controls.Add(this.insurerRequestCB);
            this.registrationRequestGB.Controls.Add(this.clientRequestCB);
            this.registrationRequestGB.Controls.Add(this.dateRequestLabel);
            this.registrationRequestGB.Controls.Add(this.label4);
            this.registrationRequestGB.Controls.Add(this.label3);
            this.registrationRequestGB.Controls.Add(this.label2);
            this.registrationRequestGB.Controls.Add(this.label1);
            this.registrationRequestGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationRequestGB.Location = new System.Drawing.Point(0, 341);
            this.registrationRequestGB.Name = "registrationRequestGB";
            this.registrationRequestGB.Size = new System.Drawing.Size(1210, 338);
            this.registrationRequestGB.TabIndex = 2;
            this.registrationRequestGB.TabStop = false;
            this.registrationRequestGB.Text = "Оформление заявки";
            // 
            // printRequestBTN
            // 
            this.printRequestBTN.Location = new System.Drawing.Point(917, 283);
            this.printRequestBTN.Name = "printRequestBTN";
            this.printRequestBTN.Size = new System.Drawing.Size(267, 49);
            this.printRequestBTN.TabIndex = 31;
            this.printRequestBTN.Text = "Распечатать";
            this.printRequestBTN.UseVisualStyleBackColor = true;
            this.printRequestBTN.Click += new System.EventHandler(this.printRequestBTN_Click);
            // 
            // insuranceTypeRequestCB
            // 
            this.insuranceTypeRequestCB.DataSource = this.insuranceTypeBindingSource;
            this.insuranceTypeRequestCB.DisplayMember = "name";
            this.insuranceTypeRequestCB.FormattingEnabled = true;
            this.insuranceTypeRequestCB.Location = new System.Drawing.Point(111, 125);
            this.insuranceTypeRequestCB.Name = "insuranceTypeRequestCB";
            this.insuranceTypeRequestCB.Size = new System.Drawing.Size(208, 21);
            this.insuranceTypeRequestCB.TabIndex = 3;
            this.insuranceTypeRequestCB.ValueMember = "ID";
            this.insuranceTypeRequestCB.SelectionChangeCommitted += new System.EventHandler(this.insuranceTypeRequestCB_SelectionChangeCommitted);
            // 
            // insuranceTypeBindingSource
            // 
            this.insuranceTypeBindingSource.DataMember = "InsuranceType";
            this.insuranceTypeBindingSource.DataSource = this.insuranceCompanyDataSet;
            // 
            // sumRequestCB
            // 
            this.sumRequestCB.Location = new System.Drawing.Point(358, 255);
            this.sumRequestCB.Name = "sumRequestCB";
            this.sumRequestCB.Size = new System.Drawing.Size(226, 20);
            this.sumRequestCB.TabIndex = 22;
            this.sumRequestCB.Validating += new System.ComponentModel.CancelEventHandler(this.decimalRequestCB_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(355, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Фактическая сумма оплаты";
            // 
            // costRequestCB
            // 
            this.costRequestCB.Location = new System.Drawing.Point(462, 203);
            this.costRequestCB.Name = "costRequestCB";
            this.costRequestCB.Size = new System.Drawing.Size(122, 20);
            this.costRequestCB.TabIndex = 28;
            this.costRequestCB.Validating += new System.ComponentModel.CancelEventHandler(this.decimalRequestCB_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(355, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Стоимость полиса";
            // 
            // dateFinishRequestDTP
            // 
            this.dateFinishRequestDTP.Location = new System.Drawing.Point(630, 255);
            this.dateFinishRequestDTP.Name = "dateFinishRequestDTP";
            this.dateFinishRequestDTP.Size = new System.Drawing.Size(226, 20);
            this.dateFinishRequestDTP.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(627, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Дата окончания действия полиса";
            // 
            // requstInsertBTN
            // 
            this.requstInsertBTN.Location = new System.Drawing.Point(12, 283);
            this.requstInsertBTN.Name = "requstInsertBTN";
            this.requstInsertBTN.Size = new System.Drawing.Size(252, 49);
            this.requstInsertBTN.TabIndex = 4;
            this.requstInsertBTN.Text = "Добавить";
            this.requstInsertBTN.UseVisualStyleBackColor = true;
            this.requstInsertBTN.Click += new System.EventHandler(this.requstInsertBTN_Click);
            // 
            // paymentProcedureTB
            // 
            this.paymentProcedureTB.Location = new System.Drawing.Point(901, 162);
            this.paymentProcedureTB.Multiline = true;
            this.paymentProcedureTB.Name = "paymentProcedureTB";
            this.paymentProcedureTB.Size = new System.Drawing.Size(283, 113);
            this.paymentProcedureTB.TabIndex = 24;
            this.paymentProcedureTB.Validating += new System.ComponentModel.CancelEventHandler(this.string500RequestTB_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(898, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Порядок выплаты";
            // 
            // dateStartRequestDTP
            // 
            this.dateStartRequestDTP.Location = new System.Drawing.Point(630, 165);
            this.dateStartRequestDTP.Name = "dateStartRequestDTP";
            this.dateStartRequestDTP.Size = new System.Drawing.Size(226, 20);
            this.dateStartRequestDTP.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(627, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Дата подписания полиса";
            // 
            // policyNumberRequestCB
            // 
            this.policyNumberRequestCB.Location = new System.Drawing.Point(400, 165);
            this.policyNumberRequestCB.Name = "policyNumberRequestCB";
            this.policyNumberRequestCB.Size = new System.Drawing.Size(184, 20);
            this.policyNumberRequestCB.TabIndex = 20;
            this.policyNumberRequestCB.Validating += new System.ComponentModel.CancelEventHandler(this.policyNumberRequestCB_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Полис";
            // 
            // conditionsRiskRequestT
            // 
            this.conditionsRiskRequestT.Location = new System.Drawing.Point(901, 32);
            this.conditionsRiskRequestT.Multiline = true;
            this.conditionsRiskRequestT.Name = "conditionsRiskRequestT";
            this.conditionsRiskRequestT.Size = new System.Drawing.Size(283, 99);
            this.conditionsRiskRequestT.TabIndex = 18;
            this.conditionsRiskRequestT.Validating += new System.ComponentModel.CancelEventHandler(this.string500RequestTB_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(627, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Особоые условия страхования ";
            // 
            // specialConditionsRequestT
            // 
            this.specialConditionsRequestT.Location = new System.Drawing.Point(630, 32);
            this.specialConditionsRequestT.Multiline = true;
            this.specialConditionsRequestT.Name = "specialConditionsRequestT";
            this.specialConditionsRequestT.Size = new System.Drawing.Size(226, 99);
            this.specialConditionsRequestT.TabIndex = 16;
            this.specialConditionsRequestT.Validating += new System.ComponentModel.CancelEventHandler(this.string500RequestTB_Validating);
            // 
            // documentListRequestTB
            // 
            this.documentListRequestTB.Enabled = false;
            this.documentListRequestTB.Location = new System.Drawing.Point(358, 32);
            this.documentListRequestTB.Multiline = true;
            this.documentListRequestTB.Name = "documentListRequestTB";
            this.documentListRequestTB.Size = new System.Drawing.Size(226, 99);
            this.documentListRequestTB.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Список документов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(898, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Условия влияющие на степень риска";
            // 
            // programmRequestCB
            // 
            this.programmRequestCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.programmBindingSource, "ID", true));
            this.programmRequestCB.DataSource = this.programmBindingSource;
            this.programmRequestCB.DisplayMember = "name";
            this.programmRequestCB.FormattingEnabled = true;
            this.programmRequestCB.Location = new System.Drawing.Point(111, 163);
            this.programmRequestCB.Name = "programmRequestCB";
            this.programmRequestCB.Size = new System.Drawing.Size(208, 21);
            this.programmRequestCB.TabIndex = 10;
            this.programmRequestCB.ValueMember = "ID";
            // 
            // programmBindingSource
            // 
            this.programmBindingSource.DataMember = "Programm";
            this.programmBindingSource.DataSource = this.insuranceCompanyDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вид страхования";
            // 
            // Ghj
            // 
            this.Ghj.AutoSize = true;
            this.Ghj.Location = new System.Drawing.Point(39, 168);
            this.Ghj.Name = "Ghj";
            this.Ghj.Size = new System.Drawing.Size(66, 13);
            this.Ghj.TabIndex = 7;
            this.Ghj.Text = "Программа";
            // 
            // insurerRequestCB
            // 
            this.insurerRequestCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.insurerBindingSource, "ID", true));
            this.insurerRequestCB.FormattingEnabled = true;
            this.insurerRequestCB.Location = new System.Drawing.Point(111, 83);
            this.insurerRequestCB.Name = "insurerRequestCB";
            this.insurerRequestCB.Size = new System.Drawing.Size(208, 21);
            this.insurerRequestCB.TabIndex = 6;
            // 
            // insurerBindingSource
            // 
            this.insurerBindingSource.DataMember = "Insurer";
            this.insurerBindingSource.DataSource = this.insuranceCompanyDataSet;
            // 
            // clientRequestCB
            // 
            this.clientRequestCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource, "ID", true));
            this.clientRequestCB.FormattingEnabled = true;
            this.clientRequestCB.Location = new System.Drawing.Point(111, 47);
            this.clientRequestCB.Name = "clientRequestCB";
            this.clientRequestCB.Size = new System.Drawing.Size(208, 21);
            this.clientRequestCB.TabIndex = 5;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.insuranceCompanyDataSet;
            // 
            // dateRequestLabel
            // 
            this.dateRequestLabel.AutoSize = true;
            this.dateRequestLabel.Location = new System.Drawing.Point(157, 16);
            this.dateRequestLabel.Name = "dateRequestLabel";
            this.dateRequestLabel.Size = new System.Drawing.Size(94, 13);
            this.dateRequestLabel.TabIndex = 4;
            this.dateRequestLabel.Text = "dateRequestLabel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Страховщик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Клиент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата подачи заявки";
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // insurerTableAdapter
            // 
            this.insurerTableAdapter.ClearBeforeFill = true;
            // 
            // programmTableAdapter
            // 
            this.programmTableAdapter.ClearBeforeFill = true;
            // 
            // insuranceTypeTableAdapter
            // 
            this.insuranceTypeTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.insuranceCompanyDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // requestErrorProvider
            // 
            this.requestErrorProvider.ContainerControl = this;
            // 
            // insuranceCaseBindingSource
            // 
            this.insuranceCaseBindingSource.DataMember = "InsuranceCase";
            this.insuranceCaseBindingSource.DataSource = this.insuranceCompanyDataSet;
            // 
            // insuranceCaseTableAdapter
            // 
            this.insuranceCaseTableAdapter.ClearBeforeFill = true;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Branch";
            this.branchBindingSource.DataSource = this.insuranceCompanyDataSet;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // listRisksBindingSource
            // 
            this.listRisksBindingSource.DataMember = "ListRisks";
            this.listRisksBindingSource.DataSource = this.insuranceCompanyDataSet;
            // 
            // listRisksTableAdapter
            // 
            this.listRisksTableAdapter.ClearBeforeFill = true;
            // 
            // riskBindingSource
            // 
            this.riskBindingSource.DataMember = "Risk";
            this.riskBindingSource.DataSource = this.insuranceCompanyDataSet;
            // 
            // riskTableAdapter
            // 
            this.riskTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 679);
            this.Controls.Add(this.registrationRequestGB);
            this.Controls.Add(this.listRequestGB);
            this.Controls.Add(this.mainFormMenuStrip);
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматизированное место менеджера страховой компании";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.listRequestGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGridView)).EndInit();
            this.requstContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCompanyDataSet)).EndInit();
            this.registrationRequestGB.ResumeLayout(false);
            this.registrationRequestGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRisksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.GroupBox listRequestGB;
        private System.Windows.Forms.GroupBox registrationRequestGB;
        private System.Windows.Forms.Button updateRequestBTN;
        private System.Windows.Forms.Button deleteRequestBTN;
        private System.Windows.Forms.DataGridView requestDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox programmRequestCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Ghj;
        private System.Windows.Forms.ComboBox insurerRequestCB;
        private System.Windows.Forms.ComboBox clientRequestCB;
        private System.Windows.Forms.Label dateRequestLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox conditionsRiskRequestT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox specialConditionsRequestT;
        private System.Windows.Forms.TextBox documentListRequestTB;
        private System.Windows.Forms.TextBox sumRequestCB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox costRequestCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateFinishRequestDTP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button requstInsertBTN;
        private System.Windows.Forms.TextBox paymentProcedureTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateStartRequestDTP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox policyNumberRequestCB;
        private System.Windows.Forms.Label label7;
        private InsuranceCompanyDataSet insuranceCompanyDataSet;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private InsuranceCompanyDataSetTableAdapters.RequestTableAdapter requestTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private InsuranceCompanyDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource insurerBindingSource;
        private InsuranceCompanyDataSetTableAdapters.InsurerTableAdapter insurerTableAdapter;
        private System.Windows.Forms.BindingSource programmBindingSource;
        private InsuranceCompanyDataSetTableAdapters.ProgrammTableAdapter programmTableAdapter;
        private System.Windows.Forms.BindingSource insuranceTypeBindingSource;
        private InsuranceCompanyDataSetTableAdapters.InsuranceTypeTableAdapter insuranceTypeTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private InsuranceCompanyDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.ComboBox insuranceTypeRequestCB;
        private System.Windows.Forms.ContextMenuStrip requstContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem insuranceCaseToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider requestErrorProvider;
        private System.Windows.Forms.Button printRequestBTN;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem должникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окончаниеСрокаДействияПолисаToolStripMenuItem;
        private System.Windows.Forms.BindingSource insuranceCaseBindingSource;
        private InsuranceCompanyDataSetTableAdapters.InsuranceCaseTableAdapter insuranceCaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurer;
        private System.Windows.Forms.DataGridViewTextBoxColumn programm;
        private System.Windows.Forms.DataGridViewTextBoxColumn insuranceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn insuranceTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listDocumentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceiptPolicyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePolicyExpiration;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialConditionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionsInfluenceDegreeRiskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policyCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentProcedureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private InsuranceCompanyDataSetTableAdapters.BranchTableAdapter branchTableAdapter;
        private System.Windows.Forms.BindingSource listRisksBindingSource;
        private InsuranceCompanyDataSetTableAdapters.ListRisksTableAdapter listRisksTableAdapter;
        private System.Windows.Forms.BindingSource riskBindingSource;
        private InsuranceCompanyDataSetTableAdapters.RiskTableAdapter riskTableAdapter;
    }
}

