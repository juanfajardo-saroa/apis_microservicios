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
    public class UTPlanAlistamientoServiceFake : IPlanAlistamientoService
    {
    
        private readonly SISPAE.DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;

        public UTPlanAlistamientoServiceFake()
        {
            _dataSource = new SISPAE.DataAccess.DataMapper.DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PlanAlistamiento> GetAll()
        {
            return (IEnumerable<PlanAlistamiento>)new PlanAlistamientoMs().GetAll().Cast<PlanAlistamiento>();
        }

        public IEnumerable<PlanAlistamiento> GetAllFull()
        {
            return(IEnumerable<PlanAlistamiento>)new PlanAlistamientoMs().GetAllFull().Cast<PlanAlistamiento>();
        }

        public IEnumerable<PlanAlistamiento> GetAllRelation()
        {
            return(IEnumerable<PlanAlistamiento>)new PlanAlistamientoMs().GetAllByWithRelation().Cast<PlanAlistamiento>();
        }

        public PlanAlistamiento GetById(int id)
        {
            return (PlanAlistamiento)new PlanAlistamientoMs().GetById(new PlanAlistamiento(){ID=id});
        }

        public ObjectResult LoadTable(DtParameters dtParameters)
        {
            throw new NotImplementedException();
        }

        public PlanAlistamiento Post(PlanAlistamiento obj)
        {
            throw new NotImplementedException();
        }

        public PlanAlistamiento Put(PlanAlistamiento obj)
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
