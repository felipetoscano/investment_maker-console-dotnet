# investment-maker
Projeto em C# que realiza investimentos, utilizando o Design Pattern Strategy

Quando utilizamos uma hierarquia, como fizemos com a interface IInvestment e as implementações AgressiveInvestment, ModerateInvestment e ConservativeInvestment, e recebemos o tipo mais genérico como parâmetro, para ganharmos o polimorfismo na regra que será executada, simplificando o código e sua evolução, estamos usando o Design Pattern chamado Strategy.
