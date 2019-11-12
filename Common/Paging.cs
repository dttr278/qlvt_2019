using System;
using System.Data;
using System.Data.SqlClient;


namespace WpfApp2
{
    class Paging
    {
        public int currentIndex = 0;
        int pageSize;
        string tableName;
        string orderSQL;
        public int totalPage;
        SqlConnection connection;
        SqlDataAdapter adapter;
        public Paging(SqlConnection connection, int pageSize, string tableName, string order)
        {
            this.connection = connection;
            this.tableName = tableName;
            this.pageSize = pageSize;
            orderSQL = "SELECT * FROM " + tableName + " ORDER BY " + order;
            adapter = new SqlDataAdapter(orderSQL, connection);

            try
            {
                connection.Open();
            }
            catch (Exception ex) { }
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM " + tableName, connection);
            Int32 count = (Int32)comm.ExecuteScalar();
            totalPage = count / pageSize;
            if (count % pageSize > 0) totalPage++;
            totalPage--;

        }
        public DataTable getPage(int current)
        {
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM " + tableName, connection);
            Int32 count = (Int32)comm.ExecuteScalar();
            totalPage = count / pageSize;
            if (count % pageSize > 0) totalPage++;
            totalPage--;
            if (current > totalPage && current < 1) return null;
            DataSet dataSet = Common.DataSet;
            if (dataSet.Tables[tableName] != null)
                dataSet.Tables[tableName].Rows.Clear();
            currentIndex = current;
            adapter.Fill(dataSet, currentIndex, pageSize, tableName);
            return dataSet.Tables[tableName];
        }
    }
}
