using ConsoleApp3.DB;

Console.WriteLine("AS");

DebtorDBContext dbContext = new DebtorDBContext();

//var de = new List<DebtorsEntity> {
//            new DebtorsEntity("Shirley T. Qualls", DateTime.Parse("March 30, 1932"), "530-662-7732", "ShirleyTQualls@teleworm.us", "3565 Eagles Nest Drive Woodland, CA 95695", 2414),
//            new DebtorsEntity("Danielle W. Grier", DateTime.Parse("October 18, 1953"), "321-473-4178", "DanielleWGrier@rhyta.com", "1973 Stoneybrook Road Maitland, FL 32751", 3599),
//            new DebtorsEntity("Connie W. Lemire", DateTime.Parse("June 18, 1963"), "828-321-3751", "ConnieWLemire@rhyta.com", "2432 Hannah Street Andrews, NC 28901", 1219),
//            new DebtorsEntity("Coy K. Adams", DateTime.Parse("March 1, 1976"), "410-347-1307", "CoyKAdams@dayrep.com", "2411 Blue Spruce Lane Baltimore, MD 21202", 3784),
//            new DebtorsEntity("Bernice J. Miles", DateTime.Parse("June 1, 1988"), "912-307-6797", "BerniceJMiles@armyspy.com", "4971 Austin Avenue Savannah, GA 31401", 4060),
//            new DebtorsEntity("Bob L. Zambrano", DateTime.Parse("February 28, 1990"), "706-446-1649", "BobLZambrano@armyspy.com", "2031 Limer Street Augusta, GA 30901", 6628),
//            new DebtorsEntity("Adam D. Bartlett", DateTime.Parse("May 6, 1950"), "650-693-1758", "AdamDBartlett@rhyta.com", "2737 Rardin Drive San Jose, CA 95110", 5412),
//            new DebtorsEntity("Pablo M. Skinner", DateTime.Parse("August 26, 1936"), "630-391-2034", "PabloMSkinner@armyspy.com", "16 Fraggle Drive Hickory Hills, IL 60457", 11097),
//            new DebtorsEntity("Dorothy J. Brown", DateTime.Parse("July 9, 1971"), "270-456-3288", "DorothyJBrown@rhyta.com", "699 Harper Street Louisville, KY 40202", 7956),
//            new DebtorsEntity("Larry A. Miracle", DateTime.Parse("May 22, 1998"), "301-621-3318", "LarryAMiracle@jourrapide.com", "2940 Adams Avenue Columbia, MD 21044", 7150),
//            new DebtorsEntity("Donna B. Maynard", DateTime.Parse("January 26, 1944"), "520-297-0575", "DonnaBMaynard@teleworm.us", "4821 Elk Rd Little Tucson, AZ 85704", 2910),
//            new DebtorsEntity("Jessica J. Stoops", DateTime.Parse("April 22, 1989"), "360-366-8101", "JessicaJStoops@dayrep.com", "2527 Terra Street Custer, WA 98240", 11805),
//            new DebtorsEntity("Audry M. Styles", DateTime.Parse("February 7, 1937"), "978-773-4802", "AudryMStyles@jourrapide.com", "151 Christie Way Marlboro, MA 01752", 1001),
//            new DebtorsEntity("Violet R. Anguiano", DateTime.Parse("November 4, 1958"), "585-340-7888", "VioletRAnguiano@dayrep.com", "1460 Walt Nuzum Farm Road Rochester, NY 14620", 9128),
//            new DebtorsEntity("Charles P. Segundo", DateTime.Parse("October 21, 1970"), "415-367-3341", "CharlesPSegundo@dayrep.com", "1824 Roosevelt Street Fremont, CA 94539", 5648),
//            new DebtorsEntity("Paul H. Sturtz", DateTime.Parse("September 15, 1944"), "336-376-1732", "PaulHSturtz@dayrep.com", "759 Havanna Street Saxapahaw, NC 27340", 10437),
//            new DebtorsEntity("Doris B. King", DateTime.Parse("October 10, 1978"), "205-231-8973", "DorisBKing@rhyta.com", "3172 Bedford Street Birmingham, AL 35203", 7230),
//            new DebtorsEntity("Deanna J. Donofrio", DateTime.Parse("April 16, 1983"), "952-842-7576", "DeannaJDonofrio@rhyta.com", "1972 Orchard Street Bloomington, MN 55437", 515),
//            new DebtorsEntity("Martin S. Malinowski", DateTime.Parse("January 17, 1992"), "765-599-3523", "MartinSMalinowski@dayrep.com", "3749 Capitol Avenue New Castle, IN 47362", 1816),
//            new DebtorsEntity("Melissa R. Arner", DateTime.Parse("May 24, 1974"), "530-508-7328", "MelissaRArner@armyspy.com", "922 Hill Croft Farm Road Sacramento, CA 95814", 5037),
//            new DebtorsEntity("Kelly G. Hoffman", DateTime.Parse("September 22, 1969"), "505-876-8935", "KellyGHoffman@armyspy.com", "4738 Chapmans Lane Grants, NM 87020", 7755),
//            new DebtorsEntity("Doyle B. Short", DateTime.Parse("June 15, 1986"), "123-456-7890", "DoyleBShort@teleworm.us", "124 Wood Street Saginaw, MI 48607", 11657),
//            new DebtorsEntity("Lorrie R. Gilmore", DateTime.Parse("December 23, 1960"), "724-306-7138", "LorrieRGilmore@teleworm.us", "74 Pine Street Pittsburgh, PA 15222", 9693),
//            new DebtorsEntity("Lionel A. Cook", DateTime.Parse("April 16, 1972"), "201-627-5962", "LionelACook@jourrapide.com", "29 Goldleaf Lane Red Bank, NJ 07701", 2712),
//            new DebtorsEntity("Charlene C. Burke", DateTime.Parse("January 18, 1990"), "484-334-9729", "CharleneCBurke@armyspy.com", "4686 Renwick Drive Philadelphia, PA 19108", 4016),
//            new DebtorsEntity("Tommy M. Patton", DateTime.Parse("June 30, 1981"), "774-571-6481", "TommyMPatton@rhyta.com", "748 Rockford Road Westborough, MA 01581", 349),
//            new DebtorsEntity("Kristin S. Bloomer", DateTime.Parse("June 16, 1944"), "443-652-0734", "KristinSBloomer@dayrep.com", "15 Hewes Avenue Towson, MD 21204", 9824),
//            new DebtorsEntity("Daniel K. James", DateTime.Parse("November 10, 1997"), "801-407-4693", "DanielKJames@rhyta.com", "3052 Walton Street Salt Lake City, UT 84104", 8215),
//            new DebtorsEntity("Paula D. Henry", DateTime.Parse("September 6, 1976"), "618-378-5307", "PaulaDHenry@rhyta.com", "3575 Eagle Street Norris City, IL 62869", 5766),
//            new DebtorsEntity("Donna C. Sandoval", DateTime.Parse("December 13, 1947"), "540-482-5463", "DonnaCSandoval@rhyta.com", "675 Jehovah Drive Martinsville, VA 24112", 8363),
//            new DebtorsEntity("Robert T. Taylor", DateTime.Parse("August 17, 1932"), "270-596-6442", "RobertTTaylor@armyspy.com", "2812 Rowes Lane Paducah, KY 42001", 7785),
//            new DebtorsEntity("Donna W. Alamo", DateTime.Parse("December 9, 1948"), "978-778-2533", "DonnaWAlamo@teleworm.us", "4367 Christie Way Marlboro, MA 01752", 10030),
//            new DebtorsEntity("Amy R. Parmer", DateTime.Parse("May 19, 1995"), "480-883-4934", "AmyRParmer@armyspy.com", "85 Elmwood Avenue Chandler, AZ 85249", 5347),
//            new DebtorsEntity("Newton K. Evans", DateTime.Parse("October 8, 1986"), "303-207-9084", "NewtonKEvans@rhyta.com", "3552 Columbia Road Greenwood Village, CO 80111", 9838),
//            new DebtorsEntity("Kathleen C. Chaney", DateTime.Parse("January 5, 1949"), "605-245-3513", "KathleenCChaney@rhyta.com", "316 Elsie Drive Fort Thompson, SD 57339", 1672),
//            new DebtorsEntity("Manuel C. Johnson", DateTime.Parse("February 23, 1957"), "606-247-2659", "ManuelCJohnson@jourrapide.com", "4146 May Street Sharpsburg, KY 40374", 9195),
//            new DebtorsEntity("Carla A. Creagh", DateTime.Parse("November 21, 1988"), "614-307-8974", "CarlaACreagh@dayrep.com", "3106 Bates Brothers Road Columbus, OH 43215", 11271),
//            new DebtorsEntity("Norma M. New", DateTime.Parse("May 18, 1988"), "857-492-8703", "NormaMNew@jourrapide.com", "965 Metz Lane Woburn, MA 01801", 9761),
//            new DebtorsEntity("Roy D. Green", DateTime.Parse("January 27, 1983"), "308-340-5981", "RoyDGreen@jourrapide.com", "401 Romrog Way Grand Island, NE 68801", 10771),
//            new DebtorsEntity("Cristy J. Jensen", DateTime.Parse("November 2, 1935"), "440-626-9550", "CristyJJensen@jourrapide.com", "2177 Harley Vincent Drive Cleveland, OH 44113", 5205),
//            new DebtorsEntity("Nancy J. Fergerson", DateTime.Parse("June 10, 1993"), "219-987-8498", "NancyJFergerson@dayrep.com", "3584 Jadewood Drive Demotte, IN 46310", 1276),
//            new DebtorsEntity("Dave N. Rodriguez", DateTime.Parse("January 21, 1938"), "214-540-2499", "DaveNRodriguez@rhyta.com", "1890 Poco Mas Drive Dallas, TX 75247", 9132),
//            new DebtorsEntity("James E. Denning", DateTime.Parse("May 4, 1988"), "504-289-8640", "JamesEDenning@jourrapide.com", "1444 Rose Avenue Metairie, LA 70001", 8176),
//            new DebtorsEntity("Richard M. Thomas", DateTime.Parse("February 13, 1972"), "510-735-3359", "RichardMThomas@jourrapide.com", "4454 Green Avenue Oakland, CA 94609", 7875),
//            new DebtorsEntity("Lakisha R. Forrest", DateTime.Parse("December 1, 1973"), "334-830-1181", "LakishaRForrest@armyspy.com", "3121 Quarry Drive Montgomery, AL 36117", 3088),
//            new DebtorsEntity("Pamela H. Beauchamp", DateTime.Parse("November 20, 1959"), "801-559-6347", "PamelaHBeauchamp@jourrapide.com", "3239 Tori Lane Salt Lake City, UT 84104", 6588)
//        };

