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
     /// Clase Abstracta para  Multimedias
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MultimediasRepository : DataObject , IMultimedias 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MultimediasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MultimediasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Multimedias GetById(Multimedias pMultimedias)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMultimedias.id);                                    


    				Multimedias o = SqlMapper.QueryFirstOrDefault<Multimedias>(con, "API.PA_MultimediasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Multimedias  ->" + ex.Message);
				}
			}

			public List<Multimedias> GetAll()
			{
				try 
                {
                        List<Multimedias> l = SqlMapper.Query<Multimedias>(con, "API.PA_MultimediasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Multimedias  ->" + ex.Message);
				}
			}

			public List<Multimedias> GetAllFull()
			{
				try 
				{
                    List<Multimedias> l = SqlMapper.Query<Multimedias>(con, "API.PA_MultimediasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Multimedias  ->" + ex.Message);
				}
			}
			
			public List<Multimedias> GetAllByWithRelation()
			{
				try 
                {
                    List<Multimedias> l = SqlMapper.Query<Multimedias>(con, "API.PA_MultimediasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Multimedias  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Multimedias> GetByFilter(Multimedias pMultimedias, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMultimedias.id== null || pMultimedias.id==0) ? vintNUll :pMultimedias.id);
                    p.Add("@Nombre",(pMultimedias.Nombre== null) ? vintNUll :pMultimedias.Nombre);
                    p.Add("@PATH",(pMultimedias.PATH== null) ? vintNUll :pMultimedias.PATH);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Multimedias> l = SqlMapper.Query<Multimedias>(con, "API.PA_MultimediasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Multimedias  ->" + ex.Message);
				}
			}

			public Multimedias Add(Multimedias pMultimedias)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMultimedias.id==null ? 0 : pMultimedias.id);
                    p.Add("@Nombre", pMultimedias.Nombre);
                    p.Add("@PATH", pMultimedias.PATH);
                    p.Add("@auditoria", pMultimedias.auditoria);

                         


                    Multimedias o = SqlMapper.QueryFirstOrDefault<Multimedias>(con, "API.PA_MultimediasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Multimedias  ->" + ex.Message);
				}
			}

			public Multimedias  Update(Multimedias pMultimedias)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMultimedias.id==null ? 0 : pMultimedias.id);
                    p.Add("@Nombre", pMultimedias.Nombre);
                    p.Add("@PATH", pMultimedias.PATH);
                    p.Add("@auditoria", pMultimedias.auditoria);

                         


                    Multimedias o = SqlMapper.QueryFirstOrDefault<Multimedias>(con, "API.PA_MultimediasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Multimedias  ->" + ex.Message);
				}
			}

			public bool Delete(Multimedias pMultimedias)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMultimedias.id);
                    p.Add("@auditoria", pMultimedias.auditoria);

                

 

					Multimedias o = SqlMapper.QueryFirstOrDefault<Multimedias>(con, "API.PA_MultimediasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Multimedias  ->" + ex.Message);
				}
			}

		



            public List<Multimedias> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Multimedias> MultimediasList = new List<Multimedias>();

                    MultimediasList = SqlMapper.Query<Multimedias>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MultimediasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Multimedias  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Multimedias> b)
            {
                DapperPlusManager.Entity<Multimedias>().Table("Multimedias");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}