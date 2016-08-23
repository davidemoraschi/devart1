using System;
using Devart.Data.Oracle;

namespace devart1
{
    class Program
    {
        static void Main(string[] args)
        {
            //OracleConnection oracleConnection1 = new OracleConnection();
            //oracleConnection1.Server = "DESARROLLO";
            //oracleConnection1.UserId = "scott";
            //oracleConnection1.Password = "tiger";

            OracleConnectionStringBuilder oraCSB = new OracleConnectionStringBuilder();
            oraCSB.Direct = true;
            oraCSB.Server = "192.168.0.1";
            oraCSB.Port = 1251;
            oraCSB.Sid = "OracleSid";
            oraCSB.UserId = "scott";
            oraCSB.Password = "tiger";
            oraCSB.MaxPoolSize = 150;
            oraCSB.ConnectionTimeout = 30;
            OracleConnection myConnection = new OracleConnection(oraCSB.ConnectionString);


        }
    }
}