//foreach (var a in de)
//{
//    dbContext.Debtors.Add(a);
//}
//dbContext.SaveChanges();



//  2) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag
var domains = new List<string>() { "dayrep.com", "rhyta.com" };
bool func2(DebtorsEntity a)
{
    if (a.Email.EndsWith(domains[0]) || a.Email.EndsWith(domains[1]))
        return true;
    else return false;
}
var list2 = dbContext.Debtors.Where(func2);
foreach (var a in list2)
    Console.WriteLine(a.Email);
//  3) Yashi 26-dan 36-ya qeder olan borclulari cixartmag
bool func3(DebtorsEntity a)
{
    DateTime d = DateTime.Now;
    int age = d.Year - a.BirthDay.Year;
    if (age >= 26 && 36 >= age)
        return true;
    else return false;
}
var list3 = dbContext.Debtors.Where(func3);
Console.WriteLine("\n\n\n\n");
foreach (var a in list3)
    Console.WriteLine(a.BirthDay);
//  4) Borcu 5000-den cox olmayan borclularic cixartmag
bool func4(DebtorsEntity a)
{
    double borc = a.Debt;
    if (5000 > borc)
        return true;
    else return false;
}
var list4 = dbContext.Debtors.Where(func4);
Console.WriteLine("\n\n\n\n");
foreach (var a in list4)
    Console.WriteLine(a.Debt);

