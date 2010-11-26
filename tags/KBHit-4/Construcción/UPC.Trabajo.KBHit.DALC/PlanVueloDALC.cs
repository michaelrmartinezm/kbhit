using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class PlanVueloDALC
    {
        public abstract int InsertarPlanVueloBE(PlanDeVueloBE obj);
        public abstract PlanDeVueloBE ObtenerPlanVueloBE(int iCod);
        public abstract void EliminarPlanVueloBE(int iCod);
        public abstract List<PlanDeVueloBE> ListarPlanVueloBE();
        public abstract void ActualizarPlanVueloBE(PlanDeVueloBE obj);
    }
}
