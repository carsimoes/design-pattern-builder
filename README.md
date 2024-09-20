# Padrão de projeto — Builder

O que é padrão de projeto:
Um padrão de projeto (ou design pattern) é uma solução geral reutilizável para um problema comum que ocorre no desenvolvimento de software. Esses padrões são descrições ou modelos abstratos que podem ser aplicados a diferentes cenários, fornecendo uma estrutura ou abordagem para resolver problemas recorrentes de design e arquitetura de sistemas com paradigma de programação orientada a objetos .

Os padrões de projeto são categorizados em três tipos principais:

Padrões Criacionais: Focados na criação de objetos, ajudando a abstrair o processo de instanciar classes.
Padrões Estruturais: Tratam da composição de classes e objetos para formar estruturas flexíveis e mais eficientes.
Padrões Comportamentais: Definem a integração e comunicação entre objetos e classes de forma a garantir flexibilidade e extensibilidade no sistema.
A ideia central dos padrões de projeto é promover boas práticas de design, como reutilização de código, redução de complexidade e aumento da flexibilidade, tornando o software mais fácil de manter e evoluir. Permitido assim adição de novas funcionalidades sem muita mudanças no código.

2. História

Os design patterns (padrões de projeto) foram popularizados por quatro autores conhecidos como a Gang of Four (GoF). Eles publicaram o livro clássico “Design Patterns: Elements of Reusable Object-Oriented Software” em 1994, que catalogou 23 padrões de projeto aplicáveis a sistemas orientados a objetos. Os autores são Erich Gamma, Richard Helm, Ralph Johnson John Vlissides.

O trabalho deles tornou-se uma referência fundamental para programadores, arquitetos engenheiros de software, ajudando a estabelecer uma linguagem comum para descrever soluções de design reutilizáveis.

3. Sobre o padrão de projeto Builder

3.1 Definição

O Builder é um padrão de projeto criacional, ele separa a construção de um objeto complexo da sua representação, permitindo que o mesmo processo de construção crie diferentes representações.


Acima temos uma imagem com o diagrama de classes da implementação do Builder, a seguir vamos descrever o comportamento de cada classe.

Produto: Essa é a classe que representa o objeto complexo construída pelo Builder, seria equivalente a um modelo.

Builder: A classe abstrata ou interface responsável pela criação do modelo, ela define todos os passos necessários para a criação do modelo, no caso o Produto.

ConcreteBuilder: A classe responsável pela criação efetivamente do produto, sendo filha e herdando ou implementando os métodos da interface Builder, para definir o passo a passo da criação do produto.

Director: A classe que orquestra vários builders para criação de diferentes representações do mesmo objeto.

3.2 Para que serve

Ideal para quando queremos evitar a complexidade de construtores longos ou com múltiplos parâmetros (telescópicos).

4. Vantagens do uso do padrão Builder

Uma das principais vantagens do padrão Builder é que ele permite a criação de objetos de maneira mais legível e modular, sem a necessidade de construtores longos ou sobrecarregados. O cliente pode configurar apenas os atributos que são necessários para sua aplicação, ignorando os que são irrelevantes. Além disso, ele permite a reutilização do processo de construção para criar diferentes representações do mesmo objeto, de acordo com as necessidades.

5. Exemplo prático

Segue um exemplo de diagrama de classes da implementação do padrão Builder


HamburgerBuilder (Classe Abstrata)

Esta é uma classe abstrata que define uma série de métodos “comuns” que as classes filhas devem implementar para construir um hambúrguer com diferentes ingredientes.
Métodos:
Build() : Hamburger: Retorna o objeto Hamburger após a construção.
WithBacon(bool hasBacon) : HamburgerBuilder: Adiciona bacon ao hambúrguer.
WithBread(string bread) : HamburgerBuilder: Define o tipo de pão.
WithCheese(bool hasCheese) : HamburgerBuilder: Adiciona queijo.
WithEgg(bool hasEgg) : HamburgerBuilder: Adiciona ovo.
WithMeat(string meat) : HamburgerBuilder: Define o tipo de carne.
WithSalad(bool hasLettuce, bool hasTomato, bool hasOnion, bool hasCucumber) : HamburgerBuilder: Define os componentes da salada.
WithSauce(string sauce) : HamburgerBuilder: Adiciona molho ao hambúrguer.
AlainProstHamburgerBuilder (Classe Concreta)

