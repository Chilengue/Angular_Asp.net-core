namespace SmartSchool_WebAPI.Models
{
    public class Aluno
    {

        public Aluno()  {  }
        
          public Aluno(int aid,
              string nome,
              string sobrenome,
              string telefone)
        {
            this.Aid = aid;
            this.nome = nome;
            this.Sobrenome = sobrenome;
            this.telefone = telefone;

        }
        public int Aid { get; set; }
        public string nome { get; set; }
        public string Sobrenome { get; set; }
        public string telefone { get; set; }
    }
}