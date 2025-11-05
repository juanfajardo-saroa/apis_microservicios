/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, UnitTest
/// Capa			:Capa Servicios Fake de  Pruebas Unitarias para SISPAE    
/// </Derechos_Reservados>
/// 
/// 
/// 

using Dapper;
using Microsoft.AspNetCore.Mvc;
using SISPAE.Business;
using SISPAE.Model;
using SISPAE.Tests.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



 
namespace SISPAE.Tests.Services
{
    public class UTETCDivipolaServiceFake : IETCDivipolaService
    {
    
        private readonly SISPAE.DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;

        public UTETCDivipolaServiceFake()
        {
            _dataSource = new SISPAE.DataAccess.DataMapper.DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ETCDivipola> GetAll()
        {
            return (IEnumerable<ETCDivipola>)new ETCDivipolaMs().GetAll().Cast<ETCDivipola>();
        }

        public IEnumerable<ETCDivipola> GetAllFull()
        {
            return(IEnumerable<ETCDivipola>)new ETCDivipolaMs().GetAllFull().Cast<ETCDivipola>();
        }

        public IEnumerable<ETCDivipola> GetAllRelation()
        {
            return(IEnumerable<ETCDivipola>)new ETCDivipolaMs().GetAllByWithRelation().Cast<ETCDivipola>();
        }

        public ETCDivipola GetById(int id)
        {
            return (ETCDivipola)new ETCDivipolaMs().GetById(new ETCDivipola(){id=id});
        }

        public ObjectResult LoadTable(DtParameters dtParameters)
        {
            throw new NotImplementedException();
        }

        public ETCDivipola Post(ETCDivipola obj)
        {
            throw new NotImplementedException();
        }

        public ETCDivipola Put(ETCDivipola obj)
        {
            throw new NotImplementedException();
        }


        public bool ValidateForeignKey(string table)
        {

            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Catalogo", table);

                var  o = SqlMapper.Query(con, "dbo.GetForeignKeyTables", p, commandType: CommandType.StoredProcedure);

                if (o.ToList().Count() > 0)
                    return true;

                return false;

            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(ValidateForeignKey) ->" + ex.Message + ex);
            }


        }
    }
}
