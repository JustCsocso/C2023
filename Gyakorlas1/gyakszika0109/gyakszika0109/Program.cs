using gyakszika0109;

ember e1 = new ember("Szakács", "Árpád");

Console.WriteLine(e1.teljesNev);
ember e2 = new ember("Nagy","Árpád");
Console.WriteLine(e2.teljesNev);


udvariasember ue1 = new udvariasember("Horváth", "Hugó");
Console.WriteLine(ue1.teljesNev);

ue1.koszon();
ue1.koszonoNeve();
ue1.koszon(ue1);
ue1.koszonoNeve(e1);

diak d1 = new diak("Tálas", "Miklós", 12);
diak d2 = new diak("Verbulecz", "Bálint", 19);
diak d3 = new diak("Mibajodvan", "Alehandró", 26);

d1.koszon(ue1);
d1.koszonoNeve(d2);