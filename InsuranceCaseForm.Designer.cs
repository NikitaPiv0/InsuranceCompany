
namespace Страховая_компания__2021_
{
    partial class InsuranceCaseForm
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
            this.listRequestGB = new System.Windows.Forms.GroupBox();
            this.insuranceCaseDVG = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.risk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePayoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuranceCaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insuranceCompanyDataSet = new Страховая_компания__2021_.InsuranceCompanyDataSet();
            this.updateInsuranceCaseBTN = new System.Windows.Forms.Button();
            this.deleteInsuranceCaseBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateInsuranceCaseDTP = new System.Windows.Forms.DateTimePicker();
            this.datePaymentDTP = new System.Windows.Forms.DateTimePicker();
            this.riskID_CB = new System.Windows.Forms.ComboBox();
            this.riskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sumTB = new System.Windows.Forms.TextBox();
            this.remarksTB = new System.Windows.Forms.TextBox();
            this.insertInsuranceCaseBTN = new System.Windows.Forms.Button();
            this.insuranceCaseTableAdapter = new Страховая_компания__2021_.InsuranceCompanyDataSetTableAdapters.InsuranceCaseTableAdapter();
            this.riskTableAdapter = new Страховая_компания__2021_.InsuranceCompanyDataSetTableAdapters.RiskTableAdapter();
            this.listRisksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listRisksTableAdapter = new Страховая_компания__2021_.InsuranceCompanyDataSetTableAdapters.ListRisksTableAdapter();
            this.reqeustID_TB = new System.Windows.Forms.TextBox();
            this.insuranceCaseErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.listRequestGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCaseDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRisksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCaseErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listRequestGB
            // 
            this.listRequestGB.Controls.Add(this.insuranceCaseDVG);
            this.listRequestGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.listRequestGB.Location = new System.Drawing.Point(0, 0);
            this.listRequestGB.Name = "listRequestGB";
            this.listRequestGB.Size = new System.Drawing.Size(1055, 317);
            this.listRequestGB.TabIndex = 2;
            this.listRequestGB.TabStop = false;
            this.listRequestGB.Text = "Список страховых случаев";
            // 
            // insuranceCaseDVG
            // 
            this.insuranceCaseDVG.AllowUserToAddRows = false;
            this.insuranceCaseDVG.AllowUserToDeleteRows = false;
            this.insuranceCaseDVG.AutoGenerateColumns = false;
            this.insuranceCaseDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insuranceCaseDVG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.requestIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.risk,
            this.sumDataGridViewTextBoxColumn,
            this.datePayoutDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.riskIDDataGridViewTextBoxColumn});
            this.insuranceCaseDVG.DataSource = this.insuranceCaseBindingSource;
            this.insuranceCaseDVG.Dock = System.Windows.Forms.DockStyle.Top;
            this.insuranceCaseDVG.Location = new System.Drawing.Point(3, 16);
            this.insuranceCaseDVG.Name = "insuranceCaseDVG";
            this.insuranceCaseDVG.ReadOnly = true;
            this.insuranceCaseDVG.Size = new System.Drawing.Size(1049, 295);
            this.insuranceCaseDVG.TabIndex = 0;
            this.insuranceCaseDVG.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.insuranceCaseDVG_CellMouseDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "requestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "Номер заявки";
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestIDDataGridViewTextBoxColumn.Width = 96;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата страх случая";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 115;
            // 
            // risk
            // 
            this.risk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.risk.DataPropertyName = "risk";
            this.risk.HeaderText = "Риск";
            this.risk.Name = "risk";
            this.risk.ReadOnly = true;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumDataGridViewTextBoxColumn.Width = 66;
            // 
            // datePayoutDataGridViewTextBoxColumn
            // 
            this.datePayoutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datePayoutDataGridViewTextBoxColumn.DataPropertyName = "datePayout";
            this.datePayoutDataGridViewTextBoxColumn.HeaderText = "Дата выплаты";
            this.datePayoutDataGridViewTextBoxColumn.Name = "datePayoutDataGridViewTextBoxColumn";
            this.datePayoutDataGridViewTextBoxColumn.ReadOnly = true;
            this.datePayoutDataGridViewTextBoxColumn.Width = 97;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Замечания";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // riskIDDataGridViewTextBoxColumn
            // 
            this.riskIDDataGridViewTextBoxColumn.DataPropertyName = "riskID";
            this.riskIDDataGridViewTextBoxColumn.HeaderText = "riskID";
            this.riskIDDataGridViewTextBoxColumn.Name = "riskIDDataGridViewTextBoxColumn";
            this.riskIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.riskIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // insuranceCaseBindingSource
            // 
            this.insuranceCaseBindingSource.DataMember = "InsuranceCase";
            this.insuranceCaseBindingSource.DataSource = this.insuranceCompanyDataSet;
            // 
            // insuranceCompanyDataSet
            // 
            this.insuranceCompanyDataSet.DataSetName = "InsuranceCompanyDataSet";
            this.insuranceCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updateInsuranceCaseBTN
            // 
            this.updateInsuranceCaseBTN.Location = new System.Drawing.Point(746, 451);
            this.updateInsuranceCaseBTN.Name = "updateInsuranceCaseBTN";
            this.updateInsuranceCaseBTN.Size = new System.Drawing.Size(297, 49);
            this.updateInsuranceCaseBTN.TabIndex = 3;
            this.updateInsuranceCaseBTN.Text = "Редактировать";
            this.updateInsuranceCaseBTN.UseVisualStyleBackColor = true;
            this.updateInsuranceCaseBTN.Click += new System.EventHandler(this.updateInsuranceCaseBTN_Click);
            // 
            // deleteInsuranceCaseBTN
            // 
            this.deleteInsuranceCaseBTN.Location = new System.Drawing.Point(366, 451);
            this.deleteInsuranceCaseBTN.Name = "deleteInsuranceCaseBTN";
            this.deleteInsuranceCaseBTN.Size = new System.Drawing.Size(289, 49);
            this.deleteInsuranceCaseBTN.TabIndex = 2;
            this.deleteInsuranceCaseBTN.Text = "Удалить";
            this.deleteInsuranceCaseBTN.UseVisualStyleBackColor = true;
            this.deleteInsuranceCaseBTN.Click += new System.EventHandler(this.deleteInsuranceCaseBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата страхового случая";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер заявки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата выплаты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Замечания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Страховая сумма";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Риск";
            // 
            // dateInsuranceCaseDTP
            // 
            this.dateInsuranceCaseDTP.Location = new System.Drawing.Point(174, 352);
            this.dateInsuranceCaseDTP.Name = "dateInsuranceCaseDTP";
            this.dateInsuranceCaseDTP.Size = new System.Drawing.Size(192, 20);
            this.dateInsuranceCaseDTP.TabIndex = 10;
            // 
            // datePaymentDTP
            // 
            this.datePaymentDTP.Location = new System.Drawing.Point(174, 389);
            this.datePaymentDTP.Name = "datePaymentDTP";
            this.datePaymentDTP.Size = new System.Drawing.Size(192, 20);
            this.datePaymentDTP.TabIndex = 11;
            // 
            // riskID_CB
            // 
            this.riskID_CB.FormattingEnabled = true;
            this.riskID_CB.Location = new System.Drawing.Point(174, 424);
            this.riskID_CB.Name = "riskID_CB";
            this.riskID_CB.Size = new System.Drawing.Size(192, 21);
            this.riskID_CB.TabIndex = 12;
            // 
            // riskBindingSource
            // 
            this.riskBindingSource.DataMember = "Risk";
            this.riskBindingSource.DataSource = this.insuranceCompanyDataSet;
            // 
            // sumTB
            // 
            this.sumTB.Location = new System.Drawing.Point(547, 324);
            this.sumTB.Name = "sumTB";
            this.sumTB.Size = new System.Drawing.Size(496, 20);
            this.sumTB.TabIndex = 13;
            this.sumTB.Validating += new System.ComponentModel.CancelEventHandler(this.sumTB_Validating);
            // 
            // remarksTB
            // 
            this.remarksTB.Location = new System.Drawing.Point(448, 363);
            this.remarksTB.Multiline = true;
            this.remarksTB.Name = "remarksTB";
            this.remarksTB.Size = new System.Drawing.Size(595, 82);
            this.remarksTB.TabIndex = 14;
            this.remarksTB.Validating += new System.ComponentModel.CancelEventHandler(this.string500TB_Validating);
            // 
            // insertInsuranceCaseBTN
            // 
            this.insertInsuranceCaseBTN.Location = new System.Drawing.Point(12, 451);
            this.insertInsuranceCaseBTN.Name = "insertInsuranceCaseBTN";
            this.insertInsuranceCaseBTN.Size = new System.Drawing.Size(268, 49);
            this.insertInsuranceCaseBTN.TabIndex = 4;
            this.insertInsuranceCaseBTN.Text = "Добавить";
            this.insertInsuranceCaseBTN.UseVisualStyleBackColor = true;
            this.insertInsuranceCaseBTN.Click += new System.EventHandler(this.insertInsuranceCaseBTN_Click);
            // 
            // insuranceCaseTableAdapter
            // 
            this.insuranceCaseTableAdapter.ClearBeforeFill = true;
            // 
            // riskTableAdapter
            // 
            this.riskTableAdapter.ClearBeforeFill = true;
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
            // reqeustID_TB
            // 
            this.reqeustID_TB.Enabled = false;
            this.reqeustID_TB.Location = new System.Drawing.Point(174, 320);
            this.reqeustID_TB.Name = "reqeustID_TB";
            this.reqeustID_TB.Size = new System.Drawing.Size(192, 20);
            this.reqeustID_TB.TabIndex = 15;
            // 
            // insuranceCaseErrorProvider
            // 
            this.insuranceCaseErrorProvider.ContainerControl = this;
            // 
            // InsuranceCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 505);
            this.Controls.Add(this.updateInsuranceCaseBTN);
            this.Controls.Add(this.reqeustID_TB);
            this.Controls.Add(this.deleteInsuranceCaseBTN);
            this.Controls.Add(this.insertInsuranceCaseBTN);
            this.Controls.Add(this.remarksTB);
            this.Controls.Add(this.sumTB);
            this.Controls.Add(this.riskID_CB);
            this.Controls.Add(this.datePaymentDTP);
            this.Controls.Add(this.dateInsuranceCaseDTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listRequestGB);
            this.Name = "InsuranceCaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страховой случай";
            this.Load += new System.EventHandler(this.InsuranceCaseForm_Load);
            this.listRequestGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCaseDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRisksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceCaseErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox listRequestGB;
        private System.Windows.Forms.Button updateInsuranceCaseBTN;
        private System.Windows.Forms.Button deleteInsuranceCaseBTN;
        private System.Windows.Forms.DataGridView insuranceCaseDVG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateInsuranceCaseDTP;
        private System.Windows.Forms.DateTimePicker datePaymentDTP;
        private System.Windows.Forms.ComboBox riskID_CB;
        private System.Windows.Forms.TextBox sumTB;
        private System.Windows.Forms.TextBox remarksTB;
        private System.Windows.Forms.Button insertInsuranceCaseBTN;
        private InsuranceCompanyDataSet insuranceCompanyDataSet;
        private System.Windows.Forms.BindingSource insuranceCaseBindingSource;
        private InsuranceCompanyDataSetTableAdapters.InsuranceCaseTableAdapter insuranceCaseTableAdapter;
        private System.Windows.Forms.BindingSource riskBindingSource;
        private InsuranceCompanyDataSetTableAdapters.RiskTableAdapter riskTableAdapter;
        private System.Windows.Forms.BindingSource listRisksBindingSource;
        private InsuranceCompanyDataSetTableAdapters.ListRisksTableAdapter listRisksTableAdapter;
        private System.Windows.Forms.TextBox reqeustID_TB;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn risk;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePayoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider insuranceCaseErrorProvider;
    }
}