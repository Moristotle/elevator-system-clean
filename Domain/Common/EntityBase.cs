using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Denne klassen var ment å brukes dersom operasjoenne i heissystemet ble modellert som eventer 
namespace Domain.Common
{
    public abstract class EntityBase
    {

        public int Id { get; protected set; }

        public DateTime CreatedDate { get; set; }

    }
}