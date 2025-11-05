/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano			    :2022
/// Arquitectura	:Patron MVC .NET FRamework 4.6 Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa			:MODEL (Model Entitys Layer) - Capa Model (Source: MVC7_DAL_ModelBase.CS)  Partial Interface 
/// </Derechos_Reservados>
using System.Security.Claims;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SISPAE.Model

{

    public class LeftMenuViewModel

    {

        public List<MenuElement> elements { get; set; }

    }



    public class MenuElement

    {

        public int Id { get; set; }

        public string Name { get; set; }

        public List<MenuElement> children { get; set; }

        public string Accion { get; set; }

        public string Controller { get; set; }

        public string Icono { get; set; }

        public int IdPadre { get; set; }



    }







}

