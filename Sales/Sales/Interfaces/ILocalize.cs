
using System.Globalization;

namespace Sales.Interfaces
{
    public interface ILocalize
    {
        //Informacion del telefono - devuelve el idioma en el que se encuentra el dispositivo
        CultureInfo GetCurrentCultureInfo();

        //Sirve para cambiar la configuraion del telefono.
        void SetLocale(CultureInfo ci);
    }
}
