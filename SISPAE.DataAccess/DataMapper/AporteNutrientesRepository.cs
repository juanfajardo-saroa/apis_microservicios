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
     /// Clase Abstracta para  AporteNutrientes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AporteNutrientesRepository : DataObject , IAporteNutrientes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AporteNutrientesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AporteNutrientesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AporteNutrientes GetById(AporteNutrientes pAporteNutrientes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAporteNutrientes.id);                                    


    				AporteNutrientes o = SqlMapper.QueryFirstOrDefault<AporteNutrientes>(con, "API.PA_AporteNutrientesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AporteNutrientes  ->" + ex.Message);
				}
			}

			public List<AporteNutrientes> GetAll()
			{
				try 
                {
                        List<AporteNutrientes> l = SqlMapper.Query<AporteNutrientes>(con, "API.PA_AporteNutrientesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AporteNutrientes  ->" + ex.Message);
				}
			}

			public List<AporteNutrientes> GetAllFull()
			{
				try 
				{
                    List<AporteNutrientes> l = SqlMapper.Query<AporteNutrientes>(con, "API.PA_AporteNutrientesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AporteNutrientes  ->" + ex.Message);
				}
			}
			
			public List<AporteNutrientes> GetAllByWithRelation()
			{
				try 
                {
                    List<AporteNutrientes> l = SqlMapper.Query<AporteNutrientes>(con, "API.PA_AporteNutrientesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AporteNutrientes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AporteNutrientes> GetByFilter(AporteNutrientes pAporteNutrientes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAporteNutrientes.id== null || pAporteNutrientes.id==0) ? vintNUll :pAporteNutrientes.id);
                    p.Add("@ID_AporteNutricional",(pAporteNutrientes.ID_AporteNutricional== null || pAporteNutrientes.ID_AporteNutricional==0) ? vintNUll :pAporteNutrientes.ID_AporteNutricional);
                    p.Add("@ID_Nutriente",(pAporteNutrientes.ID_Nutriente== null || pAporteNutrientes.ID_Nutriente==0) ? vintNUll :pAporteNutrientes.ID_Nutriente);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AporteNutrientes> l = SqlMapper.Query<AporteNutrientes>(con, "API.PA_AporteNutrientesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AporteNutrientes  ->" + ex.Message);
				}
			}

			public AporteNutrientes Add(AporteNutrientes pAporteNutrientes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAporteNutrientes.id==null ? 0 : pAporteNutrientes.id);
p.Add("@ID_AporteNutricional",pAporteNutrientes.ID_AporteNutricional==null ? 0 : pAporteNutrientes.ID_AporteNutricional);
p.Add("@ID_Nutriente",pAporteNutrientes.ID_Nutriente==null ? 0 : pAporteNutrientes.ID_Nutriente);
                    p.Add("@auditoria", pAporteNutrientes.auditoria);

                         


                    AporteNutrientes o = SqlMapper.QueryFirstOrDefault<AporteNutrientes>(con, "API.PA_AporteNutrientesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AporteNutrientes  ->" + ex.Message);
				}
			}

			public AporteNutrientes  Update(AporteNutrientes pAporteNutrientes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAporteNutrientes.id==null ? 0 : pAporteNutrientes.id);
p.Add("@ID_AporteNutricional",pAporteNutrientes.ID_AporteNutricional==null ? 0 : pAporteNutrientes.ID_AporteNutricional);
p.Add("@ID_Nutriente",pAporteNutrientes.ID_Nutriente==null ? 0 : pAporteNutrientes.ID_Nutriente);
                    p.Add("@auditoria", pAporteNutrientes.auditoria);

                         


                    AporteNutrientes o = SqlMapper.QueryFirstOrDefault<AporteNutrientes>(con, "API.PA_AporteNutrientesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AporteNutrientes  ->" + ex.Message);
				}
			}

			public bool Delete(AporteNutrientes pAporteNutrientes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAporteNutrientes.id);
                    p.Add("@auditoria", pAporteNutrientes.auditoria);

                

 

					AporteNutrientes o = SqlMapper.QueryFirstOrDefault<AporteNutrientes>(con, "API.PA_AporteNutrientesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AporteNutrientes  ->" + ex.Message);
				}
			}

		



            public List<AporteNutrientes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AporteNutrientes> AporteNutrientesList = new List<AporteNutrientes>();

                    AporteNutrientesList = SqlMapper.Query<AporteNutrientes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AporteNutrientesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AporteNutrientes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AporteNutrientes> b)
            {
                DapperPlusManager.Entity<AporteNutrientes>().Table("AporteNutrientes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}