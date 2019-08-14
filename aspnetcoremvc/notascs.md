# ESTRUTURAS	DE	CONTROLE

## Sintaxe

```cs

if	(condicao)	
{
				//	Esse	código	será	executado	somente	se	a	condição	for	verdadeira
}



double	n1	=	100.0;
double	n2	=	10.0;
if	(sn1	>=	n2)	
{
				n1	+=	n2;
}



double	n1	=	100.0;
double	n2	=	10.0;
if	(sn1	>=	n2)	
{
				n1	+=	n2;
}else{
      n1	-=	n2;
}


bool	souJovem	=	(idade	>=	18)	&&	(idade <	80);

```

# REPETINDO	UM	BLOCO	DE	CÓDIGO - LAÇOS DE REPETIÇÃO


## Sintaxe

```cs

for	(inicialização;	condição;	atualização)
{
				//	Esse	código	será	executado	enquanto	a	condição	for	verdadeira
}


double	valor	=	1000.0;
//Começar em 0 ou 1 faz diferença, afinal repere até que a condição seja verdadeira
for	(int	i	=	1;	i	<=	10;	i	+=	1)
{
				valor	=	valor	*	1.5;
}


do
{
				//	corpo	do	loop
}
while(condição);


double	valor	=	1000.0;
int	i	=	1;
while	(i	<=	10)
{
				valor	=	valor	*	1.9;
				i	+=	1;
}

do
{
				//	corpo	do	loop
}
while(condição);

```

## Comparações de string com C# 

