namespace apirest.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }

        public User()
        {
            
        }

        public User(int id, string nome, int idade, string cpf)
        {
            this.Id = id;
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = cpf;
        }

        
        
        
    }
}