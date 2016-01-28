using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using StackExchange.Redis;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuotesExample
{
    class QuotesDataSet : DataSet
    {
        public QuotesDataSet() : base("Quotes")
        {

            this.connRedis = ConnectionMultiplexer.Connect("10.2.7.210:6379, password=Finders6");//配置redis连接
            this.Tables.Add("options_contracts");
            InitSqlConnection();//初始化Mysql连接信息
            GetOptionsPricingParam();//将Mysql中的合约信息读入此dataset中名为options_contracts的表
            Timer timer = new Timer();//计时器
            timer.Interval = 500;//每0.5秒触发一次计时器事件
            timer.Tick += new EventHandler(UpdateQuotes);//将事件处理器UpdateQuotes绑定到计时器上
            timer.Start();//开始运行计时器
            

        }

        private void UpdateQuotes(object sender, EventArgs e)
        {
            DataTable table = this.Tables["options_contracts"];
            IDatabase redisDb = connRedis.GetDatabase();//从redis连接中获得缺省数据库连接
            foreach (DataRow row in table.Rows)
            {
                //遍历options_contracts表，从每一行中读取标的合约代码，再用该代码从redis数据库中读取最新行情
                String underlying = row["underlying_code"].ToString();
                double strikePrice = (double)row["strike_price"];
                DateTime maturityDate = (DateTime)row["maturity_date"];
                double dtm = new TimeSpan(maturityDate.Ticks - DateTime.Today.Ticks).Days;
                double volatility = (double)row["volatility"];
                decimal lastPrice = decimal.Parse(redisDb.HashGet(underlying, "LastPrice").ToString());
                decimal price = OptionsPricing.GetBlsPutPrice((double)lastPrice, strikePrice, dtm/256, volatility, 0.0325);
                row["last_price"] = lastPrice;
                row["bls_price"] = price;

            }
        }

  

        private void InitSqlConnection()
        {
            //配置MySQL连接信息
            this.connMysql = new MySqlConnection();
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();
            connBuilder.Server = "10.2.7.210";
            connBuilder.Port = 3306;
            connBuilder.Database = "otc";
            connBuilder.UserID = "tanzehuan";
            connBuilder.Password = "80027111t";
            connMysql.ConnectionString = connBuilder.ConnectionString;
        }
        private void GetOptionsPricingParam()
        {
            //从数据库中读取合约参数
            MySqlConnection connMysql = new MySqlConnection();
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();
            connBuilder.Server = "10.2.7.210";
            connBuilder.Port = 3306;
            connBuilder.Database = "otc";
            connBuilder.UserID = "tanzehuan";
            connBuilder.Password = "80027111t";
            connMysql.ConnectionString = connBuilder.ConnectionString;

            connMysql.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from options_contracts", connMysql);//创建连接sql数据库和datatable的dataadapter
            adapter.Fill(this, "options_contracts");//将sql数据库中的数据读入datatable
            connMysql.Close();

            //在datatable中添加新的列，用来储存最新价
            DataColumn col = new DataColumn("last_price");
            col.DataType = typeof(decimal);
            col.AllowDBNull = true;
            col.DefaultValue = 0;
            this.Tables["options_contracts"].Columns.Add(col);

            DataColumn colBls = new DataColumn("bls_price");
            colBls.DataType = typeof(decimal);
            colBls.AllowDBNull = true;
            colBls.DefaultValue = 0;
            this.Tables["options_contracts"].Columns.Add(colBls);
        }

        ConnectionMultiplexer connRedis;
        MySqlConnection connMysql;

    }
}
