﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sales.Resources {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sales.Resources.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Accept.
        /// </summary>
        public static string Accept {
            get {
                return ResourceManager.GetString("Accept", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Add Product.
        /// </summary>
        public static string AddProduct {
            get {
                return ResourceManager.GetString("AddProduct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Description.
        /// </summary>
        public static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Enter the product description.
        /// </summary>
        public static string DescriptionPlaceholder {
            get {
                return ResourceManager.GetString("DescriptionPlaceholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error.
        /// </summary>
        public static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a No internet connection.
        /// </summary>
        public static string NoInternet {
            get {
                return ResourceManager.GetString("NoInternet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Price.
        /// </summary>
        public static string Price {
            get {
                return ResourceManager.GetString("Price", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Enter the product price.
        /// </summary>
        public static string PricePlaceholder {
            get {
                return ResourceManager.GetString("PricePlaceholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Products.
        /// </summary>
        public static string Products {
            get {
                return ResourceManager.GetString("Products", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Please turn on your internet settings..
        /// </summary>
        public static string TurnOnInternet {
            get {
                return ResourceManager.GetString("TurnOnInternet", resourceCulture);
            }
        }
    }
}
