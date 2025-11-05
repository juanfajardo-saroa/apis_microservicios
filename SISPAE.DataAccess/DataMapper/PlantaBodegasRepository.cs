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
     /// Clase Abstracta para  PlantaBodegas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PlantaBodegasRepository : DataObject , IPlantaBodegas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PlantaBodegasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PlantaBodegasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public PlantaBodegas GetById(PlantaBodegas pPlantaBodegas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPlantaBodegas.id);                                    


    				PlantaBodegas o = SqlMapper.QueryFirstOrDefault<PlantaBodegas>(con, "API.PA_PlantaBodegasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  PlantaBodegas  ->" + ex.Message);
				}
			}

			public List<PlantaBodegas> GetAll()
			{
				try 
                {
                        List<PlantaBodegas> l = SqlMapper.Query<PlantaBodegas>(con, "API.PA_PlantaBodegasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  PlantaBodegas  ->" + ex.Message);
				}
			}

			public List<PlantaBodegas> GetAllFull()
			{
				try 
				{
                    List<PlantaBodegas> l = SqlMapper.Query<PlantaBodegas>(con, "API.PA_PlantaBodegasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  PlantaBodegas  ->" + ex.Message);
				}
			}
			
			public List<PlantaBodegas> GetAllByWithRelation()
			{
				try 
                {
                    List<PlantaBodegas> l = SqlMapper.Query<PlantaBodegas>(con, "API.PA_PlantaBodegasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  PlantaBodegas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<PlantaBodegas> GetByFilter(PlantaBodegas pPlantaBodegas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPlantaBodegas.id== null || pPlantaBodegas.id==0) ? vintNUll :pPlantaBodegas.id);
                    p.Add("@ID_TipoPlantaBodega",(pPlantaBodegas.ID_TipoPlantaBodega== null || pPlantaBodegas.ID_TipoPlantaBodega==0) ? vintNUll :pPlantaBodegas.ID_TipoPlantaBodega);
                    p.Add("@ID_PlanAlistamiento",(pPlantaBodegas.ID_PlanAlistamiento== null || pPlantaBodegas.ID_PlanAlistamiento==0) ? vintNUll :pPlantaBodegas.ID_PlanAlistamiento);
                    p.Add("@ID_Divipola",(pPlantaBodegas.ID_Divipola== null || pPlantaBodegas.ID_Divipola==0) ? vintNUll :pPlantaBodegas.ID_Divipola);
                    p.Add("@ID_EstadoPlantaBodega",(pPlantaBodegas.ID_EstadoPlantaBodega== null || pPlantaBodegas.ID_EstadoPlantaBodega==0) ? vintNUll :pPlantaBodegas.ID_EstadoPlantaBodega);
                    p.Add("@Nombre",(pPlantaBodegas.Nombre== null) ? vintNUll :pPlantaBodegas.Nombre);
                    p.Add("@Direccion",(pPlantaBodegas.Direccion== null) ? vintNUll :pPlantaBodegas.Direccion);
                    p.Add("@Celular",(pPlantaBodegas.Celular== null) ? vintNUll :pPlantaBodegas.Celular);
                    p.Add("@NombreContacto",(pPlantaBodegas.NombreContacto== null) ? vintNUll :pPlantaBodegas.NombreContacto);
                    p.Add("@ApellidoContacto",(pPlantaBodegas.ApellidoContacto== null) ? vintNUll :pPlantaBodegas.ApellidoContacto);
                    p.Add("@Correo",(pPlantaBodegas.Correo== null) ? vintNUll :pPlantaBodegas.Correo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<PlantaBodegas> l = SqlMapper.Query<PlantaBodegas>(con, "API.PA_PlantaBodegasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  PlantaBodegas  ->" + ex.Message);
				}
			}

			public PlantaBodegas Add(PlantaBodegas pPlantaBodegas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPlantaBodegas.id==null ? 0 : pPlantaBodegas.id);
p.Add("@ID_TipoPlantaBodega",pPlantaBodegas.ID_TipoPlantaBodega==null ? 0 : pPlantaBodegas.ID_TipoPlantaBodega);
p.Add("@ID_PlanAlistamiento",pPlantaBodegas.ID_PlanAlistamiento==null ? 0 : pPlantaBodegas.ID_PlanAlistamiento);
p.Add("@ID_Divipola",pPlantaBodegas.ID_Divipola==null ? 0 : pPlantaBodegas.ID_Divipola);
p.Add("@ID_EstadoPlantaBodega",pPlantaBodegas.ID_EstadoPlantaBodega==null ? 0 : pPlantaBodegas.ID_EstadoPlantaBodega);
                    p.Add("@Nombre", pPlantaBodegas.Nombre);
                    p.Add("@Direccion", pPlantaBodegas.Direccion);
                    p.Add("@Celular", pPlantaBodegas.Celular);
                    p.Add("@NombreContacto", pPlantaBodegas.NombreContacto);
                    p.Add("@ApellidoContacto", pPlantaBodegas.ApellidoContacto);
                    p.Add("@Correo", pPlantaBodegas.Correo);
                    p.Add("@auditoria", pPlantaBodegas.auditoria);

                         


                    PlantaBodegas o = SqlMapper.QueryFirstOrDefault<PlantaBodegas>(con, "API.PA_PlantaBodegasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  PlantaBodegas  ->" + ex.Message);
				}
			}

			public PlantaBodegas  Update(PlantaBodegas pPlantaBodegas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPlantaBodegas.id==null ? 0 : pPlantaBodegas.id);
