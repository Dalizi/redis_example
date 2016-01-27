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
            Dictionary<String, Type> colTypeDict = new Dictionary<string, Type>
            {
                {"ContractCode", typeof(string) },
                {"AskPrice1", typeof(decimal) },
                {"AskVolume1", typeof(decimal) },
                {"BidPrice1", typeof(decimal) },
                {"BidVolume1", typeof(decimal) },
                {"Exchange", typeof(string) },
                {"LastPrice", typeof(decimal) },
                {"OpenInterest", typeof(decimal) },
                {"PreSettlementPrice", typeof(decimal) },
                {"UpdateTime", typeof(DateTime) },
                {"Volume", typeof(decimal) }
            };
            DataTable redisTable = this.Tables.Add("RedisTable");
            foreach (KeyValuePair<String, Type> pair in colTypeDict)
            {
                String name = pair.Key;
                Type type = pair.Value;
                DataColumn column = new DataColumn(name);
                column.DataType = type;
                column.AllowDBNull = true;
                column.Caption = name;
                column.DefaultValue = DBNull.Value;
                redisTable.Columns.Add(column);
            }
            redisTable.PrimaryKey = new DataColumn[] { redisTable.Columns["ContractCode"] };
            this.conn = ConnectionMultiplexer.Connect("10.2.7.210:6379, password=Finders6");
            this.Tables.Add("options_contracts");
            InitSqlConnection();
        }

        //private void DoSomeThing(RedisChannel channel, RedisValue message)
        //{
        //    DataRow row;
        //    DataTable quotesTable = this.Tables[0];
        //    row = quotesTable.Rows.Find(channel.ToString());
        //    if (row == null)
        //    {
        //        row = quotesTable.NewRow();
        //        row["ContractCode"] = channel.ToString();

        //        foreach (String item in ((string)message).Split(','))
        //        {
        //            String key;
        //            String value;
        //            String[] keyValue = item.Split(':');
        //            key = keyValue[0];
        //            value = keyValue[1];
        //            if (quotesTable.Columns[key].DataType == typeof(String))
        //            {
        //                row[key] = value;
        //            }
        //            else if (quotesTable.Columns[key].DataType == typeof(decimal))
        //            {
        //                row[key] = Convert.ToDecimal(value);
        //            }
        //        }

        //        quotesTable.Rows.Add(row);


        //    }
        //    else
        //    {

        //        foreach (String item in ((string)message).Split(','))
        //        {
        //            String key;
        //            String value;
        //            String[] keyValue = item.Split(':');
        //            key = keyValue[0];
        //            value = keyValue[1];
        //            if (quotesTable.Columns[key].DataType == typeof(String))
        //            {
        //                row[key] = value;
        //            }
        //            else if (quotesTable.Columns[key].DataType == typeof(decimal))
        //            {
        //                row[key] = Convert.ToDecimal(value);
        //            }
        //            else if (quotesTable.Columns[key].DataType == typeof(DateTime))
        //            {
        //                row[key] = DateTime.ParseExact(value, "HHmmssfff", CultureInfo.InvariantCulture);
        //            }
        //        }

        //    }
        //}

        private void InitSqlConnection()
        {
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
            MySqlConnection connMysql = new MySqlConnection();
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();
            connBuilder.Server = "10.2.7.210";
            connBuilder.Port = 3306;
            connBuilder.Database = "otc";
            connBuilder.UserID = "tanzehuan";
            connBuilder.Password = "80027111t";
            connMysql.ConnectionString = connBuilder.ConnectionString;
            connMysql.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from options_contract", connMysql);
            adapter.Fill(this, "options_contracts");
        }

        ConnectionMultiplexer conn;
        MySqlConnection connMysql;
    }
}
