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
    public class UTPlantaBodegasServiceFake : IPlantaBodegasService
    {
    
        private readonly SISPAE.DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;

        public UTPlantaBodegasServiceFake()
        {
            _dataSource = new SISPAE.DataAccess.DataMapper.DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PlantaBodegas> GetAll()
        {
            return (IEnumerable<PlantaBodegas>)new PlantaBodegasMs().GetAll().Cast<PlantaBodegas>();
        }

        public IEnumerable<PlantaBodegas> GetAllFull()
        {
            return(IEnumerable<PlantaBodegas>)new PlantaBodegasMs().GetAllFull().Cast<PlantaBodegas>();
        }

        public IEnumerable<PlantaBodegas> GetAllRelation()
        {
            return(IEnumerable<PlantaBodegas>)new PlantaBodegasMs().GetAllByWithRelation().Cast<PlantaBodegas>();
        }

        public PlantaBodegas GetById(int id)
        {
            return (PlantaBodegas)new PlantaBodegasMs().GetById(new PlantaBodegas(){id=id});
        }

        public ObjectResult LoadTable(DtParameters dtParameters)
        {
            throw new NotImplementedException();
        }

        public PlantaBodegas Post(PlantaBodegas obj)
        {
            throw new NotImplementedException();
        }

        public PlantaBodegas Put(PlantaBodegas obj)
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
