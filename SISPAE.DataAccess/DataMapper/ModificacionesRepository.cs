/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:DataAccess (DataAccess Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_DAL_DataMapperBase.Cs)   clase 
/// </Derechos_Reservados>


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SISPAE.Model;
using SISPAE.DataAccess.DataInterfaces;
using Dapper;
using static Dapper.SqlMapper;
using Z.Dapper.Plus;



namespace SISPAE.DataAccess.DataMapper
{
     /// <Resumen>
     /// Clase Abstracta para  Modificaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ModificacionesRepository : DataObject , IModificaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ModificacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ModificacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Modificaciones GetById(Modificaciones pModificaciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pModificaciones.id);                                    


    				Modificaciones o = SqlMapper.QueryFirstOrDefault<Modificaciones>(con, "API.PA_ModificacionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Modificaciones  ->" + ex.Message);
				}
			}

			public List<Modificaciones> GetAll()
			{
				try 
                {
                        List<Modificaciones> l = SqlMapper.Query<Modificaciones>(con, "API.PA_ModificacionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Modificaciones  ->" + ex.Message);
				}
			}

			public List<Modificaciones> GetAllFull()
			{
				try 
				{
                    List<Modificaciones> l = SqlMapper.Query<Modificaciones>(con, "API.PA_ModificacionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Modificaciones  ->" + ex.Message);
				}
			}
			
			public List<Modificaciones> GetAllByWithRelation()
			{
				try 
                {
                    List<Modificaciones> l = SqlMapper.Query<Modificaciones>(con, "API.PA_ModificacionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Modificaciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Modificaciones> GetByFilter(Modificaciones pModificaciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pModificaciones.id== null || pModificaciones.id==0) ? vintNUll :pModificaciones.id);
                    p.Add("@ID_Contrato",(pModificaciones.ID_Contrato== null || pModificaciones.ID_Contrato==0) ? vintNUll :pModificaciones.ID_Contrato);
                    p.Add("@ID_TipoModificacion",(pModificaciones.ID_TipoModificacion== null || pModificaciones.ID_TipoModificacion==0) ? vintNUll :pModificaciones.ID_TipoModificacion);
                    p.Add("@NumeroDiasProrroga",(pModificaciones.NumeroDiasProrroga== null) ? vintNUll :pModificaciones.NumeroDiasProrroga);
                    p.Add("@FechaTerminacionProrroga",(pModificaciones.FechaTerminacionProrroga== null) ? vintNUll :pModificaciones.FechaTerminacionProrroga);
                    p.Add("@ValorAdicionReduccion",(pModificaciones.ValorAdicionReduccion== null) ? vintNUll :pModificaciones.ValorAdicionReduccion);
                    p.Add("@SoporteModificacionPath",(pModificaciones.SoporteModificacionPath== null) ? vintNUll :pModificaciones.SoporteModificacionPath);
                    p.Add("@Descripcion",(pModificaciones.Descripcion== null) ? vintNUll :pModificaciones.Descripcion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Modificaciones> l = SqlMapper.Query<Modificaciones>(con, "API.PA_ModificacionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Modificaciones  ->" + ex.Message);
				}
			}

			public Modificaciones Add(Modificaciones pModificaciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pModificaciones.id==null ? 0 : pModificaciones.id);
p.Add("@ID_Contrato",pModificaciones.ID_Contrato==null ? 0 : pModificaciones.ID_Contrato);
p.Add("@ID_TipoModificacion",pModificaciones.ID_TipoModificacion==null ? 0 : pModificaciones.ID_TipoModificacion);
p.Add("@NumeroDiasProrroga",pModificaciones.NumeroDiasProrroga==null ? 0 : pModificaciones.NumeroDiasProrroga);
                    p.Add("@FechaTerminacionProrroga", pModificaciones.FechaTerminacionProrroga);
                    p.Add("@ValorAdicionReduccion", pModificaciones.ValorAdicionReduccion);
                    p.Add("@SoporteModificacionPath", pModificaciones.SoporteModificacionPath);
                    p.Add("@Descripcion", pModificaciones.Descripcion);
                    p.Add("@auditoria", pModificaciones.auditoria);

                         


                    Modificaciones o = SqlMapper.QueryFirstOrDefault<Modificaciones>(con, "API.PA_ModificacionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Modificaciones  ->" + ex.Message);
				}
			}

			public Modificaciones  Update(Modificaciones pModificaciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pModificaciones.id==null ? 0 : pModificaciones.id);
p.Add("@ID_Contrato",pModificaciones.ID_Contrato==null ? 0 : pModificaciones.ID_Contrato);
p.Add("@ID_TipoModificacion",pModificaciones.ID_TipoModificacion==null ? 0 : pModificaciones.ID_TipoModificacion);
p.Add("@NumeroDiasProrroga",pModificaciones.NumeroDiasProrroga==null ? 0 : pModificaciones.NumeroDiasProrroga);
                    p.Add("@FechaTerminacionProrroga", pModificaciones.FechaTerminacionProrroga);
                    p.Add("@ValorAdicionReduccion", pModificaciones.ValorAdicionReduccion);
                    p.Add("@SoporteModificacionPath", pModificaciones.SoporteModificacionPath);
                    p.Add("@Descripcion", pModificaciones.Descripcion);
                    p.Add("@auditoria", pModificaciones.auditoria);

                         


                    Modificaciones o = SqlMapper.QueryFirstOrDefault<Modificaciones>(con, "API.PA_ModificacionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Modificaciones  ->" + ex.Message);
				}
			}

			public bool Delete(Modificaciones pModificaciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pModificaciones.id);
                    p.Add("@auditoria", pModificaciones.auditoria);

                

 

					Modificaciones o = SqlMapper.QueryFirstOrDefault<Modificaciones>(con, "API.PA_ModificacionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Modificaciones  ->" + ex.Message);
				}
			}

		



            public List<Modificaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Modificaciones> ModificacionesList = new List<Modificaciones>();

                    ModificacionesList = SqlMapper.Query<Modificaciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ModificacionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Modificaciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Modificaciones> b)
            {
                DapperPlusManager.Entity<Modificaciones>().Table("Modificaciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}