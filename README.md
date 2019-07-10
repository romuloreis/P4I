# Projetos desenvolvidos na cadeira de Programação para Internet III

# Tópicos semi-diários
## Definição de localidade (_Locale_) e Formatação de datas & números
### Globalização e localização (_Locale_) no ASP.NET Core
Se você pretende suportar multiplas línguas na sua aplicação, você deve começar por esse [ARTIGO](https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/localization?view=aspnetcore-2.2). Aqui também entra questões culturais, como ordem pradrão das datas dd/mm/aaaa ou mm/dd/aaaa, marcador de casa decimal _,_ ou _._ e símbolo monetário da moeda vigente no país do usuário.

As opções de localidade podem ser definidas dentro método _Configure()_ do arquivo _Startup.cs_, 
conforme o exemplo abaixo que define a localidade padrão baseada em english-United States

            > Não esqueça de importar
            > using System.Globalization;
            > using Microsoft.AspNetCore.Localization;

```cs

            //Instância um objeto CultureInfo
            var enUS = new CultureInfo("en-US");
            //Instância a opção de localização, com um conjunto de definições
            var localizationOption = new RequestLocalizationOptions
            {
                //Definição da Cultura padrão
                DefaultRequestCulture = new RequestCulture(enUS),
                SupportedCultures = new List<CultureInfo> { enUS },
                SupportedUICultures = new List<CultureInfo> { enUS }
            };

            //Define o Locale padrão
            app.UseRequestLocalization(localizationOption);
```

### Labels Customizados - [Display]
 
 Podemos personalizar os labels das propriedades dos _models_ por meio da _annotation_ Display. 
 Assim, serão exibidos termos mais adequados nas views.
 
 ```cs
            [Display(Name = "Data de Nascimento")]
            public DateTime BirthDate { get; set; }
 ```
 
### Semântica da data - [DataType]

Por padrão o ASP.NET Core vai tratar propriedades do tipo _DataTime_ como sendo dia, mês, ano, hora, minutos.
Mas, nem sempre queremos ambas informações (data e hora).
Então, podemos personalizar os labels das propriedades dos _models_ por meio da _annotation_ DataType. 
Assim, serão exibidos termos mais adequados nas views.

No exemplo abaixo definimos que na view essa propriedade vai ser tratada apenas como Data.
Note que também podemos usar a _annotation_ DataType para definirmos o comportamento nas views para outros 
tipos de propriedades, como uma propriedade que armazena um e-mail pode ter o DataType.Email, fazendo com que 
a view se comporte de maneira mais adequada para esse tipo de dado. Nesse caso do e-mail, o valor da propriedade 
vai ser mostrado como um link _mailto_ para abrir o seu cliente de e-mail padrão.
 
 ```cs
            [Display(Name = "Data de Nascimento")]
            [DataType(DataType.Date)]
            public DateTime BirthDate { get; set; }
 ```
 
 ### Formato de exebição - [DisplayFormat]
Podemos personalizar os padrões de formatação da exibição dos dados por meio da _annotation_ DisplayFormat. 
Como por exemplo definir o número de casas decimais que você deseja mostrar ou o formato da data.

 ```cs
        /*O valor 0-zero indica o valor do atributo, o qual vai ter a formatação F2, 
         * a qual é a formatação que define que serão exibidas duas casas decimais*/
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double Salary { get; set; }
        
         /*O valor 0-zero indica o valor do atributo, o qual vai ter a formatação dia, mês e ano, 
         * a qual é a formatação que define que serão exibidas duas casas decimais*/
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
 ```

## ViewModel

Uma ViewModel é uma classe para ser usada especificamente em uma view. 
Com ela é possivel trabalhar com conjuntos de objetos contendo somente as propriedades necessárias de cada entidade/model.

            > Há três formas de passar dados para a View:
            > ViewBag - Sem verificação de erros - erros em runtime
            > ViewData - Verificação de erros pré compilação
            > Direto via parametro do return IActionResult
            
            > Essas duas syntaxes são equivalentes
            > ViewBag.livors = Livros.GetAll();
            > ViewData["livros"] = Livros.GetAll();
            >
            > return View(meus_dados);
            > Note que você declara @model com letra minúscula, mas acessa Model com letra maiúscula
 
## Relações (Apenas Model)

