Atributos internos
Aqui estão alguns dos atributos de validação internos:
[CreditCard]: valida se a propriedade tem um formato de cartão de crédito.
[Compare]: valida se duas propriedades em um modelo são correspondentes.
[EmailAddress]: valida se a propriedade tem um formato de email.
[Phone]: valida se a propriedade tem um formato de número de telefone.
[RegularExpression]: valida se o valor da propriedade corresponde à expressão regular especificada.
[Url]: valida se a propriedade tem um formato de URL.
[Remote]: valida a entrada no cliente chamando um método de ação no servidor. Consulte atributo [Remote] para obter detalhes sobre o comportamento desse atributo.


**Required**
Valida se o campo não é nulo. Consulte atributo.
This attribute specifies that the value is mandatory and cannot be skipped.

Syntax

[Required(ErrorMessage="Please enter name"),MaxLength(30)]

**DataType**

This attribute is used to specify the datatype of the model.

Syntax

[DataType(DataType.Text)]

**Range**
Valida se o valor da propriedade está dentro de um intervalo especificado.
Using this attribute we can set a range between two numbers.

Syntax

[Range(100,500,ErrorMessage="Please enter correct value")]

**StringLength**
Valida se um valor da propriedade de cadeia de caracteres não excede um limite de comprimento especificado.
Using this attribute we can specify maximum and minimum length of the property.

Syntax

[StringLength(30,ErrorMessage="Do not enter more than 30 characters")]

**DisplayName**

Using this attribute we can specify property name to be displayed on view.

Syntax

[Display(Name="Student Name")]

**MaxLength**

Using this attribute we can specify maximum length of property.

Syntax

[MaxLength(3)]

**Bind**

This attribute specify fields to include or exclude for model binding.

Syntax

[Bind(Exclude = "StudentID")]

**DisplayFormat**

This attribute allows us to set date in the format specified as per the attribute.

Syntax

[DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]

**RegularExpression**

We can set a regex pattern for the property. For ex: Email ID.

Syntax

[RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]


  - [Article about phone  number validation](https://sensibledev.com/phone-number-validation-in-asp-net/)
  - [compare-validator-in-mvc](https://sensibledev.com/compare-validator-in-mvc/)
  - [mvc multiple file upload](https://sensibledev.com/mvc-multiple-file-upload/)
  
  - [Concepts](https://sensibledev.com/entity-framework-interview-questions/)
