## Views/Sellers/Index.cshtml

```html

@model IEnumerable<ProjectName.Models.Seller>

@{
    ViewData["Title"] = "Sellers";
}

<h2>@ViewData["Title"]</h2>

<p>
    <a asp-action="Create" class="btn btn-default">Create New</a>
</p>

<!-- classes do bootstrap (table table-striped table-hover)-->
<table class="table table-striped table-hover">
    <thead>
        <tr class="success">
            <th>
                <!-- recurso do framework(mostrar nome do atributo do objeto "Name" do objeto da lista)
               apenas o nome do atributo, não o valor. Até pq @model é uma lista-->
                @Html.DisplayNameFor(model => model.Name)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Email)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.BirthDate)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.BaseSalary)
            </th>
            <th></th>
        </tr>
    </thead>
      <!-- para cada item da lista -->
    <tbody>
        @foreach (var item in Model)
        {
        <tr>
            <td>
                <!-- DisplayFor mostra o conteúdo da propriedade acessada.
                Usa-se um apelido qualquer "modelItem", o que conta é  "item.Name"-->
                @Html.DisplayFor(modelItem => item.Name)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Email)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.BirthDate)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.BaseSalary)
            </td>
            <td>
                <a asp-action="Edit" asp-route-id="@item.Id">Edit</a>
                <a asp-action="Details" asp-route-id="@item.Id">Details</a>
                <a asp-action="Delete" asp-route-id="@item.Id">Delete</a>
            </td>
        </tr>

        }
    </tbody>

</table>

```

# LINQ	E	LAMBDA

```cs
//	inicializa	a	lista
            List<Conta> contas = new List<Conta>();
            //	inserimos	algumas	contas lista.Add(...);	
            Conta c1 = new Conta(1, "Ana", 2000);
            contas.Add(c1);
            Conta c2 = new Conta(2, "Paula", 1200);
            contas.Add(c2);
            Conta c3 = new Conta(3, "Ricardo", 2500);
            contas.Add(c3);
            Conta c4 = new Conta(4, "Bruno", 3000);
            contas.Add(c4);

            //	cria	lista	que	usaremos	para	guardar	os	elementos	filtrados 
            var filtrados	=	new	List<Conta>();


            foreach (Conta c in contas) {
                if (c.Saldo	>	2000)		{
                    filtrados.Add(c);
                }
            }
            //	agora	a	variavel	"filtrados"	tem	as	contas	que	queremos!
            Console.WriteLine("Filtrados");
            foreach (Conta c in filtrados)
            {
                Console.WriteLine("Nome: "+c.Name);
            }

```

## FILTROS	UTILIZANDO	O	LINQ

Para	filtrar	uma	lista,	seria	muito	mais	interessante	que	a	própria	coleção	tivesse	algum	método	que recebesse	a	condição	que	queremos	aplicar	nesse	filtro	e	já	implementasse	a	lógica	do		foreach	,	algo como:
```cs
List<Conta>	contas	=	//	inicializa	a	lista
var	filtradas	=	contas.Filtra(condição); 
```

Mas	como	passar	a	condição	para	esse	filtro?	Teríamos	que	enviar	um	bloco	de	código	que	aceita	ou rejeita	os	valores	da	coleção.	Para	passar	um	bloco	de	código	que	pode	ser	utilizado	por	um	método,	o C#	introduziu	as	funções	anônimas	ou	lambdas.	As	funções	anônimas	funcionam	como	métodos estáticos	da	linguagem	com	uma	declaração	simplificada.	Para	declarar	uma	função	anônima	que	recebe um	argumento	do	tipo		Conta		utilizamos	o	seguinte	código:

```cs
            //	inicializa	a	lista
            List<Conta> contas = new List<Conta>();
            //	inserimos	algumas	contas lista.Add(...);	
            Conta c1 = new Conta(1, "Ana", 2000);
            contas.Add(c1);
            Conta c2 = new Conta(2, "Paula", 1200);
            contas.Add(c2);
            Conta c3 = new Conta(3, "Ricardo", 2500);
            contas.Add(c3);
            Conta c4 = new Conta(4, "Bruno", 3000);
            contas.Add(c4);

            //	cria	lista	que	usaremos	para	guardar	os	elementos	filtrados 

            var filtradas = contas.Where((Conta c) => { return c.Saldo > 2000; });

            //	agora	a	variavel	"filtrados"	tem	as	contas	que	queremos!
            Console.WriteLine("Filtrados");
            foreach (Conta c in filtradas)
            {
                Console.WriteLine("Nome: "+c.Name);
            }

```

