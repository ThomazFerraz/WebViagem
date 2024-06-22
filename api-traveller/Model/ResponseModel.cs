using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace api_traveller.Model
{
    public class ResponseModel
    {

        public ResponseModel()
        {
            Erros = new List<string>();
        }

        public object Dados { get; set; }

        public List<string> Erros { get; set; }

        public bool Successo
        {
            get
            {
                if (Erros == null || !Erros.Any())
                    return true;

                return false;
            }
        }
    }
}
