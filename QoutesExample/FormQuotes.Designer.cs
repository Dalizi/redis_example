namespace QuotesExample
{
    partial class FormQuotes
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
            this.dataGridViewQuotes = new System.Windows.Forms.DataGridView();
            this.contractCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.askPrice1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.askVolume1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidPrice1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidVolume1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openInterestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSettlementPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableMarketQuotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQuotes = new QuotesExample.DataSetQuotes();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableMarketQuotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuotes
            // 
            this.dataGridViewQuotes.AllowUserToAddRows = false;
            this.dataGridViewQuotes.AllowUserToDeleteRows = false;
            this.dataGridViewQuotes.AutoGenerateColumns = false;
            this.dataGridViewQuotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractCodeDataGridViewTextBoxColumn,
            this.askPrice1DataGridViewTextBoxColumn,
            this.askVolume1DataGridViewTextBoxColumn,
            this.bidPrice1DataGridViewTextBoxColumn,
            this.bidVolume1DataGridViewTextBoxColumn,
            this.exchangeDataGridViewTextBoxColumn,
            this.lastPriceDataGridViewTextBoxColumn,
            this.openInterestDataGridViewTextBoxColumn,
            this.preSettlementPriceDataGridViewTextBoxColumn,
            this.updateTimeDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn});
            this.dataGridViewQuotes.DataSource = this.dataTableMarketQuotesBindingSource;
            this.dataGridViewQuotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewQuotes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewQuotes.Name = "dataGridViewQuotes";
            this.dataGridViewQuotes.RowTemplate.Height = 23;
            this.dataGridViewQuotes.Size = new System.Drawing.Size(1112, 227);
            this.dataGridViewQuotes.TabIndex = 0;
            // 
            // contractCodeDataGridViewTextBoxColumn
            // 
            this.contractCodeDataGridViewTextBoxColumn.DataPropertyName = "ContractCode";
            this.contractCodeDataGridViewTextBoxColumn.HeaderText = "ContractCode";
            this.contractCodeDataGridViewTextBoxColumn.Name = "contractCodeDataGridViewTextBoxColumn";
            // 
            // askPrice1DataGridViewTextBoxColumn
            // 
            this.askPrice1DataGridViewTextBoxColumn.DataPropertyName = "AskPrice1";
            this.askPrice1DataGridViewTextBoxColumn.HeaderText = "AskPrice1";
            this.askPrice1DataGridViewTextBoxColumn.Name = "askPrice1DataGridViewTextBoxColumn";
            // 
            // askVolume1DataGridViewTextBoxColumn
            // 
            this.askVolume1DataGridViewTextBoxColumn.DataPropertyName = "AskVolume1";
            this.askVolume1DataGridViewTextBoxColumn.HeaderText = "AskVolume1";
            this.askVolume1DataGridViewTextBoxColumn.Name = "askVolume1DataGridViewTextBoxColumn";
            // 
            // bidPrice1DataGridViewTextBoxColumn
            // 
            this.bidPrice1DataGridViewTextBoxColumn.DataPropertyName = "BidPrice1";
            this.bidPrice1DataGridViewTextBoxColumn.HeaderText = "BidPrice1";
            this.bidPrice1DataGridViewTextBoxColumn.Name = "bidPrice1DataGridViewTextBoxColumn";
            // 
            // bidVolume1DataGridViewTextBoxColumn
            // 
            this.bidVolume1DataGridViewTextBoxColumn.DataPropertyName = "BidVolume1";
            this.bidVolume1DataGridViewTextBoxColumn.HeaderText = "BidVolume1";
            this.bidVolume1DataGridViewTextBoxColumn.Name = "bidVolume1DataGridViewTextBoxColumn";
            // 
            // exchangeDataGridViewTextBoxColumn
            // 
            this.exchangeDataGridViewTextBoxColumn.DataPropertyName = "Exchange";
            this.exchangeDataGridViewTextBoxColumn.HeaderText = "Exchange";
            this.exchangeDataGridViewTextBoxColumn.Name = "exchangeDataGridViewTextBoxColumn";
            // 
            // lastPriceDataGridViewTextBoxColumn
            // 
            this.lastPriceDataGridViewTextBoxColumn.DataPropertyName = "LastPrice";
            this.lastPriceDataGridViewTextBoxColumn.HeaderText = "LastPrice";
            this.lastPriceDataGridViewTextBoxColumn.Name = "lastPriceDataGridViewTextBoxColumn";
            // 
            // openInterestDataGridViewTextBoxColumn
            // 
            this.openInterestDataGridViewTextBoxColumn.DataPropertyName = "OpenInterest";
            this.openInterestDataGridViewTextBoxColumn.HeaderText = "OpenInterest";
            this.openInterestDataGridViewTextBoxColumn.Name = "openInterestDataGridViewTextBoxColumn";
            // 
            // preSettlementPriceDataGridViewTextBoxColumn
            // 
            this.preSettlementPriceDataGridViewTextBoxColumn.DataPropertyName = "PreSettlementPrice";
            this.preSettlementPriceDataGridViewTextBoxColumn.HeaderText = "PreSettlementPrice";
            this.preSettlementPriceDataGridViewTextBoxColumn.Name = "preSettlementPriceDataGridViewTextBoxColumn";
            // 
            // updateTimeDataGridViewTextBoxColumn
            // 
            this.updateTimeDataGridViewTextBoxColumn.DataPropertyName = "UpdateTime";
            dataGridViewCellStyle1.Format = "{HH:mm:ss fff}";
            this.updateTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.updateTimeDataGridViewTextBoxColumn.HeaderText = "UpdateTime";
            this.updateTimeDataGridViewTextBoxColumn.Name = "updateTimeDataGridViewTextBoxColumn";
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            // 
            // dataTableMarketQuotesBindingSource
            // 
            this.dataTableMarketQuotesBindingSource.DataMember = "DataTableMarketQuotes";
            this.dataTableMarketQuotesBindingSource.DataSource = this.dataSetQuotes;
            this.dataTableMarketQuotesBindingSource.CurrentChanged += new System.EventHandler(this.dataTableMarketQuotesBindingSource_CurrentChanged);
            // 
            // dataSetQuotes
            // 
            this.dataSetQuotes.DataSetName = "DataSetQuotes";
            this.dataSetQuotes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(1026, 234);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 261);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewQuotes);
            this.Name = "FormQuotes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableMarketQuotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuotes;
        private System.Windows.Forms.BindingSource dataTableMarketQuotesBindingSource;
        private DataSetQuotes dataSetQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn askPrice1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn askVolume1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidPrice1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidVolume1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openInterestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSettlementPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

