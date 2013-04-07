enum MesNombre { Enero, Febrero, ..., Diciembre }

MesNombre actual;
int mesDias;

switch (actual) {
    case MesNombre.Febrero :
        mesDias = 28;
        break;
    case MesNombre.Abril :
    case MesNombre.Junio :
    case MesNombre.Septiembre :
    case MesNombre.Noviembre :
        mesDias = 30;
        break;
    default :
        mesDias = 31;
        break;
}