//  5) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2-den cox 7 reqemi olan borclulari cixartmaq
bool func5(DebtorsEntity a)
{
    string temizad = a.FullName.Replace(" ", "");
    int simvolsayiad = temizad.Length;
    if(simvolsayiad > 18)
    {
        int count = 0;
        foreach(var z in a.Phone)
        {
            if (z == '7')
                count += 1;
        }
        if (count >= 2) return true;
    }
    return false;
}
var list5 = dbContext.Debtors.Where(func5);
Console.WriteLine("\n\n\n\n");
foreach (var a in list5)
    Console.WriteLine(a.FullName);

//  7) Qishda anadan olan borclulari cixardmaq
bool func7(DebtorsEntity a)
{
    var birth = a.BirthDay;
    if (birth.Month == 12 || birth.Month == 1 || birth.Month == 2)
        return true;
    else return false;
}
var list7 = dbContext.Debtors.Where(func7);
Console.WriteLine("\n\n\n\n");
foreach (var a in list7)
    Console.WriteLine(a.BirthDay);
//  8) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek
double ortalama = dbContext.Debtors.Average(a => a.Debt);
var list8 = dbContext.Debtors.OrderBy(a => a.FullName).OrderByDescending(a=>a.Debt).Where(a=>a.Debt > ortalama);
Console.WriteLine("\n\n\n\n Ortalama borc: " + ortalama);
foreach(var a in list8)
    Console.WriteLine(a.FullName + " => " + a.Debt);
