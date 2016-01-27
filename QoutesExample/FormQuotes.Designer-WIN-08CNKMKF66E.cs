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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuotes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quotesDataSet = new QuotesExample.QuotesDataSet();
            this.redisTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redisTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.redisTableBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(949, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // quotesDataSet
            // 
            this.quotesDataSet.DataSetName = "Quotes";
            // 
            // redisTableBindingSource
            // 
            this.redisTableBindingSource.DataMember = "RedisTable";
            this.redisTableBindingSource.DataSource = typeof(QuotesExample.QuotesDataSet);
            this.redisTableBindingSource.Position = 0;
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
            this.updateTimeDataGridViewTextBoxColumn.HeaderText = "UpdateTime";
            this.updateTimeDataGridViewTextBoxColumn.Name = "updateTimeDataGridViewTextBoxColumn";
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            // 
            // FormQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 358);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormQuotes";
            this.Text = "FormQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redisTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn askVolumne1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidVolumne1DataGridViewTextBoxColumn;
        private QuotesDataSet quotesDataSet;
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
        private System.Windows.Forms.BindingSource redisTableBindingSource;
    }
}