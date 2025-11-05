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
     /// Clase Abstracta para  Vigencias
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class VigenciasRepository : DataObject , IVigencias 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public VigenciasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public VigenciasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Vigencias GetById(Vigencias pVigencias)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pVigencias.id);                                    


    				Vigencias o = SqlMapper.QueryFirstOrDefault<Vigencias>(con, "API.PA_VigenciasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Vigencias  ->" + ex.Message);
				}
			}

			public List<Vigencias> GetAll()
			{
				try 
                {
                        List<Vigencias> l = SqlMapper.Query<Vigencias>(con, "API.PA_VigenciasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Vigencias  ->" + ex.Message);
				}
			}

			public List<Vigencias> GetAllFull()
			{
				try 
				{
                    List<Vigencias> l = SqlMapper.Query<Vigencias>(con, "API.PA_VigenciasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Vigencias  ->" + ex.Message);
				}
			}
			
			public List<Vigencias> GetAllByWithRelation()
			{
				try 
                {
                    List<Vigencias> l = SqlMapper.Query<Vigencias>(con, "API.PA_VigenciasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Vigencias  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Vigencias> GetByFilter(Vigencias pVigencias, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pVigencias.id== null || pVigencias.id==0) ? vintNUll :pVigencias.id);
                    p.Add("@Nombre",(pVigencias.Nombre== null) ? vintNUll :pVigencias.Nombre);
                    p.Add("@Ano",(pVigencias.Ano== null) ? vintNUll :pVigencias.Ano);
                    p.Add("@FechaInicial",(pVigencias.FechaInicial== null) ? vintNUll :pVigencias.FechaInicial);
                    p.Add("@VigenciaActual",(pVigencias.VigenciaActual== null) ? vintNUll :pVigencias.VigenciaActual);
                    p.Add("@id_FaseVigencia",(pVigencias.id_FaseVigencia== null || pVigencias.id_FaseVigencia==0) ? vintNUll :pVigencias.id_FaseVigencia);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Vigencias> l = SqlMapper.Query<Vigencias>(con, "API.PA_VigenciasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Vigencias  ->" + ex.Message);
				}
			}

			public Vigencias Add(Vigencias pVigencias)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pVigencias.id==null ? 0 : pVigencias.id);
                    p.Add("@Nombre", pVigencias.Nombre);
p.Add("@Ano",pVigencias.Ano==null ? 0 : pVigencias.Ano);
                    p.Add("@FechaInicial", pVigencias.FechaInicial);
                    p.Add("@VigenciaActual", pVigencias.VigenciaActual);
p.Add("@id_FaseVigencia",pVigencias.id_FaseVigencia== null ? 0: pVigencias.id_FaseVigencia);
                    p.Add("@auditoria", pVigencias.auditoria);

                         


                    Vigencias o = SqlMapper.QueryFirstOrDefault<Vigencias>(con, "API.PA_VigenciasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Vigencias  ->" + ex.Message);
				}
			}

			public Vigencias  Update(Vigencias pVigencias)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pVigencias.id==null ? 0 : pVigencias.id);
                    p.Add("@Nombre", pVigencias.Nombre);
p.Add("@Ano",pVigencias.Ano==null ? 0 : pVigencias.Ano);
                    p.Add("@FechaInicial", pVigencias.FechaInicial);
                    p.Add("@VigenciaActual", pVigencias.VigenciaActual);
p.Add("@id_FaseVigencia",pVigencias.id_FaseVigencia== null ? 0: pVigencias.id_FaseVigencia);
                    p.Add("@auditoria", pVigencias.auditoria);

                         


                    Vigencias o = SqlMapper.QueryFirstOrDefault<Vigencias>(con, "API.PA_VigenciasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Vigencias  ->" + ex.Message);
				}
			}

			public bool Delete(Vigencias pVigencias)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pVigencias.id);
                    p.Add("@auditoria", pVigencias.auditoria);

                

 

					Vigencias o = SqlMapper.QueryFirstOrDefault<Vigencias>(con, "API.PA_VigenciasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Vigencias  ->" + ex.Message);
				}
			}

		



            public List<Vigencias> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Vigencias> VigenciasList = new List<Vigencias>();

                    VigenciasList = SqlMapper.Query<Vigencias>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return VigenciasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Vigencias  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Vigencias> b)
            {
                DapperPlusManager.Entity<Vigencias>().Table("Vigencias");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}