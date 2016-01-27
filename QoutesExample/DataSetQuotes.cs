using StackExchange.Redis;
using System.Data;
using System;
using System.Windows.Forms;
using System.Globalization;

namespace QuotesExample
{
    partial class DataSetQuotes
    {
        partial class QuotesDataTable
        {
            void InitializeData()
            {
                conn = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                ISubscriber sub = conn.GetSubscriber();
                sub.Subscribe("SR605", new Action<RedisChannel, RedisValue>(DoSomeThing));
            }

            private void DoSomeThing(RedisChannel channel, RedisValue message)
            {
                DataRow row;
                row = this.Rows.Find(channel.ToString());
                if (row == null)
                {
                    row = this.NewRow();
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
                            if (this.Columns[key].DataType == typeof(String))
                            {
                                row[key] = value;
                            }
                            else if (this.Columns[key].DataType == typeof(decimal))
                            {
                                row[key] = Convert.ToDecimal(value);
                            }
                        }

                        this.Rows.Add(row);


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
                            if (this.Columns[key].DataType == typeof(String))
                            {
                                row[key] = value;
                            }
                            else if (this.Columns[key].DataType == typeof(decimal))
                            {
                                row[key] = Convert.ToDecimal(value);
                            }
                            else if (this.Columns[key].DataType == typeof(DateTime))
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
}

