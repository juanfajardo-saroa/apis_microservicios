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
     /// Clase Abstracta para  SedesBeneficiarias
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SedesBeneficiariasRepository : DataObject , ISedesBeneficiarias 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SedesBeneficiariasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SedesBeneficiariasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public SedesBeneficiarias GetById(SedesBeneficiarias pSedesBeneficiarias)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSedesBeneficiarias.id);                                    


    				SedesBeneficiarias o = SqlMapper.QueryFirstOrDefault<SedesBeneficiarias>(con, "API.PA_SedesBeneficiariasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  SedesBeneficiarias  ->" + ex.Message);
				}
			}

			public List<SedesBeneficiarias> GetAll()
			{
				try 
                {
                        List<SedesBeneficiarias> l = SqlMapper.Query<SedesBeneficiarias>(con, "API.PA_SedesBeneficiariasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  SedesBeneficiarias  ->" + ex.Message);
				}
			}

			public List<SedesBeneficiarias> GetAllFull()
			{
				try 
				{
                    List<SedesBeneficiarias> l = SqlMapper.Query<SedesBeneficiarias>(con, "API.PA_SedesBeneficiariasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  SedesBeneficiarias  ->" + ex.Message);
				}
			}
			
			public List<SedesBeneficiarias> GetAllByWithRelation()
			{
				try 
                {
                    List<SedesBeneficiarias> l = SqlMapper.Query<SedesBeneficiarias>(con, "API.PA_SedesBeneficiariasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  SedesBeneficiarias  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<SedesBeneficiarias> GetByFilter(SedesBeneficiarias pSedesBeneficiarias, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSedesBeneficiarias.id== null || pSedesBeneficiarias.id==0) ? vintNUll :pSedesBeneficiarias.id);
                    p.Add("@ID_SedeJornada",(pSedesBeneficiarias.ID_SedeJornada== null || pSedesBeneficiarias.ID_SedeJornada==0) ? vintNUll :pSedesBeneficiarias.ID_SedeJornada);
                    p.Add("@ID_Contrato",(pSedesBeneficiarias.ID_Contrato== null || pSedesBeneficiarias.ID_Contrato==0) ? vintNUll :pSedesBeneficiarias.ID_Contrato);
                    p.Add("@ID_TipoModeloOperacion",(pSedesBeneficiarias.ID_TipoModeloOperacion== null || pSedesBeneficiarias.ID_TipoModeloOperacion==0) ? vintNUll :pSedesBeneficiarias.ID_TipoModeloOperacion);
                    p.Add("@ID_Sede",(pSedesBeneficiarias.ID_Sede== null || pSedesBeneficiarias.ID_Sede==0) ? vintNUll :pSedesBeneficiarias.ID_Sede);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<SedesBeneficiarias> l = SqlMapper.Query<SedesBeneficiarias>(con, "API.PA_SedesBeneficiariasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  SedesBeneficiarias  ->" + ex.Message);
				}
			}

			public SedesBeneficiarias Add(SedesBeneficiarias pSedesBeneficiarias)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSedesBeneficiarias.id==null ? 0 : pSedesBeneficiarias.id);
p.Add("@ID_SedeJornada",pSedesBeneficiarias.ID_SedeJornada==null ? 0 : pSedesBeneficiarias.ID_SedeJornada);
p.Add("@ID_Contrato",pSedesBeneficiarias.ID_Contrato==null ? 0 : pSedesBeneficiarias.ID_Contrato);
p.Add("@ID_TipoModeloOperacion",pSedesBeneficiarias.ID_TipoModeloOperacion==null ? 0 : pSedesBeneficiarias.ID_TipoModeloOperacion);
p.Add("@ID_Sede",pSedesBeneficiarias.ID_Sede==null ? 0 : pSedesBeneficiarias.ID_Sede);
                    p.Add("@auditoria", pSedesBeneficiarias.auditoria);

                         


                    SedesBeneficiarias o = SqlMapper.QueryFirstOrDefault<SedesBeneficiarias>(con, "API.PA_SedesBeneficiariasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  SedesBeneficiarias  ->" + ex.Message);
				}
			}

			public SedesBeneficiarias  Update(SedesBeneficiarias pSedesBeneficiarias)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSedesBeneficiarias.id==null ? 0 : pSedesBeneficiarias.id);
p.Add("@ID_SedeJornada",pSedesBeneficiarias.ID_SedeJornada==null ? 0 : pSedesBeneficiarias.ID_SedeJornada);
p.Add("@ID_Contrato",pSedesBeneficiarias.ID_Contrato==null ? 0 : pSedesBeneficiarias.ID_Contrato);
p.Add("@ID_TipoModeloOperacion",pSedesBeneficiarias.ID_TipoModeloOperacion==null ? 0 : pSedesBeneficiarias.ID_TipoModeloOperacion);
p.Add("@ID_Sede",pSedesBeneficiarias.ID_Sede==null ? 0 : pSedesBeneficiarias.ID_Sede);
                    p.Add("@auditoria", pSedesBeneficiarias.auditoria);

                         


                    SedesBeneficiarias o = SqlMapper.QueryFirstOrDefault<SedesBeneficiarias>(con, "API.PA_SedesBeneficiariasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  SedesBeneficiarias  ->" + ex.Message);
				}
			}

			public bool Delete(SedesBeneficiarias pSedesBeneficiarias)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSedesBeneficiarias.id);
                    p.Add("@auditoria", pSedesBeneficiarias.auditoria);

                

 

					SedesBeneficiarias o = SqlMapper.QueryFirstOrDefault<SedesBeneficiarias>(con, "API.PA_SedesBeneficiariasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) SedesBeneficiarias  ->" + ex.Message);
				}
			}

		



            public List<SedesBeneficiarias> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<SedesBeneficiarias> SedesBeneficiariasList = new List<SedesBeneficiarias>();

                    SedesBeneficiariasList = SqlMapper.Query<SedesBeneficiarias>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SedesBeneficiariasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) SedesBeneficiarias  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<SedesBeneficiarias> b)
            {
                DapperPlusManager.Entity<SedesBeneficiarias>().Table("SedesBeneficiarias");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}