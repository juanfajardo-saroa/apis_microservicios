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
    public class UTTiposModeloOperacionServiceFake : ITiposModeloOperacionService
    {
    
        private readonly SISPAE.DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;

        public UTTiposModeloOperacionServiceFake()
        {
            _dataSource = new SISPAE.DataAccess.DataMapper.DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TiposModeloOperacion> GetAll()
        {
            return (IEnumerable<TiposModeloOperacion>)new TiposModeloOperacionMs().GetAll().Cast<TiposModeloOperacion>();
        }

        public IEnumerable<TiposModeloOperacion> GetAllFull()
        {
            return(IEnumerable<TiposModeloOperacion>)new TiposModeloOperacionMs().GetAllFull().Cast<TiposModeloOperacion>();
        }

        public IEnumerable<TiposModeloOperacion> GetAllRelation()
        {
            return(IEnumerable<TiposModeloOperacion>)new TiposModeloOperacionMs().GetAllByWithRelation().Cast<TiposModeloOperacion>();
        }

        public TiposModeloOperacion GetById(int id)
        {
            return (TiposModeloOperacion)new TiposModeloOperacionMs().GetById(new TiposModeloOperacion(){id=id});
        }

        public ObjectResult LoadTable(DtParameters dtParameters)
        {
            throw new NotImplementedException();
        }

        public TiposModeloOperacion Post(TiposModeloOperacion obj)
        {
            throw new NotImplementedException();
        }

        public TiposModeloOperacion Put(TiposModeloOperacion obj)
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