Para saber mais sobre relações acesse esse [ARTIGO](https://docs.microsoft.com/pt-br/ef/core/modeling/relationships)

 > Lembre-se de definir o comportamento ao ser deletado um registro que tenha relação com outros registros!

<details>

<summary>Exemplo de código de relação um para um (1-1)</summary> 

```cs

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    
    public Post Post { get; set; }
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public Blog Blog { get; set; }
}

```

</details>

<details>
<summary>Exemplo de código de relação um para muitos (1-n)</summary> 
 
```cs

 class MyContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BlogImage> BlogImages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>()
            .HasOne(p => p.BlogImage)
            .WithOne(i => i.Blog)
            .HasForeignKey<BlogImage>(b => b.BlogForeignKey);
    }
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    public BlogImage BlogImage { get; set; }
}

public class BlogImage
{
    public int BlogImageId { get; set; }
    public byte[] Image { get; set; }
    public string Caption { get; set; }

    public int BlogForeignKey { get; set; }
    public Blog Blog { get; set; }
}

```
</details>

<details>
<summary>Exemplo de código de relação muitos para muitos (n-n)</summary> 
 
```cs

 class MyContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Tag> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PostTag>()
            .HasKey(pt => new { pt.PostId, pt.TagId });

        modelBuilder.Entity<PostTag>()
            .HasOne(pt => pt.Post)
            .WithMany(p => p.PostTags)
            .HasForeignKey(pt => pt.PostId);

        modelBuilder.Entity<PostTag>()
            .HasOne(pt => pt.Tag)
            .WithMany(t => t.PostTags)
            .HasForeignKey(pt => pt.TagId);
    }
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public List<PostTag> PostTags { get; set; }
}

public class Tag
{
    public string TagId { get; set; }

    public List<PostTag> PostTags { get; set; }
}

public class PostTag
{
    public int PostId { get; set; }
    public Post Post { get; set; }

    public string TagId { get; set; }
    public Tag Tag { get; set; }
}

```
</details>


## Deletando registros: Comportamentos de exclusão
Ao deletar um registro de uma tabela, os registros de outras tabelas que tenham relação com esse registro são impactados.
Precisamos garantir a consistência dos dados no banco relacional, sendo assim, devemos definir como tratar o impacto da remoção de um registro do banco no DBContext. O comportamento da exclusão normalmente deve ser baseado nas [exigências do relacionamento](https://docs.microsoft.com/pt-br/ef/core/modeling/relationships#required-and-optional-relationships), definidas apartir das regras de negócio.

Por exemplo,
Em um cenário onde haja uma tabela **Post** e uma tabela **Comentários**, qual o comportamento mais adequado ao excluir um registro da Tabela **Post** que tenha vários comentários (Tabela Comentários tem uma chave estrangeira da table Post)?

 - Deletar o registro de Post e todos os registros relacionados da tabela  **Comentários**?
 - Deletar o registro de Post e definir o valor **NULL** para a chave estrangeira desse registro em **Comentários**?
 - Não permitir a exlusão do registro da tabela **Post**?

<details>

<summary> Clique aqui para ver um código de exemplo! </summary> 

Você também pode fazer download do código [aqui](#)

```cs
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>();
    }
```

```cs
  public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }

        /*a exclamação após a palavra int indica que esse campo é opcional,
         sendo assim, podemos apagar o post em que esse comentário foi feito grandes impactos. 
         Nesse caso, os comentários ficariam orfãos, não tendo relação com nenhuma postagem.*/
        public int? PostId { get; set; }
        public Post Post { get; set; }
    }
```

```cs
 public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        /*Relação entre a postagem e seu autor.
        O campo AuthorId torna-se obrigatório por padrão, 
        afinal o framework entende que ele é uma chave estrangeira,
         sendo assim, até podemos apagar o autor de uma postagem, porém isso terá um impacto nas 
         postagens feitas pelo autor. 
         Nesse caso, poderiamos deletar as postagens do autor ou definir o campo AuthorId como NULL,
         já que o mesmo é um campo obrigatório*/
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
```

Aproveite o exemplo para alterar o comportamento de delete e testar.

```cs
/*Arquivo DBContext*/
 protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*Uma postagem tem um autor, o qual tem várias postagens*/
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Author)
                .WithMany(b => b.Posts)
                .OnDelete(DeleteBehavior.Cascade); /*Comportamento ao deletar uma postagem*/

            /*Uma postagem vários comentários, os quais são de/pertencem à apenas uma postagem*/
            modelBuilder.Entity<Post>()
                .HasMany(c => c.Comments)
                .WithOne(p => p.Post)
                .OnDelete(DeleteBehavior.ClientSetNull);/*Comportamento ao deletar uma postagem*/

            /*Uma autor tem vários posts, os quais são de/pertencem à apenas um autor*/
            modelBuilder.Entity<Author>()
                .HasMany(p => p.Posts)
                .WithOne(a => a.Author)
                .OnDelete(DeleteBehavior.Cascade);/*Comportamento ao deletar autor*/
        }

```
</details>

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
  
  
