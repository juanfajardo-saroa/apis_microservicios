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
    public class UTAprobacionesServiceFake : IAprobacionesService
    {
    
        private readonly SISPAE.DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;

        public UTAprobacionesServiceFake()
        {
            _dataSource = new SISPAE.DataAccess.DataMapper.DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aprobaciones> GetAll()
        {
            return (IEnumerable<Aprobaciones>)new AprobacionesMs().GetAll().Cast<Aprobaciones>();
        }

        public IEnumerable<Aprobaciones> GetAllFull()
        {
            return(IEnumerable<Aprobaciones>)new AprobacionesMs().GetAllFull().Cast<Aprobaciones>();
        }

        public IEnumerable<Aprobaciones> GetAllRelation()
        {
            return(IEnumerable<Aprobaciones>)new AprobacionesMs().GetAllByWithRelation().Cast<Aprobaciones>();
        }

        public Aprobaciones GetById(int id)
        {
            return (Aprobaciones)new AprobacionesMs().GetById(new Aprobaciones(){id=id});
        }

        public ObjectResult LoadTable(DtParameters dtParameters)
        {
            throw new NotImplementedException();
        }

        public Aprobaciones Post(Aprobaciones obj)
        {
            throw new NotImplementedException();
        }

        public Aprobaciones Put(Aprobaciones obj)
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
