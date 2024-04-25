using System.Text;

namespace gateway_resonance_pass.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentificationController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get(int number)
        {
            //variables
            var resultado = SumNumber(number);  


            return Ok($"EL resultado es: {resultado}");
        }

        //public string NombreApellido(string nombre, string apellido)
        //{
        //    return $"Mi nombre es: {nombre} y mi apellido es {apellido}";
        //}

        private int SumNumber(int number)
        {
            var suma = 0;

            for (int i = 0; i <= number; i++)
            {
                suma += i;
            }

            return suma;
        }
    }
}
