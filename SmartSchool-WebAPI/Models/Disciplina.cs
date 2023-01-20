namespace SmartSchool_WebAPI.Models
{
    public class Disciplina
    {
        public Disciplina() {}
        public Disciplina(int dID, string name, int professorID)
        {
            this.DID = dID;
            this.Name = name;
            this.professorID = professorID;

        }
        public int DID { get; set; }

        public string Name { get; set; }
        public int professorID { get; set; }
        public Professor professor { get; set; }

    }
}