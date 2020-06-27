
# ResolveJuros

Código que cria duas APIs com o intuito de fazer operações de juros (não possui interface gráfica)

# APIs

A aplicação possui as seguintes API's:

- /taxaJuros

- /calculajuros/{valorInicial}/{tempo};

- /showmethecode

  # Swagger

Para a documentação das APIs foi usado o swagger. Depois que for feito o deploy da aplicação, basta acessar: http://localhost:4000/swagger (usa a interface gráfica nativa do swagger).

# Deploy e Build

Essa aplicação usa docker, nas configurações atuais a porta que será usada pela aplicação será a: **4000**.

Portanto, quando forem executados os seguintes comandos:

- docker build . -t resolvejuros

- docker stack deploy -c docker-stack.yaml resolveJuros

Apos isso, basta usar alguma ferramenta para consultar as APIs como o por exemplo **Postman**.

As URLs são:

- http://localhost:4000/taxaJuros;

- http://localhost:4000/calculajuros/{valorInicial}/{tempo};

- http://localhost:4000/showmethecode;



**Desenvolvedor**: Alain Melo

**Email**: arllmcomputação@gmail.com