using System;

namespace IntroducaoGitGitHub__C_Sharp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine("Yes, that's it, the World said hello, you're a luck guy and your future is gonna be awesome");
            Console.WriteLine("Have a great day!");


            // PowerShell/CMD:
            // ren git.txt .gitignore (depois copiar lá pra dentro todo o texto de gitignore para Visual Studio em github/Gitignore

            // GitBASH:
            // git init
            // git config --global user.name ""
            // git config --global user.email ""
            // git status
            // git add .
            // git commit -m ""   --caso esqueça de colocar um comentário, para sair do editor VIM, tecle ESC e depois-> :q!
            // git log
            // git log --oneline

            // git clean -df         --descartar as últimas alterações (quando se está em vermelho ainda, então
            // git checkout -- .       esses dois comandos excluem as últimas alterações no código)

            // git reset --soft HEAD~1     --Remove o último commit porém mantém as alterações lá no código
            // git reset --hard HEAD~1     --CUIDADO! Remove o último commit E SUAS ALTERAÇÕES no código

            // git checkout CódigoDoCommit      --Volta ao commit desejado para poder analisa-lo, executá-lo, enfim...
            // git checkout NomeDoBranch        --Volta ao branch desejado para continuar com o projeto, pode ser 'master' no caso, se quiser voltar para o master
            
            // git remote add origin URLdoRepositórioRemoto        --Depois de criado um repositório vazio no GitHub, associar Local a ele.
            // git remote set-url origin URLdoRepositórioRemoto    --Associar o Local a um outro repositório remoto

            // git push -u origin master       --Transferir repositório local para o remoto
            // git push                        --Caso já tenha usado o último comando com o -u, basta dar esse comando agora para o push do master
            
            // git clone URLdoRepositórioRemoto      --Clonar Repositório Remoto para Local

            // git pull origin master        --Atualizar seu repositório Local de acordo com o Remoto

        }
    }
}
