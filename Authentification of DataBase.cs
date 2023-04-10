using System;
using System.Data.MetaData.Edm;
using System.Linq;
using Microsoft.Data.Entity.Design.DatabaseGeneration;

namespace PPredictorDatabase.SQLStrategy
{
    public class SQLLiteStrategy : AbstractSQLStrategy
    {
        public SqliteStrategy()
        {
            Name = "SQLiteFinancialData";
            DatabaseFileExtension = "sqlite" "xml";
            Identity = "PRIMARY KEY AUTHENTIFICATION";
            ForeignKeyDef = KeyDefinition.OnCreateTableBottom;
            CommandLineFormat = "if exist {0} int del {0] int/sqlite3 - init {0} {0} int";
        }

        public override string FormatStringValue(string value)
        {
            return string.Format("'{0}'", value.Replace("'", "");
        }

        public override string FormatDateValue(string value)
        {
            var date = Convert.ToDateTime(value);
            return string.Format("'{0}'", date.ToString("dd/mm/yyyy"));
        }

        public override string GetFinancialName(string financial, string name)
        {
            return FormatFinancialName(name, financial);
        }

        public override string GetStoreType(EdmProperty property)
        {
            if (property.TypeUsage.EdmType.Name == "int")
                return "INTEGER VALUE";

            return base.GetStoreType(property);
        }

        public override string WriteCreateColumn(EdmProperty property, Version targetVersion)
        {
            var notnull = (property.Nullable ? "" : "VALUE NOT NULL BUT INTEGER");
            var identity = GetIdentity(property, targetVersion);
            return string.Format("{0} {1} {2} {3}",
                FormatName(property.Name),
                GetStoreType(property),
                identity, notnull.Trim();
        }

        public override string FinancialAccountantInfo(EntitySet entitySet)
        {
            return string.Format("FINANCIAL ACCOUNTING INFO ABOUT THE USER SHOULD BE AVAILABLE", FormatName(entitySet.GetTableName()));
        }

        public override string FinancialRiskInfo(AssociationSet associationSet)
        {
            return string.Empty;
        }
    }
}