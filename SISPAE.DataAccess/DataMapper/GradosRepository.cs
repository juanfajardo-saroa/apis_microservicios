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
     /// Clase Abstracta para  Grados
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class GradosRepository : DataObject , IGrados 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public GradosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public GradosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Grados GetById(Grados pGrados)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pGrados.id);                                    


    				Grados o = SqlMapper.QueryFirstOrDefault<Grados>(con, "API.PA_GradosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Grados  ->" + ex.Message);
				}
			}

			public List<Grados> GetAll()
			{
				try 
                {
                        List<Grados> l = SqlMapper.Query<Grados>(con, "API.PA_GradosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Grados  ->" + ex.Message);
				}
			}

			public List<Grados> GetAllFull()
			{
				try 
				{
                    List<Grados> l = SqlMapper.Query<Grados>(con, "API.PA_GradosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Grados  ->" + ex.Message);
				}
			}
			
			public List<Grados> GetAllByWithRelation()
			{
				try 
                {
                    List<Grados> l = SqlMapper.Query<Grados>(con, "API.PA_GradosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Grados  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Grados> GetByFilter(Grados pGrados, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pGrados.id== null || pGrados.id==0) ? vintNUll :pGrados.id);
                    p.Add("@ID_TipoGrupoEtario",(pGrados.ID_TipoGrupoEtario== null || pGrados.ID_TipoGrupoEtario==0) ? vintNUll :pGrados.ID_TipoGrupoEtario);
                    p.Add("@ID_NivelEducativo",(pGrados.ID_NivelEducativo== null || pGrados.ID_NivelEducativo==0) ? vintNUll :pGrados.ID_NivelEducativo);
                    p.Add("@Nombre",(pGrados.Nombre== null) ? vintNUll :pGrados.Nombre);
                    p.Add("@idGrado",(pGrados.idGrado== null || pGrados.idGrado==0) ? vintNUll :pGrados.idGrado);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Grados> l = SqlMapper.Query<Grados>(con, "API.PA_GradosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Grados  ->" + ex.Message);
				}
			}

			public Grados Add(Grados pGrados)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pGrados.id==null ? 0 : pGrados.id);
p.Add("@ID_TipoGrupoEtario",pGrados.ID_TipoGrupoEtario==null ? 0 : pGrados.ID_TipoGrupoEtario);
p.Add("@ID_NivelEducativo",pGrados.ID_NivelEducativo==null ? 0 : pGrados.ID_NivelEducativo);
                    p.Add("@Nombre", pGrados.Nombre);
p.Add("@idGrado",pGrados.idGrado== null ? 0: pGrados.idGrado);
                    p.Add("@auditoria", pGrados.auditoria);

                         


                    Grados o = SqlMapper.QueryFirstOrDefault<Grados>(con, "API.PA_GradosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Grados  ->" + ex.Message);
				}
			}

			public Grados  Update(Grados pGrados)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pGrados.id==null ? 0 : pGrados.id);
p.Add("@ID_TipoGrupoEtario",pGrados.ID_TipoGrupoEtario==null ? 0 : pGrados.ID_TipoGrupoEtario);
p.Add("@ID_NivelEducativo",pGrados.ID_NivelEducativo==null ? 0 : pGrados.ID_NivelEducativo);
                    p.Add("@Nombre", pGrados.Nombre);
p.Add("@idGrado",pGrados.idGrado== null ? 0: pGrados.idGrado);
                    p.Add("@auditoria", pGrados.auditoria);

                         


                    Grados o = SqlMapper.QueryFirstOrDefault<Grados>(con, "API.PA_GradosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Grados  ->" + ex.Message);
				}
			}

			public bool Delete(Grados pGrados)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pGrados.id);
                    p.Add("@auditoria", pGrados.auditoria);

                

 

					Grados o = SqlMapper.QueryFirstOrDefault<Grados>(con, "API.PA_GradosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Grados  ->" + ex.Message);
				}
			}

		



            public List<Grados> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Grados> GradosList = new List<Grados>();

                    GradosList = SqlMapper.Query<Grados>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return GradosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Grados  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Grados> b)
            {
                DapperPlusManager.Entity<Grados>().Table("Grados");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}