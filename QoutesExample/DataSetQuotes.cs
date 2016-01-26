using StackExchange.Redis;
using System.Data;
using System;
using System.Windows.Forms;
using System.Globalization;

namespace QuotesExample
{


    partial class DataSetQuotes
    {
        void InitializeData()
        {
            conn = ConnectionMultiplexer.Connect("10.2.7.210:6379,password=Finders6");
            ISubscriber sub= conn.GetSubscriber();
            sub.Subscribe("SR605", new Action<RedisChannel, RedisValue>(DoSomeThing));
        }

        private void DoSomeThing(RedisChannel channel, RedisValue message)
        {
            DataRow row;
            DataTable quotesTable = this.Tables[0];
            row = quotesTable.Rows.Find(channel.ToString());
            if (row == null)
            {
                row = quotesTable.NewRow();
                row["ContractCode"] = channel.ToString();
                try
                {
                    foreach (String item in ((string)message).Split(','))
                    {
                        String key;
                        String value;
                        String[] keyValue = item.Split(':');
                        key = keyValue[0];
                        value = keyValue[1];
                        if (quotesTable.Columns[key].DataType == typeof(String))
                        {
                            row[key] = value;
                        }
                        else if (quotesTable.Columns[key].DataType == typeof(decimal))
                        {
                            row[key] = Convert.ToDecimal(value);
                        }
                    }

                    quotesTable.Rows.Add(row);


                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Exception");
                }
            }
            else
            {
                try
                {
                    foreach (String item in ((string)message).Split(','))
                    {
                        String key;
                        String value;
                        String[] keyValue = item.Split(':');
                        key = keyValue[0];
                        value = keyValue[1];
                        if (quotesTable.Columns[key].DataType == typeof(String))
                        {
                            row[key] = value;
                        }
                        else if (quotesTable.Columns[key].DataType == typeof(decimal))
                        {
                            row[key] = Convert.ToDecimal(value);
                        }
                        else if (quotesTable.Columns[key].DataType == typeof(DateTime))
                        {
                            row[key] = DateTime.ParseExact(value, "HHmmssfff", CultureInfo.InvariantCulture);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Exception");
                }
            }
        }

        ConnectionMultiplexer conn;
    }
}
