using System;
using System.IO;
using System.Reflection;

namespace IndWork.Codigo.Infraestrutura.ScriptsSql
{
    public static class AuxiliarRecursos
    {
        private static Assembly DefaultAssembly { get; } = Assembly.GetExecutingAssembly();

        public static string ObtemRecursoComoString(Type resourceNameSpaceClass, string embeddedResourceName)
        {
            return ObtemRecursoComoString(resourceNameSpaceClass.Namespace, embeddedResourceName, resourceNameSpaceClass.Assembly);
        }

        public static string ObtemRecursoComoString(string resourceNamespace, string embeddedResourceName, Assembly assembly = null)
        {
            assembly = assembly ?? DefaultAssembly;

            string absoluteResourceName = ObtemNomeAbsolutoRecurso(resourceNamespace, embeddedResourceName);

            string conteudoRecurso = LeRecursoComoString(assembly, resourceNamespace, embeddedResourceName);
            
            return conteudoRecurso;
        }

        private static string ObtemNomeAbsolutoRecurso(string resourceNamespace, string embeddedResourceName)
        {
            return $"{resourceNamespace}.{embeddedResourceName}";
        }

        private static string LeRecursoComoString(Assembly assembly, string resourceNamespace, string embeddedResourceName)
        {
            string absoluteResourceName = ObtemNomeAbsolutoRecurso(resourceNamespace, embeddedResourceName);

            using (Stream resourceStream = assembly.GetManifestResourceStream(absoluteResourceName))
            {
                if (resourceStream == null)
                {
                    throw new ArgumentException($"Resource {embeddedResourceName} not found.");
                }

                using (StreamReader reader = new StreamReader(resourceStream))
                {
                    string conteudoRecurso = reader.ReadToEnd();

                    return conteudoRecurso;
                }
            }
        }
    }
}
