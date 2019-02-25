using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class BolleHeaven
	{
		private List<Jingo> john;

		private Bongo jiggy;

		private Form1 form1;

		public BolleHeaven(Form1 form)
		{
			form1 = form;
			form1.explodeMe(1200, 1000);
			if (!form1.timer1IsRunning)
			{
				form1.SpellOut(form1.junkie.Next(3, 6));
				form1.timer1.Start();
				form1.timer1IsRunning = true;
			}
		}

		public BolleHeaven(List<Jingo> john)
		{
			this.john = john;
		}

		public int bolledej(int x, int y)
		{
			return 400300 + x - y;
		}

		public string vowel(int joy, Random jiggo)
		{
			string[] array = callShuffle(new string[14]
			{
				"a",
				"e",
				"ol",
				"i",
				"y",
				"iv",
				"af",
				" ",
				"up",
				"ed",
				"an",
				"ka",
				"ti",
				"mu"
			});
			return array[jiggo.Next(14)];
		}

		public string jongoNese()
		{
			string[] array = callShuffle(new string[33]
			{
				"ka",
				"ra",
				"te",
				"o",
				"ke",
				"to",
				"yo",
				"ta",
				"mit",
				"su",
				"bi",
				"shi",
				"so",
				"ny",
				"hi",
				"ni",
				"hon",
				"na",
				"rin",
				"go",
				"ta",
				"ha",
				"sei",
				"sen",
				"na",
				"ro",
				"san",
				"ke",
				"ki",
				"han",
				"sho",
				"ten",
				"gu"
			});
			return array[form1.junkie.Next(33)];
		}

		public string wordUP()
		{
			string text = "";
			for (int i = 0; i < form1.junkie.Next(7); i++)
			{
				text += jongoNese();
			}
			return text;
		}

		public string shisLak()
		{
			string[] array = callShuffle(new string[33]
			{
				"sha",
				"ra",
				"la",
				"ka",
				"shash",
				"ki'",
				"ral",
				"tal",
				"mar",
				"kel",
				"'",
				"kar",
				"shil",
				"lil",
				"ni",
				"ka",
				"hat",
				"ta",
				"wha",
				"ja",
				"te",
				"-",
				"lar",
				"si",
				"gar",
				"fro",
				"lin",
				"kesh",
				"kunth",
				"tcha",
				"ras",
				"hesh",
				"tarl"
			});
			return array[form1.junkie.Next(33)];
		}

		public string numbersRandom()
		{
			string[] array = callShuffle(new string[27]
			{
				"001",
				"2",
				"4",
				"56",
				"76",
				"223'",
				"90",
				",2",
				"24 5",
				"200",
				"23 4",
				"09",
				",345",
				"/74",
				"sinus0,04",
				"220",
				"tan4",
				"400",
				"cos3",
				"dx=",
				"yx",
				"[4]",
				"407,1",
				"30013x",
				"4*4*13",
				"-205",
				"500+2"
			});
			return array[form1.junkie.Next(27)];
		}

		public string programmingMadness()
		{
			string[] array = callShuffle(new string[19]
			{
				"new line",
				"break;",
				"if(!200<bongoLimit)",
				"switch(" + form1.junkie.Next(2, 10) + ")",
				"for(int i = 0; i < 50;i++)",
				"(random.Next(200))",
				"switch(new line)",
				"Bongo(int i, double vector, Mood honey)",
				"void newLine()",
				"{void bongo200(int k, Math.sinus(random))}",
				"newLine(4)",
				"void madnessUp(Vector k, double size)",
				"ComboBox1.SelectMeNot = something",
				"Math.Tan(random.Next(joy))=='5,79$'",
				"Initialize()",
				"kk = something",
				"nokOmLivet = ViggoStuckenbergsLiv",
				"BørneLærdom(joyMadness viErTilGrin, nokOmLivet firehundrede)",
				"ViggoErEnMandFraVenstresOprindeligeTanke,firetotreViTællerOpAd"
			});
			return array[form1.junkie.Next(19)];
		}

		public string viErToDerSavnerDigHelle()
		{
			string text = "";
			for (int i = 0; i < form1.junkie.Next(7); i++)
			{
				text += programmingMadness();
			}
			return text;
		}

		public string bongoDrengenFraVanløse()
		{
			string text = "";
			for (int i = 0; i < form1.junkie.Next(7); i++)
			{
				text += numbersRandom();
			}
			return text;
		}

		public string testMeYO()
		{
			string text = "";
			for (int i = 0; i < form1.junkie.Next(7); i++)
			{
				text += shisLak();
			}
			return text;
		}

		public string constantIteration(int numberJoy, Random joy)
		{
			string[] array = callShuffle(new string[16]
			{
				"j",
				"k",
				"t",
				"s",
				"r",
				"v",
				" ",
				"n",
				"m",
				"p",
				"-",
				"\u00b4",
				"|",
				"3",
				"-4",
				"uo"
			});
			return array[joy.Next(16)];
		}

		private string[] callShuffle(string[] bonnysFornøjelse)
		{
			return bonnysFornøjelse;
		}

		public string gEn2Name(int lenght, Random pig)
		{
			switch (pig.Next(15))
			{
			case 0:
				return constantIteration(133, pig) + vowel(12, pig) + constantIteration(150, pig) + vowel(1400, pig) + constantIteration(132, pig);
			case 1:
				return vowel(21, pig) + constantIteration(951, pig) + constantIteration(391, pig) + vowel(5861, pig) + constantIteration(4851, pig);
			case 2:
				return constantIteration(124, pig) + constantIteration(135, pig) + vowel(146, pig) + vowel(61, pig) + constantIteration(13, pig);
			case 3:
				return constantIteration(186, pig) + vowel(153, pig) + constantIteration(55, pig) + constantIteration(561, pig) + vowel(351, pig);
			case 4:
				return constantIteration(186, pig) + vowel(153, pig) + constantIteration(55, pig) + constantIteration(561, pig) + vowel(351, pig) + vowel(153, pig) + constantIteration(561, pig);
			case 5:
				return vowel(153, pig) + constantIteration(186, pig) + constantIteration(55, pig) + constantIteration(186, pig) + vowel(153, pig) + vowel(153, pig) + constantIteration(561, pig) + constantIteration(561, pig);
			case 6:
				return constantIteration(186, pig) + vowel(153, pig) + constantIteration(55, pig) + constantIteration(561, pig) + vowel(351, pig) + vowel(351, pig);
			case 7:
				return constantIteration(951, pig) + vowel(21, pig) + constantIteration(391, pig) + constantIteration(4851, pig) + vowel(234, pig);
			case 8:
				return constantIteration(951, pig) + vowel(21, pig) + constantIteration(391, pig) + constantIteration(4851, pig) + vowel(5861, pig) + constantIteration(4851, pig);
			case 9:
				return constantIteration(951, pig) + vowel(21, pig) + constantIteration(391, pig) + constantIteration(4851, pig) + vowel(5861, pig);
			case 10:
				return constantIteration(951, pig) + vowel(21, pig) + vowel(5861, pig);
			default:
				return constantIteration(364, pig) + vowel(136, pig) + constantIteration(153, pig);
			}
		}

		internal static Jongo bongo(int p, Afmagt afmagt)
		{
			throw new NotImplementedException();
		}

		public string[] gEn2NameArray(int lenght, Random pig)
		{
			List<string> list = new List<string>();
			switch (pig.Next(15))
			{
			case 0:
				list.Add(constantIteration(133, pig));
				list.Add(vowel(12, pig));
				list.Add(constantIteration(150, pig));
				list.Add(vowel(1400, pig));
				list.Add(constantIteration(132, pig));
				return list.ToArray();
			case 1:
				list.Add(vowel(21, pig));
				list.Add(constantIteration(951, pig));
				list.Add(constantIteration(391, pig));
				list.Add(vowel(5861, pig));
				list.Add(constantIteration(4851, pig));
				return list.ToArray();
			case 2:
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(135, pig));
				list.Add(vowel(146, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(13, pig));
				return list.ToArray();
			case 3:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				return list.ToArray();
			case 4:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				return list.ToArray();
			case 5:
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				return list.ToArray();
			case 6:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(vowel(61, pig));
				return list.ToArray();
			case 7:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				return list.ToArray();
			case 8:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				return list.ToArray();
			case 9:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				return list.ToArray();
			case 10:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(vowel(61, pig));
				return list.ToArray();
			default:
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				list.Add(constantIteration(124, pig));
				list.Add(constantIteration(124, pig));
				list.Add(vowel(61, pig));
				return list.ToArray();
			}
		}

		public string[] getSentenceVolaHovski(int lines, int words)
		{
			string[] array = new string[400];
			array[0] = "Der";
			array[1] = "var";
			array[2] = "engang";
			array[3] = "en";
			array[4] = "gammel";
			array[5] = "mand";
			array[6] = "han";
			array[7] = "hed";
			array[8] = "OlleBolle";
			array[9] = "fire";
			array[10] = "måneder";
			array[11] = "senere";
			array[12] = "gik";
			array[13] = "han";
			array[14] = "i";
			array[15] = "skole";
			array[16] = "maden";
			array[17] = "var";
			array[18] = "tam";
			array[19] = "men";
			array[20] = "nem";
			array[21] = "at";
			array[22] = "få";
			array[23] = "ned";
			array[24] = "to";
			array[25] = "sætninger";
			array[26] = "blev";
			array[27] = "til";
			array[28] = "i";
			array[29] = "hans";
			array[30] = "skolegård";
			array[31] = "fire";
			array[32] = "mennesker";
			array[33] = "så";
			array[34] = "til";
			array[35] = "mens";
			array[36] = "han";
			array[37] = "spiste";
			array[38] = "leverpostej";
			array[39] = "det";
			array[40] = "var";
			array[41] = "en";
			array[42] = "dejlig";
			array[43] = "dag";
			array[44] = "hunden";
			array[45] = "gik";
			array[46] = "tur";
			array[47] = "med";
			array[48] = "sig";
			array[49] = "selv";
			array[50] = "en";
			array[51] = "dag";
			array[52] = "gik";
			array[53] = "det";
			array[54] = "op";
			array[55] = "for";
			array[56] = "ham";
			array[57] = "mennesker";
			array[58] = "stod";
			array[59] = "i";
			array[60] = "kø";
			array[61] = "for";
			array[62] = "at";
			array[63] = "sige";
			array[64] = "goddag";
			array[65] = "flere";
			array[66] = "kom";
			array[67] = "til";
			array[68] = "en";
			array[69] = "dag";
			array[70] = "blev";
			array[71] = "det";
			array[72] = "mange";
			array[73] = "fornøjelser";
			array[74] = "kom";
			array[75] = "og";
			array[76] = "gik";
			array[77] = "klokken";
			array[78] = "blev";
			array[79] = "sent";
			array[80] = "men";
			array[81] = "han";
			array[82] = "var";
			array[83] = "vågen";
			string[] array2 = new string[lines];
			for (int i = 0; i < lines; i++)
			{
				string text = "";
				int num = 0;
				for (int j = 0; j < form1.junkie.Next(words) + 4; j++)
				{
					if (num >= 6)
					{
						text += ", ";
						num = form1.junkie.Next(3);
					}
					text = text + array[form1.junkie.Next(84)] + " ";
					num++;
				}
				array2[i] = text;
			}
			return array2;
		}

		public string[] getSentenceVolaHovskiPovski(int lines, int words)
		{
			new List<string>();
			string str = "Der var engang en smuk tusse den hed alfred og boede i en skov skoven lå mellem to bjerge og midt imellem løb en flod";
			str += " I dalen boede fem tosser den ene havde en datter så smuk hun hed Magdalene hendes yndlingsdyr var en enhjørning som viste sig i en lysning";
			str += " i dalen to mennesker troede de ville have hævn og det var den rene sandhed godt nok sagde jesus en masse om kærlighed";
			string str2 = "Fire mennesker troede på Jesus men så kom en alien og sagde goddag på fransk han hed ipswitch og handler om";
			str2 += " tid og sted to patroner til du forstår det handler om divine intervention betyder på fransk at gud er med os";
			str2 += " hvad enten vi tror eller ej sådan er livet min ven vi handler i god tro altid vi er guds efterkommere";
			string str3 = "vi har en tid for os selv musikken er mærkelig og livet går vidre frøen bor i os alle alle er guds børn forstå mig ret";
			str3 += " sådan er livet vi moser med trends der får os i uføre hvem skal overtage showet det er en tanke fra det vilde vest vi er trætte af at";
			str3 += " forstå hvad der sker i fremtiden rummet er uendeligt vi har ingen chance for at begå os rigtigt det er en tanke fra de varme lande at vi er";
			str3 += " vanskelige at forstå sådan er virkeligheden vi elsker os selv og det ukendte";
			string str4 = "det hele handler om et grundstof så tungt at det ikke kan beskrives forskellige variationer af protoner og neutroner giver isotoper af en kerne";
			str4 += " fyldt med interaktioner tyngdeloven holder sammen på partiklerne som kredser om hinanden flere forskellige variationer giver forskellige muligheder at";
			str4 += " kombinere med hvem ville tro det var nemt at skabe et grundstof som ikke findes endnu spændende sager forstå det handler om at give rumforskning en chance";
			str4 += " for at begå sig i universet på lang sigt hvem vil holde på en hemmelighed så tung så længe";
			string str5 = "Der gik en mand i skolen han hed Olebole han var fjorten år og så kører vi langsomt gik det op for ham han ikke var";
			str5 += " den eneste der gik med bukserne om livet han brugte meget tid på at inkassere en formue fra Bent lige meget hvad gik han op i taskerne på kvinderne men han var ikke køn";
			str5 += " skønt hans mor havde sagt det livet er for kort til utroskab min ven sådan drejer det sig om livet her på klostret";
			str5 += " hvad jeg ikke vidste var han bed mig i underbukserne for trettende gang nok om det han hed vist bare GummiHans";
			string str6 = "Fjorten år på skole gangen og han var lige fyldt femten så fik han oprejsning for sine stylter men troede ikke sine egne øjne han var blind";
			str6 += " af raseri på fjortende år gik han ind til lærerinden og fik en guldkant på æblet for at ikke sige lyssky affærer med hans kone som var viet med HansPeter";
			str6 += " kom meget ud af fjerde sal vi vidste ikke hvad der var galt han sagde bare avs og sådan noget svin siger jeg nok om det han var sød nok";
			str6 += " i hans lede armhule dø forbistrede svinekam du nakker dig selv imorgen og så gik han hjem tulle blev træt af livet og sagde op for syttende gang nok om det han hed bare Bjarne";
			string str7 = "Vi hedder ikke det samme siger morfar vi kommer fra anus på en giraf så kan hun lære det vi spiser ikke pinochiokugler her i livet nok om svanset tanker";
			str7 += " vi myldrer frem i mørket siger jeg dig mørkekammer er jeg ikke heldig var hendes begrundelse nok om Tove hun var i sin hjerne for pokker hvor lyder det godt";
			str7 += " mormor vi fejrer dig en anden dag med lys og lagkage helt din egen fødselsdag nok om Britta vi heiler ikke om livet sagde SvenOtto fire pindsvin har taget min nadver og";
			str7 += " jeg hader dig for det det pacifist perker bølle når truer du mig på livet så får du svansen om halsen din bøttesvensker vi går lige op i himlen sagde JytteMor";
			string str8 = "BøtteSvensker er godt for noget vi regner med det tager sin tid at lære noget om livet. Jeg væmmes ved dine tanker Olfert ikke helt vel nå ikke hvem sagde noget om vi kan ikke mere Ole";
			str8 += " du er aldrig med til noget imorgen det siger jeg dig for faen er vi aldrig hjemme hos Morten og Lisbeth mere det var da ærgerligt ikke sandt vi har heller ingen penge på kontoen SvendBent";
			str8 += " hvorfor falder æblet aldrig helt ind til stammen far det skal jeg sige dig OleBole du har ingen sovs i kartoflerne derfor må du ikke lege med Britta Jørgensen kom nu videre i fandte ikke mine";
			str8 += " hylere igen vel hvorfor er der ingen der kommentere på livet imorgen er jeg træt af at lege med mig selv fordi fjorten unger ikke vil have pis på fingrene i har vel ikke set Jørgens undertrusser";
			string str9 = "Hvad er meningen med livet Svenna du tror vel ikke jeg har taget dine penge til overs for situationen imorgen giver jeg is på torvet ikke. Vi arbejder på torsdag og sover på fredag, sådan har det altid";
			str9 += " været min ven, vi skal ikke sende soldater til Irak fordi de er dumme og grimme for dig selv ikke sandt leg med situationsfornemmelsen HansPeter Du jo ikke fredelig vel, de andre kan ikke li dig fordi du er";
			str9 += " pafid i dit udtryk som sådan siger det hele ikke smovse på tæppet Lis Andersen det er ikke god for noget Jeg skal sige dig sådan er jeg født med en perle om halsen De trykker på knappen til selvmord imorgen";
			str9 += " Vi arbejder på udtryk der kan udvaske enhver tvivl om de vil sig selv til fanden for fødselsdag ikke noget hår i maskinen kære Lisbeth Vi tørrer ikke dit hår i maskinen vel nok om det vi har knapper i universets tanker";
			string text = "Kom ind og lyt med hvis du tør siger jeg der er tanker fra en fjern planet i gære nok er tretten år fordi vi modnes med alderen det er ligegyldigt om du er ung, smuk eller tilpas ligeglad hvad der rører sig";
			str9 += " i din pafide tanke du minder om en frø der kan hampe dig tilbage i tiden du går i sko der er for små til dig selv ikke sandt nok skal vi se på om du er med på at lege lærdom fra dig vi ønsker ikke at du skal viske dig ud";
			str9 += " men du forstår ikke at vi er til at beregne på nok er jeg modig men jeg tror ikke du er vild med mig i længden vi ser om du kan afkode mit sprog senere spasser forstå jeg ikke er til at give dig en røvfuld når jeg går herfra";
			str9 += " ";
			string text2 = "Nok er vi venner men jeg er ikke din fadervor vel gå hjem og tro vi kommer ind og tæver din søster væk hun tror du er til at forstå men ikke mig jeg viste dig en hamper form men nu er du væk imorgen tro du ikke er til at forstå jeg";
			str9 += " siger mig selv op hvis du tør begå mig en gang til vi kommer til at tro du ikke er væmmelig men du er nok en ost af kaliber ikke hvor om alt er tro jeg ikke du skal vise mig dit ansigt tilbagestående organisme vi er til at blive syge i bærret";
			str9 += " over nok skal vi hylde din mor men du er ikke forbi endnu vel kom an hvis du tør ingen forstår du ikke skal pisse mig i graven dit bæst vi er til at blive ligegyldige over nok er mit udtryk lidt hampert men du vender dig i graven for sidste gang det siger jeg dig ";
			str9 += " for vi er med på en leg, ikke mere snak vel gå væk og tro du er bedre end mig hvis du tør siger jeg din svamp tusse forstå vi ikke ligner hinanden på nogen måde vi er fra forskellige tanker om det nok skal vi se om du tør lægge dig ud med svampen fra mars";
			string text3 = "Du skal til at ligne en der er fra en anden dimension ikke hvorfor er der venner på i morgen er der tanker om du formerer dig aligevel trods alt godt så du er ikke med på legen vel nok om to somme tanker i morgen er vi til at blive grint af";
			str9 += " i takt med vi mener alt skal være os gyldige aligevel ikke nok skal du have en tanke fra Morten ikke Den er helt personlig i sit udtryk fatter jeg ikke med på om hun ser sig i spejlet tosse kom ind og men jeg har tanker om dig din perker ikke";
			str9 += " nok er vi ligeglade om du mener dit eller dat dit lokumshor er lige til at blive spasser af kom ind og men jeg er den bedste til sommer så ser vi om du er til at fatte på sangen er nok en hamper ide men du luller dig ind i et slør af skandaler om";
			str9 += " hvordan det går dig ikke fordi du er ude og mene alt er til at fatte du ikke skal begå mig med tanker med Gud når alt kommer til alt så er du lige fra det værste udskud i min bog";
			string text4 = "Sæt dig ind og men et eller andet ligegyldigt så kommer tissetrold og tager et skud snakker i om at blive sindsyge i jeres familie eller hvad du er umanerlig ligegyldig i mit udtryk er du ikke til at forstå aligevel er jeg glad for du mener mig en tanke ";
			str9 += " det handler om vi ikke er til at blive ligeglade om nok er jeg ven af folket men ikke mere end jeg siger til dig vi er forstå det ikke helt lige meget om du skaber dig når jeg sover vel det er det jeg mener om det for vi er alle tro mod Herren i alles forstand";
			str9 += " skal det vide sig du er til at fatte når du siger kom ind med en tanke der så stor der ingen plads til bekymring fra min side du er en mand der viseluller dig ind i tanker om alt er godt imorgen ikke sæt dig til at fundere om jeg er til grin i min verden er du pisse hamrende ligeglad om jeg fatter du ikke skal sige til";
			str9 += " vi er ved at blive hampre af fat du ikke skal sige til mig jeg er dårlig når du selv er så svag i udtrykket nok skal vi sige ting om hinanden men du er til at fatte ikke mere end du tror om mig er du perker dit svin send dig selv en tanke om jeg forsvinder til sommer det er Mortens lalleglade profil du troller på";
			string[] array;
			switch (form1.junkie.Next(13))
			{
			case 0:
				array = str.Split(' ');
				break;
			case 1:
				array = str2.Split(' ');
				break;
			case 2:
				array = str3.Split(' ');
				break;
			case 3:
				array = str4.Split(' ');
				break;
			case 4:
				array = str5.Split(' ');
				break;
			case 5:
				array = str6.Split(' ');
				break;
			case 6:
				array = str7.Split(' ');
				break;
			case 7:
				array = str8.Split(' ');
				break;
			case 8:
				array = str9.Split(' ');
				break;
			case 9:
				array = text.Split(' ');
				break;
			case 10:
				array = text2.Split(' ');
				break;
			case 11:
				array = text3.Split(' ');
				break;
			case 12:
				array = text4.Split(' ');
				break;
			default:
				array = str.Split(' ');
				break;
			}
			string[] array2 = new string[lines];
			for (int i = 0; i < lines; i++)
			{
				string text5 = "";
				int num = 0;
				for (int j = 0; j < form1.junkie.Next(words) + 4; j++)
				{
					if (num >= 6)
					{
						text5 += ", ";
						num = form1.junkie.Next(3);
					}
					text5 = text5 + array[form1.junkie.Next(array.Length)] + " ";
					num++;
				}
				array2[i] = text5;
			}
			return array2;
		}
	}
}
