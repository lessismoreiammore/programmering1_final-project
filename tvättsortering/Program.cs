using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smart_laundry
{
    class Program
    {
        //Skapa en klass som lagrar objekter med information om inmatade kläder
        public class Clothing
        {
            public string name;
            //svart, vit, ljus, kulört, mörk
            public string color;
            //sport, barn, fin, hus
            public string function_type;
            //bomull, syntet, silk, ull, jeans
            public string fabric_type;
        }

        //Skapa en klass som lagrar objekter med information om en inställning
        class Install
        {
            public int temprature;
            public int centrifugation;
            public int index;

            //Jag skriver en konstruktor för att göra inmatning av inställningar
            public Install(int index, int temperature, int centrifugation)
            {
                this.temprature = temperature;
                this.centrifugation = centrifugation;
                this.index = index;
            }
        }

        //Skapa en klass som lagrar en list av objekter med inställningar
        class ProgramList
        {
            public List<Install> programs = new List<Install>();

            //Jag vill skriva ett program som kan arbeta i verkligheten, dvs med verkliga avtal av parameter. Dessutom har jag så långa if-loopar i metoden
            //Jag vill också öva om jag kan arbeta med många information. Jag tror jag lyckas. Jag känner mig mer säkert i programmering nu
            public int ProgramSearch(Clothing clothing)
            {
                if (clothing.color == "svart" && clothing.function_type == "sport" && clothing.fabric_type == "syntet" ||
                    clothing.color == "svart" && clothing.function_type == "hus" && clothing.fabric_type == "syntet" ||
                    clothing.color == "vit" && clothing.function_type == "fin" && clothing.fabric_type == "syntet" ||
                    clothing.color == "ljus" && clothing.function_type == "fin" && clothing.fabric_type == "syntet")
                {
                    return 1;
                }
                else if (clothing.color == "kulört" && clothing.function_type == "fin" && clothing.fabric_type == "syntet" ||
                        clothing.color == "mörk" && clothing.function_type == "sport" && clothing.fabric_type == "syntet" ||
                        clothing.color == "kulört" && clothing.function_type == "sport" && clothing.fabric_type == "syntet"
                    )
                {
                    return 2;
                }
                else if (clothing.color == "svart" && clothing.function_type == "sport" && clothing.fabric_type == "silk" ||
                        clothing.color == "svart" && clothing.function_type == "sport" && clothing.fabric_type == "ull" ||
                        clothing.color == "vit" && clothing.function_type == "sport" && clothing.fabric_type == "silk" ||
                        clothing.color == "vit" && clothing.function_type == "sport" && clothing.fabric_type == "ull" ||
                        clothing.color == "kulört" && clothing.function_type == "sport" && clothing.fabric_type == "bomull" ||
                        clothing.color == "kulört" && clothing.function_type == "sport" && clothing.fabric_type == "jeans" ||
                        clothing.color == "mörk" && clothing.function_type == "hus" && clothing.fabric_type == "syntet" ||
                        clothing.color == "svart" && clothing.function_type == "fin" && clothing.fabric_type == "syntet" ||
                        clothing.color == "mörk" && clothing.function_type == "fin" && clothing.fabric_type == "syntet" ||
                        clothing.color == "kulört" && clothing.function_type == "fin" && clothing.fabric_type == "bomull" ||
                        clothing.color == "kulört" && clothing.function_type == "fin" && clothing.fabric_type == "jeans"
                        )
                {
                    return 3;
                }
                else if (clothing.color == "ljus" && clothing.function_type == "fin" && clothing.fabric_type == "ull" ||
                        clothing.color == "ljus" && clothing.function_type == "fin" && clothing.fabric_type == "silk" ||
                        clothing.color == "kulört" && clothing.function_type == "fin" && clothing.fabric_type == "ull" ||
                        clothing.color == "kulört" && clothing.function_type == "fin" && clothing.fabric_type == "silk" ||
                        clothing.color == "vit" && clothing.function_type == "fin" && clothing.fabric_type == "ull" ||
                        clothing.color == "vit" && clothing.function_type == "fin" && clothing.fabric_type == "silk" ||
                        clothing.color == "mörk" && clothing.function_type == "fin" && clothing.fabric_type == "ull" ||
                        clothing.color == "mörk" && clothing.function_type == "fin" && clothing.fabric_type == "silk" ||
                        clothing.color == "svart" && clothing.function_type == "fin" && clothing.fabric_type == "ull" ||
                        clothing.color == "svart" && clothing.function_type == "fin" && clothing.fabric_type == "silk" ||
                        clothing.color == "mörk" && clothing.function_type == "sport" && clothing.fabric_type == "silk" ||
                        clothing.color == "mörk" && clothing.function_type == "sport" && clothing.fabric_type == "ull" ||
                        clothing.color == "kulört" && clothing.function_type == "sport" && clothing.fabric_type == "silk" ||
                        clothing.color == "kulört" && clothing.function_type == "sport" && clothing.fabric_type == "ull" ||
                        clothing.color == "ljus" && clothing.function_type == "sport" && clothing.fabric_type == "silk" ||
                        clothing.color == "ljus" && clothing.function_type == "sport" && clothing.fabric_type == "ull" ||
                        clothing.color == "svart" && clothing.function_type == "barn" && clothing.fabric_type == "silk" ||
                        clothing.color == "svart" && clothing.function_type == "barn" && clothing.fabric_type == "ull" ||
                        clothing.color == "vit" && clothing.function_type == "barn" && clothing.fabric_type == "silk" ||
                        clothing.color == "vit" && clothing.function_type == "barn" && clothing.fabric_type == "ull" ||
                        clothing.color == "mörk" && clothing.function_type == "barn" && clothing.fabric_type == "syntet" ||
                        clothing.color == "mörk" && clothing.function_type == "barn" && clothing.fabric_type == "silk" ||
                        clothing.color == "mörk" && clothing.function_type == "barn" && clothing.fabric_type == "ull" ||
                        clothing.color == "kulört" && clothing.function_type == "barn" && clothing.fabric_type == "syntet" ||
                        clothing.color == "kulört" && clothing.function_type == "barn" && clothing.fabric_type == "silk" ||
                        clothing.color == "kulört" && clothing.function_type == "barn" && clothing.fabric_type == "ull" ||
                        clothing.color == "ljus" && clothing.function_type == "barn" && clothing.fabric_type == "silk" ||
                        clothing.color == "ljus" && clothing.function_type == "barn" && clothing.fabric_type == "ull" ||
                        clothing.color == "svart" && clothing.function_type == "hus" && clothing.fabric_type == "silk" ||
                        clothing.color == "svart" && clothing.function_type == "hus" && clothing.fabric_type == "ull" ||
                        clothing.color == "vit" && clothing.function_type == "hus" && clothing.fabric_type == "silk" ||
                        clothing.color == "vit" && clothing.function_type == "hus" && clothing.fabric_type == "ull" ||
                        clothing.color == "mörk" && clothing.function_type == "hus" && clothing.fabric_type == "silk" ||
                        clothing.color == "mörk" && clothing.function_type == "hus" && clothing.fabric_type == "ull" ||
                        clothing.color == "ljus" && clothing.function_type == "hus" && clothing.fabric_type == "ull" ||
                        clothing.color == "ljus" && clothing.function_type == "hus" && clothing.fabric_type == "silk"
                        )
                {
                    return 4;
                }
                else if (clothing.color == "kulört" && clothing.function_type == "hus" && clothing.fabric_type == "silk" ||
                        clothing.color == "kulört" && clothing.function_type == "hus" && clothing.fabric_type == "ull"
                        )
                {
                    return 5;
                }
                else if (clothing.color == "vit" && clothing.function_type == "barn" && clothing.fabric_type == "syntet"
                        )
                {
                    return 6;
                }
                else if (clothing.color == "vit" && clothing.function_type == "sport" && clothing.fabric_type == "syntet" ||
                        clothing.color == "ljus" && clothing.function_type == "sport" && clothing.fabric_type == "syntet" ||
                        clothing.color == "vit" && clothing.function_type == "fin" && clothing.fabric_type == "bomull" ||
                        clothing.color == "vit" && clothing.function_type == "fin" && clothing.fabric_type == "jeans" ||
                        clothing.color == "ljus" && clothing.function_type == "barn" && clothing.fabric_type == "syntet"
                        )
                {
                    return 7;
                }
                else if (clothing.color == "svart" && clothing.function_type == "sport" && clothing.fabric_type == "bomull" ||
                        clothing.color == "black" && clothing.function_type == "sport" && clothing.fabric_type == "jeans" ||
                        clothing.color == "mörk" && clothing.function_type == "sport" && clothing.fabric_type == "bomull" ||
                        clothing.color == "mörk" && clothing.function_type == "sport" && clothing.fabric_type == "jeans" ||
                        clothing.color == "ljus" && clothing.function_type == "sport" && clothing.fabric_type == "bomull" ||
                        clothing.color == "ljus" && clothing.function_type == "sport" && clothing.fabric_type == "jeans" ||
                        clothing.color == "ljus" && clothing.function_type == "fin" && clothing.fabric_type == "bomull" ||
                        clothing.color == "ljus" && clothing.function_type == "fin" && clothing.fabric_type == "jeans" ||
                        clothing.color == "svart" && clothing.function_type == "barn" && clothing.fabric_type == "bomull" ||
                        clothing.color == "svart" && clothing.function_type == "barn" && clothing.fabric_type == "jeans" ||
                        clothing.color == "svart" && clothing.function_type == "barn" && clothing.fabric_type == "syntet" ||
                        clothing.color == "svart" && clothing.function_type == "hus" && clothing.fabric_type == "bomull" ||
                        clothing.color == "svart" && clothing.function_type == "hus" && clothing.fabric_type == "jeans"
                        )
                {
                    return 8;
                }
                else if (clothing.color == "svart" && clothing.function_type == "fin" && clothing.fabric_type == "bomull" ||
                        clothing.color == "svart" && clothing.function_type == "fin" && clothing.fabric_type == "jeans" ||
                        clothing.color == "mörk" && clothing.function_type == "fin" && clothing.fabric_type == "bomull" ||
                        clothing.color == "mörk" && clothing.function_type == "fin" && clothing.fabric_type == "jeans" ||
                        clothing.color == "mörk" && clothing.function_type == "barn" && clothing.fabric_type == "bomull" ||
                        clothing.color == "mörk" && clothing.function_type == "barn" && clothing.fabric_type == "jeans" ||
                        clothing.color == "kulört" && clothing.function_type == "barn" && clothing.fabric_type == "bomull" ||
                        clothing.color == "kulört" && clothing.function_type == "barn" && clothing.fabric_type == "jeans" ||
                        clothing.color == "mörk" && clothing.function_type == "hus" && clothing.fabric_type == "bomull" ||
                        clothing.color == "mörk" && clothing.function_type == "hus" && clothing.fabric_type == "jeans" ||
                        clothing.color == "kulört" && clothing.function_type == "hus" && clothing.fabric_type == "bomull" ||
                        clothing.color == "kulört" && clothing.function_type == "hus" && clothing.fabric_type == "jeans" ||
                        clothing.color == "kulört" && clothing.function_type == "hus" && clothing.fabric_type == "syntet"
                        )
                {
                    return 9;
                }
                else if (clothing.color == "vit" && clothing.function_type == "hus" && clothing.fabric_type == "syntet"
                        )
                {
                    return 10;
                }
                else if (clothing.color == "vit" && clothing.function_type == "barn" && clothing.fabric_type == "bomull" ||
                        clothing.color == "vit" && clothing.function_type == "barn" && clothing.fabric_type == "jeans" ||
                        clothing.color == "ljus" && clothing.function_type == "hus" && clothing.fabric_type == "syntet" ||
                        clothing.color == "vit" && clothing.function_type == "sport" && clothing.fabric_type == "bomull" ||
                        clothing.color == "vit" && clothing.function_type == "sport" && clothing.fabric_type == "jeans")
                {
                    return 11;
                }
                else if (clothing.color == "ljus" && clothing.function_type == "barn" && clothing.fabric_type == "bomull" ||
                        clothing.color == "ljus" && clothing.function_type == "barn" && clothing.fabric_type == "jeans"
                        )
                {
                    return 12;
                }
                else if (clothing.color == "vit" && clothing.function_type == "hus" && clothing.fabric_type == "bomull" ||
                        clothing.color == "vit" && clothing.function_type == "hus" && clothing.fabric_type == "jeans")
                {
                    return 13;
                }
                else if (clothing.color == "ljus" && clothing.function_type == "hus" && clothing.fabric_type == "bomull" ||
                        clothing.color == "ljus" && clothing.function_type == "hus" && clothing.fabric_type == "jeans"
                        )
                {
                    return 14;
                }

                return 0;
            }

            //Sökning metod som returear inställningar enligt index
            public Install GetInstallByIndex(int index)
            {
                for (int i = 0; i < programs.Count; i++)
                {
                    if (index == programs[i].index)
                    {
                        return programs[i];
                    }
                }
                return null;
            }
        }

        // Skapa en klass som lagrar objekter som består själv av objekter Clothing och index som väjers enligt Clothing parameter
        public class ClothingWithIndex
        {
            public Clothing clothing;
            public int index;
        }

        //Sortering metod som hjälper att sortera objekter i listan ClothingWithIndex enligt deras index från minmala till maximala. 
        //Minimala index betyder att instälningar är mjuka, med andra ord några styck kläder kan tvättas tillsammans med denna mjuka inställningar
        public static List<ClothingWithIndex> Sort(List<ClothingWithIndex> list)
        {

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    if (list[j].index > list[j + 1].index)
                    {
                        ClothingWithIndex temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }

        //Metoden som visar listan av inmatade kläder
        static void ShowClothing(List<Clothing> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int n = i + 1;
                Console.WriteLine(n + ": " + list[i].name + " " + list[i].color + " " + list[i].fabric_type + " " + list[i].function_type);
            }
        }

        static void Main(string[] args)
        {
            //Dekalration av listor

            //List som innehåller objketer Clothing med användares inmatade parameter av kläder
            List<Clothing> laundry = new List<Clothing>();
            //List som innehåller objekter ProgramList med list av inställnigar av objekter med klass Install
            ProgramList programList = new ProgramList();

            //Inställningar deklaration och värde tilldellning
            //Denna värden är faktiska, vänligen testa programmet med dina egna kläder!
            programList.programs.Add(new Install(1, 30, 1000));
            programList.programs.Add(new Install(2, 30, 800));
            programList.programs.Add(new Install(3, 30, 600));
            programList.programs.Add(new Install(4, 30, 400));
            programList.programs.Add(new Install(5, 30, 300));

            programList.programs.Add(new Install(6, 40, 1200));
            programList.programs.Add(new Install(7, 40, 1000));
            programList.programs.Add(new Install(8, 40, 800));
            programList.programs.Add(new Install(9, 40, 600));

            programList.programs.Add(new Install(10, 60, 1200));
            programList.programs.Add(new Install(11, 60, 1000));
            programList.programs.Add(new Install(12, 60, 800));

            programList.programs.Add(new Install(13, 90, 1200));
            programList.programs.Add(new Install(14, 90, 800));


            //Inledning meddelande
            Console.WriteLine("Hej! Välkommen till smart tvätt!");
            Console.WriteLine("Välja vad vill du göra nu från menyn");
            Console.WriteLine();

            //Huvuddel av program. Anv'ndare väljer vad att göra på menyn

            //Variabel check skapas för att avsluta while-loopen på ett bra sätt
            bool check = true;
            while (check)
            {
                Console.WriteLine();
                Console.WriteLine("[1]Mata in kläder");
                Console.WriteLine("[2]Visa en list av inmatade kläder");
                Console.WriteLine("[3]Få råd om program som passar till alla inmatade kläder");
                Console.WriteLine("[4]Visa en list av inmatade kläder med unika rekommenderade inställningar");
                Console.WriteLine("[5]Avsluta");
                Console.WriteLine();
                int userChoice = Convert.ToInt32(Console.ReadLine());

                //Jag vet att användare bara tre möjligheter i menyn eftersom jag tycker att switch-loopen är optimal att använda här
                switch (userChoice)
                {
                    case (1):
                        //Kanske kan jag göra en submeny för att man ska inte göra fel genom inmatnning
                        //Tvärtemot bestämde jag mig för att inte försvarar program och koncentrera istallet på klasser
                        //På grund av detta ger jag instruktioner till användare vad behövs att skriva in
                        //På samma sätt ger jag några vinkar vad jag menar med några kategorier. 
                        //Jag tror att när jag har mer erfarenhet i programmering ska jag göra en möjlighet att gömma denna vinkar om användaren vill
                        Clothing clothing = new Clothing();

                        Console.Write("Mata in namn av kläder. Skriv t.e. byxor, jeans: ");
                        string userName = Console.ReadLine();
                        clothing.name = userName;

                        /*Console.WriteLine();
                        Console.WriteLine("Enligt färg kan kläder vanligen delas i 5 kategorien.");
                        Console.WriteLine("Nämligen svart, vit, mörk, ljus och kulört.");
                        Console.WriteLine("Använd gärna någon av denna kategori via inmattning");
                        Console.WriteLine("Om din kläder har mönster skriva in en färg som du ser mest på kläder");
                        Console.Write("Mata in färg av kläder: ");
                        string userColor = Console.ReadLine();
                        clothing.color = userColor;*/

                        //Jag vet att min användare får inmata bara 5 string med särskilt värde. Istället att använda try&catch jag fördrar att loopa indata till anvädare skriver in den rätt
                        //Färg inmatning
                        bool checkColor = true;
                        while (checkColor)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enligt färg kan kläder vanligen delas i 5 kategorien.");
                            Console.WriteLine("Nämligen svart, vit, mörk, ljus och kulört.");
                            Console.WriteLine("Använd gärna någon av denna kategori via inmattning");
                            Console.WriteLine("Om din kläder har mönster skriva in en färg som du ser mest på kläder");
                            Console.Write("Mata in färg av kläder: ");
                            string userColor = Console.ReadLine();
                            if (userColor == "svart" || userColor == "vit" || userColor == "mörk" || userColor == "ljus" || userColor == "kulört")
                            {
                                clothing.color = userColor;
                                checkColor = false;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Fel! Du får skriva in bara svart, vit, mörk och ljus");
                                Console.WriteLine("Läsa noga instruktioner igen!");
                            }
                        }

                        bool checkFabric = true;
                        while (checkFabric)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enligt tygtyp kan kläder vanligen tillhör 4 grupper.");
                            Console.WriteLine("Nämligen bomull, syntet, jeans, silk och ull");
                            Console.WriteLine("Om du är inte säkert titta på kläders etikett.");
                            Console.WriteLine("Om det består av några tyg skriv in den som har störst procent");
                            Console.WriteLine("Gruppen syntet tillhör polyester, nylon, elastan, polyamid, polyuretan ");
                            Console.WriteLine("Gruppen bomull tillhör viskos, bomull, modal, jersey");
                            Console.Write("Mata in tygtyp av kläder: ");
                            string userFabric = Console.ReadLine();
                            if (userFabric == "bomull" || userFabric == "jeans" || userFabric == "silk" || userFabric == "ull" || userFabric == "syntet")
                            {
                                clothing.fabric_type = userFabric;
                                checkFabric = false;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Fel! Du får skriva in bara bomull, jeans, silk, ull och kulört");
                                Console.WriteLine("Läsa noga instruktioner igen!");
                            }
                        }

                        /*Console.WriteLine();
                        Console.WriteLine("Enligt tygtyp kan kläder vanligen tillhör 4 grupper.");
                        Console.WriteLine("Nämligen bomull, syntet, jeans, silk och ull");
                        Console.WriteLine("Om du är inte säkert titta på kläders etikett.");
                        Console.WriteLine("Om det består av några tyg skriv in den som har störst procent");
                        Console.WriteLine("Gruppen syntet tillhör polyester, nylon, elastan, polyamid, polyuretan ");
                        Console.WriteLine("Gruppen bomull tillhör viskos, bomull, modal, jersey");
                        Console.Write("Mata in tygtyp av kläder: ");
                        string userFabric = Console.ReadLine();
                        clothing.fabric_type = userFabric;*/

                        bool checkFunction = true;
                        while (checkFunction)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enligt function kan kläder vanligen delas i 4 kategorien.");
                            Console.WriteLine("Nämligen sport, barn, fin och hus.");
                            Console.WriteLine("Exempelvis lakan tillhör hus kategori.");
                            Console.WriteLine("Om det är vardaglig kläder skriv in gärna fin som functiontyp.");
                            Console.Write("Mata in functiontyp av kläder: ");
                            string userFunction = Console.ReadLine();
                            if (userFunction == "sport" || userFunction == "barn" || userFunction == "fin" || userFunction == "hus")
                            {
                                clothing.function_type = userFunction;
                                checkFunction = false;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Fel! Du får skriva in bara sport, barn, fin och hus");
                                Console.WriteLine("Läsa noga instruktioner igen!");
                            }
                        }

                        /*Console.WriteLine();
                        Console.WriteLine("Enligt function kan kläder vanligen delas i 4 kategorien.");
                        Console.WriteLine("Nämligen sport, barn, fin och hus.");
                        Console.WriteLine("Exempelvis lakan tillhör hus kategori.");
                        Console.WriteLine("Om det är vardaglig kläder skriv in gärna fin som functiontyp.");
                        Console.Write("Mata in functiontyp av kläder: ");
                        string userFunction = Console.ReadLine();
                        clothing.function_type = userFunction;*/

                        //Objekter Clothing skapas till en list
                        laundry.Add(clothing);

                        break;

                    case (2):
                        ShowClothing(laundry);
                        break;

                    case (3):
                        //Skapa en lista för att lagra objekter av klass ClothingWithIndex
                        List<ClothingWithIndex> currentLaundry = new List<ClothingWithIndex>();
                        for (int i = 0; i < laundry.Count; i++)
                        {
                            int index = programList.ProgramSearch(laundry[i]);
                            ClothingWithIndex clothingWithIndex = new ClothingWithIndex();
                            clothingWithIndex.clothing = laundry[i];
                            clothingWithIndex.index = index;
                            currentLaundry.Add(clothingWithIndex);
                        }
                        //Skapa en sorterad enligt index list med objekter av klass clothingWithIndex
                        List<ClothingWithIndex> sortedList = Sort(currentLaundry);

                        //Får inställnigar
                        Install finalInstall = programList.GetInstallByIndex(sortedList[0].index);
                        Console.WriteLine("Rekommenderade inställningar är " + finalInstall.temprature + " grader och " + finalInstall.centrifugation + " centrifigurering hastighet");
                        Console.WriteLine("Om alla kläder som du vill tvätta har samma färg du kan tvätta allt med inställningar du får");

                        break;
                    case (4):
                        for (int i = 0; i < laundry.Count; i++)
                        {
                            int index = programList.ProgramSearch(laundry[i]);
                            Install finalInstallUnique = programList.GetInstallByIndex(index);
                            int n = i + 1;
                            Console.WriteLine(n + " " + laundry[i].name + " " + finalInstallUnique.temprature + " grader och " + finalInstallUnique.centrifugation + " centrifigurering hastighet");
                        }
                        break;

                    case (5):
                        //Slut av programmet
                        check = false;

                        break;

                    default:
                        //Meddelande om man skriv in något annat tangent som finns ej i menyn
                        Console.WriteLine();
                        Console.WriteLine("Fel! Du får mata in bara tre tal från 1 till 3!");
                        break;
                }
            }

            //Avlutningvis meddelande
            Console.WriteLine();
            Console.WriteLine("Hej då! Ha en trevlig tvätt!!!");
            Console.ReadKey();
        }
    }
}