p.Add("@ID_TipoPlantaBodega",pPlantaBodegas.ID_TipoPlantaBodega==null ? 0 : pPlantaBodegas.ID_TipoPlantaBodega);
p.Add("@ID_PlanAlistamiento",pPlantaBodegas.ID_PlanAlistamiento==null ? 0 : pPlantaBodegas.ID_PlanAlistamiento);
p.Add("@ID_Divipola",pPlantaBodegas.ID_Divipola==null ? 0 : pPlantaBodegas.ID_Divipola);
p.Add("@ID_EstadoPlantaBodega",pPlantaBodegas.ID_EstadoPlantaBodega==null ? 0 : pPlantaBodegas.ID_EstadoPlantaBodega);
                    p.Add("@Nombre", pPlantaBodegas.Nombre);
                    p.Add("@Direccion", pPlantaBodegas.Direccion);
                    p.Add("@Celular", pPlantaBodegas.Celular);
                    p.Add("@NombreContacto", pPlantaBodegas.NombreContacto);
                    p.Add("@ApellidoContacto", pPlantaBodegas.ApellidoContacto);
                    p.Add("@Correo", pPlantaBodegas.Correo);
                    p.Add("@auditoria", pPlantaBodegas.auditoria);

                         


                    PlantaBodegas o = SqlMapper.QueryFirstOrDefault<PlantaBodegas>(con, "API.PA_PlantaBodegasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  PlantaBodegas  ->" + ex.Message);
				}
			}

			public bool Delete(PlantaBodegas pPlantaBodegas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPlantaBodegas.id);
                    p.Add("@auditoria", pPlantaBodegas.auditoria);

                

 

					PlantaBodegas o = SqlMapper.QueryFirstOrDefault<PlantaBodegas>(con, "API.PA_PlantaBodegasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) PlantaBodegas  ->" + ex.Message);
				}
			}

		



            public List<PlantaBodegas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<PlantaBodegas> PlantaBodegasList = new List<PlantaBodegas>();

                    PlantaBodegasList = SqlMapper.Query<PlantaBodegas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PlantaBodegasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) PlantaBodegas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<PlantaBodegas> b)
            {
                DapperPlusManager.Entity<PlantaBodegas>().Table("PlantaBodegas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}