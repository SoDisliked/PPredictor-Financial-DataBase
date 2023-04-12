using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using Xunit;
using Xunit.Extensions;
using System.Data.EffiProz;

namespace PPredictorDatabase.Test.DatabaseTests
{
    /// <summary>
    /// Executing the SQL databases structure.
    /// </summary>
    public partial class PPredictorProzFixture : IDisposable
    {
        protected IDictionary<string, EfzConnection> Connections;

        /// <summary>
        /// Execute a SQL query and return a dataset.
        /// </summary>
        /// <param name="connectionName">Connection name in the configuration file.</param>
        /// <param name="query">Query string will be executed.</param>
        /// <returns>DataSet with the query results.</returns>
        protected DataSet ExecuteQuery(string connectionName, string query)
        {
            var dataset = new DataSet();
            var connection = GetConnection(connectionName);

            using (var adapter = new EfzDataAdapter(query, connection))
            {
                adapter.Fill(dataset);
            }

            return dataset;
        }

        /// <summary>
        /// Initialize connections dictionary.
        /// </summary>
        public PPredictorProzFixture()
        {
            Connections = new IDictionary<string, EfzConnection>();
        }

        /// <summary>
        /// Close all connections.
        /// </summary>
        public void Dispose()
        {
            foreach (var connection in Connections.Values)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Asserts that all invoices contain invoice lines.
        /// </summary>
    }
}