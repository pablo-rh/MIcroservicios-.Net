namespace Example.Catalogos.Resources
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Example.Catalogos.Entities.Model;
    public class baseDatos{
        public static List<CatalogosModel> listaDatos = new List<CatalogosModel> (){
            new CatalogosModel { Id = 1, FirstName = "Alejandro", LastName = "Ojeda", Email = "alejandro.ojeda@axity.com", Birthdate = DateTime.Now },
            new CatalogosModel { Id = 2, FirstName = "Jorge", LastName = "Morales", Email = "jorge.morales@axity.com", Birthdate = DateTime.Now },
            new CatalogosModel { Id = 3, FirstName = "Arturo", LastName = "Miranda", Email = "arturo.miranda@axity.com", Birthdate = DateTime.Now },
            new CatalogosModel { Id = 4, FirstName = "Benjamin", LastName = "Galindo", Email = "benjamin.galindo@axity.com", Birthdate = DateTime.Now }, 
        };
    }
}