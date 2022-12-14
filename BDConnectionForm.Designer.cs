
namespace Страховая_компания__2021_
{
    partial class DBConnectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.serverNameCB = new System.Windows.Forms.ComboBox();
            this.connectionBTN = new System.Windows.Forms.Button();
            this.seveConnectionBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя сервера";
            // 
            // serverNameCB
            // 
            this.serverNameCB.FormattingEnabled = true;
            this.serverNameCB.Location = new System.Drawing.Point(92, 12);
            this.serverNameCB.Name = "serverNameCB";
            this.serverNameCB.Size = new System.Drawing.Size(268, 21);
            this.serverNameCB.TabIndex = 1;
            // 
            // connectionBTN
            // 
            this.connectionBTN.Location = new System.Drawing.Point(15, 39);
            this.connectionBTN.Name = "connectionBTN";
            this.connectionBTN.Size = new System.Drawing.Size(160, 26);
            this.connectionBTN.TabIndex = 4;
            this.connectionBTN.Text = "Подключиться";
            this.connectionBTN.UseVisualStyleBackColor = true;
            this.connectionBTN.Click += new System.EventHandler(this.connectionBTN_Click);
            // 
            // seveConnectionBTN
            // 
            this.seveConnectionBTN.Location = new System.Drawing.Point(200, 39);
            this.seveConnectionBTN.Name = "seveConnectionBTN";
            this.seveConnectionBTN.Size = new System.Drawing.Size(160, 26);
            this.seveConnectionBTN.TabIndex = 5;
            this.seveConnectionBTN.Text = "Сохранить";
            this.seveConnectionBTN.UseVisualStyleBackColor = true;
            this.seveConnectionBTN.Click += new System.EventHandler(this.seveConnectionBTN_Click);
            // 
            // DBConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 75);
            this.Controls.Add(this.seveConnectionBTN);
            this.Controls.Add(this.connectionBTN);
            this.Controls.Add(this.serverNameCB);
            this.Controls.Add(this.label1);
            this.Name = "DBConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение к БД";
            this.Load += new System.EventHandler(this.DBConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serverNameCB;
        private System.Windows.Forms.Button connectionBTN;
        private System.Windows.Forms.Button seveConnectionBTN;
    }
}