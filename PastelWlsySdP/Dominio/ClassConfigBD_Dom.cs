namespace PastelWlsySdP.Dominio
{
    public class ClassConfigBD_Dom
    {
        private string autenticacao;
        private string servidor;
        private string instancia;
        private string usuario;
        private string senha;
        private string bd;
        private string diretorio;
        private string bdOriginal;
        private string destino;
        public string Servidor { get => servidor; set => servidor = value; }
        public string Instância { get => instancia; set => instancia = value; }
        public string Usuário { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Bd { get => bd; set => bd = value; }
        public string Diretório { get => diretorio; set => diretorio = value; }
        public string BdOriginal { get => bdOriginal; set => bdOriginal = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Autenticação
        {
            get { return autenticacao; }
            set
            {
                autenticacao = value;
                if (autenticacao == "Autenticação do Windows")
                    autenticacao = "Windows";
                else if (autenticacao == "Autenticação do SQL")
                    autenticacao = "SQL";
            }
        }
    }
}
