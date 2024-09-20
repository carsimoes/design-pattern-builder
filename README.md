# Padrão de projeto — Builder

O que é padrão de projeto:
Um padrão de projeto (ou design pattern) é uma solução geral reutilizável para um problema comum que ocorre no desenvolvimento de software. Esses padrões são descrições ou modelos abstratos que podem ser aplicados a diferentes cenários, fornecendo uma estrutura ou abordagem para resolver problemas recorrentes de design e arquitetura de sistemas com paradigma de programação orientada a objetos .


## HamburgerBuilder (Classe Abstrata)
Esta é uma classe abstrata que define uma série de métodos “comuns” que as classes filhas devem implementar para construir um hambúrguer com diferentes ingredientes.

## AlainProstHamburgerBuilder (Classe Concreta)
Esta classe herda de HamburgerBuilder e implementa os métodos definidos na classe abstrata para construir um hambúrguer específico com características definidas.

## AyrtonSennaHamburgerBuilder (Classe Concreta)

Semelhante à classe anterior, herda de HamburgerBuilder e implementa seus próprios métodos para construir um hambúrguer no estilo Ayrton Senna.

## NelsonPiquetHamburgerBuilder (Classe Concreta)
Outra classe concreta que herda de HamburgerBuilder, personalizando a construção de um hambúrguer de acordo com as preferências atribuídas a Nelson Piquet.

## RubensBarricheloHamburgerBuilder (Classe Concreta)
Semelhante aos demais, mas com as características específicas de construção para o estilo de hambúrguer do Rubens Barrichelo.

## SchumarHamburgerBuilder (Classe Concreta)
Implementa a construção de um hambúrguer no estilo “Schumar” com os ingredientes e método de construção específicos.

## Hamburger (Classe)
Esta é a classe que representa o objeto final que será construído pelas classes “builders”.

## Salad (Classe)
Representa os ingredientes de salada que podem ser adicionados ao hambúrguer.

## HamburgerDirector (Classe)
Esta classe é responsável por gerenciar o processo de construção do hambúrguer usando os diferentes “builders”.

A classe HamburgerDirector coordena o processo de construção de diferentes tipos de hambúrgueres, utilizando diferentes classes concretas de HamburgerBuilder. Cada construtor especializado (como o AlainProstHamburgerBuilder ou AyrtonSennaHamburgerBuilder) implementa o processo de construção de um hambúrguer com suas próprias variações de ingredientes. O resultado final é um objeto Hamburger personalizado.

## Conclusão

O padrão Builder é especialmente útil em cenários onde a criação de um objeto envolve muitas variáveis ou etapas complexas. Ele proporciona uma maneira estruturada e modular de construir objetos, melhorando a clareza do código e a separação de responsabilidades. Ao encapsular o processo de construção, ele facilita a manutenção e a evolução do software, permitindo a criação de produtos de forma consistente e flexível, sem sacrificar a simplicidade.
