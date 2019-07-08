# Projetos desenvolvidos na cadeira de Programação para Internet III

# Tópicos semi-diários
## Deletando registros: Comportamentos de exclusão
Ao deletar um registro de uma tabela, os registros de outras tabelas que tenham relação com esse registro são impactados.
Precisamos garantir a consistência dos dados no banco relacional, sendo assim, devemos definir como tratar o impacto da remoção de um registro do banco. O comportamento da exclusão normalmente deve ser baseado nas [exigências do relacionamento](https://docs.microsoft.com/pt-br/ef/core/modeling/relationships#required-and-optional-relationships), definidas apartir das regras de negócio.

Por exemplo,
Em um cenário onde haja uma tabela **Post** e uma tabela **Comentários**, qual o comportamento mais adequado ao excluir um registro da Tabela **Post** que tenha vários comentários (Tabela Comentários tem uma chave estrangeira da table Post)?

 - Deletar o registro de Post e todos os registros relacionados da tabela  **Comentários**?
 - Deletar o registro de Post e definir o valor **NULL** para a chave estrangeira desse registro em **Comentários**?
 - Não permitir a exlusão do registro da tabela **Post**?

Descubra como fazer isso por meio desse **[ARTIGO](https://docs.microsoft.com/pt-br/ef/core/saving/cascade-delete)**

# Material 
 - [Ambeinte](aspnetcoremvc/ambiente.md)
 - [Criando Projeto](aspnetcoremvc/criandoprojeto.md)
 - [Criando Department](aspnetcoremvc/department.md)
 - [Criando Demais Modelos](aspnetcoremvc/criandomodels.md) 
 - [Criando Controlador de Vendedores](aspnetcoremvc/controladores-seller.md)
 - [Formulário para add Vendedores](aspnetcoremvc/formulario-criacao-seller.md)
 - [Deletando Vendedores](aspnetcoremvc/deletando-seller.md)]
 - [Tipos de notações (resumo)](https://github.com/romuloreis/P4I/blob/master/aspnetcoremvc/annotations.md)
 
 
 # Seeding Service
  - [Código SeedingService](aspnetcoremvc/seedingservice.md)
  - [Código Index de Sellers](https://github.com/romuloreis/P4I/blob/master/aspnetcoremvc/notas-aula.md)
  
  # Projetos feitos em aula atualizados
   - [Projeto ualmart - download](https://github.com/romuloreis/P4I/blob/master/aspnetcoremvc/ualmart.zip)
   - [Projeto Blog Relacional](https://github.com/romuloreis/P4I/blob/master/aspnetcoremvc/SuperBlogRelacional.zip)
   - [Projeto Validação](https://github.com/romuloreis/P4I/blob/master/aspnetcoremvc/ValidationApplication.zip)
   
   
   # Material
   
   - [Criando Modelos](https://docs.microsoft.com/pt-br/ef/core/modeling/)
   - [Modelagem do banco de dados](https://docs.microsoft.com/pt-br/ef/core/modeling/relational/)
   - [Data Annotations](https://docs.microsoft.com/pt-br/ef/ef6/modeling/code-first/data-annotations)
   - [Helper Tag - validação](https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/working-with-forms?view=aspnetcore-3.0#the-validation-summary-tag-helper)
   - [Série de tutoriais](https://docs.microsoft.com/pt-br/aspnet/core/data/ef-mvc/?view=aspnetcore-2.2)
   - [Tutorial básico](https://docs.microsoft.com/pt-br/ef/core/get-started/aspnetcore/new-db?tabs=visual-studio)
   - [Tutorial Básico do zero](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-2.2&tabs=visual-studio)
   - [Relações](https://docs.microsoft.com/pt-br/ef/core/modeling/relationships) - Ver exclusões
   - [Tutorial: Criar um modelo de dados complexo - ASP.NET MVC com EF Core](https://docs.microsoft.com/pt-br/aspnet/core/data/ef-mvc/complex-data-model?view=aspnetcore-2.2)
   - [Many-to-many artigo 1](https://www.codeproject.com/Articles/702890/MVC-Entity-Framework-and-Many-to-Many-Relation)
   - [Many-to-many artigo 2](https://www.learnentityframeworkcore.com/configuration/many-to-many-relationship-configuration)
   **New: ** [Consultas](https://docs.microsoft.com/pt-br/ef/core/querying/)
   - [Paginação, caixa de pesquisa e filtros](https://docs.microsoft.com/pt-br/aspnet/core/data/ef-mvc/sort-filter-page?view=aspnetcore-2.2)
   
   # Material Extra
   
  - [Explicação sobre validação em pt-br](https://docs.microsoft.com/pt-br/aspnet/core/mvc/models/validation?view=aspnetcore-2.1)
  - [Artigo sobre validação de números de telefone](https://sensibledev.com/phone-number-validation-in-asp-net/)
  - [compare validator mvc](https://sensibledev.com/compare-validator-in-mvc/)
  - [mvc - upload de multiplos arquivos](https://sensibledev.com/mvc-multiple-file-upload/)
  
  - [Conceitos importantes](https://sensibledev.com/entity-framework-interview-questions/)
  - [BootStrap 4](https://sensibledev.com/mvc-bootstrap-form-example/)
  
  
