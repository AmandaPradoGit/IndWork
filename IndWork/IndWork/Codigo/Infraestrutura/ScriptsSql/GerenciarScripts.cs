namespace IndWork.Codigo.Infraestrutura.ScriptsSql
{
    public static class GerenciarScripts
    {
        public static string ObtemScriptInserirPessoa()
        {
            return ObtemScript("InserirPessoa.sql");
        }

        public static string ObtemScriptAtualizarPessoa()
        {
            return ObtemScript("AtualizarPessoa.sql");
        }

        public static string ObtemScriptRemoverPessoa()
        {
            return ObtemScript("RemoverPessoa.sql");
        }

        public static string ObtemScriptObterPessoaPorId()
        {
            return ObtemScript("ObtemPessoaPorId.sql");
        }

        public static string ObtemScriptListarPessoas()
        {
            return ObtemScript("ListarPessoas.sql");
        }

        public static string ObtemScriptInserirPrestador()
        {
            return ObtemScript("InserirPrestador.sql");
        }

        public static string ObtemScriptAtualizarPrestador()
        {
            return ObtemScript("AtualizarPrestador.sql");
        }

        public static string ObtemScriptRemoverPrestador()
        {
            return ObtemScript("RemoverPrestador.sql");
        }

        public static string ObtemScriptObterPrestadorPorId()
        {
            return ObtemScript("ObtemPrestadorPorId.sql");
        }

        public static string ObtemScriptListarPrestadores()
        {
            return ObtemScript("ListarPrestadores.sql");
        }

        private static string ObtemScript(string nomeScript)
        {
            return AuxiliarRecursos.ObtemRecursoComoString(typeof(GerenciarScripts),nomeScript);
        }
    }
}