//  9) Telefon nomresinde 8 olmayan borclularin yalniz familyasin, yashin ve umumi borcun meblegin cixarmaq
bool func9(DebtorsEntity a)
{
    var phone = a.Phone;
    foreach(var b in phone)
    {
        if (b == '8')
            return false;
    }
    return true;
}
var list9 = dbContext.Debtors.Where(func9);
Console.WriteLine("\n\n\n\n");
foreach (var a in list7)
{
    string[] parts = a.FullName.Split();
    DateTime today = DateTime.Now;
    int age = today.Year - a.BirthDay.Year;
    Console.WriteLine(parts[1] + " => "+ age + " => " + a.Debt);
}

//  11)Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek
bool func11(DebtorsEntity a)
{
    var fullname = a.FullName;
    List<char> ch = new List<char>();
    foreach (var b in fullname)
    {
        if (b != ' ')
        {
            if (!ch.Contains(b))
                ch.Add(b);
            else
            {
                ch.Add(b);
                if (ch.Count(c => c == b) >= 3)
                    return true;
            }
        }
    }
    return false;
}
var list11 = dbContext.Debtors.Where(func11).OrderBy(a=>a.FullName);
Console.WriteLine("\n\n\n\n as");
foreach (var a in list11)
    Console.WriteLine(a.FullName);

//  14)Borcu en boyuk olan 5 borclunun siyahisini cixartmaq
Console.WriteLine("\n\n\n\n");
var list14 = dbContext.Debtors.OrderByDescending(a=>a.Debt).Take(5).ToList();
foreach(var a in list14)
    Console.WriteLine(a.FullName+" => "+a.Debt);
//  15)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq

var umumiborc = dbContext.Debtors.Sum(a => a.Debt);
Console.WriteLine("\n\n\n\n Umumi borc:" + umumiborc + " $");
//  16)2ci dunya muharibesin gormush borclularin siyahisi cixartmaq
bool func16(DebtorsEntity a)
{
    var birth = a.BirthDay;
    if (birth.Year <= 1944)
        return true;
    else return false;
}
var list16 = dbContext.Debtors.Where(func16);
Console.WriteLine("\n\n\n\n");
foreach (var a in list16)
    Console.WriteLine(a.BirthDay);
//  18)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq
bool func18(DebtorsEntity a)
{
    string phonenumber = a.Phone;
    List<char> ch = new List<char>();
    foreach(var b in phonenumber)
    {
        if (b != '-')
        {
            if (!ch.Contains(b))
                ch.Add(b);
            else return false;
        }
    }
    return true;
}
var list18 = dbContext.Debtors.Where(func18);
Console.WriteLine("\n\n\n\n");
foreach (var a in list18)
    Console.WriteLine(a.FullName+ " => "+ a.Phone +" => "+a.Debt);

//  19)Tesevvur edek ki, butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler. Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq

bool func19(DebtorsEntity a)
{
    var birth = a.BirthDay;
    var datenow = DateTime.Now;
    var debt = a.Debt;

    if (birth.Month > datenow.Month)
    {
        int monthleft = datenow.Month - birth.Month;
        if (debt - (monthleft * 500) <= 0)
            return true;
    }
    else
    {
        DateOnly nextbday = new DateOnly(datenow.Year + 1, birth.Month, birth.Day);
        int monthl = (nextbday.Year - datenow.Year) * 12 + nextbday.Month - datenow.Month;
        if (debt - (monthl * 500) <= 0)
            return true;
    }
    return false;
}
var list19 = dbContext.Debtors.Where(func19);
Console.WriteLine("\n\n\n\n");
foreach (var a in list19)
    Console.WriteLine(a.FullName +" => "+ a.BirthDay +" => " + a.Debt);