Esta classe herda de HamburgerBuilder e implementa os métodos definidos na classe abstrata para construir um hambúrguer específico com características definidas.
Métodos:
WithBacon()
WithBread()
WithCheese()
WithEgg()
WithMeat()
WithSalad()
WithSauce()
AyrtonSennaHamburgerBuilder (Classe Concreta)

Semelhante à classe anterior, herda de HamburgerBuilder e implementa seus próprios métodos para construir um hambúrguer no estilo Ayrton Senna.
Métodos:
WithBacon()
WithBread()
WithCheese()
WithEgg()
WithMeat()
WithSalad()
WithSauce()
NelsonPiquetHamburgerBuilder (Classe Concreta)

Outra classe concreta que herda de HamburgerBuilder, personalizando a construção de um hambúrguer de acordo com as preferências atribuídas a Nelson Piquet.
Métodos:
WithBacon()
WithBread()
WithCheese()
WithEgg()
WithMeat()
WithSalad()
WithSauce()
RubensBarricheloHamburgerBuilder (Classe Concreta)

Semelhante aos demais, mas com as características específicas de construção para o estilo de hambúrguer do Rubens Barrichelo.
SchumarHamburgerBuilder (Classe Concreta)

Implementa a construção de um hambúrguer no estilo “Schumar” com os ingredientes e método de construção específicos.
Hamburger (Classe)

Esta é a classe que representa o objeto final que será construído pelas classes “builders”.
Propriedades:
Bread : string: O tipo de pão.
HasBacon : bool: Se tem bacon ou não.
HasCheese : bool: Se tem queijo ou não.
HasEgg : bool: Se tem ovo ou não.
Meat : string: O tipo de carne.
Sauce : string: O tipo de molho.
Métodos:
Hamburger(): Construtor da classe.
ToString() : string: Método para retornar uma descrição textual do hambúrguer.
Salad (Classe)

Representa os ingredientes de salada que podem ser adicionados ao hambúrguer.
Propriedades:
HasCucumber : bool: Indica se tem pepino.
HasLettuce : bool: Indica se tem alface.
HasOnion : bool: Indica se tem cebola.
HasTomato : bool: Indica se tem tomate.
Métodos:
Salad(): Construtor da classe.
ToString() : string: Retorna uma descrição da salada.
HamburgerDirector (Classe)

Esta classe é responsável por gerenciar o processo de construção do hambúrguer usando os diferentes “builders”.
Métodos:
BuildAlainProstHamburger() : Hamburger
BuildAyrtonSennaHamburger() : Hamburger
BuildNelsonPiquetHamburger() : Hamburger
BuildRubensBarricheloHamburger() : Hamburger
BuildSchumarHamburger() : Hamburger
A classe HamburgerDirector coordena o processo de construção de diferentes tipos de hambúrgueres, utilizando diferentes classes concretas de HamburgerBuilder. Cada construtor especializado (como o AlainProstHamburgerBuilder ou AyrtonSennaHamburgerBuilder) implementa o processo de construção de um hambúrguer com suas próprias variações de ingredientes. O resultado final é um objeto Hamburger personalizado.

5. Diferenças com outros padrões criacionais

Uma distinção importante entre o Builder e outros padrões criacionais, como o Factory Method ou o Abstract Factory, é que o Builder se concentra na criação de objetos complexos que requerem a execução de vários passos ou etapas. Enquanto os padrões de fábrica são usados para a criação de objetos simples ou com variações pré-definidas, o Builder permite a criação de um objeto passo a passo, oferecendo maior controle e flexibilidade sobre o processo.

6. Conclusão

O padrão Builder é especialmente útil em cenários onde a criação de um objeto envolve muitas variáveis ou etapas complexas. Ele proporciona uma maneira estruturada e modular de construir objetos, melhorando a clareza do código e a separação de responsabilidades. Ao encapsular o processo de construção, ele facilita a manutenção e a evolução do software, permitindo a criação de produtos de forma consistente e flexível, sem sacrificar a simplicidade.
