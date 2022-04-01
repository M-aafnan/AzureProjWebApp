using PracADOWeb.Models.DAL.IRepositories;
using PracADOWeb.Models.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracADOWeb.Models.DAL
{
    public class DBFactory
    {
        public enum DBName { ADO,Entity,AzureTBL};

        public static ISupplierRepository GetDatabase(DBName dbName)
        {
            switch (dbName)
            {
                case DBName.ADO:
                    return new SupplierRepository();
                    break;

                case DBName.Entity:
                    return new EntitySupplierRepository();
                    break;

                case DBName.AzureTBL:
                    return new AzureTBL_SupplierRepository();
                    break;
                default:
                    return null;
                    break;
            }
        }
    }
}