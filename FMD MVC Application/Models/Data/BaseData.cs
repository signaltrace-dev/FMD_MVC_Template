using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FMD.Data.Oracle;

namespace $safeprojectname$.Models.Data
{
    public class BaseData
    {
        private OracleDB aimDb;
        private OracleDB db;
        private OracleDB userDb;

        public OracleDB AIMDB {
            get {
                return this.aimDb;
            }
        }

        public OracleDB DB {
            get {
                return this.db;
            }
        }

        public OracleDB UserDB {
            get { return this.userDb; }
        }

        public BaseData() {
            aimDb = new OracleDB(OracleDB.DBInstance.AIMTest);
            db = new OracleDB(OracleDB.DBInstance.AIMProductionReadOnly);
            userDb = new OracleDB(OracleDB.DBInstance.Xerxes);
        }
    }

}