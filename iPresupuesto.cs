using System;
using System.ServiceModel;

namespace ipresupuesto{
    [ServiceContract]
    public interface iPresupuesto{
        [OperationContract]
        public decimal mostrarPresupuestoDisponible();
        [OperationContract]
        public string agregarPresupuesto(decimal monto);
        [OperationContract]
        public string sustraerPresupuesto(decimal monto);
        [OperationContract]
        public bool alcanzaElPresupuesto(decimal monto);
        
    }
}