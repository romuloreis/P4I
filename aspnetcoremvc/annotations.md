**Required**

This attribute specifies that the value is mandatory and cannot be skipped.

Syntax

[Required(ErrorMessage="Please enter name"),MaxLength(30)]

**DataType**

This attribute is used to specify the datatype of the model.

Syntax

[DataType(DataType.Text)]

**Range**

Using this attribute we can set a range between two numbers.

Syntax

[Range(100,500,ErrorMessage="Please enter correct value")]

**StringLength**

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
