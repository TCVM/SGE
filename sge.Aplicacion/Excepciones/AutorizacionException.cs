﻿namespace sge.Aplicacion;

public class AutorizacionException: Exception
{
//debe ser lanzada cuando un usuario intenta realizar una operación para la cual no tiene los permisos necesarios.

    public AutorizacionException() 
    { 
        
    }
    public AutorizacionException(string message): base(message) 
    { 
        message= "No estas autorizado";
    }
    public AutorizacionException(string message, Exception inner): base(message, inner) 
    { 
        message= "No estas autorizado";
    }
//Se usa cuando en un manejador de excepción (bloque catch) se lanza otra excepción pero en inner se mantiene la referencia a la original 
}