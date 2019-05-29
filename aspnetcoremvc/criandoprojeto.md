# Super Application - Primeiro Projeto

## Criando projeto MVC e repositório Git

Para criar um novo projeto acesso o menu **File->New->Project** (Fig. 1).

![First_img](/aspnetcoremvc/assets/img/ambiente01.png)

Figura 1. Criando novo projeto

Na lateral esquerda da janela _New Project_ abra as guias _installed - Visual C# - Web - .NET Core_ e selecione a opção _ASP.NET Core Web Application_. Então dê um nome ao projeto, neste caso **SuperApplication**. Você também pode marcar a opção **Add to source control** para criar criar um repositório GIT automaticamente (Fig. 2).

![Second_img](/aspnetcoremvc/assets/img/ambiente02.png)

Figura 2. Criando novo projeto

Nesta tela selecione a versão 2.1 do ASP.NET Core e o template para projeto _Web Application (Model - View - Controller)_ (Fig. 3). Essa opção vai criar a estrutura do projeto, incluindo algumas páginas de exemplo.

![Second_img](/aspnetcoremvc/assets/img/ambiente03.png)

Figura 3. Criando novo projeto


## Entendo a estrutura de diretórios/pastas do projeto

Ao criar um novo projeto ASP.NET Core MVC, será criada um estrutura de diretórios e arquivos, como pode ser visiualizado em _Solution Explorer_ na lateral direita do Visual Studio (Fig. 4). A raíz da estrutura é a Solução (Solution) com o nome do projeto. Dentro da solução tem a pasta do projeto (Posso ter vários projetos dentro da mesma solução). Com um duplo clique nos arquivos dessa estrutura você vai poder visualizar o conteúdo dos mesmos. Recomendo abrir e explorar cada um dos itens dessa estrutura. 

![Second_img](/aspnetcoremvc/assets/img/ambiente06.png)

Figura 4. Estrutura do projeto no Solution Explorer.

Segue abaixo a descrição de cada um dos elementos dessa estrutura (Clique para expandir). 

**SuperApplication**
 <details>
  <summary>Connected Services (Serviços Conectados)</summary>
 Todo projeto pode estar conectado à alguns serviços online como github e outros serviços de nuvem providos pela Azure, AWS, etc.
 </details>
  <details>
  <summary>Dependencies (Dependências)</summary>
 Aqui estão configuradas algumas dependências do projeto, como o SDK do ASP.NET na versão correta, pacotes do NuGet, como drive de conexão do banco de dados, etc. Além disso também há um item de ferramentas de análise.
 </details>  
 <details>
  <summary>Properties (Propriedades do Projeto)</summary>
 Aqui estão as propriedades do projeto.
 </details>
 <details>
  <summary>wwwroot</summary>
 Neste diretório estão os recursos de front-end da minha aplicação, então temos as pastas _css_, destinado aos arquivos de folha de estilo, _images_, destinada à arquivos de imagens da aplicação, _js_, destinada aos arquivos de código JavaScript e a pasta _lib_, onde serão adicionados todas as bibliotecas utilizadas no projeto, como JQuery e BootStrap. Além disso, ainda há o arquivo _favicon.ico_ da aplicação. 
 
  > Esse diretório funiona muito bem para projetos de pequeno porte. Para projetos de maiores, recomendo a criação de pastas para cada tipo de arquivo de dado armazenado no servidor, como pdf, docx, json, etc (embora esses arquivos devessem estar em um serviço de Storage como o S3). Me perguntem durante a aula qual seria uma abordagem melhor para projetos maiores.
 
 </details>
 <details>
  <summary>Controllers</summary>
 Pasta destinada às classes Controladores (Controller)
 </details>
 <details>
  <summary>Models</summary>
 Pasta destinada à armazenar os Models e os ViewModels (este último temos que criar na mão)
 </details>
 <details>
  <summary>Views</summary>
 Pasta destinada as telas da minha aplicação. Essa pasta é organizada em subpastas conforme minhas entidades. Em outras palavras, se ru tiver uma entidade chamada Produto, eu terei que criar uma pasta chamada Produto dentro da pasta View, para colocar as telas (os arquivos com extensão _cshtml_) relativos à essa entidade. Os arquivos _.cshtml_  permitem bloco de códigos C# no meio do código HTML.
 </details>
 <details>
  <summary>appsettings.json</summary>
bla
 </details>
 <details>
  <summary>Program.cs</summary>
 Aarquivo principal responsável por inicializar a aplicação por meio do método _public void main_.
 </details>
 <details>
  <summary>Startup.cs</summary>
bla
 </details>
 
## Executando o projeto

Para **apenas compilar** o projeto, precione **Ctrl+Shift+B** no teclado e você deverá visializar a seguinte mensagem de saída:


Já para compilar e subir a aplicação há duas opções:

 - Com Debug
   - F5
   - Necessário reiniciar para aplicar alterações no código
 - Sem Debug
   - CTRL+F5
   - Alterações em tempo real
   - Possibilidade de paras a execução do servidor web IIS Express de forma manual



 > http://[servidor]:[porta]/NomeController/Action/value
 
 ## Commit do projeto
 
 Se a opção de criar um repositório de forma automática foi selecionada na etapa de criação do projeto, basta executar o seguintes comandos git no diretório do projeto.
 
  > Dica: No Windows você pode acessar a pasta do projeto e 
 
 ```bash
 #Associar o projeto local ao diretório do github
 git remote add origin https://github.com/nome_usuario/nome_diretorio.git
 #Suba o código
 git push -u origin master
 #Informe suas credenciais
 ```
 
