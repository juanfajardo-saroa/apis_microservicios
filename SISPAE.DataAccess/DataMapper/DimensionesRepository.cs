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
     /// Clase Abstracta para  Dimensiones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DimensionesRepository : DataObject , IDimensiones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DimensionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DimensionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Dimensiones GetById(Dimensiones pDimensiones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDimensiones.id);                                    


    				Dimensiones o = SqlMapper.QueryFirstOrDefault<Dimensiones>(con, "API.PA_DimensionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Dimensiones  ->" + ex.Message);
				}
			}

			public List<Dimensiones> GetAll()
			{
				try 
                {
                        List<Dimensiones> l = SqlMapper.Query<Dimensiones>(con, "API.PA_DimensionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Dimensiones  ->" + ex.Message);
				}
			}

			public List<Dimensiones> GetAllFull()
			{
				try 
				{
                    List<Dimensiones> l = SqlMapper.Query<Dimensiones>(con, "API.PA_DimensionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Dimensiones  ->" + ex.Message);
				}
			}
			
			public List<Dimensiones> GetAllByWithRelation()
			{
				try 
                {
                    List<Dimensiones> l = SqlMapper.Query<Dimensiones>(con, "API.PA_DimensionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Dimensiones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Dimensiones> GetByFilter(Dimensiones pDimensiones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDimensiones.id== null || pDimensiones.id==0) ? vintNUll :pDimensiones.id);
                    p.Add("@Nombre",(pDimensiones.Nombre== null) ? vintNUll :pDimensiones.Nombre);
                    p.Add("@icono",(pDimensiones.icono== null) ? vintNUll :pDimensiones.icono);
                    p.Add("@PonderacionRps",(pDimensiones.PonderacionRps== null) ? vintNUll :pDimensiones.PonderacionRps);
                    p.Add("@PonderacionRi",(pDimensiones.PonderacionRi== null) ? vintNUll :pDimensiones.PonderacionRi);
                    p.Add("@PonderacionCatering",(pDimensiones.PonderacionCatering== null) ? vintNUll :pDimensiones.PonderacionCatering);
                    p.Add("@Orden",(pDimensiones.Orden== null) ? vintNUll :pDimensiones.Orden);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Dimensiones> l = SqlMapper.Query<Dimensiones>(con, "API.PA_DimensionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Dimensiones  ->" + ex.Message);
				}
			}

			public Dimensiones Add(Dimensiones pDimensiones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDimensiones.id==null ? 0 : pDimensiones.id);
                    p.Add("@Nombre", pDimensiones.Nombre);
                    p.Add("@icono", pDimensiones.icono);
                    p.Add("@PonderacionRps", pDimensiones.PonderacionRps);
                    p.Add("@PonderacionRi", pDimensiones.PonderacionRi);
                    p.Add("@PonderacionCatering", pDimensiones.PonderacionCatering);
p.Add("@Orden",pDimensiones.Orden==null ? 0 : pDimensiones.Orden);
                    p.Add("@auditoria", pDimensiones.auditoria);

                         


                    Dimensiones o = SqlMapper.QueryFirstOrDefault<Dimensiones>(con, "API.PA_DimensionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Dimensiones  ->" + ex.Message);
				}
			}

			public Dimensiones  Update(Dimensiones pDimensiones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDimensiones.id==null ? 0 : pDimensiones.id);
                    p.Add("@Nombre", pDimensiones.Nombre);
                    p.Add("@icono", pDimensiones.icono);
                    p.Add("@PonderacionRps", pDimensiones.PonderacionRps);
                    p.Add("@PonderacionRi", pDimensiones.PonderacionRi);
                    p.Add("@PonderacionCatering", pDimensiones.PonderacionCatering);
p.Add("@Orden",pDimensiones.Orden==null ? 0 : pDimensiones.Orden);
                    p.Add("@auditoria", pDimensiones.auditoria);

                         


                    Dimensiones o = SqlMapper.QueryFirstOrDefault<Dimensiones>(con, "API.PA_DimensionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Dimensiones  ->" + ex.Message);
				}
			}

			public bool Delete(Dimensiones pDimensiones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDimensiones.id);
                    p.Add("@auditoria", pDimensiones.auditoria);

                

 

					Dimensiones o = SqlMapper.QueryFirstOrDefault<Dimensiones>(con, "API.PA_DimensionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Dimensiones  ->" + ex.Message);
				}
			}

		



            public List<Dimensiones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Dimensiones> DimensionesList = new List<Dimensiones>();

                    DimensionesList = SqlMapper.Query<Dimensiones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DimensionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Dimensiones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Dimensiones> b)
            {
                DapperPlusManager.Entity<Dimensiones>().Table("Dimensiones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}