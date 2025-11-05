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
     /// Clase Abstracta para  Divipolas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DivipolasRepository : DataObject , IDivipolas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DivipolasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DivipolasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Divipolas GetById(Divipolas pDivipolas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDivipolas.id);                                    


    				Divipolas o = SqlMapper.QueryFirstOrDefault<Divipolas>(con, "API.PA_DivipolasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Divipolas  ->" + ex.Message);
				}
			}

			public List<Divipolas> GetAll()
			{
				try 
                {
                        List<Divipolas> l = SqlMapper.Query<Divipolas>(con, "API.PA_DivipolasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Divipolas  ->" + ex.Message);
				}
			}

			public List<Divipolas> GetAllFull()
			{
				try 
				{
                    List<Divipolas> l = SqlMapper.Query<Divipolas>(con, "API.PA_DivipolasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Divipolas  ->" + ex.Message);
				}
			}
			
			public List<Divipolas> GetAllByWithRelation()
			{
				try 
                {
                    List<Divipolas> l = SqlMapper.Query<Divipolas>(con, "API.PA_DivipolasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Divipolas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Divipolas> GetByFilter(Divipolas pDivipolas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDivipolas.id== null || pDivipolas.id==0) ? vintNUll :pDivipolas.id);
                    p.Add("@DepartamentoCode",(pDivipolas.DepartamentoCode== null) ? vintNUll :pDivipolas.DepartamentoCode);
                    p.Add("@MunicipioCode",(pDivipolas.MunicipioCode== null) ? vintNUll :pDivipolas.MunicipioCode);
                    p.Add("@CentroPobladoCode",(pDivipolas.CentroPobladoCode== null) ? vintNUll :pDivipolas.CentroPobladoCode);
                    p.Add("@DepartamentoNombre",(pDivipolas.DepartamentoNombre== null) ? vintNUll :pDivipolas.DepartamentoNombre);
                    p.Add("@Nombre",(pDivipolas.Nombre== null) ? vintNUll :pDivipolas.Nombre);
                    p.Add("@CentroPobladoNombre",(pDivipolas.CentroPobladoNombre== null) ? vintNUll :pDivipolas.CentroPobladoNombre);
                    p.Add("@Id_TipoMunicipio",(pDivipolas.Id_TipoMunicipio== null || pDivipolas.Id_TipoMunicipio==0) ? vintNUll :pDivipolas.Id_TipoMunicipio);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Divipolas> l = SqlMapper.Query<Divipolas>(con, "API.PA_DivipolasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Divipolas  ->" + ex.Message);
				}
			}

			public Divipolas Add(Divipolas pDivipolas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDivipolas.id==null ? 0 : pDivipolas.id);
                    p.Add("@DepartamentoCode", pDivipolas.DepartamentoCode);
                    p.Add("@MunicipioCode", pDivipolas.MunicipioCode);
                    p.Add("@CentroPobladoCode", pDivipolas.CentroPobladoCode);
                    p.Add("@DepartamentoNombre", pDivipolas.DepartamentoNombre);
                    p.Add("@Nombre", pDivipolas.Nombre);
                    p.Add("@CentroPobladoNombre", pDivipolas.CentroPobladoNombre);
p.Add("@Id_TipoMunicipio",pDivipolas.Id_TipoMunicipio==null ? 0 : pDivipolas.Id_TipoMunicipio);
                    p.Add("@auditoria", pDivipolas.auditoria);

                         


                    Divipolas o = SqlMapper.QueryFirstOrDefault<Divipolas>(con, "API.PA_DivipolasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Divipolas  ->" + ex.Message);
				}
			}

			public Divipolas  Update(Divipolas pDivipolas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDivipolas.id==null ? 0 : pDivipolas.id);
                    p.Add("@DepartamentoCode", pDivipolas.DepartamentoCode);
                    p.Add("@MunicipioCode", pDivipolas.MunicipioCode);
                    p.Add("@CentroPobladoCode", pDivipolas.CentroPobladoCode);
                    p.Add("@DepartamentoNombre", pDivipolas.DepartamentoNombre);
                    p.Add("@Nombre", pDivipolas.Nombre);
                    p.Add("@CentroPobladoNombre", pDivipolas.CentroPobladoNombre);
p.Add("@Id_TipoMunicipio",pDivipolas.Id_TipoMunicipio==null ? 0 : pDivipolas.Id_TipoMunicipio);
                    p.Add("@auditoria", pDivipolas.auditoria);

                         


                    Divipolas o = SqlMapper.QueryFirstOrDefault<Divipolas>(con, "API.PA_DivipolasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Divipolas  ->" + ex.Message);
				}
			}

			public bool Delete(Divipolas pDivipolas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDivipolas.id);
                    p.Add("@auditoria", pDivipolas.auditoria);

                

 

					Divipolas o = SqlMapper.QueryFirstOrDefault<Divipolas>(con, "API.PA_DivipolasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Divipolas  ->" + ex.Message);
				}
			}

		



            public List<Divipolas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Divipolas> DivipolasList = new List<Divipolas>();

                    DivipolasList = SqlMapper.Query<Divipolas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DivipolasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Divipolas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Divipolas> b)
            {
                DapperPlusManager.Entity<Divipolas>().Table("Divipolas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}