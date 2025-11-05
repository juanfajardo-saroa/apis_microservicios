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
     /// Clase Abstracta para  SubTiposRegistroMercantil
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SubTiposRegistroMercantilRepository : DataObject , ISubTiposRegistroMercantil 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SubTiposRegistroMercantilRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SubTiposRegistroMercantilRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public SubTiposRegistroMercantil GetById(SubTiposRegistroMercantil pSubTiposRegistroMercantil)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSubTiposRegistroMercantil.id);                                    


    				SubTiposRegistroMercantil o = SqlMapper.QueryFirstOrDefault<SubTiposRegistroMercantil>(con, "API.PA_SubTiposRegistroMercantilGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  SubTiposRegistroMercantil  ->" + ex.Message);
				}
			}

			public List<SubTiposRegistroMercantil> GetAll()
			{
				try 
                {
                        List<SubTiposRegistroMercantil> l = SqlMapper.Query<SubTiposRegistroMercantil>(con, "API.PA_SubTiposRegistroMercantilGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  SubTiposRegistroMercantil  ->" + ex.Message);
				}
			}

			public List<SubTiposRegistroMercantil> GetAllFull()
			{
				try 
				{
                    List<SubTiposRegistroMercantil> l = SqlMapper.Query<SubTiposRegistroMercantil>(con, "API.PA_SubTiposRegistroMercantilGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  SubTiposRegistroMercantil  ->" + ex.Message);
				}
			}
			
			public List<SubTiposRegistroMercantil> GetAllByWithRelation()
			{
				try 
                {
                    List<SubTiposRegistroMercantil> l = SqlMapper.Query<SubTiposRegistroMercantil>(con, "API.PA_SubTiposRegistroMercantilGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  SubTiposRegistroMercantil  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<SubTiposRegistroMercantil> GetByFilter(SubTiposRegistroMercantil pSubTiposRegistroMercantil, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSubTiposRegistroMercantil.id== null || pSubTiposRegistroMercantil.id==0) ? vintNUll :pSubTiposRegistroMercantil.id);
                    p.Add("@ID_TipoRegistroMercantil",(pSubTiposRegistroMercantil.ID_TipoRegistroMercantil== null || pSubTiposRegistroMercantil.ID_TipoRegistroMercantil==0) ? vintNUll :pSubTiposRegistroMercantil.ID_TipoRegistroMercantil);
                    p.Add("@Nombre",(pSubTiposRegistroMercantil.Nombre== null) ? vintNUll :pSubTiposRegistroMercantil.Nombre);
                    p.Add("@CodigoCHIP",(pSubTiposRegistroMercantil.CodigoCHIP== null) ? vintNUll :pSubTiposRegistroMercantil.CodigoCHIP);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<SubTiposRegistroMercantil> l = SqlMapper.Query<SubTiposRegistroMercantil>(con, "API.PA_SubTiposRegistroMercantilGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  SubTiposRegistroMercantil  ->" + ex.Message);
				}
			}

			public SubTiposRegistroMercantil Add(SubTiposRegistroMercantil pSubTiposRegistroMercantil)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSubTiposRegistroMercantil.id==null ? 0 : pSubTiposRegistroMercantil.id);
p.Add("@ID_TipoRegistroMercantil",pSubTiposRegistroMercantil.ID_TipoRegistroMercantil==null ? 0 : pSubTiposRegistroMercantil.ID_TipoRegistroMercantil);
                    p.Add("@Nombre", pSubTiposRegistroMercantil.Nombre);
p.Add("@CodigoCHIP",pSubTiposRegistroMercantil.CodigoCHIP==null ? 0 : pSubTiposRegistroMercantil.CodigoCHIP);
                    p.Add("@auditoria", pSubTiposRegistroMercantil.auditoria);

                         


                    SubTiposRegistroMercantil o = SqlMapper.QueryFirstOrDefault<SubTiposRegistroMercantil>(con, "API.PA_SubTiposRegistroMercantilAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  SubTiposRegistroMercantil  ->" + ex.Message);
				}
			}

			public SubTiposRegistroMercantil  Update(SubTiposRegistroMercantil pSubTiposRegistroMercantil)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSubTiposRegistroMercantil.id==null ? 0 : pSubTiposRegistroMercantil.id);
p.Add("@ID_TipoRegistroMercantil",pSubTiposRegistroMercantil.ID_TipoRegistroMercantil==null ? 0 : pSubTiposRegistroMercantil.ID_TipoRegistroMercantil);
                    p.Add("@Nombre", pSubTiposRegistroMercantil.Nombre);
p.Add("@CodigoCHIP",pSubTiposRegistroMercantil.CodigoCHIP==null ? 0 : pSubTiposRegistroMercantil.CodigoCHIP);
                    p.Add("@auditoria", pSubTiposRegistroMercantil.auditoria);

                         


                    SubTiposRegistroMercantil o = SqlMapper.QueryFirstOrDefault<SubTiposRegistroMercantil>(con, "API.PA_SubTiposRegistroMercantilUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  SubTiposRegistroMercantil  ->" + ex.Message);
				}
			}

			public bool Delete(SubTiposRegistroMercantil pSubTiposRegistroMercantil)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSubTiposRegistroMercantil.id);
                    p.Add("@auditoria", pSubTiposRegistroMercantil.auditoria);

                

 

					SubTiposRegistroMercantil o = SqlMapper.QueryFirstOrDefault<SubTiposRegistroMercantil>(con, "API.PA_SubTiposRegistroMercantilDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) SubTiposRegistroMercantil  ->" + ex.Message);
				}
			}

		



            public List<SubTiposRegistroMercantil> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<SubTiposRegistroMercantil> SubTiposRegistroMercantilList = new List<SubTiposRegistroMercantil>();

                    SubTiposRegistroMercantilList = SqlMapper.Query<SubTiposRegistroMercantil>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SubTiposRegistroMercantilList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) SubTiposRegistroMercantil  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<SubTiposRegistroMercantil> b)
            {
                DapperPlusManager.Entity<SubTiposRegistroMercantil>().Table("SubTiposRegistroMercantil");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}