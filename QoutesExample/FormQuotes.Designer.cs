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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.optionscontractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typedirectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strikepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maturitydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marginrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.underlyingcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settlepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multiplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volatilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blspriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionscontractsBindingSource)).BeginInit();
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
            this.contractcodeDataGridViewTextBoxColumn,
            this.typecodeDataGridViewTextBoxColumn,
            this.typedirectionDataGridViewTextBoxColumn,
            this.strikepriceDataGridViewTextBoxColumn,
            this.maturitydateDataGridViewTextBoxColumn,
            this.marginrateDataGridViewTextBoxColumn,
            this.underlyingcodeDataGridViewTextBoxColumn,
            this.settlepriceDataGridViewTextBoxColumn,
            this.multiplierDataGridViewTextBoxColumn,
            this.commissionDataGridViewTextBoxColumn,
            this.volatilityDataGridViewTextBoxColumn,
            this.lastpriceDataGridViewTextBoxColumn,
            this.blspriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.optionscontractsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(949, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // optionscontractsBindingSource
            // 
            this.optionscontractsBindingSource.DataMember = "options_contracts";
            this.optionscontractsBindingSource.DataSource = typeof(QuotesExample.QuotesDataSet);
            this.optionscontractsBindingSource.Position = 0;
            // 
            // contractcodeDataGridViewTextBoxColumn
            // 
            this.contractcodeDataGridViewTextBoxColumn.DataPropertyName = "contract_code";
            this.contractcodeDataGridViewTextBoxColumn.HeaderText = "contract_code";
            this.contractcodeDataGridViewTextBoxColumn.Name = "contractcodeDataGridViewTextBoxColumn";
            // 
            // typecodeDataGridViewTextBoxColumn
            // 
            this.typecodeDataGridViewTextBoxColumn.DataPropertyName = "type_code";
            this.typecodeDataGridViewTextBoxColumn.HeaderText = "type_code";
            this.typecodeDataGridViewTextBoxColumn.Name = "typecodeDataGridViewTextBoxColumn";
            // 
            // typedirectionDataGridViewTextBoxColumn
            // 
            this.typedirectionDataGridViewTextBoxColumn.DataPropertyName = "type_direction";
            this.typedirectionDataGridViewTextBoxColumn.HeaderText = "type_direction";
            this.typedirectionDataGridViewTextBoxColumn.Name = "typedirectionDataGridViewTextBoxColumn";
            // 
            // strikepriceDataGridViewTextBoxColumn
            // 
            this.strikepriceDataGridViewTextBoxColumn.DataPropertyName = "strike_price";
            this.strikepriceDataGridViewTextBoxColumn.HeaderText = "strike_price";
            this.strikepriceDataGridViewTextBoxColumn.Name = "strikepriceDataGridViewTextBoxColumn";
            // 
            // maturitydateDataGridViewTextBoxColumn
            // 
            this.maturitydateDataGridViewTextBoxColumn.DataPropertyName = "maturity_date";
            this.maturitydateDataGridViewTextBoxColumn.HeaderText = "maturity_date";
            this.maturitydateDataGridViewTextBoxColumn.Name = "maturitydateDataGridViewTextBoxColumn";
            // 
            // marginrateDataGridViewTextBoxColumn
            // 
            this.marginrateDataGridViewTextBoxColumn.DataPropertyName = "margin_rate";
            this.marginrateDataGridViewTextBoxColumn.HeaderText = "margin_rate";
            this.marginrateDataGridViewTextBoxColumn.Name = "marginrateDataGridViewTextBoxColumn";
            // 
            // underlyingcodeDataGridViewTextBoxColumn
            // 
            this.underlyingcodeDataGridViewTextBoxColumn.DataPropertyName = "underlying_code";
            this.underlyingcodeDataGridViewTextBoxColumn.HeaderText = "underlying_code";
            this.underlyingcodeDataGridViewTextBoxColumn.Name = "underlyingcodeDataGridViewTextBoxColumn";
            // 
            // settlepriceDataGridViewTextBoxColumn
            // 
            this.settlepriceDataGridViewTextBoxColumn.DataPropertyName = "settle_price";
            this.settlepriceDataGridViewTextBoxColumn.HeaderText = "settle_price";
            this.settlepriceDataGridViewTextBoxColumn.Name = "settlepriceDataGridViewTextBoxColumn";
            // 
            // multiplierDataGridViewTextBoxColumn
            // 
            this.multiplierDataGridViewTextBoxColumn.DataPropertyName = "multiplier";
            this.multiplierDataGridViewTextBoxColumn.HeaderText = "multiplier";
            this.multiplierDataGridViewTextBoxColumn.Name = "multiplierDataGridViewTextBoxColumn";
            // 
            // commissionDataGridViewTextBoxColumn
            // 
            this.commissionDataGridViewTextBoxColumn.DataPropertyName = "commission";
            this.commissionDataGridViewTextBoxColumn.HeaderText = "commission";
            this.commissionDataGridViewTextBoxColumn.Name = "commissionDataGridViewTextBoxColumn";
            // 
            // volatilityDataGridViewTextBoxColumn
            // 
            this.volatilityDataGridViewTextBoxColumn.DataPropertyName = "volatility";
            this.volatilityDataGridViewTextBoxColumn.HeaderText = "volatility";
            this.volatilityDataGridViewTextBoxColumn.Name = "volatilityDataGridViewTextBoxColumn";
            // 
            // lastpriceDataGridViewTextBoxColumn
            // 
            this.lastpriceDataGridViewTextBoxColumn.DataPropertyName = "last_price";
            this.lastpriceDataGridViewTextBoxColumn.HeaderText = "last_price";
            this.lastpriceDataGridViewTextBoxColumn.Name = "lastpriceDataGridViewTextBoxColumn";
            // 
            // blspriceDataGridViewTextBoxColumn
            // 
            this.blspriceDataGridViewTextBoxColumn.DataPropertyName = "bls_price";
            this.blspriceDataGridViewTextBoxColumn.HeaderText = "bls_price";
            this.blspriceDataGridViewTextBoxColumn.Name = "blspriceDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.optionscontractsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn askVolumne1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidVolumne1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typedirectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strikepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maturitydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marginrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn underlyingcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn settlepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn multiplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volatilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blspriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource optionscontractsBindingSource;
    }
}