/*
    <Derechos_Reservados>
    Aplicacion		:SISPAE 
    Autor			:TiGlobal SAS y SoftManagement
    Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
    Ano				:2022
    Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, UnitTest
    Capa			:Capa Controlador Pruebas Unitarias para SISPAE    
    </Derechos_Reservados>

    Metodos desarrollados mediante xunit 
    Arrange (Preparar) – Aquí creamos los datos de arranque, instanciando la clase que tiene la función que deseamos probar, y el valor a probar.
    Act (Ejecutar) – Ejecutamos la función requerida o metodo que esta en la api o el controlador  y asignamos el resultado a la variable respuesta.
    Assert (Revisar) – Finalmente en la última sección nos aseguramos de que el resultado sea el esperado, o valido.
*/


using Xunit;
using SISPAE.Model;
using System;
using System.Linq;
using SISPAE_API_GestionExcedentes.WebAPI.Controllers;
using SISPAE.Tests.Interfaces;
using SISPAE.Tests.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit.Sdk;
using Xunit.Abstractions;


namespace SISPAE.Tests.Controllers
{
    public  class UTTiposDestinosRacionesController: ITestCaseOrderer
    {
        private readonly TiposDestinosRacionesController _controller;
        private readonly ITiposDestinosRacionesService _service;
        private readonly TiposDestinosRaciones _Objeto;

        public IEnumerable<TTestCase> OrderTestCases<TTestCase>(IEnumerable<TTestCase> testCases) where TTestCase : ITestCase =>testCases.OrderBy(testCase => testCase.TestMethod.Method.Name);


        public UTTiposDestinosRacionesController()
        {
            _service = new UTTiposDestinosRacionesServiceFake();
            _controller = new TiposDestinosRacionesController();
            
             _Objeto = new TiposDestinosRaciones()
            {
                id=0,
Nombre="a",
auditoria="a",

            };
        }



         [Fact]
         /* <PruebaUnitaria>
               Metodo T01_InsertarUnregistro
               LLama al método Post para verificar que inserte valores  del microservicio y del controlador y verifica que retorna los mismo valores 
            </PruebaUnitaria>
         */
        public void T01_InsertarUnregistro()
        {
            //Act
            var okResult = _controller.Post(_Objeto);

            TiposDestinosRaciones v = (TiposDestinosRaciones)((Microsoft.AspNetCore.Mvc.ObjectResult)okResult).Value;
            _Objeto.id = v.id;
            
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }




        [Fact]
        /* <PruebaUnitaria>
                Metodo T02_Post_Objeto
                LLama al método Post a partir de un elemento del GetAll para verificar que inserte valores  del microservicio y del controlador y verifica que retorna los mismo valores  
        </PruebaUnitaria>
        */
        public void T02_Post_Objeto() 
        {

            //Arrange
            var l = _service.GetAll().Select(r => r.id).ToList();
            int i = GetRandomElements(l);


            //Act

            //Obtenemos un objeto
            TiposDestinosRaciones c =  _service.GetById(i);

            //Eliminamos el objeto
            // _service.Delete(i);
            c.id = 0;

            //Assert
            var okResult = _controller.Post(c) as OkObjectResult;

        }


        [Fact]
        /*
         <PruebaUnitaria>
           Metodo T03_Insertar_PasarDesconocidoId_RetornaBadRequestesult()
           LLama al método Post a partir de un id desconocido para verificar que genere la excepcion  
         </PruebaUnitaria>
       */
        public void T03_Insertar_PasarDesconocidoId_RetornaBadRequestesult()
        {

            //Arrange
            _Objeto.id = -1;


            //Pasamos cero porque no deberia existir como id en ninguna referencia
            var FoundResultNull = (ActionResult)_controller.Post(_Objeto); 


            //Assert
            Assert.IsType<BadRequestObjectResult>(FoundResultNull as BadRequestObjectResult);

        }



        [Fact]
        /* <PruebaUnitaria>
            Metodo T04_LeerElRegistroInsertado()
            LLama al método GetById para verificar que Obetenga los  valores  desde controlador 
        </PruebaUnitaria>
        */
        public void T04_LeerElRegistroInsertado()
        {
            //Act
            var okResult = _controller.GetById(_Objeto.id);

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);

        }



