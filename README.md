# DDD
Proceso de creacion

1.  Crear proyecto Domain como Biblioteca de clase
1.1 Crear Cerpeta Contenedora "Abstracs","Base","Entities"
1.2 Instalar paquetes NuGet ("EntityFrameWork","System.ComponentModel")
1.3 en Base crear  "IEntity.cs","BaseEntity.cs" 


################IEntity.cs################

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }

################BaseEntity.cs################

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;
namespace Domain
{
    public abstract class BaseEntity
    {

    }
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        [Key]
        public virtual T Id { get; set; }
    }
}



2 Crear Infraestructure.Data
Referenciar : EntityFrameWork, System.ComponentModel, Domain, System.Data.Entity


# DDD_VIRGEN
