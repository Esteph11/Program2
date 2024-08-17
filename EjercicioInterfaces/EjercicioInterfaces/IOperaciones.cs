
namespace EjercicioInterfaces
{
    public interface IOperaciones
    {
        /// <summary>
        /// Implementa el proceso de calcular el área de un rectángulo
        /// </summary>
        /// <returns>Area de rectángulo</returns>
        public double AreaRectangulo();
        /// <summary>
        /// Implementa el proceso de calcular el área de un triángulo
        /// </summary>
        /// <returns>Area de triángulo</returns>
        public double AreaTriangulo();
        /// <summary>
        /// Implementa el proceso de calcular el área de un circulo
        /// </summary>
        /// <returns>Area de un circulo</returns>
        public double AreaCirculo();
        /// <summary>
        /// Implementa el proceso de calcular volumen de un cubo
        /// </summary>
        /// <returns>volumen de un cubo</returns>
        public double VolumenCubo();
        /// <summary>
        /// Implementa el proceso de calcular longitud de una circunferencia
        /// </summary>
        /// <returns>longitud de una circunferencia</returns>
        public double LongitudCircunferencia();

    }
}