        [Fact]
        /* <PruebaUnitaria>
               Metodo T05_Obtener_CuandoLLama_GetAllRetornarOkResult
               LLama al método GetAll para verificar que retorna valores desde el controlador
            </PruebaUnitaria>
        */
        public void T05_Obtener_CuandoLLama_GetAllRetornarOkResult()
        {
            // Act
            var okResult = _controller.GetAll();

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
           /* <PruebaUnitaria>
               Metodo T06_Obtener_CuandoLLama_GetAllTodosLosResultados
              LLama al método GetAll para verificar que retorna valores  del microservicio y del controlador y verifica que retorna los mismo valores 
            </PruebaUnitaria>
        */
        public void T6_Obtener_CuandoLLama_GetAllTodosLosResultados()
        {
            // Act
            var okResult = _controller.GetAll() as OkObjectResult;
            var i = (IEnumerable<TiposDestinosRaciones>)okResult.Value;


            // Assert

            Assert.Equal(i.ToList().Count(), _service.GetAll().Count());

        }

        [Fact]

         /* <PruebaUnitaria>
               Metodo T07_Obtener_CuandoLLama_GetAllFullRetornarOkResult()
               LLama al método GetAllFull para verificar que retorna valores desde el controlador
            </PruebaUnitaria>
        */
        public void T07_Obtener_CuandoLLama_GetAllFullRetornarOkResult()
        {
            // Act
            var okResult = _controller.GetAllFull();

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
         
         
         [Fact]
         /* <PruebaUnitaria>
               Metodo T08_Obtener_CuandoLLama_GetAllRelationRetornarOkResult()
               LLama al método GetAllRelation para verificar que retorna valores desde el controlador  
            </PruebaUnitaria>
        */
         public void T08_Obtener_CuandoLLama_GetAllRelationRetornarOkResult()
         {
             // Act
             var okResult = _controller.GetAllRelation();

             // Assert
             Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
         }



        [Fact]
        /* <PruebaUnitaria>
               Metodo T08_Obtener_CuandoLLama_LoadTableRetornarOkResult()
               LLama al método LoadTable para verificar que retorna valores desde el controlador  
            </PruebaUnitaria>
        */
        public void T08_Obtener_CuandoLLama_LoadTableRetornarOkResult()
         {
            //Arr
            DtParameters dp = new DtParameters();

            // Act
            var okResult = _controller.LoadTable(dp).Result;

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
         }


        [Fact]
         /* <PruebaUnitaria>
               Metodo T09_LoadTable_PasarIdDesconocidoeRetornarBadRequest()
               LLama al método LoadTable enviando un id desconocido para verificar que genera la excepcion
            </PruebaUnitaria>
        */
        public void T09_LoadTable_PasarIdDesconocidoeRetornarBadRequest()
        {
            //Arr
            DtOrder[] adt = new DtOrder[1];
            adt[0] = new DtOrder() { Column = -1 };

            DtParameters dp = new DtParameters(){ Start = -1, Length = -1, Order = adt };

            // Act
            var FoundResult = _controller.LoadTable(dp).Result;

            //Assert
            Assert.IsType<BadRequestObjectResult>(FoundResult as BadRequestObjectResult);

        }


       [Fact]
        /* <PruebaUnitaria>
            Metodo T10_Obtener_CuandoLLama_LoadTableOrdenamientoRetornarOkResult()
            LLama al método LoadTable con la configuracion para ordenamiento  y  verificar que retorna valores   
         </PruebaUnitaria>
     */
        public void T10_Obtener_CuandoLLama_LoadTableOrdenamientoRetornarOkResult()
        {
            //Arr
            DtOrder[] o = new DtOrder[1];
            o[0] = new DtOrder() { Column = 0};

            DtColumn[] c = new DtColumn[1];
            c[0] = new DtColumn();
            c[0].Data = "id";
            c[0].Name = "";
            c[0].Orderable = false;
            c[0].Search = new DtSearch() { Regex = false, Value = "" };
            c[0].Searchable = true;

            DtSearch s = new DtSearch() { Regex = false, Value = "" };

            DtParameters dp = new DtParameters() { Columns = c, Draw = 1, Length = 10, Order = o, Search = s, Start = 0, bandeja = null, filtro = null, tipoConjuntoDatos = null, 
                userId = null };


            // Act
            var okResult = _controller.LoadTable(dp).Result;

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        /* <PruebaUnitaria>
            Metodo T10_Obtener_CuandoLLama_LoadTableBusquedaRetornarOkResult()
            LLama al método LoadTable con la configuracion para busqueda  y  verificar que retorna valores   
             </PruebaUnitaria>
        */
        public void T10_Obtener_CuandoLLama_LoadTableBusquedaRetornarOkResult()
        {
            //Arr
            DtOrder[] o = new DtOrder[1];
            o[0] = new DtOrder() { Column = 0 };

            DtColumn[] c = new DtColumn[1];
            c[0] = new DtColumn();
            c[0].Data = "Nombre";
            c[0].Name = "";
            c[0].Orderable = false;
            c[0].Search = new DtSearch() { Regex = false, Value = "a" };
            c[0].Searchable = true;

            DtSearch s = new DtSearch() { Regex = false, Value = "a" };

            DtParameters dp = new DtParameters()
            {
                Columns = c,
                Draw = 1,
                Length = 10,
                Order = o,
                Search = s,
                Start = 0,
                bandeja = null,
                filtro = null,
                tipoConjuntoDatos = null,
                userId = null
            };


            // Act
            var okResult = _controller.LoadTable(dp).Result;

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }



        [Fact]
        /* <PruebaUnitaria>
               Metodo T11_Obtener_CuandoLLama_GetAllFullTodosLosResultados()
               LLama al método GetAllFull para verificar que retorna valores  del microservicio y del controlador y verifica que retorna los mismo valores 
            </PruebaUnitaria>
        */
        public void T11_Obtener_CuandoLLama_GetAllFullTodosLosResultados()
        {

            // Act
            var okResult = _controller.GetAllFull() as OkObjectResult;
            var i = (IEnumerable<TiposDestinosRaciones>)okResult.Value;


            // Assert
            Assert.Equal(i.ToList().Count(), _service.GetAllFull().Count());

        }


        [Fact]
        /* <PruebaUnitaria>
               Metodo T12_GetById_PasarDesconocidoId_RetornaBadRequestesult()
               LLama al método GetById enviando un id desconocido para verificar que genera la excepcion
            </PruebaUnitaria>
        */
        public void T12_GetById_PasarDesconocidoId_RetornaBadRequestesult()
        {

            //Pasamos cero porque no deberia existir como id en ninguna referencia
            var FoundResultNull = (ActionResult)_controller.GetById(-1);


            //Assert
            Assert.IsType<BadRequestObjectResult>(FoundResultNull as BadRequestObjectResult);

        }




        [Fact]
        /* <PruebaUnitaria>
            Metodo T13_GetById_PasarConocidoId_ReturnaOkResult()
            LLama al método GetById para verificar que retorna valores desde el controlador  
        </PruebaUnitaria>
        */
        public void T13_GetById_PasarConocidoId_ReturnaOkResult()
        {
            // Arrange
            var l = _service.GetAll().Select(r => r.id).ToList();
            int i = GetRandomElements(l);

            // Act
            var okResult = _controller.GetById(i);

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        /* <PruebaUnitaria>
            Metodo T14_GetById_ExistenteID_ReturnamismoID()
            LLama al método GetAll para verificar que retorna los mismos valores   del microservicio y controlador
        </PruebaUnitaria>
        */
        public void T14_GetById_ExistenteID_ReturnamismoID()
        {
            // Arrange
            var l = _service.GetAll().Select(r => r.id).ToList();
            int i =GetRandomElements(l);

            // Act
            var okResult = _controller.GetById(i) as OkObjectResult;

            // Assert
            Assert.IsType<TiposDestinosRaciones>(okResult.Value);
            Assert.Equal(i, (okResult.Value as TiposDestinosRaciones).id);
        }


        [Fact]
        /* <PruebaUnitaria>
            Metodo T15_ActualizarUnregistroInsertado()
            LLama al método Put para verificar que actualice los  valores  desde el controlador 
            </PruebaUnitaria>
        */
        public void T15_ActualizarUnregistroInsertado()
        {
            //Arrange
            _Objeto.Nombre="a";
_Objeto.auditoria="a";



            //Act
            var okResult = _controller.Put(_Objeto);

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
         /* <PruebaUnitaria>
            Metodo T16_Actualizar_PasarDesconocidoId_RetornaBadRequestesult()
            LLama al método Put para con un id Desconocido para verificar que genere la excepcion
            </PruebaUnitaria>
        */
        public void T16_Actualizar_PasarDesconocidoId_RetornaBadRequestesult()
        {

            //Arrange
            _Objeto.id = -1;

            //Pasamos cero porque no deberia existir como id en ninguna referencia
            var FoundResultNull = (ActionResult)_controller.Put(_Objeto);


            //Assert
            Assert.IsType<BadRequestObjectResult>(FoundResultNull as BadRequestObjectResult);

        }




      //  [Fact]
      //  /* <PruebaUnitaria>
      //      Metodo T17_EliminarElRegistroInsertado()
      //      LLama al método Delete  para verificar que Elimine los  valores  del microservicio y del controlador y verifica que retorna los mismo valores 
      //      </PruebaUnitaria>
      //  */
      //  public void T17_EliminarElRegistroInsertado()
      //  {
      //      //Act
      //      var Result = _controller.Delete(_service.GetAll().First());
      //
      //      // Assert
      //      if (!_service.ValidateForeignKey("TiposDestinosRaciones"))
      //          Assert.IsType<OkResult>(Result as OkResult);
      //      else
      //          Assert.IsType<BadRequestObjectResult>(Result);
      //  }
        


        [Fact]
        /* <PruebaUnitaria>
            Metodo T17_EliminarElRegistroInsertado()
            LLama al método Delete  para verificar que Elimine los  valores  del microservicio y del controlador y verifica que retorna los mismo valores 
            </PruebaUnitaria>
        */
        public void T17_EliminarElRegistroInsertado()
        {
            //Act
            var Result = _controller.Delete(_service.GetAll().First());

                Assert.IsType<OkResult>(Result as OkResult);
        }




        [Fact]
         /* <PruebaUnitaria>
            Metodo T18_Eliminar_PasarDesconocidoId_RetornaBadRequestesult()
            LLama al método Delete  con un id desconocido para verificar que genere la excepcion 
            </PruebaUnitaria>
        */
        public void T18_Eliminar_PasarDesconocidoId_RetornaBadRequestesult()
        {

            //Arrange
            _Objeto.id = -1;

            //Pasamos cero porque no deberia existir como id en ninguna referencia
            var FoundResultNull = (ActionResult)_controller.Delete(_Objeto);


            //Assert
            Assert.IsType<BadRequestObjectResult>(FoundResultNull as BadRequestObjectResult);

        }



      //  [Fact]
      //  /* <PruebaUnitaria>
      //      Metodo T15_Remover_ExistingIdPasado_RemueveUnItem()
      //      LLama al método Delete  para verificar que Elimina valores   
      //      </PruebaUnitaria>
      //  */
      //  public void T15_Remover_ExistingIdPasado_RemueveUnItem()
      //  {
      //      // Arrange
      //      var l = _service.GetAll().Select(r => r.id).ToList();
      //      int i = GetRandomElements(l);
      //
      //      // Act
      //      var okResponse = _controller.Delete(new TiposDestinosRaciones() { id = i });
      //
      //      // Assert
      //      Assert.Equal(l.Count()-1, _service.GetAll().Count());
      //  }




        #region Privados

        private int GetRandomElements(List<int> l)
        {
            Random rnd = new Random();
            int i = rnd.Next(l.Count());
            return l.ElementAt(i);
        }

        private string GetRandomElements(List<string> l)
        {
            Random rnd = new Random();
            int i = rnd.Next(l.Count());
            return l.ElementAt(i);
        }

        #endregion

    }
}
