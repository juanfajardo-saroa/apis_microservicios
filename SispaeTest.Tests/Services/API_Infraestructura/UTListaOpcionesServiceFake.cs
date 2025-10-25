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
    public class UTListaOpcionesServiceFake : IListaOpcionesService
    {
    
        private readonly SISPAE.DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;

        public UTListaOpcionesServiceFake()
        {
            _dataSource = new SISPAE.DataAccess.DataMapper.DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ListaOpciones> GetAll()
        {
            return (IEnumerable<ListaOpciones>)new ListaOpcionesMs().GetAll().Cast<ListaOpciones>();
        }

        public IEnumerable<ListaOpciones> GetAllFull()
        {
            return(IEnumerable<ListaOpciones>)new ListaOpcionesMs().GetAllFull().Cast<ListaOpciones>();
        }

        public IEnumerable<ListaOpciones> GetAllRelation()
        {
            return(IEnumerable<ListaOpciones>)new ListaOpcionesMs().GetAllByWithRelation().Cast<ListaOpciones>();
        }

        public ListaOpciones GetById(int id)
        {
            return (ListaOpciones)new ListaOpcionesMs().GetById(new ListaOpciones(){id=id});
        }

        public ObjectResult LoadTable(DtParameters dtParameters)
        {
            throw new NotImplementedException();
        }

        public ListaOpciones Post(ListaOpciones obj)
        {
            throw new NotImplementedException();
        }

        public ListaOpciones Put(ListaOpciones obj)
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