[font](https://codigosimples.net/2018/09/26/comparacoes-de-string-com-c-7/)
Existem algumas maneiras diferentes de comparar strings em C # e .NET. O método String.Compare é usado para comparar duas strings. 
Você também pode usar o método String.Equals. Vamos ver como comparar string usando métodos diferentes e quando utilizá-los.

### String.Equals

A forma mais simples de dividir duas cadeias para o mesmo valor é usando o método String.Equals. Se ambas as strings forem iguais, 
o método retornará true; mais retorna falso. O exemplo de código abaixo é um exemplo de comparação de duas cadeias usando o 
método String.Equals.

```cs

    string author1 = "Jhonathan Soares";  
    string author2 = "João Sauro";  
    string author3 = "Jhonathan Soares";  
      
    // Compare strings using String.Equals  
    if (String.Equals(author1, author2))  
        Console.WriteLine($"{author1} and {author2} have same value.");  
    else  
        Console.WriteLine($"{author1} and {author2} are different.");  
      
    if (String.Equals(author1, author3))  
        Console.WriteLine($"{author1} and {author3} have same value.");  
    else  
        Console.WriteLine($"{author1} and {author3} are different.");  

```

### String.Compare

O método String.Compare compara duas strings e retorna um valor inteiro. O valor de retorno do método Compare pode ser menor que zero, maior que zero ou igual a zero.
Valor de retorno	Significado
Menos de 0	A primeira cadeia precede a segunda string na ordem de classificação.
0	Ambas as cadeias são iguais em valor.
Mais de 0	A primeira string procede a segunda string na ordem de classificação.
O exemplo de código é um exemplo de comparação de duas cadeias usando o método String.Compare

```cs
    string author1 = "João Hugo Silva";  
    string author2 = "Pedro Lopes Alves";  
      
    // Use String.Compare method  
    if (String.Compare(author1, author2) == 0)  
    Console.WriteLine($"Both strings have same value.");  
    else if (String.Compare(author1, author2) < 0)  
    Console.WriteLine($"{author1} precedes {author2}.");  
    else if (String.Compare(author1, author2) > 0)  
    Console.WriteLine($"{author1} follows {author2}."); 
```

### método CompareTo

O método CompareTo é um método de instância da classe string. Ele compara um valor (uma string ou um objeto) com uma instância de string. Os valores de retorno deste método são os mesmos do método Compare.
O exemplo de código é um exemplo de comparação de duas cadeias usando o método CompareTo.

```cs

     string author1 = "João Hugo Silva";  
    string author2 = "Pedro Lopes Alves";  
      
       // Use CompareTo method  
    if (author1.CompareTo(author2) == 0)  
        Console.WriteLine($"Both strings have same value.");  
    else if (author1.CompareTo(author2) < 0)  
        Console.WriteLine($"{author1} precedes {author2}.");  
    else if (author1.CompareTo(author2) > 0)  
        Console.WriteLine($"{author1} follows {author2}.");  

```

### StringComparer

Você também pode usar a classe StringComparer para comparar duas strings. 
O código abaixo é um exemplo de comparação de duas string usando o método StringComparer

```cs
    string author1 = "João Hugo Silva";  
    string author2 = "Pedro Lopes Alves";  
      
    //Use StringComparer  
    StringComparer comparer = StringComparer.OrdinalIgnoreCase;  
    if (comparer.Compare(author1, author2) == 0)  
        Console.WriteLine($"Both strings have same value.");  
    else if (comparer.Compare(author1, author2) < 0)  
        Console.WriteLine($"{author1} precedes {author2}.");  
    else if (comparer.Compare(author1, author2) > 0)  
        Console.WriteLine($"{author1} follows {author2}.");  
```

### Exemplo de código completo


```cs
                  Exemplo Completão

                   string author1 = "Pedro Hugo";  
                    string author2 = "Jhonathan Soares";  
                    string author3 = "Pedro Hugo";  
      
                    // Compare strings using String.Equals  
                    if (String.Equals(author1, author2))  
                        Console.WriteLine($"{author1} and {author2} have same value.");  
                    else  
                        Console.WriteLine($"{author1} and {author2} are different.");  
      
                    if (String.Equals(author1, author3))  
                        Console.WriteLine($"{author1} and {author3} have same value.");  
                    else  
                        Console.WriteLine($"{author1} and {author3} are different.");  
      
      
                // Use String.Compare method  
                if (String.Compare(author1, author2) == 0)  
                    Console.WriteLine($"Both strings have same value.");  
                else if (String.Compare(author1, author2) < 0)  
                    Console.WriteLine($"{author1} precedes {author2}.");  
                else if (String.Compare(author1, author2) > 0)  
                    Console.WriteLine($"{author1} follows {author2}.");  
      
                // Use CompareTo method  
                if (author1.CompareTo(author2) == 0)  
                    Console.WriteLine($"Both strings have same value.");  
                else if (author1.CompareTo(author2) < 0)  
                    Console.WriteLine($"{author1} precedes {author2}.");  
                else if (author1.CompareTo(author2) > 0)  
                    Console.WriteLine($"{author1} follows {author2}.");  
      
                //Use StringComparer  
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;  
                if (comparer.Compare(author1, author2) == 0)  
                    Console.WriteLine($"Both strings have same value.");  
                else if (comparer.Compare(author1, author2) < 0)  
                    Console.WriteLine($"{author1} precedes {author2}.");  
                else if (comparer.Compare(author1, author2) > 0)  
                    Console.WriteLine($"{author1} follows {author2}.");
                Console.ReadKey();  

```

## CLASSES

Por padrão, os nomes das classes e seus arquivos inicial com letra maiuscula.
O nome da classe deve usar palavra _class_ antes da declaração.
O nome da classe deve ser o mesmo nome do arquivo.cs
variáveis dentro da classe, essas variáveis são os atributos.

```cs
//Conta.cs

class Conta
{
	int	numero;
	string	titular;
	double	saldo;
}

```
Para instanciar um objeto, podemos usar a seguinte sintaxe:

```cs
//Instância um objeto
new Conta();
//Atribui uma nova instância à x
Conta x = new Conta();
//Note que vai ocorrer um erro, pois os atributos são privados e não estão publicos
x.numero = 2;
```
Para que os atributos sejam acessiveis, é necessário torna-los publicos, usando a palavra _public_

	> Explicar referência de memória, indicando que o x aponta para o endereço de memória onde está armazenado o objeto (39-40)

```cs
//Conta.cs
class Conta
{
	public int numero;
	public string titular;
	public double saldo;
}

```

```cs

Conta x = new Conta();
x.numero = 2;

```


### MÉTODOS

```cs
//Método que não devolve nada _void_
public void Saca()
{
	if(this.saldo >=100.0)
	{
		this.saldo-=100.0;
	}
}
```

```cs

//Método que devolve um valor _bool_
public	bool	Saca(double	valor)
{
	if(this.saldo>=valor)
	{
	this.saldo-=valor;
	return true;
	}
	else
	{
	return false;
	}
}
```


```cs
//Pegando retorno do método (42-44)
Conta	c	=	new	Conta();
//	inicializa	os	atributos
bool teste = c.Saca(100.0);
if(c.Saca(100.0))
{
MessageBox.Show("Saque	realizado	com	sucesso");
}
else
{
MessageBox.Show("Saldo	Insuficiente");
}
```

### ARGUMENTOS E PARAMETROS

public void (int a, string b)
{
//IMPLEMENTAÇÃO
}


### FIZZBUZZ

###  COMPOSIÇÃO DE CLASSES

Conta tem Titular


### ENCAPSULAMENTO E MODIFICADORES DE ACESSO


### CONTROLANDO O ACESSO COM PROPERTIES E AUTO PROPERTIES E SUAS NOMECLATURAS

### CONSTRUTORES

