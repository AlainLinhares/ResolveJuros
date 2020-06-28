
# ResolveJuros

Aplicação que cria APIs com o intuito de fazer operações de juros (não possui interface gráfica)

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



# Bibliotecas Externas
Foi usada uma biblioteca chamada MockHttp no projeto de testes. Essa biblioteca funciona como uma camada de teste para a biblioteca HttpClient. Permitindo que respostas mockadas sejam configuradas para solicitações HTTP correspondentes e pode ser usado para testar a camada de serviço da aplicação.

Os links são:
https://www.nuget.org/packages/RichardSzalay.MockHttp/
https://github.com/richardszalay/mockhttp

O link do texto da licença é: https://github.com/richardszalay/mockhttp/blob/master/LICENSE

Como é solicitado, é necessário colocar o texto da licença:
The MIT License (MIT)

Copyright (c) 2014 Richard Szalay

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


**Desenvolvedor**: Alain Melo

**Email**: arllmcomputação@gmail.com
