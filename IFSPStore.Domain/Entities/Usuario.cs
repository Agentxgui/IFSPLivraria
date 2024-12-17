using IFSPLivraria.Domain.Base;

namespace IFSPLivraria.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public Usuario() 
        {
        
        }
        public Usuario(int id, string login, string senha) : base(id)
        {
            Login = login;
            Senha = senha;
        }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
