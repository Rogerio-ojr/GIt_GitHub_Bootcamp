# Links Importantes #

https://comandosgit.github.io/

# Comandos Importantes Git #

Gerar o SSH :oncoming_automobile:

- ssh-keygen -t ed -C email  ------ (Type de ED)

- ssh-keygen -t ed25519 -C email  ------ (Gerar o Token)

  > Na Pasta do SSH gerada, executar os seguintes codigos
  >
  > - cat id_ed25519.pub  ------ (Gera o SSH)

  > Fora da Pasta SSH Gerada, Executar os seguintes comandos
  >
  > - eval $(ssh-agent -s)  ------ (Gera o agent)
  > - ssh-add id_ed25519  ------  (Add o SSH Privado ao Agent)

Ecossistema Git

git status

- Untracked

  > Status de arquivos ainda não mapeados pelo Git;

- Unmodified 

  > Status de arquivos ainda não modificados, mas que possivelmente já foram commitados;

- Modified

  > Status de arquivos que foram editados, e estão aguardando serem adicionados so Staged;

- Staged

  > Status de Arquivos que foram adcionados, e estão agora aguardando o Commit, apos o Commit esses arquivos voltam para o status de Unmodified.

​		Todos os arquivos que são commitados, eles ficam no Repositorio Local, aguardando serem enviados para o repositorio  Remoto.

​		Desta forma temos o seguinte:

- Ambiente de Desenvolvimento

  > - Working Directory: Diretorio de Trabalho.
  > - Staging Area: Area onde os arquivos ficam agurdando os Commits.
  > - Local Repository: Repositorio Local, onde os arquivos ficam aguardando o envio para o Repositorio Remoto.

- Servidor

  > - Remote Repository: Git Hub.



Comandos que alteram os status dos arquivos, conforme estrutura acima.

- git add *

- git add nomeArquivo

- git add .

- git commit -m "Descrição do Commit"

  

  

  Comandos de configuração do Git

  - git config --list
  - git config --global --unset user.nickname (Ao lado esta um exmplo de delete do nick name)
  - git config --global user.nickname "Rogério" (Ao lado esta um exemplo de inclusão apenas do nickName)

  

  Comandos de Envio dos dados ao Git Hub

  - Na Pasta do Projeto executar os seguintes comandos

    > - git remote add origin httpsDoRepositorioCriadoNoGitHub
    > - git remote - v (lista as listas de repositorios)
    > - git push origin master 
    
  - Pull comando para puxar alterações realizadas por outras pssoas
  
    > - git pull origin master

​		Comando para clone

​		- git clone httpsDoRepositorioCriadoNoGitHub

Comando para Criação de uma nova Branche no mesmo commit existente ou mudança de branche
  - git checkout -b nomeDaBranche
