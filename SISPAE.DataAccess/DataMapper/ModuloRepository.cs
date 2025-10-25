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
     /// Clase Abstracta para  Modulo
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ModuloRepository : DataObject , IModulo 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ModuloRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ModuloRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Modulo GetById(Modulo pModulo)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pModulo.id);                                    


    				Modulo o = SqlMapper.QueryFirstOrDefault<Modulo>(con, "API.PA_ModuloGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Modulo  ->" + ex.Message);
				}
			}

			public List<Modulo> GetAll()
			{
				try 
                {
                        List<Modulo> l = SqlMapper.Query<Modulo>(con, "API.PA_ModuloGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Modulo  ->" + ex.Message);
				}
			}

			public List<Modulo> GetAllFull()
			{
				try 
				{
                    List<Modulo> l = SqlMapper.Query<Modulo>(con, "API.PA_ModuloGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Modulo  ->" + ex.Message);
				}
			}
			
			public List<Modulo> GetAllByWithRelation()
			{
				try 
                {
                    List<Modulo> l = SqlMapper.Query<Modulo>(con, "API.PA_ModuloGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Modulo  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Modulo> GetByFilter(Modulo pModulo, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pModulo.id== null || pModulo.id==0) ? vintNUll :pModulo.id);
                    p.Add("@Nombre",(pModulo.Nombre== null) ? vintNUll :pModulo.Nombre);
                    p.Add("@id_Sistema",(pModulo.id_Sistema== null || pModulo.id_Sistema==0) ? vintNUll :pModulo.id_Sistema);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Modulo> l = SqlMapper.Query<Modulo>(con, "API.PA_ModuloGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Modulo  ->" + ex.Message);
				}
			}

			public Modulo Add(Modulo pModulo)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pModulo.id==null ? 0 : pModulo.id);
                    p.Add("@Nombre", pModulo.Nombre);
p.Add("@id_Sistema",pModulo.id_Sistema== null ? 0: pModulo.id_Sistema);
                    p.Add("@auditoria", pModulo.auditoria);

                         


                    Modulo o = SqlMapper.QueryFirstOrDefault<Modulo>(con, "API.PA_ModuloAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Modulo  ->" + ex.Message);
				}
			}

			public Modulo  Update(Modulo pModulo)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pModulo.id==null ? 0 : pModulo.id);
                    p.Add("@Nombre", pModulo.Nombre);
p.Add("@id_Sistema",pModulo.id_Sistema== null ? 0: pModulo.id_Sistema);
                    p.Add("@auditoria", pModulo.auditoria);

                         


                    Modulo o = SqlMapper.QueryFirstOrDefault<Modulo>(con, "API.PA_ModuloUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Modulo  ->" + ex.Message);
				}
			}

			public bool Delete(Modulo pModulo)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pModulo.id);
                    p.Add("@auditoria", pModulo.auditoria);

                

 

					Modulo o = SqlMapper.QueryFirstOrDefault<Modulo>(con, "API.PA_ModuloDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Modulo  ->" + ex.Message);
				}
			}

		



            public List<Modulo> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Modulo> ModuloList = new List<Modulo>();

                    ModuloList = SqlMapper.Query<Modulo>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ModuloList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Modulo  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Modulo> b)
            {
                DapperPlusManager.Entity<Modulo>().Table("Modulo");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}