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

        private static string ObtemScript(string nomeScript)
        {
            return AuxiliarRecursos.ObtemRecursoComoString(typeof(GerenciarScripts),nomeScript);
        }
    }
}
