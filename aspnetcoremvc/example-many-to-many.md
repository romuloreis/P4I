```cs    
    
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Categorization> Categorizations { get; set; }
        
        /*Esse método vai ser chamado no index, para mostrar Yes ou No no ligar de true ou false*/
        [Display(Name = "Is this good?")]
        public string IsGoodDisplay
        {
            get
            {
                if (IsGood)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
    }
    
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public ICollection<Categorization> Categorizations { get; set; }
    }
    
    
    public class Categorization
    {   
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
     }     
```

```cs
    /*DBCONTEXT*/
        public DbSet<Relation.Models.Category> Categories { get; set; }

        public DbSet<Relation.Models.Product> Products { get; set; }

        public DbSet<Relation.Models.Categorization> Categorizations { get; set; }
        /*romulo*/
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Categorization>().HasKey(c => new {c.CategoryId, c.ProductId});
        }
```

```html
/*INDEX*/
<table class="table">
    <thead>
        <tr>
            <th>
                @Html.DisplayNameFor(model => model.Name)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.IsGoodDisplay)
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in Model)
        {
            <tr>
                <td>
                    @Html.DisplayFor(modelItem => item.Name)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.IsGoodDisplay)
                </td>
                <td>
                    <a asp-action="Edit" asp-route-id="@item.CategoryId">Edit</a> |
                    <a asp-action="Details" asp-route-id="@item.CategoryId">Details</a> |
                    <a asp-action="Delete" asp-route-id="@item.CategoryId">Delete</a>
                </td>
            </tr>
        }
    </tbody>
</table>
```
