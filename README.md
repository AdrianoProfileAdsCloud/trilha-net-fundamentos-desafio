# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Este desafio proposto consiste em colocar em prática parte dos conhecimentos adquiridos no módulo de Fundamentos e C#,por se tratar de um Sitema simples como podemos verificar no Diagrama de classe; pelo menos nesta primeira versão que contempla o que foi solicitado no desafio não foi lançado mão de muitos recursos e até mesmo tratamento de erros etc.
  Mais como dito anteriormente se trata de uma primeira versão, ao final deste Bootcamp-Programação C# com CRM Dynamics, farei alterações siginificativas de acordo com os conhecimentos adquiridos no bootcamp.
   Alterações que contemplaram os conhimentos adquiridos nos módulos descritos abaixo; os quais os certificados de conclusão estão no Linkedin(www.linkedin.com/in/adssolutions):
* Sintaxe e Tipos de Dados em C#
* Tipos de Operadores em C#
* Operadores Aritméticos em C#
* Conhecendo as Estruturas de Repetição em C#
* Array e Listas em C#
* Propriedades, Métodos e Construtores com C#
* Manipulando Valores com C#
* Exceções e Coleções com C#

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Contruir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
O código foi concedido pela metade, dei continuidade obedecendo as regras descritas acima.

## Como Executar
Como dito anteriormente nao foi implementado tratamentos erros metodos adicionais ou qualquer outro tipo de melhoria até o presente momento, afim de cumprir o que foi pedido. Desta forma ao executar este programa siga exatamente o que é pedido, ou terá erros consequentemente a finalização do programa!

  Até os próximos ajustes....
