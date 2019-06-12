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

## Códigos

Nosso	banco	armazena	uma	lista	de	contas.	Essas	contas	possuem	os	mais	variados	correntistas,	saldos	e tipos.	Muitas	vezes,	precisamos	filtrá-las	de	alguma	forma.	Por	exemplo,	se	quisermos	pegar	todas	as contas	com	saldo	maior	que	2000	reais,	fazemos:

Se	complicarmos	ainda	mais	o	filtro	(por	exemplo,	contas	com	saldo	maior	que	2000	e	menor	que 5000,	com	data	de	abertura	entre	os	anos	2010	e	2012,	...),	nosso	código	ficará	também	mais	complexo, além	disso,	se	quiséssemos	aplicar	um	filtro	em	uma	lista	com	outro	tipo	de	objeto,	teríamos	que	repetir novamente	o	código	do		foreach		em	diversos	pontos	da	aplicação.


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