## 	SIMPLIFICANDO	A	DECLARAÇÃO	DO	LAMBDA

**Tipo** do retorno é redundante 

**Chaves e Return** desnecessário para uma linha de código

```cs
Conta	filtradas	=	contas.Where(c	=>	c.Saldo	>	2000	);
```

## 	OUTROS	MÉTODOS	DO	LINQ

Somar o saldo de todas as contas 
```cs
    List<Conta>	contas	=	//	inicializa	a	lista	de	contas 
    double	total	=	0.0;
    foreach(Conta	c	in	contas) {				
        total	+=	c.Saldo;
    } 
 ```
 
 Quando	queremos	fazer	a	soma	dos elementos	de	uma	lista,	podemos	utilizar	o	método	Sum	do	LINQ,	passando	um	lambda	que	fala	qual	é a	propriedade	da	conta	que	queremos	somar:

```cs
double	total	=	contas.Sum(c	=>	c.Saldo);
```

Com	essa	linha	de	código	conseguimos	o	mesmo	efeito	do		foreach		anterior.	Além	do		Sum	, também	podemos	utilizar	o	método	Average	para	calcular	a	média	dos	valores,	Count	para	contar	o número	de	valores	que	obedecem	algum	critério,	Min	para	calcular	o	menor	valor	e	Max	para	calcular	o maior	valor:

```cs
List<Conta>	contas	=	//	inicializa	a	lista
    
//	soma	dos	saldos	de	todas	as	contas
double	saldoTotal	=	contas.Sum(c	=>	c.Saldo);
//	media	do	saldo	das	contas 
double	mediaDosSaldos	=	contas.Average(c	=>	c.Saldo);
//	número	de	contas	que	possuem	Numero	menor	do	que	1000 
int	numero	=	contas.Count(c	=>	c.Numero	<	1000);
int	menorNumero	=	contas.Min(c	=>	c.Numero);
double	maiorSaldo	=	contas.Max(c	=>	c.Saldo); 
```

Quando	utilizamos	esses	métodos	de	agregação	em	uma	lista	com	tipos	primitivos,	o	lambda	é	um argumento	opcional.	Por	exemplo,	se	tivéssemos	uma	lista	de		double	,	poderíamos	utilizar	o	seguinte código	para	calcular	a	média	dos	números:

```cs
List<double>	saldos	=	//	inicializa	a	lista
double	media	=	saldos.Average();
```

## UTILIZANDO	O	LINQ	COM	OUTROS	TIPOS
Podemos	utilizar	o	LINQ	com	qualquer	objeto	que	implemente	a	interface		IEnumerable

## OUTROS FILTROS (OrderBy, ThenBy)																				
.ThenBy()

```cs
var	resultado	=	contas
.Where(c	=>	c.Saldo	>	10000)																				
.OrderBy(c	=>	c.Titular.Nome)																				
.ThenBy(c	=>	c.Numero);
```

## MELHORANDO	AS	BUSCAS	UTILIZANDO	A	SINTAXE	DE	QUERIES

```cs
var	filtradas	=	from	c	in	contas
where	c.Numero	<	2000																
select	c;
```

## 	PROJEÇÕES	E	OBJETOS	ANÔNIMOS

```cs
var	resultado	=	from	c	in	contas
where	<condição	da	busca>
select	new	{	c.Numero,	c.Titular	}; 
```

## 	ORDENANDO	COLEÇÕES	COM	LINQ

List<Conta>	contas	=	//	inicializa	a	lista	de	contas 
    var	resultado	=	from	c	in	contas
    where	c.Saldo	>	10000																
    orderby	c.Titular.Nome	descending,	c.Numero	descending																
    select	c;

