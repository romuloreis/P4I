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

Ao criar um novo projeto ASP.NET Core MVC, será criada um estrutura de diretórios e arquivos, como pode ser visiualizado em _Solution Explorer_ na lateral direita do Visual Studio (Fig. 4).

![Second_img](/aspnetcoremvc/assets/img/ambiente06.png)

Figura 4. Estrutura do projeto no Solution Explorer.


**SuperApplication**
 <details>
  <summary>Connected Services</summary>
bla
 </details>
  <details>
  <summary>Dependencies</summary>
bla
 </details>  
 <details>
  <summary>Properties</summary>
bla
 </details>
 <details>
  <summary>wwwroot</summary>
bla
 </details>
 <details>
  <summary>Controllers</summary>
bla
 </details>
 <details>
  <summary>Models</summary>
bla
 </details>
 <details>
  <summary>Views</summary>
bla
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
Sem Debug
   - CTRL+F5
   - Alterações em tempo real
   - Possibilidade de paras a execução do servidor web IIS Express de forma manual



 > http://[servidor]:[porta]/NomeController/Action/value
