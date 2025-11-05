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
     /// Clase Abstracta para  ElementosDelnventario
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ElementosDelnventarioRepository : DataObject , IElementosDelnventario 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ElementosDelnventarioRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ElementosDelnventarioRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ElementosDelnventario GetById(ElementosDelnventario pElementosDelnventario)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pElementosDelnventario.id);                                    


    				ElementosDelnventario o = SqlMapper.QueryFirstOrDefault<ElementosDelnventario>(con, "API.PA_ElementosDelnventarioGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ElementosDelnventario  ->" + ex.Message);
				}
			}

			public List<ElementosDelnventario> GetAll()
			{
				try 
                {
                        List<ElementosDelnventario> l = SqlMapper.Query<ElementosDelnventario>(con, "API.PA_ElementosDelnventarioGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ElementosDelnventario  ->" + ex.Message);
				}
			}

			public List<ElementosDelnventario> GetAllFull()
			{
				try 
				{
                    List<ElementosDelnventario> l = SqlMapper.Query<ElementosDelnventario>(con, "API.PA_ElementosDelnventarioGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ElementosDelnventario  ->" + ex.Message);
				}
			}
			
			public List<ElementosDelnventario> GetAllByWithRelation()
			{
				try 
                {
                    List<ElementosDelnventario> l = SqlMapper.Query<ElementosDelnventario>(con, "API.PA_ElementosDelnventarioGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ElementosDelnventario  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ElementosDelnventario> GetByFilter(ElementosDelnventario pElementosDelnventario, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pElementosDelnventario.id== null || pElementosDelnventario.id==0) ? vintNUll :pElementosDelnventario.id);
                    p.Add("@Nombre",(pElementosDelnventario.Nombre== null) ? vintNUll :pElementosDelnventario.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ElementosDelnventario> l = SqlMapper.Query<ElementosDelnventario>(con, "API.PA_ElementosDelnventarioGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ElementosDelnventario  ->" + ex.Message);
				}
			}

			public ElementosDelnventario Add(ElementosDelnventario pElementosDelnventario)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pElementosDelnventario.id==null ? 0 : pElementosDelnventario.id);
                    p.Add("@Nombre", pElementosDelnventario.Nombre);
                    p.Add("@auditoria", pElementosDelnventario.auditoria);

                         


                    ElementosDelnventario o = SqlMapper.QueryFirstOrDefault<ElementosDelnventario>(con, "API.PA_ElementosDelnventarioAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ElementosDelnventario  ->" + ex.Message);
				}
			}

			public ElementosDelnventario  Update(ElementosDelnventario pElementosDelnventario)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pElementosDelnventario.id==null ? 0 : pElementosDelnventario.id);
                    p.Add("@Nombre", pElementosDelnventario.Nombre);
                    p.Add("@auditoria", pElementosDelnventario.auditoria);

                         


                    ElementosDelnventario o = SqlMapper.QueryFirstOrDefault<ElementosDelnventario>(con, "API.PA_ElementosDelnventarioUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ElementosDelnventario  ->" + ex.Message);
				}
			}

			public bool Delete(ElementosDelnventario pElementosDelnventario)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pElementosDelnventario.id);
                    p.Add("@auditoria", pElementosDelnventario.auditoria);

                

 

					ElementosDelnventario o = SqlMapper.QueryFirstOrDefault<ElementosDelnventario>(con, "API.PA_ElementosDelnventarioDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ElementosDelnventario  ->" + ex.Message);
				}
			}

		



            public List<ElementosDelnventario> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ElementosDelnventario> ElementosDelnventarioList = new List<ElementosDelnventario>();

                    ElementosDelnventarioList = SqlMapper.Query<ElementosDelnventario>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ElementosDelnventarioList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ElementosDelnventario  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ElementosDelnventario> b)
            {
                DapperPlusManager.Entity<ElementosDelnventario>().Table("ElementosDelnventario");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}