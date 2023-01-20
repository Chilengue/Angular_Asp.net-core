namespace SmartSchool_WebAPI.Models
{
    public class Professor
    {
        public Professor() {}
        public Professor(int pID, String nome)
        {
            this.PID = pID;
            this.Nome = nome;
        

        }
        public int PID { get; set; }
        public String Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }


    }
}