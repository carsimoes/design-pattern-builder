using Builder.Director;

var hamburguerDirector = new HamburguerDirector();

var alainProstHamburguer = hamburguerDirector.BuildAlainProstHamburguer();

Console.WriteLine($"AlainProstHamburguer: {alainProstHamburguer}");

var ayrtonSennaHamburguer = hamburguerDirector.BuildAyrtonSennaHamburguer();
    
Console.WriteLine($"AyrtonSennaHamburguer: {ayrtonSennaHamburguer}");

var nelsonPiquetHamburguer = hamburguerDirector.BuildNelsonPiquetHamburguer();

Console.WriteLine($"NelsonPiquetHamburguer: {nelsonPiquetHamburguer}");

var rubensBaricheloHamburguer = hamburguerDirector.BuildRubensBaricheloHamburguer();

Console.WriteLine($"RubensBaricheloHamburguer: {rubensBaricheloHamburguer}");

var schumarHamburguer = hamburguerDirector.BuildSchumarHamburguer();
    
Console.WriteLine($"SchumarHamburguer: {schumarHamburguer}");



